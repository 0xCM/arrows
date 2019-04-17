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
    public class LoadUInt32 : LoadTest<LoadUInt32, uint>
    {
        public const string Path = LoadUInt32.BasePath + P.uint32;
            
        public void LoadParams()
        {
            var src = new uint[4]{1,2,3,4};
            var v0 = Vec128.define(src);
            var v1 = InX.load(1u,2u,3u,4u);
            Claim.eq(v0,v1);
        }

        public override void LoadSpans()
            => base.LoadSpans();
        
        public override void LoadArrays()
            => base.LoadArrays();

    }

}