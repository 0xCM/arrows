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
    
    public readonly struct num<T> : IEquatable<num<T>>
        where T : struct, IEquatable<T>
    {
        readonly T placeholder;

        public static readonly IPrimalInfo<T> NumInfo = PrimalInfo.Get<T>();

        public static readonly bool Signed = NumInfo.Signed;

        public static readonly int ByteSize = NumInfo.Size;

        public static readonly int BitSize = NumInfo.Size*8;

        public static readonly num<T> MinVal = NumInfo.MinVal;

        public static readonly num<T> MaxVal = NumInfo.MaxVal;

        public static readonly num<T> Zero = gmath.zero<T>();

        public static readonly num<T> One = gmath.one<T>();
        
        [MethodImpl(Inline)]
        static ref num<T> toNum(ref T src)
            => ref Unsafe.As<T,num<T>>(ref src);

        [MethodImpl(Inline)]
        static ref T toVal(ref num<T> src)
            => ref Unsafe.As<num<T>,T>(ref src);

        [MethodImpl(Inline)]
        public static implicit operator num<T>(T src)
            =>  toNum(ref src);

        [MethodImpl(Inline)]
        public static implicit operator T(num<T> src)
            => toVal(ref src);

        [MethodImpl(Inline)]
        public static bool operator == (num<T> lhs, num<T> rhs) 
            => gmath.eq(toVal(ref lhs),toVal(ref rhs));

        [MethodImpl(Inline)]
        public static bool operator != (num<T> lhs, num<T> rhs) 
            => gmath.neq(toVal(ref lhs),toVal(ref rhs));

        [MethodImpl(Inline)]
        public static num<T> operator + (num<T> lhs, num<T> rhs) 
            => gmath.add(toVal(ref lhs),toVal(ref rhs));

        [MethodImpl(Inline)]
        public static num<T> operator - (num<T> lhs, num<T> rhs) 
            => gmath.sub(toVal(ref lhs),toVal(ref rhs));

        [MethodImpl(Inline)]
        public static num<T> operator * (num<T> lhs, num<T> rhs) 
            => gmath.mul(toVal(ref lhs),toVal(ref rhs));

        [MethodImpl(Inline)]
        public static num<T> operator / (num<T> lhs, num<T> rhs) 
            => gmath.div(toVal(ref lhs),toVal(ref rhs));

        [MethodImpl(Inline)]
        public static num<T> operator % (num<T> lhs, num<T> rhs)
            => gmath.mod(toVal(ref lhs),toVal(ref rhs));

        [MethodImpl(Inline)]
        public static num<T> operator - (num<T> src) 
            => throw new NotSupportedException();

        [MethodImpl(Inline)]
        public static num<T> operator ++ (num<T> src) 
            => gmath.inc(Unsafe.As<num<T>,T>(ref src));

        [MethodImpl(Inline)]
        public static num<T> operator -- (num<T> src) 
            => gmath.dec(Unsafe.As<num<T>,T>(ref src));

        [MethodImpl(Inline)]
        public static bool operator < (num<T> lhs, num<T> rhs) 
            => gmath.lt(toVal(ref lhs),toVal(ref rhs));

        [MethodImpl(Inline)]
        public static bool operator <= (num<T> lhs, num<T> rhs) 
            => gmath.lteq(toVal(ref lhs),toVal(ref rhs));

        [MethodImpl(Inline)]
        public static bool operator > (num<T> lhs, num<T> rhs) 
            => gmath.gt(toVal(ref lhs),toVal(ref rhs));

        [MethodImpl(Inline)]
        public static bool operator >= (num<T> lhs, num<T> rhs) 
            => gmath.gteq(toVal(ref lhs),toVal(ref rhs));

        [MethodImpl(Inline)]
        public static num<T> operator & (num<T> lhs, num<T> rhs) 
            => gmath.and(toVal(ref lhs),toVal(ref rhs));

        [MethodImpl(Inline)]
        public static num<T> operator | (num<T> lhs, num<T> rhs) 
            => gmath.or(toVal(ref lhs),toVal(ref rhs));

        [MethodImpl(Inline)]
        public static num<T> operator ^ (num<T> lhs, num<T> rhs) 
            => gmath.xor(toVal(ref lhs),toVal(ref rhs));

        [MethodImpl(Inline)]
        public static num<T> operator ~ (num<T> src) 
            => gmath.flip(toVal(ref src));

        [MethodImpl(Inline)]
        public static num<T> abs(num<T> src)
            => gmath.abs(toVal(ref src));

        [MethodImpl(Inline)]
        public static num<T> pow(num<T> src, uint exp)
            => gmath.pow(toVal(ref src), exp);

        [MethodImpl(Inline)]
        public bool Equals(num<T> rhs)
        {
            var lhs = this;
            return gmath.eq(toVal(ref lhs),toVal(ref rhs));
        }
         
        [MethodImpl(Inline)]
        public override int GetHashCode()
        {
            var src = this;
            return toVal(ref src).GetHashCode();
        }

        public override bool Equals(object rhs)
            => throw new NotSupportedException();

        public override string ToString()
        {
            var src = this;
            return toVal(ref src).ToString();
        }
    }
}