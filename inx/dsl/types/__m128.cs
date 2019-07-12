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

    using static zfunc;

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public struct __m128
    {

        [MethodImpl(Inline)]
        public Vec128<float> ToVec128()
                => Unsafe.As<__m128,Vec128<float>>(ref this);

        [MethodImpl(Inline)]
        public static __m128 FromVec128(in Vec128<float> src)
                => Unsafe.As<Vec128<float>, __m128>(ref As.asRef(in src));

        [MethodImpl(Inline)]
        public Vector128<float> ToVector128()
                => Unsafe.As<__m128,Vector128<float>>(ref this);

        [MethodImpl(Inline)]
        public static __m128 FromVector128(in Vector128<float> src)
                => Unsafe.As<Vector128<float>, __m128>(ref As.asRef(in src));

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


        [FieldOffset(0)]
        public float x00f;

        [FieldOffset(4)]
        public float x01f;

        [FieldOffset(8)]
        public float x02f;

        [FieldOffset(12)]
        public float x03f;

    }

}