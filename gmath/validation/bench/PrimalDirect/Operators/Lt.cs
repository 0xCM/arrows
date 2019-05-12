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

        public OpMetrics LtI8(bool[] dst)
        {
            var opid = Id<sbyte>(OpKind.Lt);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] < src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics LtU8(bool[] dst)
        {
            var opid = Id<byte>(OpKind.Lt);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] < src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics LtI16(bool[] dst)
        {
            var opid = Id<short>(OpKind.Lt);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] < src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics LtU16(bool[] dst)
        {
            var opid = Id<ushort>(OpKind.Lt);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] < src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics LtI32(bool[] dst)
        {
            var opid = Id<int>(OpKind.Lt);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] < src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics LtU32(bool[] dst)
        {
            var opid = Id<uint>(OpKind.Lt);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] < src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics LtI64(bool[] dst)
        {
            var opid = Id<long>(OpKind.Lt);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] < src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics LtU64(bool[] dst)
        {
            var opid = Id<ulong>(OpKind.Lt);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] < src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics LtF32(bool[] dst)
        {
            var opid = Id<float>(OpKind.Lt);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] < src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics LtF64(bool[] dst)
        {
            var opid = Id<double>(OpKind.Lt);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] < src.Right[it];
            return SampleTime(snapshot(sw));
        }
   }
}