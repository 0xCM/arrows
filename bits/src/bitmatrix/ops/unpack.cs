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

    partial class BitMatrix
    {

        /// <summary>
        /// Projects the bits of a fixed primal bitmatrix into a generic target matrix of the same order
        /// </summary>
        /// <param name="src">The source matrix</param>
        /// <param name="dst">The target metrix</param>
        /// <typeparam name="T">The element type of the target matrix</typeparam>
        [MethodImpl(Inline)]
        public static ref Matrix<N8, T> unpack<T>(BitMatrix8 src, ref Matrix<N8,T> dst)
            where T : unmanaged
        {
            gbits.unpack(src.Data, dst.Data.AsSpan());            
            return ref dst;
        }

        /// <summary>
        /// Projects the bits of a fixed primal bitmatrix into a generic target matrix of the same order
        /// </summary>
        /// <param name="src">The source matrix</param>
        /// <param name="dst">The target metrix</param>
        /// <typeparam name="T">The element type of the target matrix</typeparam>
        [MethodImpl(Inline)]
        public static Matrix<N8, T> unpack<T>(BitMatrix8 src, Matrix<N8,T> dst)
            where T : unmanaged
        {
            gbits.unpack(src.Data, dst.Data.AsSpan());            
            return dst;
        }

        /// <summary>
        /// Projects the bits of a fixed primal bitmatrix into a generic target matrix of the same order
        /// </summary>
        /// <param name="src">The source matrix</param>
        /// <param name="dst">The target metrix</param>
        /// <typeparam name="T">The element type of the target matrix</typeparam>
        [MethodImpl(Inline)]
        public static ref Matrix<N16, T> unpack<T>(BitMatrix16 src, ref Matrix<N16,T> dst)
            where T : unmanaged
        {
            gbits.unpack(src.Data, dst.Data.AsSpan());            
            return ref dst;
        }

        /// <summary>
        /// Projects the bits of a fixed primal bitmatrix into a generic target matrix of the same order
        /// </summary>
        /// <param name="src">The source matrix</param>
        /// <param name="dst">The target metrix</param>
        /// <typeparam name="T">The element type of the target matrix</typeparam>
        [MethodImpl(Inline)]
        public static ref Matrix<N32, T> unpack<T>(BitMatrix32 src, ref Matrix<N32,T> dst)
            where T : unmanaged
        {
            gbits.unpack(src.Data, dst.Data.AsSpan());            
            return ref dst;
        }

        /// <summary>
        /// Projects the bits of a fixed primal bitmatrix into a generic target matrix of the same order
        /// </summary>
        /// <param name="src">The source matrix</param>
        /// <param name="dst">The target metrix</param>
        /// <typeparam name="T">The element type of the target matrix</typeparam>
        [MethodImpl(Inline)]
        public static ref Matrix<N64, T> unpack<T>(BitMatrix64 src, ref Matrix<N64,T> dst)
            where T : unmanaged
        {
            gbits.unpack(src.Data, dst.Data.AsSpan());            
            return ref dst;
        }

        /// <summary>
        /// Projects the bits of a generic sqare bitmatix of natural order into a generic target matrix of the same order
        /// </summary>
        /// <param name="src">The source matrix</param>
        /// <param name="dst">The target metrix</param>
        /// <typeparam name="N">The orer type</typeparam>
        /// <typeparam name="S">The source matrix element type</typeparam>
        /// <typeparam name="T">The target matrix element type</typeparam>
        [MethodImpl(Inline)]
        public static ref Matrix<N, T> unpack<N,S,T>(BitMatrix<N,S> src, ref Matrix<N,T> dst)
            where S : unmanaged
            where T : unmanaged
            where N : ITypeNat, new()
        {
            gbits.unpack(src.Data, dst.Data.AsSpan());            
            return ref dst;
        }

        /// <summary>
        /// Projects the bits of a generic bitmatix of natural dimensions into a generic matrix of the same dimensions
        /// </summary>
        /// <param name="src">The source matrix</param>
        /// <param name="dst">The target metrix</param>
        /// <typeparam name="M">The row dimension type</typeparam>
        /// <typeparam name="N">The col dimension type</typeparam>
        /// <typeparam name="S">The source matrix element type</typeparam>
        /// <typeparam name="T">The target matrix element type</typeparam>
        [MethodImpl(Inline)]
        public static ref Matrix<M, N, T> unpack<M,N,S,T>(BitMatrix<M,N,S> src, ref Matrix<M,N,T> dst)
            where S : unmanaged
            where T : unmanaged
            where M : ITypeNat, new()
            where N : ITypeNat, new()
        {
            gbits.unpack(src.Data, dst.Data.AsSpan());            
            return ref dst;
        }


        /// <summary>
        /// Projects the bits of a square generic bitmatix of natural order into a generic block matrix of the same order
        /// </summary>
        /// <param name="src">The source matrix</param>
        /// <param name="dst">The target metrix</param>
        /// <typeparam name="M">The row dimension type</typeparam>
        /// <typeparam name="N">The col dimension type</typeparam>
        /// <typeparam name="S">The source matrix element type</typeparam>
        /// <typeparam name="T">The target matrix element type</typeparam>
        [MethodImpl(Inline)]
        public static ref BlockMatrix<N, T> unpack<N,S,T>(BitMatrix<N,S> src, ref BlockMatrix<N,T> dst)
            where S : unmanaged
            where T : unmanaged
            where N : ITypeNat, new()
        {
            gbits.unpack(src.Data, dst.Unblocked);            
            return ref dst;
        }

        /// <summary>
        /// Projects the bits of a generic bitmatix of natural dimensions into a generic block matrix of the same dimensions
        /// </summary>
        /// <param name="src">The source matrix</param>
        /// <param name="dst">The target metrix</param>
        /// <typeparam name="M">The row dimension type</typeparam>
        /// <typeparam name="N">The col dimension type</typeparam>
        /// <typeparam name="S">The source matrix element type</typeparam>
        /// <typeparam name="T">The target matrix element type</typeparam>
       [MethodImpl(Inline)]
        public static ref BlockMatrix<M,N,T> unpack<M,N,S,T>(BitMatrix<M,N,S> src, ref BlockMatrix<M,N,T> dst)
            where S : unmanaged
            where T : unmanaged
            where M : ITypeNat, new()
            where N : ITypeNat, new()
        {
            gbits.unpack(src.Data, dst.Unblocked);            
            return ref dst;
        }

    }

}