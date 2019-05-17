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
        public static ref Span<T> sub<T>(ref Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    return ref subI8(ref lhs,rhs);
                case PrimalKind.uint8:
                    return ref subU8(ref lhs,rhs);
                case PrimalKind.int16:
                    return ref subI16(ref lhs,rhs);
                case PrimalKind.uint16:
                    return ref subU16(ref lhs,rhs);
                case PrimalKind.int32:
                    return ref subI32(ref lhs,rhs);
                case PrimalKind.uint32:
                    return ref subU32(ref lhs,rhs);
                case PrimalKind.int64:
                    return ref subI64(ref lhs,rhs);
                case PrimalKind.uint64:
                    return ref subU64(ref lhs,rhs);
                case PrimalKind.float32:
                    return ref subF32(ref lhs,rhs);
                case PrimalKind.float64:
                    return ref subF64(ref lhs,rhs);
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

        [MethodImpl(NotInline)]
        static ref Span<T> subI8<T>(ref Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            math.sub(int8(lhs),int8(rhs));
            return ref lhs;
        }

        [MethodImpl(NotInline)]
        static ref Span<T> subU8<T>(ref Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            math.sub(uint8(lhs),uint8(rhs));
            return ref lhs;
        }

        [MethodImpl(NotInline)]
        static ref Span<T> subI16<T>(ref Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            math.sub(int16(lhs), int16(rhs));
            return ref lhs;
        }

        [MethodImpl(NotInline)]
        static ref Span<T> subU16<T>(ref Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            math.sub(uint16(lhs), uint16(rhs));
            return ref lhs;
        }

        [MethodImpl(NotInline)]
        static ref Span<T> subI32<T>(ref Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            math.sub(int32(lhs),int32(rhs));
            return ref lhs;
        }

        [MethodImpl(NotInline)]
        static ref Span<T> subU32<T>(ref Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            math.sub(uint32(lhs),uint32(rhs));
            return ref lhs;
        }

        [MethodImpl(NotInline)]
        static ref Span<T> subI64<T>(ref Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            math.sub(int64(lhs),int64(rhs));
            return ref lhs;
        }


        [MethodImpl(NotInline)]
        static ref Span<T> subU64<T>(ref Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            math.sub(uint64(lhs),uint64(rhs));
            return ref lhs;
        }

        [MethodImpl(NotInline)]
        static ref Span<T> subF32<T>(ref Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            math.sub(float32(lhs),float32(rhs));
            return ref lhs;
        }

        [MethodImpl(NotInline)]
        static ref Span<T> subF64<T>(ref Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct
        {
            math.sub(float64(lhs),float64(rhs));
            return ref lhs;
        } 
    }

}