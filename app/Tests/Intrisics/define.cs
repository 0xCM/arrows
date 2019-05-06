//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tests.InX128
{
    using System;
    using System.Linq;
    using System.Threading;
    using System.Reflection;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using Z0.Testing;
    
    using static zcore;
    
    using P = Paths;


    [DisplayName(Path)]
    public class InX128Define : UnitTest<InX128Define>
    {
        public const string Path = P.InX128 + P.create;


        public InX128Define()
        {

        }

        IEnumerable<Vec128<uint>> Vec128UInt32Stream(uint[] cells)        
            => Vec128.stream(cells);
        
        public void StoreInt32Vec()
        {
            var src = new int[]{-50,-25,25,50};
            var dst = new int[src.Length];
            var v1 = Vec128.single(src);
            dinx.store(v1, dst, 0);
            var v2 = Vec128.single(dst);
            Claim.eq(v1,v2);
        }



        public void DefineFloat64Vec()
        {
            var src = new double[]{50,25};
            var v1 = Vec128.single(src);
            var v2 = Vec128.load(src,0);
            Claim.eq(v1,v2);
        }
    }

}