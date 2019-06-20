//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;
    using static math;

    public static class Pcg
    {
        public static Pcg64 Rng64(ulong s0, ulong? index = null)
            => Pcg64.Define(s0, index);        
    }

    public static class PcgX
    {
        public static HashSet<uint> TakeSet(this Pcg64 rng, int count)
            => rng.Stream().Take(count).ToHashSet();

        public static Pcg64 Retreat(this Pcg64 rng, ulong count)
            => rng.Advance(negate(count));        

    }

    public class Pcg64
    {
        ulong state;

        public static Pcg64 Define(ulong s0, ulong? index = null)
            => new Pcg64(s0,index);

        public const ulong DefaultMultiplier = 6364136223846793005;

        public const ulong DefaultIndex = 1442695040888963407;

        public readonly ulong Multiplier = DefaultMultiplier;
        
        public readonly ulong Index = DefaultIndex;


        [MethodImpl(Inline)]
        Pcg64(ulong s0, ulong? index = null)
        {
            if(index % 2 == 0)
                throw new ArgumentException($"Then index value {index} is not odd");

            this.Index = ((index ?? DefaultIndex) << 1) | 1u;
            Step();
            this.state += s0;
            Step();
        }
        
        public ulong State
        {
            [MethodImpl(Inline)]
            get => state;
        }

        [MethodImpl(Inline)]
        public uint Next()
            => Grind(Step());


        public IEnumerable<uint> Stream()
        {
            while(true)
            {
                yield return Next();
            }
        }

        [MethodImpl(Inline)]
        public Pcg64 Advance(ulong delta)  
        {      
            state = Advance(state, delta, Multiplier, Index);
            return this;
        }

        public override string ToString()
            => $"{state}[{Index}]";

        /// <summary>
        /// Advances the generator to the next state and returns the
        /// prior state for consumption
        /// </summary>
        [MethodImpl(Inline)]
        ulong Step()
        {
            var prior = state;
            state =  prior*Multiplier + Index;
            return prior;
        }

        [MethodImpl(Inline)]
        public static uint rotr(uint src, uint count)
        {            
            var lhs = src >> (int)count;
            var rhs = src << (int)(~count & 31) + 1;
            return lhs | rhs;
        }            

        [MethodImpl(Inline)]
        static uint Grind(ulong state)
        {
            var src = ((state >> 18) ^ state) >> 27;            
            var dst = rotr((uint)src,(uint)(state >> 59));
            return dst;
        }

        static ulong Advance(ulong state, ulong delta, ulong multiplier, ulong index)
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
    }
}