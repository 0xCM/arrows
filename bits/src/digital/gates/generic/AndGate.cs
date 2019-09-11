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

    public readonly struct AndGate<T> :
        IBinaryGate<T>, 
        IBinaryGate<Vec128<T>>,
        IBinaryGate<Vec256<T>>
        where T : struct
    {
        internal static readonly AndGate<T> Gate = default;

        [MethodImpl(Inline)]
        public T Send(T x, T y)
            => gbits.and(x,y);

        [MethodImpl(Inline)]
        public Vec128<T> Send(Vec128<T> a, Vec128<T> b)
            => gbits.and(a,b);

        [MethodImpl(Inline)]
        public Vec256<T> Send(Vec256<T> a, Vec256<T> b)
            => gbits.and(a,b);

    }
}