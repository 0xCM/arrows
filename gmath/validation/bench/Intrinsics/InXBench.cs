//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static zfunc;
    using static mfunc;


    public static class InXBench
    {

        static IEnumerable<BenchComparisonRecord> Compare(OpKind op, PrimalKind primal, InXMetricConfig128 config)
        {
            foreach(var record in InX128Bench.CompareIntrinsics(op,primal,config))
                yield return record;
        }

        static IEnumerable<BenchComparisonRecord> Compare(OpKind op, PrimalKind primal, InXMetricConfig256 config)
        {

            foreach(var record in InX256Bench.CompareIntrinsics(op,primal,config))
                yield return record;
        }


        public static IEnumerable<BenchComparisonRecord> Compare(OpKind op, PrimalKind primal, InXMetricConfig config)
        {
            var headerEmitted = false;
            var comparison = config is InXMetricConfig128 x 
                ? InXBench.Compare(op, primal, x) 
                : InXBench.Compare(op, primal, config as InXMetricConfig256);
            
            foreach(var record in comparison)
            {
                if(!headerEmitted)
                {
                    print(record.DescribeHeader());
                    headerEmitted = true;
                }
                print(record.FormatMessage());                
                yield return record;
            }

        }

    }


}