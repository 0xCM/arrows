//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    
    using static As;
    using static AsInX;

    partial class ginx
    {
        [MethodImpl(Inline)]
        public static Vec128<T> or<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.or(in int8(in lhs), in int8(in rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(dinx.or(in uint8(in lhs), in uint8(in rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.or(in int16(in lhs), in int16(in rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.or(in uint16(in lhs), in uint16(in rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.or(in int32(in lhs), in int32(in rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.or(in uint32(in lhs), in uint32(in rhs)));
            else if(typeof(T) == typeof(long))
                return generic<T>(dinx.or(in int64(in lhs), in int64(in rhs)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.or(in uint64(in lhs), in uint64(in rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(dinx.or(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dinx.or(in float64(in lhs), in float64(in rhs)));
            else 
                throw unsupported(PrimalKinds.kind<T>());
        }

        [MethodImpl(Inline)]
        public static Vec256<T> or<T>(in Vec256<T> lhs, in Vec256<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.or(in int8(in lhs), in int8(in rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(dinx.or(in uint8(in lhs), in uint8(in rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.or(in int16(in lhs), in int16(in rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.or(in uint16(in lhs), in uint16(in rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.or(in int32(in lhs), in int32(in rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.or(in uint32(in lhs), in uint32(in rhs)));
            else if(typeof(T) == typeof(long))
                return generic<T>(dinx.or(in int64(in lhs), in int64(in rhs)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.or(in uint64(in lhs), in uint64(in rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(dinx.or(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dinx.or(in float64(in lhs), in float64(in rhs)));
            else 
                throw unsupported(PrimalKinds.kind<T>());
        }


        [MethodImpl(Inline)]
        public static void or<T>(in Vec128<T> lhs, in Vec128<T> rhs, ref T dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                dinx.or(int8(lhs), int8(rhs), ref int8(ref dst));
            else if (typeof(T) == typeof(byte))
                dinx.or(uint8(lhs), uint8(rhs), ref uint8(ref dst));                    
            else if (typeof(T) == typeof(short))
                dinx.or(int16(lhs), int16(rhs), ref int16(ref dst));
            else if (typeof(T) == typeof(ushort))
                dinx.or(uint16(lhs), uint16(rhs), ref uint16(ref dst));
            else if(typeof(T) == typeof(int))
                dinx.or(int32(lhs), int32(rhs), ref int32(ref dst));
            else if(typeof(T) == typeof(uint))
                dinx.or(uint32(lhs), uint32(rhs), ref uint32(ref dst));
            else if(typeof(T) == typeof(long))
                dinx.or(int64(lhs), int64(rhs), ref int64(ref dst));
            else if(typeof(T) == typeof(ulong))
                dinx.or(uint64(lhs), uint64(rhs), ref uint64(ref dst));
            else if(typeof(T) == typeof(float))
                dinx.or(float32(lhs), float32(rhs), ref float32(ref dst));
            else if(typeof(T) == typeof(double))
                dinx.or(float64(lhs), float64(rhs), ref float64(ref dst));                
            else    
                throw unsupported(PrimalKinds.kind<T>());            
        }
        
        [MethodImpl(Inline)]
        public static void or<T>(in Vec256<T> lhs, in Vec256<T> rhs, ref T dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                dinx.or(int8(lhs), int8(rhs), ref int8(ref dst));
            else if (typeof(T) == typeof(byte))
                dinx.or(uint8(lhs), uint8(rhs), ref uint8(ref dst));                    
            else if (typeof(T) == typeof(short))
                dinx.or(int16(lhs), int16(rhs), ref int16(ref dst));
            else if (typeof(T) == typeof(ushort))
                dinx.or(uint16(lhs), uint16(rhs), ref uint16(ref dst));
            else if(typeof(T) == typeof(int))
                dinx.or(int32(lhs), int32(rhs), ref int32(ref dst));
            else if(typeof(T) == typeof(uint))
                dinx.or(uint32(lhs), uint32(rhs), ref uint32(ref dst));
            else if(typeof(T) == typeof(long))
                dinx.or(int64(lhs), int64(rhs), ref int64(ref dst));
            else if(typeof(T) == typeof(ulong))
                dinx.or(uint64(lhs), uint64(rhs), ref uint64(ref dst));
            else if(typeof(T) == typeof(float))
                dinx.or(float32(lhs), float32(rhs), ref float32(ref dst));
            else if(typeof(T) == typeof(double))
                dinx.or(float64(lhs), float64(rhs), ref float64(ref dst));                
            else    
                throw unsupported(PrimalKinds.kind<T>());            
        }

        public static Span128<T> or<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, Span128<T> dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                dinx.or(int8(lhs), int8(rhs), int8(dst));
            else if (typeof(T) == typeof(byte))
                dinx.or(uint8(lhs), uint8(rhs), uint8(dst));                    
            else if (typeof(T) == typeof(short))
                dinx.or(int16(lhs), int16(rhs), int16(dst));
            else if (typeof(T) == typeof(ushort))
                dinx.or(uint16(lhs), uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                dinx.or(int32(lhs), int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                dinx.or(uint32(lhs), uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                dinx.or(int64(lhs), int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                dinx.or(uint64(lhs), uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                dinx.or(float32(lhs), float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                dinx.or(float64(lhs), float64(rhs), float64(dst));                
            else    
                throw unsupported(PrimalKinds.kind<T>());         
            return dst;   
        }


        public static Span256<T> or<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, Span256<T> dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                dinx.or(int8(lhs), int8(rhs), int8(dst));
            else if (typeof(T) == typeof(byte))
                dinx.or(uint8(lhs), uint8(rhs), uint8(dst));                    
            else if (typeof(T) == typeof(short))
                dinx.or(int16(lhs), int16(rhs), int16(dst));
            else if (typeof(T) == typeof(ushort))
                dinx.or(uint16(lhs), uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                dinx.or(int32(lhs), int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                dinx.or(uint32(lhs), uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                dinx.or(int64(lhs), int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                dinx.or(uint64(lhs), uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                dinx.or(float32(lhs), float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                dinx.or(float64(lhs), float64(rhs), float64(dst));                
            else    
                throw unsupported(PrimalKinds.kind<T>());         
            return dst;   
        }
    }
}