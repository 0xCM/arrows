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
        public OpMetrics Or(sbyte[] dst)
        {
            var opid = Id<sbyte>(OpKind.Or);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (sbyte)(src.Left[it] | src.Right[it]);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Or(byte[] dst)
        {
            var opid = Id<byte>(OpKind.Or);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (byte)(src.Left[it] | src.Right[it]);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Or(short[] dst)
        {
            var opid = Id<short>(OpKind.Or);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (short)(src.Left[it] | src.Right[it]);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Or(ushort[] dst)
        {
            var opid = Id<ushort>(OpKind.Or);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (ushort)(src.Left[it] | src.Right[it]);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Or(int[] dst)
        {
            var opid = Id<int>(OpKind.Or);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] | src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Or(uint[] dst)
        {
            var opid = Id<uint>(OpKind.Or);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] | src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Or(long[] dst)
        {
            var opid = Id<long>(OpKind.Or);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] | src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Or(ulong[] dst)
        {
            var opid = Id<ulong>(OpKind.Or);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] | src.Right[it];
            return SampleTime(snapshot(sw));
        }
 
         public OpMetrics OrFused(sbyte[] dst)
        {
            var opid = Id<sbyte>(OpKind.Or);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.or(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics OrFused(byte[] dst)
        {
            var opid = Id<byte>(OpKind.Or);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.or(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics OrFused(short[] dst)
        {
            var opid = Id<short>(OpKind.Or);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.or(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics OrFused(ushort[] dst)
        {
            var opid = Id<ushort>(OpKind.Or);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.or(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics OrFused(int[] dst)
        {
            var opid = Id<int>(OpKind.Or);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.or(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics OrFused(uint[] dst)
        {
            var opid = Id<uint>(OpKind.Or);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.or(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics OrFused(long[] dst)
        {
            var opid = Id<long>(OpKind.Or);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.or(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics OrFused(ulong[] dst)
        {
            var opid = Id<ulong>(OpKind.Or);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.or(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

 
   }
}