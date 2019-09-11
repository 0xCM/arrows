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

    public readonly struct NOrGate<T> : 
        IBinaryGate<T>, 
        IBinaryGate<Vec128<T>>, 
        IBinaryGate<Vec256<T>>, 
        IBinaryBitGate
        where T : struct
    {
        internal static readonly NOrGate<T> Gate = default;

        [MethodImpl(Inline)]
        public Bit Send(Bit x, Bit y)
            => !(x | y);

        [MethodImpl(Inline)]
        public T Send(T x, T y)
            => gbits.flip(gbits.or(x,y));

        [MethodImpl(Inline)]
        public Vec128<T> Send(Vec128<T> x, Vec128<T> y)
            => gbits.flip(gbits.or(x,y));

        [MethodImpl(Inline)]
        public Vec256<T> Send(Vec256<T> x, Vec256<T> y)
            => gbits.flip(gbits.or(x,y));
    }
}