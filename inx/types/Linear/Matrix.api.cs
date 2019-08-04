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
    using Z0.Mkl;

    using static nfunc;
    using static zfunc;


    public static class Matrix
    {
        public static Matrix<M,N,T> Load<M,N,T>(Span256<T> src)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
                => new Matrix<M, N, T>(src);
        
        public static Matrix<M,N,T> Load<M,N,T>(Span<T> src)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
        {
            var blocklen = Span256.blocklength<T>();                        
            var qr = math.quorem(src.Length, blocklen);                        
            if(qr.Remainder == 0)
                return new Matrix<M,N,T>(Span256.load(src));
            else
            {
                var blocks = qr.Quotient + 1;
                var dst = Span256.alloc<T>(blocks);
                src.CopyTo(dst);
                return new Matrix<M,N,T>(dst);
            }                                            
        }

        /// <summary>
        /// Defines the canonical filename for a matrix data file
        /// </summary>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The column count type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static FileName DataFileName<M,N,T>(string fileId = null)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct    
                => FileName.Define($" {fileId ?? "mat"}_{PrimalKinds.kind<T>()}[{nati<M>()}x{nati<N>()}].csv");
        
        /// <summary>
        /// Reads a matrix from a delimited file
        /// </summary>
        /// <param name="src">The source file</param>
        /// <param name="format">The file format</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The column count type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        public static Matrix<M,N,T> ReadFrom<M,N,T>(FilePath src, TextFormat? format = null)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct    
        {
            var doc = src.ReadTextDoc().Require();
            var m = nati<M>();
            var n = nati<N>();

            if(m != doc.DataLineCount)
                return default;

            if(n != doc.Rows[0].Cells.Length)
                return default;

            var dst =  Load<M,N,T>(Span256.alloc<M,N,T>());
            for(var i = 0; i<doc.Rows.Length; i++)
            {
                ref readonly var row = ref doc[i];
                for(var j = 0; j<row.Cells.Length; j++)
                {
                    gmath.parse<T>(row.Cells[j].CellValue, out T cell);
                    dst[i,j] = cell;
                }                
            }

            return dst;
        }

        public static string Format<M,N,T>(Matrix<M,N,T> src, TextFormat? fmt = null)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct    
        {
            var _fmt = fmt ?? TextFormat.Default;
            var sep = _fmt.Delimiter;
            var rows = nati<M>();
            var cols = nati<N>();
            var sb = new StringBuilder();                        
            for(var row = 0; row < rows; row++)
            {
                for(var col = 0; col<cols; col++)
                {
                    sb.Append(src[row,col]);
                    if(col != cols - 1)
                        sb.Append(sep);
                }
                sb.AppendLine();
            }
            return sb.ToString();            

        }

        /// <summary>
        /// Writes a matrix to a delimited file
        /// </summary>
        /// <param name="src">The source matrix</param>
        /// <param name="dst">The target file</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The column count type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        public static void WriteTo<M,N,T>(Matrix<M,N,T> src, FilePath dst, bool overwrite = true, TextFormat? fmt = null)
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
            sb.Append(Format(src,_fmt));

            // for(var row = 0; row < rows; row++)
            // {
            //     for(var col = 0; col<cols; col++)
            //     {
            //         sb.Append(src[row,col]);
            //         if(col != cols - 1)
            //             sb.Append(sep);
            //     }
            //     sb.AppendLine();
            // }
            
            if(overwrite)
                dst.Overwrite(sb.ToString());
            else
                dst.Append(sb.ToString());
        }

   }

}