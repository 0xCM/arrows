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

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public struct m256
    {
        [MethodImpl(Inline)]
        public Vec256<float> ToVec256()
                => Unsafe.As<m256,Vec256<float>>(ref this);

        [MethodImpl(Inline)]
        public static m256 FromVec256(in Vec256<float> src)
                => Unsafe.As<Vec256<float>, m256>(ref As.asRef(in src));

        [MethodImpl(Inline)]
        public Vector256<float> ToVector256()
                => Unsafe.As<m256,Vector256<float>>(ref this);

        [MethodImpl(Inline)]
        public static m256 FromVector256(in Vector256<float> src)
                => Unsafe.As<Vector256<float>, m256>(ref As.asRef(in src));

        [MethodImpl(Inline)]
        public static implicit operator m256(in Vec256<float> src)
            => FromVec256(in src);

        [MethodImpl(Inline)]
        public static implicit operator Vec256<float>(in m256 src)
            => src.ToVec256();


        [MethodImpl(Inline)]
        public static implicit operator m256(in Vector256<float> src)
            => FromVector256(in src);

        [MethodImpl(Inline)]
        public static implicit operator Vector256<float>(in m256 src)
            => src.ToVector256();


        [FieldOffset(0)]
        public float x00f;

        [FieldOffset(4)]
        public float x01f;

        [FieldOffset(8)]
        public float x02f;

        [FieldOffset(12)]
        public float x03f;

        [FieldOffset(16)]
        public float x04f;

        [FieldOffset(20)]
        public float x05f;

        [FieldOffset(24)]
        public float x06f;

        [FieldOffset(28)]
        public float x07f;

 
    }

}