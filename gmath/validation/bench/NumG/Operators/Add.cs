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

    partial class NumGBench
    {
       public OpMetrics Add<T>(T[] dst)
            where T : struct
        {
            var opid =  Id<T>(OpKind.Add);
            var src = Sampled(opid);
            var lhs = Num.many(src.Left);
            var rhs = Num.many(src.Right);
            var stage = alloc<num<T>>(dst.Length);            
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                stage[it] = lhs[it] + rhs[it];
            
            var time = snapshot(sw);
            stage.Extract().CopyTo(dst);
            return(SampleSize, time);
        }

       public OpMetrics<T> Add<T>()
            where T : struct
        {
            var opid =  ~!Id<T>(OpKind.Add);
            var src = Sampled(opid);
            var lhs = Num.many(src.Left);
            var rhs = Num.many(src.Right);
            var dst = alloc<num<T>>(SampleSize);
            var cycle = 0;

            var sw = stopwatch();
            while(++cycle <= Config.Cycles)
            {
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = lhs[it] + rhs[it];
            }            
            return OpMetrics.Define(opid, SampleSize, snapshot(sw), dst);
        }

        IBenchComparison AddI8()
        {
            var opid = Id<sbyte>(OpKind.Add);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.Add, targets.Left);
            var benched = Measure(!~opid, Add, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        IBenchComparison AddU8()
        {
            var opid =  Id<byte>(OpKind.Add);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.Add, targets.Left);
            var benched = Measure(!~opid, Add, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        IBenchComparison AddI16()
        {
            var opid =  Id<short>(OpKind.Add);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.Add, targets.Left);
            var benched = Measure(!~opid, Add, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        IBenchComparison AddU16()
        {
            var opid =  Id<ushort>(OpKind.Add);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.Add, targets.Left);
            var benched = Measure(!~opid, Add, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }


        IBenchComparison AddI32()
        {
            var opid =  Id<int>(OpKind.Add);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.Add, targets.Left);
            var benched = Measure(!~opid, Add, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        IBenchComparison AddU32()
        {
            var opid =  Id<uint>(OpKind.Add);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.Add, targets.Left);
            var benched = Measure(!~opid, Add, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        IBenchComparison AddI64()
        {
            var opid =  Id<long>(OpKind.Add);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.Add, targets.Left);
            var benched = Measure(!~opid, Add, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        IBenchComparison AddU64()
        {
            var opid =  Id<ulong>(OpKind.Add);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.Add, targets.Left);
            var benched = Measure(!~opid, Add, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        IBenchComparison AddF32()
        {
            var opid =  Id<float>(OpKind.Add);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.Add, targets.Left);
            var benched = Measure(!~opid, Add, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        IBenchComparison AddF64()
        {
            var opid =  Id<double>(OpKind.Add);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.Add, targets.Left);
            var benched = Measure(!~opid, Add, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        } 
    }
}