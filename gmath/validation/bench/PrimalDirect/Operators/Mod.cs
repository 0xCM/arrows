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
        public OpMetrics Mod(sbyte[] dst)
        {
            var opid = Id<sbyte>(OpKind.Mod);
            var src = Sampled(opid, true);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (sbyte)(src.Left[it] % src.Right[it]);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Mod(byte[] dst)
        {
            var opid = Id<byte>(OpKind.Mod);
            var src = Sampled(opid, true);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (byte)(src.Left[it] % src.Right[it]);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Mod(short[] dst)
        {
            var opid = Id<short>(OpKind.Mod);
            var src = Sampled(opid, true);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (short)(src.Left[it] % src.Right[it]);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Mod(ushort[] dst)
        {
            var opid = Id<ushort>(OpKind.Mod);
            var src = Sampled(opid, true);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (ushort)(src.Left[it] % src.Right[it]);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Mod(int[] dst)
        {
            var opid = Id<int>(OpKind.Mod);
            var src = Sampled(opid, true);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] % src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Mod(uint[] dst)
        {
            var opid = Id<uint>(OpKind.Mod);
            var src = Sampled(opid, true);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] % src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Mod(long[] dst)
        {
            var opid = Id<long>(OpKind.Mod);
            var src = Sampled(opid, true);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] % src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Mod(ulong[] dst)
        {
            var opid = Id<ulong>(OpKind.Mod);
            var src = Sampled(opid, true);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] % src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Mod(float[] dst)
        {
            var opid = Id<float>(OpKind.Mod);
            var src = Sampled(opid, true);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] % src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Mod(double[] dst)
        {
            var opid = Id<double>(OpKind.Mod);
            var src = Sampled(opid, true);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] % src.Right[it];
            return SampleTime(snapshot(sw));
        }
   }
}