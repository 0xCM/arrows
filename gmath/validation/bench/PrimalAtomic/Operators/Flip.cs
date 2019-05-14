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

    partial class PrimalAtomicBench
    {

        public IBenchComparison FlipI8()
        {
            var opid = Id<sbyte>(OpKind.Flip);
            var samples = Sampled(opid);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.Flip, targets.Left);

            OpMetrics bench()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    targets.Right[it] = gmath.flip(samples.Left[it]);
                return(SampleTime(snapshot(sw)));
            }

            var benched = Measure(!~opid, bench);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison,targets);
        }

        public IBenchComparison FlipU8()
        {
            var opid = Id<byte>(OpKind.Flip);
            var samples = Sampled(opid);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.Flip, targets.Left);

            OpMetrics bench()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    targets.Right[it] = gmath.flip(samples.Left[it]);
                return(SampleTime(snapshot(sw)));
            }

            var benched = Measure(!~opid, bench);
            var comparison = Run(opid, baselined, benched);                        
            return Finish(comparison,targets);
        }

        public IBenchComparison FlipI16()
        {
            var opid = Id<short>(OpKind.Flip);
            var samples = Sampled(opid);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.Flip, targets.Left);

            OpMetrics bench()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    targets.Right[it] = gmath.flip(samples.Left[it]);
                return(SampleTime(snapshot(sw)));
            }

            var benched = Measure(!~opid, bench);
            var comparison = Run(opid, baselined, benched);
            return Finish(comparison,targets);
        }

        public IBenchComparison FlipU16()
        {
            var opid = Id<ushort>(OpKind.Flip);
            var samples = Sampled(opid);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.Flip, targets.Left);

            OpMetrics bench()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    targets.Right[it] = gmath.flip(samples.Left[it]);
                return(SampleTime(snapshot(sw)));
            }

            var benched = Measure(!~opid, bench);
            var comparison = Run(opid, baselined, benched);                        
            return Finish(comparison,targets);
        }

        public IBenchComparison FlipI32()
        {
            var opid = Id<int>(OpKind.Flip);
            var samples = Sampled(opid);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.Flip, targets.Left);

            OpMetrics bench()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    targets.Right[it] = gmath.flip(samples.Left[it]);
                return(SampleTime(snapshot(sw)));
            }

            var benched = Measure(!~opid, bench);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison,targets);
        }

        public IBenchComparison FlipU32()
        {
            var opid = Id<uint>(OpKind.Flip);
            var samples = Sampled(opid);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.Flip, targets.Left);

            OpMetrics bench()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    targets.Right[it] = gmath.flip(samples.Left[it]);
                return(SampleTime(snapshot(sw)));
            }

            var benched = Measure(!~opid, bench);
            var comparison = Run(opid, baselined, benched);
            return Finish(comparison,targets);
        }

        public IBenchComparison FlipI64()
        {
            var opid = Id<long>(OpKind.Flip);
            var samples = Sampled(opid);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.Flip, targets.Left);

            OpMetrics bench()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    targets.Right[it] = gmath.flip(samples.Left[it]);
                return(SampleTime(snapshot(sw)));
            }

            var benched = Measure(!~opid, bench);
            var comparison = Run(opid, baselined, benched);            
            return Finish(comparison,targets);
        }

        public IBenchComparison FlipU64()
        {
            var opid = Id<ulong>(OpKind.Flip);
            var samples = Sampled(opid);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.Flip, targets.Left);

            OpMetrics bench()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    targets.Right[it] = gmath.flip(samples.Left[it]);
                return(SampleTime(snapshot(sw)));
            }

            var benched = Measure(!~opid, bench);
            var comparison = Run(opid, baselined, benched);                        
            return Finish(comparison,targets);
        }

   }
}