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
        public static Span<T> sub<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T :  struct
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    return subI8(lhs,rhs,dst);
                case PrimalKind.uint8:
                    return subU8(lhs,rhs,dst);
                case PrimalKind.int16:
                    return subI16(lhs,rhs,dst);
                case PrimalKind.uint16:
                    return subU16(lhs,rhs,dst);
                case PrimalKind.int32:
                    return subI32(lhs,rhs,dst);
                case PrimalKind.uint32:
                    return subU32(lhs,rhs,dst);
                case PrimalKind.int64:
                    return subI64(lhs,rhs,dst);
                case PrimalKind.uint64:
                    return subU64(lhs,rhs,dst);
                case PrimalKind.float32:
                    return subF32(lhs,rhs,dst);
                case PrimalKind.float64:
                    return subF64(lhs,rhs,dst);
                default:
                    throw unsupported(kind);                
            }
        }

        [MethodImpl(NotInline)]
        public static Span<T> subI8<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T :  struct
        {
            var x = int8(lhs);
            var y = int8(rhs);
            var z = int8(dst);
            math.sub(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> subU8<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T :  struct
        {
            var x = uint8(lhs);
            var y = uint8(rhs);
            var z = uint8(dst);
            math.sub(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> subI16<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T :  struct
        {
            var x = int16(lhs);
            var y = int16(rhs);
            var z = int16(dst);
            math.sub(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> subU16<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T :  struct
        {
            var x = uint16(lhs);
            var y = uint16(rhs);
            var z = uint16(dst);
            math.sub(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> subI32<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T :  struct
        {
            var x = int32(lhs);
            var y = int32(rhs);
            var z = int32(dst);
            math.sub(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> subU32<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T :  struct
        {
            var x = uint32(lhs);
            var y = uint32(rhs);
            var z = uint32(dst);
            math.sub(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> subI64<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T :  struct
        {
            var x = int64(lhs);
            var y = int64(rhs);
            var z = int64(dst);
            math.sub(x,y,z);
            return dst;
        }


        [MethodImpl(NotInline)]
        public static Span<T> subU64<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T :  struct
        {
            var x = uint64(lhs);
            var y = uint64(rhs);
            var z = uint64(dst);
            math.sub(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> subF32<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T :  struct
        {
            var x = float32(lhs);
            var y = float32(rhs);
            var z = float32(dst);
            math.sub(x,y,z);
            return dst;
        }


        [MethodImpl(NotInline)]
        public static Span<T> subF64<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T :  struct
        {
            var x = float64(lhs);
            var y = float64(rhs);
            var z = float64(dst);
            math.sub(x,y,z);
            return dst;
        }

    }

}