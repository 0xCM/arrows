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

    public interface Rand<T>
    {
        real<T> one(real<T> min, real<T> max);
        
        IEnumerable<real<T>> stream(real<T> min, real<T> max);
    
        IEnumerable<real<T>> many(ulong count, real<T> min, real<T> max);
    }


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
        };

        public static Rand<T> random<T>()
            => (Rand<T>)randomizers[type<T>()];
    
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
                var entries = rand.many(len, bounds.left, bounds.right);
                yield return Matrix.define(dim, entries);
                
            }                
        }  


        /// <summary>
        /// Constructs a stream of random vectors
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
                var entries = rand.many(len, bounds.left, bounds.right);
                yield return Vector.define(dim, entries);
            }                
        }  

        public static IEnumerable<real<T>> values<T>(real<T> min, real<T> max)
                => random<T>().stream(min,max);

        public static Slice<real<T>> slice<T>(uint count, real<T> min, real<T> max)
                => random<T>().stream(min,max).Take((int)count).ToSlice();

        public static IEnumerable<Matrix<M,N,real<T>>> matrices<M,N,T>(real<T> min, real<T> max)
            where M : TypeNat, new()
            where N : TypeNat, new()
                => Rand.matrices(dim(new M(), new N()), Interval.closed(min, max));

        public static IEnumerable<Matrix<M,N,real<T>>> matrices<M,N,T>(Dim<M,N> dim, real<T> min, real<T> max)
            where M : TypeNat, new()
            where N : TypeNat, new()
                => Rand.matrices(dim, Interval.closed(min, max));

        public static IEnumerable<Vector<N,real<T>>> vectors<N,T>(real<T> min, real<T> max)
            where N : TypeNat, new()
                => Rand.vectors(dim(new N()), Interval.closed(min, max));

        public static IEnumerable<Vector<N,real<T>>> vectors<N,T>(Dim<N> dim, real<T> min, real<T> max)
            where N : TypeNat, new()
                => Rand.vectors(dim, Interval.closed(min, max));

    }
}