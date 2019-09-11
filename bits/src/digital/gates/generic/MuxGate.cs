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

    public readonly struct MuxGate<T> : 
        ITernaryBitGate, 
        ITernaryGate<T>, 
        ITernaryGate<Vec128<T>>,
        ITernaryGate<Vec256<T>>
        where T : struct
    {
        internal static readonly MuxGate<T> Gate = default;

        [MethodImpl(Inline)]
        public T Send(T x, T y, T control)
            => gbits.or(gbits.andn(x, control), gbits.and(y, control));

        [MethodImpl(Inline)]
        public Vec128<T> Send(Vec128<T> x, Vec128<T> y, Vec128<T> control)
            => gbits.or(gbits.andn(x, control), gbits.and(y, control));

        [MethodImpl(Inline)]
        public Vec256<T> Send(Vec256<T> x, Vec256<T> y, Vec256<T> control)
            => gbits.or(gbits.andn(x, control), gbits.and(y, control));

        [MethodImpl(Inline)]
        public Bit Send(Bit x, Bit y, Bit control)
            => control ? y : x;
    }
}