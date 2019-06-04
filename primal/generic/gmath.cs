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