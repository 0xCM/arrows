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
    using static BitDMetrics;
    using static As;

    [OpMetric(MetricKind.BitD, OpKind.Toggle)]
    public class ToggleDMetrics 
    {
        public static Metrics<T> Toggle<T>(ReadOnlySpan<T> src, ReadOnlySpan<int> positions, BitDConfig config = null)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return Toggle(int8(src), positions, config).As<T>();
            else if(typeof(T) == typeof(byte))
                return Toggle(uint8(src),positions, config).As<T>();
            else if(typeof(T) == typeof(short))
                return Toggle(int16(src),positions, config).As<T>();
            else if(typeof(T) == typeof(ushort))
                return Toggle(uint16(src), positions, config).As<T>();
            else if(typeof(T) == typeof(int))
                return Toggle(int32(src), positions, config).As<T>();
            else if(typeof(T) == typeof(uint))
                return Toggle(uint32(src), positions, config).As<T>();
            else if(typeof(T) == typeof(long))
                return Toggle(int64(src), positions, config).As<T>();
            else if(typeof(T) == typeof(ulong))
                return Toggle(uint64(src),positions, config).As<T>();
            throw unsupported(PrimalKinds.kind<T>());
        }

        public Metrics<T> Measure<T>(BitDConfig config, IRandomizer random)
            where T : struct
        {
            var src = random.ReadOnlySpan<T>(config.Samples);
            var positions = random.Span<int>(config.Samples, closed(0,7));
            var metrics = Metrics<T>.Zero;
            for(var i=0; i<config.Runs; i++)
            {
                var result = Toggle(src,positions,config);
                metrics += result;
                print(result.Describe());
            }
            return metrics;
        }

        static Metrics<sbyte> Toggle(ReadOnlySpan<sbyte> src, ReadOnlySpan<int> pos, BitDConfig config = null)
        {
            OpId opid = Id<sbyte>(OpKind.Toggle);            
            var dst = src.Replicate();
            var cycles =Cycles(config);
            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample< dst.Length; sample++)
                Bits.toggle(ref dst[sample], pos[sample]);
            
            var time = snapshot(sw);
            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        static Metrics<byte> Toggle(ReadOnlySpan<byte> src, ReadOnlySpan<int> pos, BitDConfig config = null)
        {
            OpId opid = Id<byte>(OpKind.Toggle);            
            var dst = src.Replicate();
            var cycles =Cycles(config);
            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample< dst.Length; sample++)
                Bits.toggle(ref dst[sample], pos[sample]);
            
            var time = snapshot(sw);
            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        static Metrics<short> Toggle(ReadOnlySpan<short> src, ReadOnlySpan<int> pos, BitDConfig config = null)
        {
            OpId opid = Id<short>(OpKind.Toggle);            
            var dst = src.Replicate();
            var cycles =Cycles(config);
            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample< dst.Length; sample++)
                Bits.toggle(ref dst[sample], pos[sample]);
            
            var time = snapshot(sw);
            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        static Metrics<ushort> Toggle(ReadOnlySpan<ushort> src, ReadOnlySpan<int> pos, BitDConfig config = null)
        {
            OpId opid = Id<ushort>(OpKind.Toggle);            
            var dst = src.Replicate();
            var cycles =Cycles(config);
            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample< dst.Length; sample++)
                Bits.toggle(ref dst[sample], pos[sample]);
            
            var time = snapshot(sw);
            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        static Metrics<int> Toggle(ReadOnlySpan<int> src, ReadOnlySpan<int> pos, BitDConfig config = null)
        {
            OpId opid = Id<int>(OpKind.Toggle);            
            var dst = src.Replicate();
            var cycles =Cycles(config);
            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample< dst.Length; sample++)
                Bits.toggle(ref dst[sample], pos[sample]);
            
            var time = snapshot(sw);
            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        static Metrics<uint> Toggle(ReadOnlySpan<uint> src, ReadOnlySpan<int> pos, BitDConfig config = null)
        {
            OpId opid = Id<uint>(OpKind.Toggle);            
            var dst = src.Replicate();
            var cycles =Cycles(config);
            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample< dst.Length; sample++)
                Bits.toggle(ref dst[sample], pos[sample]);
            
            var time = snapshot(sw);
            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        static Metrics<long> Toggle(ReadOnlySpan<long> src, ReadOnlySpan<int> pos, BitDConfig config = null)
        {
            OpId opid = Id<long>(OpKind.Toggle);            
            var dst = src.Replicate();
            var cycles =Cycles(config);
            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample< dst.Length; sample++)
                Bits.toggle(ref dst[sample], pos[sample]);
            
            var time = snapshot(sw);
            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }

        static Metrics<ulong> Toggle(ReadOnlySpan<ulong> src, ReadOnlySpan<int> pos, BitDConfig config = null)
        {
            OpId opid = Id<ulong>(OpKind.Toggle);            
            var dst = src.Replicate();
            var cycles =Cycles(config);
            
            var sw = stopwatch();
            for(var cycle = 0; cycle < cycles; cycle++)
            for(var sample=0; sample< dst.Length; sample++)
                Bits.toggle(ref dst[sample], pos[sample]);
            
            var time = snapshot(sw);
            return opid.CaptureMetrics(cycles*dst.Length, time, dst);
        }
    }

}
