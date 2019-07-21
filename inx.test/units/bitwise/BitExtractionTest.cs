//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public class BitExtractionTest : UnitTest<BitExtractionTest>
    {        
        public void ExtractBits()
        {
            var src = 0b00001010110000101001_001_111_011_001u;
            var bsSrc = src.ToBitString().Format2(true);
            Claim.eq("1010110000101001001111011001", bsSrc);
            
            var i=-3; 

            var x0 = gbits.extract(in src, (byte)(i += 3), 3);
            var bsx0 = x0.ToBitString();
            var y0 = bsx0.ToPrimalValue<uint>();
            Claim.eq(x0,y0);


            var x1 = gbits.extract(in src, (byte)(i += 3), 3);
            var bsx1 = x1.ToBitString();
            var y1 = bsx1.ToPrimalValue<uint>();
            Claim.eq(x1,y1);

            var x2 = gbits.extract(in src, (byte)(i += 3), 3);
            var bsx2 = x2.ToBitString();
            var y2 = bsx2.ToPrimalValue<uint>();
            Claim.eq(x2,y2);
            
            var x3 = gbits.extract(in src, (byte)(i += 3), 3);
            var bsx3 = x3.ToBitString();
            var y3 = bsx3.ToPrimalValue<uint>();
            Claim.eq(x3,y3);            
        }
    }

}