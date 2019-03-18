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
    using structure = int64;
    using systype = System.Int64;

    public readonly struct int64 : C.BoundSignedInt<structure,systype>, IEquatable<structure>, IComparable<structure>
    {

        static readonly C.BoundSignedInt<systype> ops = MathOps.signedint<systype>();
        
        public static readonly int64 Zero = new int64(0);
        
        public static readonly structure One = new int64(1);

        public static readonly structure MinValue = systype.MinValue;

        public static readonly structure MaxValue = systype.MaxValue;

        public structure minval => MinValue;

        public structure maxval => MaxValue;

        [MethodImpl(Inline)]
        public static implicit operator int64(systype value) 
            => new int64(value);

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

        // [MethodImpl(Inline)]
        // public static QR<int64> operator / (structure lhs, structure rhs) 
        //     => map(ops.divrem(lhs,rhs), q =>  QR.define<int64>(q.q,q.r));

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
            => lhs.data <= rhs.data;

        [MethodImpl(Inline)]
        public static bool operator > (structure lhs, structure rhs) 
            => lhs.data > rhs.data;

        [MethodImpl(Inline)]
        public static bool operator >= (structure lhs, structure rhs) 
            => lhs.data >= rhs.data;

        [MethodImpl(Inline)]
        public static bool operator == (structure lhs, structure rhs) 
            => lhs.data == rhs.data;

        [MethodImpl(Inline)]
        public static bool operator != (structure a, structure b) 
            => a.data != b.data;

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
        public static structure operator << (structure x, int shift) 
            => x.data << shift;

        [MethodImpl(Inline)]
        public static structure operator >> (structure x, int shift) 
            => x.data >> shift;

        [MethodImpl(Inline)]
        public static structure operator ~ (structure x) 
            => ops.flip(x);

        [MethodImpl(Inline)]
        public static structure operator -- (structure x) 
            => ops.dec(x);

        [MethodImpl(Inline)]
        public static structure operator ++ (structure x) 
            => ops.inc(x);

        [MethodImpl(Inline)]
        public static structure operator - (structure x) 
            => - x.data;

        public systype data {get;}

        public structure zero 
            => Zero;

        public structure one
            => One;


        [MethodImpl(Inline)]
        public structure inc()
            => ops.inc(data);

        [MethodImpl(Inline)]
        public Sign sign() 
            => throw new NotImplementedException();

        [MethodImpl(Inline)]
        public structure or(structure rhs)
            => data | rhs;
    
        [MethodImpl(Inline)]
        public structure xor(structure right)
            => data ^ right;

        [MethodImpl(Inline)]
        public structure and(structure rhs)
            => data & rhs;

        [MethodImpl(Inline)]
        public structure flip()
            => ~ this;

        [MethodImpl(Inline)]
        public structure gcd(structure rhs)
            => throw new NotImplementedException();

        [MethodImpl(Inline)]
        public structure dec() 
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
        public structure pow(int exp)
            => throw new NotSupportedException();

        [MethodImpl(Inline)]
        public int64 div(structure rhs)
            => ops.div(data,rhs);

        [MethodImpl(Inline)]
        public structure add(structure rhs)
            => ops.add(data,rhs);

        [MethodImpl(Inline)]
        public structure add(systype rhs)
            => ops.add(data,rhs);

        [MethodImpl(Inline)]
        public structure sub(structure rhs)
            => ops.sub(data,rhs);

        [MethodImpl(Inline)]
        public structure mul(structure rhs)
            => ops.mul(data,rhs);

        [MethodImpl(Inline)]
        public structure mod(structure rhs)
            => ops.mod(data,rhs);

        [MethodImpl(Inline)]
        public QR<structure> divrem(structure rhs)
            => map(ops.divrem(data,rhs), 
                x => QR.define<structure>(x.q,x.r));

        [MethodImpl(Inline)]
        public structure negate()
            => ops.negate(data);
        
        [MethodImpl(Inline)]
        public bool lt(structure rhs)
            => ops.lt(data,rhs);

        [MethodImpl(Inline)]
        public bool lteq(structure rhs)
            => ops.lteq(data,rhs);

        [MethodImpl(Inline)]
        public bool gt(structure rhs)
            => ops.gt(data,rhs);

        [MethodImpl(Inline)]
        public bool gteq(structure rhs)
            => ops.gteq(data,rhs);

        [MethodImpl(Inline)]
        public bool eq(structure rhs)
            => ops.eq(data,rhs);

        [MethodImpl(Inline)]
        public bool neq(structure rhs)
            => ops.neq(data,rhs);

        [MethodImpl(Inline)]
        public structure lshift(int rhs)
            => ops.lshift(data,rhs);

        [MethodImpl(Inline)]
        public structure rshift(int rhs)
            => ops.rshift(data,rhs);

        [MethodImpl(Inline)]
        public structure abs() 
            => ops.abs(data);

        [MethodImpl(Inline)]
        bool IEquatable<structure>.Equals(structure rhs)
            => ops.eq(data,rhs);

        [MethodImpl(Inline)]
        int IComparable<structure>.CompareTo(structure rhs)
            => data.CompareTo(rhs);

        public override bool Equals(object rhs)
            => data.Equals(rhs);

        public override int GetHashCode()
            => data.GetHashCode();


    }

}