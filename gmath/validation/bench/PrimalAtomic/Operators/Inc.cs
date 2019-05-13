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

        public IBenchComparison IncI8()
        {
            var opid = Id<sbyte>(OpKind.Inc);
            var ioLeft = LeftTarget(opid);
            var ioRight = LeftTarget(opid);

            OpMetrics baseline1()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    math.inc(ref ioLeft[it]);
                return(SampleTime(snapshot(sw)));
            }

            OpMetrics baseline2()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    ++ioLeft[it];
                return(SampleTime(snapshot(sw)));
            }

            OpMetrics bench()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    gmath.inc(ref ioRight[it]);
                return(SampleTime(snapshot(sw)));
            }

            var baselined = Baseline switch 
            {
                2 => Measure(opid, baseline2),                
                _ => Measure(opid, baseline1)
            };

            var benched = Measure(!~opid, bench);

            var comparison = Run(opid, baselined, benched);            
            Claim.eq(ioLeft, ioRight);                        
            return Finish(comparison);
        }

        public IBenchComparison IncU8()
        {
            var opid = Id<sbyte>(OpKind.Inc);
            var ioLeft = LeftTarget(opid);
            var ioRight = LeftTarget(opid);

            OpMetrics baseline1()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    math.inc(ref ioLeft[it]);
                return(SampleTime(snapshot(sw)));
            }

            OpMetrics baseline2()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    ++ioLeft[it];
                return(SampleTime(snapshot(sw)));
            }

            OpMetrics bench()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    gmath.inc(ref ioRight[it]);
                return(SampleTime(snapshot(sw)));
            }

            var baselined = Baseline switch 
            {
                2 => Measure(opid, baseline2),                
                _ => Measure(opid, baseline1)
            };

            var benched = Measure(!~opid, bench);

            var comparison = Run(opid, baselined, benched);            
            Claim.eq(ioLeft, ioRight);                        
            return Finish(comparison);
        }

        public IBenchComparison IncI16()
        {
            var opid = Id<short>(OpKind.Inc);
            var ioLeft = LeftTarget(opid);
            var ioRight = LeftTarget(opid);

            OpMetrics baseline1()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    math.inc(ref ioLeft[it]);
                return(SampleTime(snapshot(sw)));
            }

            OpMetrics baseline2()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    ++ioLeft[it];
                return(SampleTime(snapshot(sw)));
            }

            OpMetrics bench()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    gmath.inc(ref ioRight[it]);
                return(SampleTime(snapshot(sw)));
            }

            var baselined = Baseline switch 
            {
                2 => Measure(opid, baseline2),                
                _ => Measure(opid, baseline1)
            };
            
            var benched = Measure(!~opid, bench);

            var comparison = Run(opid, baselined, benched);            
            Claim.eq(ioLeft, ioRight);                        
            return Finish(comparison);
        }


        public IBenchComparison IncU16()
        {
            var opid = Id<ushort>(OpKind.Inc);
            var ioLeft = LeftTarget(opid);
            var ioRight = LeftTarget(opid);

            OpMetrics baseline1()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    math.inc(ref ioLeft[it]);
                return(SampleTime(snapshot(sw)));
            }

            OpMetrics baseline2()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    ++ioLeft[it];
                return(SampleTime(snapshot(sw)));
            }

            OpMetrics bench()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    gmath.inc(ref ioRight[it]);
                return(SampleTime(snapshot(sw)));
            }

            var baselined = Baseline switch 
            {
                2 => Measure(opid, baseline2),                
                _ => Measure(opid, baseline1)
            };

            var benched = Measure(!~opid, bench);

            var comparison = Run(opid, baselined, benched);            
            Claim.eq(ioLeft, ioRight);                        
            return Finish(comparison);
        }


        public IBenchComparison IncI32()
        {
            var opid = Id<int>(OpKind.Inc);
            var ioLeft = LeftTarget(opid);
            var ioRight = LeftTarget(opid);

            OpMetrics baseline1()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    math.inc(ref ioLeft[it]);
                return(SampleTime(snapshot(sw)));
            }

            OpMetrics baseline2()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    ++ioLeft[it];
                return(SampleTime(snapshot(sw)));
            }

            OpMetrics bench()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    gmath.inc(ref ioRight[it]);
                return(SampleTime(snapshot(sw)));
            }

            var baselined = Baseline switch 
            {
                2 => Measure(opid, baseline2),                
                _ => Measure(opid, baseline1)
            };

            var benched = Measure(!~opid, bench);

            var comparison = Run(opid, baselined, benched);            
            Claim.eq(ioLeft, ioRight);                        
            return Finish(comparison);
        }

        public IBenchComparison IncU32()
        {
            var opid = Id<uint>(OpKind.Inc);
            var ioLeft = LeftTarget(opid);
            var ioRight = LeftTarget(opid);

            OpMetrics baseline1()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    math.inc(ref ioLeft[it]);
                return(SampleTime(snapshot(sw)));
            }

            OpMetrics baseline2()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    ++ioLeft[it];
                return(SampleTime(snapshot(sw)));
            }

            OpMetrics bench()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    gmath.inc(ref ioRight[it]);
                return(SampleTime(snapshot(sw)));
            }

            var baselined = Baseline switch 
            {
                2 => Measure(opid, baseline2),                
                _ => Measure(opid, baseline1)
            };

            var benched = Measure(!~opid, bench);

            var comparison = Run(opid, baselined, benched);            
            Claim.eq(ioLeft, ioRight);                        
            return Finish(comparison);
        }

        public IBenchComparison IncI64()
        {
            var opid = Id<long>(OpKind.Inc);
            var ioLeft = LeftTarget(opid);
            var ioRight = LeftTarget(opid);

            OpMetrics baseline1()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    math.inc(ref ioLeft[it]);
                return(SampleTime(snapshot(sw)));
            }


            OpMetrics bench()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    gmath.inc(ref ioRight[it]);
                return(SampleTime(snapshot(sw)));
            }

            OpMetrics baseline2()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    ++ioLeft[it];
                return(SampleTime(snapshot(sw)));
            }

            var baselined = Baseline switch 
            {
                2 => Measure(opid, baseline2),                
                _ => Measure(opid, baseline1)
            };

            var benched = Measure(!~opid, bench);

            var comparison = Run(opid, baselined, benched);            
            Claim.eq(ioLeft, ioRight);                        
            return Finish(comparison);
        }

        public IBenchComparison IncU64()
        {
            var opid = Id<ulong>(OpKind.Inc);
            var ioLeft = LeftTarget(opid);
            var ioRight = LeftTarget(opid);

            OpMetrics baseline1()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    math.inc(ref ioLeft[it]);
                return(SampleTime(snapshot(sw)));
            }

            OpMetrics baseline2()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    ++ioLeft[it];
                return(SampleTime(snapshot(sw)));
            }

            OpMetrics bench()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    gmath.inc(ref ioRight[it]);
                return(SampleTime(snapshot(sw)));
            }

            var baselined = Baseline switch 
            {
                2 => Measure(opid, baseline2),                
                _ => Measure(opid, baseline1)
            };

            var benched = Measure(!~opid, bench);

            var comparison = Run(opid, baselined, benched);            
            Claim.eq(ioLeft, ioRight);                        
            return Finish(comparison);
        }


    }


}