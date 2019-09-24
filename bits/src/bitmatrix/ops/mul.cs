//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class BitMatrix
    {
        /// <summary>
        /// Computes the product of square bitmatrices of common natural order and stores the
        /// result to a caller-supplied target matrix
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="C">The target matrix</param>
        /// <typeparam name="N">The order type</typeparam>
        /// <typeparam name="T">The matrix storage type</typeparam>
        public static ref BitMatrix<N,T> mul<N,T>(in BitMatrix<N,T> A, in BitMatrix<N,T> B, ref BitMatrix<N,T> C)
            where N : ITypeNat, new()
            where T : unmanaged
        {
            var x = A;
            var y = B.Transpose();
            var n = (int)new N().value;
            for(var i=0; i<n; i++)
            for(var j=0; j<n; j++)
                C[i,j] = x.RowVector(i) % y.RowVector(j);

            return ref C;
        }

        /// <summary>
        /// Computes the product of 64-bit bitmatrices
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="C">The target matrix</param>
        public static BitMatrix64 mul(in BitMatrix64 A, in BitMatrix64 B)
        {
            var x = A;
            var y = B.Transpose();
            var C = BitMatrix64.Alloc();

            for(var i=0; i< 64; i++)
            {
                var r = x.RowVector(i);
                var z = BitVector64.Alloc();
                for(var j = 0; j< 64; j++)
                    z[j] = r % y.RowVector(j);
                C[i] = (ulong)z;
            }
            return C;
        }

        /// <summary>
        /// Computes the product of 64-bit bitmatrices and stores the result to a caller-supplied target matrix
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="C">The target matrix</param>
        public static ref BitMatrix64 mul(in BitMatrix64 A, in BitMatrix64 B, ref BitMatrix64 C)
        {
            var x = A;
            var y = B.Transpose();

            for(var i=0; i< 64; i++)
            {
                var r = x.RowVector(i);
                var z = BitVector64.Alloc();
                for(var j = 0; j< 64; j++)
                    z[j] = r % y.RowVector(j);
                C[i] = (ulong)z;
            }
            return ref C;
        }


        /// <summary>
        /// Computes the product of bitmatrices of comparible natural dimensions and stores the
        /// result to a caller-supplied target matrix
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="C">The target matrix</param>
        /// <typeparam name="N">The order type</typeparam>
        /// <typeparam name="T">The matrix storage type</typeparam>
        public static ref BitMatrix<M, N, T> mul<M,P,N,T>(in BitMatrix<M,P,T> A, in BitMatrix<P,N,T> B, ref BitMatrix<M,N,T> C)
            where M : ITypeNat, new()
            where P : ITypeNat, new()
            where N : ITypeNat, new()
            where T : unmanaged
        {
            var x = A;
            var y = B.Transpose();
            var n = (int)new N().value;
            for(var i=0; i<n; i++)
            for(var j=0; j<n; j++)
                C[i,j] = x.RowVector(i) % y.RowVector(j);

            return ref C;
        }


    }

}