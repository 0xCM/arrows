//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;

    using static zfunc;

    public class ts_posl : ScalarBitTest<ts_posl>
    {
        
        public void FindLeastOnBit()
        {
            Claim.eq((byte)3, gbits.posl((byte)0b111000));
            Claim.eq(2u, gbits.posl(0b0001011000100u));
            Claim.eq(5u, gbits.posl(0b000101100000u));

        }

    }

}