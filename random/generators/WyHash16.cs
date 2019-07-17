//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static zfunc;
    using System;

    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    /// <summary>
    /// Implements a 16-bit random number generator
    /// </summary>
    /// <remarks>Algorithms take from https://lemire.me/blog/2019/07/03/a-fast-16-bit-random-number-generator/</remarks>
    class WyHash16 : IRandomSource<ushort>
    {
        [MethodImpl(Inline)]
        public WyHash16(ushort Seed, ushort? Increment = null)
        {
            this.Seed = Seed;
            this.State = Seed;
            this.Increment = Increment ?? 0xfc15;
        }
                
        readonly ushort Seed;
        
        readonly ushort Increment;

        ushort State;

        [MethodImpl(Inline)]
        public ushort Next()
            => Hash16(State += Increment, 0x2ab);

        [MethodImpl(Inline)]
        ushort Hash16(uint input, uint key) 
        {
            var hash = input * key;
            return (ushort) (((hash >> 16) ^ hash) & 0xFFFF);
        }        

        public ushort Next(ushort max)
        {
            var x = Next();
            var m = (uint)x * (uint)max;
            var l = (ushort)m;
            if (l < max) 
            {
                var t = math.mod(math.negate(max), max);
                while (l < t) 
                {
                    x = Next();
                    m = (uint)x * (uint)max;
                    l = (ushort)m;
                }
            }
            return (ushort) (m >> 16);
        }   

        [MethodImpl(Inline)]
        public ushort Next(Interval<ushort> domain)
            => math.add(domain.Left, Next(domain.Width()));

        public IEnumerable<ushort> Stream()
        {
            while(true)
                yield return Next();
        }
    }


}