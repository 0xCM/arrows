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

    public readonly struct XOrGate : IBinaryGate
    {
        internal static readonly XOrGate G = default;

        [MethodImpl(Inline)]
        public Bit Send(Bit x, Bit y)
            => x ^ y;
    }

    public readonly struct XOrGate<T> : IBinaryGate<T>
        where T : struct
    {
        internal static readonly XOrGate<T> G = default;

        [MethodImpl(Inline)]
        public T Send(T x, T y)
            => gbits.xor(x,y);
    }

    public readonly struct XOrGate128<T> : IBinaryGate<Vec128<T>>
        where T : struct
    {
        internal static readonly XOrGate128<T> G = default;

        public Vec128<T> Send(Vec128<T> x, Vec128<T> y)
            => gbits.xor(x, y);
    }

    public readonly struct XOrGate256<T> : IBinaryGate<Vec256<T>>
        where T : struct
    {
        internal static readonly XOrGate256<T> G = default;

        public Vec256<T> Send(Vec256<T> x, Vec256<T> y)
            => gbits.xor(x, y);
    }

}