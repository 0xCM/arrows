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
        public static Span<T> negate<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct, IEquatable<T>
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    return negateI8(src,dst);
                case PrimalKind.int16:
                    return negateI16(src, dst);
                case PrimalKind.int32:
                    return negateI32(src, dst);
                case PrimalKind.int64:
                    return negateI64(src, dst);
                case PrimalKind.float32:
                    return negateF32(src, dst);
                case PrimalKind.float64:
                    return negateF64(src, dst);
                default:
                    throw unsupported(kind);                
            }
        }

        [MethodImpl(NotInline)]
        public static Span<T> negateI8<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct, IEquatable<T>
        {
            var x = int8(src);
            var z = int8(dst);
            math.negate(x,z);
            return dst;
        }


        [MethodImpl(NotInline)]
        public static Span<T> negateI16<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct, IEquatable<T>
        {
            var x = int16(src);
            var z = int16(dst);
            math.negate(x,z);
            return dst;
        }


        [MethodImpl(NotInline)]
        public static Span<T> negateI32<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct, IEquatable<T>
        {
            var x = int32(src);
            var z = int32(dst);
            math.negate(x,z);
            return dst;
        }


        [MethodImpl(NotInline)]
        public static Span<T> negateI64<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct, IEquatable<T>
        {
            var x = int64(src);
            var z = int64(dst);
            math.negate(x,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> negateF32<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct, IEquatable<T>
        {
            var x = float32(src);
            var z = float32(dst);
            math.negate(x,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> negateF64<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct, IEquatable<T>
        {
            var x = float64(src);
            var z = float64(dst);
            math.negate(x,z);
            return dst;
        }

    }
}