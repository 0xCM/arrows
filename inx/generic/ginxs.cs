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

    public static class ginxs
    {        
        public static Span128<T> Add<T>(this ReadOnlySpan128<T> lhs, in ReadOnlySpan128<T> rhs, in Span128<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                int8(lhs).Add(int8(rhs), int8(dst));
            else if(typeof(T) == typeof(byte))
                uint8(lhs).Add(uint8(rhs), uint8(dst));
            else if(typeof(T) == typeof(short))
                int16(lhs).Add(int16(rhs), int16(dst));
            else if(typeof(T) == typeof(ushort))
                uint16(lhs).Add(uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                int32(lhs).Add(int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                uint32(lhs).Add(uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                int64(lhs).Add(int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                uint64(lhs).Add(uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                float32(lhs).Add(float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                float64(lhs).Add(float64(rhs), float64(dst));
            else 
                throw unsupported<T>();
            return dst;
        }

        public static Span256<T> Add<T>(this ReadOnlySpan256<T> lhs, in ReadOnlySpan256<T> rhs, in Span256<T> dst)
            where T : struct
        {            
            if(typeof(T) == typeof(sbyte))
                int8(lhs).Add(int8(rhs), int8(dst));
            else if(typeof(T) == typeof(byte))
                uint8(lhs).Add(uint8(rhs), uint8(dst));
            else if(typeof(T) == typeof(short))
                int16(lhs).Add(int16(rhs), int16(dst));
            else if(typeof(T) == typeof(ushort))
                uint16(lhs).Add(uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                int32(lhs).Add(int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                uint32(lhs).Add(uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                int64(lhs).Add(int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                uint64(lhs).Add(uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                float32(lhs).Add(float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                float64(lhs).Add(float64(rhs), float64(dst));
            else 
                throw unsupported<T>();
            return dst;
        }

        public static Span128<T> Sub<T>(this ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, Span128<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                int8(lhs).Sub(int8(rhs), int8(dst));
            else if(typeof(T) == typeof(byte))
                uint8(lhs).Sub(uint8(rhs), uint8(dst));
            else if(typeof(T) == typeof(short))
                int16(lhs).Sub(int16(rhs), int16(dst));
            else if(typeof(T) == typeof(ushort))
                uint16(lhs).Sub(uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                int32(lhs).Sub(int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                uint32(lhs).Sub(uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                int64(lhs).Sub(int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                uint64(lhs).Sub(uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                float32(lhs).Sub(float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                float64(lhs).Sub(float64(rhs), float64(dst));
            else 
                throw unsupported<T>();
            return dst;
        }

        public static Span256<T> Sub<T>(this ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, Span256<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                int8(lhs).Sub(int8(rhs), int8(dst));
            else if(typeof(T) == typeof(byte))
                uint8(lhs).Sub(uint8(rhs), uint8(dst));
            else if(typeof(T) == typeof(short))
                int16(lhs).Sub(int16(rhs), int16(dst));
            else if(typeof(T) == typeof(ushort))
                uint16(lhs).Sub(uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                int32(lhs).Sub(int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                uint32(lhs).Sub(uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                int64(lhs).Sub(int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                uint64(lhs).Sub(uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                float32(lhs).Sub(float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                float64(lhs).Sub(float64(rhs), float64(dst));
            else 
                throw unsupported<T>();
            return dst;
        }


        public static Span128<T> Mul<S,T>(this ReadOnlySpan128<S> lhs, ReadOnlySpan128<S> rhs, Span128<T> dst)
            where S : struct
            where T : struct
        {
            if(typeof(S) == typeof(int))
                int32(lhs).Mul(int32(rhs), int64(dst));
            else if(typeof(S) == typeof(uint))
                uint32(lhs).Mul(uint32(rhs), uint64(dst));
            else if(typeof(S) == typeof(float))
                float32(lhs).Mul(float32(rhs), float32(dst));
            else if(typeof(S) == typeof(double))
                float64(rhs).Mul(float64(rhs), float64(dst));
            else
                throw unsupported<T>();
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span256<T> Mul<S,T>(this ReadOnlySpan256<S> lhs, ReadOnlySpan256<S> rhs, Span256<T> dst)
            where S : struct
            where T : struct
        {
            if(typeof(S) == typeof(int))
                int32(lhs).Mul(int32(rhs), int64(dst));
            else if(typeof(S) == typeof(uint))
                uint32(lhs).Mul(uint32(rhs), uint64(dst));
            else if(typeof(S) == typeof(float))
                float32(lhs).Mul(float32(rhs), float32(dst));
            else if(typeof(S) == typeof(double))
                float64(rhs).Mul(float64(rhs), float64(dst));
            else
                throw unsupported<T>();
            return dst;

        }


        public static Span128<T> Div<T>(this ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, Span128<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dinx.div(float32(lhs), float32(rhs), float32(dst)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dinx.div(float64(lhs), float64(rhs), float64(dst)));
            else                
                throw unsupported<T>();
        }
        
        public static Span256<T> Div<T>(this ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, Span256<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dinx.div(float32(lhs), float32(rhs), float32(dst)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dinx.div(float64(lhs), float64(rhs), float64(dst)));
            else                
                throw unsupported<T>();
        }

        public static Span128<T> And<T>(this ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, Span128<T> dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                int8(lhs).And(int8(rhs), int8(dst));
            else if (typeof(T) == typeof(byte))
                uint8(lhs).And(uint8(rhs), uint8(dst));
            else if (typeof(T) == typeof(short))
                int16(lhs).And(int16(rhs), int16(dst));
            else if (typeof(T) == typeof(ushort))
                uint16(lhs).And(uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                int32(lhs).And(int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                uint32(lhs).And(uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                int64(lhs).And(int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                uint64(lhs).And(uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                float32(lhs).And(float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                float64(lhs).And(float64(rhs), float64(dst));
            else    
                throw unsupported<T>();
            return dst;        
        }

        public static Span256<T> And<T>(this ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, Span256<T> dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                int8(lhs).And(int8(rhs), int8(dst));
            else if (typeof(T) == typeof(byte))
                uint8(lhs).And(uint8(rhs), uint8(dst));                    
            else if (typeof(T) == typeof(short))
                int16(lhs).And(int16(rhs), int16(dst));
            else if (typeof(T) == typeof(ushort))
                uint16(lhs).And(uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                int32(lhs).And(int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                uint32(lhs).And(uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                int64(lhs).And(int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                uint64(lhs).And(uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                float32(lhs).And(float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                float64(lhs).And(float64(rhs), float64(dst));                
            else    
                throw unsupported<T>();
            return dst;        
        } 
 
        public static Span128<T> Or<T>(this ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, Span128<T> dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                int8(lhs).Or(int8(rhs), int8(dst));
            else if (typeof(T) == typeof(byte))
                uint8(lhs).Or(uint8(rhs), uint8(dst));                    
            else if (typeof(T) == typeof(short))
                int16(lhs).Or(int16(rhs), int16(dst));
            else if (typeof(T) == typeof(ushort))
                uint16(lhs).Or(uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                int32(lhs).Or(int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                uint32(lhs).Or(uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                int64(lhs).Or(int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                uint64(lhs).Or(uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                float32(lhs).Or(float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                float64(lhs).Or(float64(rhs), float64(dst));
            else    
                throw unsupported<T>();
            return dst;   
        }


        public static Span256<T> Or<T>(this ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, Span256<T> dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                int8(lhs).Or(int8(rhs), int8(dst));
            else if (typeof(T) == typeof(byte))
                uint8(lhs).Or(uint8(rhs), uint8(dst));                    
            else if (typeof(T) == typeof(short))
                int16(lhs).Or(int16(rhs), int16(dst));
            else if (typeof(T) == typeof(ushort))
                uint16(lhs).Or(uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                int32(lhs).Or(int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                uint32(lhs).Or(uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                int64(lhs).Or(int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                uint64(lhs).Or(uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                float32(lhs).Or(float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                float64(lhs).Or(float64(rhs), float64(dst));
            else    
                throw unsupported<T>();
            return dst;   
        }


        [MethodImpl(Inline)]
        public static Span128<S> ShiftL<S,T>(this ReadOnlySpan128<S> lhs, ReadOnlySpan128<T> shifts, Span128<S> dst)
            where S : struct
            where T : struct
        {
            if(typeof(S) == typeof(int))
                dinxx.shiftl(int32(in lhs), uint32(in shifts), int32(in dst));
            else if(typeof(S) == typeof(uint)) 
                dinxx.shiftl(uint32(in lhs), uint32(in shifts), uint32(in dst));
            else if(typeof(S) == typeof(long))
                dinxx.shiftl(int64(in lhs), uint64(in shifts), int64(in dst));
            else if(typeof(S) == typeof(ulong))
                dinxx.shiftl(uint64(in lhs), uint64(in shifts), uint64(in dst));
            else
                throw unsupported<S>();
            return dst;
        }

        public static Span256<T> ShiftL<S,T>(this ReadOnlySpan256<T> lhs,  ReadOnlySpan256<S> shifts, Span256<T> dst)
            where T : struct
            where S : struct
        {
            if(typeof(S) == typeof(int))
                dinxx.shiftl(int32(in lhs), uint32(in shifts), int32(in dst));
            else if(typeof(S) == typeof(uint)) 
                dinxx.shiftl(uint32(in lhs), uint32(in shifts), uint32(in dst));
            else if(typeof(S) == typeof(long))
                dinxx.shiftl(int64(in lhs), uint64(in shifts), int64(in dst));
            else if(typeof(S) == typeof(ulong))
                dinxx.shiftl(uint64(in lhs), uint64(in shifts), uint64(in dst));
            else
                throw unsupported<S>();
            return dst;
        }


        [MethodImpl(Inline)]
        public static Span128<S> ShiftR<S,T>(this ReadOnlySpan128<S> lhs, ReadOnlySpan128<T> shifts, Span128<S> dst)
            where S : struct
            where T : struct
        {
            if(typeof(S) == typeof(int))
                dinx.shiftr(int32(in lhs), uint32(in shifts), int32(in dst));
            else if(typeof(S) == typeof(uint)) 
                dinx.shiftr(uint32(in lhs), uint32(in shifts), uint32(in dst));
            else if(typeof(S) == typeof(long))
                dinx.shiftr(int64(in lhs), uint64(in shifts), int64(in dst));
            else if(typeof(S) == typeof(ulong))
                dinx.shiftr(uint64(in lhs), uint64(in shifts), uint64(in dst));
            else
                throw unsupported<S>();
            return dst;
        }

        public static Span256<T> shiftr<S,T>(in ReadOnlySpan256<T> lhs, in ReadOnlySpan256<S> shifts, in Span256<T> dst)
            where T : struct
            where S : struct
        {
            if(typeof(S) == typeof(int))
                dinx.shiftr(int32(in lhs), uint32(in shifts), int32(in dst));
            else if(typeof(S) == typeof(uint)) 
                dinx.shiftr(uint32(in lhs), uint32(in shifts), uint32(in dst));
            else if(typeof(S) == typeof(long))
                dinx.shiftr(int64(in lhs), uint64(in shifts), int64(in dst));
            else if(typeof(S) == typeof(ulong))
                dinx.shiftr(uint64(in lhs), uint64(in shifts), uint64(in dst));
            else
                throw unsupported<S>();
            return dst;
        }
        
        public static Span128<T> XOr<T>(this ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, Span128<T> dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                dinxx.XOr(int8(lhs), int8(rhs), int8(dst));
            else if (typeof(T) == typeof(byte))
                dinxx.XOr(uint8(lhs), uint8(rhs), uint8(dst));                    
            else if (typeof(T) == typeof(short))
                dinxx.XOr(int16(lhs), int16(rhs), int16(dst));
            else if (typeof(T) == typeof(ushort))
                dinxx.XOr(uint16(lhs), uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                dinxx.XOr(int32(lhs), int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                dinxx.XOr(uint32(lhs), uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                dinxx.XOr(int64(lhs), int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                dinxx.XOr(uint64(lhs), uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                dinxx.XOr(float32(lhs), float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                dinxx.XOr(float64(lhs), float64(rhs), float64(dst));                
            else    
                throw unsupported<T>();
            return dst;   
        }

        public static Span256<T> XOr<T>(this ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, Span256<T> dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                dinxx.XOr(int8(lhs), int8(rhs), int8(dst));
            else if (typeof(T) == typeof(byte))
                dinxx.XOr(uint8(lhs), uint8(rhs), uint8(dst));                    
            else if (typeof(T) == typeof(short))
                dinxx.XOr(int16(lhs), int16(rhs), int16(dst));
            else if (typeof(T) == typeof(ushort))
                dinxx.XOr(uint16(lhs), uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                dinxx.XOr(int32(lhs), int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                dinxx.XOr(uint32(lhs), uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                dinxx.XOr(int64(lhs), int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                dinxx.XOr(uint64(lhs), uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                dinxx.XOr(float32(lhs), float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                dinxx.XOr(float64(lhs), float64(rhs), float64(dst));                
            else    
                throw unsupported<T>();
            return dst;   
        }

    }

}
