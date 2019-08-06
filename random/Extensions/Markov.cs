//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static nfunc;

    partial class RngX
    {

        [MethodImpl(Inline)]
        static void MarkovVector(this IRandomSource random, Span<float> dst)
        {            
            var length = dst.Length;
            random.StreamTo(closed(1.0f,length << 4), length, ref dst[0]);
            dst.Div(dst.Avg() * length);
        }

        [MethodImpl(Inline)]
        static void MarkovVector(this IRandomSource random, Span<double> dst)
        {            
            var length = dst.Length;
            random.StreamTo(closed(1.0, length << 4), length, ref dst[0]);
            dst.Div(dst.Avg() * length);
        }

        [MethodImpl(Inline)]
        static Vector<float> MarkovVector(this IRandomSource random, int length, float min, float max)
        {            
            var dst = Z0.Span256.alloc<float>(Z0.Span256.minblocks<float>(length));
            random.StreamTo(closed(min,max), length, ref dst[0]);
            return dst.Div(dst.Avg() * length);
        }

        [MethodImpl(Inline)]
        static Vector<double> MarkovVector(this IRandomSource random, int length, double min, double max)
        {                        
            var dst = Z0.Span256.alloc<double>(Z0.Span256.minblocks<double>(length));
            random.StreamTo(closed(min,max), length, ref dst[0]);
            return dst.Div(dst.Avg() * length);
        }

        /// <summary>
        /// Produces a stochastic vector of a specified length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="len">The result vector length</param>
        [MethodImpl(Inline)]
        static void MarkovVector<T>(this IRandomSource random, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(float))                
                random.MarkovVector(As.float32(dst));
            else if(typeof(T) == typeof(double))
                random.MarkovVector(As.float64(dst));
            else
                throw unsupported<T>();
        }


        /// <summary>
        /// Produces a stochastic vector of a specified length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="len">The result vector length</param>
        [MethodImpl(Inline)]
        public static Vector<T> MarkovVector<T>(this IRandomSource random, int length)
            where T : struct
        {
            if(typeof(T) == typeof(float))                
                return random.MarkovVector(length, 1f, length << 4).As<T>();
            else if(typeof(T) == typeof(double))
                return random.MarkovVector(length, 1.0, length << 4).As<T>();
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector<N,T> MarkovVector<N,T>(this IRandomSource random)
            where N : ITypeNat, new()
            where T : struct
        {
            var dst = Vector.Alloc<N,T>();
            random.MarkovVector(dst.Unsize());
            return dst;

        }

        /// <summary>
        /// Allocates and populates a right-stochastic matrix, otherwise known as a Markov matrix;
        /// each row records a stocastic vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="rep"></param>
        /// <param name="dim"></param>
        /// <typeparam name="N"></typeparam>
        /// <typeparam name="T"></typeparam>
        public static Matrix<N,N,T> MarkovMatrix<N,T>(this IRandomSource random, T rep = default, N dim = default)
            where T : struct
            where N : ITypeNat, new()
        {
            var data = Z0.Span256.alloc<N,N,T>();
            var n = nati<N>();
            for(int row=0; row < n; row++)
                random.MarkovVector<T>(data.Slice(row*n, n));                            
            return Z0.Matrix.Load<N,N,T>(data);
        }

        [MethodImpl(Inline)]
        public static ref Vector<N,T> MarkovVector<N,T>(this IRandomSource random, ref Vector<N,T> dst)
            where N : ITypeNat, new()
            where T : struct
        {
            random.MarkovVector(dst.Unsize());
            return ref dst;
        }

        public static ref Matrix<N,N,T> MarkovMatrix<N,T>(this IRandomSource random, ref Matrix<N,N,T> dst)
            where T : struct
            where N : ITypeNat, new()
        {
            var data = dst.Data;
            var n = nati<N>();
            for(int row=0; row < n; row++)
                random.MarkovVector<T>(data.Slice(row*n, n));                            
            return ref dst;
        }

    }


}