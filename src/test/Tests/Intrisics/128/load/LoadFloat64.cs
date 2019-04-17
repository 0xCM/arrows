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
    public class LoadFloat64 : LoadTest<LoadFloat64, double>
    {
        public const string Path = LoadUInt64.BasePath + P.float64;
            
        public void LoadParams()
        {
            var src = new double[2]{1.707,2.225};
            var v0 = Vec128.define(src);
            var v1 = InX.load(1.707,2.225);
            Claim.eq(v0,v1);
        }

        public override void LoadSpans()
            => base.LoadSpans();
        
        public override void LoadArrays()
            => base.LoadArrays();

    }

}