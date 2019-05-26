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
        public static Span<bool> eq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    return eqI8(lhs,rhs,dst);
                case PrimalKind.uint8:
                    return eqU8(lhs,rhs,dst);
                case PrimalKind.int16:
                    return eqI16(lhs,rhs,dst);
                case PrimalKind.uint16:
                    return eqU16(lhs,rhs,dst);
                case PrimalKind.int32:
                    return eqI32(lhs,rhs,dst);
                case PrimalKind.uint32:
                    return eqU32(lhs,rhs,dst);
                case PrimalKind.int64:
                    return eqI64(lhs,rhs,dst);
                case PrimalKind.uint64:
                    return eqU64(lhs,rhs,dst);
                case PrimalKind.float32:
                    return eqF32(lhs,rhs,dst);
                case PrimalKind.float64:
                    return eqF64(lhs,rhs,dst);
                default:
                    throw unsupported(kind);                
            }
        }

        [MethodImpl(Inline)]
        public static Span<bool> eq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var dst = span<bool>(length(lhs,rhs));
            return fused.eq(lhs,rhs,dst);
        }

        [MethodImpl(NotInline)]
        public static Span<bool> eqI8<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            var x = int8(lhs);
            var y = int8(rhs);
            var z = dst;
            math.eq(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> eqU8<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            var x = uint8(lhs);
            var y = uint8(rhs);
            var z = dst;
            math.eq(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> eqI16<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            var x = int16(lhs);
            var y = int16(rhs);
            var z = dst;
            math.eq(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> eqU16<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            var x = uint16(lhs);
            var y = uint16(rhs);
            var z = dst;
            math.eq(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> eqI32<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            var x = int32(lhs);
            var y = int32(rhs);
            var z = dst;
            math.eq(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> eqU32<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            var x = uint32(lhs);
            var y = uint32(rhs);
            var z = dst;
            math.eq(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> eqI64<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            var x = int64(lhs);
            var y = int64(rhs);
            var z = dst;
            math.eq(x,y,z);
            return dst;
        }


        [MethodImpl(NotInline)]
        public static Span<bool> eqU64<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            var x = uint64(lhs);
            var y = uint64(rhs);
            var z = dst;
            math.eq(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> eqF32<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            var x = float32(lhs);
            var y = float32(rhs);
            var z = dst;
            math.eq(x,y,z);
            return dst;
        }


        [MethodImpl(NotInline)]
        public static Span<bool> eqF64<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            var x = float64(lhs);
            var y = float64(rhs);
            var z = dst;
            math.eq(x,y,z);
            return dst;
        }

    }

}