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
        public static IRandomStream<T> Primal<T>(this IRandomizer random)
            where T : struct, IEquatable<T>
                => cast<IRandomStream<T>>(random);
        
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