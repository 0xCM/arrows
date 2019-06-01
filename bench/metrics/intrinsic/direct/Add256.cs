//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Metrics
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;
    using static As;
    using static InX256DMetrics;

    public static class AddInX256D
    {
        public static Metrics<T> AddD<T>(this InXConfig256 config, ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
            where T : struct
                =>  config.Add(lhs,rhs);
        static Metrics<T> Add<T>(this InXConfig256 config, ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            switch(kind)
            {
                case PrimalKind.int8:
                    return Add(int8(lhs), int8(rhs), config).As<T>();
                case PrimalKind.uint8:
                    return Add(uint8(lhs), uint8(rhs), config).As<T>();
                case PrimalKind.int16:
                    return Add(int16(lhs), int16(rhs), config).As<T>();
                case PrimalKind.uint16:
                    return Add(uint16(lhs), uint16(rhs), config).As<T>();
                case PrimalKind.int32:
                    return Add(int32(lhs), int32(rhs), config).As<T>();
                case PrimalKind.uint32:
                    return Add(uint32(lhs), uint32(rhs), config).As<T>();
                case PrimalKind.int64:
                    return Add(int64(lhs), int64(rhs), config).As<T>();
                case PrimalKind.uint64:
                    return Add(uint64(lhs), uint64(rhs), config).As<T>();
                case PrimalKind.float32:
                    return Add(float32(lhs), float32(rhs), config).As<T>();
                case PrimalKind.float64:                    
                    return Add(float64(lhs), float64(rhs), config).As<T>();
                default:
                    throw unsupported(kind);
            }
        }



        static Metrics<sbyte> Add(ReadOnlySpan256<sbyte> lhs, ReadOnlySpan256<sbyte> rhs, InXConfig256 config)
        {
            var opid = Id<sbyte>(OpKind.Add);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.add(lhs, rhs, ref dst);            
            return opid.CaptureMetrics(config, snapshot(sw), dst);                        
        }

        static Metrics<byte> Add(ReadOnlySpan256<byte> lhs, ReadOnlySpan256<byte> rhs, InXConfig256 config)
        {
            var opid = Id<byte>(OpKind.Add);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.add(lhs, rhs, ref dst);            
            return opid.CaptureMetrics(config, snapshot(sw), dst);                        
        }

        static Metrics<short> Add(ReadOnlySpan256<short> lhs, ReadOnlySpan256<short> rhs, InXConfig256 config)
        {
            var opid = Id<short>(OpKind.Add);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.add(lhs, rhs, ref dst);            
            return opid.CaptureMetrics(config, snapshot(sw), dst);                        
        }

        static Metrics<ushort> Add(ReadOnlySpan256<ushort> lhs, ReadOnlySpan256<ushort> rhs, InXConfig256 config)
        {
            var opid = Id<ushort>(OpKind.Add);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.add(lhs, rhs, ref dst);            
            return opid.CaptureMetrics(config, snapshot(sw), dst);                        
        }

        static Metrics<int> Add(ReadOnlySpan256<int> lhs, ReadOnlySpan256<int> rhs, InXConfig256 config)
        {
            var opid = Id<int>(OpKind.Add);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.add(lhs, rhs, ref dst);            
            return opid.CaptureMetrics(config, snapshot(sw), dst);                        
        }

        static Metrics<uint> Add(ReadOnlySpan256<uint> lhs, ReadOnlySpan256<uint> rhs, InXConfig256 config)
        {
            var opid = Id<uint>(OpKind.Add);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.add(lhs, rhs, ref dst);            
            return opid.CaptureMetrics(config, snapshot(sw), dst);                        
        }

        static Metrics<long> Add(ReadOnlySpan256<long> lhs, ReadOnlySpan256<long> rhs, InXConfig256 config)
        {
            var opid = Id<long>(OpKind.Add);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.add(lhs, rhs, ref dst);            
            return opid.CaptureMetrics(config, snapshot(sw), dst);                        
        }

        static Metrics<ulong> Add(ReadOnlySpan256<ulong> lhs, ReadOnlySpan256<ulong> rhs, InXConfig256 config)
        {
            var opid = Id<ulong>(OpKind.Add);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.add(lhs, rhs, ref dst);            
            return opid.CaptureMetrics(config, snapshot(sw), dst);                        
        }

        static Metrics<float> Add(ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs, InXConfig256 config)
        {
            var opid = Id<float>(OpKind.Add);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.add(lhs, rhs, ref dst);            
            return opid.CaptureMetrics(config, snapshot(sw), dst);                        
        }

        static Metrics<double> Add(ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs, InXConfig256 config)
        {
            var opid = Id<double>(OpKind.Add);            
            var dst = alloc(lhs,rhs);
            var sw = stopwatch();
            for(var cycle = 0; cycle < config.Cycles; cycle++)
                dinx.add(lhs, rhs, ref dst);            
            return opid.CaptureMetrics(config, snapshot(sw), dst);                        
        }
 


    }

}
