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


    public abstract class RealVectorBinOpTest<N,T,R> : VectorBinOpTest<N,T,R>
        where N : TypeNat, new()
        where T : struct, IEquatable<T>            
        where R : struct, IEquatable<R>
    {

        /// <summary>
        /// The source for left real vectors
        /// </summary>
        protected  IReadOnlyList<Vector<N,real<T>>> LeftRealVecSrc {get;}
        
        /// <summary>
        /// The source for right real vectors
        /// </summary>
        protected  IReadOnlyList<Vector<N,real<T>>> RightRealVecSrc {get;}

        protected RealVectorBinOpTest(T MinPrimVal, T MaxPrimVal, uint SampleSize = Pow2.T20)
            : base(MinPrimVal, MaxPrimVal, SampleSize)
        {
            LeftRealVecSrc = map(LeftPrimVecSrc,v => v.map(real));
            RightRealVecSrc = map(RightPrimVecSrc,v => v.map(real));
        }

        public new virtual IReadOnlyList<Vector<N,real<R>>> Applied() 
            => list<Vector<N,real<R>>>();

        public virtual new void Verify()
        {
            var expect = Baseline();
            var actual = Applied().Map(x => x.map(y => y.unwrap()));
            iter(VectorCount, i => Claim.eq(expect[i], actual[i]));
        }
    }
}