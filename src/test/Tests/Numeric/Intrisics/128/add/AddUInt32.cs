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
    public class InX128AddUInt32 : InX128Test<InX128AddUInt32,uint>
    {
        public const string Path = P.InX128 + P.add + P.uint32;
            
        public InX128AddUInt32()
            : base("+")
        {

        }

        public void Validate()
        {            
            var v1 = RandomVector(); 
            var v2 = RandomVector(); 

            var e1 = v1.Freeze().Add(v2.Freeze());
            var r1 = InX.add(v1,v2);
            
            Claim.eq(e1.ToVec128(),r1, OpInfo(v1, v2, r1));
            Claim.eq(e1,r1.Freeze());
        }

        public void ValidateStream()
        {
            var lPrior = RandomList();
            var vPrior = lPrior.ToVec128();
            foreach(var lCurrent in  RandomLists())
            {
                var vCurrent = lCurrent.ToVec128();

                var lResult = lPrior.Add(lCurrent);
                var vResult = vPrior.Add(vCurrent);

                Claim.eq(lResult.ToVec128(),vResult);
            }
            
        }

        public void ProcessVectors()
        {
            var op = InX128G.Add<uint>();
            var prior = RandomVector();
            foreach(var v in RandomVectors())
                prior = op.add(prior, v);
        }

        public void ProcessLists()
        {
            var prior = RandomList();
            foreach(var v in RandomLists())
                prior = prior.Add(v);

        }

    }
}