//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Runtime.CompilerServices;
    using static zfunc;

 
    public sealed class t_copy : UnitTest<t_copy>
    {


        public void Test1()
        {

            var src = new uint[]{2, 4, 6, 8};
            var dst = new byte[16];
            memcpy(src,dst);

            Claim.eq(dst[0], (byte)2);
            Claim.eq(dst[4], (byte)4);
            Claim.eq(dst[8], (byte)6);
            Claim.eq(dst[12], (byte)8);


        }


    }


}