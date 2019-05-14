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
        public static Span<bool> gt<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    return gtI8(lhs,rhs,dst);
                case PrimalKind.uint8:
                    return gtU8(lhs,rhs,dst);
                case PrimalKind.int16:
                    return gtI16(lhs,rhs,dst);
                case PrimalKind.uint16:
                    return gtU16(lhs,rhs,dst);
                case PrimalKind.int32:
                    return gtI32(lhs,rhs,dst);
                case PrimalKind.uint32:
                    return gtU32(lhs,rhs,dst);
                case PrimalKind.int64:
                    return gtI64(lhs,rhs,dst);
                case PrimalKind.uint64:
                    return gtU64(lhs,rhs,dst);
                case PrimalKind.float32:
                    return gtF32(lhs,rhs,dst);
                case PrimalKind.float64:
                    return gtF64(lhs,rhs,dst);
                default:
                    throw unsupported(kind);                
            }
        }

        [MethodImpl(NotInline)]
        public static Span<bool> gtI8<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            var x = int8(lhs);
            var y = int8(rhs);
            var z = dst;
            math.eq(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> gtU8<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            var x = uint8(lhs);
            var y = uint8(rhs);
            var z = dst;
            math.eq(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> gtI16<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            var x = int16(lhs);
            var y = int16(rhs);
            var z = dst;
            math.eq(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> gtU16<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            var x = uint16(lhs);
            var y = uint16(rhs);
            var z = dst;
            math.eq(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> gtI32<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            var x = int32(lhs);
            var y = int32(rhs);
            var z = dst;
            math.eq(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> gtU32<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            var x = uint32(lhs);
            var y = uint32(rhs);
            var z = dst;
            math.eq(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> gtI64<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            var x = int64(lhs);
            var y = int64(rhs);
            var z = dst;
            math.eq(x,y,z);
            return dst;
        }


        [MethodImpl(NotInline)]
        public static Span<bool> gtU64<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            var x = uint64(lhs);
            var y = uint64(rhs);
            var z = dst;
            math.eq(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> gtF32<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            var x = float32(lhs);
            var y = float32(rhs);
            var z = dst;
            math.eq(x,y,z);
            return dst;
        }


        [MethodImpl(NotInline)]
        public static Span<bool> gtF64<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
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