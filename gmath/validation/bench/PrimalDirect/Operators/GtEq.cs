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

        public OpMetrics GtEqI8(bool[] dst)
        {
            var opid = Id<sbyte>(OpKind.GtEq);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] >= src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics GtEqU8(bool[] dst)
        {
            var opid = Id<byte>(OpKind.GtEq);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] >= src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics GtEqI16(bool[] dst)
        {
            var opid = Id<short>(OpKind.GtEq);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] >= src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics GtEqU16(bool[] dst)
        {
            var opid = Id<ushort>(OpKind.GtEq);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] >= src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics GtEqI32(bool[] dst)
        {
            var opid = Id<int>(OpKind.GtEq);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] >= src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics GtEqU32(bool[] dst)
        {
            var opid = Id<uint>(OpKind.GtEq);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] >= src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics GtEqI64(bool[] dst)
        {
            var opid = Id<long>(OpKind.GtEq);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] >= src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics GtEqU64(bool[] dst)
        {
            var opid = Id<ulong>(OpKind.GtEq);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] >= src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics GtEqF32(bool[] dst)
        {
            var opid = Id<float>(OpKind.GtEq);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] >= src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics GtEqF64(bool[] dst)
        {
            var opid = Id<double>(OpKind.GtEq);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] >= src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics GtEqI8Fused(bool[] dst)
        {
            var opid = Id<sbyte>(OpKind.GtEq);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.gteq(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics GtEqU8Fused(bool[] dst)
        {
            var opid = Id<byte>(OpKind.GtEq);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.gteq(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics GtEqI16Fused(bool[] dst)
        {
            var opid = Id<short>(OpKind.GtEq);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.gteq(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics GtEqU16Fused(bool[] dst)
        {
            var opid = Id<ushort>(OpKind.GtEq);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.gteq(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics GtEqI32Fused(bool[] dst)
        {
            var opid = Id<int>(OpKind.GtEq);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.gteq(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics GtEqU32Fused(bool[] dst)
        {
            var opid = Id<uint>(OpKind.GtEq);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.gteq(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics GtEqI64Fused(bool[] dst)
        {
            var opid = Id<long>(OpKind.GtEq);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.gteq(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics GtEqU64Fused(bool[] dst)
        {
            var opid = Id<ulong>(OpKind.GtEq);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.gteq(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics GtEqF32Fused(bool[] dst)
        {
            var opid = Id<float>(OpKind.GtEq);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.gteq(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics GtEqF64Fused(bool[] dst)
        {
            var opid = Id<double>(OpKind.GtEq);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.gteq(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }
         
   }
}