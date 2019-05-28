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
        public static T dec<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return decI8(src);
            else if(typeof(T) == typeof(byte))
                return decU8(src);
            else if(typeof(T) == typeof(short))
                return decI16(src);
            else if(typeof(T) == typeof(ushort))
                return decU16(src);
            else if(typeof(T) == typeof(int))
                return decI32(src);
            else if(typeof(T) == typeof(uint))
                return decU32(src);
            else if(typeof(T) == typeof(long))
                return decI64(src);
            else if(typeof(T) == typeof(ulong))
                return decU64(src);
            else if(typeof(T) == typeof(float))
                return decF32(src);
            else if(typeof(T) == typeof(double))
                return decF64(src);
            else            
                throw unsupported(PrimalKinds.kind<T>());
        }           

        [MethodImpl(Inline)]
        public static ref T dec<T>(ref T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return ref decI8(ref src);
            else if(typeof(T) == typeof(byte))
                return ref decU8(ref src);
            else if(typeof(T) == typeof(short))
                return ref decI16(ref src);
            else if(typeof(T) == typeof(ushort))
                return ref decU16(ref src);
            else if(typeof(T) == typeof(int))
                return ref decI32(ref src);
            else if(typeof(T) == typeof(uint))
                return ref decU32(ref src);
            else if(typeof(T) == typeof(long))
                return ref decI64(ref src);
            else if(typeof(T) == typeof(ulong))
                return ref decU64(ref src);
            else if(typeof(T) == typeof(float))
                return ref decF32(ref src);
            else if(typeof(T) == typeof(double))
                return ref decF64(ref src);
            else            
                throw unsupported(PrimalKinds.kind<T>());
        }           


        [MethodImpl(Inline)]
        public static Span<T> dec<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            if(kind == PrimalKind.int8)
                math.dec(int8(src), int8(dst));
            else if(kind == PrimalKind.uint8)
                math.dec(uint8(src), uint8(dst));
            else if(kind == PrimalKind.int16)
                math.dec(int16(src), int16(dst));
            else if(kind == PrimalKind.uint16)
                math.dec(uint16(src), uint16(dst));
            else if(kind == PrimalKind.int32)
                math.dec(int32(src), int32(dst));
            else if(kind == PrimalKind.uint32)
                math.dec(uint32(src), uint32(dst));
            else if(kind == PrimalKind.int64)
                math.dec(int64(src), int64(dst));
            else if(kind == PrimalKind.uint64)
                math.dec(uint64(src), uint64(dst));
            else if(kind == PrimalKind.float32)
                math.dec(float32(src), float32(dst));
            else if(kind == PrimalKind.float64)
                math.dec(float64(src), float64(dst));
            else
                throw unsupported(kind);                
            return dst;
        }
        
        [MethodImpl(Inline)]
        public static ref Span<T> dec<T>(ref Span<T> io)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            if(kind == PrimalKind.int8)
                math.dec(int8(io));
            else if(kind == PrimalKind.uint8)
                math.dec(uint8(io));
            else if(kind == PrimalKind.int16)
                math.dec(int16(io));
            else if(kind == PrimalKind.uint16)
                math.dec(uint16(io));
            else if(kind == PrimalKind.int32)
                math.dec(int32(io));
            else if(kind == PrimalKind.uint32)
                math.dec(uint32(io));
            else if(kind == PrimalKind.int64)
                math.dec(int64(io));
            else if(kind == PrimalKind.uint64)
                math.dec(uint64(io));
            else if(kind == PrimalKind.float32)
                math.dec(float32(io));
            else if(kind == PrimalKind.float64)
                math.dec(float64(io));
            else
                throw unsupported(kind);                
           
            return ref io;
        }

        [MethodImpl(Inline)]
        static T decI8<T>(T src)
            => decI8(ref src);

        [MethodImpl(Inline)]
        static T decU8<T>(T src)
            => decU8(ref src);

        [MethodImpl(Inline)]
        static T decI16<T>(T src)
            => decI16(ref src);

        [MethodImpl(Inline)]
        static T decU16<T>(T src)
            => decU16(ref src);

        [MethodImpl(Inline)]
        static T decI32<T>(T src)
            => decI32(ref src);
        
        [MethodImpl(Inline)]
        static T decU32<T>(T src)
            => decU32(ref src);

        [MethodImpl(Inline)]
        static T decI64<T>(T src)
            => decI64(ref src);

        [MethodImpl(Inline)]
        static T decU64<T>(T src)
            => decU64(ref src);

        [MethodImpl(Inline)]
        static T decF32<T>(T src)
            => decF32(ref src);

        [MethodImpl(Inline)]
        static T decF64<T>(T src)
            => decF64(ref src);

        [MethodImpl(Inline)]
        static ref T decI8<T>(ref T io)
        {
            math.dec(ref int8(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        static ref T decU8<T>(ref T io)
        {
            math.dec(ref uint8(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        static ref T decI16<T>(ref T io)
        {
            math.dec(ref int16(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        static ref T decU16<T>(ref T io)
        {
            math.dec(ref uint16(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        static ref T decI32<T>(ref T io)
        {
            math.dec(ref int32(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        static ref T decU32<T>(ref T io)
        {
            math.dec(ref uint32(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        static ref T decI64<T>(ref T io)
        {
            math.dec(ref int64(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        static ref T decU64<T>(ref T io)
        {
            math.dec(ref uint64(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        static ref T decF32<T>(ref T io)
        {
            math.dec(ref float32(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        static ref T decF64<T>(ref T io)
        {
            math.dec(ref float64(ref io));
            return ref io;
        } 
    }
}