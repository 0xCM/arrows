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
        public OpMetrics Flip(sbyte[] dst)
        {
            var opid = Id<sbyte>(OpKind.Flip);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (sbyte)(~ src.Left[it]);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Flip(byte[] dst)
        {
            var opid = Id<byte>(OpKind.Flip);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (byte)(~ src.Left[it]);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Flip(short[] dst)
        {
            var opid = Id<short>(OpKind.Flip);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (short)(~ src.Left[it]);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Flip(ushort[] dst)
        {
            var opid = Id<ushort>(OpKind.Flip);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (ushort)(~ src.Left[it]);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Flip(int[] dst)
        {
            var opid = Id<int>(OpKind.Flip);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = ~ src.Left[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Flip(uint[] dst)
        {
            var opid = Id<uint>(OpKind.Flip);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = ~ src.Left[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Flip(long[] dst)
        {
            var opid = Id<long>(OpKind.Flip);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = ~ src.Left[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Flip(ulong[] dst)
        {
            var opid = Id<ulong>(OpKind.Flip);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = ~ src.Left[it];
            return SampleTime(snapshot(sw));
        }
   }
}