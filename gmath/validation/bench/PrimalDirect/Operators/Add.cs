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
        public OpMetrics Add(sbyte[] dst)
        {
            var opid = Id<sbyte>(OpKind.Add);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (sbyte)(src.Left[it] + src.Right[it]);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Add(byte[] dst)
        {
            var opid = Id<byte>(OpKind.Add);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (byte)(src.Left[it] + src.Right[it]);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Add(short[] dst)
        {
            var opid = Id<short>(OpKind.Add);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (short)(src.Left[it] + src.Right[it]);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Add(ushort[] dst)
        {
            var opid = Id<ushort>(OpKind.Add);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (ushort)(src.Left[it] + src.Right[it]);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Add(int[] dst)
        {
            var opid = Id<int>(OpKind.Add);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] + src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Add(uint[] dst)
        {
            var opid = Id<uint>(OpKind.Add);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] + src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Add(long[] dst)
        {
            var opid = Id<long>(OpKind.Add);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] + src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Add(ulong[] dst)
        {
            var opid = Id<ulong>(OpKind.Add);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] + src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Add(float[] dst)
        {
            var opid = Id<float>(OpKind.Add);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] + src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Add(double[] dst)
        {
            var opid = Id<double>(OpKind.Add);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] + src.Right[it];
            return SampleTime(snapshot(sw));
        }
   }
}