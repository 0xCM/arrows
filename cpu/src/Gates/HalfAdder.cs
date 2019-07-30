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


    /// <summary>
    /// Represents a half adder as described by https://en.wikipedia.org/wiki/Adder_(electronics)
    /// </summary>
    public readonly struct HalfAdder : ILogicGate<HalfAdder,(Bit a, Bit b), (Bit s, Bit c)>
    {
        public static readonly HalfAdder G = default;

        [MethodImpl(Inline)]
        public (Bit s, Bit c) Send((Bit a, Bit b) input)
            => (XOrGate.G.Send(input), AndGate.G.Send(input));
    }

}