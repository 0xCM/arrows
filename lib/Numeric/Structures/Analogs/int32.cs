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
    using static zfunc;

    using static Structures;
    using analog = int32;
    using primitive = System.Int32;

    /// <summary>
    /// Defines a 32-bit signed integer via primitive operations
    /// </summary>
    public readonly struct int32 : IInteger<analog, primitive>, Formattable
    {
    
        static readonly Operative.PrimOps<primitive> Prim = primops.typeops<primitive>();
        
        static readonly NumberInfo<primitive> NumInfo = Prim.numinfo;

        public static readonly analog Zero = NumInfo.Zero;

        public static readonly analog One = NumInfo.One;

        public static readonly analog MinVal = NumInfo.MinVal;

        public static readonly analog MaxVal = NumInfo.MaxVal;

        public static readonly uint BitSize = NumInfo.BitSize;
        
        public const bool Signed = true;

        [MethodImpl(Inline)]    
        public static int32 define(int src)
            => new int32(src);

        [MethodImpl(Inline)]    
        public static int @bool(bool x)
            => x ? 1 : 0;

        [MethodImpl(Inline)]
        public static implicit operator analog(int src)
            => new analog(src);

        [MethodImpl(Inline)]
        public static implicit operator int(analog src)
            => src.data;

        [MethodImpl(Inline)]
        public static explicit operator byte(analog src)
            => (byte)src.data;

        [MethodImpl(Inline)]
        public static explicit operator sbyte(analog src)
            => (sbyte)src.data;

        [MethodImpl(Inline)]
        public static explicit operator short(analog src)
            => (short)src.data;

        [MethodImpl(Inline)]
        public static explicit operator ushort(analog src)
            => (ushort)src.data;

        [MethodImpl(Inline)]
        public static explicit operator uint(analog src)
            => (uint)src.data;

        [MethodImpl(Inline)]
        public static explicit operator long(analog src)
            => src.data;

        [MethodImpl(Inline)]
        public static explicit operator ulong(analog src)
            => (ulong)src.data;

        [MethodImpl(Inline)]    
        public static bool operator true(analog x)
            => x.data != 0;

        [MethodImpl(Inline)]    
        public static bool operator false(analog x)
            => x.data == 0;

        [MethodImpl(Inline)]
        public static bool operator == (analog lhs, analog rhs) 
            => lhs.data == rhs.data;

        [MethodImpl(Inline)]
        public static bool operator != (analog lhs, analog rhs) 
            => lhs.data != rhs.data;

        [MethodImpl(Inline)]
        public static analog operator + (analog lhs, analog rhs) 
            => lhs.data + rhs.data;

        [MethodImpl(Inline)]
        public static analog operator - (analog lhs, analog rhs) 
            => lhs.data - rhs.data;

        [MethodImpl(Inline)]
        public static analog operator -- (analog x) 
            =>  x.data - 1;

        [MethodImpl(Inline)]
        public static analog operator ++ (analog x) 
            =>  x.data + 1;

        [MethodImpl(Inline)]
        public static analog operator - (analog x) 
            => -x.data;

        [MethodImpl(Inline)]
        public static analog operator * (analog lhs, analog rhs) 
            => lhs.data * rhs.data;

        [MethodImpl(Inline)]
        public static analog operator / (analog lhs, analog rhs) 
            => lhs.data / rhs.data;

        [MethodImpl(Inline)]
        public static analog operator % (analog lhs, analog rhs)
            => lhs.data % rhs.data;

        [MethodImpl(Inline)]
        public static bool operator < (analog lhs, analog rhs) 
            => lhs.data < rhs.data;

        [MethodImpl(Inline)]
        public static bool operator <= (analog lhs, analog rhs) 
            => lhs.data <= rhs.data;

        [MethodImpl(Inline)]
        public static bool operator > (analog lhs, analog rhs) 
            => lhs.data > rhs.data;

        [MethodImpl(Inline)]
        public static bool operator >= (analog lhs, analog rhs) 
            => lhs.data >= rhs.data;

        [MethodImpl(Inline)]
        public static analog operator & (analog lhs, analog rhs) 
            => lhs.data & rhs.data;

        [MethodImpl(Inline)]
        public static analog operator | (analog lhs, analog rhs) 
            => lhs.data | rhs.data;

        [MethodImpl(Inline)]
        public static analog operator ^ (analog lhs, analog rhs) 
            => lhs.data ^ rhs.data;

        [MethodImpl(Inline)]
        public static analog operator ~ (analog x) 
            => ~ x.data;

        [MethodImpl(Inline)]
        public static analog operator >> (analog lhs, int rhs) 
            => lhs.data >> rhs;

        [MethodImpl(Inline)]
        public static analog operator << (analog lhs, int rhs) 
            => lhs.data << rhs;

        public analog zero 
        {
            [MethodImpl(Inline)]
            get{return Zero;}
        }

        public analog one 
        {
            [MethodImpl(Inline)]
            get{return One;}
        }

        public NumberInfo<analog> numinfo 
            => new NumberInfo<analog>((MinVal, MaxVal),Signed,Zero, One, BitSize);

        readonly int data;

        [MethodImpl(Inline)]
        public int32(primitive x) 
            => data = x;

        [MethodImpl(Inline)]
        public int unwrap()
            => data;

        [MethodImpl(Inline)]
        public analog inc()
            => this + One;

        [MethodImpl(Inline)]
        public analog dec() 
            => this - One;

        [MethodImpl(Inline)]
        public analog negate()
            => -this;

        [MethodImpl(Inline)]
        public analog add(analog rhs)
            => this + rhs;

        [MethodImpl(Inline)]
        public analog sub(analog rhs)
            => this - rhs;

        [MethodImpl(Inline)]
        public analog mul(analog rhs)
            => this * rhs;
        
        [MethodImpl(Inline)]
        public analog div(analog rhs)
            => this / rhs;

        [MethodImpl(Inline)]
        public analog mod(analog rhs)
            => this % rhs;

        [MethodImpl(Inline)]
        public bool divides(analog lhs)
            => lhs % this == Zero;

        [MethodImpl(Inline)]
        public analog pow(int exp)
            => fold(repeat(data,exp), (x,y) => x*y ,One);        
        
        [MethodImpl(Inline)]
        public bool even()
            => this % 2 == Zero;

        [MethodImpl(Inline)]
        public bool odd()
            => not(even());

        [MethodImpl(Inline)]
        public Quorem<analog> divrem(analog rhs)
        {
            var quo = this/rhs;
            var rem = this - quo * rhs;
            return Quorem.define(quo, rem);
        }


        [MethodImpl(Inline)]
        public byte[] bytes()
            => Prim.bytes(data);

        [MethodImpl]
        public bool testbit(int pos)
            => Prim.testbit(data,pos);

        [MethodImpl(Inline)]
        public analog and(analog rhs)
            => this & rhs;

        [MethodImpl(Inline)]
        public analog or(analog rhs)
            => this | rhs;

        [MethodImpl(Inline)]
        public analog xor(analog rhs)
            => this ^ rhs;

        [MethodImpl(Inline)]
        public analog flip()
            => ~ this;

        [MethodImpl(Inline)]
        public analog lshift(int rhs)
            => this << rhs;

        [MethodImpl(Inline)]
        public analog rshift(int rhs)
            => this >> rhs;

        [MethodImpl(Inline)]
        public bool eq(analog rhs)
            => this == rhs;

        [MethodImpl(Inline)]
        public bool neq(analog rhs)
            => this != rhs;
 
        [MethodImpl(Inline)]
        public bool lteq(analog rhs) 
            => this <= rhs;

        [MethodImpl(Inline)]
        public bool gteq(analog rhs) 
            => this >= rhs;

        [MethodImpl(Inline)]
        public bool lt(analog rhs) 
            => this < rhs;

        [MethodImpl(Inline)]
        public bool gt(analog rhs) 
            => this > rhs;

        [MethodImpl(Inline)]
        public analog abs()
            => data < Zero ? -data : data;

        [MethodImpl(Inline)]
        public Sign sign()
            => Prim.sign(data);

        [MethodImpl(Inline)]
        public analog gcd(analog rhs)
            => Prim.gcd(data, rhs.data); 

        [MethodImpl(Inline)]
        public analog distributeL((analog x, analog y) rhs)
            => this * rhs.x + this * rhs.y;
 
        [MethodImpl(Inline)]
        public analog distributeR((analog x, analog y) rhs)
            => rhs.x * this + rhs.y * this;

        [MethodImpl(Inline)]
        public bool nonzero()
            => data != 0;

        [MethodImpl(Inline)]
        public byte[] digits()
            => (from c in data.ToString() 
                    select byte.Parse(c.ToString())).ToArray();
        
        [MethodImpl(Inline)]
        public analog muladd(analog y, analog z)
            => this * y + z;

        [MethodImpl(Inline)]
        public analog sin()
            => Prim.sin(data);

        [MethodImpl(Inline)]
        public analog sinh()
            => Prim.sinh(data);

        [MethodImpl(Inline)]
        public analog asin()
            => Prim.asin(data);

        [MethodImpl(Inline)]
        public analog asinh()
            => Prim.asinh(data);

        [MethodImpl(Inline)]
        public analog cos()
            => Prim.cos(data);

        [MethodImpl(Inline)]
        public analog cosh()
            => Prim.cosh(data);

        [MethodImpl(Inline)]
        public analog acos()
            => Prim.acos(data);

        [MethodImpl(Inline)]
        public analog acosh()
            => Prim.acosh(data);

        [MethodImpl(Inline)]
        public analog tan()
            => Prim.tan(data);

        [MethodImpl(Inline)]
        public analog tanh()
            => Prim.tanh(data);

        [MethodImpl(Inline)]
        public analog atan()
            => Prim.atan(data);

        [MethodImpl(Inline)]
        public analog atanh()
            => Prim.atanh(data);

        [MethodImpl(Inline)]
        public int CompareTo(analog other)
            => data.CompareTo(other.data);

        [MethodImpl(Inline)]
        public bool eq(analog lhs, analog rhs)
            => lhs == rhs;
 
        [MethodImpl(Inline)]
        public bool neq(analog lhs, analog rhs)
            => lhs != rhs;
 
        [MethodImpl(Inline)]
        public analog min(analog rhs)
            => rhs < this ? rhs : this;

        [MethodImpl(Inline)]
        public analog max(analog rhs) 
            => rhs > this ? rhs : this;

        [MethodImpl(Inline)]
        public bool Equals(analog rhs)
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