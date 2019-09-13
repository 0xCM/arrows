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

        public void disable_after()
        {
            var src = BitVector16.Ones;
            var dst = src.Replicate();
            dst.DisableAfter(2);
            Claim.eq((ushort)0b111, dst);
        }

        public void select_16()
        {
            
            var src = Random.Next<ushort>();
            var a = Bits.select(src, Part10x1.Part0 | Part10x1.Part2 | Part10x1.Part3);
            var b = src.ToBitVector();
            b.DisableAfter(2);
            Claim.eq(a,b);

        }


    }

}