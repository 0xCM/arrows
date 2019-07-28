//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static RegIdOffset;
    using static Pow2;
    using static zfunc;

    public static class GpRegOps
    {
        public static string Format<N,R>(this ref R register)
            where N : ITypeNat, INatPow2, new()
            where R : struct, ICpuReg<N>
        {
            ref var src = ref Unsafe.As<R,byte>(ref register);
            var dst = new byte[register.ByteSize];
            Unsafe.CopyBlock(ref dst[0], ref src, register.ByteSize);
            return dst.FormatHexBlocks();
        }

        /// <summary>
        /// Determines the bank address of an identified register
        /// </summary>
        /// <param name="src">The soruce register</param>
        [MethodImpl(Inline)]
        public static BankAddress Address(this GpRegId src)
            => new BankAddress
            {
                Offset = Bits.hi((ulong)src),
                Size = Bits.lo((ulong)src)            
            };
        
        /// <summary>
        /// Retrieves a reference to the first byte of a register bank
        /// </summary>
        /// <param name="bank">The source bank</param>
        [MethodImpl(Inline)]
        public static ref byte Head(this ref GpRegBank bank)
            => ref bank.al.al;

        [MethodImpl(Inline)]
        public static ref byte Head<T>(this ref T src)
            where T : struct
                => ref Unsafe.As<T, byte>(ref As.asRef(in src));

        /// <summary>
        /// Retrieves a memory reference determined by a bank address
        /// </summary>
        /// <param name="bank">The source bank</param>
        /// <param name="bank">The bank-relative address</param>
        [MethodImpl(Inline)]
        public static ref byte Ref(this ref GpRegBank bank, BankAddress address)
            => ref Unsafe.Add(ref bank.Head(), (int)address.Offset);


        [MethodImpl(Inline)]
        public static void CopyTo(this ref byte src, ref byte dst, ByteSize count)
            => Unsafe.CopyBlock(ref dst, ref src, count);
    }
}