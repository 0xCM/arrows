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
        OpMetrics GtEq<T>(bool[] dst)
            where T : struct, IEquatable<T>
        {
            var opid = Id<T>(OpKind.GtEq);
            var samples = Sampled(opid);
            var it = -1;
            
            var sw = stopwatch();            
            while(++it < SampleSize)
                dst[it] = gmath.gteq(samples.Left[it], samples.Right[it]);
            return(SampleTime(snapshot(sw)));
        }

        public IBenchComparison GtEqI8()
        {
            var opid = Id<sbyte>(OpKind.Add);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.GtEqI8, targets.Left);
            var benched = Measure(!~opid, GtEq<sbyte>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison GtEqU8()
        {
            var opid = Id<byte>(OpKind.GtEq);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.GtEqU8, targets.Left);
            var benched = Measure(!~opid, GtEq<byte>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison GtEqI16()
        {
            var opid = Id<short>(OpKind.GtEq);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.GtEqI16, targets.Left);
            var benched = Measure(!~opid, GtEq<short>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison GtEqU16()
        {
            var opid = Id<ushort>(OpKind.GtEq);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.GtEqU16, targets.Left);
            var benched = Measure(!~opid, GtEq<ushort>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison GtEqI32()
        {
            var opid = Id<int>(OpKind.GtEq);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.GtEqI32, targets.Left);
            var benched = Measure(!~opid, GtEq<int>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison GtEqU32()
        {
            var opid = Id<uint>(OpKind.GtEq);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.GtEqU32, targets.Left);
            var benched = Measure(!~opid, GtEq<uint>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison GtEqI64()
        {
            var opid = Id<long>(OpKind.GtEq);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.GtEqI64, targets.Left);
            var benched = Measure(!~opid, GtEq<long>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison GtEqU64()
        {
            var opid = Id<ulong>(OpKind.GtEq);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.GtEqU64, targets.Left);
            var benched = Measure(!~opid, GtEq<ulong>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison GtEqF32()
        {
            var opid = Id<float>(OpKind.GtEq);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.GtEqF32, targets.Left);
            var benched = Measure(!~opid, GtEq<float>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
        }

        public IBenchComparison GtEqF64()
        {
            var opid = Id<double>(OpKind.GtEq);
            var targets = Targets<bool>();
            var baselined = Measure(opid, Baselines.GtEqF64, targets.Left);
            var benched = Measure(!~opid, GtEq<double>, targets.Right);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison, targets);
      }

    }
}