//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    public static class BitMatrix
    {
        /// <summary>
        /// Allocates a zero-filled n-square matrix
        /// </summary>
        /// <typeparam name="N">The square dimension</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        public static BitMatrix<N,N,T> Zeros<N,T>()
            where N : ITypeNat, new()
            where T : struct
                => BitMatrix<N,N,T>.Zeros();
        
        /// <summary>
        /// Allocates a zero-filled mxn matrix
        /// </summary>
        /// <typeparam name="M">The row dimension</typeparam>
        /// <typeparam name="N">The column dimension</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        public static BitMatrix<M,N,T> Zeros<M,N,T>(M m = default, N n = default)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
                => BitMatrix<M,N,T>.Zeros();

        /// <summary>
        /// Allocates a one-filled N-square matrix
        /// </summary>
        /// <typeparam name="M">The row dimension</typeparam>
        /// <typeparam name="N">The column dimension</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        public static BitMatrix<N,N,T> Ones<N,T>(N n = default)
            where N : ITypeNat, new()
            where T : struct
                => BitMatrix<N,N,T>.Ones();

        /// <summary>
        /// Allocates a one-filled mxn matrix
        /// </summary>
        /// <typeparam name="M">The row dimension</typeparam>
        /// <typeparam name="N">The column dimension</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        public static BitMatrix<M,N,T> Ones<M,N,T>(M m = default, N n = default)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
                => BitMatrix<M,N,T>.Ones();

        /// <summary>
        /// Allocates an N-square identity matrix
        /// </summary>
        /// <typeparam name="N">The column/row dimension</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        public static BitMatrix<N,N,T> Identity<N,T>()
            where N : ITypeNat, new()
            where T : struct
        {            

            var dst = Zeros<N,T>();
            for(var row = 0; row < dst.RowCount; row++)
            for(var col = 0; col < dst.ColCount; col++)
                if(row == col)
                    dst[row,col] = 1;
            
            return dst;
        }    

        [MethodImpl(Inline)]
        public static BitMatrix<M,N,T> Define<M,N,T>(ReadOnlySpan<T> src, M m = default, N n = default)        
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
                => new BitMatrix<M,N,T>(src); 

        [MethodImpl(Inline)]
        public static BitMatrix<M,N,T> Define<M,N,T>(Span<T> src, M m = default, N n = default)        
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
                => new BitMatrix<M,N,T>(src); 
    }

}