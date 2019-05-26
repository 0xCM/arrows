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
        public static Span<T> add<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    return addI8(lhs,rhs,dst);
                case PrimalKind.uint8:
                    return addU8(lhs,rhs,dst);
                case PrimalKind.int16:
                    return addI16(lhs,rhs,dst);
                case PrimalKind.uint16:
                    return addU16(lhs,rhs,dst);
                case PrimalKind.int32:
                    return addI32(lhs,rhs,dst);
                case PrimalKind.uint32:
                    return addU32(lhs,rhs,dst);
                case PrimalKind.int64:
                    return addI64(lhs,rhs,dst);
                case PrimalKind.uint64:
                    return addU64(lhs,rhs,dst);
                case PrimalKind.float32:
                    return addF32(lhs,rhs,dst);
                case PrimalKind.float64:
                    return addF64(lhs,rhs,dst);
                default:
                    throw unsupported(kind);                
            }
        }

        [MethodImpl(NotInline)]
        public static ref Span<T> add<T>(ref Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    return ref addI8(ref lhs,rhs);
                case PrimalKind.uint8:
                    return ref addU8(ref lhs,rhs);
                case PrimalKind.int16:
                    return ref addI16(ref lhs,rhs);
                case PrimalKind.uint16:
                    return ref addU16(ref lhs,rhs);
                case PrimalKind.int32:
                    return ref addI32(ref lhs,rhs);
                case PrimalKind.uint32:
                    return ref addU32(ref lhs,rhs);
                case PrimalKind.int64:
                    return ref addI64(ref lhs,rhs);
                case PrimalKind.uint64:
                    return ref addU64(ref lhs,rhs);
                case PrimalKind.float32:
                    return ref addF32(ref lhs,rhs);
                case PrimalKind.float64:
                    return ref addF64(ref lhs,rhs);
                default:
                    throw unsupported(kind);                
            }
        }

        [MethodImpl(NotInline)]
        static Span<T> addI8<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            var x = int8(lhs);
            var y = int8(rhs);
            var z = int8(dst);
            math.add(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        static Span<T> addU8<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            var x = uint8(lhs);
            var y = uint8(rhs);
            var z = uint8(dst);
            math.add(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        static Span<T> addI16<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            var x = int16(lhs);
            var y = int16(rhs);
            var z = int16(dst);
            math.add(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        static Span<T> addU16<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            var x = uint16(lhs);
            var y = uint16(rhs);
            var z = uint16(dst);
            math.add(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        static Span<T> addI32<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            var x = int32(lhs);
            var y = int32(rhs);
            var z = int32(dst);
            math.add(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        static Span<T> addU32<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            var x = uint32(lhs);
            var y = uint32(rhs);
            var z = uint32(dst);
            math.add(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        static Span<T> addI64<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            var x = int64(lhs);
            var y = int64(rhs);
            var z = int64(dst);
            math.add(x,y,z);
            return dst;
        }


        [MethodImpl(NotInline)]
        static Span<T> addU64<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            var x = uint64(lhs);
            var y = uint64(rhs);
            var z = uint64(dst);
            math.add(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        static Span<T> addF32<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            var x = float32(lhs);
            var y = float32(rhs);
            var z = float32(dst);
            math.add(x,y,z);
            return dst;
        }


        [MethodImpl(NotInline)]
        static Span<T> addF64<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : struct
        {
            var x = float64(lhs);
            var y = float64(rhs);
            var z = float64(dst);
            math.add(x,y,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        static ref Span<T> addI8<T>(ref Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            math.add(int8(lhs),int8(rhs));
            return ref lhs;
        }

        [MethodImpl(NotInline)]
        static ref Span<T> addU8<T>(ref Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            math.add(uint8(lhs),uint8(rhs));
            return ref lhs;
        }

        [MethodImpl(NotInline)]
        static ref Span<T> addI16<T>(ref Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            math.add(int16(lhs), int16(rhs));
            return ref lhs;
        }

        [MethodImpl(NotInline)]
        static ref Span<T> addU16<T>(ref Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            math.add(uint16(lhs), uint16(rhs));
            return ref lhs;
        }

        [MethodImpl(NotInline)]
        static ref Span<T> addI32<T>(ref Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            math.add(int32(lhs),int32(rhs));
            return ref lhs;
        }

        [MethodImpl(NotInline)]
        static ref Span<T> addU32<T>(ref Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            math.add(uint32(lhs),uint32(rhs));
            return ref lhs;
        }

        [MethodImpl(NotInline)]
        static ref Span<T> addI64<T>(ref Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            math.add(int64(lhs),int64(rhs));
            return ref lhs;
        }


        [MethodImpl(NotInline)]
        static ref Span<T> addU64<T>(ref Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            math.add(uint64(lhs),uint64(rhs));
            return ref lhs;
        }

        [MethodImpl(NotInline)]
        static ref Span<T> addF32<T>(ref Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            math.add(float32(lhs),float32(rhs));
            return ref lhs;
        }

        [MethodImpl(NotInline)]
        static ref Span<T> addF64<T>(ref Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            math.add(float64(lhs),float64(rhs));
            return ref lhs;
        }
    }
}