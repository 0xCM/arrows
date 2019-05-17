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
        public static Span<bool> neq<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    return neqI8(lhs,rhs,dst);
                case PrimalKind.uint8:
                    return neqU8(lhs,rhs,dst);
                case PrimalKind.int16:
                    return neqI16(lhs,rhs,dst);
                case PrimalKind.uint16:
                    return neqU16(lhs,rhs,dst);
                case PrimalKind.int32:
                    return neqI32(lhs,rhs,dst);
                case PrimalKind.uint32:
                    return neqU32(lhs,rhs,dst);
                case PrimalKind.int64:
                    return neqI64(lhs,rhs,dst);
                case PrimalKind.uint64:
                    return neqU64(lhs,rhs,dst);
                case PrimalKind.float32:
                    return neqF32(lhs,rhs,dst);
                case PrimalKind.float64:
                    return neqF64(lhs,rhs,dst);
                default:
                    throw unsupported(kind);                
            }
        }

        [MethodImpl(NotInline)]
        public static Span<bool> neqI8<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            var x = int8(lhs);
            var y = int8(rhs);
            var z = dst;
            math.neq(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> neqU8<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            var x = uint8(lhs);
            var y = uint8(rhs);
            var z = dst;
            math.neq(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> neqI16<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            var x = int16(lhs);
            var y = int16(rhs);
            var z = dst;
            math.neq(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> neqU16<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            var x = uint16(lhs);
            var y = uint16(rhs);
            var z = dst;
            math.neq(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> neqI32<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            var x = int32(lhs);
            var y = int32(rhs);
            var z = dst;
            math.neq(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> neqU32<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            var x = uint32(lhs);
            var y = uint32(rhs);
            var z = dst;
            math.neq(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> neqI64<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            var x = int64(lhs);
            var y = int64(rhs);
            var z = dst;
            math.neq(x,y,z);
            return dst;
        }


        [MethodImpl(NotInline)]
        public static Span<bool> neqU64<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            var x = uint64(lhs);
            var y = uint64(rhs);
            var z = dst;
            math.neq(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<bool> neqF32<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            var x = float32(lhs);
            var y = float32(rhs);
            var z = dst;
            math.neq(x,y,z);
            return dst;
        }


        [MethodImpl(NotInline)]
        public static Span<bool> neqF64<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<bool> dst)
            where T : struct
        {
            var x = float64(lhs);
            var y = float64(rhs);
            var z = dst;
            math.neq(x,y,z);
            return dst;
        }

    }

}