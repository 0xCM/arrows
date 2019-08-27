//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Numerics;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using static System.Runtime.Intrinsics.X86.Pclmulqdq;
 
    using static zfunc;
    
    public enum ClMulMask : byte
    {
        X00 = 0x00,

        X01 = 0x01,

        X10 = 0x10,

        X11 = 0x11,
    }
    
    partial class dinx
    {                

        /// <summary>
        /// _mm_clmulepi64_si128
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static ushort clmul(byte lhs, byte rhs)
            => (ushort)clmul((uint)lhs, (uint)rhs);

        /// <summary>
        /// _mm_clmulepi64_si128
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static uint clmul(ushort lhs, ushort rhs)
            => (uint)clmul((uint)lhs, (uint)rhs);

        /// <summary>
        /// _mm_clmulepi64_si128
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static ulong clmul(uint lhs, uint rhs)
            => extract(CarrylessMultiply(Vec128.LoadScalar((ulong)lhs), Vec128.LoadScalar((ulong)rhs), 0x00), 0);

        [MethodImpl(Inline)]
        public static UInt128 clmul(ulong lhs, ulong rhs)
        {
            var a = Vec128.LoadScalar(lhs);
            var b = Vec128.LoadScalar(rhs);
            return CarrylessMultiply(a,b,0x00);
        }

        /// <summary>
        /// _mm_clmulepi64_si128
        /// Effects carryless multiplication on selected components
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="control">?</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> clmul(in Vec128<ulong> lhs, in Vec128<ulong> rhs, ClMulMask mask)
            =>  CarrylessMultiply(lhs, rhs, (byte)mask);
    
        /// <summary>
        /// Computes carry-less product variations for two source vectors
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="dst">Receives the results</param>
        [MethodImpl(Inline)]
        public static ref Vec512<ulong> clmul(in Vec128<ulong> lhs, in Vec128<ulong> rhs, out Vec512<ulong> dst)
        {
            dst = Vec512.FromParts(
                clmul(lhs, rhs, ClMulMask.X00), 
                clmul(lhs, rhs, ClMulMask.X01), 
                clmul(lhs, rhs, ClMulMask.X10), 
                clmul(lhs, rhs, ClMulMask.X11)
                );
            return ref dst;
        }


    }

}