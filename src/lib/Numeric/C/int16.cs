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

    // !! short
    // !! -----------------------------------------------------------------

    partial class C : C.SignableNumber<short>
    {

        readonly NumberInfo<short> z16i
            = new NumberInfo<short>((Int16.MinValue,Int16.MaxValue), true, 0, 1, 16);

        [MethodImpl(Inline)]
        public short z16(short x)
            => x;

        [MethodImpl(Inline)]
        public short z16(bool x)
            => z16(x ? z16i.One : z16i.Zero);

        [MethodImpl(Inline)]
        public NumberInfo<short> numinfo(short x)
            => z16i;

        [MethodImpl(Inline)]
        public short bitsize(short x)
            => numinfo(x).BitSize;

        [MethodImpl(Inline)]
        public short zero(short x)
            => numinfo(x).Zero;

        [MethodImpl(Inline)]
        public short one(short x)
            => numinfo(x).One;

        [MethodImpl(Inline)]
        public short eq(short lhs, short rhs)
            => z16(lhs == rhs);

        [MethodImpl(Inline)]
        public short neq(short lhs, short rhs)
            => z16(lhs != rhs);

        [MethodImpl(Inline)]
        public short lt(short lhs, short rhs)
            => z16(lhs < rhs);

        [MethodImpl(Inline)]
        public short lteq(short lhs, short rhs)
            => z16(lhs <= rhs);

        [MethodImpl(Inline)]
        public short gt(short lhs, short rhs)
            => z16(lhs > rhs);

        [MethodImpl(Inline)]
        public short gteq(short lhs, short rhs)
            => z16(lhs >= rhs);

        [MethodImpl(Inline)]
        public short add(short lhs, short rhs)
            => (short)(lhs + rhs);

        [MethodImpl(Inline)]
        public short sub(short lhs, short rhs)
            => (short)(lhs - rhs);

        [MethodImpl(Inline)]
        public short mul(short lhs, short rhs)
            => (short)(lhs * rhs);

        [MethodImpl(Inline)]
        public short div(short lhs, short rhs)
            => (short)(lhs / rhs);

        [MethodImpl(Inline)]
        public short mod(short lhs, short rhs)
            => (short)(lhs % rhs);

        [MethodImpl(Inline)]
        public short and(short lhs, short rhs)
            => (short)(lhs & rhs);

        [MethodImpl(Inline)]
        public short or(short lhs, short rhs)
            => (short)(lhs | rhs);

        [MethodImpl(Inline)]
        public short xor(short lhs, short rhs)
            => (short)(lhs ^ rhs);

        [MethodImpl(Inline)]
        public short flip(short x)
            => (short)(~x);

        [MethodImpl(Inline)]
        public short lshift(short lhs, int rhs)
            => (short)(lhs << rhs);

        [MethodImpl(Inline)]
        public short rshift(short lhs, int rhs)
            => (short)(lhs >> rhs);

        [MethodImpl(Inline)]
        public short sign(short x)
            => sub(gt(x, (short)0), lt(x,(short)0)); 
 
        [MethodImpl(Inline)]
        public short negative(short x)
            => lt(x, (short)0);

        [MethodImpl(Inline)]
        public short positive(short x)
            => gt(x, (short)0);

        [MethodImpl(Inline)]
        public short signeq(short x, short y)
            => negative(xor(x,  y));

        [MethodImpl(Inline)]
        public short mask(short x)
             => (short)(x >> bitsize(x) - 1);

        [MethodImpl(Inline)]
        public short abs(short x)
        {
            var m = mask(x);
            return xor(add(x, m), m);
        }
 
        [MethodImpl(Inline)]
        public short negate(short x)
            => (short)-x;

        [MethodImpl(Inline)]
        public short gcd(short lhs, short rhs)
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
        public Quorem<short> divrem(short lhs, short rhs)
        {
            var quo = div(lhs, rhs);
            return Quorem.define(quo, 
                sub(lhs, mul(quo, rhs)));
        }
    }
}