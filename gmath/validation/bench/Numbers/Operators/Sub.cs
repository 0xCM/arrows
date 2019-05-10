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
       OpMetrics<T> sub<T>(OpId<T> opid)
            where T : struct, IEquatable<T>
        {
            var lhs = numbers(LeftSample(opid));
            var rhs = numbers(RightSample(opid));
            
            var sw = stopwatch();
            var result = lhs - rhs;   
            var time = snapshot(sw);                    

            return(opid, SampleSize, time, result.ToArray());
        }

        public IBenchComparison SubI8()
        {
            var opid = Id<sbyte>(OpKind.Sub);
            var lhsDst = Target(opid);

            OpMetrics<sbyte> baseline()
            {
                var lhs = LeftSample(opid);
                var rhs = RightSample(opid);

                var sw = stopwatch();
                math.sub(lhs, rhs, lhsDst);                                
                return(opid, SampleSize, snapshot(sw), lhsDst);
            }
            
            Claim.eq(baseline().Result, sub(~opid).Result);            
            
            var comparison = Run(opid, 
                Measure(opid, () => baseline()), 
                Measure(~opid, () => sub(~opid)));                        
            return Finish(comparison);
        }

        public IBenchComparison SubU8()
        {
            var opid = Id<byte>(OpKind.Sub);
            var lhsDst = Target(opid);

            OpMetrics<byte> baseline()
            {
                var lhs = LeftSample(opid);
                var rhs = RightSample(opid);

                var sw = stopwatch();
                math.sub(lhs, rhs, lhsDst);                                
                return(opid, SampleSize, snapshot(sw), lhsDst);
            }
                        
            Claim.eq(baseline().Result, sub(~opid).Result);            
            
            var comparison = Run(opid, 
                Measure(opid, () => baseline()), 
                Measure(~opid, () => sub(~opid)));                        
            return Finish(comparison);
        }

        public IBenchComparison SubI16()
        {
            var opid =  Id<short>(OpKind.Sub);
            var lhsDst = Target(opid);

            OpMetrics<short> baseline()
            {
                var lhs = LeftSample(opid);
                var rhs = RightSample(opid);

                var sw = stopwatch();
                math.sub(lhs, rhs, lhsDst);                                
                return(opid, SampleSize, snapshot(sw), lhsDst);
            }
                        
            Claim.eq(baseline().Result, sub(~opid).Result);            
            
            var comparison = Run(opid, 
                Measure(opid, () => baseline()), 
                Measure(~opid, () => sub(~opid)));                        
            return Finish(comparison);
        }

        public IBenchComparison SubU16()
        {
            var opid =  Id<ushort>(OpKind.Sub);
            var lhsDst = Target(opid);

            OpMetrics<ushort> baseline()
            {
                var lhs = LeftSample(opid);
                var rhs = RightSample(opid);

                var sw = stopwatch();
                math.sub(lhs, rhs, lhsDst);                                
                return(opid, SampleSize, snapshot(sw), lhsDst);
            }
                        
            Claim.eq(baseline().Result, sub(~opid).Result);            
            
            var comparison = Run(opid, 
                Measure(opid, () => baseline()), 
                Measure(~opid, () => sub(~opid)));                        
            return Finish(comparison);
        }


        public IBenchComparison SubI32()
        {
            var opid =  Id<int>(OpKind.Sub);
            var lhsDst = Target(opid);
            
            OpMetrics<int> baseline()
            {
                var lhs = LeftSample(opid);
                var rhs = RightSample(opid);

                var sw = stopwatch();
                math.sub(lhs, rhs, lhsDst);                                
                return(opid, SampleSize, snapshot(sw), lhsDst);
            }
                        
            Claim.eq(baseline().Result, sub(~opid).Result);            
            
            var comparison = Run(opid, 
                Measure(opid, () => baseline()), 
                Measure(~opid, () => sub(~opid)));                        
            return Finish(comparison);
        }

        public IBenchComparison SubU32()
        {
            var opid =  Id<uint>(OpKind.Sub);
            var lhsDst = Target(opid);
            
            OpMetrics<uint> baseline()
            {
                var lhs = LeftSample(opid);
                var rhs = RightSample(opid);

                var sw = stopwatch();
                math.sub(lhs, rhs, lhsDst);                                
                return(opid, SampleSize, snapshot(sw), lhsDst);
            }
                        
            Claim.eq(baseline().Result, sub(~opid).Result);            
            
            var comparison = Run(opid, 
                Measure(opid, () => baseline()), 
                Measure(~opid, () => sub(~opid)));                        
            return Finish(comparison);
        }

        public IBenchComparison SubI64()
        {
            var opid =  Id<long>(OpKind.Sub);
            var lhsDst = Target(opid);

            OpMetrics<long> baseline()
            {
                var lhs = LeftSample(opid);
                var rhs = RightSample(opid);

                var sw = stopwatch();
                math.sub(lhs, rhs, lhsDst);                                
                return(opid, SampleSize, snapshot(sw), lhsDst);
            }
                        
            Claim.eq(baseline().Result, sub(~opid).Result);            
            
            var comparison = Run(opid, 
                Measure(opid, () => baseline()), 
                Measure(~opid, () => sub(~opid)));                        
            return Finish(comparison);
        }

        public IBenchComparison SubU64()
        {
            var opid =  Id<ulong>(OpKind.Sub);
            var lhsDst = Target(opid);
            
            OpMetrics<ulong> baseline()
            {
                var lhs = LeftSample(opid);
                var rhs = RightSample(opid);

                var sw = stopwatch();
                math.sub(lhs, rhs, lhsDst);                                
                return(opid, SampleSize, snapshot(sw), lhsDst);
            }

            Claim.eq(baseline().Result, sub(~opid).Result);            
            
            var comparison = Run(opid, 
                Measure(opid, () => baseline()), 
                Measure(~opid, () => sub(~opid)));                        
            return Finish(comparison);
        }

        public IBenchComparison SubF32()
        {
            var opid =  Id<float>(OpKind.Sub);
            var lhsDst = Target(opid);

            OpMetrics<float> baseline()
            {
                var lhs = LeftSample(opid);
                var rhs = RightSample(opid);

                var sw = stopwatch();
                math.sub(lhs, rhs, lhsDst);                                
                return(opid, SampleSize, snapshot(sw), lhsDst);
            }

            Claim.eq(baseline().Result, sub(~opid).Result);            
            
            var comparison = Run(opid, 
                Measure(opid, () => baseline()), 
                Measure(~opid, () => sub(~opid)));                        
            return Finish(comparison);
        }

        public IBenchComparison SubF64()
        {
            var opid =  Id<double>(OpKind.Sub);
            var lhsDst = Target(opid);
            
            OpMetrics<double> baseline()
            {
                var lhs = LeftSample(opid);
                var rhs = RightSample(opid);

                var sw = stopwatch();
                math.sub(lhs, rhs, lhsDst);                                
                return(opid, SampleSize, snapshot(sw), lhsDst);
            }

            Claim.eq(baseline().Result, sub(~opid).Result);            
            
            var comparison = Run(opid, 
                Measure(opid, () => baseline()), 
                Measure(~opid, () => sub(~opid)));                        
            return Finish(comparison);
        } 
    }
}