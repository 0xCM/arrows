//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Bench
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;
    using static As;
    using static BenchRunner;
    
    public static class InXDBench
    {
        public static Metrics<T> Run<T>(this InXDContext128 context, OpKind op)        
            where T : struct
        {
            var random = context.Random;
            var lhs = random.Span128<T>(context.Blocks);
            var rhs = op.IsDivision() 
                ? random.NonZeroSpan128<T>(context.Blocks) 
                : random.Span128<T>(context.Blocks);            
            var metrics = Metrics<T>.Zero;

            GC.Collect();            
            for(var i=0; i<context.Runs; i++)
                metrics += context.Run<T>(op, lhs, rhs);
            return metrics;            
        }

        public static Metrics<T> Run<T>(this InXDContext256 context, OpKind op)        
            where T : struct
        {
            var random = context.Random;
            var lhs = random.Span256<T>(context.Blocks);
            var rhs = op.IsDivision() 
                ? random.NonZeroSpan256<T>(context.Blocks) 
                : random.Span256<T>(context.Blocks);            
            var metrics = Metrics<T>.Zero;

            GC.Collect();            
            for(var i=0; i < context.Runs; i++)
                metrics += context.Run<T>(op, lhs, rhs);
            return metrics;            
        }

        public static IMetrics Run(this InXDContext128 context, OpKind op, PrimalKind prim)
        {
            var random = context.Random;
            switch(prim)
            {
                case PrimalKind.int8:
                    return context.Run<sbyte>(op);
                case PrimalKind.uint8:
                    return context.Run<byte>(op);
                case PrimalKind.int16:
                    return context.Run<short>(op);
                case PrimalKind.uint16:
                    return context.Run<ushort>(op);
                case PrimalKind.int32:
                    return context.Run<int>(op);
                case PrimalKind.uint32:
                    return context.Run<uint>(op);
                case PrimalKind.int64:
                    return context.Run<long>(op);
                case PrimalKind.uint64:
                    return context.Run<ulong>(op);
                case PrimalKind.float32:
                    return context.Run<float>(op);
                case PrimalKind.float64:                    
                    return context.Run<double>(op);
                default:
                    throw unsupported(op, prim);
            }
        }

        public static IMetrics Run(this InXDContext256 context, OpKind op, PrimalKind prim)
        {
            var random = context.Random;
            switch(prim)
            {
                case PrimalKind.int8:
                    return context.Run<sbyte>(op);
                case PrimalKind.uint8:
                    return context.Run<byte>(op);
                case PrimalKind.int16:
                    return context.Run<short>(op);
                case PrimalKind.uint16:
                    return context.Run<ushort>(op);
                case PrimalKind.int32:
                    return context.Run<int>(op);
                case PrimalKind.uint32:
                    return context.Run<uint>(op);
                case PrimalKind.int64:
                    return context.Run<long>(op);
                case PrimalKind.uint64:
                    return context.Run<ulong>(op);
                case PrimalKind.float32:
                    return context.Run<float>(op);
                case PrimalKind.float64:                    
                    return context.Run<double>(op);
                default:
                    throw unsupported(op, prim);
            }
        }


    }


}
