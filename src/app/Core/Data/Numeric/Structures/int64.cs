//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Runtime.CompilerServices;
    using C = Contracts;
    using static corefunc;
    using structype = int64;
    using systype = System.Int64;

    using static Class;
    using static Struct;

    public readonly struct int64 : Struct.FiniteSignedInt<structype,systype>, IEquatable<structype>, IComparable<structype>
    {

        static readonly FiniteSignedInt<systype> ops = Operations.signedint<systype>();
        
        public static readonly int64 Zero = new int64(0);
        
        public static readonly structype One = new int64(1);

        public static readonly structype MinValue = systype.MinValue;

        public static readonly structype MaxValue = systype.MaxValue;

        [MethodImpl(Inline)]
        public static implicit operator int64(systype value) 
            => new int64(value);

        [MethodImpl(Inline)]
        public static implicit operator systype(structype x) 
            => x.data;

        [MethodImpl(Inline)]
        public static structype operator + (structype lhs, structype rhs) 
            => ops.add(lhs,rhs);

        [MethodImpl(Inline)]
        public static structype operator - (structype lhs, structype rhs) 
            => ops.sub(lhs,rhs);

        [MethodImpl(Inline)]
        public static structype operator * (structype lhs, structype rhs) 
            => ops.mul(lhs,rhs);

        [MethodImpl(Inline)]
        public static structype operator / (structype lhs, structype rhs) 
            => ops.div(lhs,rhs);

        [MethodImpl(Inline)]
        public static structype operator % (structype lhs, structype rhs)
            => ops.mod(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator < (structype lhs, structype rhs) 
            => ops.lt(lhs,rhs);
        
        [MethodImpl(Inline)]
        public static bool operator <= (structype lhs, structype rhs) 
            => lhs.data <= rhs.data;

        [MethodImpl(Inline)]
        public static bool operator > (structype lhs, structype rhs) 
            => lhs.data > rhs.data;

        [MethodImpl(Inline)]
        public static bool operator >= (structype lhs, structype rhs) 
            => lhs.data >= rhs.data;

        [MethodImpl(Inline)]
        public static bool operator == (structype lhs, structype rhs) 
            => lhs.data == rhs.data;

        [MethodImpl(Inline)]
        public static bool operator != (structype a, structype b) 
            => a.data != b.data;

        [MethodImpl(Inline)]
        public static structype operator & (structype lhs, structype rhs) 
            => lhs.data & rhs.data;

        [MethodImpl(Inline)]
        public static structype operator | (structype lhs, structype rhs) 
            => lhs.data | rhs.data;

        [MethodImpl(Inline)]
        public static structype operator ^ (structype lhs, structype rhs) 
            => lhs.data ^ rhs.data;

        [MethodImpl(Inline)]
        public static structype operator << (structype x, int shift) 
            => x.data << shift;

        [MethodImpl(Inline)]
        public static structype operator >> (structype x, int shift) 
            => x.data >> shift;

        [MethodImpl(Inline)]
        public static structype operator ~ (structype x) 
            => ops.flip(x);

        [MethodImpl(Inline)]
        public static structype operator -- (structype x) 
            => ops.dec(x);

        [MethodImpl(Inline)]
        public static structype operator ++ (structype x) 
            => ops.inc(x);

        [MethodImpl(Inline)]
        public static structype operator - (structype x) 
            => - x.data;

        public systype data {get;}

        public structype minval 
            => MinValue;

        public structype maxval 
            => MaxValue;
        
        public structype zero 
            => Zero;
        
        public structype one
            => One;


        [MethodImpl(Inline)]
        public structype inc()
            => ops.inc(data);

        [MethodImpl(Inline)]
        public Sign sign() 
            => throw new NotImplementedException();

        [MethodImpl(Inline)]
        public structype or(structype rhs)
            => data | rhs;
    
        [MethodImpl(Inline)]
        public structype xor(structype right)
            => data ^ right;

        [MethodImpl(Inline)]
        public structype and(structype rhs)
            => data & rhs;

        [MethodImpl(Inline)]
        public structype flip()
            => ~ this;

        [MethodImpl(Inline)]
        public structype gcd(structype rhs)
            => throw new NotImplementedException();

        [MethodImpl(Inline)]
        public structype dec() 
            => ops.sub(data,One);

        [MethodImpl(Inline)]
        public bool even()
            => abs() % 2 == 0;

        [MethodImpl(Inline)]
        public bool odd()
            => !even();

        [MethodImpl(Inline)]
        public int64(systype x)
            => this.data = x;

        [MethodImpl(Inline)]
        public structype pow(int exp)
            => ops.pow(this,exp);

        [MethodImpl(Inline)]
        public int64 div(structype rhs)
            => this / rhs;

        [MethodImpl(Inline)]
        public structype add(structype rhs)
            => this + rhs;

        [MethodImpl(Inline)]
        public structype add(systype rhs)
            => this + rhs;

        [MethodImpl(Inline)]
        public structype sub(structype rhs)
            => this - rhs;

        [MethodImpl(Inline)]
        public structype mul(structype rhs)
            => this * rhs;

        [MethodImpl(Inline)]
        public structype mod(structype rhs)
            => this % rhs;

        [MethodImpl(Inline)]
        public Quorem<structype> divrem(structype rhs)
            => map(ops.divrem(data,rhs), 
                x => Quorem.define<structype>(x.q,x.r));

        [MethodImpl(Inline)]
        public structype negate()
            => - this;
        
        [MethodImpl(Inline)]
        public bool lt(structype rhs)
            => this < rhs;

        [MethodImpl(Inline)]
        public bool lteq(structype rhs)
            => this <= rhs;


        [MethodImpl(Inline)]
        public bool gt(structype rhs)
            => this > rhs;

        [MethodImpl(Inline)]
        public bool gteq(structype rhs)
            => this >= rhs;


        [MethodImpl(Inline)]
        public bool eq(structype rhs)
            => this == rhs;

        [MethodImpl(Inline)]
        public bool neq(structype rhs)
            => this != rhs;

        [MethodImpl(Inline)]
        public structype lshift(int rhs)
            => this << rhs;

        [MethodImpl(Inline)]
        public structype rshift(int rhs)
            => this >> rhs;

        [MethodImpl(Inline)]
        public structype abs() 
            => ops.abs(data);

        [MethodImpl(Inline)]
        public string bitstring()
            => ops.bitstring(data);
            
        [MethodImpl(Inline)]
        public structype distributeL((structype x, structype y) rhs)
            => this * rhs.x + this * rhs.y;
 
        [MethodImpl(Inline)]
        public structype distributeR((structype x, structype y) rhs)
            => rhs.x * this + rhs.y * this;

        [MethodImpl(Inline)]
        bool IEquatable<structype>.Equals(structype rhs)
            => ops.eq(data,rhs);

        [MethodImpl(Inline)]
        int IComparable<structype>.CompareTo(structype rhs)
            => data.CompareTo(rhs);

        public override bool Equals(object rhs)
            => data.Equals(rhs);

        public override int GetHashCode()
            => data.GetHashCode();
    }

}