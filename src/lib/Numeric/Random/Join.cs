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

        static Rand<T> random<T>()
            => (Rand<T>)randomizers[type<T>()];

        static PrimalRand<T> primrand<T>()
            => (PrimalRand<T>)randomizers[type<T>()];

        static readonly Randomizer freerand = new Randomizer();
        
        public static IEnumerable<bit> bits()
            => freerand.bits();

        /// <summary>
        /// Yields a stream of uniformly distributed real[t] values that
        /// are bounded within a specified range
        /// </summary>
        /// <param name="min">The lower bound</param>
        /// <param name="max">The upper bound</param>
        /// <typeparam name="T">The underlying type</typeparam>
        public static IEnumerable<real<T>> reals<T>(real<T> min, real<T> max)
            => random<T>().stream(min,max);

        /// <summary>
        /// Yields a stream of uniformly distributed primitive values that
        /// are bounded within a specified range
        /// </summary>
        /// <param name="min">The lower bound</param>
        /// <param name="max">The upper bound</param>
        /// <typeparam name="T">The primitive type</typeparam>
        public static IEnumerable<T> primal<T>(T min, T max)
            => primrand<T>().stream(min,max);

        /// <summary>
        /// Yields a slice of random primitives
        /// </summary>
        /// <param name="len">The length of the slice </param>
        /// <param name="min">The minimum value</param>
        /// <param name="max">The maximum value</param>
        /// <typeparam name="T">The primitive type</typeparam>
        public static Slice<T> slice<T>(int len, T min, T max)
            => primal(min,max).Take(len).ToSlice();

        /// <summary>
        /// Yields a natrural length slice of random primitives
        /// </summary>
        /// <param name="min">The minimum value</param>
        /// <param name="max">The maximum value</param>
        /// <typeparam name="T">The primitive type</typeparam>
        public static Slice<N,T> slice<N,T>(T min, T max)
            where N : TypeNat, new()
                => primal(min,max).ToSlice(natrep<N>());

        /// <summary>
        /// Yields a natural length slice of random primitives
        /// </summary>
        /// <param name="min">The minimum value</param>
        /// <param name="max">The maximum value</param>
        /// <typeparam name="T">The primitive type</typeparam>
        public static Slice<N,T> slice<N,T>(N rep, T min, T max)
            where N : TypeNat, new()
                => primal(min,max).ToSlice(rep);

        /// <summary>
        /// Yields a stream of random primal slices
        /// </summary>
        /// <param name="len">The length of each slice</param>
        /// <param name="min">The minimum value of each cell</param>
        /// <param name="min">The maximum value of each cell</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static IEnumerable<Slice<T>> slices<T>(int len, T min, T max)
        {
            Slice<T> slice(IEnumerable<T> src)
                => Slice.define<T>(src.Freeze(len));

            var s = primal(min,max);
            while(true)
                yield return slice(s);
        }

        /// <summary>
        /// Yields a stream of primal random vectors
        /// </summary>
        /// <param name="min">The minimum component value</param>
        /// <param name="max">The maximum component value</param>
        /// <typeparam name="N">The natural length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        public static IEnumerable<Vector<N,T>> vectors<N,T>(T min, T max)
            where N : TypeNat, new()
        {
            static Vector<N,T> vector(N len, IEnumerable<T> src)
                => Vector.define(len, (src.Take((int)natval<N>())));

            var s = primal(min,max);
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
        public static IEnumerable<Vector<N,T>> vectors<N,T>(N rep, T min, T max)
            where N : TypeNat, new()
                => vectors<N,T>(min,max);

        /// <summary>
        /// Yields a stream of priamal random matrices
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
        /// Yields a stream of primal random matrices
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


        /// <summary>
        /// Constructs a stream of uniformly distributed values
        /// </summary>
        /// <param name="dim">The dimension value; exits as a type inference aid</param>
        /// <param name="bounds">The interval constraining the entries</param>
        /// <typeparam name="N">The natural vector length</typeparam>
        /// <typeparam name="T">The underlying numeric type</typeparam>
        public static IEnumerable<Vector<N,real<T>>> vectors<N,T>(N rep, real<T> min, real<T> max)
            where N : TypeNat, new()
        {
            var len = rep.value;
            var src = reals(min,max);
            while(true)
            {                    
                var entries = src.Take((int)len);
                yield return Vector.define(rep, entries);
            }                
        }  

        /// <summary>
        /// Constructs a stream of uniformly distributed 2-tuples
        /// </summary>
        /// <param name="left">The left tuple component</param>
        /// <param name="right">The right tuple component</param>
        /// <typeparam name="T">The underlying numeric type</typeparam>
        public static IEnumerable<(real<T> left, real<T> right)> pairs<T>(real<T> min, real<T> max)
                => zip(reals(min,max), reals(min,max));

        /// <summary>
        /// Yields a slice of random real[t] values
        /// </summary>
        /// <param name="min">The minimum value</param>
        /// <param name="max">The maximum value</param>
        /// <typeparam name="T">The underlying type</typeparam>
        public static Slice<real<T>> slice<T>(int count, real<T> min, real<T> max)
                => reals(min,max).Take(count).ToSlice();
 
    }
}