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
        public static Span<T> mul<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    return mulI8(lhs,rhs,dst);
                case PrimalKind.uint8:
                    return mulU8(lhs,rhs,dst);
                case PrimalKind.int16:
                    return mulI16(lhs,rhs,dst);
                case PrimalKind.uint16:
                    return mulU16(lhs,rhs,dst);
                case PrimalKind.int32:
                    return mulI32(lhs,rhs,dst);
                case PrimalKind.uint32:
                    return mulU32(lhs,rhs,dst);
                case PrimalKind.int64:
                    return mulI64(lhs,rhs,dst);
                case PrimalKind.uint64:
                    return mulU64(lhs,rhs,dst);
                case PrimalKind.float32:
                    return mulF32(lhs,rhs,dst);
                case PrimalKind.float64:
                    return mulF64(lhs,rhs,dst);
                default:
                    throw unsupported(kind);                
            }
        }

        [MethodImpl(NotInline)]
        public static Span<T> mulI8<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct, IEquatable<T>
        {
            var x = int8(lhs);
            var y = int8(rhs);
            var z = int8(dst);
            math.mul(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> mulU8<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct, IEquatable<T>
        {
            var x = uint8(lhs);
            var y = uint8(rhs);
            var z = uint8(dst);
            math.mul(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> mulI16<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct, IEquatable<T>
        {
            var x = int16(lhs);
            var y = int16(rhs);
            var z = int16(dst);
            math.mul(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> mulU16<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct, IEquatable<T>
        {
            var x = uint16(lhs);
            var y = uint16(rhs);
            var z = uint16(dst);
            math.mul(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> mulI32<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct, IEquatable<T>
        {
            var x = int32(lhs);
            var y = int32(rhs);
            var z = int32(dst);
            math.mul(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> mulU32<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct, IEquatable<T>
        {
            var x = uint32(lhs);
            var y = uint32(rhs);
            var z = uint32(dst);
            math.mul(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> mulI64<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct, IEquatable<T>
        {
            var x = int64(lhs);
            var y = int64(rhs);
            var z = int64(dst);
            math.mul(x,y,z);
            return dst;
        }


        [MethodImpl(NotInline)]
        public static Span<T> mulU64<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct, IEquatable<T>
        {
            var x = uint64(lhs);
            var y = uint64(rhs);
            var z = uint64(dst);
            math.mul(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> mulF32<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct, IEquatable<T>
        {
            var x = float32(lhs);
            var y = float32(rhs);
            var z = float32(dst);
            math.mul(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> mulF64<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct, IEquatable<T>
        {
            var x = float64(lhs);
            var y = float64(rhs);
            var z = float64(dst);
            math.mul(x,y,z);
            return dst;
        }
    }
}