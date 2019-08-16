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

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct __m128
    {
        [FieldOffset(0)]
        public float x00f;

        [FieldOffset(4)]
        public float x01f;

        [FieldOffset(8)]
        public float x02f;

        [FieldOffset(12)]
        public float x03f;

        [MethodImpl(Inline)]
        public Vec128<float> ToVec128()
            => Vec128.FromParts(x00f,x01f,x02f,x03f);

        [MethodImpl(Inline)]
        public static __m128 FromVec128(in Vec128<float> src)
        {
            var dst = default(__m128);
            vstore(in src, ref dst.x00f);
            return dst;
        }
            
        [MethodImpl(Inline)]
        public Vector128<float> ToVector128()
            => Vector128.Create(x00f,x01f,x02f,x03f);

        [MethodImpl(Inline)]
        public static unsafe __m128 FromVector128(in Vector128<float> src)
        {
            var dst = default(__m128);
            Avx2.Store(refptr(ref dst.x00f), src);
            return dst;
        }

        [MethodImpl(Inline)]
        public static implicit operator __m128(in Vec128<float> src)
            => FromVec128(in src);

        [MethodImpl(Inline)]
        public static implicit operator Vec128<float>(in __m128 src)
            => src.ToVec128();

        [MethodImpl(Inline)]
        public static implicit operator __m128(in Vector128<float> src)
            => FromVector128(in src);

        [MethodImpl(Inline)]
        public static implicit operator Vector128<float>(in __m128 src)
            => src.ToVector128();
    }
}