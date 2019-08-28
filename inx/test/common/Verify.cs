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

    public static class Verification
    {
        public static void Equality<N,T>(Vector<N,T> vExpect, Vector<N,T> vResult)
            where T : struct
            where N : ITypeNat, new()
        {
            var len = (int)(new N().value);

            for(var i = 0; i< len; i++)
                Claim.eq(vExpect[i], vResult[i]);

            var eq = vExpect.Eq(vResult);
            for(var i=0; i<len; i++)
                Claim.yea(eq[i]);            
        }        

    }

}