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

        public IBenchComparison DecI8()
        {
            var opid = Id<sbyte>(OpKind.Dec);
            var samples = Sampled(opid);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.Dec, targets.Left);

            OpMetrics bench()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    targets.Right[it] = gmath.dec(samples.Left[it]);
                return(SampleTime(snapshot(sw)));
            }

            var benched = Measure(!~opid, bench);
            var comparison = Run(opid, baselined, benched);            
            
            Claim.eq(targets.Left, targets.Right);                        
            return Finish(comparison);
        }

        public IBenchComparison DecU8()
        {
            var opid = Id<byte>(OpKind.Dec);
            var samples = Sampled(opid);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.Dec, targets.Left);

            OpMetrics bench()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    targets.Right[it] = gmath.dec(samples.Left[it]);
                return(SampleTime(snapshot(sw)));
            }

            var benched = Measure(!~opid, bench);
            var comparison = Run(opid, baselined, benched);            
            
            Claim.eq(targets.Left, targets.Right);                        
            return Finish(comparison);
        }

        public IBenchComparison DecI16()
        {
            var opid = Id<short>(OpKind.Dec);
            var samples = Sampled(opid);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.Dec, targets.Left);

            OpMetrics bench()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    targets.Right[it] = gmath.dec(samples.Left[it]);
                return(SampleTime(snapshot(sw)));
            }

            var benched = Measure(!~opid, bench);
            var comparison = Run(opid, baselined, benched);            
            
            Claim.eq(targets.Left, targets.Right);                        
            return Finish(comparison);
        }

        public IBenchComparison DecU16()
        {
            var opid = Id<ushort>(OpKind.Dec);
            var samples = Sampled(opid);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.Dec, targets.Left);

            OpMetrics bench()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    targets.Right[it] = gmath.dec(samples.Left[it]);
                return(SampleTime(snapshot(sw)));
            }

            var benched = Measure(!~opid, bench);
            var comparison = Run(opid, baselined, benched);            
            
            Claim.eq(targets.Left, targets.Right);                        
            return Finish(comparison);
        }

        public IBenchComparison DecI32()
        {
            var opid = Id<int>(OpKind.Dec);
            var samples = Sampled(opid);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.Dec, targets.Left);

            OpMetrics bench()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    targets.Right[it] = gmath.dec(samples.Left[it]);
                return(SampleTime(snapshot(sw)));
            }

            var benched = Measure(!~opid, bench);
            var comparison = Run(opid, baselined, benched);            
            
            Claim.eq(targets.Left, targets.Right);                        
            return Finish(comparison);
        }

        public IBenchComparison DecU32()
        {
            var opid = Id<uint>(OpKind.Dec);
            var samples = Sampled(opid);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.Dec, targets.Left);

            OpMetrics bench()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    targets.Right[it] = gmath.dec(samples.Left[it]);
                return(SampleTime(snapshot(sw)));
            }

            var benched = Measure(!~opid, bench);
            var comparison = Run(opid, baselined, benched);            
            
            Claim.eq(targets.Left, targets.Right);                        
            return Finish(comparison);
        }

        public IBenchComparison DecI64()
        {
            var opid = Id<long>(OpKind.Dec);
            var samples = Sampled(opid);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.Dec, targets.Left);

            OpMetrics bench()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    targets.Right[it] = gmath.dec(samples.Left[it]);
                return(SampleTime(snapshot(sw)));
            }

            var benched = Measure(!~opid, bench);
            var comparison = Run(opid, baselined, benched);            
            
            Claim.eq(targets.Left, targets.Right);                        
            return Finish(comparison);
        }

        public IBenchComparison DecU64()
        {
            var opid = Id<ulong>(OpKind.Dec);
            var samples = Sampled(opid);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.Dec, targets.Left);

            OpMetrics bench()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    targets.Right[it] = gmath.dec(samples.Left[it]);
                return(SampleTime(snapshot(sw)));
            }

            var benched = Measure(!~opid, bench);
            var comparison = Run(opid, baselined, benched);            
            
            Claim.eq(targets.Left, targets.Right);                        
            return Finish(comparison);
        }

        public IBenchComparison DecF32()
        {
            var opid = Id<float>(OpKind.Dec);
            var samples = Sampled(opid);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.Dec, targets.Left);
            
            OpMetrics bench()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    targets.Right[it] = gmath.dec(samples.Left[it]);
                return(SampleTime(snapshot(sw)));
            }

            var benched = Measure(!~opid, bench);            
            var comparison = Run(opid, baselined, benched);            
            
            Claim.eq(targets.Left, targets.Right);                        
            return Finish(comparison);
        }

        public IBenchComparison DecF64()
        {
            var opid = Id<double>(OpKind.Dec);
            var samples = Sampled(opid);
            var targets = Targets(opid);
            var baselined = Measure(opid, Baselines.Dec, targets.Left);

            OpMetrics bench()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    targets.Right[it] = gmath.dec(samples.Left[it]);
                return(SampleTime(snapshot(sw)));
            }

            var benched = Measure(!~opid, bench);
            var comparison = Run(opid, baselined, benched);            
            
            Claim.eq(targets.Left, targets.Right);                        
            return Finish(comparison);
        }

   }
}