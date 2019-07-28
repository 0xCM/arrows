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


    public interface ILogicGate<G,in I,out O>
        where G : struct, ILogicGate<G,I,O>
    {
        O Send(I input);
    }
    
    public readonly struct NotGate : ILogicGate<NotGate,Bit,Bit>
    {
        public static readonly NotGate G = default;
        
        [MethodImpl(Inline)]
        public Bit Send(Bit input)
            => !input;    
    }

    public readonly struct AndGate : ILogicGate<AndGate,(Bit x,Bit y),Bit>
    {
        public static readonly AndGate G = default;

        [MethodImpl(Inline)]
        public Bit Send((Bit x, Bit y) input)
            => input.x & input.y;
    }

    public readonly struct OrGate : ILogicGate<OrGate,(Bit x,Bit y),Bit>
    {
        public static readonly OrGate G = default;
        
        [MethodImpl(Inline)]
        public Bit Send((Bit x, Bit y) input)
            => input.x | input.y;
    }

    public readonly struct NAndGate : ILogicGate<NAndGate,(Bit x,Bit y),Bit>
    {
        public static readonly NAndGate G = default;

        [MethodImpl(Inline)]
        public Bit Send((Bit x, Bit y) input)
            => !(input.x & input.y);
    }

    public readonly struct NOrGate : ILogicGate<NOrGate,(Bit x,Bit y),Bit>
    {
        public static readonly NOrGate G = default;

        [MethodImpl(Inline)]
        public Bit Send((Bit x, Bit y) input)
            => !(input.x | input.y);
    }

    public readonly struct XOrGate : ILogicGate<XOrGate,(Bit x,Bit y),Bit>
    {
        public static readonly XOrGate G = default;

        [MethodImpl(Inline)]
        public Bit Send((Bit x, Bit y) input)
            => input.x ^ input.y;
    }

    public readonly struct NXOrGate : ILogicGate<NXOrGate,(Bit x,Bit y),Bit>
    {
        public static readonly NXOrGate G = default;
        
        [MethodImpl(Inline)]
        public Bit Send((Bit x, Bit y) input)
            => !(input.x ^ input.y);
    }

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