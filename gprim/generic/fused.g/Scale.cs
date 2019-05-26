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
    
    
    
    using static zfunc;    
    using static As;

    public static partial class fused
    {
        [MethodImpl(NotInline)]
        public static Span<T> scale<T>(ReadOnlySpan<T> lhs, T factor, Span<T> dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    return scaleI8(lhs, factor, dst);
                case PrimalKind.uint8:
                    return scaleU8(lhs, factor, dst);
                case PrimalKind.int16:
                    return scaleI16(lhs, factor, dst);
                case PrimalKind.uint16:
                    return scaleU16(lhs, factor, dst);
                case PrimalKind.int32:
                    return scaleI32(lhs, factor, dst);
                case PrimalKind.uint32:
                    return scaleU32(lhs, factor, dst);
                case PrimalKind.int64:
                    return scaleI64(lhs, factor, dst);
                case PrimalKind.uint64:
                    return scaleU64(lhs, factor, dst);
                case PrimalKind.float32:
                    return scaleF32(lhs, factor, dst);
                case PrimalKind.float64:
                    return scaleF64(lhs, factor, dst);
                default:
                    throw unsupported(kind);                
            }
        }

        [MethodImpl(NotInline)]
        public static Span<T> scaleI8<T>(ReadOnlySpan<T> lhs, T factor, Span<T> dst)
            where T : struct
        {
            math.scale(int8(lhs), int8(factor), int8(dst));
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> scaleU8<T>(ReadOnlySpan<T> lhs, T factor, Span<T> dst)
            where T : struct
        {
            math.scale(uint8(lhs), uint8(factor), uint8(dst));
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> scaleI16<T>(ReadOnlySpan<T> lhs, T factor, Span<T> dst)
            where T : struct
        {
            math.scale(int16(lhs), int16(factor), int16(dst));
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> scaleU16<T>(ReadOnlySpan<T> lhs, T factor, Span<T> dst)
            where T : struct
        {
            math.scale(uint16(lhs), uint16(factor), uint16(dst));
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> scaleI32<T>(ReadOnlySpan<T> lhs, T factor, Span<T> dst)
            where T : struct
        {
            math.scale(int32(lhs), int32(factor), int32(dst));
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> scaleU32<T>(ReadOnlySpan<T> lhs, T factor, Span<T> dst)
            where T : struct
        {
            math.scale(uint32(lhs), uint32(factor), uint32(dst));
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> scaleI64<T>(ReadOnlySpan<T> lhs, T factor, Span<T> dst)
            where T : struct
        {
            math.scale(int64(lhs), int64(factor), int64(dst));
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> scaleU64<T>(ReadOnlySpan<T> lhs, T factor, Span<T> dst)
            where T : struct
        {
            math.scale(uint64(lhs), uint64(factor), uint64(dst));
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> scaleF32<T>(ReadOnlySpan<T> lhs, T factor, Span<T> dst)
            where T : struct
        {
            math.scale(float32(lhs), float32(factor), float32(dst));
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> scaleF64<T>(ReadOnlySpan<T> lhs, T factor, Span<T> dst)
            where T : struct
        {
            math.scale(float64(lhs), float64(factor), float64(dst));
            return dst;
        }
    }
}