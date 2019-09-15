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

    public class ts_select : UnitTest<ts_select>
    {        
        public void select_16()
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


    }

}