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
    public class EqFloat64 : EqTest<EqFloat64,double>
    {
        public const string Path = EqFloat64.BasePath + P.float64;

        public override void Verify()
            => VerifyOp();
            
        public override void Apply()
        {
            var result = ApplyOp().ToReadOnlyList();
            trace(result.Count);
        }

        // public void VerifyNotEqual()
        // {
        //     var vec1 = Vec128.define(-35.5d, 53.7d);
        //     var vec2 = Vec128.define(-35.5d, 52.7d);
        //     var vec3 = InX.eq(vec1,vec2);
        //     trace($"{vec3} := {vec1} == {vec2}");
        // }
            

    }
}