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

    public struct num<T> : IEquatable<num<T>>
        where T : struct
    {
        T x;

        public static readonly IPrimalInfo<T> NumInfo = PrimalInfo.Get<T>();

        public static readonly bool Signed = NumInfo.Signed;

        public static readonly ByteSize ByteSize = NumInfo.ByteSize;

        public static readonly BitSize BitSize = NumInfo.BitSize;

        public static readonly num<T> Zero = Num.zero<T>();

        public static readonly num<T> One = Num.one<T>();

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
            ref var result = ref gmath.add(ref unwrap(in lhs), unwrap(rhs));            
            return Unsafe.As<T,num<T>>(ref result);
        }
        
        [MethodImpl(Inline)]
        public static num<T> operator - (in num<T> lhs, in num<T> rhs) 
        {
            ref var result = ref gmath.sub(ref unwrap(in lhs), unwrap(rhs));            
            return Unsafe.As<T,num<T>>(ref result);
        }

        [MethodImpl(Inline)]
        public static num<T> operator * (in num<T> lhs, in num<T> rhs) 
        {
            ref var result = ref gmath.mul(ref unwrap(in lhs), unwrap(rhs));            
            return Unsafe.As<T,num<T>>(ref result);
        }

        [MethodImpl(Inline)]
        public static num<T> operator / (in num<T> lhs, in num<T> rhs) 
        {
            ref var result = ref gmath.div(ref unwrap(in lhs), unwrap(rhs));            
            return Unsafe.As<T,num<T>>(ref result);
        }

        [MethodImpl(Inline)]
        public static num<T> operator % (in num<T> lhs, in num<T> rhs)
        {
            ref var result = ref gmath.mod(ref unwrap(in lhs), unwrap(rhs));            
            return Unsafe.As<T,num<T>>(ref result);
        }

        [MethodImpl(Inline)]
        public static num<T> operator - (in num<T> src) 
        {
            ref var result = ref gmath.negate(ref unwrap(in src));            
            return Unsafe.As<T,num<T>>(ref result);
        }

        [MethodImpl(Inline)]
        public static num<T> operator ++ (in num<T> src) 
        {
            ref var result = ref gmath.inc(ref unwrap(in src));            
            return Unsafe.As<T,num<T>>(ref result);
        }

        [MethodImpl(Inline)]
        public static num<T> operator -- (in num<T> src) 
        {
            ref var result = ref gmath.dec(ref unwrap(in src));            
            return Unsafe.As<T,num<T>>(ref result);
        }

        [MethodImpl(Inline)]
        public static num<T> operator & (in num<T> lhs, in num<T> rhs) 
        {
            ref var result = ref gmath.and(ref unwrap(in lhs), in unwrap(in rhs));
            return Unsafe.As<T,num<T>>(ref result);
        }

        [MethodImpl(Inline)]
        public static num<T> operator | (num<T> lhs, in num<T> rhs) 
        {
            ref var result = ref gmath.or(ref unwrap(in lhs), in unwrap(in rhs));
            return Unsafe.As<T,num<T>>(ref result);
        }

        [MethodImpl(Inline)]
        public static num<T> operator ^ (num<T> lhs, in num<T> rhs) 
        {
            ref var result = ref gmath.xor(ref unwrap(in lhs), in unwrap(in rhs));
            return Unsafe.As<T,num<T>>(ref result);
        }

        [MethodImpl(Inline)]
        public static bool operator == (in num<T> lhs, in num<T> rhs) 
            => gmath.eq(unwrap(lhs), unwrap(rhs));            
            
        [MethodImpl(Inline)]
        public static bool operator != (in num<T> lhs, in num<T> rhs) 
            => gmath.neq(unwrap(lhs), unwrap(rhs));            

        [MethodImpl(Inline)]
        public static bool operator < (in num<T> lhs, in num<T> rhs) 
            => gmath.lt(unwrap(lhs), unwrap(rhs));            

        [MethodImpl(Inline)]
        public static bool operator <= (in num<T> lhs, in num<T> rhs) 
            => gmath.lteq(unwrap(lhs), unwrap(rhs));            

        [MethodImpl(Inline)]
        public static bool operator > (in num<T> lhs, in num<T> rhs) 
            => gmath.gt(unwrap(lhs), unwrap(rhs));            

        [MethodImpl(Inline)]
        public static bool operator >= (in num<T> lhs, in num<T> rhs) 
            => gmath.gteq(unwrap(in lhs), unwrap(in rhs));            

        [MethodImpl(Inline)]
        public bool Equals(num<T> rhs)
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

        /// <summary>
        /// Converts a generic number to a bitstring
        /// </summary>
        /// <param name="src">The source number</param>
        /// <typeparam name="T">The underlying primal type</typeparam>
        [MethodImpl(Inline)]
        public BitString ToBitString()
            => BitString.FromScalar<T>(in scalar(ref this));
 
         [MethodImpl(Inline)]
        static ref T scalar(ref num<T> src)
            => ref Unsafe.As<num<T>,T>(ref src);

        [MethodImpl(Inline)]
        static ref T unwrap(in num<T> src)
            => ref Unsafe.As<num<T>,T>(ref As.asRef(in src));

    }
}