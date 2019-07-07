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

    public class BitRangeTest : UnitTest<BitRangeTest>
    {

        public void TestBitStringRange()
        {
                    //0b00001010110000101001001111011001
            var src = 0b00001010110000101001001111011001u;
            var bsSrc = src.ToBitString();
            Trace($"bs = {bsSrc}");
            var r1 = bsSrc.Range(0, 8);
            var r2 = bsSrc.Range(8, 8);
            Trace($"r1 = {r1}");
            Trace($"r2 = {r2}");

        }
        
        public void TestBitRange()
        {
            var src = 0b00001010110000101001_001_111_011_001u;
            var bsSrc = src.ToBitString();
            
            var i=-3; 

            var x0 = gbits.range(in src, i += 3, 3);
            var bsx0 = x0.ToBitString(true);
            var y0 = bsx0.ToValue<uint>();
            Claim.eq(x0,y0);

            var x1 = gbits.range(in src, i += 3, 3);
            var bsx1 = x1.ToBitString(true);
            var y1 = bsx1.ToValue<uint>();
            Claim.eq(x1,y1);

            var x2 = gbits.range(in src, i += 3, 3);
            var bsx2 = x2.ToBitString(true);
            var y2 = bsx2.ToValue<uint>();
            Claim.eq(x2,y2);
            
            var x3 = gbits.range(in src, i += 3, 3);
            var bsx3 = x3.ToBitString(true);
            var y3 = bsx3.ToValue<uint>();
            Claim.eq(x3,y3);            
        }
    }

}