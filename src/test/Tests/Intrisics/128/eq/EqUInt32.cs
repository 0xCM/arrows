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
    public class EqUInt32 : EqTest<EqUInt32,uint>
    {
        public const string Path = EqUInt32.BasePath + P.uint32;
            
        public EqUInt32()
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