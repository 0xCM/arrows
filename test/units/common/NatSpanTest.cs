//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Test
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.ComponentModel;

    using static Nats;
    using static nfunc;
    using static zfunc;

    public class NatSpanTest : UnitTest<NatSpanTest>
    {

        
        public void Transpose()
        {
            
            var m = Nats.N4;
            var n = Nats.N3;
            var src = Random.Span(m, n, closed(1,1000));
            Claim.eq(src.Dim.i, m.value);
            Claim.eq(src.Dim.j, n.value);            
            Trace($"A = {src.Format()}");

            var dst = src.Transpose();
            Trace($"A{Super.T} = {dst.Format()}");

            Claim.eq(dst.Dim.i, n.value);
            Claim.eq(dst.Dim.j, m.value);

            for(var i=0; i< m; i++)
            for(var j=0; j < n; j++)
                Claim.eq(src[i,j], dst[j,i]);            
        }        


    }
}
