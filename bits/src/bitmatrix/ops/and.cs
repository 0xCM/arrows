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
    using System.Runtime.Intrinsics;

    using static zfunc;
    using static As;

    partial class BitMatrix
    {
        /// <summary>
        /// Computes the logical AND between two primal bitmatrices of order 8
        /// </summary>
        /// <param name="lhs">The left matrix</param>
        /// <param name="rhs">The right matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix8 and(BitMatrix8 lhs, BitMatrix8 rhs)
             => BitMatrix8.From((ulong)lhs & (ulong)rhs);             

        /// <summary>
        /// Computes the logical AND between two primal bitmatrices of order 16
        /// </summary>
        /// <param name="lhs">The left matrix</param>
        /// <param name="rhs">The right matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix16 and(in BitMatrix16 lhs, in BitMatrix16 rhs)
        {
            ref var A = ref lhs.LoadCpuVec(out Vector256<ushort> _);
            ref var B = ref rhs.LoadCpuVec(out Vector256<ushort> _);
            var C = dinx.and(A,B);
            return BitMatrix16.From(C);
        }

        /// <summary>
        /// Computes the logical AND between two primal bitmatrices of order 16
        /// </summary>
        /// <param name="lhs">The left matrix</param>
        /// <param name="rhs">The right matrix</param>
        public static BitMatrix32 and(in BitMatrix32 A, in BitMatrix32 B)
        {
            const int rowstep = 8;
            var dst = BitMatrix32.Alloc();
            for(var i=0; i< A.RowCount; i += rowstep)
                dinx.and(Vec256.Load(ref A[i]), Vec256.Load(ref B[i])).StoreTo(ref dst[i]);
            return dst;
        }

        /// <summary>
        /// Computes the bitwise AND between two square bitmatrices of common natural order and stores the
        /// result a caller-supplied target matrix
        /// </summary>
        /// <param name="A">The first source operand</param>
        /// <param name="B">The second source operand</param>
        /// <param name="C">The target</param>
        /// <typeparam name="N">The matrix order</typeparam>
        /// <typeparam name="T">The matrix storage type</typeparam>
        [MethodImpl(Inline)]
        public static ref BitMatrix<N,T> and<N,T>(in BitMatrix<N,T> A, in BitMatrix<N,T> B, ref BitMatrix<N,T> C)
            where N : ITypeNat, new()
            where T : unmanaged
        {
            gbitspan.and(A.Data, B.Data, C.Data);
            return ref C;
        }

        /// <summary>
        /// Computes the bitwise AND between two square bitmatrices of common order
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix<N,T> and<N,T>(in BitMatrix<N,T> A, in BitMatrix<N,T> B)
            where N : ITypeNat, new()
            where T : unmanaged
        {
            var C = Alloc<N,T>();
            return and(in A, in B, ref C);
        }

        /// <summary>
        /// Computes the bitwise AND between two bitmatrices of common dimension and stores the
        /// result a caller-supplied target matrix
        /// </summary>
        /// <param name="A">The first source operand</param>
        /// <param name="B">The second source operand</param>
        /// <param name="C">The target</param>
        /// <typeparam name="N">The matrix order</typeparam>
        /// <typeparam name="T">The matrix storage type</typeparam>
        [MethodImpl(Inline)]
        public static ref BitMatrix<M,N,T> and<M,N,T>(in BitMatrix<M,N,T> A, in BitMatrix<M,N,T> B, ref BitMatrix<M,N,T> C)        
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : unmanaged
        {
            gbitspan.and(A.Data, B.Data, C.Data);
            return ref C;
        }


    }

}