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

    public readonly struct OrGate<T> : IBinaryBitGate, IBinaryGate<T>
        where T : struct
    {
        internal static readonly OrGate<T> Gate = default;

        [MethodImpl(Inline)]
        public Bit Send(Bit x, Bit y)
            => x | y;

        [MethodImpl(Inline)]
        public T Send(T x, T y)
            => gbits.or(x,y);

        [MethodImpl(Inline)]
        public Vec128<T> Send(Vec128<T> a, Vec128<T> b)
            => gbits.or(a,b);

        [MethodImpl(Inline)]
        public Vec256<T> Send(Vec256<T> a, Vec256<T> b)
            => gbits.or(a,b);
    }


}