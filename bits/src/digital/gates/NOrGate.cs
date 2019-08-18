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

    public readonly struct NOrGate : IBinaryGate
    {
        internal static readonly NOrGate G = default;

        [MethodImpl(Inline)]
        public Bit Send(Bit x, Bit y)
            => !(x | y);
    }

    public readonly struct NOrGate<T> : IBinaryGate<T>
        where T : struct
    {
        internal static readonly NOrGate<T> G = default;

        [MethodImpl(Inline)]
        public T Send(T x, T y)
            => gbits.flip(gbits.or(x,y));

    }

    public readonly struct NOrGate128<T> : IBinaryGate<Vec128<T>>
        where T : struct
    {
        internal static readonly NOrGate128<T> G = default;

        public Vec128<T> Send(Vec128<T> x, Vec128<T> y)
            => gbits.flip(gbits.or(x,y));
    }

    public readonly struct NOrGate256<T> : IBinaryGate<Vec256<T>>
        where T : struct
    {
        internal static readonly NOrGate256<T> G = default;

        public Vec256<T> Send(Vec256<T> x, Vec256<T> y)
            => gbits.flip(gbits.or(x,y));
    }

}