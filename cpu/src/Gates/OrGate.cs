//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;
    using static zfunc;

    public readonly struct OrGate : ILogicGate<OrGate,(Bit x,Bit y),Bit>
    {
        public static readonly OrGate G = default;
        
        [MethodImpl(Inline)]
        public Bit Send((Bit x, Bit y) input)
            => input.x | input.y;
    }

}