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

    public static class Matrix
    {
        /// <summary>
        /// Allocates a square matrix of natual dimension
        /// </summary>
        /// <param name="n">The square dimension; specified, if desired, to aid type inference</param>
        /// <param name="exemplar">An example value; specified, if desired, to aid type inference</param>
        /// <typeparam name="N">The natural dimension type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Matrix<N,N,T> Alloc<N,T>(N n = default, T exemplar = default)
            where N : ITypeNat, new()
            where T : struct
                => Span256.alloc<N,N,T>(); 

        /// <summary>
        /// Allocates a matrix of natual dimensions
        /// </summary>
        /// <param name="m">The row count, specified if desired to aid type inference</param>
        /// <param name="n">The column count, specified if desired to aid type inference</param>
        /// <param name="exemplar">An example value, specified if desired to aid type inference</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Matrix<M,N,T> Alloc<M,N,T>(M m = default, N n = default, T exemplar = default)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
                => Span256.alloc<M,N,T>(); 
         
        /// <summary>
        /// Loads a matrix of natural dimensions from a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The col count type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Matrix<M,N,T> Load<M,N,T>(Span256<T> src, M m = default, N n = default)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
                => new Matrix<M, N, T>(src);

        public static Matrix<M,N,T> Load<M,N,T>(Span<T> src,M m = default, N n = default)
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
   }

}