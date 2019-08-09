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

    public class Pcg64 : Pcg<ulong>, IRandomSource<ulong>, IRandomSource
    {
        public static Pcg64 Define(ulong s0, ulong? index = null)
            => new Pcg64(s0,index);
     
        public readonly ulong Multiplier 
            = DefaultMultiplier64;
        

        IRandomSource<ulong> PointSource
            => this;

        Polyrand PR;

        [MethodImpl(Inline)]
        Pcg64(ulong s0, ulong? index = null)
        {
            Init(s0, index ?? DefaultIndex64);
            this.PR = new Polyrand(PointSource);    

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
        public ulong Next()
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

        public IEnumerable<ulong> Stream()
        {
            while(true)
            {
                yield return Next();
            }
        }

        [MethodImpl(Inline)]
        public void Advance(ulong count)  
            => State = Advance(State, count, Multiplier, Index);

        [MethodImpl(Inline)]
        public void Retreat(ulong count)
            => Advance(negate(count));        

        /// <summary>
        /// Produces a pseudorandom output predicated on a state
        /// </summary>
        /// <param name="state">The source state</param>
        /// <remarks>Follows the implementation of pcg_output_rxs_m_xs_64_64</remarks>
        [MethodImpl(Inline)]
        static ulong Grind(ulong state)
        {
            var shift = (int) ((state >> 59) + 5);
            var src = ((state >> shift) ^ state) * 12605985483714917081ul;  
            var dst = (src >> 43) ^ src; 
            return dst;         
        }

        ulong IRandomSource.NextUInt64()
            => PR.Next<ulong>();
 
        ulong IRandomSource.NextUInt64(ulong max)
            => PR.Next(max);   

        int IRandomSource.NextInt32(int max)
            => PR.NextInt32(max);

        double IRandomSource.NextDouble()
            => PR.Next<double>();
    }

}