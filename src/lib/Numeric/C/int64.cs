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

    // !! long
    // !! -----------------------------------------------------------------


    partial class C : C.SignableNumber<long>
    {
 
        readonly NumberInfo<long> z64i
            = new NumberInfo<long>((Int64.MinValue,Int64.MaxValue), true, 0, 1, 64);

        [MethodImpl(Inline)]
        public long z64(long x)
            => x;

        [MethodImpl(Inline)]
        public long z64(bool x)
            => z64(x ? z64i.One : z64i.Zero);

        [MethodImpl(Inline)]
        public NumberInfo<long> numinfo(long x)
            => z64i;

        [MethodImpl(Inline)]
        public long bitsize(long x)
            => numinfo(x).BitSize;

        [MethodImpl(Inline)]
        public long zero(long x)
            => numinfo(x).Zero;

        [MethodImpl(Inline)]
        public long one(long x)
            => numinfo(x).One;

        [MethodImpl(Inline)]
        public long eq(long lhs, long rhs)
            => z64(lhs == rhs);

        [MethodImpl(Inline)]
        public long neq(long lhs, long rhs)
            => z64(lhs != rhs);

        [MethodImpl(Inline)]
        public long lt(long lhs, long rhs)
            => z64(lhs < rhs);

        [MethodImpl(Inline)]
        public long lteq(long lhs, long rhs)
            => z64(lhs <= rhs);

        [MethodImpl(Inline)]
        public long gt(long lhs, long rhs)
            => z64(lhs > rhs);

        [MethodImpl(Inline)]
        public long gteq(long lhs, long rhs)
            => z64(lhs >= rhs);

        [MethodImpl(Inline)]
        public long add(long lhs, long rhs)
            => (long)(lhs + rhs);

        [MethodImpl(Inline)]
        public long sub(long lhs, long rhs)
            => (long)(lhs - rhs);

        [MethodImpl(Inline)]
        public long mul(long lhs, long rhs)
            => (long)(lhs * rhs);

        [MethodImpl(Inline)]
        public long div(long lhs, long rhs)
            => (long)(lhs / rhs);

        [MethodImpl(Inline)]
        public long mod(long lhs, long rhs)
            => (long)(lhs % rhs);

        [MethodImpl(Inline)]
        public long and(long lhs, long rhs)
            => (long)(lhs & rhs);

        [MethodImpl(Inline)]
        public long or(long lhs, long rhs)
            => (long)(lhs | rhs);

        [MethodImpl(Inline)]
        public long xor(long lhs, long rhs)
            => (long)(lhs ^ rhs);

        [MethodImpl(Inline)]
        public long flip(long x)
            => (long)(~x);

        [MethodImpl(Inline)]
        public long lshift(long lhs, int rhs)
            => (long)(lhs << rhs);

        [MethodImpl(Inline)]
        public long rshift(long lhs, int rhs)
            => (long)(lhs >> rhs);

        [MethodImpl(Inline)]
        public long sign(long x)
            => sub(gt(x, 0L), lt(x,0L)); 

        [MethodImpl(Inline)]
        public long negate(long x)
            => -x;

        [MethodImpl(Inline)]
        public long positive(long x)
            => gt(x, 0);

        [MethodImpl(Inline)]
        public long negative(long x)
            => lt(x, 0);

        /// <summary>
        /// Determines whether two integers have the same sign
        /// </summary>
        /// <param name="x">The first operand</param>
        /// <param name="y">The second operand</param>
        /// <returns>Returns 1 if the signs of the integers agree, 0 otherwise</returns>
        [MethodImpl(Inline)]
        public long signeq(long x, long y)
            => negative(xor(x,y));

        [MethodImpl(Inline)]
        public long mask(long x)
            => x >> (int)bitsize(x) - 1;

        [MethodImpl(Inline)]
        public long abs(long x)
        {
            var m = mask(x);
            return (x + m)  ^ m;
        }

        [MethodImpl(Inline)]
        public long min(long x, long y)
            => xor(y, and(xor(x,y), negate(lt(x,y))));

        [MethodImpl(Inline)]
        public long max(long x, long y)
            => xor(x , ( and(xor(x,y) , negate(lt(x,  y)))));

        [MethodImpl(Inline)]
        public long gcd(long lhs, long rhs)
        {
            var x = abs(lhs);
            var y = abs(rhs);
            while (y != 0L)
            {
                var rem = mod(x,y);
                x = y;
                y = rem;
            }
            return x;
       }

        [MethodImpl(Inline)]
        public Quorem<long> divrem(long lhs, long rhs)
        {
            var quo = div(lhs, rhs);
            return Quorem.define(quo, 
                sub(lhs, mul(quo, rhs)));
        }
    }
}