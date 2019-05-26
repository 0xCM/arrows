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
        public static Span<T> abs<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    return absI8(src,dst);
                case PrimalKind.uint8:
                    src.CopyTo(dst);
                    return dst;
                case PrimalKind.int16:
                    return absI16(src, dst);
                case PrimalKind.uint16:
                    src.CopyTo(dst);
                    return dst;
                case PrimalKind.int32:
                    return absI32(src, dst);
                case PrimalKind.uint32:
                    src.CopyTo(dst);
                    return dst;
                case PrimalKind.int64:
                    return absI64(src, dst);
                case PrimalKind.uint64:
                    src.CopyTo(dst);
                    return dst;
                case PrimalKind.float32:
                    return absF32(src, dst);
                case PrimalKind.float64:
                    return absF64(src, dst);
                default:
                    throw unsupported(kind);                
            }
        }

        [MethodImpl(NotInline)]
        public static ref Span<T> abs<T>(ref Span<T> io)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    return ref absI8(ref io);
                case PrimalKind.uint8:
                    return ref io;
                case PrimalKind.int16:
                    return ref absI16(ref io);
                case PrimalKind.uint16:
                    return ref io;
                case PrimalKind.int32:
                    return ref absI32(ref io);
                case PrimalKind.uint32:
                    return ref io;
                case PrimalKind.int64:
                    return ref absI64(ref io);
                case PrimalKind.uint64:
                    return ref io;
                case PrimalKind.float32:
                    return ref absF32(ref io);
                case PrimalKind.float64:
                    return ref absF64(ref io);
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
 
        [MethodImpl(NotInline)]
        public static ref Span<T> absI8<T>(ref Span<T> io)
            where T : struct
        {
            var x = int8(io);
            math.abs(ref x);
            return ref io;
        }


        [MethodImpl(NotInline)]
        public static ref Span<T> absI16<T>(ref Span<T> io)
            where T : struct
        {
            var x = int16(io);
            math.abs(ref x);
            return ref io;
        }
        

        [MethodImpl(NotInline)]
        public static ref Span<T> absI32<T>(ref Span<T> io)
            where T : struct
        {
            var x = int32(io);
            math.abs(ref x);
            return ref io;
        }

        
        [MethodImpl(NotInline)]
        public static ref Span<T> absI64<T>(ref Span<T> io)
            where T : struct
        {
            var x = int64(io);
            math.abs(ref x);
            return ref io;
        }


        [MethodImpl(NotInline)]
        public static ref Span<T> absF32<T>(ref Span<T> io)
            where T : struct
        {
            var x = float32(io);
            math.abs(ref x);
            return ref io;
        }

        [MethodImpl(NotInline)]
        public static ref Span<T> absF64<T>(ref Span<T> io)
            where T : struct
        {
            var x = float64(io);
            math.abs(ref x);
            return ref io;
        }

    }
}