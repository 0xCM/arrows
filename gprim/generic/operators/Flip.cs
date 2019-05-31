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
        public static T flip<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return flipI8(src);
            else if(typeof(T) == typeof(byte))
                return flipU8(src);
            else if(typeof(T) == typeof(short))
                return flipI16(src);
            else if(typeof(T) == typeof(ushort))
                return flipU16(src);
            else if(typeof(T) == typeof(int))
                return flipI32(src);
            else if(typeof(T) == typeof(uint))
                return flipU32(src);
            else if(typeof(T) == typeof(long))
                return flipI64(src);
            else if(typeof(T) == typeof(ulong))
                return flipU64(src);
            else            
                throw unsupported(PrimalKinds.kind<T>());
        }           

        [MethodImpl(Inline)]
        public static ref T flip<T>(ref T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return ref flipI8(ref src);
            else if(typeof(T) == typeof(byte))
                return ref flipU8(ref src);
            else if(typeof(T) == typeof(short))
                return ref flipI16(ref src);
            else if(typeof(T) == typeof(ushort))
                return ref flipU16(ref src);
            else if(typeof(T) == typeof(int))
                return ref flipI32(ref src);
            else if(typeof(T) == typeof(uint))
                return ref flipU32(ref src);
            else if(typeof(T) == typeof(long))
                return ref flipI64(ref src);
            else if(typeof(T) == typeof(ulong))
                return ref flipU64(ref src);
            else            
                throw unsupported(PrimalKinds.kind<T>());
        }           

        public static Span<T> flip<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.flip(int8(src), int8(dst));
            else if(typeof(T) == typeof(byte))
                math.flip(uint8(src), uint8(dst));
            else if(typeof(T) == typeof(short))
                math.flip(int16(src), int16(dst));
            else if(typeof(T) == typeof(ushort))
                math.flip(uint16(src), uint16(dst));
            else if(typeof(T) == typeof(int))
                math.flip(int32(src), int32(dst));
            else if(typeof(T) == typeof(uint))
                math.flip(uint32(src), uint32(dst));
            else if(typeof(T) == typeof(long))
                math.flip(int64(src), int64(dst));
            else if(typeof(T) == typeof(ulong))
                math.flip(uint64(src), uint64(dst));
            else
                throw unsupported(PrimalKinds.kind<T>());                
            return dst;
        }

        public static ref Span<T> flip<T>(ref Span<T> io)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.flip(int8(io), int8(io));
            else if(typeof(T) == typeof(byte))
                math.flip(uint8(io), uint8(io));
            else if(typeof(T) == typeof(short))
                math.flip(int16(io), int16(io));
            else if(typeof(T) == typeof(ushort))
                math.flip(uint16(io), uint16(io));
            else if(typeof(T) == typeof(int))
                math.flip(int32(io), int32(io));
            else if(typeof(T) == typeof(uint))
                math.flip(uint32(io), uint32(io));
            else if(typeof(T) == typeof(long))
                math.flip(int64(io), int64(io));
            else if(typeof(T) == typeof(ulong))
                math.flip(uint64(io), uint64(io));
            else
                throw unsupported(PrimalKinds.kind<T>());                
            return ref io;
        }

        [MethodImpl(Inline)]
        static T flipI8<T>(T src)
            => generic<T>(math.flip(ref int8(ref src)));            
            
        [MethodImpl(Inline)]
        static T flipU8<T>(T src)
        {
            math.flip(ref uint8(ref src));            
            return src;
        }

        [MethodImpl(Inline)]
        static T flipI16<T>(T src)
        {
            math.flip(ref int16(ref src));            
            return src;
        }

        [MethodImpl(Inline)]
        static T flipU16<T>(T src)
        {
            math.flip(ref uint16(ref src));            
            return src;
        }

        [MethodImpl(Inline)]
        static T flipI32<T>(T src)
        {
            math.flip(ref int32(ref src));            
            return src;
        }
        
        [MethodImpl(Inline)]
        static T flipU32<T>(T src)
        {
            math.flip(ref uint32(ref src));            
            return src;
        }

        [MethodImpl(Inline)]
        static T flipI64<T>(T src)
        {
            math.flip(ref int64(ref src));            
            return src;
        }

        [MethodImpl(Inline)]
        static T flipU64<T>(T src)
        {
            math.flip(ref uint64(ref src));            
            return src;
        }

        [MethodImpl(Inline)]
        static ref T flipI8<T>(ref T src)
        {
            math.flip(ref int8(ref src));            
            return ref src;
        }            

        [MethodImpl(Inline)]
        static ref T flipU8<T>(ref T src)
        {
            math.flip(ref uint8(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref T flipI16<T>(ref T src)
        {
            math.flip(ref int16(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref T flipU16<T>(ref T src)
        {
            math.flip(ref uint16(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref T flipI32<T>(ref T src)
        {
            math.flip(ref int32(ref src));            
            return ref src;
        }
        
        [MethodImpl(Inline)]
        static ref T flipU32<T>(ref T src)
        {
            math.flip(ref uint32(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref T flipI64<T>(ref T src)
        {
            math.flip(ref int64(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref T flipU64<T>(ref T src)
        {
            math.flip(ref uint64(ref src));            
            return ref src;
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