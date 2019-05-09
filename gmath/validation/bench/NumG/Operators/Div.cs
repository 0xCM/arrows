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

    partial class NumGBench
    {

        OpMeasure gdiv<T>(T[] dst)
            where T : struct, IEquatable<T>
        {
            var lhs = Number.many(LeftSrc.Sampled(head(dst)));
            var rhs = Number.many(NonZeroSrc.Sampled(head(dst)));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = lhs[it] + rhs[it];
            return(dst.Length, snapshot(sw));
        }

        OpMeasure ddiv(sbyte[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = NonZeroSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = (sbyte)(lhs[it] + rhs[it]);
            return(dst.Length, snapshot(sw));
        }

        OpMeasure ddiv(byte[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = NonZeroSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = (byte)(lhs[it] + rhs[it]);
            return(dst.Length, snapshot(sw));
        }

        OpMeasure ddiv(short[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = NonZeroSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = (short)(lhs[it] + rhs[it]);
            return(dst.Length, snapshot(sw));
        }

        OpMeasure ddiv(ushort[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = NonZeroSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = (ushort)(lhs[it] + rhs[it]);
            return(dst.Length, snapshot(sw));
        }

        OpMeasure ddiv(int[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = NonZeroSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = lhs[it] + rhs[it];
            return(dst.Length, snapshot(sw));
        }

        OpMeasure ddiv(uint[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = NonZeroSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = lhs[it] + rhs[it];
            return(dst.Length, snapshot(sw));
        }


        OpMeasure ddiv(long[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = NonZeroSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = lhs[it] + rhs[it];
            return(dst.Length, snapshot(sw));
        }


        OpMeasure ddiv(ulong[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = NonZeroSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = lhs[it] + rhs[it];
            return(dst.Length, snapshot(sw));
        }


        OpMeasure ddiv(float[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = NonZeroSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = lhs[it] + rhs[it];
            return(dst.Length, snapshot(sw));
        }


        OpMeasure ddiv(double[] dst)
        {
            var lhs = LeftSrc.Sampled(head(dst));
            var rhs = NonZeroSrc.Sampled(head(dst));
            var sw = stopwatch();
            var it = It.Define(0, dst.Length);
            while(++it)
                dst[it] = lhs[it] + rhs[it];
            return(dst.Length, snapshot(sw));
        }

        public IBenchComparison DivI8()
        {
            var opid = Id<sbyte>(OpKind.Div);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => ddiv(dst.Left)), 
                Measure(opid, () => gdiv(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison DivU8()
        {
            var opid = Id<byte>(OpKind.Div);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => ddiv(dst.Left)), 
                Measure(opid, () => gdiv(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison DivI16()
        {
            var opid = Id<short>(OpKind.Div);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => ddiv(dst.Left)), 
                Measure(opid, () => gdiv(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison DivU16()
        {
            var opid =  Id<ushort>(OpKind.Div);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => ddiv(dst.Left)), 
                Measure(opid, () => gdiv(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }


        public IBenchComparison DivI32()
        {
            var opid = Id<int>(OpKind.Div);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => ddiv(dst.Left)), 
                Measure(opid, () => gdiv(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }


        public IBenchComparison DivU32()
        {
            var opid =  Id<uint>(OpKind.Div);
            var dst = ArrayTargets<uint>();

            var comparison = Run(opid, 
                Measure(~opid, () => ddiv(dst.Left)), 
                Measure(opid, () => gdiv(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison DivI64()
        {
            var opid = Id<long>(OpKind.Div);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => ddiv(dst.Left)), 
                Measure(opid, () => gdiv(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison DivU64()
        {
            var opid = Id<ulong>(OpKind.Div);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => ddiv(dst.Left)), 
                Measure(opid, () => gdiv(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison DivF32()
        {
            var opid = Id<float>(OpKind.Div);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => ddiv(dst.Left)), 
                Measure(opid, () => gdiv(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

        public IBenchComparison DivF64()
        {
            var opid = Id<double>(OpKind.Div);
            var dst = Targets(opid);

            var comparison = Run(opid, 
                Measure(~opid, () => ddiv(dst.Left)), 
                Measure(opid, () => gdiv(dst.Right)));

            Claim.eq(dst.Left, dst.Right);        
            
            return Finish(comparison);
        }

    }
}