//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Text;
    using Z0.Mkl;        

    using static zfunc;
    using static nfunc;

    public static class MatrixX
    {
        /// <summary>
        /// Aligns the content of a tablespan with a blocked 256-bit span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="M">The natural row count type</typeparam>
        /// <typeparam name="N">The natural column count type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        public static Span256<T> Align256<M,N,T>(this Span<M,N,T> src)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct    
        {            
            var lhsSrc = src.Unsize();
            var dataLen = nati<M>() * nati<N>();
            Span256.alignment<T>(dataLen, out int blocklen, out int fullBlocks, out int remainder);            
            if(remainder == 0)
                return Span256.load(lhsSrc);
            else
            {
                var dst = Span256.alloc<T>(fullBlocks + 1);
                lhsSrc.CopyTo(dst);
                return dst;
            }            
        }

        public static string Format<M,N,T>(this Matrix<M,N,T> src, TextFormat? fmt = null)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct    
                => Matrix.Format<M,N,T>(src, fmt);

        /// <summary>
        /// Computes the sum of two matrices and stores the result in the left matrix
        /// </summary>
        /// <param name="lhs">The left matrix</param>
        /// <param name="rhs">The right matrix</param>
        /// <typeparam name="M">The natural row count type</typeparam>
        /// <typeparam name="N">The natural column count type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref Matrix<M,N,T> Add<M,N,T>(this ref Matrix<M,N,T> lhs, Matrix<M,N,T> rhs)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct    
        {
            lhs.Data.ReadOnly().Add(rhs.Data, lhs.Data);
            return ref lhs;
        }

        /// <summary>
        /// Computes the difference of two matrices and stores the result in the left matrix
        /// </summary>
        /// <param name="lhs">The left matrix</param>
        /// <param name="rhs">The right matrix</param>
        /// <typeparam name="M">The natural row count type</typeparam>
        /// <typeparam name="N">The natural column count type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref Matrix<M,N,T> Sub<M,N,T>(this ref Matrix<M,N,T> lhs, Matrix<M,N,T> rhs)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct    
        {
            lhs.Data.ReadOnly().Sub(rhs.Data, lhs.Data);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Matrix<M,N,T> Or<M,N,T>(this ref Matrix<M,N,T> lhs, Matrix<M,N,T> rhs)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct    
        {
            lhs.Data.ReadOnly().Or(rhs.Data, lhs.Data);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Matrix<M,N,T> And<M,N,T>(this ref Matrix<M,N,T> lhs, Matrix<M,N,T> rhs)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct    
        {
            lhs.Data.ReadOnly().And(rhs.Data, lhs.Data);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Matrix<M,N,T> XOr<M,N,T>(this ref Matrix<M,N,T> lhs, Matrix<M,N,T> rhs)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct    
        {
            lhs.Data.ReadOnly().XOr(rhs.Data, lhs.Data);
            return ref lhs;
        }

        /// <summary>
        /// Writes the matrix to a delimited file
        /// </summary>
        /// <param name="src">The source matrix</param>
        /// <param name="dst">The target file</param>
        /// <typeparam name="M">The natural row count type</typeparam>
        /// <typeparam name="N">The natural column count type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        public static void WriteTo<M,N,T>(this Matrix<M,N,T> src, FilePath dst, bool overwrite = true, TextFormat? fmt = null)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct    
                => Matrix.WriteTo(src,dst,overwrite,fmt);

        /// <summary>
        /// Evaluates whether a square matrix is right-stochasitc, i.e. the sum of the entries
        /// in each row is equal to 1
        /// </summary>
        /// <param name="src">The matrix to evaluate</param>
        /// <param name="n">The natural dimension value</param>
        /// <typeparam name="N">The natural dimension type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
         public static bool IsRightStochastic<N,T>(this Matrix<N,N,T> src, N n = default)
            where N : ITypeNat, new()
            where T : struct
        {
            var tol = .0001;
            var radius = closed(1 - tol,1 + tol);   
            for(var r = 0; r < (int)n.value; r ++)
            {
                var row = src.Row(r);
                var sum =  convert<T,double>(gmath.sum(row.Unsize()));
                if(!radius.Contains(sum))
                    return false;
            }
            return true;
        }

    }
}