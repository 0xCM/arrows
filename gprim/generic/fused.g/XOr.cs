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
        public static Span<T> xor<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    return xorI8(lhs,rhs,dst);
                case PrimalKind.uint8:
                    return xorU8(lhs,rhs,dst);
                case PrimalKind.int16:
                    return xorI16(lhs,rhs,dst);
                case PrimalKind.uint16:
                    return xorU16(lhs,rhs,dst);
                case PrimalKind.int32:
                    return xorI32(lhs,rhs,dst);
                case PrimalKind.uint32:
                    return xorU32(lhs,rhs,dst);
                case PrimalKind.int64:
                    return xorI64(lhs,rhs,dst);
                case PrimalKind.uint64:
                    return xorU64(lhs,rhs,dst);
                default:
                    throw unsupported(kind);                
            }
        }

        [MethodImpl(NotInline)]
        public static Span<T> xorI8<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            var x = int8(lhs);
            var y = int8(rhs);
            var z = int8(dst);
            math.xor(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> xorU8<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            var x = uint8(lhs);
            var y = uint8(rhs);
            var z = uint8(dst);
            math.xor(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> xorI16<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            var x = int16(lhs);
            var y = int16(rhs);
            var z = int16(dst);
            math.xor(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> xorU16<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            var x = uint16(lhs);
            var y = uint16(rhs);
            var z = uint16(dst);
            math.xor(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> xorI32<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            var x = int32(lhs);
            var y = int32(rhs);
            var z = int32(dst);
            math.xor(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> xorU32<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            var x = uint32(lhs);
            var y = uint32(rhs);
            var z = uint32(dst);
            math.xor(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> xorI64<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            var x = int64(lhs);
            var y = int64(rhs);
            var z = int64(dst);
            math.xor(x,y,z);
            return dst;
        }


        [MethodImpl(NotInline)]
        public static Span<T> xorU64<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            var x = uint64(lhs);
            var y = uint64(rhs);
            var z = uint64(dst);
            math.xor(x,y,z);
            return dst;
        }

    }
}