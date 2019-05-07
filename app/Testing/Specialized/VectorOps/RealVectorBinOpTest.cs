//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Testing
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zcore;
    using static zfunc;



    public abstract class RealVectorBinOpTest<C,N,T,R> : VectorBinOpTest<C,N,T,R>
        where C : RealVectorBinOpTest<C,N,T,R>
        where N : ITypeNat, new()
        where T : struct, IEquatable<T>            
        where R : struct, IEquatable<R>
    {

        /// <summary>
        /// The source for left real vectors
        /// </summary>
        protected  Index<Vector<N,real<T>>> LeftRealVecSrc {get;}
        
        /// <summary>
        /// The source for right real vectors
        /// </summary>
        protected  Index<Vector<N,real<T>>> RightRealVecSrc {get;}

        protected RealVectorBinOpTest(Interval<T> bounds, Func<T,bool> filter = null,  int? SampleSize = null)
            : base(bounds, filter, SampleSize)
        {
            LeftRealVecSrc = map(LeftPrimVecSrc,v => v.map(real));
            RightRealVecSrc = map(RightPrimVecSrc,v => v.map(real));
        }

        public new virtual Index<Vector<N,real<R>>> Applied() 
            => index<Vector<N,real<R>>>();

        public virtual new void Verify()
        {
            var expect = Baseline();
            var actual = Applied().Map(x => x.map(y => y.unwrap()));
            iter(VectorCount, i => Claim.eq(expect[i], actual[i]));
        }
    }
}