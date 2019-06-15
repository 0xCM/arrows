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
    using System.Text;

    using static zfunc;
    using static As;

    public static partial class UniformRandom
    {
        public static IEnumerable<T> UniformStream<T>(this IRandomSource src, Interval<T> domain, Func<T,bool> filter = null)
            where T : struct
        {

            if(filter != null)
                return src.FilteredStream(domain,filter);
            else
                return src.UnfilteredStream(domain);

        }
        public static IEnumerable<T> UniformStream<T>(this IRandomSource src, Interval<T>? domain = null, Func<T,bool> filter = null)
            where T : struct
        {
            if(filter != null)
                return src.FilteredStream(domain.Configure(),filter);
            else
                return src.UnfilteredStream(domain.Configure());
        }

        [MethodImpl(Inline)]
        static T UniformPoint<T>(this IRandomSource src, Interval<T> domain)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(src.Next(domain.As<sbyte>()));
            else if(typeof(T) == typeof(byte))
                return generic<T>(src.Next(domain.As<byte>()));                    
            else if(typeof(T) == typeof(short))
                return generic<T>(src.Next(domain.As<short>()));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(src.Next(domain.As<ushort>()));
            else if(typeof(T) == typeof(int))
                return generic<T>(src.Next(domain.As<int>()));
            else if(typeof(T) == typeof(uint))
                return generic<T>(src.Next(domain.As<uint>()));
            else if(typeof(T) == typeof(long))
                return generic<T>(src.Next(domain.As<long>()));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(src.Next(domain.As<ulong>()));
            else if(typeof(T) == typeof(float))
                return generic<T>(src.Next(domain.As<float>()));
            else if(typeof(T) == typeof(double))
                return generic<T>(src.Next(domain.As<double>()));
            else throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        static T UniformPoint<T>(this IRandomSource src)
            where T : struct
        {
            var domain = TypeBoundDomain<T>();
            if(typeof(T) == typeof(sbyte))
                return generic<T>(src.Next(domain.As<sbyte>()));
            else if(typeof(T) == typeof(byte))
                return generic<T>(src.Next(domain.As<byte>()));                    
            else if(typeof(T) == typeof(short))
                return generic<T>(src.Next(domain.As<short>()));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(src.Next(domain.As<ushort>()));
            else if(typeof(T) == typeof(int))
                return generic<T>(src.Next(domain.As<int>()));
            else if(typeof(T) == typeof(uint))
                return generic<T>(src.Next(domain.As<uint>()));
            else if(typeof(T) == typeof(long))
                return generic<T>(src.Next(domain.As<long>()));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(src.Next(domain.As<ulong>()));
            else if(typeof(T) == typeof(float))
                return generic<T>(src.Next(domain.As<float>()));
            else if(typeof(T) == typeof(double))
                return generic<T>(src.Next(domain.As<double>()));
            else throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static T Next<T>(this IRandomSource src, Interval<T>? domain = null)
            where T : struct
                => domain.MapValueOrElse(d => src.UniformPoint<T>(d), () => src.UniformPoint<T>());

        [MethodImpl(Inline)]
        public static Vec128<T> Vec128<T>(this IRandomSource random, Interval<T>? domain = null, Func<T,bool> filter = null)        
            where T : struct
                => random.Span128<T>(1, domain, filter).ToVec128();

        [MethodImpl(Inline)]
        public static Vec256<T> Vec256<T>(this IRandomSource random, Interval<T>? domain = null, Func<T,bool> filter = null)        
            where T : struct
                => random.Span256<T>(1, domain, filter).ToVec256();

        /// <summary>
        /// Implements Leimire's algorithm for sampling a uniformly distribute random number
        /// in an interval [0,..,max)
        /// </summary>
        /// <param name="rng">A random source</param>
        /// <param name="max">The upper bound for the sample</param>
        /// <remarks>Reference: Fast Random Integer Generation in an Interval, Daniel Lemire 2018</remarks>
        public static ulong NextInteger(this IRandomSource rng, ulong max) 
        {
            var x = rng.NextInteger();
            dinx.mul(x, max, out UInt128 m);
            ulong l = m.lo;
            if (l < max) 
            {
                ulong t = ~max % max;
                while (l < t) 
                {
                    x = rng.NextInteger();
                    m = dinx.mul(x, max, out UInt128 z);
                    l = m.lo;                    
                }
            }
        
            var vec = dinx.shiftrw(m.ToVec128(), 8);
            return vec.ToUInt128().lo;
        }

        public static IEnumerable<ulong> Integers(this IRandomSource rng)
        {
            while(true)
                yield return rng.NextInteger();
        }

        public static IEnumerable<ulong> Integers(this IRandomSource rng, ulong max)
        {
            while(true)
                yield return rng.NextInteger(max);
        }
   
        public static IEnumerable<double> Doubles(this IRandomSource rng)
        {
            while(true)
                yield return rng.NextDouble();
        }

        public static IEnumerable<Bit> Bits(this IRandomSource rng)
        {
            var q = (rng as Rng).BitQ;
            while(true)
            {
                if(q.TryDequeue(out Bit bit))
                {
                    yield return bit;
                }
                else
                {
                    var u64 = rng.NextInteger();
                    for(var i = 0; i< 64; i++)
                    {
                        if(i == 0)
                            yield return testbit(u64, i);
                        else
                            q.Enqueue(testbit(u64, i));
                    }                    
                }                
            }
        }

        [MethodImpl(Inline)]
        public static Bit NextBit(this IRandomSource rng)
            => rng.Bits().First();

        [MethodImpl(Inline)]
        public static Sign NextSign(this IRandomSource rng)
            => rng.NextBit() ? Sign.Positive : Sign.Negative;

        public static IEnumerable<byte> Bytes(this IRandomSource rng)
        {
            var q = (rng as Rng).ByteQ;
            while(true)
            {
                if(q.TryDequeue(out byte b))
                {
                    yield return b;
                }
                else
                {
                    var bytes = BitConverter.GetBytes(rng.NextInteger());
                    for(var i = 0; i< bytes.Length; i++)
                    {
                        if(i == 0)
                            yield return bytes[i];
                        else
                            q.Enqueue(bytes[i]);
                    }                    
                }                
            }
        }

        public static IEnumerable<sbyte> SBytes(this IRandomSource rng)
            => from b in rng.Bytes() select (sbyte)b;


        [MethodImpl(Inline)]
        public static sbyte NextSByte(this IRandomSource rng)
            => rng.SBytes().First();

        [MethodImpl(Inline)]
        static ulong Next(this IRandomSource src, ulong max)
            => src.NextInteger(max);

        [MethodImpl(Inline)]
        static sbyte Next(this IRandomSource src, Interval<sbyte> domain)
        {
            var delta = math.sub(domain.Right,domain.Left);
            var next = 
                delta > 0 
                ? math.add(domain.Left, (sbyte)src.Next((ulong)delta)) 
                : math.add(domain.Left, (sbyte)src.Next((ulong)delta.Negate()));
            return next;
        }

        [MethodImpl(Inline)]
        static byte Next(this IRandomSource src, Interval<byte> domain)
            => math.add(domain.Left, (byte)src.Next((ulong)domain.Width()));

        [MethodImpl(Inline)]
        static short Next(this IRandomSource src, Interval<short> domain)
        {
            var delta = math.sub(domain.Right,domain.Left);
            var next = 
                delta > 0 
                ? math.add(domain.Left, (short)src.Next((ulong)delta)) 
                : math.add(domain.Left, (short)src.Next((ulong)delta.Negate()));
            return next;
        }

        [MethodImpl(Inline)]
        static ushort Next(this IRandomSource src, Interval<ushort> domain)
            => math.add(domain.Left, (ushort)src.Next((ulong)domain.Width()));

        [MethodImpl(Inline)]
        static int Next(this IRandomSource src, Interval<int> domain)
        {
            var delta = math.sub(domain.Right, domain.Left);
            return delta > 0 
                ? domain.Left + (int)src.Next((ulong)delta) 
                : domain.Left + (int)src.Next((ulong)delta.Negate());
        }

        [MethodImpl(Inline)]
        static uint Next(this IRandomSource src, Interval<uint> domain)
            => math.add(domain.Left, (uint)src.Next((ulong)domain.Width()));

        [MethodImpl(Inline)]
        static long Next(this IRandomSource src, Interval<long> domain)
        {
            var delta = math.sub(domain.Right,domain.Left);
            var next = delta > 0 
                ? domain.Left + (long)src.Next((ulong)delta) 
                : domain.Left + (long)src.Next((ulong)delta.Negate());
            return next;
        }

        [MethodImpl(Inline)]
        static ulong Next(this IRandomSource src, Interval<ulong> domain)
            => domain.Left + src.Next(domain.Width());

        [MethodImpl(Inline)]
        static float Next(this IRandomSource src, Interval<float> domain)
        {
            var whole = (float)src.Next(domain.Convert<int>());
            return whole + (float)src.NextDouble();
        }

        [MethodImpl(Inline)]
        static double Next(this IRandomSource src, Interval<double> domain)
        {
            var whole = (double)src.Next(domain.Convert<long>());
            return whole + src.NextDouble();            
        }
 
        static Interval<T> TypeBoundDomain<T>()
            where T : struct
        {
            var min = gmath.signed<T>() && !gmath.floating<T>()
                ? gmath.negate(gbits.shiftr(gmath.maxval<T>(), 1)) 
                : gmath.zero<T>();
            var max = 
                gmath.signed<T>() && !gmath.floating<T>()
                ? gbits.shiftr(gmath.maxval<T>(), 1)
                : gmath.maxval<T>();
            return leftclosed(min,max);

        }

       [MethodImpl(Inline)]
       static Interval<T> Configure<T>(this Interval<T>? domain)        
            where T : struct
                => domain.ValueOrElse(() => TypeBoundDomain<T>());

        static IEnumerable<T> FilteredStream<T>(this IRandomSource src, Interval<T> domain, Func<T,bool> filter)
            where T : struct
        {
            var next = default(T);    
            while(true)            
            {
                if(typeof(T) == typeof(sbyte))
                    next = generic<T>(src.Next(domain.As<sbyte>()));                    
                else if(typeof(T) == typeof(byte))
                    next = generic<T>(src.Next(domain.As<byte>()));                    
                else if(typeof(T) == typeof(short))
                    next = generic<T>(src.Next(domain.As<short>()));                    
                else if(typeof(T) == typeof(ushort))
                    next = generic<T>(src.Next(domain.As<ushort>()));                    
                else if(typeof(T) == typeof(int))
                    next = generic<T>(src.Next(domain.As<int>()));                    
                else if(typeof(T) == typeof(uint))
                    next = generic<T>(src.Next(domain.As<uint>()));                    
                else if(typeof(T) == typeof(long))
                    next = generic<T>(src.Next(domain.As<long>()));                    
                else if(typeof(T) == typeof(ulong))
                    next = generic<T>(src.Next(domain.As<ulong>()));                    
                else if(typeof(T) == typeof(float))
                    next = generic<T>(src.Next(domain.As<float>()));                    
                else if(typeof(T) == typeof(double))
                    next = generic<T>(src.Next(domain.As<double>()));                    
                else throw unsupported<T>();

                if(filter(next))
                    yield return next;
            }
        }

        static IEnumerable<T> UnfilteredStream<T>(this IRandomSource src, Interval<T> domain)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
            {
                var range = domain.As<sbyte>();
                while(true)
                    yield return generic<T>(src.Next(range));                    
            }
            else if(typeof(T) == typeof(byte))
            {
                var range = domain.As<byte>();
                while(true)
                    yield return generic<T>(src.Next(range));                    
            }
            else if(typeof(T) == typeof(short))
            {
                var range = domain.As<short>();
                while(true)
                    yield return generic<T>(src.Next(range));
            }
            else if(typeof(T) == typeof(ushort))
            {
                var range = domain.As<ushort>();
                while(true)
                    yield return generic<T>(src.Next(range));
            }
            else if(typeof(T) == typeof(int))
            {
                var range = domain.As<int>();
                while(true)
                    yield return generic<T>(src.Next(range));
            }
            else if(typeof(T) == typeof(uint))
            {
                var range = domain.As<uint>();
                while(true)
                    yield return generic<T>(src.Next(range));
            }
            else if(typeof(T) == typeof(long))
            {
                var range = domain.As<long>();
                while(true)
                    yield return generic<T>(src.Next(range));
            }
            else if(typeof(T) == typeof(ulong))
            {
                var range = domain.As<ulong>();
                while(true)
                    yield return generic<T>(src.Next(range));
            }
            else if(typeof(T) == typeof(float))
            {
                var range = domain.As<float>();
                while(true)
                    yield return generic<T>(src.Next(range));
            }
            else if(typeof(T) == typeof(double))
            {
                var range = domain.As<double>();
                while(true)
                    yield return generic<T>(src.Next(range));
            }
            else throw unsupported<T>();
        }


    }

}