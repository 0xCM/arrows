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
    
    public interface IUnitTest
    {
        IEnumerable<AppMsg> DequeueMessages();
    }
    public abstract class UnitTest
    {

        protected virtual string OpName 
            => string.Empty;
    }

    public abstract class UnitTest<T> : UnitTest, IUnitTest
        where T : UnitTest<T>
    {
        protected static readonly TestContext<T> Context = TestContext.define<T>(RandSeeds.TestSeed);

        List<AppMsg> Messages {get;} = new List<AppMsg>();
        
        protected int SampleSize {get;}

        protected UnitTest(int? SampleSize = null)            
        {
            this.SampleSize = SampleSize ?? Defaults.SampleSize;
        }

        protected void trace(string msg, [CallerMemberName] string caller = null)
            => Messages.Add(AppMsg.Define(msg, SeverityLevel.Info, GetType().DisplayName() + caller));            
            

        IEnumerable<AppMsg> IUnitTest.DequeueMessages()
        {
            var copy = new List<AppMsg>(Messages);
            Messages.Clear();
            return copy;
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
