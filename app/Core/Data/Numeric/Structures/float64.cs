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

    using system = System.Double;
    using structure = float64;

    public readonly struct float64 : C.BoundFloat<structure,double>
    {
        public static readonly structure Zero = new structure(0);
        
        public static readonly structure One = new structure(1);

        static readonly C.BoundFloat<system> ops = MathOps.boundfloat<system>();

        
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
            => lhs.data < rhs.data;
        
        [MethodImpl(Inline)]
        public static bool operator <= (structure a, structure b) 
            => a.data <= b.data;

        [MethodImpl(Inline)]
        public static bool operator > (structure lhs, structure rhs) 
            => ops.lt(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator >= (structure lhs, structure rhs) 
            => ops.gteq(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator == (structure lhs, structure rhs) 
            => ops.eq(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator != (structure lhs, structure rhs) 
            => !ops.eq(lhs,rhs);

        [MethodImpl(Inline)]
        public static structure operator - (structure x) 
            => - x.data;

        [MethodImpl(Inline)]
        public static structure operator -- (structure x) 
            => x - One;

        [MethodImpl(Inline)]
        public static structure operator ++ (structure x) 
            => x + One;

        public system data {get;}


        [MethodImpl(Inline)]
        public float64(system src)
            => data = src;

        public structure zero 
            => Zero;

        public float64 one
            => One;

        public structure minval => throw new NotImplementedException();

        public structure maxval => throw new NotImplementedException();

        public Sign sign() 
            => throw new NotImplementedException();


        [MethodImpl(Inline)]
        public float64 pow(int exp)
            => throw new NotSupportedException();

        int IComparable<float64>.CompareTo(float64 other)
            => data.CompareTo(other);

        [MethodImpl(Inline)]
        public static implicit operator float64(double src) 
            => new float64(src);

        [MethodImpl(Inline)]
        public static implicit operator double(float64 src) 
            => src.data;

        [MethodImpl(Inline)]
        public float64 add(float64 rhs)
            => data + rhs;

        [MethodImpl(Inline)]
        public float64 sub(float64 rhs)
            => data - rhs;

        [MethodImpl(Inline)]
        public float64 mul(float64 rhs)
            => data * rhs;

        [MethodImpl(Inline)]
        public float64 div(float64 rhs)
            => ops.div(data,rhs);


        [MethodImpl(Inline)]
        public float64 mod(float64 rhs)
            => ops.mod(data,rhs);

        [MethodImpl(Inline)]
        public float64 negate()
            => -this;
        
        [MethodImpl(Inline)]
        public bool lt(float64 rhs)
            => ops.lt(data, rhs);

        [MethodImpl(Inline)]
        public bool lteq(float64 rhs)
            => ops.lteq(data, rhs);

        [MethodImpl(Inline)]
        public bool gt(float64 rhs)
            => ops.gt(data, rhs);

        [MethodImpl(Inline)]
        public bool gteq(structure rhs)
            => ops.gteq(data, rhs);

        [MethodImpl(Inline)]
        public bool eq(structure rhs)
            => ops.eq(data,rhs);

        [MethodImpl(Inline)]
        public bool neq(structure rhs)
            => !ops.eq(data,rhs);

        [MethodImpl(Inline)]
        public structure abs() 
            =>  data < 0 ? (-1) * data : data;

        [MethodImpl(Inline)]
        public structure ceiling()
            => ops.ceiling(data);

        [MethodImpl(Inline)]
        public structure floor()
            => ops.floor(data);

        
        public override bool Equals(object rhs)
            => data.Equals(rhs);

        public override int GetHashCode()
            => data.GetHashCode();

        public override string ToString()
            => data.ToString();

    }
}