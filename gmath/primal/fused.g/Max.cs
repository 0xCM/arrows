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
        public static T max<T>(ReadOnlySpan<T> src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    return maxI8(src);
                case PrimalKind.uint8:
                    return maxU8(src);
                case PrimalKind.int16:
                    return maxI16(src);
                case PrimalKind.uint16:
                    return maxU16(src);
                case PrimalKind.int32:
                    return maxI32(src);
                case PrimalKind.uint32:
                    return maxU32(src);
                case PrimalKind.int64:
                    return maxI64(src);
                case PrimalKind.uint64:
                    return maxU64(src);
                case PrimalKind.float32:
                    return maxF32(src);
                case PrimalKind.float64:
                    return maxF64(src);
                default:
                    throw unsupported(kind);                
            }
        }

        [MethodImpl(NotInline)]
        public static T maxI8<T>(ReadOnlySpan<T> src)
            where T : struct
            => generic<T>(math.max(int8(src)));

        [MethodImpl(NotInline)]
        public static T maxU8<T>(ReadOnlySpan<T> src)
            where T : struct
            => generic<T>(math.max(uint8(src)));

        [MethodImpl(NotInline)]
        public static T maxI16<T>(ReadOnlySpan<T> src)
            where T : struct
            => generic<T>(math.max(int16(src)));

        [MethodImpl(NotInline)]
        public static T maxU16<T>(ReadOnlySpan<T> src)
            where T : struct
            => generic<T>(math.max(uint16(src)));

        [MethodImpl(NotInline)]
        public static T maxI32<T>(ReadOnlySpan<T> src)
            where T : struct
            => generic<T>(math.max(int32(src)));

        [MethodImpl(NotInline)]
        public static T maxU32<T>(ReadOnlySpan<T> src)
            where T : struct
            => generic<T>(math.max(uint32(src)));

        [MethodImpl(NotInline)]
        public static T maxI64<T>(ReadOnlySpan<T> src)
            where T : struct
            => generic<T>(math.max(int64(src)));

        [MethodImpl(NotInline)]
        public static T maxU64<T>(ReadOnlySpan<T> src)
            where T : struct
            => generic<T>(math.max(uint64(src)));

        [MethodImpl(NotInline)]
        public static T maxF32<T>(ReadOnlySpan<T> src)
            where T : struct
            => generic<T>(math.max(float32(src)));

        [MethodImpl(NotInline)]
        public static T maxF64<T>(ReadOnlySpan<T> src)
            where T : struct
            => generic<T>(math.max(float64(src)));

    }
}