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
    public struct __m128d
    {
        [FieldOffset(0)]
        public double x0d;

        [FieldOffset(8)]
        public double x1d;
 
        [MethodImpl(Inline)]
        public Vec128<double> ToVec128()
            => Vec128.FromParts(x0d, x1d);

        [MethodImpl(Inline)]
        public static __m128d FromVec128(in Vec128<double> src)
        {
            var dst = default(__m128d);
            vstore(in src, ref dst.x0d);
            return dst;
        }

        [MethodImpl(Inline)]
        public Vector128<double> ToVector128()
            => Vector128.Create(x0d, x1d);

        [MethodImpl(Inline)]
        public static unsafe __m128d FromVector128(in Vector128<double> src)
        {
            var dst = default(__m128d);
            Avx2.Store(refptr(ref dst.x0d), src);
            return dst;
        }

        [MethodImpl(Inline)]
        public static implicit operator __m128d(in Vec128<double> src)
            => FromVec128(in src);

        [MethodImpl(Inline)]
        public static implicit operator Vec128<double>(in __m128d src)
            => src.ToVec128();

        [MethodImpl(Inline)]
        public static implicit operator __m128d(in Vector128<double> src)
            => FromVector128(in src);

        [MethodImpl(Inline)]
        public static implicit operator Vector128<double>(in __m128d src)
            => src.ToVector128();
    }

}