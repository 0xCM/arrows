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

    public interface IRandomStream<T>
        where T : struct, IEquatable<T>
    {
        IEnumerable<T> stream(Interval<T> domain);
    }
    

    public interface IRandom<T>
        where T : struct, IEquatable<T>
    {
        
        IEnumerable<T> stream(T min, T max);        
    }

    public interface IRandomizer
    {
        /// <summary>
        /// Obtains the next ulong random value
        /// </summary>
        ulong next();

        /// <summary>
        /// Obtains a random stream of ulong values
        /// </summary>
        IEnumerable<ulong> stream();

        /// <summary>
        /// Obtains a random bitstream
        /// </summary>
        IEnumerable<bit> bits();

        /// <summary>
        /// Obtains a random stream whose values are between a specified min and max.
        /// </summary>
        /// <param name="min">The smallest number to yield</param>
        /// <param name="max">The largest number to yield</param>
        IEnumerable<byte> stream(byte min, byte max);

        /// <summary>
        /// Obtains a random stream whose values are within a specified interval.
        /// </summary>
        /// <param name="domain">The random value domain</param>
        IEnumerable<byte> stream(Interval<byte> domain);

        /// <summary>
        /// Obtains a random stream whose values are between a specified min and max.
        /// </summary>
        /// <param name="min">The smallest number to yield</param>
        /// <param name="max">The largest number to yield</param>
        IEnumerable<sbyte> stream(sbyte min, sbyte max);

        /// <summary>
        /// Obtains a random stream whose values are within a specified interval.
        /// </summary>
        /// <param name="domain">The random value domain</param>
        IEnumerable<sbyte> stream(Interval<sbyte> domain);

        /// <summary>
        /// Obtains a random stream whose values are between a specified min and max.
        /// </summary>
        /// <param name="min">The smallest number to yield</param>
        /// <param name="max">The largest number to yield</param>
        IEnumerable<short> stream(short min, short max);

        /// <summary>
        /// Obtains a random stream whose values are within a specified interval.
        /// </summary>
        /// <param name="domain">The random value domain</param>
        IEnumerable<short> stream(Interval<short> domain);

        /// <summary>
        /// Obtains a random stream whose values are between a specified min and max.
        /// </summary>
        /// <param name="min">The smallest number to yield</param>
        /// <param name="max">The largest number to yield</param>
        IEnumerable<ushort> stream(ushort min, ushort max);

        /// <summary>
        /// Obtains a random stream whose values are within a specified interval.
        /// </summary>
        /// <param name="domain">The random value domain</param>
        IEnumerable<ushort> stream(Interval<ushort> domain);

        /// <summary>
        /// Obtains a random stream whose values are between a specified min and max.
        /// </summary>
        /// <param name="min">The smallest number to yield</param>
        /// <param name="max">The largest number to yield</param>
        IEnumerable<int> stream(int min, int max);

        /// <summary>
        /// Obtains a random stream whose values are within a specified interval.
        /// </summary>
        /// <param name="domain">The random value domain</param>
        IEnumerable<int> stream(Interval<int> domain);

        /// <summary>
        /// Obtains a random stream whose values are between a specified min and max.
        /// </summary>
        /// <param name="min">The smallest number to yield</param>
        /// <param name="max">The largest number to yield</param>
        IEnumerable<uint> stream(uint min, uint max);

        /// <summary>
        /// Obtains a random stream whose values are within a specified interval.
        /// </summary>
        /// <param name="domain">The random value domain</param>
        IEnumerable<uint> stream(Interval<uint> domain);

        /// <summary>
        /// Obtains a random stream whose values are between a specified min and max.
        /// </summary>
        /// <param name="min">The smallest number to yield</param>
        /// <param name="max">The largest number to yield</param>
        IEnumerable<long> stream(long min, long max);

        /// <summary>
        /// Obtains a random stream whose values are within a specified interval.
        /// </summary>
        /// <param name="domain">The random value domain</param>
        IEnumerable<long> stream(Interval<long> domain);

        /// <summary>
        /// Obtains a random stream whose values are between a specified min and max.
        /// </summary>
        /// <param name="min">The smallest number to yield</param>
        /// <param name="max">The largest number to yield</param>
        IEnumerable<ulong> stream(ulong min, ulong max);

        /// <summary>
        /// Obtains a random stream whose values are within a specified interval.
        /// </summary>
        /// <param name="domain">The random value domain</param>
        IEnumerable<ulong> stream(Interval<ulong> domain);

        /// <summary>
        /// Obtains a random stream whose values are between a specified min and max.
        /// </summary>
        /// <param name="min">The smallest number to yield</param>
        /// <param name="max">The largest number to yield</param>
        IEnumerable<float> stream(float min, float max);
        
        /// <summary>
        /// Obtains a random stream whose values are within a specified interval.
        /// </summary>
        /// <param name="domain">The random value domain</param>
        IEnumerable<float> stream(Interval<float> domain);


        /// <summary>
        /// Obtains a random stream whose values are between a specified min and max.
        /// </summary>
        /// <param name="min">The smallest number to yield</param>
        /// <param name="max">The largest number to yield</param>
        IEnumerable<double> stream(double min, double max);

        /// <summary>
        /// Obtains a random stream whose values are within a specified interval.
        /// </summary>
        /// <param name="domain">The random value domain</param>
        IEnumerable<double> stream(Interval<double> domain);

        /// <summary>
        /// Obtains a random stream whose values are between a specified min and max.
        /// </summary>
        /// <param name="min">The smallest number to yield</param>
        /// <param name="max">The largest number to yield</param>
        IEnumerable<decimal> stream(decimal min, decimal max);
 
         /// <summary>
        /// Obtains a random stream whose values are within a specified interval.
        /// </summary>
        /// <param name="domain">The random value domain</param>
        IEnumerable<decimal> stream(Interval<decimal> domain);
   }

    /// <summary>
    /// Defines pseudorandom number generator
    /// </summary>
    /// <remarks> Adapted from http://xoshiro.di.unimi.it/xoshiro256starstar.c</remarks>
    public class Randomizer : IRandomizer,
        IRandomStream<byte>,
        IRandomStream<sbyte>,
        IRandomStream<short>,
        IRandomStream<ushort>,
        IRandomStream<int>,
        IRandomStream<uint>,
        IRandomStream<long>,
        IRandomStream<ulong>,
        IRandomStream<float>,
        IRandomStream<double>,
        IRandomStream<decimal>
    {
        
        /// <summary>
        /// Constructs a random stream using a specific seed
        /// </summary>
        /// <param name="seed">The seed upon which generation is predicated</param>
        public static IRandomStream<T> define<T>(ulong[] seed)
            where T : struct, IEquatable<T>
                => (IRandomStream<T>)new Randomizer(seed);

        /// <summary>
        /// Constructs a randomizer using a specific seed
        /// </summary>
        /// <param name="seed">The seed upon which generation is predicated</param>
        public static IRandomizer define(ulong[] seed)
            => new Randomizer(seed);

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
            if(!(min < max))
                throw new ArgumentException($"{min} !< {max}");

            var width = (ulong)(max - min);
            var offset = (ulong)(min + 1);
            var result = next() % width + offset;
            return (byte)result;            
        }

        [MethodImpl(Inline)]
        public sbyte one(sbyte min, sbyte max)
        {
            var width = (byte)(max - min);
            var uVal = one((byte)0, width);
            return (sbyte)(max - uVal);
        }



        [MethodImpl(Inline)]
        public uint one(uint min, uint max)
        {
            var width = (ulong)(max - min);
            var offset = (ulong)(min + 1);
            var result = next() % width + offset;
            return (uint)result;            
        }


        [MethodImpl(Inline)]
        public ulong one(ulong min, ulong max)
        {
            var width = max - min;
            var offset = min + 1;
            return next() % width + offset;
            
        }


        public IEnumerable<ulong> stream()
        {
            while(true)
                yield return next();
        }

        public IEnumerable<ulong> stream(ulong min, ulong max)
        {
            if(!(min < max))
                throw new ArgumentException($"{min} !< {max}");

            var width = max - min;
            foreach(var n in stream())
                yield return ( n % width + min);
        }

        public IEnumerable<ulong> stream(Interval<ulong> domain)        
            => stream(domain.left, domain.right);

        public IEnumerable<byte> stream(byte min, byte max)
            => from x in stream((ulong)min, (ulong)max) select (byte)x;

        public IEnumerable<byte> stream(Interval<byte> domain)        
            => stream(domain.left, domain.right);

        public IEnumerable<sbyte> stream(sbyte min, sbyte max)
        {
            if(!(min < max))
                throw new ArgumentException($"{min} !< {max}");
            while(true)
                yield return one(min,max);
        }

        public IEnumerable<sbyte> stream(Interval<sbyte> domain)        
            => stream(domain.left, domain.right);

        [MethodImpl(Inline)]
        public ushort one(ushort min, ushort max)
        {
            var width = (ulong)(max - min);
            var offset = (ulong)(min + 1);
            var result = next() % width + offset;
            return (ushort)result;            
        }

        public IEnumerable<ushort> stream(ushort min, ushort max)
        {
            if(!(min < max))
                throw new ArgumentException($"{min} !< {max}");
            
            while(true)
                yield return one(min,max);
        }

        public IEnumerable<ushort> stream(Interval<ushort> domain)        
            => stream(domain.left, domain.right);


        [MethodImpl(Inline)]
        public short one(short min, short max)
        {
            var width = (ushort)(max - min);
            var uVal = one((ushort)0, width);
            return (short)(max - uVal);
        }

        public IEnumerable<short> stream(short min, short max)
        {
            if(!(min < max))
                throw new ArgumentException($"{min} !< {max}");
            
            while(true)
                yield return one(min,max);
        }

        public IEnumerable<short> stream(Interval<short> domain)        
            => stream(domain.left, domain.right);

        public IEnumerable<uint> stream(uint min, uint max)
            => stream((ulong)min, ((ulong)max)).Select(x => (uint)x);

        public IEnumerable<uint> stream(Interval<uint> domain)        
            => stream(domain.left, domain.right);

        [MethodImpl(Inline)]
        public int one(int min, int max)
        {
            var width = (uint)(max - min);
            var uVal = one((uint)0, width);
            return (int)(max - uVal);
        }

        public IEnumerable<int> stream(int min, int max)
        {
            if(!(min < max))
                throw new ArgumentException($"{min} !< {max}");

            while(true)
                yield return one(min,max);
        }

        public IEnumerable<int> stream(Interval<int> domain)        
            => stream(domain.left, domain.right);

        [MethodImpl(Inline)]
        public long one(long min, long max)
        {
            var width = (ulong)(max - min);
            var uVal = one((ulong)0, width);
            return max - (long)uVal;
        }

        public IEnumerable<long> stream(long min, long max)
        {
            if(!(min < max))
                throw new ArgumentException($"{min} !< {max}");

            while(true)
                yield return one(min,max);
        }

        public IEnumerable<long> stream(Interval<long> domain)        
            => stream(domain.left, domain.right);

        [MethodImpl(Inline)]
        double nextf64n()
            => ((double) one(uint.MinValue, uint.MaxValue))/(double)(uint.MaxValue);

        [MethodImpl(Inline)]
        public double one(double min, double max)
        {
            var width = (ulong)(max - min);
            var whole = max - one(0ul, width);
            var part = nextf64n();
            return whole + part;        
        }

        public IEnumerable<double> stream(double min, double max)
        {
            if(!(min < max))
                throw new ArgumentException($"{min} !< {max}");

            var wMax = Math.Floor(max);
            var width = (ulong)(max - min);

            while(true)
                yield return (wMax - next() % width) + nextf64n();        

        }

        public IEnumerable<double> stream(Interval<double> domain)        
            => stream(domain.left, domain.right);

        [MethodImpl(Inline)]
        float nextf32n()
            =>((float) one(ushort.MinValue, ushort.MaxValue))/((float)ushort.MaxValue);
        
        [MethodImpl(Inline)]
        public float one(float min, float max)
        {
            var width = (uint)(max - min);
            var whole = max - one(0u, width);
            var part = nextf32n();
            var result = whole + part;       
            return result;
        }
 
        public IEnumerable<float> stream(float min, float max)
        {
            if(!(min < max))
                throw new ArgumentException($"{min} !< {max}");

            while(true)
                yield return one(min,max);
        }

        public IEnumerable<float> stream(Interval<float> domain)        
            => stream(domain.left, domain.right);

        public IEnumerable<decimal> stream(decimal min, decimal max)
        {
            if(!(min < max))
                throw new ArgumentException($"{min} !< {max}");

            var width = max - min;
            var offset = min + 1m;
            while(true)
            {
                var @base = (decimal)next();
                yield return (@base % width + offset)/width;
            }
        }

        public IEnumerable<decimal> stream(Interval<decimal> domain)        
            => stream(domain.left, domain.right);
    }
}