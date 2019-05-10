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

    partial class NumbersBench
    {
       OpMetrics<T> add<T>(OpId<T> opid)
            where T : struct, IEquatable<T>
        {
            var lhs = numbers(LeftSample(opid));
            var rhs = numbers(RightSample(opid));
            
            var sw = stopwatch();
            var result = lhs + rhs;   
            var time = snapshot(sw);                    

            return(opid, SampleSize, time, result.ToArray());
        }

        public IBenchComparison AddI8()
        {
            var opid = Id<sbyte>(OpKind.Add);
            var lhsDst = Target(opid);

            OpMetrics<sbyte> baseline()
            {
                var lhs = LeftSample(opid);
                var rhs = RightSample(opid);

                var sw = stopwatch();
                math.add(lhs, rhs, lhsDst);                                
                return(opid, SampleSize, snapshot(sw), lhsDst);
            }
            
            Claim.eq(baseline().Result, add(~opid).Result);            
            
            var comparison = Run(opid, 
                Measure(opid, () => baseline()), 
                Measure(~opid, () => add(~opid)));                        
            return Finish(comparison);
        }

        public IBenchComparison AddU8()
        {
            var opid = Id<byte>(OpKind.Add);
            var lhsDst = Target(opid);

            OpMetrics<byte> baseline()
            {
                var lhs = LeftSample(opid);
                var rhs = RightSample(opid);

                var sw = stopwatch();
                math.add(lhs, rhs, lhsDst);                                
                return(opid, SampleSize, snapshot(sw), lhsDst);
            }
                        
            Claim.eq(baseline().Result, add(~opid).Result);            
            
            var comparison = Run(opid, 
                Measure(opid, () => baseline()), 
                Measure(~opid, () => add(~opid)));                        
            return Finish(comparison);
        }

        public IBenchComparison AddI16()
        {
            var opid =  Id<short>(OpKind.Add);
            var lhsDst = Target(opid);

            OpMetrics<short> baseline()
            {
                var lhs = LeftSample(opid);
                var rhs = RightSample(opid);

                var sw = stopwatch();
                math.add(lhs, rhs, lhsDst);                                
                return(opid, SampleSize, snapshot(sw), lhsDst);
            }
                        
            Claim.eq(baseline().Result, add(~opid).Result);            
            
            var comparison = Run(opid, 
                Measure(opid, () => baseline()), 
                Measure(~opid, () => add(~opid)));                        
            return Finish(comparison);
        }

        public IBenchComparison AddU16()
        {
            var opid =  Id<ushort>(OpKind.Add);
            var lhsDst = Target(opid);

            OpMetrics<ushort> baseline()
            {
                var lhs = LeftSample(opid);
                var rhs = RightSample(opid);

                var sw = stopwatch();
                math.add(lhs, rhs, lhsDst);                                
                return(opid, SampleSize, snapshot(sw), lhsDst);
            }
                        
            Claim.eq(baseline().Result, add(~opid).Result);            
            
            var comparison = Run(opid, 
                Measure(opid, () => baseline()), 
                Measure(~opid, () => add(~opid)));                        
            return Finish(comparison);
        }


        public IBenchComparison AddI32()
        {
            var opid =  Id<int>(OpKind.Add);
            var lhsDst = Target(opid);
            
            OpMetrics<int> baseline()
            {
                var lhs = LeftSample(opid);
                var rhs = RightSample(opid);

                var sw = stopwatch();
                math.add(lhs, rhs, lhsDst);                                
                return(opid, SampleSize, snapshot(sw), lhsDst);
            }
                        
            Claim.eq(baseline().Result, add(~opid).Result);            
            
            var comparison = Run(opid, 
                Measure(opid, () => baseline()), 
                Measure(~opid, () => add(~opid)));                        
            return Finish(comparison);
        }

        public IBenchComparison AddU32()
        {
            var opid =  Id<uint>(OpKind.Add);
            var lhsDst = Target(opid);
            
            OpMetrics<uint> baseline()
            {
                var lhs = LeftSample(opid);
                var rhs = RightSample(opid);

                var sw = stopwatch();
                math.add(lhs, rhs, lhsDst);                                
                return(opid, SampleSize, snapshot(sw), lhsDst);
            }
                        
            Claim.eq(baseline().Result, add(~opid).Result);            
            
            var comparison = Run(opid, 
                Measure(opid, () => baseline()), 
                Measure(~opid, () => add(~opid)));                        
            return Finish(comparison);
        }

        public IBenchComparison AddI64()
        {
            var opid =  Id<long>(OpKind.Add);
            var lhsDst = Target(opid);

            OpMetrics<long> baseline()
            {
                var lhs = LeftSample(opid);
                var rhs = RightSample(opid);

                var sw = stopwatch();
                math.add(lhs, rhs, lhsDst);                                
                return(opid, SampleSize, snapshot(sw), lhsDst);
            }
                        
            Claim.eq(baseline().Result, add(~opid).Result);            
            
            var comparison = Run(opid, 
                Measure(opid, () => baseline()), 
                Measure(~opid, () => add(~opid)));                        
            return Finish(comparison);
        }

        public IBenchComparison AddU64()
        {
            var opid =  Id<ulong>(OpKind.Add);
            var lhsDst = Target(opid);
            
            OpMetrics<ulong> baseline()
            {
                var lhs = LeftSample(opid);
                var rhs = RightSample(opid);

                var sw = stopwatch();
                math.add(lhs, rhs, lhsDst);                                
                return(opid, SampleSize, snapshot(sw), lhsDst);
            }

            Claim.eq(baseline().Result, add(~opid).Result);            
            
            var comparison = Run(opid, 
                Measure(opid, () => baseline()), 
                Measure(~opid, () => add(~opid)));                        
            return Finish(comparison);
        }

        public IBenchComparison AddF32()
        {
            var opid =  Id<float>(OpKind.Add);
            var lhsDst = Target(opid);

            OpMetrics<float> baseline()
            {
                var lhs = LeftSample(opid);
                var rhs = RightSample(opid);

                var sw = stopwatch();
                math.add(lhs, rhs, lhsDst);                                
                return(opid, SampleSize, snapshot(sw), lhsDst);
            }

            Claim.eq(baseline().Result, add(~opid).Result);            
            
            var comparison = Run(opid, 
                Measure(opid, () => baseline()), 
                Measure(~opid, () => add(~opid)));                        
            return Finish(comparison);
        }

        public IBenchComparison AddF64()
        {
            var opid =  Id<double>(OpKind.Add);
            var lhsDst = Target(opid);
            
            OpMetrics<double> baseline()
            {
                var lhs = LeftSample(opid);
                var rhs = RightSample(opid);

                var sw = stopwatch();
                math.add(lhs, rhs, lhsDst);                                
                return(opid, SampleSize, snapshot(sw), lhsDst);
            }

            Claim.eq(baseline().Result, add(~opid).Result);            
            
            var comparison = Run(opid, 
                Measure(opid, () => baseline()), 
                Measure(~opid, () => add(~opid)));                        
            return Finish(comparison);
        } 
    }
}