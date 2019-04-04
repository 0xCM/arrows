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

    using static zcore;
    using static Structures;
    using reify = int32;
    using operand = System.Int32;

    public readonly struct int32 : Structures.Integer<reify, operand>, Formattable
    {
    
        public static readonly reify Zero = 0;

        public static readonly reify One = 1;

        public static readonly reify MinVal = operand.MinValue;

        public static readonly reify MaxVal = operand.MaxValue;

        public const int BitSize = sizeof(operand) * 8;
        
        public const bool Signed = true;

        [MethodImpl(Inline)]    
        public static int32 define(int src)
            => new int32(src);

        [MethodImpl(Inline)]    
        public static int @bool(bool x)
            => x ? 1 : 0;

        [MethodImpl(Inline)]
        public static implicit operator reify(int src)
            => new reify(src);

        [MethodImpl(Inline)]
        public static implicit operator int(reify src)
            => src.data;

        [MethodImpl(Inline)]
        public static explicit operator byte(reify src)
            => (byte)src.data;

        [MethodImpl(Inline)]
        public static explicit operator sbyte(reify src)
            => (sbyte)src.data;

        [MethodImpl(Inline)]
        public static explicit operator short(reify src)
            => (short)src.data;

        [MethodImpl(Inline)]
        public static explicit operator ushort(reify src)
            => (ushort)src.data;

        [MethodImpl(Inline)]
        public static explicit operator uint(reify src)
            => (uint)src.data;

        [MethodImpl(Inline)]
        public static explicit operator long(reify src)
            => src.data;

        [MethodImpl(Inline)]
        public static explicit operator ulong(reify src)
            => (ulong)src.data;

        [MethodImpl(Inline)]    
        public static bool operator true(reify x)
            => x.data != 0;

        [MethodImpl(Inline)]    
        public static bool operator false(reify x)
            => x.data == 0;

        [MethodImpl(Inline)]
        public static bool operator == (reify lhs, reify rhs) 
            => lhs.data == rhs.data;

        [MethodImpl(Inline)]
        public static bool operator != (reify lhs, reify rhs) 
            => lhs.data != rhs.data;

        [MethodImpl(Inline)]
        public static reify operator + (reify lhs, reify rhs) 
            => lhs.data + rhs.data;

        [MethodImpl(Inline)]
        public static reify operator - (reify lhs, reify rhs) 
            => lhs.data - rhs.data;

        [MethodImpl(Inline)]
        public static reify operator -- (reify x) 
            =>  x.data - 1;

        [MethodImpl(Inline)]
        public static reify operator ++ (reify x) 
            =>  x.data + 1;

        [MethodImpl(Inline)]
        public static reify operator - (reify x) 
            => -x.data;

        [MethodImpl(Inline)]
        public static reify operator * (reify lhs, reify rhs) 
            => lhs.data * rhs.data;

        [MethodImpl(Inline)]
        public static reify operator / (reify lhs, reify rhs) 
            => lhs.data / rhs.data;

        [MethodImpl(Inline)]
        public static reify operator % (reify lhs, reify rhs)
            => lhs.data % rhs.data;

        [MethodImpl(Inline)]
        public static bool operator < (reify lhs, reify rhs) 
            => lhs.data < rhs.data;

        [MethodImpl(Inline)]
        public static bool operator <= (reify lhs, reify rhs) 
            => lhs.data <= rhs.data;

        [MethodImpl(Inline)]
        public static bool operator > (reify lhs, reify rhs) 
            => lhs.data > rhs.data;

        [MethodImpl(Inline)]
        public static bool operator >= (reify lhs, reify rhs) 
            => lhs.data >= rhs.data;

        [MethodImpl(Inline)]
        public static reify operator & (reify lhs, reify rhs) 
            => lhs.data & rhs.data;

        [MethodImpl(Inline)]
        public static reify operator | (reify lhs, reify rhs) 
            => lhs.data | rhs.data;

        [MethodImpl(Inline)]
        public static reify operator ^ (reify lhs, reify rhs) 
            => lhs.data ^ rhs.data;

        [MethodImpl(Inline)]
        public static reify operator ~ (reify x) 
            => ~ x.data;

        [MethodImpl(Inline)]
        public static reify operator >> (reify lhs, int rhs) 
            => lhs.data >> rhs;

        [MethodImpl(Inline)]
        public static reify operator << (reify lhs, int rhs) 
            => lhs.data << rhs;

        public reify zero 
        {
            [MethodImpl(Inline)]
            get{return Zero;}
        }

        public reify one 
        {
            [MethodImpl(Inline)]
            get{return One;}
        }

        public reify bitsize 
            => BitSize;

        public NumberInfo<reify> numinfo 
            => new NumberInfo<reify>((MinVal, MaxVal),Signed,Zero, One, BitSize);

        readonly int data;

        [MethodImpl(Inline)]
        public int32(operand x) 
            => data = x;

        [MethodImpl(Inline)]
        public reify inc()
            => this + One;

        [MethodImpl(Inline)]
        public reify dec() 
            => this - One;

        [MethodImpl(Inline)]
        public reify negate()
            => -this;

        [MethodImpl(Inline)]
        public reify add(reify rhs)
            => this + rhs;

        [MethodImpl(Inline)]
        public reify sub(reify rhs)
            => this - rhs;

        [MethodImpl(Inline)]
        public reify mul(reify rhs)
            => this * rhs;
        
        [MethodImpl(Inline)]
        public reify div(reify rhs)
            => this / rhs;

        [MethodImpl(Inline)]
        public reify mod(reify rhs)
            => this % rhs;

        [MethodImpl(Inline)]
        public bool divides(reify lhs)
            => lhs % this == Zero;

        [MethodImpl(Inline)]
        public reify pow(int exp)
            => fold(repeat(data,exp), (x,y) => x*y ,One);        
        
        [MethodImpl(Inline)]
        public bool even()
            => this % 2 == Zero;

        [MethodImpl(Inline)]
        public bool odd()
            => not(even());

        [MethodImpl(Inline)]
        public Quorem<reify> divrem(reify rhs)
        {
            var quo = this/rhs;
            var rem = this - quo * rhs;
            return Quorem.define(quo, rem);
        }

        [MethodImpl(Inline)]
        public reify and(reify rhs)
            => this & rhs;

        [MethodImpl(Inline)]
        public reify or(reify rhs)
            => this | rhs;

        [MethodImpl(Inline)]
        public reify xor(reify rhs)
            => this ^ rhs;

        [MethodImpl(Inline)]
        public reify flip()
            => ~ this;

        [MethodImpl(Inline)]
        public reify lshift(int rhs)
            => this << rhs;

        [MethodImpl(Inline)]
        public reify rshift(int rhs)
            => this >> rhs;

        [MethodImpl(Inline)]
        public bool eq(reify rhs)
            => this == rhs;

        [MethodImpl(Inline)]
        public bool neq(reify rhs)
            => this != rhs;
 
        [MethodImpl(Inline)]
        public bool lteq(reify rhs) 
            => this <= rhs;

        [MethodImpl(Inline)]
        public bool gteq(reify rhs) 
            => this >= rhs;

        [MethodImpl(Inline)]
        public bool lt(reify rhs) 
            => this < rhs;

        [MethodImpl(Inline)]
        public bool gt(reify rhs) 
            => this > rhs;

        [MethodImpl(Inline)]
        public reify abs()
            => data < Zero ? -data : data;

        [MethodImpl(Inline)]
        public Sign sign()
            => nonzero() ? Sign.Neutral : 
               this < Zero ? Sign.Negative :
               Sign.Positive;

        [MethodImpl(Inline)]
        public reify gcd(reify other)
        {
            var lhs = abs().data;
            var rhs = other.abs().data;
            while (rhs != Zero)
            {
                var rem = lhs % rhs;
                lhs = rhs;
                rhs = rem;
            }
            return lhs;
        }

        [MethodImpl(Inline)]
        public BitString bitstring()
            => BitString.define(data);

        [MethodImpl(Inline)]
        public reify distributeL((reify x, reify y) rhs)
            => this * rhs.x + this * rhs.y;
 
        [MethodImpl(Inline)]
        public reify distributeR((reify x, reify y) rhs)
            => rhs.x * this + rhs.y * this;

        [MethodImpl(Inline)]
        public bool nonzero()
            => data != 0;

        [MethodImpl(Inline)]
        public byte[] digits()
            => (from c in data.ToString() 
                    select byte.Parse(c.ToString())).ToArray();
        
        [MethodImpl(Inline)]
        public reify muladd(reify y, reify z)
            => this * y + z;

        [MethodImpl(Inline)]
        public reify sin()
            => (operand)MathF.Sin(this.data);

        [MethodImpl(Inline)]
        public reify sinh()
            => (operand)MathF.Sinh(this.data);

        [MethodImpl(Inline)]
        public reify asin()
            => (operand)MathF.Asin(this.data);

        [MethodImpl(Inline)]
        public reify asinh()
            => (operand)MathF.Asinh(this.data);

        [MethodImpl(Inline)]
        public reify cos()
            => (operand)MathF.Cos(this.data);

        [MethodImpl(Inline)]
        public reify cosh()
            => (operand)MathF.Cosh(this.data);

        [MethodImpl(Inline)]
        public reify acos()
            => (operand)MathF.Acos(this.data);

        [MethodImpl(Inline)]
        public reify acosh()
            => (operand)MathF.Acosh(this.data);

        [MethodImpl(Inline)]
        public reify tan()
            => (operand)MathF.Tan(this.data);

        [MethodImpl(Inline)]
        public reify tanh()
            => (operand)MathF.Tanh(this.data);

        [MethodImpl(Inline)]
        public reify atan()
            => (operand)MathF.Atan(this.data);

        [MethodImpl(Inline)]
        public reify atanh()
            => (operand)MathF.Atanh(this.data);

        [MethodImpl(Inline)]
        public int CompareTo(reify other)
            => data.CompareTo(other.data);

        [MethodImpl(Inline)]
        public bool eq(reify lhs, reify rhs)
            => lhs == rhs;
 
        [MethodImpl(Inline)]
        public bool neq(reify lhs, reify rhs)
            => lhs != rhs;
 
        [MethodImpl(Inline)]
        public reify min(reify rhs)
            => rhs < this ? rhs : this;

        [MethodImpl(Inline)]
        public reify max(reify rhs) 
            => rhs > this ? rhs : this;

        [MethodImpl(Inline)]
        public bool Equals(reify rhs)
                => this == rhs;

        [MethodImpl(Inline)]
        public int hash()
            => data.GetHashCode();

        public string format()
            => data.ToString();

        public override int GetHashCode()
            => hash();

        public override bool Equals(object rhs)
            => data.Equals(rhs);
        
        public override string ToString()
            => data.ToString();

    }

}