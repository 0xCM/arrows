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
    public class StreamUInt64 : StreamTest<StreamUInt64,ulong>
    {
        public const string Path = P.InX128 + P.streams + P.uint64;
                    
        public StreamUInt64()
        {
        }

        public void Validate()
            => ValidateStream();

        public void Iterate()
            => IterateStream();
    }
}
