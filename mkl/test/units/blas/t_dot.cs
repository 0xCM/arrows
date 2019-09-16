//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static nfunc;
    
    public class t_dot : t_mkl<t_dot>
    {
        [MethodImpl(Inline)]
        internal static T dot<T>(in BlockVector<T> lhs, in BlockVector<T> rhs)
            where T : struct
                => gmath.dot<T>(lhs.Unblocked, rhs.Unblocked);

        [MethodImpl(Inline)]
        internal static T dot<N,T>(in BlockVector<N,T> lhs, in BlockVector<N,T> rhs)
            where N : ITypeNat, new()
            where T : struct    
                => gmath.dot<T>(lhs.Unsized,rhs.Unsized);

        public void dot32f()
        {
            for(var i=0; i< DefaltCycleCount; i++)
            {
                var x = RVecF32(DefaultSampleSize);
                var y = RVecF32(DefaultSampleSize);
                Claim.eq(mkl.dot(x,y),dot(x,y));
            }
        }

        public void dot32fn()
        {
            for(var i=0; i< DefaltCycleCount; i++)
            {
                var x = RVecF32(DefaultSampleNat);
                var y = RVecF32(DefaultSampleNat);
                Claim.eq(mkl.dot(x,y),dot(x,y));
            }
        }

        public void dot64f()
        {
            for(var i=0; i< DefaltCycleCount; i++)
            {
                var x = RVecF64(DefaultSampleSize);
                var y = RVecF64(DefaultSampleSize);
                Claim.eq(mkl.dot(x,y),dot(x,y));
            }
        }

        public void dot64fn()
        {
            for(var i=0; i< DefaltCycleCount; i++)
            {
                var x = RVecF64(DefaultSampleNat);
                var y = RVecF64(DefaultSampleNat);                
                Claim.eq(mkl.dot(x,y),dot(x,y));
            }
        }
    }
}