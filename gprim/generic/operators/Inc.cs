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
        public static T inc<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return incI8(src);
            else if(typeof(T) == typeof(byte))
                return incU8(src);
            else if(typeof(T) == typeof(short))
                return incI16(src);
            else if(typeof(T) == typeof(ushort))
                return incU16(src);
            else if(typeof(T) == typeof(int))
                return incI32(src);
            else if(typeof(T) == typeof(uint))
                return incU32(src);
            else if(typeof(T) == typeof(long))
                return incI64(src);
            else if(typeof(T) == typeof(ulong))
                return incU64(src);
            else if(typeof(T) == typeof(float))
                return incF32(src);
            else if(typeof(T) == typeof(double))
                return incF64(src);
            else            
                throw unsupported(PrimalKinds.kind<T>());
        }           

        [MethodImpl(Inline)]
        public static ref T inc<T>(ref T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return ref incI8(ref src);
            else if(typeof(T) == typeof(byte))
                return ref incU8(ref src);
            else if(typeof(T) == typeof(short))
                return ref incI16(ref src);
            else if(typeof(T) == typeof(ushort))
                return ref incU16(ref src);
            else if(typeof(T) == typeof(int))
                return ref incI32(ref src);
            else if(typeof(T) == typeof(uint))
                return ref incU32(ref src);
            else if(typeof(T) == typeof(long))
                return ref incI64(ref src);
            else if(typeof(T) == typeof(ulong))
                return ref incU64(ref src);
            else if(typeof(T) == typeof(float))
                return ref incF32(ref src);
            else if(typeof(T) == typeof(double))
                return ref incF64(ref src);
            else            
                throw unsupported(PrimalKinds.kind<T>());
        }           


        public static Span<T> inc<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.inc(int8(src), int8(dst));
            else if(typeof(T) == typeof(byte))
                math.inc(uint8(src), uint8(dst));
            else if(typeof(T) == typeof(short))
                math.inc(int16(src), int16(dst));
            else if(typeof(T) == typeof(ushort))
                math.inc(uint16(src), uint16(dst));
            else if(typeof(T) == typeof(int))
                math.inc(int32(src), int32(dst));
            else if(typeof(T) == typeof(uint))
                math.inc(uint32(src), uint32(dst));
            else if(typeof(T) == typeof(long))
                math.inc(int64(src), int64(dst));
            else if(typeof(T) == typeof(ulong))
                math.inc(uint64(src), uint64(dst));
            else if(typeof(T) == typeof(float))
                math.inc(float32(src), float32(dst));
            else if(typeof(T) == typeof(double))
                math.inc(float64(src), float64(dst));
            else
                throw unsupported(PrimalKinds.kind<T>());                
            return dst;
        }

        [MethodImpl(NotInline)]
        public static ref Span<T> inc<T>(ref Span<T> io)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            if(kind == PrimalKind.int8)
                math.inc(int8(io));
            else if(kind == PrimalKind.uint8)
                math.inc(uint8(io));
            else if(kind == PrimalKind.int16)
                math.inc(int16(io));
            else if(kind == PrimalKind.uint16)
                math.inc(uint16(io));
            else if(kind == PrimalKind.int32)
                math.inc(int32(io));
            else if(kind == PrimalKind.uint32)
                math.inc(uint32(io));
            else if(kind == PrimalKind.int64)
                math.inc(int64(io));
            else if(kind == PrimalKind.uint64)
                math.inc(uint64(io));
            else if(kind == PrimalKind.float32)
                math.inc(float32(io));
            else if(kind == PrimalKind.float64)
                math.inc(float64(io));
            else
                throw unsupported(kind);                
           
            return ref io;
        }


        [MethodImpl(Inline)]
        static T incI8<T>(T src)
            => generic<T>(math.inc(ref int8(ref src)));

        [MethodImpl(Inline)]
        static T incU8<T>(T src)
            => generic<T>(math.inc(ref uint8(ref src)));

        [MethodImpl(Inline)]
        static T incI16<T>(T src)
            => generic<T>(math.inc(ref int16(ref src)));

        [MethodImpl(Inline)]
        static T incU16<T>(T src)
            => generic<T>(math.inc(ref uint16(ref src)));

        [MethodImpl(Inline)]
        static T incI32<T>(T src)
            => generic<T>(math.inc(ref int32(ref src)));
        
        [MethodImpl(Inline)]
        static T incU32<T>(T src)
            => generic<T>(math.inc(ref uint32(ref src)));

        [MethodImpl(Inline)]
        static T incI64<T>(T src)
            => generic<T>(math.inc(ref int64(ref src)));

        [MethodImpl(Inline)]
        static T incU64<T>(T src)
            => generic<T>(math.inc(ref uint64(ref src)));

        [MethodImpl(Inline)]
        static T incF32<T>(T src)
            => generic<T>(math.inc(ref float32(ref src)));

        [MethodImpl(Inline)]
        static T incF64<T>(T src)
            => generic<T>(math.inc(ref float64(ref src)));

        [MethodImpl(Inline)]
        static ref T incI8<T>(ref T io)
        {
            math.inc(ref int8(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        static ref T incU8<T>(ref T io)
        {
            math.inc(ref uint8(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        static ref T incI16<T>(ref T io)
        {
            math.inc(ref int16(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        static ref T incU16<T>(ref T io)
        {
            math.inc(ref uint16(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        static ref T incI32<T>(ref T io)
        {
            math.inc(ref int32(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        static ref T incU32<T>(ref T io)
        {
            math.inc(ref uint32(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        static ref T incI64<T>(ref T io)
        {
            math.inc(ref int64(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        static ref T incU64<T>(ref T io)
        {
            math.inc(ref uint64(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        static ref T incF32<T>(ref T io)
        {
            math.inc(ref float32(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        static ref T incF64<T>(ref T io)
        {
            math.inc(ref float64(ref io));
            return ref io;
        }



    }

}