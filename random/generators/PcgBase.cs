//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;
    using static math;

    public abstract class Pcg<S> : Rng
        where S : struct
    {
        protected const ulong DefaultMultiplier64 = 6364136223846793005;

        protected const ulong DefaultIndex64 = 1442695040888963407;

        protected static ulong Advance(ulong state, ulong delta, ulong multiplier, ulong index)
        {
            ulong factor = 1u;
            ulong increment = 0u;
            while (delta > 0) 
            {
                if ((delta & 1)  != 0)
                {
                    factor *= multiplier;
                    increment = increment * multiplier + index;
                }
                index = (multiplier + 1) * index;
                multiplier *= multiplier;
                delta /= 2;
            }
            return factor * state + increment;
        }

        protected S State;

        protected S Index;

        protected Pcg(S s0, S index)
        {
            this.State = s0;
            this.Index = index;
        }

        protected Pcg()
        {

        }

        public override string ToString()
            => $"{State}[{Index}]";
    }

    public static class PcgX
    {

        public static Span<ulong> Next(this Span<Pcg32> generators)
        {
            var dst = span<ulong>(generators.Length);
            for(var i=0; i<generators.Length; i++)
                dst[i] = generators[i].Next();
            return dst;
        }
    }

}