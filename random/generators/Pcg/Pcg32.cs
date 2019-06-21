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
    using static zfunc;
    using static math;

    public class Pcg32 : Pcg<ulong>,  IRandomSource<uint>
    {
        //ulong State;

        /// <summary>
        /// Returns a sequence of generators predicated on supplied seed and index values
        /// </summary>
        /// <param name="seeds">A span of seed values</param>
        /// <param name="indices">A span of index values</param>
        public static Span<Pcg32> Suite(Span<ulong> seeds, Span<ulong> indices)        
        {
            var count = length(seeds,indices);
            var g = span<Pcg32>(count);
            for(var i=0; i<count; i++)
                g[i] = Pcg32.Define(seeds[i], indices[i]);
            return g;
        }        

        public static Pcg32 Define(ulong s0, ulong? index = null)
            => new Pcg32(s0,index);

        public readonly ulong Multiplier 
            = PcgCommon.DefaultMultiplier64;
        

        [MethodImpl(Inline)]
        Pcg32(ulong s0, ulong? index = null)
        {
            Init(s0, index ?? PcgCommon.DefaultIndex64);
        }
        
        void Init(ulong s0, ulong index)
        {
            if(index % 2 == 0)
                throw new ArgumentException($"Then index value {index} is not odd");

            this.Index = (index << 1) | 1u;
            Step();
            this.State += s0;
            Step();

        }

        [MethodImpl(Inline)]
        public uint Next()
            => Grind(Step());

        /// <summary>
        /// Advances the generator to the next state and returns the
        /// prior state for consumption
        /// </summary>
        [MethodImpl(Inline)]
        ulong Step()
        {
            var prior = State;
            State =  prior*Multiplier + Index;
            return prior;
        }

        public IEnumerable<uint> Stream()
        {
            while(true)
            {
                yield return Next();
            }
        }

        [MethodImpl(Inline)]
        public void Advance(ulong delta)  
            => State = PcgCommon.Advance(State, delta, Multiplier, Index);

        [MethodImpl(Inline)]
        public void Retreat(ulong count)
            => Advance(negate(count));        

        /// <summary>
        /// Produces a pseudorandom output from a given source state
        /// </summary>
        /// <param name="state">The source state</param>
        /// <remarks>Follows the implementation of pcg_output_xsh_rr_64_32</remarks>
        [MethodImpl(Inline)]
        static uint Grind(ulong state)
        {
            var src = ((state >> 18) ^ state) >> 27;            
            var dst = Bits.rotr((uint)src,(uint)(state >> 59));
            return dst;
        }
    }
}