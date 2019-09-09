//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;


    /// <summary>
    /// Defines pseudorandom number generator
    /// </summary>
    public struct XOrShift128 : IPointSource<uint>
    {        
        public XOrShift128(uint a, uint b, uint c, uint d)
        {
            this.a = a;
            this.b = b;            
            this.c = c;
            this.d = d;
        }

        public XOrShift128(ReadOnlySpan<uint> state)
        {
            require(state.Length >= 4);
            this.a = state[0];
            this.b = state[1];            
            this.c = state[2];
            this.d = state[3];
        }

        uint a;

        uint b;

        uint c;

        uint d;

        public RngKind RngKind 
            => RngKind.XOrShift128;

        // From Marsaglia's Xorshift RNGs
        // The stream produced should have a period of 2^128 - 1
        public uint Next()
        {
            var t = math.xorsl(a,15);
            a = b; 
            b = c;
            c = d; 
            d = Grind(d,t);
            return d;
        }

        [MethodImpl(Inline)]
        static uint Grind(uint d, uint t)
            => math.xorsr(d, 21) ^ math.xorsr(t, 4);

    }
}