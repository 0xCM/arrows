//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    using System.Runtime.Intrinsics.X86;
        
    using static zfunc;

    using static As;

    partial class gmath
    {
        public static void init()
        {
            one<byte>();
            one<sbyte>();        
            one<short>();
            one<ushort>();
            one<int>();
            one<uint>();
            one<long>();
            one<ulong>();
            one<float>();
            one<double>();
        }

        abstract class Add<T>
            where T : struct
        {
            public static readonly Add<T> TheOnly = Instantiate();

            static Add<T> Instantiate()
            {
                var kind = PrimalKinds.kind<T>(); 
                if(kind == PrimalKind.float32)
                {
                    var instance = new AddF32();
                    return Unsafe.As<AddF32, Add<T>>(ref instance);
                }
                else if(kind == PrimalKind.float64)
                {
                    var instance = new AddF64();
                    return Unsafe.As<AddF64, Add<T>>(ref instance);
                }
                else if(kind == PrimalKind.uint64)
                {
                    var instance = new AddU64();
                    return Unsafe.As<AddU64, Add<T>>(ref instance);
                }
                else if(kind == PrimalKind.int64)
                {
                    var instance = new AddI64();
                    return Unsafe.As<AddI64, Add<T>>(ref instance);
                }
                else if(kind == PrimalKind.uint32)
                {
                    var instance = new AddU32();
                    return Unsafe.As<AddU32, Add<T>>(ref instance);
                }
                else if(kind == PrimalKind.int32)
                {
                    var instance = new AddI32();
                    return Unsafe.As<AddI32, Add<T>>(ref instance);
                }
                else 
                    throw unsupported(kind);
            }

            sealed class AddI32 : Add<int>
            {
                public override int apply(int lhs, int rhs)
                    => lhs + rhs;
            }

            sealed class AddU32 : Add<uint>
            {
                public override uint apply(uint lhs, uint rhs)
                    => lhs + rhs;
            }

            sealed class AddI64 : Add<long>
            {
                public override long apply(long lhs, long rhs)
                    => lhs + rhs;
            }

            sealed class AddU64 : Add<ulong>
            {
                public override ulong apply(ulong lhs, ulong rhs)
                    => lhs + rhs;
            }

            sealed class AddF32 : Add<float>
            {
                public override float apply(float lhs, float rhs)
                    => lhs + rhs;
            }

            sealed class AddF64 : Add<double>
            {
                public override double apply(double lhs, double rhs)
                    => lhs + rhs;
            }

            public abstract T apply(T lhs, T rhs);

        }
        
        public static Span<T> scale<T>(ReadOnlySpan<T> lhs, T factor, Span<T> dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    math.scale(int8(lhs), int8(factor), int8(dst));
                break;
                case PrimalKind.uint8:
                    math.scale(uint8(lhs), uint8(factor), uint8(dst));
                break;
                case PrimalKind.int16:
                    math.scale(int16(lhs), int16(factor), int16(dst));
                break;
                case PrimalKind.uint16:
                    math.scale(uint16(lhs), uint16(factor), uint16(dst));
                break;
                case PrimalKind.int32:
                    math.scale(int32(lhs), int32(factor), int32(dst));
                break;
                case PrimalKind.uint32:
                    math.scale(uint32(lhs), uint32(factor), uint32(dst));
                break;
                case PrimalKind.int64:
                    math.scale(int64(lhs), int64(factor), int64(dst));
                break;
                case PrimalKind.uint64:
                    math.scale(uint64(lhs), uint64(factor), uint64(dst));
                break;
                case PrimalKind.float32:
                      math.scale(float32(lhs), float32(factor), float32(dst));
                break;
                case PrimalKind.float64:
                    math.scale(float64(lhs), float64(factor), float64(dst));
                break;
                default:
                    throw unsupported(kind);                
            }
            return dst;            
        }

 
    }
}