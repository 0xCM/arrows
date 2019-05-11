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

    partial class PrimalDirectBench
    {
        public IBenchComparison AddI8()
        {
            var opid = Id<sbyte>(OpKind.Add);
            var src = Sampled(opid);
            var dst = Targets(opid);            
            
            OpMetrics baseline()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst.Left[it] = (sbyte)(src.Left[it] + src.Right[it]);
                return(SampleSize, snapshot(sw));
            }

            OpMetrics direct()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst.Right[it] = math.add(src.Left[it], src.Right[it]);
                return(SampleSize, snapshot(sw));
            }

            var comparison = Run(opid, 
                Measure(opid, baseline), 
                Measure(!opid, direct));
            
            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);

        }

        public IBenchComparison AddU8()
        {
            var opid = Id<byte>(OpKind.Add);
            var src = Sampled(opid);
            var dst = Targets(opid);            
            
            OpMetrics baseline()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst.Left[it] = (byte)(src.Left[it] + src.Right[it]);
                return(SampleSize, snapshot(sw));
            }

            OpMetrics direct()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst.Right[it] = math.add(src.Left[it], src.Right[it]);
                return(SampleSize, snapshot(sw));
            }

            var comparison = Run(opid, 
                Measure(opid, baseline), 
                Measure(!opid, direct));
            
            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        public IBenchComparison AddI16()
        {
            var opid = Id<short>(OpKind.Add);
            var src = Sampled(opid);
            var dst = Targets(opid);            
            
            OpMetrics baseline()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst.Left[it] = (short)(src.Left[it] + src.Right[it]);
                return(SampleSize, snapshot(sw));
            }

            OpMetrics direct()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst.Right[it] = math.add(src.Left[it], src.Right[it]);
                return(SampleSize, snapshot(sw));
            }

            var comparison = Run(opid, 
                Measure(opid, baseline), 
                Measure(!opid, direct));
            
            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        public IBenchComparison AddU16()
        {
            var opid = Id<ushort>(OpKind.Add);
            var src = Sampled(opid);
            var dst = Targets(opid);            
            
            OpMetrics baseline()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst.Left[it] = (ushort)(src.Left[it] + src.Right[it]);
                return(SampleSize, snapshot(sw));
            }

            OpMetrics direct()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst.Right[it] = math.add(src.Left[it], src.Right[it]);
                return(SampleSize, snapshot(sw));
            }

            var comparison = Run(opid, 
                Measure(opid, baseline), 
                Measure(!opid, direct));
            
            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        public IBenchComparison AddI32()
        {
            var opid = Id<int>(OpKind.Add);
            var src = Sampled(opid);
            var dst = Targets(opid);            
            
            OpMetrics baseline()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst.Left[it] = src.Left[it] + src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            OpMetrics direct()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst.Right[it] = math.add(src.Left[it], src.Right[it]);
                return(SampleSize, snapshot(sw));
            }

            var comparison = Run(opid, 
                Measure(opid, baseline), 
                Measure(!opid, direct));
            
            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        public IBenchComparison AddU32()
        {
            var opid = Id<uint>(OpKind.Add);
            var src = Sampled(opid);
            var dst = Targets(opid);            
            
            OpMetrics baseline()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst.Left[it] = src.Left[it] + src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            OpMetrics direct()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst.Right[it] = math.add(src.Left[it], src.Right[it]);
                return(SampleSize, snapshot(sw));
            }

            var comparison = Run(opid, 
                Measure(opid, baseline), 
                Measure(!opid, direct));
            
            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        public IBenchComparison AddI64()
        {
            var opid = Id<long>(OpKind.Add);
            var src = Sampled(opid);
            var dst = Targets(opid);            
            
            OpMetrics baseline()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst.Left[it] = src.Left[it] + src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            OpMetrics direct()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst.Right[it] = math.add(src.Left[it], src.Right[it]);
                return(SampleSize, snapshot(sw));
            }

            var comparison = Run(opid, 
                Measure(opid, baseline), 
                Measure(!opid, direct));
            
            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        public IBenchComparison AddU64()
        {
            var opid = Id<ulong>(OpKind.Add);            
            var src = Sampled(opid);
            var dst = Targets(opid);            
            
            OpMetrics baseline()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst.Left[it] = src.Left[it] + src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            OpMetrics direct()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst.Right[it] = math.add(src.Left[it], src.Right[it]);
                return(SampleSize, snapshot(sw));
            }

            var comparison = Run(opid, 
                Measure(opid, baseline), 
                Measure(!opid, direct));
            
            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        public IBenchComparison AddF32()
        {
            var opid = Id<float>(OpKind.Add);
            var src = Sampled(opid);
            var dst = Targets(opid);            
            
            OpMetrics baseline()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst.Left[it] = src.Left[it] + src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            OpMetrics direct()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst.Right[it] = math.add(src.Left[it], src.Right[it]);
                return(SampleSize, snapshot(sw));
            }

            var comparison = Run(opid, 
                Measure(opid, baseline), 
                Measure(!opid, direct));
            
            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }

        public IBenchComparison AddF64()
        {
            var opid = Id<double>(OpKind.Add);
 
            var src = Sampled(opid);
            var dst = Targets(opid);            
            
            OpMetrics baseline()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst.Left[it] = src.Left[it] + src.Right[it];
                return(SampleSize, snapshot(sw));
            }

            OpMetrics direct()
            {
                var sw = stopwatch();
                var it = -1;
                while(++it < SampleSize)
                    dst.Right[it] = math.add(src.Left[it], src.Right[it]);
                return(SampleSize, snapshot(sw));
            }

            var comparison = Run(opid, 
                Measure(opid, baseline), 
                Measure(!opid, direct));
            
            Claim.eq(dst.Left, dst.Right);            
            return Finish(comparison);
        }
 
    }
}