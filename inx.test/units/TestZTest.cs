//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;

    public class TestZTest : UnitTest<TestZTest>
    {


        public void ZeroIsZero()
        {
            Claim.eq(0, gbits.testz(Vec128<byte>.Zero, Vec128<byte>.Zero));
            Claim.eq(0, gbits.testz(Vec128<sbyte>.Zero, Vec128<sbyte>.Zero));
            Claim.eq(0, gbits.testz(Vec128<ulong>.Zero, Vec128<ulong>.Zero));
            Claim.eq(0, gbits.testz(Vec128<double>.Zero, Vec128<double>.Zero));
        }

        // Test case taken from https://docs.microsoft.com/en-us/previous-versions/bb514073(v=vs.120)
        public void Vec128Eq2()
        {
            var a = Vec128.define(0x55550000BBBB9999ul, 0x0123456789ABCDEFul);
            var b = Vec128.define(0xAAAAFFFF44446666ul, 0xFEDCBA9876543210ul);
            var c = Vec128.define(0x55550000BBCB9999ul, 0x0123456789ABCDEFul);
            Claim.yea(Bits.testz(a,b));
            Claim.nea(Bits.testz(c,b));
            
        }
        
        public void Vec128Eq1()
        {            
            var v1 = Vec128.fill((byte)0b01100011);
            var v2 = Vec128.fill((byte)0b10011100);
            var v3 = Vec128.fill((byte)0b11111111);
            
            //Should be true since the logical and of V1 and V2 is zero
            Claim.yea(Bits.testz(v1,v2));

            //Should be false since the logical and of both V1 and V2 with V3 is nonzero
            Claim.nea(Bits.testz(v1,v3));
            Claim.nea(Bits.testz(v2,v3));
        

        }
    }

}
