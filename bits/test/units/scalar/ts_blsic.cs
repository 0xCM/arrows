//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;

    using static zfunc;

    public class ts_blsic : ScalarBitTest<ts_blsic>
    {


        public void blsic_8()
        {
            var src = (byte)0b11101010;
            var dst = gbits.blsic((byte)src);
            Claim.eq(dst, (byte)0b11111101);

            
        }

    }

}
