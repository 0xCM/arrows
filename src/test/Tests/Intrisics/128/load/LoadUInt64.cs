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
    public class LoadUInt64 : LoadTest<LoadUInt64, ulong>
    {
        public const string Path = LoadUInt64.BasePath + P.uint32;
            
        public void LoadParams()
        {
            var src = new ulong[2]{1,2};
            var v0 = Vec128.define(src);
            var v1 = InX.load(1ul,2ul);
            Claim.eq(v0,v1);
        }

        public override void LoadSpans()
            => base.LoadSpans();
        
        public override void LoadArrays()
            => base.LoadArrays();

    }

}