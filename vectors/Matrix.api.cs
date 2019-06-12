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
    
    using static nfunc;
    using static zfunc;


    public static class Matrix
    {
        public static Matrix<M,N,T> load<M,N,T>(Span<M,N,T> src)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
                => new Matrix<M, N, T>(src);


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


        public static bool eq<M,N,T>(Matrix<M,N,T> lhs, Matrix<M,N,T> rhs)
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

        public static bool neq<M,N,T>(Matrix<M,N,T> lhs, Matrix<M,N,T> rhs)
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


    }

}