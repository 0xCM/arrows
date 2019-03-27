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

    using static zcore;

    /// <summary>
    /// Defines pseudorandom number generator
    /// </summary>
    /// <remarks> Adapted from http://xoshiro.di.unimi.it/xoshiro256starstar.c</remarks>
    public class RandUInt32 : Randomizer<uint>
    {

        const int Bitsize = 32;
        
        [MethodImpl(Inline)]
        static uint rotl(uint x, int k) 
            => (x << k) | (x >> (Bitsize - k));

        static IEnumerable<uint> guiseed()
        {
            var g1 = Guid.NewGuid().ToByteArray();
            var g2 = Guid.NewGuid().ToByteArray();
            yield return BitConverter.ToUInt32(g1,0);
            yield return BitConverter.ToUInt32(g1,4);
            yield return BitConverter.ToUInt32(g2,0);
            yield return BitConverter.ToUInt32(g2,4);
        }

        readonly uint[] seed;

        public RandUInt32()
            => seed = guiseed().ToArray();

        public RandUInt32(uint[] seed)
            => this.seed = seed;
 
        [MethodImpl(Inline)]
        void increment()
        {
            var t = seed[1] << 17;
            seed[2] ^= seed[0];
            seed[3] ^= seed[1];
            seed[1] ^= seed[2];
            seed[0] ^= seed[3];
            seed[2] ^= t;
            seed[3] = rotl(seed[3], 45);
        }
        
        public real<uint> next() 
        {
            var next = rotl(seed[1] * 5, 7) * 9;
            increment(); 
            return next;
        }

        public IEnumerable<real<uint>> next(int count)
        {
            for(var j = 0; j<count; j++)
                yield return next();
        }

    }
}