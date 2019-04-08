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
    using structure = int32;
    using primitive = System.Int32;

    public readonly struct int32 : Structures.Integer<structure, primitive>, Formattable
    {
    
        static readonly Operative.PrimOps<primitive> Prim = primops.type<primitive>();
        
        static readonly NumberInfo<primitive> NumInfo = Prim.numinfo;

        public static readonly structure Zero = NumInfo.Zero;

        public static readonly structure One = NumInfo.One;

        public static readonly structure MinVal = NumInfo.MinVal;

        public static readonly structure MaxVal = NumInfo.MaxVal;

        public static readonly uint BitSize = NumInfo.BitSize;
        
        public const bool Signed = true;

        [MethodImpl(Inline)]    
        public static int32 define(int src)
            => new int32(src);

        [MethodImpl(Inline)]    
        public static int @bool(bool x)
            => x ? 1 : 0;

        [MethodImpl(Inline)]
        public static implicit operator structure(int src)
            => new structure(src);

        [MethodImpl(Inline)]
        public static implicit operator int(structure src)
            => src.data;

        [MethodImpl(Inline)]
        public static explicit operator byte(structure src)
            => (byte)src.data;

        [MethodImpl(Inline)]
        public static explicit operator sbyte(structure src)
            => (sbyte)src.data;

        [MethodImpl(Inline)]
        public static explicit operator short(structure src)
            => (short)src.data;

        [MethodImpl(Inline)]
        public static explicit operator ushort(structure src)
            => (ushort)src.data;

        [MethodImpl(Inline)]
        public static explicit operator uint(structure src)
            => (uint)src.data;

        [MethodImpl(Inline)]
        public static explicit operator long(structure src)
            => src.data;

        [MethodImpl(Inline)]
        public static explicit operator ulong(structure src)
            => (ulong)src.data;

        [MethodImpl(Inline)]    
        public static bool operator true(structure x)
            => x.data != 0;

        [MethodImpl(Inline)]    
        public static bool operator false(structure x)
            => x.data == 0;

        [MethodImpl(Inline)]
        public static bool operator == (structure lhs, structure rhs) 
            => lhs.data == rhs.data;

        [MethodImpl(Inline)]
        public static bool operator != (structure lhs, structure rhs) 
            => lhs.data != rhs.data;

        [MethodImpl(Inline)]
        public static structure operator + (structure lhs, structure rhs) 
            => lhs.data + rhs.data;

        [MethodImpl(Inline)]
        public static structure operator - (structure lhs, structure rhs) 
            => lhs.data - rhs.data;

        [MethodImpl(Inline)]
        public static structure operator -- (structure x) 
            =>  x.data - 1;

        [MethodImpl(Inline)]
        public static structure operator ++ (structure x) 
            =>  x.data + 1;

        [MethodImpl(Inline)]
        public static structure operator - (structure x) 
            => -x.data;

        [MethodImpl(Inline)]
        public static structure operator * (structure lhs, structure rhs) 
            => lhs.data * rhs.data;

        [MethodImpl(Inline)]
        public static structure operator / (structure lhs, structure rhs) 
            => lhs.data / rhs.data;

        [MethodImpl(Inline)]
        public static structure operator % (structure lhs, structure rhs)
            => lhs.data % rhs.data;

        [MethodImpl(Inline)]
        public static bool operator < (structure lhs, structure rhs) 
            => lhs.data < rhs.data;

        [MethodImpl(Inline)]
        public static bool operator <= (structure lhs, structure rhs) 
            => lhs.data <= rhs.data;

        [MethodImpl(Inline)]
        public static bool operator > (structure lhs, structure rhs) 
            => lhs.data > rhs.data;

        [MethodImpl(Inline)]
        public static bool operator >= (structure lhs, structure rhs) 
            => lhs.data >= rhs.data;

        [MethodImpl(Inline)]
        public static structure operator & (structure lhs, structure rhs) 
            => lhs.data & rhs.data;

        [MethodImpl(Inline)]
        public static structure operator | (structure lhs, structure rhs) 
            => lhs.data | rhs.data;

        [MethodImpl(Inline)]
        public static structure operator ^ (structure lhs, structure rhs) 
            => lhs.data ^ rhs.data;

        [MethodImpl(Inline)]
        public static structure operator ~ (structure x) 
            => ~ x.data;

        [MethodImpl(Inline)]
        public static structure operator >> (structure lhs, int rhs) 
            => lhs.data >> rhs;

        [MethodImpl(Inline)]
        public static structure operator << (structure lhs, int rhs) 
            => lhs.data << rhs;

        public structure zero 
        {
            [MethodImpl(Inline)]
            get{return Zero;}
        }

        public structure one 
        {
            [MethodImpl(Inline)]
            get{return One;}
        }

        public NumberInfo<structure> numinfo 
            => new NumberInfo<structure>((MinVal, MaxVal),Signed,Zero, One, BitSize);

        readonly int data;

        [MethodImpl(Inline)]
        public int32(primitive x) 
            => data = x;

        [MethodImpl(Inline)]
        public int unwrap()
            => data;

        [MethodImpl(Inline)]
        public structure inc()
            => this + One;

        [MethodImpl(Inline)]
        public structure dec() 
            => this - One;

        [MethodImpl(Inline)]
        public structure negate()
            => -this;

        [MethodImpl(Inline)]
        public structure add(structure rhs)
            => this + rhs;

        [MethodImpl(Inline)]
        public structure sub(structure rhs)
            => this - rhs;

        [MethodImpl(Inline)]
        public structure mul(structure rhs)
            => this * rhs;
        
        [MethodImpl(Inline)]
        public structure div(structure rhs)
            => this / rhs;

        [MethodImpl(Inline)]
        public structure mod(structure rhs)
            => this % rhs;

        [MethodImpl(Inline)]
        public bool divides(structure lhs)
            => lhs % this == Zero;

        [MethodImpl(Inline)]
        public structure pow(int exp)
            => fold(repeat(data,exp), (x,y) => x*y ,One);        
        
        [MethodImpl(Inline)]
        public bool even()
            => this % 2 == Zero;

        [MethodImpl(Inline)]
        public bool odd()
            => not(even());

        [MethodImpl(Inline)]
        public Quorem<structure> divrem(structure rhs)
        {
            var quo = this/rhs;
            var rem = this - quo * rhs;
            return Quorem.define(quo, rem);
        }

        [MethodImpl(Inline)]
        public BitString bitstring()
            => Prim.bitstring(data);

        [MethodImpl(Inline)]
        public byte[] bytes()
            => Prim.bytes(data);

        [MethodImpl]
        public bool testbit(int pos)
            => Prim.testbit(data,pos);

        [MethodImpl(Inline)]
        public structure and(structure rhs)
            => this & rhs;

        [MethodImpl(Inline)]
        public structure or(structure rhs)
            => this | rhs;

        [MethodImpl(Inline)]
        public structure xor(structure rhs)
            => this ^ rhs;

        [MethodImpl(Inline)]
        public structure flip()
            => ~ this;

        [MethodImpl(Inline)]
        public structure lshift(int rhs)
            => this << rhs;

        [MethodImpl(Inline)]
        public structure rshift(int rhs)
            => this >> rhs;

        [MethodImpl(Inline)]
        public bool eq(structure rhs)
            => this == rhs;

        [MethodImpl(Inline)]
        public bool neq(structure rhs)
            => this != rhs;
 
        [MethodImpl(Inline)]
        public bool lteq(structure rhs) 
            => this <= rhs;

        [MethodImpl(Inline)]
        public bool gteq(structure rhs) 
            => this >= rhs;

        [MethodImpl(Inline)]
        public bool lt(structure rhs) 
            => this < rhs;

        [MethodImpl(Inline)]
        public bool gt(structure rhs) 
            => this > rhs;

        [MethodImpl(Inline)]
        public structure abs()
            => data < Zero ? -data : data;

        [MethodImpl(Inline)]
        public Sign sign()
            => Prim.sign(data);

        [MethodImpl(Inline)]
        public structure gcd(structure rhs)
            => Prim.gcd(data, rhs.data); 

        [MethodImpl(Inline)]
        public structure distributeL((structure x, structure y) rhs)
            => this * rhs.x + this * rhs.y;
 
        [MethodImpl(Inline)]
        public structure distributeR((structure x, structure y) rhs)
            => rhs.x * this + rhs.y * this;

        [MethodImpl(Inline)]
        public bool nonzero()
            => data != 0;

        [MethodImpl(Inline)]
        public byte[] digits()
            => (from c in data.ToString() 
                    select byte.Parse(c.ToString())).ToArray();
        
        [MethodImpl(Inline)]
        public structure muladd(structure y, structure z)
            => this * y + z;

        [MethodImpl(Inline)]
        public structure sin()
            => Prim.sin(data);

        [MethodImpl(Inline)]
        public structure sinh()
            => Prim.sinh(data);

        [MethodImpl(Inline)]
        public structure asin()
            => Prim.asin(data);

        [MethodImpl(Inline)]
        public structure asinh()
            => Prim.asinh(data);

        [MethodImpl(Inline)]
        public structure cos()
            => Prim.cos(data);

        [MethodImpl(Inline)]
        public structure cosh()
            => Prim.cosh(data);

        [MethodImpl(Inline)]
        public structure acos()
            => Prim.acos(data);

        [MethodImpl(Inline)]
        public structure acosh()
            => Prim.acosh(data);

        [MethodImpl(Inline)]
        public structure tan()
            => Prim.tan(data);

        [MethodImpl(Inline)]
        public structure tanh()
            => Prim.tanh(data);

        [MethodImpl(Inline)]
        public structure atan()
            => Prim.atan(data);

        [MethodImpl(Inline)]
        public structure atanh()
            => Prim.atanh(data);

        [MethodImpl(Inline)]
        public int CompareTo(structure other)
            => data.CompareTo(other.data);

        [MethodImpl(Inline)]
        public bool eq(structure lhs, structure rhs)
            => lhs == rhs;
 
        [MethodImpl(Inline)]
        public bool neq(structure lhs, structure rhs)
            => lhs != rhs;
 
        [MethodImpl(Inline)]
        public structure min(structure rhs)
            => rhs < this ? rhs : this;

        [MethodImpl(Inline)]
        public structure max(structure rhs) 
            => rhs > this ? rhs : this;

        [MethodImpl(Inline)]
        public bool Equals(structure rhs)
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