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
    public struct m256d
    {
        [MethodImpl(Inline)]
        public Vec256<double> ToVec256()
                => Unsafe.As<m256d,Vec256<double>>(ref this);

        [MethodImpl(Inline)]
        public static m256d FromVec256(in Vec256<double> src)
                => Unsafe.As<Vec256<double>, m256d>(ref As.asRef(in src));

        [MethodImpl(Inline)]
        public Vector256<double> ToVector256()
                => Unsafe.As<m256d,Vector256<double>>(ref this);

        [MethodImpl(Inline)]
        public static m256d FromVector256(in Vector256<double> src)
                => Unsafe.As<Vector256<double>, m256d>(ref As.asRef(in src));

        [MethodImpl(Inline)]
        public static implicit operator m256d(in Vec256<double> src)
            => FromVec256(in src);

        [MethodImpl(Inline)]
        public static implicit operator Vec256<double>(in m256d src)
            => src.ToVec256();


        [MethodImpl(Inline)]
        public static implicit operator m256d(in Vector256<double> src)
            => FromVector256(in src);

        [MethodImpl(Inline)]
        public static implicit operator Vector256<double>(in m256d src)
            => src.ToVector256();


        [FieldOffset(0)]
        public double x0d;

        [FieldOffset(8)]
        public double x1d;

        [FieldOffset(16)]
        public double x2d;

        [FieldOffset(24)]
        public double x3d;
 
    }
}