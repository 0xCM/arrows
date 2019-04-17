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
    using System.ComponentModel;

    using Z0.Testing;
    
    using static zcore;
    
    using P = Paths;

    public abstract class EqTest<S,T> : InXTest<S,T>
        where S : EqTest<S,T>
        where T : struct, IEquatable<T>
    {
        protected static readonly InXEq<T> InXOp = InXG.eq<T>();        
        
        protected EqTest(Interval<T>? domain = null, int? sampleSize = null)
            : base(P.eq, domain, sampleSize)        
        {
            
        }
                
        protected IEnumerable<Vec128<T>> Results()
        {
            for(var i = 0; i< VecCount; i++)
                yield return InXOp.eq(LeftVecSrc[i], LeftVecSrc[i]);            
        }

        public virtual void Apply()
        {
            var result = Results().ToReadOnlyList();
            trace(result.Count);
        }                

        public virtual void Verify()
        {
            var zero = primops.zero<T>();
            var result = Results().ToReadOnlyList();
            for(var i = 0; i< VecCount; i++)
            {
                var components = result[i].ToArray();
                if(components.Any(c => c.Equals(zero)))
                    Claim.fail("The components are not equal");
            }                
        }        
    }

    public class EqualityTests
    {
        const string BasePath = P.InX128 + P.eq;

        [DisplayName(Path)]
        public class EqInt16 : EqTest<EqInt16,short>
        {
            public const string Path = BasePath + P.int16;
                
            public override void Verify()
                => base.Verify();
                
            public override void Apply()
                => base.Apply();
        }

        [DisplayName(Path)]
        public class EqInt32 : EqTest<EqInt32,int>
        {
            public const string Path = BasePath + P.int64;

            public override void Verify()
                => base.Verify();
                
            public override void Apply()
                => base.Apply();
        }

        [DisplayName(Path)]
        public class EqUInt32 : EqTest<EqUInt32,uint>
        {
            public const string Path = BasePath + P.uint32;

            public override void Verify()
                => base.Verify();

            public override void Apply()
                => base.Apply();

        }

        [DisplayName(Path)]
        public class EqFloat64 : EqTest<EqFloat64,double>
        {
            public const string Path = BasePath + P.float64;

            public override void Verify()
                => base.Verify();
                
            public override void Apply()
                => base.Apply();
        }        
    }
}