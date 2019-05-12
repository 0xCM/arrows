//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.ComponentModel;

    using Z0.Testing;
    
    using static zcore;
    using static zfunc;

    
    using P = Paths;

    public abstract class InXEqualityTest<S,T> : InXTest<S,T>
        where S : InXEqualityTest<S,T>
        where T : struct, IEquatable<T>
    {
                
        protected InXEqualityTest(Interval<T>? domain = null, int? sampleSize = null)
            : base(OpKind.Eq.Vec128OpId<T>(), domain, sampleSize)        
        {
            
        }
                
        protected IEnumerable<bool> Results()
        {
            yield return false;
            // for(var i = 0; i< VecCount; i++)
            //     yield return eq(LeftVecSrc[i], LeftVecSrc[i]);            
        }

        public virtual void Apply()
            => trace(Results().Freeze().Length);
        
        public virtual void Verify()
            => iter(Results(), result => Claim.@true(result));
    }

    public class EqualityTests
    {
        const string BasePath = P.InX128 + P.eq;
        [DisplayName(Path)]
        public class EqUInt8 : InXEqualityTest<EqUInt8,byte>
        {
            public const string Path = BasePath + P.uint8;
                
            public override void Verify()
                =>  base.Verify();
                
            public override void Apply()
                => base.Apply();

        }

        [DisplayName(Path)]
        public class EqUInt16 : InXEqualityTest<EqUInt16,ushort>
        {
            public const string Path = BasePath + P.uint16;
                
            public override void Verify()
                => base.Verify();
                
            public override void Apply()
                => base.Apply();
        }

        [DisplayName(Path)]
        public class EqInt16 : InXEqualityTest<EqInt16,short>
        {
            public const string Path = BasePath + P.int16;
                
            public override void Verify()
                => base.Verify();
                
            public override void Apply()
                => base.Apply();

        }

        [DisplayName(Path)]
        public class EqInt32 : InXEqualityTest<EqInt32,int>
        {
            public const string Path = BasePath + P.int64;

            public override void Verify()
                => base.Verify();
                
            public override void Apply()
                => base.Apply();

        }

        [DisplayName(Path)]
        public class EqUInt32 : InXEqualityTest<EqUInt32,uint>
        {
            public const string Path = BasePath + P.uint32;

            public override void Verify()
                => base.Verify();

            public override void Apply()
                => base.Apply();

        }

        [DisplayName(Path)]
        public class EqInt64 : InXEqualityTest<EqInt64,long>
        {
            public const string Path = BasePath + P.int64;

            public override void Verify()
                => base.Verify();

            public override void Apply()
                => base.Apply();

        }

        [DisplayName(Path)]
        public class EqUInt64 : InXEqualityTest<EqUInt64,ulong>
        {
            public const string Path = BasePath + P.uint64;

            public override void Verify()
                => base.Verify();

            public override void Apply()
                => base.Apply();

        }

        [DisplayName(Path)]
        public class EqFloat32 : InXEqualityTest<EqFloat32,float>
        {
            public const string Path = BasePath + P.float64;

            public override void Verify()
                => base.Verify();

            public override void Apply()
                => base.Apply(); 
        }

        [DisplayName(Path)]
        public class EqFloat64 : InXEqualityTest<EqFloat64,double>
        {
            public const string Path = BasePath + P.float64;

            public override void Verify()
                => base.Verify();

            public override void Apply()
                => base.Apply(); 
        }

    }
}