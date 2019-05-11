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
    using static As;

    public static partial class fused
    {
        [MethodImpl(NotInline)]
        public static Span<bool> gteq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    return gteqI8(lhs,rhs,dst);
                case PrimalKind.uint8:
                    return gteqU8(lhs,rhs,dst);
                case PrimalKind.int16:
                    return gteqI16(lhs,rhs,dst);
                case PrimalKind.uint16:
                    return gteqU16(lhs,rhs,dst);
                case PrimalKind.int32:
                    return gteqI32(lhs,rhs,dst);
                case PrimalKind.uint32:
                    return gteqU32(lhs,rhs,dst);
                case PrimalKind.int64:
                    return gteqI64(lhs,rhs,dst);
                case PrimalKind.uint64:
                    return gteqU64(lhs,rhs,dst);
                case PrimalKind.float32:
                    return gteqF32(lhs,rhs,dst);
                case PrimalKind.float64:
                    return gteqF64(lhs,rhs,dst);
                default:
                    throw unsupported(kind);                
            }
        }

        [MethodImpl(NotInline)]
        public static Span<bool> gteqI8<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct, IEquatable<T>
        {
            var x = int8(lhs);
            var y = int8(rhs);
            var z = dst;
            math.eq(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> gteqU8<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct, IEquatable<T>
        {
            var x = uint8(lhs);
            var y = uint8(rhs);
            var z = dst;
            math.eq(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> gteqI16<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct, IEquatable<T>
        {
            var x = int16(lhs);
            var y = int16(rhs);
            var z = dst;
            math.eq(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> gteqU16<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct, IEquatable<T>
        {
            var x = uint16(lhs);
            var y = uint16(rhs);
            var z = dst;
            math.eq(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> gteqI32<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct, IEquatable<T>
        {
            var x = int32(lhs);
            var y = int32(rhs);
            var z = dst;
            math.eq(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> gteqU32<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct, IEquatable<T>
        {
            var x = uint32(lhs);
            var y = uint32(rhs);
            var z = dst;
            math.eq(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> gteqI64<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct, IEquatable<T>
        {
            var x = int64(lhs);
            var y = int64(rhs);
            var z = dst;
            math.eq(x,y,z);
            return dst;
        }


        [MethodImpl(NotInline)]
        public static Span<bool> gteqU64<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct, IEquatable<T>
        {
            var x = uint64(lhs);
            var y = uint64(rhs);
            var z = dst;
            math.eq(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> gteqF32<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct, IEquatable<T>
        {
            var x = float32(lhs);
            var y = float32(rhs);
            var z = dst;
            math.eq(x,y,z);
            return dst;
        }


        [MethodImpl(NotInline)]
        public static Span<bool> gteqF64<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct, IEquatable<T>
        {
            var x = float64(lhs);
            var y = float64(rhs);
            var z = dst;
            math.eq(x,y,z);
            return dst;
        }

    }

}