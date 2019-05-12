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

        public OpMetrics EqI8(bool[] dst)
        {
            var opid = Id<sbyte>(OpKind.Eq);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] == src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics EqU8(bool[] dst)
        {
            var opid = Id<byte>(OpKind.Eq);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] == src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics EqI16(bool[] dst)
        {
            var opid = Id<short>(OpKind.Eq);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] == src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics EqU16(bool[] dst)
        {
            var opid = Id<ushort>(OpKind.Eq);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] == src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics EqI32(bool[] dst)
        {
            var opid = Id<int>(OpKind.Eq);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] == src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics EqU32(bool[] dst)
        {
            var opid = Id<uint>(OpKind.Eq);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] == src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics EqI64(bool[] dst)
        {
            var opid = Id<long>(OpKind.Eq);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] == src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics EqU64(bool[] dst)
        {
            var opid = Id<ulong>(OpKind.Eq);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] == src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics EqF32(bool[] dst)
        {
            var opid = Id<float>(OpKind.Eq);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] == src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics EqF64(bool[] dst)
        {
            var opid = Id<double>(OpKind.Eq);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] == src.Right[it];
            return SampleTime(snapshot(sw));
        }
   }
}