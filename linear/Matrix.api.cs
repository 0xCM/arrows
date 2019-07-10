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
        public static Matrix<M,N,T> load<M,N,T>(Span<M,N,T> src)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
                => new Matrix<M, N, T>(src);

        public static void save<M,N,T>(Matrix<M,N,T> src, FilePath dst)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct    
        {
            var sep = AsciSym.Comma;
            var rows = nati<M>();
            var cols = nati<M>();
            var sb = new StringBuilder();            
            sb.Append(typeof(T).Name);
            sb.Append(sep);
            sb.Append(rows);
            sb.Append(sep);
            sb.Append(cols);
            sb.Append(sep);
            for(var row = 0; row < rows; row++)
            {
                for(var col = 0; col<cols; col++)
                {
                    sb.Append(src[row,col]);
                    sb.Append(sep);
                }
            }
            var line = sb.ToString();
            dst.Append(line);
        }
    }

}