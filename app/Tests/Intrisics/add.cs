//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tests.InXTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    using Z0.Testing;
    
    using static zcore;
    
    using P = Paths;

    public class AddTest<T> : InXBinOpTest<AddTest<T>,T>
        where T : struct, IEquatable<T>
    {                
        public AddTest(Interval<T>? domain = null, int? sampleSize = null)
            : base("add", domain, sampleSize)        
        {

        }

        protected override IndexBinOp<T> IndexOp {get;} 
            = PrimOps.add;    

        protected override Vec128BinOp<T> VecOp {get;}
            = Vec128Ops.add; 

        public virtual void VerifyGeneric()
        {                
            Claim.eq(
                IndexOp(LeftDataSrc,RightDataSrc),
                LeftDataSrc.AddG(RightDataSrc)
                );            
        }

        public override void VerifyAll()
        {
            base.VerifyAll();
            VerifyGeneric();
        }
    }

    [DisplayName(BasePath)]
    public class AddTests : UnitTest<AddTests>
    {
        const string BasePath = P.InX128 + P.add;        
        
        [DisplayName(P.int8)]
        public void AddI8()
            => new AddTest<byte>().VerifyAll();

        [DisplayName(P.uint8)]
        public void AddU8()
            => new AddTest<sbyte>().VerifyAll();

        [DisplayName(P.int16)]
        public void AddI16()
            => new AddTest<short>().VerifyAll();

        [DisplayName(P.uint16)]
        public void AddU16()
            => new AddTest<ushort>().VerifyAll();

        [DisplayName(P.int32)]
        public void AddI32()
            => new AddTest<int>().VerifyAll();

        [DisplayName(P.uint32)]
        public void AddU32()
            => new AddTest<uint>().VerifyAll();

        [DisplayName(P.int64)]
        public void AddI64()
            => new AddTest<long>().VerifyAll();

        [DisplayName(P.uint64)]
        public void AddU64()
            => new AddTest<ulong>().VerifyAll();

        [DisplayName(P.float32)]
        public void AddF32()
            => new AddTest<short>().VerifyAll();

        [DisplayName(P.float64)]
        public void AddF64()
            => new AddTest<double>().VerifyAll();


    }
}