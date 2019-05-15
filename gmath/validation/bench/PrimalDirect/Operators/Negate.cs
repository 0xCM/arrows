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

    partial class BaselineMetrics
    {
        public OpMetrics Negate(sbyte[] dst)
        {
            var opid = Id<sbyte>(OpKind.Negate);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (sbyte)(- src.Left[it]);
            return SampleTime(snapshot(sw));
        }


        public OpMetrics Negate(short[] dst)
        {
            var opid = Id<short>(OpKind.Negate);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (short)(- src.Left[it]);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Negate(int[] dst)
        {
            var opid = Id<int>(OpKind.Negate);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = - src.Left[it];
            return SampleTime(snapshot(sw));
        }


        public OpMetrics Negate(long[] dst)
        {
            var opid = Id<long>(OpKind.Negate);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = - src.Left[it];
            return SampleTime(snapshot(sw));
        }


        public OpMetrics Negate(float[] dst)
        {
            var opid = Id<float>(OpKind.Negate);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = - src.Left[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Negate(double[] dst)
        {
            var opid = Id<double>(OpKind.Negate);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = - src.Left[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics NegateFused(sbyte[] dst)
        {
            var opid = Id<sbyte>(OpKind.Negate);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.negate(src.Left, dst);
            return SampleTime(snapshot(sw));
        }


        public OpMetrics NegateFused(short[] dst)
        {
            var opid = Id<short>(OpKind.Negate);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.negate(src.Left, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics NegateFused(int[] dst)
        {
            var opid = Id<int>(OpKind.Negate);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.negate(src.Left, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics NegateFused(long[] dst)
        {
            var opid = Id<long>(OpKind.Negate);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.negate(src.Left, dst);
            return SampleTime(snapshot(sw));
        }


        public OpMetrics NegateFused(float[] dst)
        {
            var opid = Id<float>(OpKind.Negate);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.negate(src.Left, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics NegateFused(double[] dst)
        {
            var opid = Id<double>(OpKind.Negate);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.negate(src.Left, dst);
            return SampleTime(snapshot(sw));
        }


        public OpMetrics NegateIO(sbyte[] io)
        {
            var opid = Id<sbyte>(OpKind.Negate);
            var it = -1;
            var len = io.Length;

            var sw = stopwatch();
            while(++it < len)
                gmath.negate(ref io[it]);
            return SampleTime(snapshot(sw));            
        }

        public OpMetrics NegateIO(byte[] io)
        {
            var opid = Id<byte>(OpKind.Negate);
            var it = -1;
            var len = io.Length;

            var sw = stopwatch();
            while(++it < len)
                gmath.negate(ref io[it]);
            return SampleTime(snapshot(sw));            
        }

        public OpMetrics NegateIO(short[] io)
        {
            var opid = Id<short>(OpKind.Negate);
            var it = -1;
            var len = io.Length;

            var sw = stopwatch();
            while(++it < len)
                gmath.negate(ref io[it]);
            return SampleTime(snapshot(sw));            
        }

        public OpMetrics NegateIO(ushort[] io)
        {
            var opid = Id<ushort>(OpKind.Negate);
            var it = -1;
            var len = io.Length;

            var sw = stopwatch();
            while(++it < len)
                gmath.negate(ref io[it]);
            return SampleTime(snapshot(sw));            
        }

        public OpMetrics NegateIO(int[] io)
        {
            var opid = Id<int>(OpKind.Negate);
            var it = -1;
            var len = io.Length;

            var sw = stopwatch();
            while(++it < len)
                gmath.negate(ref io[it]);
            return SampleTime(snapshot(sw));            
        }

        public OpMetrics NegateIO(uint[] io)
        {
            var opid = Id<uint>(OpKind.Negate);
            var it = -1;
            var len = io.Length;

            var sw = stopwatch();
            while(++it < len)
                gmath.negate(ref io[it]);
            return SampleTime(snapshot(sw));            
        }

        public OpMetrics NegateIO(long[] io)
        {
            var opid = Id<long>(OpKind.Negate);
            var it = -1;
            var len = io.Length;

            var sw = stopwatch();
            while(++it < len)
                gmath.negate(ref io[it]);
            return SampleTime(snapshot(sw));            
        }

        public OpMetrics NegateIO(ulong[] io)
        {
            var opid = Id<float>(OpKind.Negate);
            var it = -1;
            var len = io.Length;

            var sw = stopwatch();
            while(++it < len)
                gmath.negate(ref io[it]);
            return SampleTime(snapshot(sw));            
        }

        public OpMetrics NegateIO(float[] io)
        {
            var opid = Id<float>(OpKind.Negate);
            var it = -1;
            var len = io.Length;

            var sw = stopwatch();
            while(++it < len)
                gmath.negate(ref io[it]);
            return SampleTime(snapshot(sw));            
        }

        public OpMetrics NegateIO(double[] io)
        {
            var opid = Id<double>(OpKind.Negate);
            var it = -1;
            var len = io.Length;

            var sw = stopwatch();
            while(++it < len)
                gmath.negate(ref io[it]);
            return SampleTime(snapshot(sw));            
        }
   }
}