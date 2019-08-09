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
    
    public class EnumTest : UnitTest<EnumTest>
    {


        public void GenEnumValues()
        {
            var stream = Random.EnumStream<OpKind>();
            var set = new HashSet<OpKind>(stream.Take(Pow2.T12));
            var values = GEnum<OpKind,byte>.Values;
            values.Iterate(v => Claim.yea(set.Contains(v)));
        }


    }

}