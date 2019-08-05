//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
    
    
    using static zfunc;
    using static As;

    public struct num<T>
        where T : struct
    {
        readonly T x;

        public static readonly IPrimalInfo<T> NumInfo = PrimalInfo.Get<T>();

        public static readonly bool Signed = NumInfo.Signed;

        public static readonly int ByteSize = NumInfo.ByteSize;

        public static readonly ulong BitSize = NumInfo.BitSize;

        public static readonly num<T> Zero = Num.zero<T>();

        public static readonly num<T> One = Num.one<T>();

        [MethodImpl(Inline)]
        static ref T scalar(ref num<T> src)
            => ref Unsafe.As<num<T>,T>(ref src);

        [MethodImpl(Inline)]
        static T unwrap(in num<T> src)
            => Unsafe.As<num<T>,T>(ref As.asRef(in src));

        [MethodImpl(Inline)]
        public static explicit operator sbyte(num<T> src)
            => convert(scalar(ref src), out sbyte x);

        [MethodImpl(Inline)]
        public static explicit operator byte(num<T> src)
            => convert(scalar(ref src), out byte x);

        [MethodImpl(Inline)]
        public static explicit operator short(num<T> src)
            => convert(scalar(ref src), out short x);

        [MethodImpl(Inline)]
        public static explicit operator ushort(num<T> src)
            => convert(scalar(ref src), out ushort x);

        [MethodImpl(Inline)]
        public static explicit operator int(num<T> src)
            => convert(scalar(ref src), out int x);

        [MethodImpl(Inline)]
        public static explicit operator uint(num<T> src)
            => convert(scalar(ref src), out uint x);

        [MethodImpl(Inline)]
        public static explicit operator long(num<T> src)
            => convert(scalar(ref src), out long x);

        [MethodImpl(Inline)]
        public static explicit operator ulong(num<T> src)
            => convert(scalar(ref src), out ulong x);

        [MethodImpl(Inline)]
        public static explicit operator float(num<T> src)
            => convert(scalar(ref src), out float x);

        [MethodImpl(Inline)]
        public static explicit operator double(num<T> src)
            => convert(scalar(ref src), out double x);

        [MethodImpl(Inline)]
        public static explicit operator num<T>(sbyte src)
            => toNum(ref generic<T>(ref src));

        [MethodImpl(Inline)]
        public static explicit operator num<T>(byte src)
            => toNum(ref generic<T>(ref src));

        [MethodImpl(Inline)]
        public static explicit operator num<T>(short src)
            => toNum(ref generic<T>(ref src));

        [MethodImpl(Inline)]
        public static explicit operator num<T>(ushort src)
            => toNum(ref generic<T>(ref src));

        [MethodImpl(Inline)]
        public static explicit operator num<T>(int src)
            => toNum(ref generic<T>(ref src));

        [MethodImpl(Inline)]
        public static explicit operator num<T>(uint src)
            => toNum(ref generic<T>(ref src));

        [MethodImpl(Inline)]
        public static explicit operator num<T>(long src)
            => toNum(ref generic<T>(ref src));

        [MethodImpl(Inline)]
        public static explicit operator num<T>(ulong src)
            => toNum(ref generic<T>(ref src));

        [MethodImpl(Inline)]
        public static explicit operator num<T>(float src)
            => toNum(ref generic<T>(ref src));

        [MethodImpl(Inline)]
        public static explicit operator num<T>(double src)
            => toNum(ref generic<T>(ref src));

        static ref num<T> toNum(ref T src)
            => ref Unsafe.As<T,num<T>>(ref  src);

        [MethodImpl(Inline)]
        public static implicit operator num<T>(T src)
            => Unsafe.As<T,num<T>>(ref  src);

        [MethodImpl(Inline)]
        public static num<T> operator + (in num<T> lhs, in num<T> rhs) 
        {
            var result = gmath.add(unwrap(lhs), unwrap(rhs));            
            return Unsafe.As<T,num<T>>(ref result);
        }
        
        [MethodImpl(Inline)]
        public static num<T> operator - (in num<T> lhs, in num<T> rhs) 
        {
            var result = gmath.sub(unwrap(lhs), unwrap(rhs));            
            return Unsafe.As<T,num<T>>(ref result);
        }

        [MethodImpl(Inline)]
        public static num<T> operator * (in num<T> lhs, in num<T> rhs) 
        {
            var result = gmath.mul(unwrap(lhs), unwrap(rhs));            
            return Unsafe.As<T,num<T>>(ref result);
        }

        [MethodImpl(Inline)]
        public static num<T> operator / (in num<T> lhs, in num<T> rhs) 
        {
            var result = gmath.div(unwrap(lhs), unwrap(rhs));            
            return Unsafe.As<T,num<T>>(ref result);
        }

        [MethodImpl(Inline)]
        public static num<T> operator % (in num<T> lhs, in num<T> rhs)
        {
            var result = gmath.mod(unwrap(lhs), unwrap(rhs));            
            return Unsafe.As<T,num<T>>(ref result);
        }

        [MethodImpl(Inline)]
        public static num<T> operator - (in num<T> src) 
        {
            var result = gmath.negate(unwrap(src));            
            return Unsafe.As<T,num<T>>(ref result);
        }

        [MethodImpl(Inline)]
        public static num<T> operator ++ (num<T> src) 
        {
            var result = gmath.inc(unwrap(src));            
            return Unsafe.As<T,num<T>>(ref result);
        }

        [MethodImpl(Inline)]
        public static num<T> operator -- (num<T> src) 
        {
            var result = gmath.dec(unwrap(src));            
            return Unsafe.As<T,num<T>>(ref result);
        }

        [MethodImpl(Inline)]
        public static bool operator == (num<T> lhs, in num<T> rhs) 
            => gmath.eq(unwrap(lhs), unwrap(rhs));            
            
        [MethodImpl(Inline)]
        public static bool operator != (in num<T> lhs, in num<T> rhs) 
            => gmath.neq(unwrap(lhs), unwrap(rhs));            

        [MethodImpl(Inline)]
        public static bool operator < (num<T> lhs, in num<T> rhs) 
            => gmath.lt(unwrap(lhs), unwrap(rhs));            

        [MethodImpl(Inline)]
        public static bool operator <= (num<T> lhs, in num<T> rhs) 
            => gmath.lteq(unwrap(lhs), unwrap(rhs));            

        [MethodImpl(Inline)]
        public static bool operator > (num<T> lhs, in num<T> rhs) 
            => gmath.gt(unwrap(lhs), unwrap(rhs));            

        [MethodImpl(Inline)]
        public static bool operator >= (num<T> lhs, in num<T> rhs) 
            => gmath.gteq(unwrap(lhs), unwrap(rhs));            


        [MethodImpl(Inline)]
        public static num<T> operator | (num<T> lhs, in num<T> rhs) 
        {
            var result = lhs.Or(unwrap(rhs));            
            return Unsafe.As<T,num<T>>(ref result);
        }

        [MethodImpl(Inline)]
        public static num<T> operator ^ (num<T> lhs, in num<T> rhs) 
        {
            var result = gmath.xor(unwrap(lhs), unwrap(rhs));            
            return Unsafe.As<T,num<T>>(ref result);
        }

        [MethodImpl(Inline)]
        public static num<T> operator ~ (num<T> src) 
        {
            var result = gmath.flip(unwrap(src));            
            return Unsafe.As<T,num<T>>(ref result);
        }

        [MethodImpl(Inline)]
        public bool Eq(num<T> rhs)
             => gmath.eq(unwrap(this), unwrap(rhs));            
       
        [MethodImpl(Inline)]
        public override int GetHashCode()
            => throw new NotSupportedException();

        public override bool Equals(object rhs)
            => throw new NotSupportedException();

        public override string ToString()
        {
            var x = scalar(ref this);
            return x.ToString();
        }

        [MethodImpl(Inline)]
        public T Or(T rhs)
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>((sbyte)(int8(x) | int8(rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>((byte)(uint8(x) | uint8(rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>((short)(int16(x) | int16(rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>((ushort)(uint16(x) | uint16(rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(int32(x) | int32(x));
            else if(typeof(T) == typeof(uint))
                return generic<T>(uint32(x) | uint32(rhs));
            else if(typeof(T) == typeof(long))
                return generic<T>(int64(x) | int64(rhs));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(uint64(x) | uint64(rhs));
            else            
                throw unsupported<T>();
        }       




    }
}