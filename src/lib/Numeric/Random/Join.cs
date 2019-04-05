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


    public static class Rand
    {
        static readonly Dictionary<Type,object> randomizers = new Dictionary<Type, object>{

            [type<byte>()] = new RandU8(new Randomizer()),
            [type<sbyte>()] = new Rand8(new Randomizer()),
            
            [type<short>()] = new Rand16(new Randomizer()),
            [type<ushort>()] = new RandU16(new Randomizer()),

            [type<int>()] = new Rand32(new Randomizer()),
            [type<uint>()] = new RandU32(new Randomizer()),
            
            [type<long>()] = new Rand64(new Randomizer()),          
            [type<ulong>()] = new RandU64(new Randomizer()),          

            [type<float>()] = new RandF32(new Randomizer()),
            [type<double>()] = new RandF64(new Randomizer()),            
            [type<decimal>()] = new RandF128(new Randomizer()),            
        };

        public static Rand<T> random<T>()
            => (Rand<T>)randomizers[type<T>()];

        public static PrimalRand<T> primal<T>()
            => (PrimalRand<T>)randomizers[type<T>()];

        /// <summary>
        /// Constructs a stream of random matrices
        /// </summary>
        /// <param name="dim">The dimension value; exits as a type inference aid</param>
        /// <param name="bounds">The interval constraining the entries</param>
        /// <typeparam name="M">The natural row count</typeparam>
        /// <typeparam name="N">The natural colun count</typeparam>
        /// <typeparam name="T">The entry type</typeparam>
        public static IEnumerable<Matrix<M, N,real<T>>> matrices<M,N,T>(Dim<M,N> dim, ClosedInterval<real<T>> bounds)
            where M : TypeNat, new()
            where N : TypeNat, new()
        {
            var len = dim.volume();
            var rand = random<T>();
            while(true)
            {                    
                var entries = rand.stream(bounds.left, bounds.right).Take((int)len);
                yield return Matrix.define(dim, entries);
                
            }                
        }  


        /// <summary>
        /// Constructs a stream of uniformly distributed values
        /// </summary>
        /// <param name="dim">The dimension value; exits as a type inference aid</param>
        /// <param name="bounds">The interval constraining the entries</param>
        /// <typeparam name="N">The natural vector length</typeparam>
        /// <typeparam name="T">The underlying numeric type</typeparam>
        public static IEnumerable<Vector<N,real<T>>> vectors<N,T>(Dim<N> dim, ClosedInterval<real<T>> bounds)
            where N : TypeNat, new()
        {
            var len = dim.volume();
            var rand = random<T>();
            while(true)
            {                    
                var entries = rand.stream(bounds.left, bounds.right).Take((int)len);
                yield return Vector.define(dim, entries);
            }                
        }  

        /// <summary>
        /// Constructs a stream of uniformly distributed values
        /// </summary>
        /// <typeparam name="T">The underlying numeric type</typeparam>
        public static IEnumerable<real<T>> values<T>(real<T> min, real<T> max)
                => random<T>().stream(min,max);

        /// <summary>
        /// Constructs a stream of uniformly distributed 2-tuples
        /// </summary>
        /// <param name="left">The left tuple component</param>
        /// <param name="right">The right tuple component</param>
        /// <typeparam name="T">The underlying numeric type</typeparam>
        public static IEnumerable<(real<T> left, real<T> right)> pairs<T>(real<T> min, real<T> max)
                => zip(random<T>().stream(min,max), random<T>().stream(min,max));

        public static Slice<real<T>> values<T>(int count, real<T> min, real<T> max)
                => random<T>().stream(min,max).Take(count).ToSlice();

        /// <summary>
        /// Yields a stream of random matrices
        /// </summary>
        /// <param name="min">The entry value minimum</param>
        /// <param name="max">The entry value maximum</param>
        /// <typeparam name="M">The row dimension</typeparam>
        /// <typeparam name="N">The column dimension</typeparam>
        /// <typeparam name="T">The entry type</typeparam>
        public static IEnumerable<Matrix<M,N,T>> matrices<M,N,T>(T min, T max)
             where M : TypeNat, new()
             where N : TypeNat, new()
                => MatrixSource<M,N,T>.Inhabitant.stream(min, max);

        /// <summary>
        /// Yields a stream of random matrices
        /// </summary>
        /// <param name="dim">The matrix dimension</param>
        /// <param name="min">The entry value minimum</param>
        /// <param name="max">The entry value maximum</param>
        /// <typeparam name="M">The row dimension</typeparam>
        /// <typeparam name="N">The column dimension</typeparam>
        /// <typeparam name="T">The entry type</typeparam>
        public static IEnumerable<Matrix<M,N,T>> matrices<M,N,T>(Dim<M,N> dim, T min, T max)
             where M : TypeNat, new()
             where N : TypeNat, new()
                => MatrixSource<M,N,T>.Inhabitant.stream(min, max);


        public static IEnumerable<Vector<N,real<T>>> vectors<N,T>(real<T> min, real<T> max)
            where N : TypeNat, new()
                => Rand.vectors(dim(new N()), Interval.closed(min, max));

        public static IEnumerable<Vector<N,real<T>>> vectors<N,T>(Dim<N> dim, real<T> min, real<T> max)
            where N : TypeNat, new()
                => Rand.vectors(dim, Interval.closed(min, max));

    }
}