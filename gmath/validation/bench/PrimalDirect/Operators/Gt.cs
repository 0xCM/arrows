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

        public OpMetrics GtI8(bool[] dst)
        {
            var opid = Id<sbyte>(OpKind.Gt);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] > src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics GtU8(bool[] dst)
        {
            var opid = Id<byte>(OpKind.Gt);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] > src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics GtI16(bool[] dst)
        {
            var opid = Id<short>(OpKind.Gt);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] > src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics GtU16(bool[] dst)
        {
            var opid = Id<ushort>(OpKind.Gt);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] > src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics GtI32(bool[] dst)
        {
            var opid = Id<int>(OpKind.Gt);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] > src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics GtU32(bool[] dst)
        {
            var opid = Id<uint>(OpKind.Gt);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] > src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics GtI64(bool[] dst)
        {
            var opid = Id<long>(OpKind.Gt);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] > src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics GtU64(bool[] dst)
        {
            var opid = Id<ulong>(OpKind.Gt);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] > src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics GtF32(bool[] dst)
        {
            var opid = Id<float>(OpKind.Gt);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] > src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics GtF64(bool[] dst)
        {
            var opid = Id<double>(OpKind.Gt);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] > src.Right[it];
            return SampleTime(snapshot(sw));
        }
   }
}