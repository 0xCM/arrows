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
        public OpMetrics Sub(sbyte[] dst)
        {
            var opid = Id<sbyte>(OpKind.Sub);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (sbyte)(src.Left[it] - src.Right[it]);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Sub(byte[] dst)
        {
            var opid = Id<byte>(OpKind.Sub);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (byte)(src.Left[it] - src.Right[it]);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Sub(short[] dst)
        {
            var opid = Id<short>(OpKind.Sub);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (short)(src.Left[it] - src.Right[it]);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Sub(ushort[] dst)
        {
            var opid = Id<ushort>(OpKind.Sub);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (ushort)(src.Left[it] - src.Right[it]);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Sub(int[] dst)
        {
            var opid = Id<int>(OpKind.Sub);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] - src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Sub(uint[] dst)
        {
            var opid = Id<uint>(OpKind.Sub);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] - src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Sub(long[] dst)
        {
            var opid = Id<long>(OpKind.Sub);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] - src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Sub(ulong[] dst)
        {
            var opid = Id<ulong>(OpKind.Sub);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] - src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Sub(float[] dst)
        {
            var opid = Id<float>(OpKind.Sub);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] - src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Sub(double[] dst)
        {
            var opid = Id<double>(OpKind.Sub);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] - src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics SubFused(sbyte[] dst)
        {
            var opid = Id<sbyte>(OpKind.Sub);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.sub(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics SubFused(byte[] dst)
        {
            var opid = Id<byte>(OpKind.Sub);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.sub(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics SubFused(short[] dst)
        {
            var opid = Id<short>(OpKind.Sub);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.sub(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics SubFused(ushort[] dst)
        {
            var opid = Id<ushort>(OpKind.Sub);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.sub(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics SubFused(int[] dst)
        {
            var opid = Id<int>(OpKind.Sub);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.sub(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics SubFused(uint[] dst)
        {
            var opid = Id<uint>(OpKind.Sub);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.sub(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics SubFused(long[] dst)
        {
            var opid = Id<long>(OpKind.Sub);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.sub(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics SubFused(ulong[] dst)
        {
            var opid = Id<ulong>(OpKind.Sub);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.sub(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics SubFused(float[] dst)
        {
            var opid = Id<float>(OpKind.Sub);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.sub(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics SubFused(double[] dst)
        {
            var opid = Id<double>(OpKind.Sub);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.sub(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

   }
}