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
    
    public static class PrimalDBench
    {        

        public static IMetrics Run(this PrimalDContext context, OpKind op, PrimalKind prim)
            => context.Config.Run(op, prim, context.Random);
        public static IMetrics Run(this PrimalDConfig config, OpKind op, PrimalKind prim, IRandomSource random)
        {
            switch(prim)
            {
                case PrimalKind.int8:
                    return config.Run<sbyte>(op, random);
                case PrimalKind.uint8:
                    return config.Run<byte>(op, random);
                case PrimalKind.int16:
                    return config.Run<short>(op, random);
                case PrimalKind.uint16:
                    return config.Run<ushort>(op, random);
                case PrimalKind.int32:
                    return config.Run<int>(op, random);
                case PrimalKind.uint32:
                    return config.Run<uint>(op, random);
                case PrimalKind.int64:
                    return config.Run<long>(op, random);
                case PrimalKind.uint64:
                    return config.Run<ulong>(op, random);
                case PrimalKind.float32:
                    return config.Run<float>(op, random);
                case PrimalKind.float64:                    
                    return config.Run<double>(op, random);
                default:
                    throw unsupported(prim);
            }
        }

        static Metrics<T> Run<T>(this PrimalDConfig config, OpKind op, IRandomSource random)        
            where T : struct
        {
            var metrics = Metrics<T>.Zero;
            var lhs = random.ReadOnlySpan<T>(config.Samples);
            var rhs = op.IsDivision() 
                ? random.NonZeroSpan<T>(config.Samples) 
                : random.ReadOnlySpan<T>(config.Samples);
            var moves = op.IsBitMovement() 
                ? random.ReadOnlySpan<int>(config.Samples, closed(0, SizeOf<T>.BitSize)) 
                : ReadOnlySpan<int>.Empty;

            GC.Collect();            
            for(var i=0; i<config.Runs; i++)
            {                
                if(op.IsBitMovement())
                    config.Run(op, lhs, moves);
                else if(op.Arity() == OpArity.Binary)
                    metrics += config.Run<T>(op, lhs, rhs);
                else if(op.Arity() == OpArity.Unary)
                    metrics += config.Run(op, lhs);
                else 
                    error($"No arity defined for {op} operator!");
            }
            return metrics;            
        }

        static Metrics<T> Run<T>(this PrimalDConfig config, OpKind op, ReadOnlySpan<T> lhs, ReadOnlySpan<int> rhs)
            where T : struct
        {
            var metrics = Metrics<T>.Zero;
            switch(op)
            {
                case OpKind.ShiftL:
                    metrics = config.ShiftL(lhs,rhs);   
                break;
                case OpKind.ShiftR:
                    metrics = config.ShiftR(lhs,rhs);   
                break;
                case OpKind.RotR:
                    metrics = config.RotR(lhs,rhs);   
                break;
                case OpKind.RotL:
                    metrics = config.RotL(lhs,rhs);   
                break;
                default: 
                    throw unsupported(op);
            }
            return metrics;
        }

        static Metrics<T> Run<T>(this PrimalDConfig config, OpKind op, ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var metrics = Metrics<T>.Zero;
            switch(op)
            {
                case OpKind.Add:
                    metrics = config.Add<T>(lhs,rhs);   
                break;
                case OpKind.Sub:
                    metrics = config.Sub<T>(lhs,rhs);   
                break;
                case OpKind.Mul:
                    metrics = config.Mul<T>(lhs,rhs);   
                break;
                case OpKind.Div:
                    metrics = config.Div<T>(lhs,rhs);   
                break;
                case OpKind.Mod:
                    metrics = config.Mod<T>(lhs, rhs);   
                break;
                case OpKind.And:
                    metrics = config.And<T>(lhs, rhs);   
                break;
                case OpKind.Or:
                    metrics = config.Or<T>(lhs, rhs);   
                break;
                case OpKind.XOr:
                    metrics = config.XOr<T>(lhs, rhs);   
                break;
                case OpKind.Eq:
                    metrics = config.Eq<T>(lhs, rhs);   
                break;
                case OpKind.Gt:
                    metrics = config.Gt<T>(lhs, rhs);   
                break;
                case OpKind.GtEq:
                    metrics = config.GtEq<T>(lhs, rhs);   
                break;
                case OpKind.Lt:
                    metrics = config.Lt<T>(lhs, rhs);   
                break;
                case OpKind.LtEq:
                    metrics = config.LtEq<T>(lhs, rhs);   
                break;

                default: 
                    throw unsupported(op);
            }            

            print(metrics.Describe());
            return metrics;
        }

        static Metrics<T> Run<T>(this PrimalDConfig config, OpKind op, ReadOnlySpan<T> src)
            where T : struct
        {
            var metrics = Metrics<T>.Zero;
            switch(op)
            {
                case OpKind.Abs:
                    metrics = config.Abs<T>(src);   
                break;
                case OpKind.Negate:
                    metrics = config.Negate<T>(src);   
                break;
                case OpKind.Flip:
                    metrics = config.Flip<T>(src);   
                break;
                case OpKind.Inc:
                    metrics = config.Inc<T>(src);   
                break;
                case OpKind.Dec:
                    metrics = config.Dec<T>(src);   
                break;

                default: 
                    throw unsupported(op);
            }            

            print(metrics.Describe());

            return metrics;
        }
    }

}