//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tests.InXTests
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using Z0.Testing;
    
    using static zcore;
    
    using P = Paths;

    public class AndTest<T> : InXBinOpTest<AndTest<T>,T>
        where T : struct, IEquatable<T>
    {                
        public AndTest(Interval<T>? domain = null, int? sampleSize = null)
            : base("add", domain, sampleSize)        
        {

        }

        protected override PrimalFusedBinOp<T> IndexOp {get;} 
            = PrimalFusion.and;    

        protected override Vec128BinOp<T> VecOp {get;}

        public virtual void VerifyGeneric()
        {                
            // Claim.eq(
            //     IndexOp(LeftDataSrc,RightDataSrc),
            //     LeftDataSrc.AndG(RightDataSrc)
            //     );            
        }

        public override void VerifyAll()
        {
            base.VerifyAll();
            VerifyGeneric();
        }
    }

    [DisplayName(BasePath)]
    public class AndTests : UnitTest<AndTests>
    {
        const string BasePath = P.InX128 + P.add;        
        
        [DisplayName(P.int8)]
        public void AndI8()
            => new AndTest<byte>().VerifyAll();

        [DisplayName(P.uint8)]
        public void AndU8()
            => new AndTest<sbyte>().VerifyAll();

        [DisplayName(P.int16)]
        public void AndI16()
            => new AndTest<short>().VerifyAll();

        [DisplayName(P.uint16)]
        public void AndU16()
            => new AndTest<ushort>().VerifyAll();

        [DisplayName(P.int32)]
        public void AndI32()
            => new AndTest<int>().VerifyAll();

        [DisplayName(P.uint32)]
        public void AndU32()
            => new AndTest<uint>().VerifyAll();

        [DisplayName(P.int64)]
        public void AndI64()
            => new AndTest<long>().VerifyAll();

        [DisplayName(P.uint64)]
        public void AndU64()
            => new AndTest<ulong>().VerifyAll();


    }
}