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

        public IEnumerable<bit> bits()
        {
            while(true)
            {
                var i = next();
                foreach(var b in i.ToBitString().bits)
                    yield return b;
            }
        }

        [MethodImpl(Inline)]
        public byte one(byte min, byte max)
        {
            var width = (ulong)(max - min);
            var offset = (ulong)(min + 1);
            var result = next() % width + offset;
            return (byte)result;            
        }

        [MethodImpl(Inline)]
        public sbyte one(sbyte min, sbyte max)
            => (sbyte)one((byte)(min),(byte)max);

        [MethodImpl(Inline)]
        public ushort one(ushort min, ushort max)
        {
            var width = (ulong)(max - min);
            var offset = (ulong)(min + 1);
            var result = next() % width + offset;
            return (ushort)result;            
        }

        [MethodImpl(Inline)]
        public short one(short min, short max)
            => (short)one((ushort)(min),(ushort)max);

        [MethodImpl(Inline)]
        public uint one(uint min, uint max)
        {
            var width = (ulong)(max - min);
            var offset = (ulong)(min + 1);
            var result = next() % width + offset;
            return (uint)result;            
        }

        [MethodImpl(Inline)]
        public int one(int min, int max)
            => (int)one((uint)(min),(uint)max);


        [MethodImpl(Inline)]
        public ulong one(ulong min, ulong max)
        {
            var width = max - min;
            var offset = min + 1;
            var result = next() % width + offset;
            return result;            
        }

        [MethodImpl(Inline)]
        public long one(long min, long max)
            => (long)one((ulong)(min),(ulong)max);

        [MethodImpl(Inline)]
        public double one(double min, double max)
        {
            var value = next();
            var part = ((double) value)/((double)UInt64.MaxValue) - Double.Epsilon;
            var whole = one((long)min, (long)max);
            return whole + part;
        }

        [MethodImpl(Inline)]
        public float one(float min, float max)
        {
            var value = next();
            var part = ((float) value)/((float)UInt64.MaxValue) - Single.Epsilon;
            var whole = one((int)min, (int)max);
            return whole + part;
        }

        IEnumerable<ulong> stream()
        {
            while(true)
                yield return next();
        }

        /// <summary>
        /// Streams a uniformly random sequence of bounded ulong values
        /// </summary>
        /// <param name="min">The minimum value</param>
        /// <param name="max">The maximum value</param>
        public IEnumerable<ulong> stream(ulong min, ulong max)
        {
            var width = max - min;
            var offset = min + 1;
            foreach(var n in stream())
                yield return (n % width + offset);
        }

        /// <summary>
        /// Streams a uniformly random sequence of bounded byte values
        /// </summary>
        /// <param name="min">The minimum value</param>
        /// <param name="max">The maximum value</param>
        public IEnumerable<byte> stream(byte min, byte max)
            => from x in stream((ulong)min, (ulong)max) select (byte)x;

        /// <summary>
        /// Streams a uniformly random sequence of bounded sbyte values
        /// </summary>
        /// <param name="min">The minimum value</param>
        /// <param name="max">The maximum value</param>
        public IEnumerable<sbyte> stream(sbyte min, sbyte max)
        {
            while(true)
                yield return one(min,max);
        }

        /// <summary>
        /// Streams a uniformly random sequence of bounded ushort values
        /// </summary>
        /// <param name="min">The minimum value</param>
        /// <param name="max">The maximum value</param>
        public IEnumerable<ushort> stream(ushort min, ushort max)
            => from x in stream((ulong)min, (ulong)max) select (ushort)x;

        /// <summary>
        /// Streams a uniformly random sequence of bounded short values
        /// </summary>
        /// <param name="min">The minimum value</param>
        /// <param name="max">The maximum value</param>
        public IEnumerable<short> stream(short min, short max)
        {
            while(true)
                yield return one(min,max);
        }

        /// <summary>
        /// Streams a uniformly random sequence of bounded uint values
        /// </summary>
        /// <param name="min">The minimum value</param>
        /// <param name="max">The maximum value</param>
        public IEnumerable<uint> stream(uint min, uint max)
            => from x in stream((ulong)min, (ulong)max) select (uint)x;

        /// <summary>
        /// Streams a uniformly random sequence of bounded int values
        /// </summary>
        /// <param name="min">The minimum value</param>
        /// <param name="max">The maximum value</param>
        public IEnumerable<int> stream(int min, int max)
        {
            while(true)
                yield return one(min,max);
        }

        /// <summary>
        /// Streams a uniformly random sequence of bounded long values
        /// </summary>
        /// <param name="min">The minimum value</param>
        /// <param name="max">The maximum value</param>
        public IEnumerable<long> stream(long min, long max)
        {
            while(true)
                yield return one(min,max);
        }

        /// <summary>
        /// Streams a uniformly random sequence of bounded double values
        /// </summary>
        /// <param name="min">The minimum value</param>
        /// <param name="max">The maximum value</param>
        public IEnumerable<double> stream(double min, double max)
        {
            while(true)
                yield return one(min,max);

        }

        /// <summary>
        /// Streams a uniformly random sequence of bounded float values
        /// </summary>
        /// <param name="min">The minimum value</param>
        /// <param name="max">The maximum value</param>
        public IEnumerable<float> stream(float min, float max)
        {
            while(true)
                yield return one(min,max);

        }

        /// <summary>
        /// Streams a uniformly random sequence of bounded decimal values
        /// </summary>
        /// <param name="min">The minimum value</param>
        /// <param name="max">The maximum value</param>
        public IEnumerable<decimal> stream(decimal min, decimal max)
        {
            var width = max - min;
            var offset = min + 1m;
            while(true)
            {
                var @base = (decimal)next();
                yield return (@base % width + offset)/width;
            }
        }
    }

}