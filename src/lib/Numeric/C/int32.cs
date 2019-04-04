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

    partial class C : C.SignableNumber<int>
    {
        [MethodImpl(Inline)]    
        public static int32 num(int x)
            => x;

        static readonly NumberInfo<int> z32i
            = new NumberInfo<int>((Int32.MinValue,Int32.MaxValue), true, 0, 1, 32);

        public readonly struct int32
        {
            readonly int data;

            [MethodImpl(Inline)]    
            public int32(int x)
                => data =x;

            [MethodImpl(Inline)]    
            public static int @bool(bool x)
                => x ? 1 : 0;

            [MethodImpl(Inline)]
            public static implicit operator int32(int src)
                => new int32(src);

            [MethodImpl(Inline)]
            public static implicit operator int(int32 src)
                => src.data;

            [MethodImpl(Inline)]
            public static explicit operator byte(int32 src)
                => (byte)src.data;

            [MethodImpl(Inline)]
            public static explicit operator sbyte(int32 src)
                => (sbyte)src.data;

            [MethodImpl(Inline)]
            public static explicit operator short(int32 src)
                => (short)src.data;

            [MethodImpl(Inline)]
            public static explicit operator ushort(int32 src)
                => (ushort)src.data;

            [MethodImpl(Inline)]
            public static explicit operator uint(int32 src)
                => (uint)src.data;

            [MethodImpl(Inline)]
            public static explicit operator long(int32 src)
                => src.data;

            [MethodImpl(Inline)]
            public static explicit operator ulong(int32 src)
                => (ulong)src.data;

            [MethodImpl(Inline)]    
            public static bool operator true(int32 x)
                => x.data != 0;

            [MethodImpl(Inline)]    
            public static bool operator false(int32 x)
                => x.data == 0;

            [MethodImpl(Inline)]
            public static int32 operator == (int32 lhs, int32 rhs) 
                => @bool(lhs.data == rhs.data);

            [MethodImpl(Inline)]
            public static int32 operator != (int32 lhs, int32 rhs) 
                => @bool(lhs.data != rhs.data);

            [MethodImpl(Inline)]
            public static int32 operator + (int32 lhs, int32 rhs) 
                => lhs.data + rhs.data;

            [MethodImpl(Inline)]
            public static int32 operator - (int32 lhs, int32 rhs) 
                => lhs.data - rhs.data;

            [MethodImpl(Inline)]
            public static int32 operator -- (int32 x) 
                =>  x.data - 1;

            [MethodImpl(Inline)]
            public static int32 operator ++ (int32 x) 
                =>  x.data + 1;

            [MethodImpl(Inline)]
            public static int32 operator - (int32 x) 
                => -x.data;

            [MethodImpl(Inline)]
            public static int32 operator * (int32 lhs, int32 rhs) 
                => lhs.data * rhs.data;

            [MethodImpl(Inline)]
            public static int32 operator / (int32 lhs, int32 rhs) 
                => lhs.data / rhs.data;

            [MethodImpl(Inline)]
            public static int32 operator % (int32 lhs, int32 rhs)
                => lhs.data % rhs.data;

            [MethodImpl(Inline)]
            public static int32 operator < (int32 lhs, int32 rhs) 
                => @bool(lhs.data < rhs.data);

            [MethodImpl(Inline)]
            public static int32 operator <= (int32 lhs, int32 rhs) 
                => @bool(lhs.data <= rhs.data);

            [MethodImpl(Inline)]
            public static int32 operator > (int32 lhs, int32 rhs) 
                => @bool(lhs.data > rhs.data);

            [MethodImpl(Inline)]
            public static int32 operator >= (int32 lhs, int32 rhs) 
                => @bool(lhs.data >= rhs.data);

            [MethodImpl(Inline)]
            public static int32 operator & (int32 lhs, int32 rhs) 
                => lhs.data & rhs.data;

            [MethodImpl(Inline)]
            public static int32 operator | (int32 lhs, int32 rhs) 
                => lhs.data | rhs.data;

            [MethodImpl(Inline)]
            public static int32 operator ^ (int32 lhs, int32 rhs) 
                => lhs.data ^ rhs.data;

            [MethodImpl(Inline)]
            public static int32 operator ~ (int32 x) 
                => ~ x.data;

            [MethodImpl(Inline)]
            public static int32 operator >> (int32 lhs, int rhs) 
                => lhs.data >> rhs;

            [MethodImpl(Inline)]
            public static int32 operator << (int32 lhs, int rhs) 
                => lhs.data << rhs;

            [MethodImpl(Inline)]
            public Quorem<int32> divrem(int32 rhs)
            {
                var lhs = this;
                var quo = lhs/rhs;
                var rem = lhs - quo * rhs;
                return Quorem.define(quo, rem);                   
            }

            [MethodImpl(Inline)]
            public bool Equals(int32 rhs)
                => data == rhs.data;

            [MethodImpl(Inline)]
            public int hash()
                => data.GetHashCode();

            [MethodImpl(Inline)]
            public string format()
                => data.ToString();

            public override int GetHashCode()
                => hash();

            public override bool Equals(object rhs)
                => data.Equals(rhs);
            
            public override string ToString()
                => format();
        }


        [MethodImpl(Inline)]
        public NumberInfo<int> numinfo(int x)
            => z32i;

        [MethodImpl(Inline)]
        public int z32(int x)
            => x;

        [MethodImpl(Inline)]
        public int z32(bool x)
            => z32(x ? 1 : 0);

        [MethodImpl(Inline)]
        public int bitsize(int x)
            => numinfo(x).BitSize;

        [MethodImpl(Inline)]
        public int zero(int x)
            => numinfo(x).Zero;

        [MethodImpl(Inline)]
        public int one(int x)
            => numinfo(x).One;


        [MethodImpl(Inline)]
        public int eq(int lhs, int rhs)
            => z32(lhs == rhs);

        [MethodImpl(Inline)]
        public int neq(int lhs, int rhs)
            => z32(lhs != rhs);

        [MethodImpl(Inline)]
        public int lt(int lhs, int rhs)
            => z32(lhs < rhs);

        [MethodImpl(Inline)]
        public int lteq(int lhs, int rhs)
            => z32(lhs <= rhs);

        [MethodImpl(Inline)]
        public int gt(int lhs, int rhs)
            => z32(lhs > rhs);

        [MethodImpl(Inline)]
        public int gteq(int lhs, int rhs)
            => z32(lhs >= rhs);

        [MethodImpl(Inline)]
        public int add(int lhs, int rhs)
            => lhs + rhs;

        [MethodImpl(Inline)]
        public int sub(int lhs, int rhs)
            => lhs - rhs;

        [MethodImpl(Inline)]
        public int mul(int lhs, int rhs)
            => lhs * rhs;

        [MethodImpl(Inline)]
        public int div(int lhs, int rhs)
            => lhs / rhs;

        [MethodImpl(Inline)]
        public int mod(int lhs, int rhs)
            => lhs % rhs;

        [MethodImpl(Inline)]
        public int and(int lhs, int rhs)
            => lhs & rhs;

        [MethodImpl(Inline)]
        public int or(int lhs, int rhs)
            => lhs | rhs;

        [MethodImpl(Inline)]
        public int xor(int lhs, int rhs)
            => lhs ^ rhs;

        [MethodImpl(Inline)]
        public int flip(int x)
            => ~x;

        [MethodImpl(Inline)]
        public int lshift(int lhs, int rhs)
            => lhs << rhs;

        [MethodImpl(Inline)]
        public int rshift(int lhs, int rhs)
            => lhs >> rhs;

        [MethodImpl(Inline)]
        public int sign(int x)
            => gt(x, 0) - lt(x,0); 

        [MethodImpl(Inline)]
        public int negate(int x)
            => (int)-x;

        [MethodImpl(Inline)]
        public int positive(int x)
            => gt(x, 0);

        [MethodImpl(Inline)]
        public int negative(int x)
            => lt(x, 0);

        [MethodImpl(Inline)]
        public int signeq(int x, int y)
            => negative(x ^ y);

        [MethodImpl(Inline)]
        int mask(int x)
            => x >> bitsize(x) - 1;
        
        [MethodImpl(Inline)]
        public int abs(int x)
        {
            var m = mask(x);
            return (x + m)  ^ m;
        }

        [MethodImpl(Inline)]
        public int min(int x, int y)
            => xor(y, and(xor(x,y), negate(lt(x,y))));

        [MethodImpl(Inline)]
        public int max(int x, int y)
            => xor(x ,  and(xor(x,y), negate(lt(x,  y))));

        [MethodImpl(Inline)]
        public int gcd(int lhs, int rhs)
        {
            var x = abs(lhs);
            var y = abs(rhs);
            while (y != 0)
            {
                var rem = mod(x,y);
                x = y;
                y = rem;
            }
            return x;
       }

        [MethodImpl(Inline)]
        public Quorem<int32> divrem(int32 lhs, int32 rhs)
            => lhs.divrem(rhs);

        [MethodImpl(Inline)]
        public Quorem<int> divrem(int lhs, int rhs)
        {
            var quo = div(lhs, rhs);
            return Quorem.define(quo, 
                sub(lhs, mul(quo, rhs)));
        }


   }
}