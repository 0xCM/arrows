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

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct __m256d
    {
        [FieldOffset(0)]
        public double x0d;

        [FieldOffset(8)]
        public double x1d;

        [FieldOffset(16)]
        public double x2d;

        [FieldOffset(24)]
        public double x3d;

        [MethodImpl(Inline)]
        public Vec256<double> ToVec256()
            => Vec256.FromParts(x0d,x1d,x2d,x3d);

        [MethodImpl(Inline)]
        public Vector256<double> ToVector256()
            => Vector256.Create(x0d,x1d,x2d,x3d);

        [MethodImpl(Inline)]
        public static __m256d FromVec256(in Vec256<double> src)
        {
            __m256d dst = default;
            vstore(in src, ref dst.x0d);            
            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe __m256d FromVector256(in Vector256<double> src)
        {
            __m256d dst = default;
            Avx2.Store(refptr(ref dst.x0d), src);
            return dst;
        }

        [MethodImpl(Inline)]
        public static __m256d Broadcast(double src)
            => Vector256.Create(src);

        static Exception TooShort(int given)
            => new Exception($"The source span length = {given} is less than the length required = {Vec256<double>.Length}");

        [MethodImpl(Inline)]
        static int CheckLength(int given)
                => given >= Vec256<double>.Length ? Vec256<double>.Length : throw TooShort(given) ;

        [MethodImpl(Inline)]
        unsafe ref double Head()
        {
            fixed(void* pSrc = &this)
                return ref Unsafe.AsRef<double>(pSrc);
        }
        
        [MethodImpl(Inline)]
        public static unsafe __m256d FromParts<T>(in ReadOnlySpan<double> src)
        {
            CheckLength(src.Length);
            ref var refSrc = ref As.asRef(in src[0]);
            var pSrc = (__m256d*)Unsafe.AsPointer(ref refSrc);
            return *pSrc;
        }

        [MethodImpl(Inline)]
        public ref double Part(int pos)
            => ref Unsafe.Add(ref Head(), pos);

        [MethodImpl(Inline)]
        public Span<double> Parts()
        {
            var len = Vec256<double>.Length;
            var dst = span<double>(len);
            for(var i=0; i<len; i++)
                dst[i] = Part(i);
            return dst;            
        }

        [MethodImpl(Inline)]
        public static implicit operator __m256d(in Vec256<double> src)
            => FromVec256(in src);

        [MethodImpl(Inline)]
        public static explicit operator Vec256<double>(in __m256d src)
            => src.ToVec256();

        [MethodImpl(Inline)]
        public static implicit operator __m256d(in Vector256<double> src)
            => FromVector256(in src);

        [MethodImpl(Inline)]
        public static implicit operator Vector256<double>(in __m256d src)
            => src.ToVector256();     
    }
}