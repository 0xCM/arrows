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

    public readonly struct num<T>
        where T : struct
    {
        readonly T x;

        public static readonly IPrimalInfo<T> NumInfo = PrimalInfo.Get<T>();

        public static readonly bool Signed = NumInfo.Signed;

        public static readonly int ByteSize = NumInfo.Size;

        public static readonly int BitSize = NumInfo.Size*8;

        public static readonly num<T> MinVal = NumInfo.MinVal;

        public static readonly num<T> MaxVal = NumInfo.MaxVal;

        public static readonly num<T> Zero = Num.zero<T>();

        public static readonly num<T> One = Num.one<T>();

        [MethodImpl(Inline)]
        public static explicit operator sbyte(num<T> src)
            => convert(src.Value, out sbyte x);

        [MethodImpl(Inline)]
        public static explicit operator byte(num<T> src)
            => convert(src.Value, out byte x);

        [MethodImpl(Inline)]
        public static explicit operator short(num<T> src)
            => convert(src.Value, out short x);

        [MethodImpl(Inline)]
        public static explicit operator ushort(num<T> src)
            => convert(src.Value, out ushort x);

        [MethodImpl(Inline)]
        public static explicit operator int(num<T> src)
            => convert(src.Value, out int x);

        [MethodImpl(Inline)]
        public static explicit operator uint(num<T> src)
            => convert(src.Value, out uint x);

        [MethodImpl(Inline)]
        public static explicit operator long(num<T> src)
            => convert(src.Value, out long x);

        [MethodImpl(Inline)]
        public static explicit operator ulong(num<T> src)
            => convert(src.Value, out ulong x);

        [MethodImpl(Inline)]
        public static explicit operator float(num<T> src)
            => convert(src.Value, out float x);

        [MethodImpl(Inline)]
        public static explicit operator double(num<T> src)
            => convert(src.Value, out double x);

        [MethodImpl(Inline)]
        public static explicit operator num<T>(sbyte src)
            => generic<T>(src);

        [MethodImpl(Inline)]
        public static explicit operator num<T>(byte src)
            => generic<T>(src);

        [MethodImpl(Inline)]
        public static explicit operator num<T>(short src)
            => generic<T>(src);

        [MethodImpl(Inline)]
        public static explicit operator num<T>(ushort src)
            => generic<T>(src);

        [MethodImpl(Inline)]
        public static explicit operator num<T>(int src)
            => generic<T>(ref src);

        [MethodImpl(Inline)]
        public static explicit operator num<T>(uint src)
            => generic<T>(ref src);

        [MethodImpl(Inline)]
        public static explicit operator num<T>(long src)
            => As.generic<T>(ref src);

        [MethodImpl(Inline)]
        public static explicit operator num<T>(ulong src)
            => As.generic<T>(ref src);

        [MethodImpl(Inline)]
        public static explicit operator num<T>(float src)
            => As.generic<T>(ref src);

        [MethodImpl(Inline)]
        public static explicit operator num<T>(double src)
            => As.generic<T>(ref src);

        [MethodImpl(Inline)]
        static ref num<T> toNum(ref T src)
            => ref Unsafe.As<T,num<T>>(ref src);

        [MethodImpl(Inline)]
        public static implicit operator num<T>(T src)
            =>  toNum(ref src);

        [MethodImpl(Inline)]
        public static implicit operator T(num<T> src)
            => scalar(ref src);

        [MethodImpl(Inline)]
        public static num<T> operator + (num<T> lhs, num<T> rhs) 
        {
            gmath.add(ref scalar(ref lhs), scalar(ref rhs));            
            return lhs;
        }

        [MethodImpl(Inline)]
        public static num<T> operator - (num<T> lhs, num<T> rhs) 
        {
            gmath.sub(ref scalar(ref lhs), scalar(ref rhs));            
            return lhs;
        }

        [MethodImpl(Inline)]
        public static num<T> operator * (num<T> lhs, num<T> rhs) 
        {
            gmath.mul(ref scalar(ref lhs), scalar(ref rhs));            
            return lhs;
        }

        [MethodImpl(Inline)]
        public static num<T> operator / (num<T> lhs, num<T> rhs) 
        {
            gmath.div(ref scalar(ref lhs), scalar(ref rhs));            
            return lhs;
        }

        [MethodImpl(Inline)]
        public static num<T> operator % (num<T> lhs, num<T> rhs)
            => gmath.mod(scalar(ref lhs),scalar(ref rhs));

        [MethodImpl(Inline)]
        public static num<T> operator - (num<T> src) 
            => src.Dec();

        [MethodImpl(Inline)]
        public static num<T> operator ++ (num<T> src) 
            => src.Inc();

        [MethodImpl(Inline)]
        public static num<T> operator -- (num<T> src) 
            => gmath.dec(ref scalar(ref src));

        [MethodImpl(Inline)]
        public static bool operator == (num<T> lhs, num<T> rhs) 
            => gmath.eq(scalar(ref lhs), scalar(ref rhs));

        [MethodImpl(Inline)]
        public static bool operator != (num<T> lhs, num<T> rhs) 
            => gmath.neq(scalar(ref lhs), scalar(ref rhs));

        [MethodImpl(Inline)]
        public static bool operator < (num<T> lhs, num<T> rhs) 
            => gmath.lt(scalar(ref lhs), scalar(ref rhs));

        [MethodImpl(Inline)]
        public static bool operator <= (num<T> lhs, num<T> rhs) 
            => gmath.lteq(scalar(ref lhs),scalar(ref rhs));

        [MethodImpl(Inline)]
        public static bool operator > (num<T> lhs, num<T> rhs) 
            => gmath.gt(scalar(ref lhs),scalar(ref rhs));

        [MethodImpl(Inline)]
        public static bool operator >= (num<T> lhs, num<T> rhs) 
            => gmath.gteq(scalar(ref lhs),scalar(ref rhs));

        [MethodImpl(Inline)]
        public static num<T> operator & (num<T> lhs, num<T> rhs) 
            => gmath.and(ref scalar(ref lhs),scalar(ref rhs));

        [MethodImpl(Inline)]
        public static num<T> operator | (num<T> lhs, num<T> rhs) 
            => gmath.or(ref scalar(ref lhs),scalar(ref rhs));

        [MethodImpl(Inline)]
        public static num<T> operator ^ (num<T> lhs, num<T> rhs) 
            => gmath.xor(ref scalar(ref lhs),scalar(ref rhs));

        [MethodImpl(Inline)]
        public static num<T> operator ~ (num<T> src) 
            => gmath.flip(ref scalar(ref src));

        [MethodImpl(Inline)]
        public static num<T> abs(num<T> src)
            => gmath.abs(ref scalar(ref src));

        [MethodImpl(Inline)]
        public static num<T> pow(num<T> src, uint exp)
            => gmath.pow(scalar(ref src), exp);

        [MethodImpl(Inline)]
        public bool Equals(num<T> rhs)
        {
            var lhs = this;
            return gmath.eq(scalar(ref lhs), scalar(ref rhs));
        }
         
        public T Value
        {
            [MethodImpl(Inline)]
            get
            {
                var src = this;
                return scalar(ref src);
            }            
        }   


        [MethodImpl(Inline)]
        public override int GetHashCode()
            => throw new NotSupportedException();

        public override bool Equals(object rhs)
            => throw new NotSupportedException();

        public override string ToString()
        {
            var src = this;
            return scalar(ref src).ToString();
        }
    }
}