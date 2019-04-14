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
    using static ztest;

    using operand = System.UInt64;
    using P = Paths;


    [DisplayName(Path)]
    public class UInt64Divisors : BinaryPrimOpsTest<UInt64Divisors,operand>
    {        
        public const string Path = P.primops + P.uint64 + "divisors/";
        

        public UInt64Divisors()
            : base(Defaults.UInt64Domaim, x => x != 0)
        {
            
        }

        const uint MaxDividend = 5000;


        // [Repeat(10)]
        // public override IReadOnlyList<operand> Baseline()
        // {
        //     var count = 0;
        //     for(var i = 0UL; i < MaxDividend; i++)
        //         count += Divisors.divisors(i).Count;
        //     return new operand[]{(uint)count};

        // }


        // [Repeat(10)]
        // public override IReadOnlyList<operand> Compute()
        // {
        //     var count = 0;
        //     for(var i = 0UL; i < MaxDividend; i++)
        //         count += algorithms.divisors(i).Count;
        //     return new operand[]{(uint)count};
        // }
            


    } 

}