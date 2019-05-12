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

        public OpMetrics LtEqI8(bool[] dst)
        {
            var opid = Id<sbyte>(OpKind.LtEq);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] <= src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics LtEqU8(bool[] dst)
        {
            var opid = Id<byte>(OpKind.LtEq);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] <= src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics LtEqI16(bool[] dst)
        {
            var opid = Id<short>(OpKind.LtEq);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] <= src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics LtEqU16(bool[] dst)
        {
            var opid = Id<ushort>(OpKind.LtEq);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] <= src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics LtEqI32(bool[] dst)
        {
            var opid = Id<int>(OpKind.LtEq);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] <= src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics LtEqU32(bool[] dst)
        {
            var opid = Id<uint>(OpKind.LtEq);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] <= src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics LtEqI64(bool[] dst)
        {
            var opid = Id<long>(OpKind.LtEq);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] <= src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics LtEqU64(bool[] dst)
        {
            var opid = Id<ulong>(OpKind.LtEq);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] <= src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics LtEqF32(bool[] dst)
        {
            var opid = Id<float>(OpKind.LtEq);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] <= src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics LtEqF64(bool[] dst)
        {
            var opid = Id<double>(OpKind.LtEq);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] <= src.Right[it];
            return SampleTime(snapshot(sw));
        }
   }
}