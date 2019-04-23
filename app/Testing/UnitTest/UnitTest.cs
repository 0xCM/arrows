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
    using System.Diagnostics;

    using static zcore;
    
    public interface IUnitTest : IContext
    {

    }

    public abstract class UnitTest<T> : Context<T>, IUnitTest
        where T : UnitTest<T>
    {
        protected static readonly TestContext<T> Context = TestContext.define<T>(RandSeeds.TestSeed);

        List<AppMsg> Messages {get;} = new List<AppMsg>();
        
        protected int SampleSize {get;}

        protected virtual string OpName 
            => string.Empty;

        protected UnitTest(int? SampleSize = null)
            : base(RandSeeds.TestSeed)            
        {
            this.SampleSize = SampleSize ?? Defaults.SampleSize;            
        }

             
        protected virtual string ClaimEq<X>(X lhs, X rhs)
            where X : struct, IEquatable<X>
                => Claim.eq(lhs,rhs);

        protected virtual void ClaimEq<X>(IReadOnlyList<X> lhs, IReadOnlyList<X> rhs)
            where X : struct, IEquatable<X>
                => Claim.eq(lhs,rhs);

        protected virtual string ClaimEq(string lhs, string rhs)
            => Claim.eq(lhs,rhs);

        protected virtual void Fail(string msg)
            => throw new Exception(msg);

        public virtual X Fail<X>(string msg)
            => throw new Exception(msg);
    }

}
