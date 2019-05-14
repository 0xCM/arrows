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
        public static Span<T> inc<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    return incI8(src,dst);
                case PrimalKind.uint8:
                    return incU8(src, dst);
                case PrimalKind.int16:
                    return incI16(src, dst);
                case PrimalKind.uint16:
                    return incU16(src, dst);
                case PrimalKind.int32:
                    return incI32(src, dst);
                case PrimalKind.uint32:
                    return incU32(src, dst);
                case PrimalKind.int64:
                    return incI64(src, dst);
                case PrimalKind.uint64:
                    return incU64(src, dst);
                case PrimalKind.float32:
                    return incF32(src, dst);
                case PrimalKind.float64:
                    return incF64(src, dst);
                default:
                    throw unsupported(kind);                
            }
        }

        [MethodImpl(NotInline)]
        public static ref Span<T> inc<T>(ref Span<T> io)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    return ref incI8(ref io);
                case PrimalKind.uint8:
                    return ref incU8(ref io);
                case PrimalKind.int16:
                    return ref incI16(ref io);
                case PrimalKind.uint16:
                    return ref incU16(ref io);
                case PrimalKind.int32:
                    return ref incI32(ref io);
                case PrimalKind.uint32:
                    return ref incU32(ref io);
                case PrimalKind.int64:
                    return ref incI64(ref io);
                case PrimalKind.uint64:
                    return ref incU64(ref io);
                case PrimalKind.float32:
                    return ref incF32(ref io);
                case PrimalKind.float64:
                    return ref incF64(ref io);
                default:
                    throw unsupported(kind);                
            }
        }


        [MethodImpl(NotInline)]
        public static Span<T> incI8<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            var x = int8(src);
            var z = int8(dst);
            math.dec(x,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> incU8<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            var x = uint8(src);
            var z = uint8(dst);
            math.dec(x,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> incI16<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            var x = int16(src);
            var z = int16(dst);
            math.dec(x,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> incU16<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            var x = uint16(src);
            var z = uint16(dst);
            math.dec(x,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> incI32<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            var x = int32(src);
            var z = int32(dst);
            math.dec(x,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> incU32<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            var x = uint32(src);
            var z = uint32(dst);
            math.dec(x,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> incI64<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            var x = int64(src);
            var z = int64(dst);
            math.dec(x,z);
            return dst;
        }


        [MethodImpl(NotInline)]
        public static Span<T> incU64<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            var x = uint64(src);
            var z = uint64(dst);
            math.dec(x,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> incF32<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            var x = float32(src);
            var z = float32(dst);
            math.dec(x,z);
            return dst;
        }

        [MethodImpl(NotInline)]
        public static Span<T> incF64<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            var x = float64(src);
            var z = float64(dst);
            math.dec(x,z);
            return dst;
        }

       [MethodImpl(NotInline)]
        public static ref Span<T> incI8<T>(ref Span<T> io)
            where T : struct
        {
            var x = int8(io);
            math.dec(ref x);
            return ref io;
        }

        [MethodImpl(NotInline)]
        public static ref Span<T> incU8<T>(ref Span<T> io)
            where T : struct
        {
            var x = uint8(io);
            math.dec(ref x);
            return ref io;
        }

        [MethodImpl(NotInline)]
        public static ref Span<T> incI16<T>(ref Span<T> io)
            where T : struct
        {
            var x = int16(io);
            math.dec(ref x);
            return ref io;
        }
        

        [MethodImpl(NotInline)]
        public static ref Span<T> incU16<T>(ref Span<T> io)
            where T : struct
        {
            var x = uint16(io);
            math.dec(ref x);
            return ref io;
        }        

        [MethodImpl(NotInline)]
        public static ref Span<T> incI32<T>(ref Span<T> io)
            where T : struct
        {
            var x = int32(io);
            math.dec(ref x);
            return ref io;
        }

        [MethodImpl(NotInline)]
        public static ref Span<T> incU32<T>(ref Span<T> io)
            where T : struct
        {
            var x = uint32(io);
            math.dec(ref x);
            return ref io;
        }

        
        [MethodImpl(NotInline)]
        public static ref Span<T> incI64<T>(ref Span<T> io)
            where T : struct
        {
            var x = int64(io);
            math.dec(ref x);
            return ref io;
        }

        [MethodImpl(NotInline)]
        public static ref Span<T> incU64<T>(ref Span<T> io)
            where T : struct
        {
            var x = uint64(io);
            math.dec(ref x);
            return ref io;
        }

        [MethodImpl(NotInline)]
        public static ref Span<T> incF32<T>(ref Span<T> io)
            where T : struct
        {
            var x = float32(io);
            math.dec(ref x);
            return ref io;
        }

        [MethodImpl(NotInline)]
        public static ref Span<T> incF64<T>(ref Span<T> io)
            where T : struct
        {
            var x = float64(io);
            math.dec(ref x);
            return ref io;
        }

    }
}