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

    public readonly struct int64 : 
        C.SignedInt<int64,long>, 
        C.BitLogics<int64,long>, 
        C.Negatable<int64,long>,
        IEquatable<int64>, 
        IComparable<int64>
    {

        static readonly C.BoundSignedInt<long> ops = MathOps.boundsint<long>();
        
        public static readonly int64 Zero = new int64(0);
        
        public static readonly int64 One = new int64(1);

        [MethodImpl(Inline)]
        public static implicit operator int64(long value) 
            => new int64(value);

        [MethodImpl(Inline)]
        public static implicit operator long(int64 x) 
            => x.data;

        [MethodImpl(Inline)]
        public static int64 operator + (int64 lhs, int64 rhs) 
            => ops.add(lhs,rhs);

        [MethodImpl(Inline)]
        public static int64 operator - (int64 lhs, int64 rhs) 
            => ops.sub(lhs,rhs);

        [MethodImpl(Inline)]
        public static int64 operator * (int64 lhs, int64 rhs) 
            => ops.mul(lhs,rhs);

        [MethodImpl(Inline)]
        public static QR<int64> operator / (int64 lhs, int64 rhs) 
            => map(ops.divrem(lhs,rhs), q =>  QR.define<int64>(q.q,q.r));


        [MethodImpl(Inline)]
        public static int64 operator % (int64 lhs, int64 rhs)
            => ops.mod(lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator < (int64 lhs, int64 rhs) 
            => ops.lt(lhs,rhs);
        
        [MethodImpl(Inline)]
        public static bool operator <= (int64 lhs, int64 rhs) 
            => lhs.data <= rhs.data;

        [MethodImpl(Inline)]
        public static bool operator > (int64 lhs, int64 rhs) 
            => lhs.data > rhs.data;

        [MethodImpl(Inline)]
        public static bool operator >= (int64 lhs, int64 rhs) 
            => lhs.data >= rhs.data;

        [MethodImpl(Inline)]
        public static bool operator == (int64 lhs, int64 rhs) 
            => lhs.data == rhs.data;

        [MethodImpl(Inline)]
        public static bool operator != (int64 a, int64 b) 
            => a.data != b.data;

        [MethodImpl(Inline)]
        public static int64 operator & (int64 lhs, int64 rhs) 
            => lhs.data & rhs.data;

        [MethodImpl(Inline)]
        public static int64 operator | (int64 lhs, int64 rhs) 
            => lhs.data | rhs.data;

        [MethodImpl(Inline)]
        public static int64 operator ^ (int64 lhs, int64 rhs) 
            => lhs.data ^ rhs.data;

        [MethodImpl(Inline)]
        public static int64 operator << (int64 x, int shift) 
            => x.data << shift;

        [MethodImpl(Inline)]
        public static int64 operator >> (int64 x, int shift) 
            => x.data >> shift;

        [MethodImpl(Inline)]
        public static int64 operator ~ (int64 x) 
            => ~ x.data;

        [MethodImpl(Inline)]
        public static int64 operator -- (int64 x) 
            => x.data - 1;

        [MethodImpl(Inline)]
        public static int64 operator ++ (int64 x) 
            => x.data + 1;

        [MethodImpl(Inline)]
        public static int64 operator - (int64 x) 
            => - x.data;

        public long data {get;}

        public int64 zero 
            => Zero;

        public int64 one
            => One;

        [MethodImpl(Inline)]
        public Sign sign() 
            => throw new NotImplementedException();

        [MethodImpl(Inline)]
        public int64 or(int64 rhs)
            => data | rhs;
    
        [MethodImpl(Inline)]
        public int64 xor(int64 right)
            => data ^ right;

        [MethodImpl(Inline)]
        public int64 and(int64 rhs)
            => data & rhs;

        [MethodImpl(Inline)]
        public int64 flip()
            => ~ this;

        [MethodImpl(Inline)]
        public int64 gcd(int64 rhs)
            => throw new NotImplementedException();

        [MethodImpl(Inline)]
        public int64 dec() 
            => ops.sub(data,One);

        [MethodImpl(Inline)]
        public int64 next() 
            => this + One;

        [MethodImpl(Inline)]
        public bool even()
            => abs() % 2 == 0;

        [MethodImpl(Inline)]
        public bool odd()
            => !even();

        [MethodImpl(Inline)]
        public int64(long x)
            => this.data = x;

        [MethodImpl(Inline)]
        public int64 pow(int exp)
            => throw new NotSupportedException();

        [MethodImpl(Inline)]
        public QR<int64> div(int64 rhs)
            => new QR<int64>(data / rhs.data, data % rhs.data);

        [MethodImpl(Inline)]
        public int64 add(int64 rhs)
            => data + rhs;

        [MethodImpl(Inline)]
        public int64 sub(int64 rhs)
            => data - rhs;

        [MethodImpl(Inline)]
        public int64 mul(int64 rhs)
            => data * rhs;

        [MethodImpl(Inline)]
        public int64 mod(int64 rhs)
            => data % rhs;

        [MethodImpl(Inline)]
        public int64 negate()
            => -data;
        
        [MethodImpl(Inline)]
        public bool lt(int64 rhs)
            => data < rhs;

        [MethodImpl(Inline)]
        public bool lteq(int64 rhs)
            => data <= rhs;

        [MethodImpl(Inline)]
        public bool gt(int64 rhs)
            => data > rhs;

        [MethodImpl(Inline)]
        public bool gteq(int64 rhs)
            => data >= rhs;

        [MethodImpl(Inline)]
        public bool eq(int64 rhs)
            => data == rhs;

        [MethodImpl(Inline)]
        public bool neq(int64 rhs)
            => data != rhs;

        [MethodImpl(Inline)]
        public int64 lshift(int shift)
            => data << shift;

        [MethodImpl(Inline)]
        public int64 rshift(int shift)
            => data >> shift;

        [MethodImpl(Inline)]
        public int64 complement()
            => ~ data;

        [MethodImpl(Inline)]
        public int64 abs() 
            => data < 0 ? (-1) * (data) : data;

        [MethodImpl(Inline)]
        public int64 inc()
            => ops.inc(data);


        [MethodImpl(Inline)]
        bool IEquatable<int64>.Equals(int64 x)
            => data.Equals(x);

        public override bool Equals(object x)
            => data.Equals(x);

        public override int GetHashCode()
            => data.GetHashCode();

        [MethodImpl(Inline)]
        int IComparable<int64>.CompareTo(int64 x)
            => data.CompareTo(x);

    }

}