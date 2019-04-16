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
    public class AddUInt64 : AddTest<AddUInt64,ulong>
    {
        public const string Path = AddUInt64.BasePath + P.uint64;
            
        public AddUInt64()
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