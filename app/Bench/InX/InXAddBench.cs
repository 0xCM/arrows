//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Bench
{
    using System;
    using System.Linq;
    using System.Diagnostics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;

    using static zcore;

    partial class InXRunners
    {
        public static IBenchmarkRunner Add<T>(BenchConfig config = null)
                where T : struct, IEquatable<T>
                    => new InXAddBench<T>(config);

        class InXAddBench<T> : InXBinOpBenchmark<T>
            where T : struct, IEquatable<T>
        {
            public InXAddBench(BenchConfig config)
                : base("add",config)
            {


            }

            public override long Run()
                => Measure(InXG.Add<T>());

        }

    }
}