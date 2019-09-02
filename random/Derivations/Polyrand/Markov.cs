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
        /// <summary>
        /// Produces a stochastic vector of a specified length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="len">The result vector length</param>
        [MethodImpl(Inline)]
        public static Vector<T> MarkovVec<T>(this IPolyrand random, int length)
            where T : struct
        {
            if(typeof(T) == typeof(float))                
                return random.MarkovVec(length, 1f, length << 4).As<T>();
            else if(typeof(T) == typeof(double))
                return random.MarkovVec(length, 1.0, length << 4).As<T>();
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Produces a stochastic vector of *unspecified* length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="len">The result vector length</param>
        [MethodImpl(Inline)]
        public static void MarkovVec<T>(this IPolyrand random, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(float))                
                random.MarkovVec(As.float32(dst));
            else if(typeof(T) == typeof(double))
                random.MarkovVec(As.float64(dst));
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Produces a stochastic vector of a natural length
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="len">The result vector length</param>
        /// <typeparam name="N">The length type</typeparam>
        [MethodImpl(Inline)]
        public static Vector<N,T> MarkovVec<N,T>(this IPolyrand random)
            where N : ITypeNat, new()
            where T : struct
        {
            var dst = Vector.Alloc<N,T>();
            random.MarkovVec(dst.Unsized);
            return dst;
        }

        /// <summary>
        /// Allocates and populates a right-stochastic matrix, otherwise known as a Markov matrix;
        /// each row records a stocastic vector
        /// </summary>
        /// <param name="random">The random source</param>
        /// <param name="rep"></param>
        /// <param name="dim"></param>
        /// <typeparam name="N">The order type</typeparam>
        /// <typeparam name="T"></typeparam>
        public static Matrix<N,T> MarkovMat<N,T>(this IPolyrand random, T rep = default, N dim = default)
            where T : struct
            where N : ITypeNat, new()
        {
            var data = Z0.Span256.Alloc<N,N,T>();
            var n = nati<N>();
            for(int row=0; row < n; row++)
                random.MarkovVec<T>(data.Slice(row*n, n));                            
            return Z0.Matrix.Load<N,T>(data);
        }

        [MethodImpl(Inline)]
        public static ref Vector<N,T> MarkovVec<N,T>(this IPolyrand random, ref Vector<N,T> dst)
            where N : ITypeNat, new()
            where T : struct
        {
            random.MarkovVec(dst.Unsized);
            return ref dst;
        }


        public static ref Matrix<N,T> MarkovMat<N,T>(this IPolyrand random, ref Matrix<N,T> dst)
            where T : struct
            where N : ITypeNat, new()
        {
            var data = dst.Unsized;
            var n = nati<N>();
            for(int row=0; row < n; row++)
                random.MarkovVec<T>(data.Slice(row*n, n));                            
            return ref dst;
        }

        [MethodImpl(Inline)]
        static Span256<float> Div(this Span256<float> src, float rhs)
        {
            src.Unblocked.Div(rhs);
            return src;
        }

        [MethodImpl(Inline)]
        static Span256<double> Div(this Span256<double> src, double rhs)
        {
            src.Unblocked.Div(rhs);
            return src;
        }

        [MethodImpl(Inline)]
        static void MarkovVec(this IPolyrand random, Span<float> dst)
        {            
            var length = dst.Length;
            random.StreamTo(closed(1.0f,length << 4), length, ref dst[0]);
            dst.Div(dst.Avg() * length);
        }

        [MethodImpl(Inline)]
        static void MarkovVec(this IPolyrand random, Span<double> dst)
        {            
            var length = dst.Length;
            random.StreamTo(closed(1.0, length << 4), length, ref dst[0]);
            dst.Div(dst.Avg() * length);
        }


        [MethodImpl(Inline)]
        static Vector<float> MarkovVec(this IPolyrand random, int length, float min, float max)
        {            
            var dst = Z0.Span256.AllocBlocks<float>(Z0.Span256.MinBlocks<float>(length));
            random.StreamTo(closed(min,max), length, ref dst[0]);
            return dst.Div(dst.Avg() * length);
        }

        [MethodImpl(Inline)]
        static Vector<double> MarkovVec(this IPolyrand random, int length, double min, double max)
        {                        
            var dst = Z0.Span256.AllocBlocks<double>(Z0.Span256.MinBlocks<double>(length));
            random.StreamTo(closed(min,max), length, ref dst[0]);
            return dst.Div(dst.Avg() * length);
        }

 
    }
}