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

        public  static string hexstring<T>(T src, bool zpad = true, bool specifier = true)
            where T : struct
        {
            var digits = string.Empty;

            if(typeof(T) == typeof(sbyte))
                digits = As.int8(src).ToString("x");
            else if(typeof(T) == typeof(byte))
                digits = As.uint8(src).ToString("x");
            else if(typeof(T) == typeof(short))
                digits = As.int16(src).ToString("x");
            else if(typeof(T) == typeof(ushort))
                digits = As.uint16(src).ToString("x");
            else if(typeof(T) == typeof(uint))
                digits = As.int32(src).ToString("x");
            else if(typeof(T) == typeof(uint))
                digits = As.uint32(src).ToString("x");
            else if(typeof(T) == typeof(long))
                digits = As.int64(src).ToString("x");
            else if(typeof(T) == typeof(ulong))
                digits = As.uint64(src).ToString("x");
            else if(typeof(T) == typeof(float))
                digits = As.float32(src).ToBits().ToString("x");
            else if(typeof(T) == typeof(double))
                digits = As.float64(src).ToBits().ToString("x");
            else
                throw unsupported<T>();

            var spec = specifier ? "0x" : string.Empty;
            return zpad ? (spec + digits) : (spec + digits.PadLeft(SizeOf<T>.Size * 2, '0'));
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