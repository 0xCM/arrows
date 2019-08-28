//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;

    public class tv_permute : UnitTest<tv_permute>
    {

        public void perm256u8()
        {

            var x = Vec256Pattern.Increasing<byte>();
            var y = Vec256Pattern.Decreasing<byte>();
            var z = dinx.permute(x,y);
            for(var i=0; i<31; i++)
                Claim.eq(x[31 - i], z[i]);
        
        }


    }

}