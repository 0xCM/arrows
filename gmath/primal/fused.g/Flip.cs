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
        public static Span<T> flip<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    return flipI8(src,dst);
                case PrimalKind.uint8:
                    return flipU8(src, dst);
                case PrimalKind.int16:
                    return flipI16(src, dst);
                case PrimalKind.uint16:
                    return flipU16(src, dst);
                case PrimalKind.int32:
                    return flipI32(src, dst);
                case PrimalKind.uint32:
                    return flipU32(src, dst);
                case PrimalKind.int64:
                    return flipI64(src, dst);
                case PrimalKind.uint64:
                    return flipU64(src, dst);
                default:
                    throw unsupported(kind);                
            }
        }

        [MethodImpl(NotInline)]
        public static Span<T> flipI8<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct, IEquatable<T>
        {
            var x = int8(src);
            var z = int8(dst);
            math.flip(x,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> flipU8<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct, IEquatable<T>
        {
            var x = uint8(src);
            var z = uint8(dst);
            math.flip(x,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> flipI16<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct, IEquatable<T>
        {
            var x = int16(src);
            var z = int16(dst);
            math.flip(x,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> flipU16<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct, IEquatable<T>
        {
            var x = uint16(src);
            var z = uint16(dst);
            math.flip(x,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> flipI32<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct, IEquatable<T>
        {
            var x = int32(src);
            var z = int32(dst);
            math.flip(x,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> flipU32<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct, IEquatable<T>
        {
            var x = uint32(src);
            var z = uint32(dst);
            math.flip(x,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> flipI64<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct, IEquatable<T>
        {
            var x = int64(src);
            var z = int64(dst);
            math.flip(x,z);
            return dst;
        }


        [MethodImpl(NotInline)]
        public static Span<T> flipU64<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct, IEquatable<T>
        {
            var x = uint64(src);
            var z = uint64(dst);
            math.flip(x,z);
            return dst;
        }

    }
}