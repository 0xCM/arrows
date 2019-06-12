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
    public class XOrStarStar256 : Rng,
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
        IRandomizer<decimal>

    {        
        public static Interval<T> Domain<T>(Interval<T>? domain)
            where T : struct
                => domain ?? RngDefaults.get<T>().SampleDomain;

        /// <summary>
        /// Constructs a random stream using a specific seed
        /// </summary>
        /// <param name="seed">The seed upon which generation is predicated</param>
        public static IRandomizer<T> define<T>(ulong[] seed)
            where T : struct
                => (IRandomizer<T>)new XOrStarStar256(seed);

        /// <summary>
        /// Constructs a randomizer using a specific seed
        /// </summary>
        /// <param name="seed">The seed upon which generation is predicated</param>
        public static IRandomizer define(ulong[] seed)
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

        static ulong[] guiseed()
            => items(Guid.NewGuid(), Guid.NewGuid()).ToU64Array();

        readonly ulong[] seed;


        public XOrStarStar256()
        {
            seed = guiseed();
            jump(J128);
        }

        public XOrStarStar256(Guid g1, Guid g2)
        {
            this.seed = items(g1,g2).ToU64Array();
            jump(J128);
        }

        public XOrStarStar256(ulong[] seed)
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
                    NextInteger();	
                }
                
            seed[0] = s0;
            seed[1] = s1;
            seed[2] = s2;
            seed[3] = s3;
        }          

        [MethodImpl(Inline)]
        public ulong NextInteger()
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

        [MethodImpl(Inline)]
        static T mod<T>(ulong lhs, ulong rhs)
            where T : struct
                => convert<ulong,T>(lhs % rhs);

        [MethodImpl(Inline)]
        static ulong width<T>(Interval<T> domain)
            where T : struct
                => convert<T,ulong>(domain.Right) - convert<T,ulong>(domain.Left);

        public IEnumerable<ulong> Stream(Interval<ulong> domain)        
            => this.UniformStream(domain);

        public IEnumerable<double> Doubles()
        {
            while(true)
                yield return NextDouble();
        }

        public IEnumerable<ulong> Integers()
        {
            while(true)
                yield return NextInteger();
        }

        public IEnumerable<Bit> Bits()
        {
            while(true)
            {
                var bits = NextInteger();
                for(var i = 0; i< 64; i++)
                    yield return testbit(bits, i);
            }
        }

        public IEnumerable<byte> Bytes()
        {
            while(true)
            {
                if(ByteQ.TryDequeue(out byte b))
                {
                    yield return b;
                }
                else
                {
                    var bytes = BitConverter.GetBytes(NextInteger());
                    for(var i = 0; i< bytes.Length; i++)
                    {
                        if(i == 0)
                            yield return bytes[i];
                        else
                            ByteQ.Enqueue(bytes[i]);
                    }                    
                }                
            }
        }

        public IEnumerable<sbyte> SBytes()
            => from b in Bytes() select (sbyte)b;

        public sbyte NextSByte()
            => SBytes().First();

        [MethodImpl(Inline)]
        float nextF32()        
            => (float)((double)NextInteger()/(double)ulong.MaxValue);                                    

        [MethodImpl(Inline)]
        public double NextDouble()
            => ((double)NextInteger()/(double)ulong.MaxValue);

        [MethodImpl(Inline)]
        public Bit NextBit()
            => Bits().First();

        [MethodImpl(Inline)]
        public Sign NextSign()
            => NextBit() ? Sign.Positive : Sign.Negative;

        [MethodImpl(Inline)]
        public byte NextByte()
            => Bytes().First();

        public IEnumerable<sbyte> Stream(Interval<sbyte> domain)        
        {
            var w = width(domain);
            while(true)
                yield return (sbyte)(mod<int>(NextInteger(), w) + domain.Left);
        }

        public IEnumerable<byte> Stream(Interval<byte> domain)        
        {
            var w = width(domain);
            while(true)
                yield return (byte)(mod<int>(NextInteger(), w) + domain.Left);                
        }

        public IEnumerable<short> Stream(Interval<short> domain)        
        {
            var w = width(domain);
            while(true)
                yield return (short)(mod<int>(NextInteger(),w) + domain.Left);                
        }

        public IEnumerable<ushort> Stream(Interval<ushort> domain)        
        {
            var w = width(domain);
            while(true)
                yield return (ushort) (mod<int>(NextInteger(), w) + domain.Left);                
        }

        public IEnumerable<int> Stream(Interval<int> domain)
            => this.UniformStream(domain);

        public IEnumerable<uint> Stream(Interval<uint> domain)
            => this.UniformStream(domain);

        public IEnumerable<long> Stream(Interval<long> domain)        
            => this.UniformStream(domain);
        
        public IEnumerable<float> Stream(Interval<float> domain)        
            => this.UniformStream(domain);

        public IEnumerable<double> Stream(Interval<double> domain)        
            => this.UniformStream(domain);

        public IEnumerable<decimal> Stream(Interval<decimal> domain)        
        {
            var width = domain.Right - domain.Left;            
            while(true)
            {
                var ratio = (decimal)NextDouble() + 1;
                var sign = Bits().Take(1).Single() ? -1.0m : 1.0m;
                yield return sign * (domain.Right - (ratio * width)/2.0m);
            }
        }
 



        public void StreamTo<T>(Interval<T> domain, int count, ref T dst, Func<T,bool> filter = null)
            where T : struct
        {
            var it = this.Stream<T>(domain,filter).Take(count).GetEnumerator();
            var counter = 0;
            while(it.MoveNext())
                Unsafe.Add(ref dst, counter++) = it.Current;
        }

    }
}