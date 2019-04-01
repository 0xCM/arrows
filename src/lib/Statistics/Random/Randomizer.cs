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
    public class Randomizer 
    {
        /* When supplied to the jump function, it is equivalent
        to 2^128 calls to next(); it can be used to generate 2^128
        non-overlapping subsequences for parallel computations. */
        static readonly ulong[] J128 = 
            { 0x180ec6d33cfd0aba, 0xd5a61266f0c9392c, 
              0xa9582618e03fc9aa, 0x39abdc4529b1661c };

        /* When supplied ot the jump function, t is equivalent to
        2^192 calls to next(); it can be used to generate 2^64 starting points,
        from each of which jump() will generate 2^64 non-overlapping
        subsequences for parallel distributed computations. */
        static readonly ulong[] J192 = 
            { 0x76e15d3efefdcbbf, 0xc5004e441c522fb3, 
              0x77710069854ee241, 0x39109bb02acbe635 };

        static ulong rotl(ulong x, int k) 
            => (x << k) | (x >> (64 - k));

        static ulong[] guiseed()
            => items(Guid.NewGuid(), Guid.NewGuid()).ToLongArray();


        readonly ulong[] seed;

        public Randomizer()
        {
            seed = guiseed();
            jump(J128);
        }

        public Randomizer(Guid g1, Guid g2)
        {
            this.seed = items(g1,g2).ToLongArray();
            jump(J128);
        }

        public Randomizer(ulong[] seed)
        {
            this.seed = seed;
            jump(J128);
        }

        [MethodImpl(Inline)]
        public real<ulong> one() 
        {
            var next = rotl(seed[1] * 5, 7) * 9;
            var t = seed[1] << 17;

            seed[2] ^= seed[0];
            seed[3] ^= seed[1];
            seed[1] ^= seed[2];
            seed[0] ^= seed[3];

            seed[2] ^= t;

            seed[3] = rotl(seed[3], 45);

            return next;
        }


        void jump(ulong[] J) 
        {            
            var s0 = 0UL;
            var s1 = 0UL;
            var s2 = 0UL;
            var s3 = 0UL;
            for(var i = 0; i < J.Length; i++)
                for(var b = 0; b < 64; b++) 
                {
                    var j = J[i] & 1UL << b;
                    if (j != 0) 
                    {
                        s0 ^= seed[0];
                        s1 ^= seed[1];
                        s2 ^= seed[2];
                        s3 ^= seed[3];
                    }
                    one();	
                }
                
            seed[0] = s0;
            seed[1] = s1;
            seed[2] = s2;
            seed[3] = s3;
        }          

        public byte one(byte min, byte max)
        {
            var width = (ulong)(max - min);
            var offset = (ulong)(min + 1);
            var result = one().data % width + offset;
            return (byte)result;            
        }

        public double one(double min, double max)
        {
            var width = max - min;
            var offset = min + 1;
            var @base = (double)one().data;
            return (@base % width + offset)/width;
        }

        public ushort one(ushort min, ushort max)
        {
            var width = (ulong)(max - min);
            var offset = (ulong)(min + 1);
            var result = one().data % width + offset;
            return (ushort)result;            
        }

        public uint one(uint min, uint max)
        {
            var width = (ulong)(max - min);
            var offset = (ulong)(min + 1);
            var result = one().data % width + offset;
            return (uint)result;            
        }

        public ulong one(ulong min, ulong max)
        {
            var width = max - min;
            var offset = min + 1;
            var result = one().data % width + offset;
            return result;            
        }

        public IEnumerable<ulong> many(ulong count)
        {
            for(var j = 0u; j<count; j++)
                yield return one();
        }

        public IEnumerable<ulong> many(ulong count, ulong min, ulong max)
        {
            var width = max - min;
            var offset = min + 1;
            foreach(var n in many(count))
                yield return (n % width + offset);
        }

        public IEnumerable<uint> many(ulong count, uint min, uint max)
            => many(count, (ulong)min, (ulong)max).Cast<uint>();

        public IEnumerable<ushort> many(ulong count, ushort min, ushort max)
            => many(count, (ulong)min, (ulong)max).Cast<ushort>();

        public IEnumerable<byte> many(ulong count, byte min, byte max)
            => many(count, (ulong)min, (ulong)max).Cast<byte>();


    }

}