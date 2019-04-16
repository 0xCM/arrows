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
    public class EqInt32 : EqTest<EqInt32,int>
    {
        public const string Path = EqInt32.BasePath + P.int64;
            
        public EqInt32()
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