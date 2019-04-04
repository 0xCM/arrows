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

    using  static zcore;

    // !! ulong
    // !! -----------------------------------------------------------------

    partial class C : C.Number<ulong>
    {
        readonly NumberInfo<ulong> u64i
            = new NumberInfo<ulong>((UInt64.MinValue,UInt64.MaxValue), true, 0, 1, 64);

        [MethodImpl(Inline)]
        public ulong u64(ulong x)
            => x;

        [MethodImpl(Inline)]
        public ulong u64(bool x)
            => u64(x ? u64i.One : u64i.Zero);

        [MethodImpl(Inline)]
        public NumberInfo<ulong> numinfo(ulong x)
            => u64i;

        [MethodImpl(Inline)]
        public ulong bitsize(ulong x)
            => numinfo(x).BitSize;

        [MethodImpl(Inline)]
        public ulong zero(ulong x)
            => numinfo(x).Zero;

        [MethodImpl(Inline)]
        public ulong one(ulong x)
            => numinfo(x).One;

        [MethodImpl(Inline)]
        public ulong eq(ulong lhs, ulong rhs)
            => u64(lhs == rhs);

        [MethodImpl(Inline)]
        public ulong neq(ulong lhs, ulong rhs)
            => u64(lhs != rhs);

        [MethodImpl(Inline)]
        public ulong lt(ulong lhs, ulong rhs)
            => u64(lhs < rhs);

        [MethodImpl(Inline)]
        public ulong lteq(ulong lhs, ulong rhs)
            => u64(lhs <= rhs);

        [MethodImpl(Inline)]
        public ulong gt(ulong lhs, ulong rhs)
            => u64(lhs > rhs);

        [MethodImpl(Inline)]
        public ulong gteq(ulong lhs, ulong rhs)
            => u64(lhs >= rhs);


        [MethodImpl(Inline)]
        public ulong add(ulong lhs, ulong rhs)
            => lhs + rhs;

        [MethodImpl(Inline)]
        public ulong sub(ulong lhs, ulong rhs)
            => lhs - rhs;

        [MethodImpl(Inline)]
        public ulong mul(ulong lhs, ulong rhs)
            => lhs * rhs;

        [MethodImpl(Inline)]
        public ulong div(ulong lhs, ulong rhs)
            => lhs / rhs;

        [MethodImpl(Inline)]
        public ulong mod(ulong lhs, ulong rhs)
            => lhs % rhs;

        [MethodImpl(Inline)]
        public ulong and(ulong lhs, ulong rhs)
            => lhs & rhs;

        [MethodImpl(Inline)]
        public ulong or(ulong lhs, ulong rhs)
            => lhs | rhs;

        [MethodImpl(Inline)]
        public ulong xor(ulong lhs, ulong rhs)
            => lhs ^ rhs;

        [MethodImpl(Inline)]
        public ulong flip(ulong x)
            => ~x;

        [MethodImpl(Inline)]
        public ulong lshift(ulong lhs, int rhs)
            => lhs << rhs;

        [MethodImpl(Inline)]
        public ulong rshift(ulong lhs, int rhs)
            => lhs >> rhs;

        [MethodImpl(Inline)]
        public ulong positive(ulong x)
            => gt(x, 0);

        [MethodImpl(Inline)]
        public ulong negative(ulong x)
            => u64(0);

        [MethodImpl(Inline)]
        public ulong sign(ulong x)
            => positive(x);

        [MethodImpl(Inline)]
        public ulong abs(ulong x)
            => x;

        [MethodImpl(Inline)]
        public ulong gcd(ulong lhs, ulong rhs)
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
        public Quorem<ulong> divrem(ulong lhs, ulong rhs)
        {
            var quo = div(lhs, rhs);
            return Quorem.define(quo, 
                sub(lhs, mul(quo, rhs)));
        }


    }
}