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
        static ref Span<T> incI8<T>(ref Span<T> io)
            where T : struct
        {
            var x = int8(io);
            math.inc(ref x);
            return ref io;
        }

        [MethodImpl(NotInline)]
        static ref Span<T> incU8<T>(ref Span<T> io)
            where T : struct
        {
            var x = uint8(io);
            math.inc(ref x);
            return ref io;
        }

        [MethodImpl(NotInline)]
        static ref Span<T> incI16<T>(ref Span<T> io)
            where T : struct
        {
            var x = int16(io);
            math.inc(ref x);
            return ref io;
        }
        

        [MethodImpl(NotInline)]
        static ref Span<T> incU16<T>(ref Span<T> io)
            where T : struct
        {
            var x = uint16(io);
            math.inc(ref x);
            return ref io;
        }        

        [MethodImpl(NotInline)]
        static ref Span<T> incI32<T>(ref Span<T> io)
            where T : struct
        {
            var x = int32(io);
            math.inc(ref x);
            return ref io;
        }

        [MethodImpl(NotInline)]
        static ref Span<T> incU32<T>(ref Span<T> io)
            where T : struct
        {
            var x = uint32(io);
            math.inc(ref x);
            return ref io;
        }

        
        [MethodImpl(NotInline)]
        static ref Span<T> incI64<T>(ref Span<T> io)
            where T : struct
        {
            var x = int64(io);
            math.inc(ref x);
            return ref io;
        }

        [MethodImpl(NotInline)]
        static ref Span<T> incU64<T>(ref Span<T> io)
            where T : struct
        {
            var x = uint64(io);
            math.inc(ref x);
            return ref io;
        }

        [MethodImpl(NotInline)]
        static ref Span<T> incF32<T>(ref Span<T> io)
            where T : struct
        {
            var x = float32(io);
            math.inc(ref x);
            return ref io;
        }

        [MethodImpl(NotInline)]
        static ref Span<T> incF64<T>(ref Span<T> io)
            where T : struct
        {
            var x = float64(io);
            math.inc(ref x);
            return ref io;
        }

    }
}