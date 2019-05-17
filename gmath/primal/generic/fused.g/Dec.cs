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
        public static Span<T> dec<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    return decI8(src,dst);
                case PrimalKind.uint8:
                    return decU8(src, dst);
                case PrimalKind.int16:
                    return decI16(src, dst);
                case PrimalKind.uint16:
                    return decU16(src, dst);
                case PrimalKind.int32:
                    return decI32(src, dst);
                case PrimalKind.uint32:
                    return decU32(src, dst);
                case PrimalKind.int64:
                    return decI64(src, dst);
                case PrimalKind.uint64:
                    return decU64(src, dst);
                case PrimalKind.float32:
                    return decF32(src, dst);
                case PrimalKind.float64:
                    return decF64(src, dst);
                default:
                    throw unsupported(kind);                
            }
        }

        [MethodImpl(NotInline)]
        public static ref Span<T> dec<T>(ref Span<T> io)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    return ref decI8(ref io);
                case PrimalKind.uint8:
                    return ref decU8(ref io);
                case PrimalKind.int16:
                    return ref decI16(ref io);
                case PrimalKind.uint16:
                    return ref decU16(ref io);
                case PrimalKind.int32:
                    return ref decI32(ref io);
                case PrimalKind.uint32:
                    return ref decU32(ref io);
                case PrimalKind.int64:
                    return ref decI64(ref io);
                case PrimalKind.uint64:
                    return ref decU64(ref io);
                case PrimalKind.float32:
                    return ref decF32(ref io);
                case PrimalKind.float64:
                    return ref decF64(ref io);
                default:
                    throw unsupported(kind);                
            }
        }


        [MethodImpl(NotInline)]
        public static Span<T> decI8<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            var x = int8(src);
            var z = int8(dst);
            math.dec(x,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> decU8<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            var x = uint8(src);
            var z = uint8(dst);
            math.dec(x,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> decI16<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            var x = int16(src);
            var z = int16(dst);
            math.dec(x,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> decU16<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            var x = uint16(src);
            var z = uint16(dst);
            math.dec(x,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> decI32<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            var x = int32(src);
            var z = int32(dst);
            math.dec(x,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> decU32<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            var x = uint32(src);
            var z = uint32(dst);
            math.dec(x,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> decI64<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            var x = int64(src);
            var z = int64(dst);
            math.dec(x,z);
            return dst;
        }


        [MethodImpl(NotInline)]
        public static Span<T> decU64<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            var x = uint64(src);
            var z = uint64(dst);
            math.dec(x,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> decF32<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            var x = float32(src);
            var z = float32(dst);
            math.dec(x,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> decF64<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            var x = float64(src);
            var z = float64(dst);
            math.dec(x,z);
            return dst;
        }

       [MethodImpl(NotInline)]
        public static ref Span<T> decI8<T>(ref Span<T> io)
            where T : struct
        {
            var x = int8(io);
            math.dec(ref x);
            return ref io;
        }

        [MethodImpl(NotInline)]
        public static ref Span<T> decU8<T>(ref Span<T> io)
            where T : struct
        {
            var x = uint8(io);
            math.dec(ref x);
            return ref io;
        }

        [MethodImpl(NotInline)]
        public static ref Span<T> decI16<T>(ref Span<T> io)
            where T : struct
        {
            var x = int16(io);
            math.dec(ref x);
            return ref io;
        }
        

        [MethodImpl(NotInline)]
        public static ref Span<T> decU16<T>(ref Span<T> io)
            where T : struct
        {
            var x = uint16(io);
            math.dec(ref x);
            return ref io;
        }
        

        [MethodImpl(NotInline)]
        public static ref Span<T> decI32<T>(ref Span<T> io)
            where T : struct
        {
            var x = int32(io);
            math.dec(ref x);
            return ref io;
        }

        [MethodImpl(NotInline)]
        public static ref Span<T> decU32<T>(ref Span<T> io)
            where T : struct
        {
            var x = uint32(io);
            math.dec(ref x);
            return ref io;
        }

        
        [MethodImpl(NotInline)]
        public static ref Span<T> decI64<T>(ref Span<T> io)
            where T : struct
        {
            var x = int64(io);
            math.dec(ref x);
            return ref io;
        }

        [MethodImpl(NotInline)]
        public static ref Span<T> decU64<T>(ref Span<T> io)
            where T : struct
        {
            var x = uint64(io);
            math.dec(ref x);
            return ref io;
        }

        [MethodImpl(NotInline)]
        public static ref Span<T> decF32<T>(ref Span<T> io)
            where T : struct
        {
            var x = float32(io);
            math.dec(ref x);
            return ref io;
        }

        [MethodImpl(NotInline)]
        public static ref Span<T> decF64<T>(ref Span<T> io)
            where T : struct
        {
            var x = float64(io);
            math.dec(ref x);
            return ref io;
        }

    }
}