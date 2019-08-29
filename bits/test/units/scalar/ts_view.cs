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

    using static zfunc;
        
    public class ts_view : UnitTest<ts_view>
    {

        public void VerifyPrimalView()
        {
            var src = UInt64.MaxValue;  
            var len = sizeof(ulong);
            var view = BitView.ViewBits(ref src);
            for(var i=0; i<len; i++)
            for(byte j=0; j<8; j++)
                view[i,j] = j % 2 == 0;
            
            var bs = src.ToBitString();
            for(var i=0; i< len*8; i++)
                Claim.yea(bs[i] == (i%2 == 0));

        }

    }

}