//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tests.InX128
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using Z0.Testing;
    
    using static zcore;
    
    using P = Paths;



    [DisplayName(Path)]
    public class AddInt64 : AddTest<AddInt64,ulong>
    {
        public const string Path = AddInt64.BasePath + P.int64;
            
        public AddInt64()
        {

        }

        public override void Verify()
            => VerifyOp();
            
        public override void Apply()
        {
            var result = ApplyOp().ToReadOnlyList();
            trace(result.Count);
        }
            


    }
}