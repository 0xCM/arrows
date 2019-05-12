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
        public OpMetrics Mul(sbyte[] dst)
        {
            var opid = Id<sbyte>(OpKind.Mul);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (sbyte)(src.Left[it] * src.Right[it]);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Mul(byte[] dst)
        {
            var opid = Id<byte>(OpKind.Mul);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (byte)(src.Left[it] * src.Right[it]);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Mul(short[] dst)
        {
            var opid = Id<short>(OpKind.Mul);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (short)(src.Left[it] * src.Right[it]);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Mul(ushort[] dst)
        {
            var opid = Id<ushort>(OpKind.Mul);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (ushort)(src.Left[it] * src.Right[it]);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Mul(int[] dst)
        {
            var opid = Id<int>(OpKind.Mul);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] * src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Mul(uint[] dst)
        {
            var opid = Id<uint>(OpKind.Mul);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] * src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Mul(long[] dst)
        {
            var opid = Id<long>(OpKind.Mul);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] * src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Mul(ulong[] dst)
        {
            var opid = Id<ulong>(OpKind.Mul);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] * src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Mul(float[] dst)
        {
            var opid = Id<float>(OpKind.Mul);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] * src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Mul(double[] dst)
        {
            var opid = Id<double>(OpKind.Mul);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] * src.Right[it];
            return SampleTime(snapshot(sw));
        }
   }
}