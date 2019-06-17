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
    using System.Numerics;

    using static zfunc;

    public abstract class Rng
    {
        internal Queue<Bit> BitQ {get;}
            = new Queue<Bit>(64);

        internal Queue<byte> ByteQ {get;}
            = new Queue<byte>(8);

    }    

    /// <summary>
    /// Defines pseudorandom number generator
    /// </summary>
    /// <remarks> Core algorithm taken from http://xoshiro.di.unimi.it/xoshiro256starstar.c</remarks>
    public class XOrStarStar256 : Rng, IRandomSource
    {        

        /// <summary>
        /// Constructs a randomizer using a specific seed
        /// </summary>
        /// <param name="seed">The seed upon which generation is predicated</param>
        public static IRandomSource define(ulong[] seed)
            => new XOrStarStar256(seed);

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

        readonly ulong[] state;

        public XOrStarStar256(Guid g1, Guid g2)
        {
            this.state = items(g1,g2).ToU64Array();
            jump(J128);
        }

        public XOrStarStar256(ulong[] seed)
        {
            this.state = seed;
            jump(J128);
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
                        s0 ^= state[0];
                        s1 ^= state[1];
                        s2 ^= state[2];
                        s3 ^= state[3];
                    }
                    NextInt();	
                }
                
            state[0] = s0;
            state[1] = s1;
            state[2] = s2;
            state[3] = s3;
        }          

        [MethodImpl(Inline)]
        public ulong NextInt()
        {
            var next = rotl(state[1] * 5, 7) * 9;
            var t = state[1] << 17;

            state[2] ^= state[0];
            state[3] ^= state[1];
            state[1] ^= state[2];
            state[0] ^= state[3];

            state[2] ^= t;

            state[3] = rotl(state[3], 45);

            return next;
        }

        [MethodImpl(Inline)]
        public double NextDouble()
            => ((double)NextInt()/(double)ulong.MaxValue);
 

        [MethodImpl(Inline)]
        public ulong NextInt(ulong max) 
            => this.NextU64(max);

        [MethodImpl(Inline)]
        public int NextInt(int max)
            => this.NextI32(max);

    }
}