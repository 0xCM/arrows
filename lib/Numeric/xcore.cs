//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using Z0;
    using static zcore;
    using static nats;

    partial class xcore
    {

        /// <summary>
        /// Yields a stream of primal random vectors
        /// </summary>
        /// <param name="min">The minimum component value</param>
        /// <param name="max">The maximum component value</param>
        /// <typeparam name="N">The natural length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        public static IEnumerable<Vector<N,T>> Vectors<N,T>(this IRandomizer rand, T min, T max)        
            where N : ITypeNat, new()
            where T : struct, IEquatable<T>
        {
                var primal = rand.Random<T>();
            
                static Vector<N,T> vector(N len, IEnumerable<T> src)
                    => Vector.define(len, (src.Take((int)natu<N>())));

                var s = primal.stream(min,max);
                var len = natrep<N>();
                while(true)
                    yield return vector(len,s);
            
        }

        /// <summary>
        /// Yields a stream of primal random vectors
        /// </summary>
        /// <param name="min">The minimum component value</param>
        /// <param name="max">The maximum component value</param>
        /// <typeparam name="N">The natural length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        public static IEnumerable<Vector<N,T>> Vectors<N,T>(this IRandomizer rand, N len, T min, T max)
            where N : ITypeNat, new()
            where T : struct, IEquatable<T>
                => rand.Vectors<N,T>(min,max);

        public static RandomMatrixSource<M,N,T> MatrixSource<M,N,T>(this IRandomizer rand)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct, IEquatable<T>
                => new MatrixSource<M,N,T>(rand);

        /// <summary>
        /// Yields a stream of priamal random matrices
        /// </summary>
        /// <param name="min">The entry value minimum</param>
        /// <param name="max">The entry value maximum</param>
        /// <typeparam name="M">The row dimension</typeparam>
        /// <typeparam name="N">The column dimension</typeparam>
        /// <typeparam name="T">The entry type</typeparam>
        public static IEnumerable<Matrix<M,N,T>> matrices<M,N,T>(this RandomMatrixSource<M,N,T> rms, T min, T max)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct, IEquatable<T>
                => rms.stream(min,max);

        /// <summary>
        /// Yields a stream of primal random matrices
        /// </summary>
        /// <param name="dim">The matrix dimension</param>
        /// <param name="min">The entry value minimum</param>
        /// <param name="max">The entry value maximum</param>
        /// <typeparam name="M">The row dimension</typeparam>
        /// <typeparam name="N">The column dimension</typeparam>
        /// <typeparam name="T">The entry type</typeparam>
        public static IEnumerable<Matrix<M,N,T>> matrices<M,N,T>(this RandomMatrixSource<M,N,T> rms, Dim<M,N> dim, T min, T max)
             where M : ITypeNat, new()
             where N : ITypeNat, new()
             where T : struct, IEquatable<T>
                => rms.stream(min,max);

        /// <summary>
        /// Determines whether the point lies within the interval
        /// </summary>
        /// <param name="src">The interval</param>
        /// <param name="point">The test point</param>
        /// <typeparam name="T">The domain of the point</typeparam>
        [MethodImpl(Inline)]
        public static bool Contains<T>(this Interval<T> src, T point)
            where T : struct, IEquatable<T> 
                => src.Contains(point);

        [MethodImpl(Inline)]
        public static bool Contains<T>(this IIntervalX<T> interval, T point)
            where T : struct, IEquatable<T>
                => interval.kind switch {
                        IntervalKind.Closed 
                            => primops.gteq(point,interval.left) && primops.lteq(point, interval.right),
                        IntervalKind.Open 
                            => primops.gt(point, interval.left) && primops.lt(point, interval.right),
                        IntervalKind.LeftClosed 
                            => primops.gteq(point, interval.left) && primops.lt(point, interval.right),
                        IntervalKind.RightClosed 
                            => primops.gt(point, interval.left) && primops.lteq(point, interval.right),
                        _ => throw new ArgumentException()
                };


        [MethodImpl(Inline)]
        public static Index<T> Discretize<T>(this Interval<T> src, T? step = null)
            where T : struct, IEquatable<T> 
                => DiscretizationStream(src, step).ToIndex();

        static IEnumerable<T> DiscretizationStream<T>(this Interval<T> src, T? step = null)
            where T : struct, IEquatable<T>
        {            
            var ops = primops.typeops<T>();

            var width = step ?? ops.one;

            if(src.leftclosed)
                yield return src.left;
            
            var next = ops.add(src.left, width);
            while(ops.lt(next,src.right))
            {
                yield return next;
                next = ops.add(next, width);
            }

            if(src.rightclosed)
                yield return src.right;
        }

        // <summary>
        /// Partitions an interval into a specified number of pieces
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <param name="parts">The number of partition points</param>
        /// <typeparam name="T">The underlying interval type</typeparam>
        public static IEnumerable<floatg<T>> Partition<T>(this IIntervalX<floatg<T>> src, floatg<T> parts)
            where T : struct, IEquatable<T>
        {
            
            if(parts.neq(floatg<T>.Zero))
            {            
                var width = (src.right - src.left)/parts;
                var current = src.left;
                
                yield return src.left;
                for(var i = floatg<T>.Zero; i < parts - floatg<T>.One; i++)
                {
                    current += width;
                    yield return current;
                }
                yield return src.right;
            }
        }

        /// <summary>
        /// Partitions an interval into a specified number of pieces
        /// </summary>
        /// <param name="src">The source interval</param>
        /// <param name="parts">The number of partition points</param>
        /// <typeparam name="T">The underlying interval type</typeparam>
        [MethodImpl(Inline)]
        public static Index<floatg<T>> Discretize<T>(this Interval<floatg<T>> src, floatg<T> parts)   
            where T : struct, IEquatable<T>
                => src.Partition(parts).ToIndex();

        [MethodImpl(Inline)]   
        public static T[] Unwrap<T>(this intg<T>[] src)
            where T : struct, IEquatable<T>
                => map(src,unwrap);

        [MethodImpl(Inline)]   
        public static IEnumerable<T> Unwrap<T>(this IEnumerable<intg<T>> src)
            where T : struct, IEquatable<T>
                => map(src,unwrap);

        [MethodImpl(Inline)]   
        public static Index<T> Unwrap<T>(this Index<intg<T>> src)
            where T : struct, IEquatable<T>
                => map(src,unwrap);


        [MethodImpl(Inline)]   
        public static IEnumerable<T> Unwrap<T>(this IEnumerable<real<T>> src)
            where T : struct, IEquatable<T>
                => map(src,unwrap);

        [MethodImpl(Inline)]   
        public static T[] Unwrap<T>(this real<T>[] src)
            where T : struct, IEquatable<T>
                => map(src,unwrap);

        [MethodImpl(Inline)]   
        public static Index<T> Unwrap<T>(this Index<real<T>> src)
            where T : struct, IEquatable<T>
                => map(src, unwrap);

        [MethodImpl(Inline)]
        public static T Sum<T>(this IEnumerable<T> src)
            where T : Structures.Additive<T>, Structures.Nullary<T>, new()
                => sum(src);

        [MethodImpl(Inline)]
        public static T Sup<T>(this IEnumerable<T> src)
            where T : struct, Structures.Orderable<T>
                => max(src);

        [MethodImpl(Inline)]
        public static T Inf<T>(this T[] src)
            where T : struct, Structures.Orderable<T>
                => min(src);

        [MethodImpl(Inline)]
        public static IEnumerable<T> Pow<T>(this IEnumerable<T> src, int exp)
            where T : Structures.NaturallyPowered<T>, new() 
                => pow(src,exp);

        [MethodImpl(Inline)]
        public static Slice<T> Pow<T>(this Slice<T> src, int exp)
            where T : struct, Structures.NaturallyPowered<T>
                => slice(pow(src,exp));

        [MethodImpl(Inline)]
        public static T Avg<T>(this IEnumerable<T> src)
            where T : Structures.RealNumber<T>,new()
                => avg(src);

        [MethodImpl(Inline)]   
        public static string ToHexString(this byte x)
            => hexstring(x);

        [MethodImpl(Inline)]   
        public static string ToHexString(this sbyte x)
            => hexstring(x);

        [MethodImpl(Inline)]   
        public static string ToHexString(this short x)
            => hexstring(x);

        [MethodImpl(Inline)]   
        public static string ToHexString(this ushort x)
            => hexstring(x);

        [MethodImpl(Inline)]   
        public static string ToHexString(this int x)
            => hexstring(x);

        [MethodImpl(Inline)]   
        public static string ToHexString(this uint x)
            => hexstring(x);

        [MethodImpl(Inline)]   
        public static string ToHexString(this long x)
            => hexstring(x);

        [MethodImpl(Inline)]   
        public static string ToHexString(this ulong x)
            => hexstring(x);


        [MethodImpl(Inline)]   
        public static string ToHexString(this BigInteger x)
            => hexstring(x);

        [MethodImpl(Inline)]   
        public static string ToHexString(this decimal src)
            => hexstring(src);
 
        public static IEnumerable<T> Collapse<T>(IEnumerable<IEnumerable<T>> src)
            => src.SelectMany(x => x);


        /// <summary>
        /// Determines whether a double value is equivalent to the NaN representative
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static bool IsNaN(this float src)
            => NaN(src);

        /// <summary>
        /// Determines whether a value is equivalent to the NaN representative
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static bool IsNaN(this double src)
            => NaN(src);

        /// <summary>
        /// Determines whether a double value is bounded 
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static bool IsFinite(this double src)
            => finite(src);

        /// <summary>
        /// Determines whether a value is negative
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static bool IsNegative(this double src)
            => double.IsNegative(src);

        /// <summary>
        /// Determines whether a value is positive
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static bool IsPositive(this double src)
            => src > 0;

        /// <summary>
        /// Determines whether a value is nonzero
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]   
        public static bool IsNonzero(this double src)
            => nonzero(src);
   }
}