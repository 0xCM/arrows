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
    using System.Runtime.InteropServices;

    using static zfunc;
    using static BitParts;

    public class ts_select : ScalarBitTest<ts_select>
    {        
        public void select_10x1()
        {            
            var src = Random.Next<ushort>();
            var maskA = (ushort)0b111;
            var maskB = Part10x1.Part0 | Part10x1.Part1 | Part10x1.Part2;
            var maskC = maskB.ToScalar();
            Claim.eq(maskA,maskC);
            
            var a = Bits.gather(src, maskA);
            var b = Bits.select(src, maskB);
            Claim.eq(a,b);

            var bv = src.ToBitVector();
            bv.DisableAfter(2);
            Claim.eq(bv, a.ToBitVector());
        }

        public void select_32x4()
        {
            var src = Random.Next<uint>();
            var bv = src.ToBitVector();
            var x0 = Bits.select(src,Part32x4.Part0).ToBitVector32();
            Claim.eq(bv[0..3], x0);
                    
        }

        public void select_32x8()
        {
            var src = 0b11100111_01010101_11001100_11110000u;

            var x0 = 0b11110000u;
            var y0 = Bits.select(src, Part32x8.Part0);
            Claim.eq(x0, y0);

            var y1  = Bits.select(src, Part32x8.Part1);
            var x1 = 0b11001100u;
            Claim.eq(x1, y1);

            var x2 = 0b01010101u;
            var y2  = Bits.select(src, Part32x8.Part2);
            Claim.eq(x2, y2);
            
            var x3 = 0b11100111u;
            var y3  = Bits.select(src, Part32x8.Part3);
            Claim.eq(x3, y3);
        }


    }

}