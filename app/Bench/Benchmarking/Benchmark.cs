//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Bench
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using System.IO;
    using System.Runtime.CompilerServices;

    using static zcore;

    public delegate BenchResult BenchSpec(BenchConfig config);

    public static class Benchmark
    {
        static Benchmarker<T> Runner<T>(string opname, BenchConfig config = null)
            where T : struct, IEquatable<T>
                => new Benchmarker<T>(opname, config);

        public static BenchSpec Measure<T>(this PrimalAggOp<T> op, string opname, AggOpInspector<T> inspector = null)
            where T : struct, IEquatable<T>
                => config => Runner<T>(opname,config).Run(op, inspector);
     
        public static BenchSpec Measure<T>(this PrimalFusedBinOp<T> op, string opname, FusedBinOpInspector<T> inspector = null)
            where T : struct, IEquatable<T>
                => config =>  Runner<T>(opname,config).Run(op, inspector);

        public static BenchSpec Measure<T>(this PrimalFusedUnaryOp<T> op, string opname, FusedUnaryOpInspector<T> inspector = null)
            where T : struct, IEquatable<T>
                => config =>  Runner<T>(opname,config).Run(op, inspector);

        public static BenchSpec Measure<T>(this PrimalFusedPred<T> op, string opname, FusedPredInspector<T> inspector = null)
            where T : struct, IEquatable<T>
                => config =>  Runner<T>(opname,config).Run(op, inspector);

        public static BenchSpec Measure<T>(this PrimalUnaryOp<T> op, string opname, FusedUnaryOpInspector<T> inspector = null)
            where T : struct, IEquatable<T>
                => config => Runner<T>(opname,config).Run(op, inspector);

        public static BenchSpec Measure<T>(this PrimalBinOp<T> op, string opname, FusedBinOpInspector<T> inspector = null)
            where T : struct, IEquatable<T>
                => config => Runner<T>(opname,config).Run(op, inspector);

        public static BenchSpec Measure<T>(Func<T,T,T> binop, string opname, FusedBinOpInspector<T> inspector = null)
            where T : struct, IEquatable<T>
                => config => Runner<T>(opname,config).Run(binop, inspector);

        public static BenchSpec Measure<T>(this Vec128BinOp<T> binop, string opname, FusedBinOpInspector<T> inspector = null)
            where T : struct, IEquatable<T>
                => config => Runner<T>(opname,config).Run(binop, inspector);
    }

}