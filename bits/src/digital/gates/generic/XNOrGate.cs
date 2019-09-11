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

    public readonly struct XNOrGate<T> : 
        IBinaryBitGate,
        IBinaryGate<T>,
        IBinaryGate<Vec128<T>>,
        IBinaryGate<Vec256<T>>
        where T : struct
    {
        internal static readonly XNOrGate<T> Gate = default;

        [MethodImpl(Inline)]
        public Bit Send(Bit x, Bit y)
            => !(x ^ y);

        [MethodImpl(Inline)]
        public T Send(T x, T y)
            => gbits.flip(gbits.xor(x,y));

        [MethodImpl(Inline)]
        public Vec128<T> Send(Vec128<T> x, Vec128<T> y)
            => gbits.flip(gbits.xor(x,y));

        [MethodImpl(Inline)]
        public Vec256<T> Send(Vec256<T> x, Vec256<T> y)
            => gbits.flip(gbits.xor(x,y));

    }

}