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
    
    
    using static mfunc;
    using static zfunc;    
    using static As;

    public static partial class fused
    {
        [MethodImpl(NotInline)]
        public static Span<T> or<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    return orI8(lhs,rhs,dst);
                case PrimalKind.uint8:
                    return orU8(lhs,rhs,dst);
                case PrimalKind.int16:
                    return orI16(lhs,rhs,dst);
                case PrimalKind.uint16:
                    return orU16(lhs,rhs,dst);
                case PrimalKind.int32:
                    return orI32(lhs,rhs,dst);
                case PrimalKind.uint32:
                    return orU32(lhs,rhs,dst);
                case PrimalKind.int64:
                    return orI64(lhs,rhs,dst);
                case PrimalKind.uint64:
                    return orU64(lhs,rhs,dst);
                default:
                    throw unsupported(kind);                
            }
        }

        [MethodImpl(NotInline)]
        public static Span<T> orI8<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct, IEquatable<T>
        {
            var x = int8(lhs);
            var y = int8(rhs);
            var z = int8(dst);
            math.or(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> orU8<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct, IEquatable<T>
        {
            var x = uint8(lhs);
            var y = uint8(rhs);
            var z = uint8(dst);
            math.or(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> orI16<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct, IEquatable<T>
        {
            var x = int16(lhs);
            var y = int16(rhs);
            var z = int16(dst);
            math.or(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> orU16<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct, IEquatable<T>
        {
            var x = uint16(lhs);
            var y = uint16(rhs);
            var z = uint16(dst);
            math.or(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> orI32<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct, IEquatable<T>
        {
            var x = int32(lhs);
            var y = int32(rhs);
            var z = int32(dst);
            math.or(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> orU32<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct, IEquatable<T>
        {
            var x = uint32(lhs);
            var y = uint32(rhs);
            var z = uint32(dst);
            math.or(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> orI64<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct, IEquatable<T>
        {
            var x = int64(lhs);
            var y = int64(rhs);
            var z = int64(dst);
            math.or(x,y,z);
            return dst;
        }


        [MethodImpl(NotInline)]
        public static Span<T> orU64<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct, IEquatable<T>
        {
            var x = uint64(lhs);
            var y = uint64(rhs);
            var z = uint64(dst);
            math.or(x,y,z);
            return dst;
        }

    }
}