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
        public OpMetrics Div(sbyte[] dst)
        {
            var opid = Id<sbyte>(OpKind.Div);
            var src = Sampled(opid, true);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (sbyte)(src.Left[it] / src.Right[it]);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Div(byte[] dst)
        {
            var opid = Id<byte>(OpKind.Div);
            var src = Sampled(opid, true);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (byte)(src.Left[it] / src.Right[it]);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Div(short[] dst)
        {
            var opid = Id<short>(OpKind.Div);
            var src = Sampled(opid, true);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (short)(src.Left[it] / src.Right[it]);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Div(ushort[] dst)
        {
            var opid = Id<ushort>(OpKind.Div);
            var src = Sampled(opid, true);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (ushort)(src.Left[it] / src.Right[it]);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Div(int[] dst)
        {
            var opid = Id<int>(OpKind.Div);
            var src = Sampled(opid, true);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] / src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Div(uint[] dst)
        {
            var opid = Id<uint>(OpKind.Div);
            var src = Sampled(opid, true);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] / src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Div(long[] dst)
        {
            var opid = Id<long>(OpKind.Div);
            var src = Sampled(opid, true);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] / src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Div(ulong[] dst)
        {
            var opid = Id<ulong>(OpKind.Div);
            var src = Sampled(opid, true);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] / src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Div(float[] dst)
        {
            var opid = Id<float>(OpKind.Div);
            var src = Sampled(opid, true);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] / src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Div(double[] dst)
        {
            var opid = Id<double>(OpKind.Div);
            var src = Sampled(opid, true);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] / src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics DivFused(sbyte[] dst)
        {
            var opid = Id<sbyte>(OpKind.Div);
            var src = Sampled(opid, true);
            var sw = stopwatch();
            math.div(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics DivFused(byte[] dst)
        {
            var opid = Id<byte>(OpKind.Div);
            var src = Sampled(opid, true);
            var sw = stopwatch();
            math.div(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics DivFused(short[] dst)
        {
            var opid = Id<short>(OpKind.Div);
            var src = Sampled(opid, true);
            var sw = stopwatch();
            math.div(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics DivFused(ushort[] dst)
        {
            var opid = Id<ushort>(OpKind.Div);
            var src = Sampled(opid, true);
            var sw = stopwatch();
            math.div(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics DivFused(int[] dst)
        {
            var opid = Id<int>(OpKind.Div);
            var src = Sampled(opid, true);
            var sw = stopwatch();
            math.div(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics DivFused(uint[] dst)
        {
            var opid = Id<uint>(OpKind.Div);
            var src = Sampled(opid, true);
            var sw = stopwatch();
            math.div(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics DivFused(long[] dst)
        {
            var opid = Id<long>(OpKind.Div);
            var src = Sampled(opid, true);
            var sw = stopwatch();
            math.div(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics DivFused(ulong[] dst)
        {
            var opid = Id<ulong>(OpKind.Div);
            var src = Sampled(opid, true);
            var sw = stopwatch();
            math.div(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics DivFused(float[] dst)
        {
            var opid = Id<float>(OpKind.Div);
            var src = Sampled(opid, true);
            var sw = stopwatch();
            math.div(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics DivFused(double[] dst)
        {
            var opid = Id<double>(OpKind.Div);
            var src = Sampled(opid, true);
            var sw = stopwatch();
            math.div(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

   }
}