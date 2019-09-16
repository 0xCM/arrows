//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Text;
    using static nfunc;
    using static zfunc;

    public static class MatrixFormat
    {
        public static Matrix<M,N,T> ToMatrix<M,N,T>(this BlockMatrix<M,N,T> src)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : unmanaged    
                => Matrix.Load<M,N,T>(src.Unblocked.ToArray());

        public static string Format<M,N,T>(this BlockMatrix<M,N,T> src, int? cellwidth = null, char? cellsep = null, Func<T,string> render = null)
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
                    var cellval = src[row,col];
                    var cellfmt = $"{render?.Invoke(cellval) ?? cellval.ToString()}".PadRight(width);
                    sb.Append(cellfmt);
                    if(col != cols - 1)
                        sb.Append(sep);
                }
                sb.AppendLine();
            }
            return sb.ToString();            
        }

        public static string Format<M,N,T>(this Matrix<M,N,T> src, int? cellwidth = null, char? cellsep = null, Func<T,string> render = null)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : unmanaged    
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
                    var cellval = src[row,col];
                    var cellfmt = $"{render?.Invoke(cellval) ?? cellval.ToString()}".PadRight(width);
                    sb.Append(cellfmt);
                    if(col != cols - 1)
                        sb.Append(sep);
                }
                sb.AppendLine();
            }
            return sb.ToString();            
        }

        [MethodImpl(Inline)]
        public static string Format<N,T>(this BlockMatrix<N,T> src, int? cellwidth = null, char? cellsep = null, Func<T,string> render = null)
            where N : ITypeNat, new()
            where T : struct    
                => src.ToRectangular().Format(cellwidth, cellsep,render);

        [MethodImpl(Inline)]
        public static string Format<N,T>(this Matrix<N,T> src, int? cellwidth = null, char? cellsep = null, Func<T,string> render = null)
            where N : ITypeNat, new()
            where T : unmanaged    
                => src.ToRectangular().Format(cellwidth, cellsep,render);

        [MethodImpl(Inline)]
        public static string Format<N,T>(this Covector<N,T> src)
            where T : unmanaged    
            where N: ITypeNat, new()
                => src.Span.FormatList();

        /// <summary>
        /// Renders the source vector as text
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="N">The natural type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static string Fomat<N,T>(this BlockVector<N,T> src)
            where T : struct    
            where N: ITypeNat, new()
                => src.Unsized.FormatList();

    }

}