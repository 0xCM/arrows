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

    partial class C : C.SignableNumber<sbyte>
    {
        readonly NumberInfo<sbyte> z8i 
            = new NumberInfo<sbyte>((SByte.MinValue,SByte.MaxValue), true, 0, 1, 8);

        [MethodImpl(Inline)]
        public NumberInfo<sbyte> numinfo(sbyte x)
            => z8i;

        [MethodImpl(Inline)]
        public sbyte z8(sbyte x)
            => x;

        [MethodImpl(Inline)]
        public sbyte z8(bool x)
            => z8(x ? z8i.One : z8i.Zero);

        [MethodImpl(Inline)]
        public sbyte bitsize(sbyte x)
            => numinfo(x).BitSize;

        [MethodImpl(Inline)]
        public sbyte zero(sbyte x)
            => numinfo(x).Zero;

        [MethodImpl(Inline)]
        public sbyte one(sbyte x)
            => numinfo(x).One;

        [MethodImpl(Inline)]
        public sbyte eq(sbyte lhs, sbyte rhs)
            => z8(lhs == rhs);

        [MethodImpl(Inline)]
        public sbyte neq(sbyte lhs, sbyte rhs)
            => z8(lhs != rhs);

        [MethodImpl(Inline)]
        public sbyte lt(sbyte lhs, sbyte rhs)
            => z8(lhs < rhs);

        [MethodImpl(Inline)]
        public sbyte lteq(sbyte lhs, sbyte rhs)
            => z8(lhs <= rhs);

        [MethodImpl(Inline)]
        public sbyte gt(sbyte lhs, sbyte rhs)
            => z8(lhs > rhs);

        [MethodImpl(Inline)]
        public sbyte gteq(sbyte lhs, sbyte rhs)
            => z8(lhs >= rhs);

        [MethodImpl(Inline)]
        public sbyte add(sbyte lhs, sbyte rhs)
            => (sbyte)(lhs + rhs);

        [MethodImpl(Inline)]
        public sbyte sub(sbyte lhs, sbyte rhs)
            => (sbyte)(lhs - rhs);

        [MethodImpl(Inline)]
        public sbyte mul(sbyte lhs, sbyte rhs)
            => (sbyte)(lhs * rhs);

        [MethodImpl(Inline)]
        public sbyte div(sbyte lhs, sbyte rhs)
            => (sbyte)(lhs / rhs);

        [MethodImpl(Inline)]
        public sbyte mod(sbyte lhs, sbyte rhs)
            => (sbyte)(lhs % rhs);

        [MethodImpl(Inline)]
        public sbyte and(sbyte lhs, sbyte rhs)
            => (sbyte)(lhs & rhs);

        [MethodImpl(Inline)]
        public sbyte or(sbyte lhs, sbyte rhs)
            => (sbyte)(lhs | rhs);

        [MethodImpl(Inline)]
        public sbyte xor(sbyte lhs, sbyte rhs)
            => (sbyte)(lhs ^ rhs);

        [MethodImpl(Inline)]
        public sbyte flip(sbyte x)
            => (sbyte)(~x);

        [MethodImpl(Inline)]
        public sbyte lshift(sbyte lhs, int rhs)
            => (sbyte)(lhs << rhs);

        [MethodImpl(Inline)]
        public sbyte rshift(sbyte lhs, int rhs)
            => (sbyte)(lhs >> rhs);
        
        [MethodImpl(Inline)]
        public sbyte sign(sbyte x)
            => sub(gt(x, (sbyte)0), lt(x, (sbyte)0)); 

        [MethodImpl(Inline)]
        public sbyte negative(sbyte x)
            => lt(x, (sbyte)0);

        [MethodImpl(Inline)]
        public sbyte positive(sbyte x)
            => gt(x, zero(x));

        [MethodImpl(Inline)]
        public sbyte signeq(sbyte x, sbyte y)
            => negative(xor(x, y));

        [MethodImpl(Inline)]
        public sbyte mask(sbyte x)
             => (sbyte)(x >> bitsize(x) - 1);

        [MethodImpl(Inline)]
        public sbyte abs(sbyte x)
        {
            var m = mask(x);
            return xor(add(x, m), m);
        }

        [MethodImpl(Inline)]
        public sbyte negate(sbyte x)
            => (sbyte)-x;
        
        [MethodImpl(Inline)]
        public bool nonzero(sbyte x)
            => x != 0;
 
        [MethodImpl(Inline)]
        public sbyte min(sbyte x, sbyte y)
            => xor(y, and(xor(x,y), negate(lt(x,y))));

        [MethodImpl(Inline)]
        public sbyte max(sbyte x, sbyte y)
            => xor(x , ( and(xor(x,y) , negate(lt(x,  y)))));

        [MethodImpl(Inline)]
        public sbyte gcd(sbyte lhs, sbyte rhs)
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
        public Quorem<sbyte> divrem(sbyte lhs, sbyte rhs)
        {
            var quo = div(lhs, rhs);
            return Quorem.define(quo, 
                sub(lhs, mul(quo, rhs)));
        }
    }
}