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

    /// <summary>
    /// Characterizes a constant value
    /// </summary>
    /// <typeparam name="T">The value type</typeparam>
    public interface Constant<T>
        where T : struct, IEquatable<T>
    {
        T Value {get;}
    }
    
    public abstract class EqTest<S,T> : InXTest<S,T>
        where S : EqTest<S,T>
        where T : struct, IEquatable<T>
    {
        protected const string BasePath = P.InX128 + P.eq;        
        
        protected static readonly InXEq<T> InXOp = InXG.eq<T>();
        
        protected static readonly Operative.PrimOps<T> PrimOps = primops.typeops<T>();
        
        protected T[] LeftDataSrc {get;}

        protected T[]  RightDataSrc {get;}
        protected IReadOnlyList<Vec128<T>> LeftVecSrc {get;}

        protected IReadOnlyList<Vec128<T>> RightVecSrc {get;}

        protected EqTest(Interval<T>? domain = null, int? sampleSize = null)
            : base("+", domain, sampleSize)        
        {
            this.LeftDataSrc = RandArray(SampleSize);
            this.RightDataSrc = LeftDataSrc;
            this.LeftVecSrc = Vec128.stream(LeftDataSrc).ToReadOnlyList();
            this.RightVecSrc = Vec128.stream(RightDataSrc).ToReadOnlyList();
        }
                
        protected IEnumerable<Vec128<T>> ApplyOp()
        {
            for(var i = 0; i< VecCount; i++)
                yield return InXOp.eq(LeftVecSrc[i], RightVecSrc[i]);            
        }

        protected void VerifyOp()
        {
            var zero = primops.zero<T>();
            var result = ApplyOp().ToReadOnlyList();
            for(var i = 0; i<LeftVecSrc.Count; i++)
            {
                var components = result[i].ToArray();
                if(components.Any(c => c.Equals(zero)))
                    Claim.fail("The components are not equal");
            }
                
        }

        protected void trace(int count, [CallerMemberName] string caller = null)
            => base.trace($"Compared equality for {count} vectors",caller);
        
        public virtual void Verify() {}

        public virtual void Apply() {}

    }


}