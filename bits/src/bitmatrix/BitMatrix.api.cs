//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
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
        [MethodImpl(Inline)]
        public static BitMatrix<N,T> Alloc<N,T>(N n = default, T rep = default)
            where N : ITypeNat, new()
            where T : unmanaged
                => BitMatrix<N,T>.Alloc();
        
        /// <summary>
        /// Allocates a zero-filled mxn bitmatrix
        /// </summary>
        /// <typeparam name="M">The row dimension</typeparam>
        /// <typeparam name="N">The column dimension</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static BitMatrix<M,N,T> Alloc<M,N,T>(M m = default, N n = default)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : unmanaged
                => BitMatrix<M,N,T>.Alloc();

        /// <summary>
        /// Loads an n-square bitmatrix from a memory segment
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="n">The matrix order</param>
        /// <typeparam name="N">The matrix order type</typeparam>
        /// <typeparam name="T">The matrix cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitMatrix<N,T> Load<N,T>(T[] src, N n = default)        
            where N : ITypeNat, new()
            where T : unmanaged
                => new BitMatrix<N,T>(src); 

        /// <summary>
        /// Loads an MxN bitmatrix from a memory segment
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="n">The matrix order</param>
        /// <typeparam name="N">The matrix order type</typeparam>
        /// <typeparam name="T">The matrix cell type</typeparam>
        [MethodImpl(Inline)]
        public static BitMatrix<M,N,T> Load<M,N,T>(T[] src, M m = default, N n = default)        
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : unmanaged
                => new BitMatrix<M,N,T>(src); 

        [MethodImpl(Inline)]
        public static BitMatrix<M,N,T> Load<M,N,T>(M m = default, N n = default, params T[] src)        
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : unmanaged
                => new BitMatrix<M,N,T>(new Memory<T>(src)); 

        /// <summary>
        /// Allocates a one-filled mxn matrix
        /// </summary>
        /// <typeparam name="M">The row dimension</typeparam>
        /// <typeparam name="N">The column dimension</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static BitMatrix<M,N,T> Ones<M,N,T>(M m = default, N n = default)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : unmanaged
                => BitMatrix<M,N,T>.Ones();

        /// <summary>
        /// Returns an immutable reference to the 1-filled N-square matrix
        /// </summary>
        /// <typeparam name="M">The row dimension</typeparam>
        /// <typeparam name="N">The column dimension</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static BitMatrix<N,T> Ones<N,T>(N n = default)
            where N : ITypeNat, new()
            where T : unmanaged
                => BitMatrix<N,T>.Ones;

        /// <summary>
        /// Returns an immutable reference to the N-square identity matrix
        /// </summary>
        /// <typeparam name="N">The column/row dimension</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        public static BitMatrix<N,T> Identity<N,T>(N n = default, T rep = default)
            where N : ITypeNat, new()
            where T : unmanaged
                => BitMatrix<N,T>.Identity;

    }

}