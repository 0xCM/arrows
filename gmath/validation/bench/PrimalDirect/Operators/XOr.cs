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
        public OpMetrics XOr(sbyte[] dst)
        {
            var opid = Id<sbyte>(OpKind.XOr);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (sbyte)(src.Left[it] ^ src.Right[it]);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics XOr(byte[] dst)
        {
            var opid = Id<byte>(OpKind.XOr);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (byte)(src.Left[it] ^ src.Right[it]);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics XOr(short[] dst)
        {
            var opid = Id<short>(OpKind.XOr);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (short)(src.Left[it] ^ src.Right[it]);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics XOr(ushort[] dst)
        {
            var opid = Id<ushort>(OpKind.XOr);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (ushort)(src.Left[it] ^ src.Right[it]);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics XOr(int[] dst)
        {
            var opid = Id<int>(OpKind.XOr);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] ^ src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics XOr(uint[] dst)
        {
            var opid = Id<uint>(OpKind.XOr);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] ^ src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics XOr(long[] dst)
        {
            var opid = Id<long>(OpKind.XOr);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] ^ src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics XOr(ulong[] dst)
        {
            var opid = Id<ulong>(OpKind.XOr);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] ^ src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics XOrFused(sbyte[] dst)
        {
            var opid = Id<sbyte>(OpKind.XOr);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.xor(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics XOrFused(byte[] dst)
        {
            var opid = Id<byte>(OpKind.XOr);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.xor(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics XOrFused(short[] dst)
        {
            var opid = Id<short>(OpKind.XOr);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.xor(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics XOrFused(ushort[] dst)
        {
            var opid = Id<ushort>(OpKind.XOr);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.xor(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics XOrFused(int[] dst)
        {
            var opid = Id<int>(OpKind.XOr);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.xor(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics XOrFused(uint[] dst)
        {
            var opid = Id<uint>(OpKind.XOr);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.xor(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics XOrFused(long[] dst)
        {
            var opid = Id<long>(OpKind.XOr);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.xor(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics XOrFused(ulong[] dst)
        {
            var opid = Id<ulong>(OpKind.XOr);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.xor(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }
   }
}