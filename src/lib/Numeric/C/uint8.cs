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

    partial class C : C.Number<byte>
    {
        static NumberInfo<byte> u8i
            = new NumberInfo<byte>((Byte.MinValue,Byte.MaxValue), true, 0, 1, 8);

        [MethodImpl(Inline)]
        public byte u8(byte x)
            => x;

        [MethodImpl(Inline)]
        public byte u8(bool x)
            => u8(x ? u8i.One : u8i.Zero);

        [MethodImpl(Inline)]
        public NumberInfo<byte> numinfo(byte x)
            => u8i;

        [MethodImpl(Inline)]
        public byte bitsize(byte x)
            => numinfo(x).BitSize;

        [MethodImpl(Inline)]
        public byte zero(byte x)
            => numinfo(x).Zero;

        [MethodImpl(Inline)]
        public byte one(byte x)
            => numinfo(x).One;

        [MethodImpl(Inline)]
        public byte eq(byte lhs, byte rhs)
            => u8(lhs == rhs);

        [MethodImpl(Inline)]
        public byte neq(byte lhs, byte rhs)
            => u8(lhs != rhs);

        [MethodImpl(Inline)]
        public byte lt(byte lhs, byte rhs)
            => u8(lhs < rhs);

        [MethodImpl(Inline)]
        public byte lteq(byte lhs, byte rhs)
            => u8(lhs <= rhs);

        [MethodImpl(Inline)]
        public byte gt(byte lhs, byte rhs)
            => u8(lhs > rhs);

        [MethodImpl(Inline)]
        public byte gteq(byte lhs, byte rhs)
            => u8(lhs >= rhs);

        [MethodImpl(Inline)]
        public byte add(byte lhs, byte rhs)
            => (byte)(lhs + rhs);

        [MethodImpl(Inline)]
        public byte sub(byte lhs, byte rhs)
            => (byte)(lhs - rhs);

        [MethodImpl(Inline)]
        public byte mul(byte lhs, byte rhs)
            => (byte)(lhs * rhs);

        [MethodImpl(Inline)]
        public byte div(byte lhs, byte rhs)
            => (byte)(lhs / rhs);

        [MethodImpl(Inline)]
        public byte mod(byte lhs, byte rhs)
            => (byte)(lhs % rhs);
 
        [MethodImpl(Inline)]
        public byte and(byte lhs, byte rhs)
            => (byte)(lhs & rhs);

        [MethodImpl(Inline)]
        public byte or(byte lhs, byte rhs)
            => (byte)(lhs | rhs);

        [MethodImpl(Inline)]
        public byte xor(byte lhs, byte rhs)
            => (byte)(lhs ^ rhs);

        [MethodImpl(Inline)]
        public byte flip(byte x)
            => (byte)(~x);

        [MethodImpl(Inline)]
        public byte lshift(byte lhs, int rhs)
            => (byte)(lhs << rhs);

        [MethodImpl(Inline)]
        public byte rshift(byte lhs, int rhs)
            => (byte)(lhs >> rhs);

        [MethodImpl(Inline)]
        public byte positive(byte x)
            => gt(x, (byte)0);

        [MethodImpl(Inline)]
        public byte negative(byte x)
            => (byte)0;

        [MethodImpl(Inline)]
        public byte sign(byte x)
            => positive(x);

        [MethodImpl(Inline)]
        public byte abs(byte x)
            => x;
 
        [MethodImpl(Inline)]
        public byte gcd(byte lhs, byte rhs)
        {
            var x = lhs;
            var y = rhs;
            while (y != 0)
            {
                var rem = mod(x,y);
                x = y;
                y = rem;
            }
            return x;
       }

        [MethodImpl(Inline)]
        public Quorem<byte> divrem(byte lhs, byte rhs)
        {
            var quo = div(lhs, rhs);
            return Quorem.define(quo, 
                sub(lhs, mul(quo, rhs)));
        }
    }
}