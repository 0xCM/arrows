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

    using primitive = System.Int64;
    using structure = C.int64;

    partial class C
    {


        public readonly struct int64 : SInt<structure,primitive>
        {
            [MethodImpl(Inline)]    
            public static IEnumerable<structure> define(IEnumerable<primitive> src)
                => src.Select(num);

            public static readonly structure Zero = 0;

            public static readonly structure One = 1;

            public const int Bitsize = 64;

            [MethodImpl(Inline)]    
            public static structure @bool(bool x)
                => x ? One : Zero;

            [MethodImpl(Inline)]
            public static implicit operator structure(primitive src)
                => new structure(src);

            [MethodImpl(Inline)]
            public static implicit operator primitive(structure src)
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
            public static explicit operator int(structure src)
                => (int)src.data;

            [MethodImpl(Inline)]
            public static explicit operator uint(structure src)
                => (uint)src.data;

            [MethodImpl(Inline)]
            public static explicit operator ulong(structure src)
                => (ulong)src.data;

            [MethodImpl(Inline)]
            public static explicit operator float(structure src)
                => (float)src.data;

            [MethodImpl(Inline)]
            public static explicit operator double(structure src)
                => (double)src.data;

            [MethodImpl(Inline)]
            public static explicit operator decimal(structure src)
                => (decimal)src.data;

            [MethodImpl(Inline)]    
            public static bool operator true(structure x)
                => x.data != 0;

            [MethodImpl(Inline)]    
            public static bool operator false(structure x)
                => x.data == 0;

            [MethodImpl(Inline)]
            public static structure operator == (structure lhs, structure rhs) 
                => @bool(lhs.data == rhs.data);

            [MethodImpl(Inline)]
            public static structure operator != (structure lhs, structure rhs) 
                => @bool(lhs.data != rhs.data);

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
            public static structure operator < (structure lhs, structure rhs) 
                => @bool(lhs.data < rhs.data);

            [MethodImpl(Inline)]
            public static structure operator <= (structure lhs, structure rhs) 
                => @bool(lhs.data <= rhs.data);

            [MethodImpl(Inline)]
            public static structure operator > (structure lhs, structure rhs) 
                => @bool(lhs.data > rhs.data);

            [MethodImpl(Inline)]
            public static structure operator >= (structure lhs, structure rhs) 
                => @bool(lhs.data >= rhs.data);

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

            readonly primitive data;

            [MethodImpl(Inline)]    
            public int64(primitive x)
                => data =x;

            [MethodImpl(Inline)]    
            public primitive unwrap()
                => data;


            [MethodImpl(Inline)]
            public structure revalue(primitive s)
                => s;

            [MethodImpl(Inline)]    
            public IEnumerable<structure> lift(IEnumerable<primitive> src)
                => src.Select(num);

            [MethodImpl(Inline)]    
            public IEnumerable<primitive> drop(IEnumerable<structure> src)
                => src.Select(x => x.unwrap());

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

            public int bitsize
            {
                [MethodImpl(Inline)]
                get{return Bitsize;}
            }

            public structure sign
            {
                [MethodImpl(Inline)]
                get{return this > zero - this < zero;}
            }

            public structure positive
            {
                [MethodImpl(Inline)]
                get{return this > zero;}
            }

            public structure negative
            {
                [MethodImpl(Inline)]
                get{return this < zero;}
            }

            [MethodImpl(Inline)]
            public structure negate()
                => -this;

            [MethodImpl(Inline)]
            public structure abs()
            {
                var m = this >> bitsize - 1;
                return (this + m)  ^ m;
            }

            [MethodImpl(Inline)]
            public bool eq(structure rhs)
                => data == rhs.data;

            [MethodImpl(Inline)]
            public bool neq(structure rhs)
                => data != rhs.data;

            [MethodImpl(Inline)]
            public bool lt(structure rhs)
                => data < rhs.data;

            [MethodImpl(Inline)]
            public bool lteq(structure rhs)
                => data <= rhs.data;

            [MethodImpl(Inline)]
            public bool gt(structure rhs)
                => data > rhs.data;

            [MethodImpl(Inline)]
            public bool gteq(structure rhs)
                => data >= rhs.data;
                
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
            public structure pow(int exp)
            {
                primitive result = 1;
                for(var i = 1; i<= exp; i++)
                    result *= this;
                return result;
            }

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
                => ~this;

            [MethodImpl(Inline)]
            public structure lshift(int rhs)
                => this << rhs;

            [MethodImpl(Inline)]
            public structure rshift(int rhs)
                => this >> rhs;


            [MethodImpl(Inline)]
            public Quorem<structure> divrem(structure rhs)
            {
                var lhs = this;
                var quo = lhs/rhs;
                var rem = lhs - quo * rhs;
                return Quorem.define(quo, rem);                   
            }

            [MethodImpl(Inline)]
            public structure div(structure rhs)
                => this/rhs;

            [MethodImpl(Inline)]
            public structure mod(structure rhs)
                => this % rhs;

            [MethodImpl(Inline)]
            public structure gcd(structure rhs)
            {
                var x = this.abs();
                var y = rhs.abs();
                while (y != y.zero)
                {
                    var rem = x % y;
                    x = y;
                    y = rem;
                }
                return x;
            }

            [MethodImpl(Inline)]
            public BitString bitstring()
                => BitString.define(data);       

            [MethodImpl(Inline)]
            public int hash()
                => data.GetHashCode();

            [MethodImpl(Inline)]
            public string format()
                => data.ToString();

            [MethodImpl(Inline)]
            public bool Equals(structure rhs)
                => data == rhs.data;

            public override int GetHashCode()
                => hash();

            public override bool Equals(object rhs)
                => data.Equals(rhs);
            
            public override string ToString()
                => format();

       }
    }
}