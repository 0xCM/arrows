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
        public IBenchComparison SubI8()
        {
            var opid = Id<sbyte>(OpKind.Sub);
            
            OpMetrics baseline(Span128<sbyte> dst)
            {
                var sw = stopwatch();
                dinx.sub(LeftSample(opid), RightSample(opid), ref dst);
                return(dst.Length, snapshot(sw));
            }
            
            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => gsub(dst.Right)));            

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison SubU8()        
        {
            var opid = Id<byte>(OpKind.Sub);

            OpMetrics baseline(Span128<byte> dst)
            {
                var sw = stopwatch();
                dinx.sub(LeftSample(opid), RightSample(opid), ref dst);
                return(dst.Length, snapshot(sw));
            }
            
            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => gsub(dst.Right)));            

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison SubI16()
        {
            var opid = Id<short>(OpKind.Sub);
        
            OpMetrics baseline(Span128<short> dst)
            {
                var sw = stopwatch();
                dinx.sub(LeftSample(opid), RightSample(opid), ref dst);
                return(dst.Length, snapshot(sw));
            }
            
            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => gsub(dst.Right)));            

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison SubU16()        
        {
            var opid = Id<ushort>(OpKind.Sub);
            
            OpMetrics baseline(Span128<ushort> dst)
            {
                var sw = stopwatch();
                dinx.sub(LeftSample(opid), RightSample(opid), ref dst);
                return(dst.Length, snapshot(sw));
            }
            
            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => gsub(dst.Right)));            

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison SubI32()
        {
            var opid = Id<int>(OpKind.Sub);
            
            OpMetrics baseline(Span128<int> dst)
            {
                var sw = stopwatch();
                dinx.sub(LeftSample(opid), RightSample(opid), ref dst);
                return(dst.Length, snapshot(sw));
            }
            
            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => gsub(dst.Right)));            

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison SubU326()        
        {
            var opid = Id<uint>(OpKind.Sub);
            
            OpMetrics baseline(Span128<uint> dst)
            {
                var sw = stopwatch();
                dinx.sub(LeftSample(opid), RightSample(opid), ref dst);
                return(dst.Length, snapshot(sw));
            }
            
            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => gsub(dst.Right)));            

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison SubI64()
        {
            var opid = Id<long>(OpKind.Sub);

            OpMetrics baseline(Span128<long> dst)
            {
                var sw = stopwatch();
                dinx.sub(LeftSample(opid), RightSample(opid), ref dst);
                return(dst.Length, snapshot(sw));
            }
            
            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => gsub(dst.Right)));            

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison SubU64()        
        {
            var opid = Id<ulong>(OpKind.Sub);
            
            OpMetrics baseline(Span128<ulong> dst)
            {
                var sw = stopwatch();
                dinx.sub(LeftSample(opid), RightSample(opid), ref dst);
                return(dst.Length, snapshot(sw));
            }
            
            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => gsub(dst.Right)));            

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison SubF32()        
        {
            var opid = Id<float>(OpKind.Sub);
            
            OpMetrics baseline(Span128<float> dst)
            {
                var sw = stopwatch();
                dinx.sub(LeftSample(opid), RightSample(opid), ref dst);
                return(dst.Length, snapshot(sw));
            }
            
            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => gsub(dst.Right)));            

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
        }

        public IBenchComparison SubF64()        
        {
            var opid = Id<double>(OpKind.Sub);
 
            OpMetrics baseline(Span128<double> dst)
            {
                var sw = stopwatch();
                dinx.sub(LeftSample(opid), RightSample(opid), ref dst);
                return(dst.Length, snapshot(sw));
            }
            
            var dst = Targets(opid);
            var comparison = Run(opid, 
                Measure(opid, () => baseline(dst.Left)), 
                Measure(~opid, () => gsub(dst.Right)));            

            Claim.eq(dst.Left, dst.Right);                    
            return Finish(comparison);
       }

        OpMetrics gsub<T>(T[] dst)
            where T : struct, IEquatable<T>
        {
            var opid = Id<T>(OpKind.Sub);
            var lhs = LeftSample(opid);
            var rhs = RightSample(opid);
            
            var sw = stopwatch();
            ginx.sub(lhs, rhs, dst.ToSpan128());
            return(lhs.Length, snapshot(sw));
        }
   }

}