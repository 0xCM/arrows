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
        public static T square<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return squareI8(src);
            else if(typeof(T) == typeof(byte))
                return squareU8(src);
            else if(typeof(T) == typeof(short))
                return squareI16(src);
            else if(typeof(T) == typeof(ushort))
                return squareU16(src);
            else if(typeof(T) == typeof(int))
                return squareI32(src);
            else if(typeof(T) == typeof(uint))
                return squareU32(src);
            else if(typeof(T) == typeof(long))
                return squareI64(src);
            else if(typeof(T) == typeof(ulong))
                return squareU64(src);
            else if(typeof(T) == typeof(float))
                return squareF32(src);
            else if(typeof(T) == typeof(double))
                return squareF64(src);
            else            
                throw unsupported(PrimalKinds.kind<T>());
        }           

        [MethodImpl(Inline)]
        public static ref T square<T>(ref T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return ref squareI8(ref src);
            else if(typeof(T) == typeof(byte))
                return ref squareU8(ref src);
            else if(typeof(T) == typeof(short))
                return ref squareI16(ref src);
            else if(typeof(T) == typeof(ushort))
                return ref squareU16(ref src);
            else if(typeof(T) == typeof(int))
                return ref squareI32(ref src);
            else if(typeof(T) == typeof(uint))
                return ref squareU32(ref src);
            else if(typeof(T) == typeof(long))
                return ref squareI64(ref src);
            else if(typeof(T) == typeof(ulong))
                return ref squareU64(ref src);
            else if(typeof(T) == typeof(float))
                return ref squareF32(ref src);
            else if(typeof(T) == typeof(double))
                return ref squareF64(ref src);
            else            
                throw unsupported(PrimalKinds.kind<T>());
        }           

        public static ref Span<T> square<T>(ref Span<T> io)
            where T : struct
        {
            for(var i=0; i< io.Length; i++)
                square(ref io[i]);
            return ref io;                
        }


        [MethodImpl(Inline)]
        static T squareI8<T>(T src)
            => squareI8(ref src);

        [MethodImpl(Inline)]
        static T squareU8<T>(T src)
            => squareU8(ref src);

        [MethodImpl(Inline)]
        static T squareI16<T>(T src)
            => squareI16(ref src);

        [MethodImpl(Inline)]
        static T squareU16<T>(T src)
            => squareU16(ref src);

        [MethodImpl(Inline)]
        static T squareI32<T>(T src)
            => squareI32(ref src);
        
        [MethodImpl(Inline)]
        static T squareU32<T>(T src)
            => squareU32(ref src);

        [MethodImpl(Inline)]
        static T squareI64<T>(T src)
            => squareI64(ref src);

        [MethodImpl(Inline)]
        static T squareU64<T>(T src)
            => squareU64(ref src);

        [MethodImpl(Inline)]
        static T squareF32<T>(T src)
            => squareU32(ref src);

        [MethodImpl(Inline)]
        static T squareF64<T>(T src)
            => squareI64(ref src);

        [MethodImpl(Inline)]
        static ref T squareI8<T>(ref T src)
        {
            math.square(ref int8(ref src));            
            return ref src;
        }            

        [MethodImpl(Inline)]
        static ref T squareU8<T>(ref T src)
        {
            math.square(ref uint8(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref T squareI16<T>(ref T src)
        {
            math.square(ref int16(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref T squareU16<T>(ref T src)
        {
            math.square(ref uint16(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref T squareI32<T>(ref T src)
        {
            math.square(ref int32(ref src));            
            return ref src;
        }
        
        [MethodImpl(Inline)]
        static ref T squareU32<T>(ref T src)
        {
            math.square(ref uint32(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref T squareI64<T>(ref T src)
        {
            math.square(ref int64(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref T squareU64<T>(ref T src)
        {
            math.square(ref uint64(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref T squareF32<T>(ref T src)
        {
            math.square(ref float32(ref src));            
            return ref src;
        }

        [MethodImpl(Inline)]
        static ref T squareF64<T>(ref T src)
        {
            math.square(ref float64(ref src));            
            return ref src;
        }
    }
}