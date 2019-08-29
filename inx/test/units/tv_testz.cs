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

    public class tv_testz : UnitTest<tv_testz>
    {

        // Test case taken from https://docs.microsoft.com/en-us/previous-versions/bb514073(v=vs.120)
        public void testz128i32()
        {
            var a = Vec128.FromParts(0x55550000BBBB9999ul, 0x0123456789ABCDEFul);
            var b = Vec128.FromParts(0xAAAAFFFF44446666ul, 0xFEDCBA9876543210ul);
            var c = Vec128.FromParts(0x55550000BBCB9999ul, 0x0123456789ABCDEFul);
            Claim.yea(Bits.testz(a,b));
            Claim.nea(Bits.testz(c,b));            
        }
        
        public void testz128u8()
        {            
            var v1 = Vec128.Fill((byte)0b01100011);
            var v2 = Vec128.Fill((byte)0b10011100);
            var v3 = Vec128.Fill((byte)0b11111111);
            
            //Should be true since the logical and of V1 and V2 is zero
            Claim.yea(Bits.testz(v1,v2));

            //Should be false since the logical and of both V1 and V2 with V3 is nonzero
            Claim.nea(Bits.testz(v1,v3));
            Claim.nea(Bits.testz(v2,v3));    
        }
    }
}
