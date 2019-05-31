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
        public static T negate<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return negateI8(src);
            else if(typeof(T) == typeof(short))
                return negateI16(src);
            else if(typeof(T) == typeof(int))
                return negateI32(src);
            else if(typeof(T) == typeof(long))
                return negateI64(src);
            else if(typeof(T) == typeof(float))
                return negateF32(src);
            else if(typeof(T) == typeof(double))
                return negateF64(src);
            else            
                throw unsupported(PrimalKinds.kind<T>());
        }           

        [MethodImpl(Inline)]
        public static ref T negate<T>(ref T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return ref negateI8(ref src);
            else if(typeof(T) == typeof(short))
                return ref negateI16(ref src);
            else if(typeof(T) == typeof(int))
                return ref negateI32(ref src);
            else if(typeof(T) == typeof(long))
                return ref negateI64(ref src);
            else if(typeof(T) == typeof(float))
                return ref negateF32(ref src);
            else if(typeof(T) == typeof(double))
                return ref negateF64(ref src);
            else            
                throw unsupported(PrimalKinds.kind<T>());
        }           

        [MethodImpl(Inline)]
        public static Span<T> negate<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.negate(int8(src), int8(dst));
            else if(typeof(T) == typeof(short))
                math.negate(int16(src), int16(dst));
            else if(typeof(T) == typeof(int))
                math.negate(int32(src), int32(dst));
            else if(typeof(T) == typeof(long))
                math.negate(int64(src), int64(dst));
            else if(typeof(T) == typeof(float))
                math.negate(float32(src), float32(dst));
            else if(typeof(T) == typeof(double))
                math.negate(float64(src), float64(dst));
            else
                throw unsupported(PrimalKinds.kind<T>());                
            return dst;
        }

        [MethodImpl(Inline)]
        public static ref Span<T> negate<T>(ref Span<T> io)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.negate(int8(io));
            else if(typeof(T) == typeof(short))
                math.negate(int16(io));
            else if(typeof(T) == typeof(int))
                math.negate(int32(io));
            else if(typeof(T) == typeof(long))
                math.negate(int64(io));
            else if(typeof(T) == typeof(float))
                math.negate(float32(io));
            else if(typeof(T) == typeof(double))
                math.negate(float64(io));
            else
                throw unsupported(PrimalKinds.kind<T>());                
            return ref io;

        }
        


        [MethodImpl(Inline)]
        static T negateI8<T>(T src)        
            => generic<T>(math.negate(ref int8(ref src)));            
        
        [MethodImpl(Inline)]
        static T negateI16<T>(T src)        
            => generic<T>(math.negate(ref int16(ref src)));            

        [MethodImpl(Inline)]
        static T negateI32<T>(T src)        
            => generic<T>(math.negate(ref int32(ref src)));            
        
        [MethodImpl(Inline)]
        static T negateI64<T>(T src)        
            => generic<T>(math.negate(ref int64(ref src)));            

        [MethodImpl(Inline)]
        static T negateF32<T>(T src)        
            => generic<T>(math.negate(ref float32(ref src)));            
        
        [MethodImpl(Inline)]
        static T negateF64<T>(T src)        
            => generic<T>(math.negate(ref float64(ref src)));            


        [MethodImpl(Inline)]
        static ref T negateI8<T>(ref T io)
        {
            math.negate(ref int8(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        static ref T negateI16<T>(ref T io)
        {
            math.negate(ref int16(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        static ref T negateI32<T>(ref T io)
        {
            math.negate(ref int32(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        static ref T negateI64<T>(ref T io)
        {
            math.negate(ref int64(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        static ref T negateF32<T>(ref T io)
        {
            math.negate(ref float32(ref io));
            return ref io;
        }

        [MethodImpl(Inline)]
        static ref T negateF64<T>(ref T io)
        {
            math.negate(ref float64(ref io));
            return ref io;
        }
    }
}