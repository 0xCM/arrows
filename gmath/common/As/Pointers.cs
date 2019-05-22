//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using System.Security;
    
    using static mfunc;
    using static zfunc;

    public static partial class As
    {

        [MethodImpl(Inline)]
        public static unsafe void* pvoid<T>(ref T src)
            => Unsafe.AsPointer(ref src);

        [MethodImpl(Inline)]
        public static unsafe sbyte* pint8<T>(ref T src)
            => (sbyte*)pvoid(ref src);
        
        [MethodImpl(Inline)]
        public static unsafe byte* puint8<T>(ref T src)
            => (byte*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe short* pint16<T>(ref T src)
            => (short*)pvoid(ref src);
        
        [MethodImpl(Inline)]
        public static unsafe ushort* puint16<T>(ref T src)
            => (ushort*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe int* pint32<T>(ref T src)
            => (int*)pvoid(ref src);
        
        [MethodImpl(Inline)]
        public static unsafe uint* puint32<T>(ref T src)
            => (uint*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe long* pint64<T>(ref T src)
            => (long*)pvoid(ref src);
        
        [MethodImpl(Inline)]
        public static unsafe ulong* puint64<T>(ref T src)
            => (ulong*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe float* pfloat32<T>(ref T src)
            => (float*)pvoid(ref src);
        
        [MethodImpl(Inline)]
        public static unsafe double* pfloat64<T>(ref T src)
            => (double*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe sbyte* int8(void* src)
            => (sbyte*)src;

        [MethodImpl(Inline)]
        public static unsafe byte* uint8(void* src)
            => (byte*)src;

        [MethodImpl(Inline)]
        public static unsafe short* int16(void* src)
            => (short*)src;

        [MethodImpl(Inline)]
        public static unsafe ushort* uint16(void* src)
            => (ushort*)src;

        [MethodImpl(Inline)]
        public static unsafe int* int32(void* src)
            => (int*)src;

        [MethodImpl(Inline)]
        public static unsafe uint* uint32(void* src)
            => (uint*)src;

        [MethodImpl(Inline)]
        public static unsafe long* int64(void* src)
            => (long*)src;

        [MethodImpl(Inline)]
        public static unsafe ulong* uint64(void* src)
            => (ulong*)src;

        [MethodImpl(Inline)]
        public static unsafe float* float32(void* src)
            => (float*)src;

        [MethodImpl(Inline)]
        public static unsafe double* float64(void* src)
            => (double*)src;

    }

}