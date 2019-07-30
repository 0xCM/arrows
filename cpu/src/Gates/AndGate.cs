//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using static zfunc;

    public readonly struct AndGate : ILogicGate<AndGate,(Bit x,Bit y),Bit>
    {
        public static readonly AndGate G = default;

        [MethodImpl(Inline)]
        public Bit Send((Bit x, Bit y) input)
            => input.x & input.y;
    }


}