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



    partial class xcore
    {
        public static PrimalRand<T> Primal<T>(this IRandomizer random)
            where T : struct, IEquatable<T>
        {
            if(type<T>().IsInt8())
                return cast<PrimalRand<T>>(new Rand8((Randomizer)random));

            if(type<T>().IsUInt8())
                return cast<PrimalRand<T>>(new RandU8((Randomizer)random));

            if(type<T>().IsInt16())
                return cast<PrimalRand<T>>(new Rand16((Randomizer)random));

            if(type<T>().IsUInt16())
                return cast<PrimalRand<T>>(new RandU16((Randomizer)random));

            if(type<T>().IsInt32())
                return cast<PrimalRand<T>>(new Rand32((Randomizer)random));

            if(type<T>().IsUInt32())
                return cast<PrimalRand<T>>(new RandU32((Randomizer)random));

            if(type<T>().IsInt64())
                return cast<PrimalRand<T>>(new Rand64((Randomizer)random));

            if(type<T>().IsUInt64())
                return cast<PrimalRand<T>>(new RandU64((Randomizer)random));

            if(type<T>().IsDouble())
                return cast<PrimalRand<T>>(new RandF64((Randomizer)random));

            if(type<T>().IsSingle())
                return cast<PrimalRand<T>>(new RandF32((Randomizer)random));

            if(type<T>().IsDecimal())
                return cast<PrimalRand<T>>(new RandF128((Randomizer)random));

            throw new NotSupportedException();
        }

        /// <summary>
        /// Yields a stream of primal random vectors
        /// </summary>
        /// <param name="min">The minimum component value</param>
        /// <param name="max">The maximum component value</param>
        /// <typeparam name="N">The natural length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        public static IEnumerable<Vector<N,T>> Vectors<N,T>(this IRandomizer rand, T min, T max)        
            where N : TypeNat, new()
            where T : struct, IEquatable<T>
        {
                var primal = rand.Primal<T>();
            
                static Vector<N,T> vector(N len, IEnumerable<T> src)
                    => Vector.define(len, (src.Take((int)natval<N>())));

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
            where N : TypeNat, new()
            where T : struct, IEquatable<T>
                => rand.Vectors<N,T>(min,max);


        public static RandomMatrixSource<M,N,T> MatrixSource<M,N,T>(this IRandomizer rand)
            where M : TypeNat, new()
            where N : TypeNat, new()
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
            where M : TypeNat, new()
            where N : TypeNat, new()
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
             where M : TypeNat, new()
             where N : TypeNat, new()
             where T : struct, IEquatable<T>
                => rms.stream(min,max);

    }

}