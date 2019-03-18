//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Numerics;
    using System.Runtime.CompilerServices;
    using static corefunc;

    using C = Contracts;
    
    using structure = bigint;
    using systype = System.Numerics.BigInteger;

    public readonly struct bigint :  C.SignedInt<structure,systype>,  IEquatable<bigint>
    {
        public static readonly C.SignedInt<systype> ops =  MathOps.bigint();

        public static readonly structure Zero = ops.zero;
        
        public static readonly structure One = ops.one;

        public systype data {get;}

        public structure zero => ops.zero;

        public structure one => ops.one;

        [MethodImpl(Inline)]
        public Sign sign() 
            => ops.sign(data);

        [MethodImpl(Inline)]
        public static implicit operator structure(systype y) 
            => new structure(y);

        [MethodImpl(Inline)]
        public static implicit operator systype(structure x) 
            => x.data;

        [MethodImpl(Inline)]
        public static structure operator + (structure lhs, structure rhs) 
            => ops.add(lhs,rhs);

        [MethodImpl(Inline)]
        public static structure operator - (structure lhs, structure rhs) 
            => ops.sub(lhs,rhs);

        [MethodImpl(Inline)]
        public static structure operator * (structure lhs, structure rhs) 
            => ops.mul(lhs,rhs);

        [MethodImpl(Inline)]
        public static structure operator / (structure lhs, structure rhs) 
            => ops.div(lhs,rhs);

        [MethodImpl(Inline)]
        public static structure operator % (structure lhs, structure rhs)
            => ops.mod(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator < (structure lhs, structure rhs) 
            => ops.lt(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator <= (structure lhs, structure rhs) 
            => ops.lteq(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator > (structure lhs, structure rhs) 
            => ops.gt(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator >= (structure lhs, structure rhs) 
            => ops.gteq(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator == (structure lhs, structure rhs) 
            => ops.eq(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator != (structure lhs, structure rhs) 
            => ops.neq(lhs,rhs);

        [MethodImpl(Inline)]
        public static structure operator & (structure lhs, structure rhs) 
            => ops.and(lhs,rhs);

        [MethodImpl(Inline)]
        public static structure operator | (structure lhs, structure rhs) 
            => ops.or(lhs,rhs);

        [MethodImpl(Inline)]
        public static structure operator ^ (structure lhs, structure rhs) 
            => ops.xor(lhs,rhs);

        [MethodImpl(Inline)]
        public static structure operator << (structure lhs, int rhs) 
            => ops.lshift(lhs,rhs);

        [MethodImpl(Inline)]
        public static structure operator >> (structure lhs, int rhs) 
            => ops.rshift(lhs,rhs);

        [MethodImpl(Inline)]
        public static structure operator ~ (structure x) 
            => ops.flip(x);

        [MethodImpl(Inline)]
        public static structure operator - (structure x) 
            => ops.negate(x);

        [MethodImpl(Inline)]
        public static structure operator -- (structure x) 
            =>  ops.dec(x);

        [MethodImpl(Inline)]
        public static structure operator ++ (structure x) 
            => ops.inc(x);

        [MethodImpl(Inline)]
        public structure abs() 
            => ops.abs(data);

        [MethodImpl(Inline)]
        public bool lteq(structure rhs) 
            => ops.lteq(this, rhs);

        [MethodImpl(Inline)]
        public bool gteq(structure rhs) 
            => ops.gteq(this, rhs);

        [MethodImpl(Inline)]
        public bool lt(structure rhs) 
            => ops.lt(this, rhs);

        [MethodImpl(Inline)]
        public bool gt(structure rhs) 
            => ops.gt(this, rhs);

        [MethodImpl(Inline)]
        public structure gcd(structure rhs)
            => systype.GreatestCommonDivisor(data, rhs);

        [MethodImpl(Inline)]
        public structure add(structure rhs)
            => ops.add(data, rhs);

        [MethodImpl(Inline)]
        public structure add(systype rhs)
            => ops.add(data,rhs);

        [MethodImpl(Inline)]
        public structure sub(structure rhs)
            => ops.sub(data, rhs);

        [MethodImpl(Inline)]
        public structure mul(structure rhs)
            => ops.mul(data, rhs);

        [MethodImpl(Inline)]   
        public structure div(structure rhs)
            => ops.div(data, rhs);

        [MethodImpl(Inline)]
        public structure mod(structure rhs)
            => ops.mod(data,rhs);

        [MethodImpl(Inline)]
        public QR<structure> divrem(structure rhs)
            => map(ops.divrem(data,rhs), x => QR.define<structure>(x.q,x.r));

        [MethodImpl(Inline)]
        public structure dec() 
            => ops.dec(data);

        [MethodImpl(Inline)]
        public structure next() 
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
        public structure pow(int exp)
            => systype.Pow(data, exp);
        
        [MethodImpl(Inline)]
        public bool eq(structure rhs)
            => ops.eq(data,rhs);

        [MethodImpl(Inline)]
        public bool neq(structure rhs)
            => ops.neq(data,rhs);

        [MethodImpl(Inline)]
        public structure and(structure rhs)
            => ops.and(data,rhs);

        [MethodImpl(Inline)]
        public structure or(structure rhs)
            => ops.or(data,rhs);

        [MethodImpl(Inline)]
        public structure xor(structure rhs)
            => ops.xor(data,rhs);

        [MethodImpl(Inline)]
        public structure flip()
            => ops.flip(data);

        public structure inc()
            => ops.inc(data);

        [MethodImpl(Inline)]
        public bool Equals(structure rhs)
            => ops.eq(data,rhs);

        [MethodImpl(Inline)]
        public byte[] bytes()
            => data.ToByteArray();

        [MethodImpl(Inline)]
        public structure lshift(int rhs)
            => ops.lshift(data,rhs);

        [MethodImpl(Inline)]
        public structure rshift(int rhs)
            => ops.rshift(data,rhs);

        [MethodImpl(Inline)]
        public structure negate()
            => ops.negate(data);

        [MethodImpl(Inline)]
        public bool divides(structure lhs)
            => ops.eq(ops.mod(lhs,data),zero.data); 

        [MethodImpl(Inline)]
        public int CompareTo(structure rhs)
            => data.CompareTo(rhs);

        public override bool Equals(object rhs)
            => data.Equals(rhs);

        public override int GetHashCode()
            => data.GetHashCode();

    }
}