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
        public static unsafe sbyte* refptr(ref sbyte src)
            => (sbyte*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe byte* puint8<T>(ref T src)
            => (byte*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe byte* refptr(ref byte src)
            => (byte*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe short* pint16<T>(ref T src)
            => (short*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe short* refptr(ref short src)
            => (short*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe ushort* puint16<T>(ref T src)
            => (ushort*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe ushort* refptr(ref ushort src)
            => (ushort*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe int* pint32<T>(ref T src)
            => (int*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe int* refptr(ref int src)
            => (int*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe uint* puint32<T>(ref T src)
            => (uint*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe uint* refptr(ref uint src)
            => (uint*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe long* pint64<T>(ref T src)
            => (long*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe long* refptr(ref long src)
            => (long*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe ulong* puint64<T>(ref T src)
            => (ulong*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe ulong* refptr(ref ulong src)
            => (ulong*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe float* pfloat32<T>(ref T src)
            => (float*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe float* refptr(ref float src)
            => (float*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe double* pfloat64<T>(ref T src)
            => (double*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe double* refptr(ref double src)
            => (double*)pvoid(ref src);


        [MethodImpl(Inline)]
        public static unsafe sbyte* constptr(in sbyte src)
            => refptr(ref asRef(in src));

        [MethodImpl(Inline)]
        public static unsafe byte* constptr(in byte src)
            => refptr(ref asRef(in src));

        [MethodImpl(Inline)]
        public static unsafe short* constptr(in short src)
            => refptr(ref asRef(in src));

        [MethodImpl(Inline)]
        public static unsafe ushort* constptr(in ushort src)
            => refptr(ref asRef(in src));

        [MethodImpl(Inline)]
        public static unsafe int* constptr(in int src)
            => refptr(ref asRef(in src));

        [MethodImpl(Inline)]
        public static unsafe uint* constptr(in uint src)
            => refptr(ref asRef(in src));

        [MethodImpl(Inline)]
        public static unsafe long* constptr(in long src)
            => refptr(ref asRef(in src));

        [MethodImpl(Inline)]
        public static unsafe ulong* constptr(in ulong src)
            => refptr(ref asRef(in src));

        [MethodImpl(Inline)]
        public static unsafe float* constptr(in float src)
            => refptr(ref asRef(in src));

        [MethodImpl(Inline)]
        public static unsafe double* constptr(in double src)
            => refptr(ref asRef(in src));

        [MethodImpl(Inline)]
        public static unsafe P* refptr<P,T>(ref T src)
            where T : struct
            where P : unmanaged
                => (P*)Unsafe.AsPointer(ref src);

    }

}