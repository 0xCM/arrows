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
        public IBenchComparison AndI8()
        {
            var opid = Id<sbyte>(OpKind.And);
            
            OpMeasure baseline(Span128<sbyte> dst)
            {
                var sw = stopwatch();
                dinx.and(LeftSample(opid), RightSample(opid), ref dst);
                return(dst.Length, snapshot(sw));
            }
            
            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => gand(dst.Right)));            

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AndU8()        
        {
            var opid = Id<byte>(OpKind.And);

            OpMeasure baseline(Span128<byte> dst)
            {
                var sw = stopwatch();
                dinx.and(LeftSample(opid), RightSample(opid), ref dst);
                return(dst.Length, snapshot(sw));
            }
            
            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => gand(dst.Right)));            

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AndI16()
        {
            var opid = Id<short>(OpKind.And);
        
            OpMeasure baseline(Span128<short> dst)
            {
                var sw = stopwatch();
                dinx.and(LeftSample(opid), RightSample(opid), ref dst);
                return(dst.Length, snapshot(sw));
            }
            
            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => gand(dst.Right)));            

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AndU16()        
        {
            var opid = Id<ushort>(OpKind.And);
            
            OpMeasure baseline(Span128<ushort> dst)
            {
                var sw = stopwatch();
                dinx.and(LeftSample(opid), RightSample(opid), ref dst);
                return(dst.Length, snapshot(sw));
            }
            
            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => gand(dst.Right)));            

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AndI32()
        {
            var opid = Id<int>(OpKind.And);
            
            OpMeasure baseline(Span128<int> dst)
            {
                var sw = stopwatch();
                dinx.and(LeftSample(opid), RightSample(opid), ref dst);
                return(dst.Length, snapshot(sw));
            }
            
            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => gand(dst.Right)));            

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AndU326()        
        {
            var opid = Id<uint>(OpKind.And);
            
            OpMeasure baseline(Span128<uint> dst)
            {
                var sw = stopwatch();
                dinx.and(LeftSample(opid), RightSample(opid), ref dst);
                return(dst.Length, snapshot(sw));
            }
            
            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => gand(dst.Right)));            

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AndI64()
        {
            var opid = Id<long>(OpKind.And);

            OpMeasure baseline(Span128<long> dst)
            {
                var sw = stopwatch();
                dinx.and(LeftSample(opid), RightSample(opid), ref dst);
                return(dst.Length, snapshot(sw));
            }
            
            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => gand(dst.Right)));            

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AndU64()        
        {
            var opid = Id<ulong>(OpKind.And);
            
            OpMeasure baseline(Span128<ulong> dst)
            {
                var sw = stopwatch();
                dinx.and(LeftSample(opid), RightSample(opid), ref dst);
                return(dst.Length, snapshot(sw));
            }
            
            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => gand(dst.Right)));            

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AndF32()        
        {
            var opid = Id<float>(OpKind.And);
            
            OpMeasure baseline(Span128<float> dst)
            {
                var sw = stopwatch();
                dinx.and(LeftSample(opid), RightSample(opid), ref dst);
                return(dst.Length, snapshot(sw));
            }
            
            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => gand(dst.Right)));            

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison AndF64()        
        {
            var opid = Id<double>(OpKind.And);
 
            OpMeasure baseline(Span128<double> dst)
            {
                var sw = stopwatch();
                dinx.and(LeftSample(opid), RightSample(opid), ref dst);
                return(dst.Length, snapshot(sw));
            }
            
            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => gand(dst.Right)));            

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
       }

        OpMeasure gand<T>(T[] dst)
            where T : struct, IEquatable<T>
        {
            var opid = Id<T>(OpKind.And);
            var lhs = LeftSample(opid);
            var rhs = RightSample(opid);
            
            var sw = stopwatch();
            ginx.and(lhs, rhs, dst.ToSpan128());
            return(lhs.Length, snapshot(sw));
        }
   }
}