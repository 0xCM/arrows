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
        public OpMetrics Add(sbyte[] dst)
        {
            var opid = Id<sbyte>(OpKind.Add);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (sbyte)(src.Left[it] + src.Right[it]);
            return SampleTime(snapshot(sw));
        }


        public OpMetrics Add(byte[] dst)
        {
            var opid = Id<byte>(OpKind.Add);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (byte)(src.Left[it] + src.Right[it]);
            return SampleTime(snapshot(sw));
        }


        public OpMetrics Add(short[] dst)
        {
            var opid = Id<short>(OpKind.Add);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (short)(src.Left[it] + src.Right[it]);
            return SampleTime(snapshot(sw));
        }

        
        public OpMetrics Add(ushort[] dst)
        {
            var opid = Id<ushort>(OpKind.Add);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = (ushort)(src.Left[it] + src.Right[it]);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Add(int[] dst)
        {
            var opid = Id<int>(OpKind.Add);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] + src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Add(uint[] dst)
        {
            var opid = Id<uint>(OpKind.Add);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] + src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Add(long[] dst)
        {
            var opid = Id<long>(OpKind.Add);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] + src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Add(ulong[] dst)
        {
            var opid = Id<ulong>(OpKind.Add);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] + src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Add(float[] dst)
        {
            var opid = Id<float>(OpKind.Add);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] + src.Right[it];
            return SampleTime(snapshot(sw));
        }

        public OpMetrics Add(double[] dst)
        {
            var opid = Id<double>(OpKind.Add);
            var src = Sampled(opid);
            var it = -1;

            var sw = stopwatch();
            while(++it < SampleSize)
                dst[it] = src.Left[it] + src.Right[it];
            return SampleTime(snapshot(sw));
        }

        
        public OpMetrics<T> Add<T>()
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    return AddI8().As<T>();
                case PrimalKind.uint8:
                    return AddU8().As<T>();
                case PrimalKind.int16:
                    return AddI16().As<T>();
                case PrimalKind.uint16:
                    return AddU16().As<T>();
                case PrimalKind.int32:
                    return AddI32().As<T>();
                case PrimalKind.uint32:
                    return AddU32().As<T>();
                case PrimalKind.int64:
                    return AddI64().As<T>();
                case PrimalKind.uint64:
                    return AddU64().As<T>();
                case PrimalKind.float32:
                    return AddF32().As<T>();
                case PrimalKind.float64:
                    return AddF64().As<T>();
                default:
                    throw unsupported(kind);
            }
        
        }

        OpMetrics<sbyte> AddI8()
        {
            var opid = Id<sbyte>(OpKind.Add);
            var dst = Target(opid);
            var src = Sampled(opid);
            var cycle = 0;

            var sw = stopwatch();
            while(++cycle <= Config.Cycles)
            {
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = (sbyte)(src.Left[it] + src.Right[it]);
            }
            return OpMetrics.Define(opid, SampleSize, snapshot(sw), dst);
        }

        OpMetrics<byte> AddU8()
        {
            var opid = Id<byte>(OpKind.Add);
            var dst = Target(opid);
            var src = Sampled(opid);
            var cycle = 0;

            var sw = stopwatch();
            while(++cycle <= Config.Cycles)
            {
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = (byte)(src.Left[it] + src.Right[it]);
            }
            return OpMetrics.Define(opid, SampleSize, snapshot(sw), dst);
        }


        OpMetrics<short> AddI16()
        {
            var opid = Id<short>(OpKind.Add);
            var dst = Target(opid);
            var src = Sampled(opid);
            var cycle = 0;

            var sw = stopwatch();
            while(++cycle <= Config.Cycles)
            {
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = (short)(src.Left[it] + src.Right[it]);
            }
            return OpMetrics.Define(opid, SampleSize, snapshot(sw), dst);
        }

        OpMetrics<ushort> AddU16()
        {
            var opid = Id<ushort>(OpKind.Add);
            var dst = Target(opid);
            var src = Sampled(opid);
            var cycle = 0;

            var sw = stopwatch();
            while(++cycle <= Config.Cycles)
            {
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = (ushort)(src.Left[it] + src.Right[it]);
            }
            return OpMetrics.Define(opid, SampleSize, snapshot(sw), dst);
        }

        OpMetrics<int> AddI32()
        {
            var opid = Id<int>(OpKind.Add);
            var dst = Target(opid);
            var src = Sampled(opid);
            var cycle = 0;

            var sw = stopwatch();
            while(++cycle <= Config.Cycles)
            {
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] + src.Right[it];
            }    

            return OpMetrics.Define(opid, SampleSize, snapshot(sw), dst);
        }

        OpMetrics<uint> AddU32()
        {
            var opid = Id<uint>(OpKind.Add);
            var dst = Target(opid);
            var src = Sampled(opid);
            var cycle = 0;

            var sw = stopwatch();
            while(++cycle <= Config.Cycles)
            {
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] + src.Right[it];
            }
            return OpMetrics.Define(opid, SampleSize, snapshot(sw), dst);
        }

        OpMetrics<long> AddI64()
        {
            var opid = Id<long>(OpKind.Add);
            var dst = Target(opid);
            var src = Sampled(opid);
            var cycle = 0;

            var sw = stopwatch();
            while(++cycle <= Config.Cycles)
            {
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] + src.Right[it];
            }
            return OpMetrics.Define(opid, SampleSize, snapshot(sw), dst);
        }

        OpMetrics<ulong> AddU64()
        {
            var opid = Id<ulong>(OpKind.Add);
            var dst = Target(opid);
            var src = Sampled(opid);
            var cycle = 0;

            var sw = stopwatch();
            while(++cycle <= Config.Cycles)
            {
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] + src.Right[it];
            }            
            return OpMetrics.Define(opid, SampleSize, snapshot(sw), dst);
        }

        OpMetrics<float> AddF32()
        {
            var opid = Id<float>(OpKind.Add);
            var dst = Target(opid);
            var src = Sampled(opid);
            var cycle = 0;

            var sw = stopwatch();
            while(++cycle <= Config.Cycles)
            {
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] + src.Right[it];
            }
            return OpMetrics.Define(opid, SampleSize, snapshot(sw), dst);
        }

        OpMetrics<double> AddF64()
        {
            var opid = Id<double>(OpKind.Add);
            var dst = Target(opid);
            var src = Sampled(opid);
            var cycle = 0;

            var sw = stopwatch();
            while(++cycle <= Config.Cycles)
            {
                var it = -1;
                while(++it < SampleSize)
                    dst[it] = src.Left[it] + src.Right[it];
            }
            
            return OpMetrics.Define(opid, SampleSize, snapshot(sw), dst);            
        }

        public OpMetrics AddFused(sbyte[] dst)
        {
            var opid = Id<sbyte>(OpKind.Add);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.add(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics AddFused(byte[] dst)
        {
            var opid = Id<byte>(OpKind.Add);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.add(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics AddFused(short[] dst)
        {
            var opid = Id<short>(OpKind.Add);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.add(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics AddFused(ushort[] dst)
        {
            var opid = Id<ushort>(OpKind.Add);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.add(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics AddFused(int[] dst)
        {
            var opid = Id<int>(OpKind.Add);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.add(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics AddFused(uint[] dst)
        {
            var opid = Id<uint>(OpKind.Add);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.add(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics AddFused(long[] dst)
        {
            var opid = Id<long>(OpKind.Add);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.add(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics AddFused(ulong[] dst)
        {
            var opid = Id<ulong>(OpKind.Add);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.add(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics AddFused(float[] dst)
        {
            var opid = Id<float>(OpKind.Add);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.add(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

        public OpMetrics AddFused(double[] dst)
        {
            var opid = Id<double>(OpKind.Add);
            var src = Sampled(opid);
            var sw = stopwatch();
            math.add(src.Left, src.Right, dst);
            return SampleTime(snapshot(sw));
        }

   }
}