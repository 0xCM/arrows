//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public readonly struct MuxGate<T> : ITernaryGate<T>,  ITernaryGate<Vec128<T>>, ITernaryGate<Vec256<T>>
        where T : unmanaged
    {
        internal static readonly MuxGate<T> Gate = default;

        [MethodImpl(Inline)]
        public Bit Send(Bit x, Bit y, Bit control)
            => control ? y : x;

        [MethodImpl(Inline)]
        public T Send(in T x, in T y, in T control)
            => gbits.or(gbits.andn(in x, in control), gbits.and(in y, in control));

        [MethodImpl(Inline)]
        public Vec128<T> Send(in Vec128<T> x, in Vec128<T> y, in Vec128<T> control)
            => gbits.or(gbits.andn(in x, control), gbits.and(in y, in control));

        [MethodImpl(Inline)]
        public Vec256<T> Send(in Vec256<T> x, in Vec256<T> y, in Vec256<T> control)
            => gbits.or(gbits.andn(in x, in control), gbits.and(in y, in control));

    }
}