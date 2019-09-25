//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public readonly struct MuxGate<T> : ITernaryGate<T>,  ITernaryGate<Vector128<T>>, ITernaryGate<Vector256<T>>
        where T : unmanaged
    {
        internal static readonly MuxGate<T> Gate = default;

        [MethodImpl(Inline)]
        public Bit Send(Bit x, Bit y, Bit control)
            => control ? y : x;

        [MethodImpl(Inline)]
        public T Send(in T x, in T y, in T control)
            => gbits.or(gbits.andn(in x, in control), gmath.and(y, control));

        [MethodImpl(Inline)]
        public Vector128<T> Send(in Vector128<T> x, in Vector128<T> y, in Vector128<T> control)
            => gbits.or(gbits.andn(in x, control), gbits.vand(y, control));

        [MethodImpl(Inline)]
        public Vector256<T> Send(in Vector256<T> x, in Vector256<T> y, in Vector256<T> control)
            => gbits.or(gbits.andn(x, control), gbits.vand<T>(y, control));

    }
}