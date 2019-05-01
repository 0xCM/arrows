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

    using static zcore;


    /// <summary>
    /// Defines pseudorandom number generator
    /// </summary>
    /// <remarks> Core algorithm taken from http://xoshiro.di.unimi.it/xoshiro256starstar.c</remarks>
    public class Randomizer :
        IRandomizer<byte>,
        IRandomizer<sbyte>,
        IRandomizer<short>,
        IRandomizer<ushort>,
        IRandomizer<int>,
        IRandomizer<uint>,
        IRandomizer<long>,
        IRandomizer<ulong>,
        IRandomizer<float>,
        IRandomizer<double>,
        IRandomizer<decimal>,
        IRandomizer<BigInteger>

    {
        
        /// <summary>
        /// Constructs a random stream using a specific seed
        /// </summary>
        /// <param name="seed">The seed upon which generation is predicated</param>
        public static IRandomizer<T> define<T>(ulong[] seed)
            where T : struct, IEquatable<T>
                => (IRandomizer<T>)new Randomizer(seed);

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

        [MethodImpl(Inline)]
        ulong next()
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

        static T mod<T>(ulong lhs, ulong rhs)
            where T : struct, IEquatable<T>
                => convert<ulong,T>(lhs % rhs);

        static ulong width<T>(Interval<T> domain)
            where T : struct, IEquatable<T>
                => convert<T,ulong>(domain.right) - convert<T,ulong>(domain.left);

        IEnumerable<ulong> stream()
        {
            while(true)
                yield return next();
        }


        [MethodImpl(Inline)]
        static uint hi(ulong src)
            => (uint)(src >> 32);

        [MethodImpl(Inline)]
        static uint lo(ulong src)
            => (uint)src;
                
        [MethodImpl(Inline)]
        static (uint x0, uint x1) unpack(ulong src)
            => (lo(src), hi(src));

        [MethodImpl(Inline)]
        static string bitcharsu32(uint src)
            => zpad(Convert.ToString(src,2), 64);

        [MethodImpl(Inline)]
        static string bitchars64(ulong src)
            => apply(unpack(src), parts 
                => bitcharsu32(parts.x0) + bitcharsu32(parts.x1));

        static BitString ToBitString(ulong src)
            => BitString.define(bit.parse(bitchars64(src)));

        public IEnumerable<bit> bits()
        {
            while(true)
            {
                var i = next();
                foreach(var b in ToBitString(i).bits)
                    yield return b;
            }
        }

        public IEnumerable<byte> stream(Interval<byte> domain)        
        {
            var w = width(domain);
            while(true)
                yield return (byte)(mod<int>(next(), w) + domain.left);                
        }

        public IEnumerable<byte> stream(byte min, byte max)
            => stream(Interval.leftclosed(min,max)); 

        public IEnumerable<sbyte> stream(Interval<sbyte> domain)        
        {
            var w = width(domain);
            while(true)
                yield return (sbyte)(mod<int>(next(), w) + domain.left);
        }

        public IEnumerable<sbyte> stream(sbyte min, sbyte max)
            => stream(Interval.leftclosed(min,max));

        public IEnumerable<ushort> stream(Interval<ushort> domain)        
        {
            var w = width(domain);
            while(true)
                yield return (ushort) (mod<int>(next(), w) + domain.left);                
        }

        public IEnumerable<ushort> stream(ushort min, ushort max)
            => stream(Interval.leftclosed(min,max));

        public IEnumerable<short> stream(Interval<short> domain)        
        {
            var w = width(domain);
            while(true)
                yield return (short)(mod<int>(next(),w) + domain.left);                
        }

        public IEnumerable<short> stream(short min, short max)
            => stream(Interval.leftclosed(min,max));

        public IEnumerable<int> stream(Interval<int> domain)
        {
            var w = width(domain);
            while(true)
                yield return (int)(mod<long>(next(),w) + domain.left);                
        }

        public IEnumerable<int> stream(int min, int max)
            => stream(Interval.leftclosed(min,max));

        public IEnumerable<uint> stream(Interval<uint> domain)
        {
            var w = width(domain);
            while(true)
                yield return mod<uint>(next(), w) + domain.left;                
        }

        public IEnumerable<uint> stream(uint min, uint max)
            => stream(Interval.closed(min,max));

        public IEnumerable<long> stream(Interval<long> domain)        
        {
            var w = width(domain);
            while(true)
                yield return mod<long>(next(), w) + domain.left;                
        }

        public IEnumerable<long> stream(long min, long max)
            => stream(Interval.leftclosed(min,max));

        public IEnumerable<ulong> stream(Interval<ulong> domain)        
        {
            var w = width(domain);
            while(true)
                yield return next() % w + domain.left;
        }

        public IEnumerable<ulong> stream(ulong min, ulong max)
            => stream(Interval.leftclosed(min,max));

       [MethodImpl(Inline)]
        float nextF32()        
            => (float)((double)next()/(double)ulong.MaxValue);                                    
        
        IEnumerable<float> IRandomizer<float>.stream()
        {
            while(true)
                yield return nextF32();
        }

        public IEnumerable<float> stream(Interval<float> domain)        
        {
            var width = domain.right - domain.left;            
            while(true)
            {
                var ratio = nextF32() + 1;
                var sign = bits().Take(1).Single() ? -1.0f : 1.0f;
                yield return sign * (domain.right - (ratio * width)/2.0f);
            }
        }

        public IEnumerable<float> stream(float min, float max)
            => stream(Interval.leftclosed(min,max));

        [MethodImpl(Inline)]
        double nextF64()
            => ((double)next()/(double)ulong.MaxValue);

        [MethodImpl(Inline)]
        int nextSign()
            => bits().Take(1).Single() ? -1 : 1;

        public IEnumerable<double> stream(Interval<double> domain)        
        {
            var width = domain.right - domain.left;            
            while(true)
            {
                var ratio = nextF64() + 1;
                var sign =  nextSign();
                yield return sign * (domain.right - (ratio * width)/2.0);
            }
        }

        public IEnumerable<double> stream(double min, double max)
            => stream(Interval.closed(min,max));


        public IEnumerable<decimal> stream(Interval<decimal> domain)        
        {
            var width = domain.right - domain.left;            
            while(true)
            {
                var ratio = (decimal)nextF64() + 1;
                var sign = bits().Take(1).Single() ? -1.0m : 1.0m;
                yield return sign * (domain.right - (ratio * width)/2.0m);
            }
        }
 
        public IEnumerable<decimal> stream(decimal min, decimal max)
            => stream(Interval.leftclosed(min,max));
                    
        IEnumerable<sbyte> IRandomizer<sbyte>.stream()
            => stream(sbyte.MinValue,sbyte.MaxValue);

        IEnumerable<int> IRandomizer<int>.stream()
            => stream(int.MinValue,int.MaxValue);

        IEnumerable<byte> IRandomizer<byte>.stream()
            => stream(byte.MinValue,byte.MaxValue);

        IEnumerable<short> IRandomizer<short>.stream()
            => stream(short.MinValue,short.MaxValue);

        IEnumerable<long> IRandomizer<long>.stream()
            => stream(long.MinValue,long.MaxValue);

        IEnumerable<ulong> IRandomizer<ulong>.stream()
            => stream();

        IEnumerable<ushort> IRandomizer<ushort>.stream()
            => stream(ushort.MinValue,ushort.MaxValue);

        IEnumerable<uint> IRandomizer<uint>.stream()
            => stream(uint.MinValue, uint.MaxValue);

        IEnumerable<double> IRandomizer<double>.stream()
        {
            while(true)
                yield return nextF64();
        }

        IEnumerable<decimal> IRandomizer<decimal>.stream()
            => from x in stream(0m, 1m)
                select x * nextSign();

        public IEnumerable<BigInteger> stream(Interval<BigInteger> domain)
            => stream((long)domain.left, (long)domain.right).Select(x => new BigInteger(x));

        public IEnumerable<BigInteger> stream(BigInteger min, BigInteger max)
            => stream((long)min, (long)max).Select(x => new BigInteger(x));

        IEnumerable<BigInteger> IRandomizer<BigInteger>.stream()
            => stream(long.MinValue, long.MaxValue).Select(x => new BigInteger(x));
    }
}