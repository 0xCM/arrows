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

    partial class Vec128Bench
    {   

        public IBenchComparison AddI8()
        {
            var opid = Id<sbyte>(OpKind.Add);
            
            OpMetrics baseline(Span128<sbyte> dst)
            {
                var sw = stopwatch();
                dinx.add(LeftSample(opid), RightSample(opid), ref dst);
                return(dst.Length, snapshot(sw));
            }
            
            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => gadd(dst.Right)));            

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AddU8()        
        {
            var opid = Id<byte>(OpKind.Add);

            OpMetrics baseline(Span128<byte> dst)
            {
                var sw = stopwatch();
                dinx.add(LeftSample(opid), RightSample(opid), ref dst);
                return(dst.Length, snapshot(sw));
            }
            
            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => gadd(dst.Right)));            

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AddI16()
        {
            var opid = Id<short>(OpKind.Add);
        
            OpMetrics baseline(Span128<short> dst)
            {
                var sw = stopwatch();
                dinx.add(LeftSample(opid), RightSample(opid), ref dst);
                return(dst.Length, snapshot(sw));
            }
            
            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => gadd(dst.Right)));            

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AddU16()        
        {
            var opid = Id<ushort>(OpKind.Add);
            
            OpMetrics baseline(Span128<ushort> dst)
            {
                var sw = stopwatch();
                dinx.add(LeftSample(opid), RightSample(opid), ref dst);
                return(dst.Length, snapshot(sw));
            }
            
            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => gadd(dst.Right)));            

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AddI32()
        {
            var opid = Id<int>(OpKind.Add);
            
            OpMetrics baseline(Span128<int> dst)
            {
                var sw = stopwatch();
                dinx.add(LeftSample(opid), RightSample(opid), ref dst);
                return(dst.Length, snapshot(sw));
            }
            
            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => gadd(dst.Right)));            

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AddU326()        
        {
            var opid = Id<uint>(OpKind.Add);
            
            OpMetrics baseline(Span128<uint> dst)
            {
                var sw = stopwatch();
                dinx.add(LeftSample(opid), RightSample(opid), ref dst);
                return(dst.Length, snapshot(sw));
            }
            
            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => gadd(dst.Right)));            

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AddI64()
        {
            var opid = Id<long>(OpKind.Add);

            OpMetrics baseline(Span128<long> dst)
            {
                var sw = stopwatch();
                dinx.add(LeftSample(opid), RightSample(opid), ref dst);
                return(dst.Length, snapshot(sw));
            }
            
            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => gadd(dst.Right)));            

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AddU64()        
        {
            var opid = Id<ulong>(OpKind.Add);
            
            OpMetrics baseline(Span128<ulong> dst)
            {
                var sw = stopwatch();
                dinx.add(LeftSample(opid), RightSample(opid), ref dst);
                return(dst.Length, snapshot(sw));
            }
            
            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => gadd(dst.Right)));            

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AddF32()        
        {
            var opid = Id<float>(OpKind.Add);
            
            OpMetrics baseline(Span128<float> dst)
            {
                var sw = stopwatch();
                dinx.add(LeftSample(opid), RightSample(opid), ref dst);
                return(dst.Length, snapshot(sw));
            }
            
            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => gadd(dst.Right)));            

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AddF64()        
        {
            var opid = Id<double>(OpKind.Add);
 
            OpMetrics baseline(Span128<double> dst)
            {
                var sw = stopwatch();
                dinx.add(LeftSample(opid), RightSample(opid), ref dst);
                return(dst.Length, snapshot(sw));
            }
            
            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => gadd(dst.Right)));            

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
       }


        OpMetrics gadd<T>(T[] dst)
            where T : struct
        {
            var opid = Id<T>(OpKind.Add);
            var lhs = LeftSample(opid);
            var rhs = RightSample(opid);
            
            var sw = stopwatch();
            ginx.add(lhs, rhs, dst.ToSpan128());
            return(lhs.Length, snapshot(sw));
        }
 
    }

}