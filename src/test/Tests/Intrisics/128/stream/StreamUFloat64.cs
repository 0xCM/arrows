//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tests.InX128
{
    using System;
    using System.Linq;
    using System.ComponentModel;
    using System.Collections.Generic;

    using Z0.Testing;
    
    using static zcore;
    
    using P = Paths;


    [DisplayName(Path)]
    public class StreamUFloat64 : StreamTest<StreamUFloat64,double>
    {
        public const string Path = P.InX128 + P.streams + P.float64;
                    
        public StreamUFloat64()
        {
        }

        public override void ValidateStream()
            => base.ValidateStream();

        public override void TraverseStream()
            => base.TraverseStream();
    }
}
