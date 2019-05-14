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
        public static Span<T> abs<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    return absI8(src,dst);
                case PrimalKind.int16:
                    return absI16(src, dst);
                case PrimalKind.int32:
                    return absI32(src, dst);
                case PrimalKind.int64:
                    return absI64(src, dst);
                case PrimalKind.float32:
                    return absF32(src, dst);
                case PrimalKind.float64:
                    return absF64(src, dst);
                default:
                    throw unsupported(kind);                
            }
        }

        [MethodImpl(NotInline)]
        public static Span<T> absI8<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            var x = int8(src);
            var z = int8(dst);
            math.abs(x,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> absI16<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            var x = int16(src);
            var z = int16(dst);
            math.abs(x,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> absI32<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            var x = int32(src);
            var z = int32(dst);
            math.abs(x,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> absI64<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            var x = int64(src);
            var z = int64(dst);
            math.abs(x,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> absF32<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            var x = float32(src);
            var z = float32(dst);
            math.abs(x,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> absF64<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            var x = float64(src);
            var z = float64(dst);
            math.abs(x,z);
            return dst;
        }
    }
}