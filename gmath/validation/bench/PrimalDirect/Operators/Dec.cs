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
        public OpMetrics Dec(sbyte[] dst)
        {
            var opid = Id<sbyte>(OpKind.Dec);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (sbyte)(src.Left[it] - 1);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Dec(byte[] dst)
        {
            var opid = Id<byte>(OpKind.Dec);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (byte)(src.Left[it] - 1);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Dec(short[] dst)
        {
            var opid = Id<short>(OpKind.Dec);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (short)(src.Left[it] - 1);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Dec(ushort[] dst)
        {
            var opid = Id<ushort>(OpKind.Dec);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (ushort)(src.Left[it] - 1);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Dec(int[] dst)
        {
            var opid = Id<int>(OpKind.Dec);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] - 1;
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Dec(uint[] dst)
        {
            var opid = Id<uint>(OpKind.Dec);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] - 1;
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Dec(long[] dst)
        {
            var opid = Id<long>(OpKind.Dec);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] - 1;
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Dec(ulong[] dst)
        {
            var opid = Id<ulong>(OpKind.Dec);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] - 1;
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Dec(float[] dst)
        {
            var opid = Id<float>(OpKind.Dec);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] - 1;
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Dec(double[] dst)
        {
            var opid = Id<double>(OpKind.Dec);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] - 1;
            return SampleTime(snapshot(sw));
        }

   }
}