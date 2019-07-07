//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;

    using static zfunc;

    using D = PrimalDelegates;

    public class BitViewTest : UnitTest<BitViewTest>
    {
        public void UnsignedNegation()
        {
            var x = Random.Vec256<int>();
            var y = x.ToBitView();
            var sb = sbuild();
            for(var i = y.ByteCount - 1; i >= 0; i--)
            {
                for(var j=7; j>= 0; j--)
                    sb.Append($"{y[i,j]}");
            }
            var ys = sb.ToString();
            var xs = x.ToBitString();
            Claim.eq(xs,ys);
        }
    }
}