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

    partial class PrimalGenericBench
    {
        OpMetrics Gt<T>(bool[] dst)
            where T : struct, IEquatable<T>
        {
            var opid = Id<T>(OpKind.Gt);
            var samples = Sampled(opid);
            var it = -1;
            
            var sw = stopwatch();            
            while(++it < SampleSize)
                dst[it] = gmath.gt(samples.Left[it], samples.Right[it]);
            return(SampleTime(snapshot(sw)));
        }

        public IBenchComparison GtI8()
        {
            var opid = Id<sbyte>(OpKind.Add);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.GtI8, targets.Left);
            var benched = Measure(!~opid, Gt<sbyte>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison GtU8()
        {
            var opid = Id<byte>(OpKind.Gt);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.GtU8, targets.Left);
            var benched = Measure(!~opid, Gt<byte>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison GtI16()
        {
            var opid = Id<short>(OpKind.Gt);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.GtI16, targets.Left);
            var benched = Measure(!~opid, Gt<short>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison GtU16()
        {
            var opid = Id<ushort>(OpKind.Gt);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.GtU16, targets.Left);
            var benched = Measure(!~opid, Gt<ushort>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison GtI32()
        {
            var opid = Id<int>(OpKind.Gt);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.GtI32, targets.Left);
            var benched = Measure(!~opid, Gt<int>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison GtU32()
        {
            var opid = Id<uint>(OpKind.Gt);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.GtU32, targets.Left);
            var benched = Measure(!~opid, Gt<uint>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison GtI64()
        {
            var opid = Id<long>(OpKind.Gt);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.GtI64, targets.Left);
            var benched = Measure(!~opid, Gt<long>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison GtU64()
        {
            var opid = Id<ulong>(OpKind.Gt);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.GtU64, targets.Left);
            var benched = Measure(!~opid, Gt<ulong>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison GtF32()
        {
            var opid = Id<float>(OpKind.Gt);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.GtF32, targets.Left);
            var benched = Measure(!~opid, Gt<float>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison GtF64()
        {
            var opid = Id<double>(OpKind.Gt);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.GtF64, targets.Left);
            var benched = Measure(!~opid, Gt<double>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
      }

    }
}