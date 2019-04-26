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
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zcore;
    
    partial class BaselineBench
    {
        static TimedIndexBinOp<T> InXAddOp<T>()
                where T : struct, IEquatable<T>
                    => InXAdd.Operator<T>();    

        static TimedIndexBinOp<T> InXAddOpG<T>()
                where T : struct, IEquatable<T>
                    => InXAdd.OperatorG<T>();    

        static BenchResult RunInXAdd<T>(BenchConfig config = null)
            where T : struct, IEquatable<T>        
                => BinOpBenchmark.Runner<T>("intrinsics/add", config).Run(InXAddOp<T>());

        static BenchResult RunInXAddG<T>(BenchConfig config = null)
            where T : struct, IEquatable<T>        
                => BinOpBenchmark.Runner<T>("intrinsics-g/add",config).Run(InXAddOpG<T>());

        static IEnumerable<BenchResult> RunInXAdd(BenchConfig config = null)
        {
            yield return RunInXAdd<sbyte>(config);
            yield return RunInXAdd<byte>(config);
            yield return RunInXAdd<short>(config);
            yield return RunInXAdd<ushort>(config);
            yield return RunInXAdd<int>(config);
            yield return RunInXAdd<uint>(config);
            yield return RunInXAdd<long>(config);
            yield return RunInXAdd<ulong>(config);
            yield return RunInXAdd<float>(config);
            yield return RunInXAdd<double>(config);
        }

        static IEnumerable<BenchResult> RunInXAddG(BenchConfig config = null)
        {
            yield return RunInXAddG<sbyte>(config);
            yield return RunInXAddG<byte>(config);
            yield return RunInXAddG<short>(config);
            yield return RunInXAddG<ushort>(config);
            yield return RunInXAddG<int>(config);
            yield return RunInXAddG<uint>(config);
            yield return RunInXAddG<long>(config);
            yield return RunInXAddG<ulong>(config);
            yield return RunInXAddG<float>(config);
            yield return RunInXAddG<double>(config);
        }

        class InXAdd 
        {        
            public static readonly PrimalIndex Operators 
                = PrimKinds.index
                    (@sbyte: new TimedIndexBinOp<sbyte>(Add),
                    @byte: new TimedIndexBinOp<byte>(Add),
                    @short: new TimedIndexBinOp<short>(Add),
                    @ushort: new TimedIndexBinOp<ushort>(Add),
                    @int: new TimedIndexBinOp<int>(Add),
                    @uint: new TimedIndexBinOp<uint>(Add),
                    @long: new TimedIndexBinOp<long>(Add),
                    @ulong: new TimedIndexBinOp<ulong>(Add),
                    @float: new TimedIndexBinOp<float>(Add),
                    @double:new TimedIndexBinOp<double>(Add)
                    );

            public static TimedIndexBinOp<T> Operator<T>()
                where T : struct, IEquatable<T>
                    => Operators.lookup<T, TimedIndexBinOp<T>>();
            public static TimedIndexBinOp<T> OperatorG<T>()
                where T : struct, IEquatable<T>
                    => AddG;
            static long AddG<T>(Index<T> lhs, Index<T> rhs, out Index<T> dst)
                where T : struct, IEquatable<T>
            {
                var sw = stopwatch();
                dst = lhs.AddG(rhs);
                return elapsed(sw);
            }
                    //=> Operator<T>()(lhs,rhs, out dst);

            static long Add(Index<sbyte> lhs, Index<sbyte> rhs, out Index<sbyte> dst)
            {
                var sw = stopwatch();
                dst = lhs.InXAdd(rhs);
                return elapsed(sw);
            }

            static long Add(Index<byte> lhs, Index<byte> rhs, out Index<byte> dst)
            {
                var sw = stopwatch();
                dst = lhs.InXAdd(rhs);
                return elapsed(sw);
            }

            static long Add(Index<short> lhs, Index<short> rhs, out Index<short> dst)
            {
                var sw = stopwatch();
                dst = lhs.InXAdd(rhs);
                return elapsed(sw);
            }

            static long Add(Index<ushort> lhs, Index<ushort> rhs, out Index<ushort> dst)
            {
                var sw = stopwatch();
                dst = lhs.InXAdd(rhs);
                return elapsed(sw);
            }

            static long Add(Index<int> lhs, Index<int> rhs, out Index<int> dst)
            {
                var sw = stopwatch();
                dst = lhs.InXAdd(rhs);
                return elapsed(sw);
            }

            static long Add(Index<uint> lhs, Index<uint> rhs, out Index<uint> dst)
            {
                var sw = stopwatch();
                dst = lhs.InXAdd(rhs);
                return elapsed(sw);
            }

            static long Add(Index<long> lhs, Index<long> rhs, out Index<long> dst)
            {
                var sw = stopwatch();
                dst = lhs.InXAdd(rhs);
                return elapsed(sw);
            }

            static long Add(Index<ulong> lhs, Index<ulong> rhs, out Index<ulong> dst)
            {
                var sw = stopwatch();
                dst = lhs.InXAdd(rhs);
                return elapsed(sw);
            }
            static long Add(Index<float> lhs, Index<float> rhs, out Index<float> dst)
            {
                var sw = stopwatch();
                dst = lhs.InXAdd(rhs);
                return elapsed(sw);
            }

            static long Add(Index<double> lhs, Index<double> rhs, out Index<double> dst)
            {
                var sw = stopwatch();
                dst = lhs.InXAdd(rhs);
                return elapsed(sw);
            }        
        }
    }
}