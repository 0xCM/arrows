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
    public class InX128AndUInt32 : InXTest<InX128AndUInt32,uint>
    {
        public const string Path = P.InX128 + P.and;

        public InX128AndUInt32()
            : base("&")
        {

        }

        public void Compute()
        {
            var v1 = Vec128.define(0b111111u, 0b011111, 0b001111, 0b000111);
            var v2 = Vec128.define(0b111000u, 0b011000, 0b001000, 00000000);
            var e1 = Vec128.define(0b111000u, 0b011000, 0b001000, 00000000);
            var r1 = InX.and(v1,v2);
                        
            Claim.eq(e1, r1, OpInfo(v1, v2, r1));

            var v3 = Vec128.define(new uint[]{0b111111, 0b011111, 0b001111, 0b000111});
            var v4 = Vec128.define(new uint[]{0b111000, 0b011000, 0b001000, 00000000});
            var e2 = Vec128.define(new uint[]{0b111000, 0b011000, 0b001000, 00000000});
            var r2 = InX.and(v3,v4);            
                        
            Claim.eq(e2, r2, OpInfo(v3,v4, r2));
                    
            Claim.eq(r1,r2);
        }


        public void ProcessVectors()
        {
            var prior = RandVec128();
            foreach(var v in RandVecs128())
                prior = InX.and(prior, v);
        }

        public void ProcessLists()
        {
            var prior = RandList128();
            foreach(var v in RandLists128())
                prior = prior.And(v);

        }

    }

}