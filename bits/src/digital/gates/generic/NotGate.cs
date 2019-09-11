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

    public readonly struct NotGate<T> : 
        IUnaryBitGate,
        IUnaryGate<T>,
        IUnaryGate<Vec128<T>>,
        IUnaryGate<Vec256<T>>
        
        where T : struct
    {
        internal static readonly NotGate<T> Gate = default;
        
        [MethodImpl(Inline)]
        public Bit Send(Bit input)
            => !input;    

        [MethodImpl(Inline)]
        public T Send(T x)
            => gbits.flip(x);

        [MethodImpl(Inline)]
        public Vec128<T> Send(Vec128<T> x)
            => gbits.flip(x);

        [MethodImpl(Inline)]
        public Vec256<T> Send(Vec256<T> x)
            => gbits.flip(x);
 

    }
}