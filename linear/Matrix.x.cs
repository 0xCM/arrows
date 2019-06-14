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
        
    using static zfunc;
    using static nfunc;
    using Z0.Mkl;

    public static class MatrixX
    {
        static bool betterEq<M,N,T>(Matrix<M,N,T> lhs, Matrix<M,N,T> rhs)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct    
        {
            var lhsSrc = lhs.Data.Unsize();
            var rhsSrc = rhs.Data.Unsize();
            var dataLen = nati<M>() * nati<N>();
            Span256.alignment<T>(dataLen, out int blocklen, out int fullBlocks, out int remainder);
            var aligned = blocklen*fullBlocks;
            var lhs256 = Span256.load(lhsSrc.Slice(0, aligned));
            var rhs256 = Span256.load(rhsSrc.Slice(0, aligned));
            
            //TODO: Implment the ginx ops to finish this
            return false;
        }


        [MethodImpl(Inline)]
        static bool eq<M,N,T>(Matrix<M,N,T> lhs, Matrix<M,N,T> rhs)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct    
        {
            var lhsSrc = lhs.Data.Unsize();
            var rhsSrc = rhs.Data.Unsize();
            var dataLen = nati<M>() * nati<N>();
            var eq = gmath.eq<T>(lhsSrc, rhsSrc);
            return eq.All(x => x == true);
        }

        public static bool NEq<M,N,T>(this Matrix<M,N,T> lhs, Matrix<M,N,T> rhs)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct    
        {
            var lhsSrc = lhs.Data.Unsize();
            var rhsSrc = rhs.Data.Unsize();
            var dataLen = nati<M>() * nati<N>();
            var eq = gmath.eq<T>(lhsSrc, rhsSrc);
            return eq.Any(x => x == false);
        }

        public static Matrix<M,N,T> Random<M,N,T>(this IRandomSource random)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct    
                =>  random.Span<M,N,T>();

        [MethodImpl(Inline)]
        public static Matrix<M,P,double> Mul<M,N,P>(this Matrix<M,N,double> lhs, Matrix<N,P,double> rhs)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where P : ITypeNat, new()
                => mkl.gemm(lhs.Data,rhs.Data);

        public static string Format<M,N,T>(this Matrix<M,N,T> src, char cellsep = AsciSym.Comma, char rowsep = AsciEscape.NewLine, int? zpad = null)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct    
            => src.Format(cellsep, rowsep, zpad);
    }
}