//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tests
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
    public class InX128AddUInt64 : InX128Test<InX128AddUInt64,ulong>
    {
        public const string Path = P.InX128 + P.add + P.uint64;
            
        public InX128AddUInt64()
            : base("+")
        {

        }

        public void Compute()
        {            
            var v1 = RandomVector(); 
            var v2 = RandomVector(); 

            var e1 = v1.Freeze().Add(v2.Freeze());
            var r1 = InX.add(v1,v2);
            
            Claim.eq(e1.ToVec128(),r1, OpInfo(v1, v2, r1));
            Claim.eq(e1,r1.Freeze());
        }

        public void ProcessVectors()
        {
            var prior = RandomVector();
            foreach(var v in RandomVectors())
                prior = InX.add(prior, v);
        }

        public void ProcessLists()
        {
            var prior = RandomList();
            foreach(var v in RandomLists())
                prior = prior.Add(v);

        }

    }
}