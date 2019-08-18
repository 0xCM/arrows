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

    public readonly struct NAndGate : IBinaryGate
    {
        internal static readonly NAndGate G = default;

        [MethodImpl(Inline)]
        public Bit Send(Bit x, Bit y)
            => !(x & y);
    }

     public readonly struct NAndGate<T> : IBinaryGate<T>
        where T : struct
    {
        internal static readonly NAndGate<T> G = default;

        [MethodImpl(Inline)]
        public T Send(T x, T y)
            => gbits.flip(gbits.and(x,y));
    }

    public readonly struct NAndGate128<T> : IBinaryGate<Vec128<T>>
        where T : struct
    {
        internal static readonly NAndGate128<T> G = default;

        public Vec128<T> Send(Vec128<T> x, Vec128<T> y)
            => gbits.flip(gbits.and(x,y));
    }

    public readonly struct NAndGate256<T> : IBinaryGate<Vec256<T>>
        where T : struct
    {
        internal static readonly NAndGate256<T> G = default;

        public Vec256<T> Send(Vec256<T> x, Vec256<T> y)
            => gbits.flip(gbits.and(x,y));
    }

}