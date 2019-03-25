//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Runtime.CompilerServices;
    using static corefunc;
    using static Traits;

    
    using structype = bigint;
    using systype = System.Numerics.BigInteger;

    public readonly struct bigint : InfiniteSignedInt<structype,systype> 
    {
        public static readonly InfiniteSignedInt<systype> ops = BigIntOps.Inhabitant;

        public static readonly structype Zero = ops.zero;
        
        public static readonly structype One = ops.one;

        public systype data {get;}

        public structype zero 
            => Zero;

        public structype one 
            => One;

        public structype unit 
            => One;


        [MethodImpl(Inline)]
        public Sign sign() 
            => ops.sign(data);

        [MethodImpl(Inline)]
        public static implicit operator structype(systype y) 
            => new structype(y);

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
            => ops.lteq(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator > (structype lhs, structype rhs) 
            => ops.gt(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator >= (structype lhs, structype rhs) 
            => ops.gteq(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator == (structype lhs, structype rhs) 
            => ops.eq(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator != (structype lhs, structype rhs) 
            => ops.neq(lhs,rhs);

        [MethodImpl(Inline)]
        public static structype operator & (structype lhs, structype rhs) 
            => ops.and(lhs,rhs);

        [MethodImpl(Inline)]
        public static structype operator | (structype lhs, structype rhs) 
            => ops.or(lhs,rhs);

        [MethodImpl(Inline)]
        public static structype operator ^ (structype lhs, structype rhs) 
            => ops.xor(lhs,rhs);

        [MethodImpl(Inline)]
        public static structype operator << (structype lhs, int rhs) 
            => ops.lshift(lhs,rhs);

        [MethodImpl(Inline)]
        public static structype operator >> (structype lhs, int rhs) 
            => ops.rshift(lhs,rhs);

        [MethodImpl(Inline)]
        public static structype operator ~ (structype x) 
            => ops.flip(x);

        [MethodImpl(Inline)]
        public static structype operator - (structype x) 
            => ops.negate(x);

        [MethodImpl(Inline)]
        public static structype operator -- (structype x) 
            =>  ops.dec(x);

        [MethodImpl(Inline)]
        public static structype operator ++ (structype x) 
            => ops.inc(x);

        [MethodImpl(Inline)]
        public structype abs() 
            => ops.abs(data);

        [MethodImpl(Inline)]
        public bool lteq(structype rhs) 
            => ops.lteq(this, rhs);

        [MethodImpl(Inline)]
        public bool gteq(structype rhs) 
            => ops.gteq(this, rhs);

        [MethodImpl(Inline)]
        public bool lt(structype rhs) 
            => ops.lt(this, rhs);

        [MethodImpl(Inline)]
        public bool gt(structype rhs) 
            => ops.gt(this, rhs);

        [MethodImpl(Inline)]
        public structype gcd(structype rhs)
            => systype.GreatestCommonDivisor(data, rhs);

        [MethodImpl(Inline)]
        public structype add(structype rhs)
            => ops.add(data, rhs);

        [MethodImpl(Inline)]
        public structype add(systype rhs)
            => ops.add(data,rhs);

        [MethodImpl(Inline)]
        public structype sub(structype rhs)
            => ops.sub(data, rhs);

        [MethodImpl(Inline)]
        public structype mul(structype rhs)
            => ops.mul(data, rhs);

        [MethodImpl(Inline)]   
        public structype div(structype rhs)
            => ops.div(data, rhs);

        [MethodImpl(Inline)]
        public structype mod(structype rhs)
            => ops.mod(data,rhs);

        [MethodImpl(Inline)]
        public Quorem<structype> divrem(structype rhs)
            => map(ops.divrem(data,rhs), x => Quorem.define<structype>(x.q,x.r));

        [MethodImpl(Inline)]
        public structype dec() 
            => ops.dec(data);

        [MethodImpl(Inline)]
        public structype next() 
            => ops.inc(data);

        [MethodImpl(Inline)]
        public bool even()
            => data.IsEven;

        [MethodImpl(Inline)]
        public bool odd()
            => not(even());

        [MethodImpl(Inline)]
        public bigint(systype _value)
            => this.data = _value;

        [MethodImpl(Inline)]
        public structype pow(int exp)
            => systype.Pow(data, exp);
        
        [MethodImpl(Inline)]
        public bool eq(structype rhs)
            => ops.eq(data,rhs);

        [MethodImpl(Inline)]
        public bool neq(structype rhs)
            => ops.neq(data,rhs);

        [MethodImpl(Inline)]
        public structype and(structype rhs)
            => ops.and(data,rhs);

        [MethodImpl(Inline)]
        public structype or(structype rhs)
            => ops.or(data,rhs);

        [MethodImpl(Inline)]
        public structype xor(structype rhs)
            => ops.xor(data,rhs);

        [MethodImpl(Inline)]
        public structype flip()
            => ops.flip(data);

        public structype inc()
            => ops.inc(data);

        [MethodImpl(Inline)]
        public bool Equals(structype rhs)
            => ops.eq(data,rhs);

        [MethodImpl(Inline)]
        public byte[] bytes()
            => data.ToByteArray();

        [MethodImpl(Inline)]
        public structype lshift(int rhs)
            => ops.lshift(data,rhs);

        [MethodImpl(Inline)]
        public structype rshift(int rhs)
            => ops.rshift(data,rhs);

        [MethodImpl(Inline)]
        public structype negate()
            => ops.negate(data);

        [MethodImpl(Inline)]
        public bool divides(structype lhs)
            => ops.eq(ops.mod(lhs,data),zero.data); 

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
        int IComparable<structype>.CompareTo(structype rhs)
            => data.CompareTo(rhs);

        public override bool Equals(object rhs)
            => data.Equals(rhs);

        public override int GetHashCode()
            => data.GetHashCode();

    }
}