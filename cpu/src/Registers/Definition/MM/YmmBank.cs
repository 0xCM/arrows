//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;
    using static As;

    [StructLayout(LayoutKind.Explicit, Size = SegLen*SegCount)]
    public unsafe struct YmmBank
    {
        public const int SegLen = 32;

        public const int SegCount = 16;

        const int HiPart = 16;


        /// <summary>
        /// Loads the registger from an unaligned memory reference
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe Vector256<T> LoadDqu<T>(in T src)
            where T: unmanaged
        {
            if(typeof(T) == typeof(sbyte))
               return generic<T>(Avx2.LoadDquVector256(constptr(in AsIn.int8(in src))));
            else if(typeof(T) == typeof(byte))
               return generic<T>(Avx2.LoadDquVector256(constptr(in AsIn.uint8(in src))));
            else if(typeof(T) == typeof(short))
               return generic<T>(Avx2.LoadDquVector256(constptr(in AsIn.int16(in src))));
            else if(typeof(T) == typeof(ushort))
               return generic<T>(Avx2.LoadDquVector256(constptr(in AsIn.uint8(in src))));
            else if(typeof(T) == typeof(int))
               return generic<T>(Avx2.LoadDquVector256(constptr(in AsIn.int32(in src))));
            else if(typeof(T) == typeof(uint))
               return generic<T>(Avx2.LoadDquVector256(constptr(in AsIn.uint32(in src))));
            else if(typeof(T) == typeof(long))
               return generic<T>(Avx2.LoadDquVector256(constptr(in AsIn.int64(in src))));
            else if(typeof(T) == typeof(ulong))
               return generic<T>(Avx2.LoadDquVector256(constptr(in AsIn.uint64(in src))));
            else if(typeof(T) == typeof(float))
               return generic<T>(Avx2.LoadVector256(constptr(in AsIn.float32(in src))));
            else if(typeof(T) == typeof(double))
               return generic<T>(Avx2.LoadVector256(constptr(in AsIn.float64(in src))));
            else
                throw unsupported<T>();
        }



        [FieldOffset(0)]        
        fixed byte Bytes[SegLen*SegCount];

        /// <summary>
        /// Returns a reference to the first register
        /// </summary>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public ref YMM First()
            => ref Unsafe.As<byte,YMM>(ref Bytes[0]);

        /// <summary>
        /// Returns a reference to an index-identified slot
        /// </summary>
        /// <param name="index">The zero-based register index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public ref YMM YmmSlot(int index)
            => ref Unsafe.Add(ref First(), index);

        /// <summary>
        /// Returns a reference to an XMM slot from the lower half of an identified YMM register
        /// </summary>
        /// <param name="index">The zero-based register index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public ref XMM XmmSlot(int index)
        {
            ref var y = ref YmmSlot(index);
            return ref  Unsafe.As<YMM,XMM>(ref y);            
        }

        [FieldOffset(0)]
        YMM ymm0;

        [FieldOffset(0)]
        XMM xmm0;

        [FieldOffset(SegLen)]
        YMM ymm1;

        [FieldOffset(SegLen)]
        XMM xmm1;

        [FieldOffset(SegLen*2)]
        YMM ymm2;

        [FieldOffset(SegLen*2)]
        XMM xmm2;

        [FieldOffset(SegLen*3)]
        YMM ymm3;

        [FieldOffset(SegLen*3)]
        XMM xmm3;

        [FieldOffset(SegLen*4)]
        YMM ymm4;

        [FieldOffset(SegLen*4)]
        XMM xmm4;

        [FieldOffset(SegLen*5)]
        YMM ymm5;

        [FieldOffset(SegLen*5)]
        XMM xmm5;

        [FieldOffset(SegLen*6)]
        YMM ymm6;

        [FieldOffset(SegLen*6)]
        XMM xmm6;

        [FieldOffset(SegLen*7)]
        YMM ymm7;

        [FieldOffset(SegLen*7)]
        XMM xmm7;

        [FieldOffset(SegLen*8)]
        YMM ymm8;

        [FieldOffset(SegLen*8)]
        XMM xmm8;


        [FieldOffset(SegLen*9)]
        YMM ymm9;

        [FieldOffset(SegLen*9)]
        XMM xmm9;

        [FieldOffset(SegLen*10)]
        YMM ymm10;

        [FieldOffset(SegLen*10)]
        XMM xmm10;

        [FieldOffset(SegLen*11)]
        YMM ymm11;

        [FieldOffset(SegLen*11)]
        XMM xmm11;
 
        [FieldOffset(SegLen*12)]
        YMM ymm12;

        [FieldOffset(SegLen*12)]
        XMM xmm12;

        [FieldOffset(SegLen*13)]
        YMM ymm13;

        [FieldOffset(SegLen*13)]
        XMM xmm13;

        [FieldOffset(SegLen*14)]
        YMM ymm14;

        [FieldOffset(SegLen*14)]
        XMM xmm14;
 
        [FieldOffset(SegLen*15)]
        YMM ymm15;

        [FieldOffset(SegLen*15)]
        XMM xmm15;
    }
}