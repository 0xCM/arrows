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
        public OpMetrics Inc(sbyte[] dst)
        {
            var opid = Id<sbyte>(OpKind.Inc);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (sbyte)(src.Left[it] + 1);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Inc(byte[] dst)
        {
            var opid = Id<byte>(OpKind.Inc);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (byte)(src.Left[it] + 1);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Inc(short[] dst)
        {
            var opid = Id<short>(OpKind.Inc);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (short)(src.Left[it] + 1);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Inc(ushort[] dst)
        {
            var opid = Id<ushort>(OpKind.Inc);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (ushort)(src.Left[it] + 1);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Inc(int[] dst)
        {
            var opid = Id<int>(OpKind.Inc);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] + 1;
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Inc(uint[] dst)
        {
            var opid = Id<uint>(OpKind.Inc);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] + 1;
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Inc(long[] dst)
        {
            var opid = Id<long>(OpKind.Inc);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] + 1;
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Inc(ulong[] dst)
        {
            var opid = Id<ulong>(OpKind.Inc);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] + 1;
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Inc(float[] dst)
        {
            var opid = Id<float>(OpKind.Inc);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] + 1;
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Inc(double[] dst)
        {
            var opid = Id<double>(OpKind.Inc);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] + 1;
            return SampleTime(snapshot(sw));
        }

        public OpMetrics IncFused(sbyte[] dst)
        {
            var opid = Id<sbyte>(OpKind.Inc);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.inc(src.Left, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics IncFused(byte[] dst)
        {
            var opid = Id<byte>(OpKind.Inc);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.inc(src.Left, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics IncFused(short[] dst)
        {
            var opid = Id<short>(OpKind.Inc);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.inc(src.Left, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics IncFused(ushort[] dst)
        {
            var opid = Id<ushort>(OpKind.Inc);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.inc(src.Left, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics IncFused(int[] dst)
        {
            var opid = Id<int>(OpKind.Inc);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.inc(src.Left, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics IncFused(uint[] dst)
        {
            var opid = Id<uint>(OpKind.Inc);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.inc(src.Left, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics IncFused(long[] dst)
        {
            var opid = Id<long>(OpKind.Inc);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.inc(src.Left, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics IncFused(ulong[] dst)
        {
            var opid = Id<ulong>(OpKind.Inc);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.inc(src.Left, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics IncFused(float[] dst)
        {
            var opid = Id<float>(OpKind.Inc);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.inc(src.Left, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics IncFused(double[] dst)
        {
            var opid = Id<double>(OpKind.Inc);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.inc(src.Left, dst);
            return SampleTime(snapshot(sw));
        }

   }
}