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
        public static T min<T>(ReadOnlySpan<T> src)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    return minI8(src);
                case PrimalKind.uint8:
                    return minU8(src);
                case PrimalKind.int16:
                    return minI16(src);
                case PrimalKind.uint16:
                    return minU16(src);
                case PrimalKind.int32:
                    return minI32(src);
                case PrimalKind.uint32:
                    return minU32(src);
                case PrimalKind.int64:
                    return minI64(src);
                case PrimalKind.uint64:
                    return minU64(src);
                case PrimalKind.float32:
                    return minF32(src);
                case PrimalKind.float64:
                    return minF64(src);
                default:
                    throw unsupported(kind);                
            }
        }

        [MethodImpl(NotInline)]
        public static T minI8<T>(ReadOnlySpan<T> src)
            where T : struct
            => generic<T>(math.min(int8(src)));

        [MethodImpl(NotInline)]
        public static T minU8<T>(ReadOnlySpan<T> src)
            where T : struct
            => generic<T>(math.min(uint8(src)));

        [MethodImpl(NotInline)]
        public static T minI16<T>(ReadOnlySpan<T> src)
            where T : struct
            => generic<T>(math.min(int16(src)));

        [MethodImpl(NotInline)]
        public static T minU16<T>(ReadOnlySpan<T> src)
            where T : struct
            => generic<T>(math.min(uint16(src)));

        [MethodImpl(NotInline)]
        public static T minI32<T>(ReadOnlySpan<T> src)
            where T : struct
            => generic<T>(math.min(int32(src)));

        [MethodImpl(NotInline)]
        public static T minU32<T>(ReadOnlySpan<T> src)
            where T : struct
            => generic<T>(math.min(uint32(src)));

        [MethodImpl(NotInline)]
        public static T minI64<T>(ReadOnlySpan<T> src)
            where T : struct
            => generic<T>(math.min(int64(src)));

        [MethodImpl(NotInline)]
        public static T minU64<T>(ReadOnlySpan<T> src)
            where T : struct
            => generic<T>(math.min(uint64(src)));

        [MethodImpl(NotInline)]
        public static T minF32<T>(ReadOnlySpan<T> src)
            where T : struct
            => generic<T>(math.min(float32(src)));

        [MethodImpl(NotInline)]
        public static T minF64<T>(ReadOnlySpan<T> src)
            where T : struct
            => generic<T>(math.min(float64(src)));

    }
}