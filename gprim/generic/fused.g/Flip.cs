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

    partial class gmath
    {
        [MethodImpl(Inline)]
        public static Span<T> flip<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            if(kind == PrimalKind.int8)
                math.flip(int8(src), int8(dst));
            else if(kind == PrimalKind.uint8)
                math.flip(uint8(src), uint8(dst));
            else if(kind == PrimalKind.int16)
                math.flip(int16(src), int16(dst));
            else if(kind == PrimalKind.uint16)
                math.flip(uint16(src), uint16(dst));
            else if(kind == PrimalKind.int32)
                math.flip(int32(src), int32(dst));
            else if(kind == PrimalKind.uint32)
                math.flip(uint32(src), uint32(dst));
            else if(kind == PrimalKind.int64)
                math.flip(int64(src), int64(dst));
            else if(kind == PrimalKind.uint64)
                math.flip(uint64(src), uint64(dst));
            else
                throw unsupported(kind);                
            return dst;
        }

        [MethodImpl(Inline)]
        public static ref Span<T> flip<T>(ref Span<T> io)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            switch(kind)
            {
                case PrimalKind.int8:
                    return ref flipI8(ref io);
                case PrimalKind.uint8:
                    return ref flipU8(ref io);
                case PrimalKind.int16:
                    return ref flipI16(ref io);
                case PrimalKind.uint16:
                    return ref flipU16(ref io);
                case PrimalKind.int32:
                    return ref flipI32(ref io);
                case PrimalKind.uint32:
                    return ref flipU32(ref io);
                case PrimalKind.int64:
                    return ref flipI64(ref io);
                case PrimalKind.uint64:
                    return ref flipU64(ref io);
                default:
                    throw unsupported(kind);                
            }
        }


 
        [MethodImpl(Inline)]
        static ref Span<T> flipI8<T>(ref Span<T> io)
            where T : struct
        {
            var x = int8(io);
            math.flip(ref x);
            return ref io;
        }

        [MethodImpl(Inline)]
        static ref Span<T> flipU8<T>(ref Span<T> io)
            where T : struct
        {
            var x = uint8(io);
            math.flip(ref x);
            return ref io;
        }

        [MethodImpl(Inline)]
        static ref Span<T> flipI16<T>(ref Span<T> io)
            where T : struct
        {
            var x = int16(io);
            math.flip(ref x);
            return ref io;
        }
        

        [MethodImpl(Inline)]
        static ref Span<T> flipU16<T>(ref Span<T> io)
            where T : struct
        {
            var x = uint16(io);
            math.flip(ref x);
            return ref io;
        }        

        [MethodImpl(Inline)]
        static ref Span<T> flipI32<T>(ref Span<T> io)
            where T : struct
        {
            var x = int32(io);
            math.flip(ref x);
            return ref io;
        }

        [MethodImpl(Inline)]
        static ref Span<T> flipU32<T>(ref Span<T> io)
            where T : struct
        {
            var x = uint32(io);
            math.flip(ref x);
            return ref io;
        }
        
        [MethodImpl(Inline)]
        static ref Span<T> flipI64<T>(ref Span<T> io)
            where T : struct
        {
            var x = int64(io);
            math.flip(ref x);
            return ref io;
        }

        [MethodImpl(Inline)]
        static ref Span<T> flipU64<T>(ref Span<T> io)
            where T : struct
        {
            var x = uint64(io);
            math.flip(ref x);
            return ref io;
        }
    }
}