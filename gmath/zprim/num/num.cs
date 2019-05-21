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
    
    
    using static mfunc;
    using static zfunc;
    using static As;

    public struct num<T>
        where T : struct
    {
        readonly T x;

        public static readonly IPrimalInfo<T> NumInfo = PrimalInfo.Get<T>();

        public static readonly bool Signed = NumInfo.Signed;

        public static readonly int ByteSize = NumInfo.Size;

        public static readonly int BitSize = NumInfo.Size*8;


        public static readonly num<T> Zero = Num.zero<T>();

        public static readonly num<T> One = Num.one<T>();

        [MethodImpl(Inline)]
        static ref T scalar(ref num<T> src)
            => ref Unsafe.As<num<T>,T>(ref src);

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
        public static num<T> operator + (num<T> lhs, in num<T> rhs) 
            => lhs.Add(rhs);
        
        [MethodImpl(Inline)]
        public static num<T> operator - (num<T> lhs, in num<T> rhs) 
            => lhs.Sub(rhs);

        [MethodImpl(Inline)]
        public static num<T> operator * (num<T> lhs, in num<T> rhs) 
            => lhs.Mul(rhs);

        [MethodImpl(Inline)]
        public static num<T> operator / (num<T> lhs, in num<T> rhs) 
            => lhs.Div(rhs);

        [MethodImpl(Inline)]
        public static num<T> operator % (num<T> lhs, in num<T> rhs)
            => lhs.Mod(rhs);

        [MethodImpl(Inline)]
        public static num<T> operator - (num<T> src) 
            => src.Negate();

        [MethodImpl(Inline)]
        public static num<T> operator ++ (num<T> src) 
            => src.Inc();

        [MethodImpl(Inline)]
        public static num<T> operator -- (num<T> src) 
            => src.Negate();

        [MethodImpl(Inline)]
        public static bool operator == (num<T> lhs, in num<T> rhs) 
            => lhs.Eq(rhs);

        [MethodImpl(Inline)]
        public static bool operator != (in num<T> lhs, in num<T> rhs) 
            => lhs.NEq(rhs);

        [MethodImpl(Inline)]
        public static bool operator < (num<T> lhs, in num<T> rhs) 
            => lhs.Lt(rhs);

        [MethodImpl(Inline)]
        public static bool operator <= (num<T> lhs, in num<T> rhs) 
            => lhs.LtEq(rhs);

        [MethodImpl(Inline)]
        public static bool operator > (num<T> lhs, in num<T> rhs) 
            => lhs.Gt(rhs);

        [MethodImpl(Inline)]
        public static bool operator >= (num<T> lhs, in num<T> rhs) 
            => lhs.GtEq(rhs);

        [MethodImpl(Inline)]
        public static num<T> operator & (num<T> lhs, in num<T> rhs) 
            => lhs.And(rhs);

        [MethodImpl(Inline)]
        public static num<T> operator | (num<T> lhs, in num<T> rhs) 
            => lhs.Or(rhs);

        [MethodImpl(Inline)]
        public static num<T> operator ^ (num<T> lhs, in num<T> rhs) 
            => lhs.XOr(rhs);

        [MethodImpl(Inline)]
        public static num<T> operator ~ (num<T> src) 
            => src.Flip();

        [MethodImpl(Inline)]
        public bool Eq(num<T> rhs)
            => gmath.eq(this.Scalar(), rhs.Scalar());
        
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
            
    }
}