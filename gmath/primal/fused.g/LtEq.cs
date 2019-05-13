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
        public static Span<bool> lteq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    return lteqI8(lhs,rhs,dst);
                case PrimalKind.uint8:
                    return lteqU8(lhs,rhs,dst);
                case PrimalKind.int16:
                    return lteqI16(lhs,rhs,dst);
                case PrimalKind.uint16:
                    return lteqU16(lhs,rhs,dst);
                case PrimalKind.int32:
                    return lteqI32(lhs,rhs,dst);
                case PrimalKind.uint32:
                    return lteqU32(lhs,rhs,dst);
                case PrimalKind.int64:
                    return lteqI64(lhs,rhs,dst);
                case PrimalKind.uint64:
                    return lteqU64(lhs,rhs,dst);
                case PrimalKind.float32:
                    return lteqF32(lhs,rhs,dst);
                case PrimalKind.float64:
                    return lteqF64(lhs,rhs,dst);
                default:
                    throw unsupported(kind);                
            }
        }

        [MethodImpl(NotInline)]
        public static Span<bool> lteqI8<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct, IEquatable<T>
        {
            var x = int8(lhs);
            var y = int8(rhs);
            var z = dst;
            math.eq(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> lteqU8<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct, IEquatable<T>
        {
            var x = uint8(lhs);
            var y = uint8(rhs);
            var z = dst;
            math.eq(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> lteqI16<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct, IEquatable<T>
        {
            var x = int16(lhs);
            var y = int16(rhs);
            var z = dst;
            math.eq(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> lteqU16<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct, IEquatable<T>
        {
            var x = uint16(lhs);
            var y = uint16(rhs);
            var z = dst;
            math.eq(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> lteqI32<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct, IEquatable<T>
        {
            var x = int32(lhs);
            var y = int32(rhs);
            var z = dst;
            math.eq(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> lteqU32<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct, IEquatable<T>
        {
            var x = uint32(lhs);
            var y = uint32(rhs);
            var z = dst;
            math.eq(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> lteqI64<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct, IEquatable<T>
        {
            var x = int64(lhs);
            var y = int64(rhs);
            var z = dst;
            math.eq(x,y,z);
            return dst;
        }


        [MethodImpl(NotInline)]
        public static Span<bool> lteqU64<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct, IEquatable<T>
        {
            var x = uint64(lhs);
            var y = uint64(rhs);
            var z = dst;
            math.eq(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> lteqF32<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct, IEquatable<T>
        {
            var x = float32(lhs);
            var y = float32(rhs);
            var z = dst;
            math.eq(x,y,z);
            return dst;
        }


        [MethodImpl(NotInline)]
        public static Span<bool> lteqF64<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
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