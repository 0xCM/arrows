//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tests.InX128
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using Z0.Testing;
    
    using static zcore;
    
    using P = Paths;

    public abstract class AddTest<S,T> : InXTest<S,T>
        where S : AddTest<S,T>
        where T : struct, IEquatable<T>
    {
        protected const string BasePath = P.InX128 + P.add;        
        
        protected static readonly InX128Add<T> InXOp = InX128G.add<T>();
        
        protected static readonly Operative.PrimOps<T> PrimOps = primops.typeops<T>();
        
        protected T[] LeftDataSrc {get;}

        protected T[]  RightDataSrc {get;}
        protected IReadOnlyList<Vec128<T>> LeftVecSrc {get;}

        protected IReadOnlyList<Vec128<T>> RightVecSrc {get;}

        protected AddTest(Interval<T>? domain = null, int? streamlen = null)
            : base("+",domain,streamlen)        
        {
            this.LeftDataSrc = RandomArray(SampleSize);
            this.RightDataSrc = RandomArray(SampleSize);
            this.LeftVecSrc = Vec128.stream(LeftDataSrc).ToReadOnlyList();
            this.RightVecSrc = Vec128.stream(RightDataSrc).ToReadOnlyList();
        }
        
        protected IEnumerable<Vec128<T>> ApplyOp()
        {
            for(var i = 0; i< LeftVecSrc.Count; i++)
                yield return InXOp.add(LeftVecSrc[i], RightVecSrc[i]);            
        }

        protected void VerifyOp()
        {
            var result = ApplyOp().ToReadOnlyList();
            var left = Arr.partition(LeftDataSrc,VecLength).ToReadOnlyList();
            var right = Arr.partition(RightDataSrc, VecLength).ToReadOnlyList();
            for(var i = 0; i<LeftVecSrc.Count; i++)
            {
                var expect = Vec128.define(PrimOps.add(left[i],right[i]));
                var actual = result[i];
                Claim.eq(expect, actual);
            }                
        }

        protected void trace(int count, [CallerMemberName] string caller = null)
            => base.trace($"Computed the sum of {count} vectors",caller);
        
        public virtual void Verify() {}

        public virtual void Apply() {}

    }


}