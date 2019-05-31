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
        public static T abs<T>(T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return absI8(src);
            else if(typeof(T) == typeof(byte))
                return src;
            else if(typeof(T) == typeof(short))
                return absI16(src);
            else if(typeof(T) == typeof(ushort))
                return src;
            else if(typeof(T) == typeof(int))
                return absI32(src);
            else if(typeof(T) == typeof(uint))
                return src;
            else if(typeof(T) == typeof(long))
                return absI64(src);
            else if(typeof(T) == typeof(ulong))
                return src;
            else if(typeof(T) == typeof(float))
                return absF32(src);
            else if(typeof(T) == typeof(double))
                return absF64(src);
            else            
                throw unsupported(PrimalKinds.kind<T>());
        }           


        [MethodImpl(Inline)]
        public static ref T abs<T>(ref T src)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return ref absI8(ref src);
            else if(typeof(T) == typeof(byte))
                return ref src;
            else if(typeof(T) == typeof(short))
                return ref absI16(ref src);
            else if(typeof(T) == typeof(ushort))
                return ref src;
            else if(typeof(T) == typeof(int))
                return ref absI32(ref src);
            else if(typeof(T) == typeof(uint))
                return ref src;
            else if(typeof(T) == typeof(long))
                return ref absI64(ref src);
            else if(typeof(T) == typeof(ulong))
                return ref src;
            else if(typeof(T) == typeof(float))
                return ref absF32(ref src);
            else if(typeof(T) == typeof(double))
                return ref absF64(ref src);
            else            
                throw unsupported(PrimalKinds.kind<T>());
        }           

        public static Span<T> abs<T>(ReadOnlySpan<T> src, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.abs(int8(src), int8(dst));
            else if(typeof(T) == typeof(short))
                math.abs(int16(src), int16(dst));
            else if(typeof(T) == typeof(int))
                math.abs(int32(src), int32(dst));
            else if(typeof(T) == typeof(long))
                math.abs(int64(src), int64(dst));
            else if(typeof(T) == typeof(float))
                math.abs(float32(src), float32(dst));
            else if(typeof(T) == typeof(double))
                math.abs(float64(src), float64(dst));
            else
                throw unsupported(PrimalKinds.kind<T>());                
            return dst;
        }

        public static ref Span<T> abs<T>(ref Span<T> io)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.abs(int8(io));
            else if(typeof(T) == typeof(short))
                math.abs(int16(io));
            else if(typeof(T) == typeof(int))
                math.abs(int32(io));
            else if(typeof(T) == typeof(long))
                math.abs(int64(io));
            else if(typeof(T) == typeof(float))
                math.abs(float32(io));
            else if(typeof(T) == typeof(double))
                math.abs(float64(io));
            else
                throw unsupported(PrimalKinds.kind<T>());                
            return ref io;
        }

        [MethodImpl(Inline)]
        static T absI8<T>(T src)
            => generic<T>(math.abs(int8(src)));

        [MethodImpl(Inline)]
        static T absI16<T>(T src)
            => generic<T>(math.abs(int16(src)));

        [MethodImpl(Inline)]
        static T absI32<T>(T src)
            => generic<T>(math.abs(int32(src)));
        
        [MethodImpl(Inline)]
        static T absI64<T>(T src)
            => generic<T>(math.abs(int64(src)));

        [MethodImpl(Inline)]
        static T absF32<T>(T src)
            => generic<T>(MathF.Abs(float32(src)));

        [MethodImpl(Inline)]
        static T absF64<T>(T src)
            => generic<T>(math.abs(float64(src)));
 
        [MethodImpl(Inline)]
        static ref T absI8<T>(ref T src)
        {
            ref var result = ref math.abs(ref int8(ref src));
            src = ref generic<T>(ref result);
            return ref src;
        }            

        [MethodImpl(Inline)]
        static ref T absI16<T>(ref T src)
        {
            ref var result = ref math.abs(ref int16(ref src));
            src = ref generic<T>(ref result);
            return ref src;
        }            

        [MethodImpl(Inline)]
        static ref T absI32<T>(ref T src)
        {
            ref var result = ref math.abs(ref int32(ref src));
            src = ref generic<T>(ref result);
            return ref src;
        }            

        [MethodImpl(Inline)]
        static ref T absI64<T>(ref T src)
        {
            ref var result = ref math.abs(ref int64(ref src));
            src = ref generic<T>(ref result);
            return ref src;
        }            

        [MethodImpl(Inline)]
        static ref T absF32<T>(ref T src)
        {
            ref var result = ref math.abs(ref float32(ref src));
            src = ref generic<T>(ref result);
            return ref src;
        }            

        [MethodImpl(Inline)]
        static ref T absF64<T>(ref T src)
        {
            ref var result = ref math.abs(ref float64(ref src));
            src = ref generic<T>(ref result);
            return ref src;
        }
    }
}