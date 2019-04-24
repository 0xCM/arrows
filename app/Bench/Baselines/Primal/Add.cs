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
        static TimedIndexBinOp<T> PrimalAddOp<T>()
                where T : struct, IEquatable<T>
                    => PrimalAddBaseline.Operator<T>();

        static BenchResult RunPrimalAdd<T>(BenchConfig config = null)
            where T : struct, IEquatable<T>        
                => PrimalAddBaseline.Runner<T>(config).Run(PrimalAddOp<T>());

        static IEnumerable<BenchResult> RunPrimalAdd(BenchConfig config = null)
        {
            yield return RunPrimalAdd<sbyte>(config);
            yield return RunPrimalAdd<byte>(config);
            yield return RunPrimalAdd<short>(config);
            yield return RunPrimalAdd<ushort>(config);
            yield return RunPrimalAdd<int>(config);
            yield return RunPrimalAdd<uint>(config);
            yield return RunPrimalAdd<long>(config);
            yield return RunPrimalAdd<ulong>(config);
            yield return RunPrimalAdd<float>(config);
            yield return RunPrimalAdd<double>(config);
        }

        class PrimalAddBaseline 
        {

            public static IBenchMark<TimedIndexBinOp<T>> Runner<T>(BenchConfig config = null)
                where T : struct, IEquatable<T>
                    => new BinOpBenchmark<T>("primal/add", config);


            public static TimedIndexBinOp<T> Operator<T>()
                where T : struct, IEquatable<T>
                    => Operators.lookup<T, TimedIndexBinOp<T>>();

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


            static long Add(Index<sbyte> lhs, Index<sbyte> rhs, out Index<sbyte> dst)
            {            
                var sw = stopwatch();
                var target = alloc<sbyte>(lhs.Count);
                for(var i = 0; i< lhs.Count; i++)
                    target[i] = (sbyte)(lhs[i] + rhs[i]);
                dst = target;
                return elapsed(sw);
            }

            static long Add(Index<byte> lhs, Index<byte> rhs, out Index<byte> dst)
            {            
                var sw = stopwatch();
                var target = alloc<byte>(lhs.Count);
                for(var i = 0; i< lhs.Count; i++)
                    target[i] = (byte)(lhs[i] + rhs[i]);
                dst = target;
                return elapsed(sw);
            }

            static long Add(Index<short> lhs, Index<short> rhs, out Index<short> dst)
            {            
                var sw = stopwatch();
                var target = alloc<short>(lhs.Count);
                for(var i = 0; i< lhs.Count; i++)
                    target[i] = (short)(lhs[i] + rhs[i]);
                dst = target;
                return elapsed(sw);
            }

            static long Add(Index<ushort> lhs, Index<ushort> rhs, out Index<ushort> dst)
            {            
                var sw = stopwatch();
                var target = alloc<ushort>(lhs.Count);
                for(var i = 0; i< lhs.Count; i++)
                    target[i] = (ushort)(lhs[i] + rhs[i]);
                dst = target;
                return elapsed(sw);
            }

            static long Add(Index<int> lhs, Index<int> rhs, out Index<int> dst)
            {            
                var sw = stopwatch();
                var target = alloc<int>(lhs.Count);
                for(var i = 0; i< lhs.Count; i++)
                    target[i] = (lhs[i] + rhs[i]);
                dst = target;
                return elapsed(sw);
            }


            static long Add(Index<uint> lhs, Index<uint> rhs, out Index<uint> dst)
            {            
                var sw = stopwatch();
                var target = new uint[lhs.Count];
                for(var i = 0; i< lhs.Count; i++)
                    target[i] = lhs[i] + rhs[i];
                dst = target;
                return elapsed(sw);
            }

            static long Add(Index<long> lhs, Index<long> rhs, out Index<long> dst)
            {            
                var sw = stopwatch();
                var target = new long[lhs.Count];
                for(var i = 0; i< lhs.Count; i++)
                    target[i] = lhs[i] + rhs[i];
                dst = target;
                return elapsed(sw);
            }


            static long Add(Index<ulong> lhs, Index<ulong> rhs, out Index<ulong> dst)
            {            
                var sw = stopwatch();
                var target = new ulong[lhs.Count];
                for(var i = 0; i< lhs.Count; i++)
                    target[i] = lhs[i] + rhs[i];
                dst = target;
                return elapsed(sw);
            }

            static long Add(Index<float> lhs, Index<float> rhs, out Index<float> dst)
            {            
                var sw = stopwatch();
                var target = new float[lhs.Count];
                for(var i = 0; i< lhs.Count; i++)
                    target[i] = lhs[i] + rhs[i];
                dst = target;
                return elapsed(sw);
            }

            static long Add(Index<double> lhs, Index<double> rhs, out Index<double> dst)
            {            
                var sw = stopwatch();
                var target = new double[lhs.Count];
                for(var i = 0; i< lhs.Count; i++)
                    target[i] = lhs[i] + rhs[i];
                dst = target;
                return elapsed(sw);
            }

            

        }
    }
}