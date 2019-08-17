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
    public struct __m256
    {
        [FieldOffset(0)]
        public float x00s;

        [FieldOffset(4)]
        public float x01s;

        [FieldOffset(8)]
        public float x02s;

        [FieldOffset(12)]
        public float x03s;

        [FieldOffset(16)]
        public float x04s;

        [FieldOffset(20)]
        public float x05s;

        [FieldOffset(24)]
        public float x06s;

        [FieldOffset(28)]
        public float x07s;            

        [MethodImpl(Inline)]
        public Vec256<float> ToVec256()
            => Vec256.FromParts(x00s,x01s,x02s,x03s,x04s,x05s,x06s,x07s);

        [MethodImpl(Inline)]
        public Vector256<float> ToVector256()
            => Vector256.Create(x00s,x01s,x02s,x03s,x04s,x05s,x06s,x07s);

        [MethodImpl(Inline)]
        public static __m256 FromVec256(in Vec256<float> src)
        {
            __m256 dst = default;
            vstore(in src, ref dst.x00s);            
            return dst;
        }

        [MethodImpl(Inline)]
        public static unsafe __m256 FromVector256(in Vector256<float> src)
        {
            __m256 dst = default;
            Avx2.Store(refptr(ref dst.x00s), src);
            return dst;
        }

        [MethodImpl(Inline)]
        public static __m256 Broadcast(float src)
            => Vector256.Create(src);

        static Exception TooShort(int given)
            => new Exception($"The source span length = {given} is less than the length required = {Vec256<float>.Length}");

        [MethodImpl(Inline)]
        static int CheckLength(int given)
                => given >= Vec256<float>.Length ? Vec256<float>.Length : throw TooShort(given) ;

        [MethodImpl(Inline)]
        unsafe ref float Head()
        {
            fixed(void* pSrc = &this)
                return ref Unsafe.AsRef<float>(pSrc);
        }        

        [MethodImpl(Inline)]
        public static unsafe __m256 FromParts(Span<float> src)
            =>  src.Length >= Vec256<float>.Length 
            ?  * (__m256*)Unsafe.AsPointer(ref src[0]) 
            : throw TooShort(src.Length);

        [MethodImpl(Inline)]
        public ref float Part(int pos)
            => ref Unsafe.Add(ref Head(), pos);

        public Span<float> Parts()
        {
            var len = Vec256<float>.Length;
            var dst = span<float>(len);
            for(var i=0; i<len; i++)
                dst[i] = Part(i);
            return dst;            
        }

        [MethodImpl(Inline)]
        public static implicit operator __m256(in Vec256<float> src)
            => FromVec256(in src);

        [MethodImpl(Inline)]
        public static explicit operator Vec256<float>(in __m256 src)
            => src.ToVec256();

        [MethodImpl(Inline)]
        public static implicit operator __m256(in Vector256<float> src)
            => FromVector256(in src);

        [MethodImpl(Inline)]
        public static implicit operator Vector256<float>(in __m256 src)
            => src.ToVector256();     
    }

}