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
        public OpMetrics And(sbyte[] dst)
        {
            var opid = Id<sbyte>(OpKind.And);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (sbyte)(src.Left[it] & src.Right[it]);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics And(byte[] dst)
        {
            var opid = Id<byte>(OpKind.And);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (byte)(src.Left[it] & src.Right[it]);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics And(short[] dst)
        {
            var opid = Id<short>(OpKind.And);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (short)(src.Left[it] & src.Right[it]);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics And(ushort[] dst)
        {
            var opid = Id<ushort>(OpKind.And);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (ushort)(src.Left[it] & src.Right[it]);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics And(int[] dst)
        {
            var opid = Id<int>(OpKind.And);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] & src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics And(uint[] dst)
        {
            var opid = Id<uint>(OpKind.And);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] & src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics And(long[] dst)
        {
            var opid = Id<long>(OpKind.And);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] & src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics And(ulong[] dst)
        {
            var opid = Id<ulong>(OpKind.And);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] & src.Right[it];
            return SampleTime(snapshot(sw));
        }
   }
}