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


    public readonly struct XOrGate<T> : 
        IBinaryGate<T>, 
        IBinaryGate<Vec128<T>>,
        IBinaryGate<Vec256<T>>,
        IBinaryBitGate
        where T : struct
    {
        internal static readonly XOrGate<T> Gate = default;

        [MethodImpl(Inline)]
        public T Send(T a, T b)
            => gbits.xor(a,b);

        [MethodImpl(Inline)]
        public Vec128<T> Send(Vec128<T> a, Vec128<T> b)
            => gbits.xor(a,b);

        [MethodImpl(Inline)]
        public Vec256<T> Send(Vec256<T> a, Vec256<T> b)
            => gbits.xor(a,b);

        [MethodImpl(Inline)]
        public Bit Send(Bit x, Bit y)
            => x ^ y;
    }

}