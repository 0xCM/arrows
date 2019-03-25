//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static corefunc;

    /// <summary>
    /// Defines pseudorandom number generator
    /// </summary>
    /// <remarks> Adapted from http://xoshiro.di.unimi.it/xoshiro256starstar.c</remarks>
    public class RandUInt64
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

        static IEnumerable<ulong> guiseed()
        {
            var g1 = Guid.NewGuid().ToByteArray();
            var g2 = Guid.NewGuid().ToByteArray();
            yield return BitConverter.ToUInt64(g1,0);
            yield return BitConverter.ToUInt64(g1,4);
            yield return BitConverter.ToUInt64(g2,0);
            yield return BitConverter.ToUInt64(g2,4);
        }

        readonly ulong[] seed;

        public RandUInt64()
        {
            seed = guiseed().ToArray();
            jump(J128);
        }

        public RandUInt64(ulong[] seed)
        {
            this.seed = seed;
        }

        public ulong next() 
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
                    next();	
                }
                
            seed[0] = s0;
            seed[1] = s1;
            seed[2] = s2;
            seed[3] = s3;
        }              
    }

}