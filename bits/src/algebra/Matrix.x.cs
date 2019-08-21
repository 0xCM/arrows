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

    using static zfunc;
    using static nfunc;

    public static class MatrixX
    {

        public static string Format<M,N,T>(this Matrix<M,N,T> src, int? cellwidth = null, char? cellsep = null)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct    
        {
            var sep = cellsep ?? '|';
            var width = cellwidth ?? 3;
            var rows = nati<M>();
            var cols = nati<N>();
            var sb = new StringBuilder();                        
            for(var row = 0; row < rows; row++)
            {
                for(var col = 0; col<cols; col++)
                {
                    var value = $"{src[row,col]}".PadRight(width);
                    sb.Append(value);
                    if(col != cols - 1)
                        sb.Append(sep);
                }
                sb.AppendLine();
            }
            return sb.ToString();            
        }

        [MethodImpl(Inline)]
        public static string Format<N,T>(this Matrix<N,T> src, int? cellwidth = null, char? cellsep = null)
            where N : ITypeNat, new()
            where T : struct    
                => src.ToRectantular().Format(cellwidth, cellsep);

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
            lhs.Unsized.ReadOnly().Add(rhs.Unsized, lhs.Unsized);
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
            lhs.Unsized.ReadOnly().Sub(rhs.Unsized, lhs.Unsized);
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
        {
            var _fmt = fmt ?? TextFormat.Default;
            var sep = _fmt.Delimiter;
            var rows = nati<M>();
            var cols = nati<N>();
            var sb = new StringBuilder();                        
            sb.AppendLine($"{_fmt.CommentPrefix} {typeof(T).Name}[{rows}x{cols}]");
            if(_fmt.HasHeader)
            {
                for(var i = 0; i<cols; i++)
                {
                    sb.Append($"Col{i}");
                    if(i != cols - 1)
                        sb.Append(sep);
                }
                sb.AppendLine();
            }
            sb.Append(src.Format(sep));
            
            if(overwrite)
                dst.Overwrite(sb.ToString());
            else
                dst.Append(sb.ToString());
        }

        /// <summary>
        /// Evaluates whether a square matrix is right-stochasitc, i.e. the sum of the entries
        /// in each row is equal to 1
        /// </summary>
        /// <param name="src">The matrix to evaluate</param>
        /// <param name="n">The natural dimension value</param>
        /// <typeparam name="N">The natural dimension type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
         public static bool IsRightStochastic<N,T>(this Matrix<N,T> src, N n = default)
            where N : ITypeNat, new()
            where T : struct
        {
            var tol = .001;
            var radius = closed(1 - tol,1 + tol);   
            for(var r = 0; r < (int)n.value; r ++)
            {
                var row = src.Row(r);
                var sum =  convert<T,double>(gmath.sum(row.Unsized));
                if(!radius.Contains(sum))
                    return false;
            }
            return true;
        }

    }
}