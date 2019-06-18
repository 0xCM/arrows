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
    public struct m128d
    {

        [MethodImpl(Inline)]
        public Vec128<double> ToVec128()
                => Unsafe.As<m128d,Vec128<double>>(ref this);

        [MethodImpl(Inline)]
        public static m128d FromVec128(in Vec128<double> src)
                => Unsafe.As<Vec128<double>, m128d>(ref As.asRef(in src));

        [MethodImpl(Inline)]
        public Vector128<double> ToVector128()
                => Unsafe.As<m128d,Vector128<double>>(ref this);

        [MethodImpl(Inline)]
        public static m128d FromVector128(in Vector128<double> src)
                => Unsafe.As<Vector128<double>, m128d>(ref As.asRef(in src));

        [MethodImpl(Inline)]
        public static implicit operator m128d(in Vec128<double> src)
            => FromVec128(in src);

        [MethodImpl(Inline)]
        public static implicit operator Vec128<double>(in m128d src)
            => src.ToVec128();


        [MethodImpl(Inline)]
        public static implicit operator m128d(in Vector128<double> src)
            => FromVector128(in src);

        [MethodImpl(Inline)]
        public static implicit operator Vector128<double>(in m128d src)
            => src.ToVector128();

        [FieldOffset(0)]
        public double x0d;

        [FieldOffset(8)]
        public double x1d;
    }

}