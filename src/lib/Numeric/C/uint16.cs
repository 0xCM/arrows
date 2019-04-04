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

    // !! ushort
    // !! -----------------------------------------------------------------

    partial class C : C.Number<ushort>
    {

        readonly NumberInfo<ushort> u16i
            = new NumberInfo<ushort>((UInt16.MinValue,UInt16.MaxValue), true, 0, 1, 16);

        [MethodImpl(Inline)]
        public ushort u16(ushort x)
            => x;

        [MethodImpl(Inline)]
        public ushort u16(bool x)
            => u16(x ? u16i.One : u16i.Zero);

        [MethodImpl(Inline)]
        public NumberInfo<ushort> numinfo(ushort x)
            => u16i;

        [MethodImpl(Inline)]
        public ushort bitsize(ushort x)
            => numinfo(x).BitSize;

        [MethodImpl(Inline)]
        public ushort zero(ushort x)
            => numinfo(x).Zero;

        [MethodImpl(Inline)]
        public ushort one(ushort x)
            => numinfo(x).One;

        [MethodImpl(Inline)]
        public ushort eq(ushort lhs, ushort rhs)
            => u16(lhs == rhs);

        [MethodImpl(Inline)]
        public ushort neq(ushort lhs, ushort rhs)
            => u16(lhs != rhs);

        [MethodImpl(Inline)]
        public ushort lt(ushort lhs, ushort rhs)
            => u16(lhs < rhs);

        [MethodImpl(Inline)]
        public ushort lteq(ushort lhs, ushort rhs)
            => u16(lhs <= rhs);

        [MethodImpl(Inline)]
        public ushort gt(ushort lhs, ushort rhs)
            => u16(lhs > rhs);

        [MethodImpl(Inline)]
        public ushort gteq(ushort lhs, ushort rhs)
            => u16(lhs >= rhs);

        [MethodImpl(Inline)]
        public ushort add(ushort lhs, ushort rhs)
            => (ushort)(lhs + rhs);

        [MethodImpl(Inline)]
        public ushort sub(ushort lhs, ushort rhs)
            => (ushort)(lhs - rhs);

        [MethodImpl(Inline)]
        public ushort mul(ushort lhs, ushort rhs)
            => (ushort)(lhs * rhs);

        [MethodImpl(Inline)]
        public ushort div(ushort lhs, ushort rhs)
            => (ushort)(lhs / rhs);

        [MethodImpl(Inline)]
        public ushort mod(ushort lhs, ushort rhs)
            => (ushort)(lhs % rhs);
 
        [MethodImpl(Inline)]
        public ushort and(ushort lhs, ushort rhs)
            => (ushort)(lhs & rhs);

        [MethodImpl(Inline)]
        public ushort or(ushort lhs, ushort rhs)
            => (ushort)(lhs | rhs);

        [MethodImpl(Inline)]
        public ushort xor(ushort lhs, ushort rhs)
            => (ushort)(lhs ^ rhs);

        [MethodImpl(Inline)]
        public ushort flip(ushort x)
            => (ushort)(~x);

        [MethodImpl(Inline)]
        public ushort lshift(ushort lhs, int rhs)
            => (ushort)(lhs << rhs);

        [MethodImpl(Inline)]
        public ushort rshift(ushort lhs, int rhs)
            => (ushort)(lhs >> rhs);

        /// <summary>
        /// Determines whether a number is positive
        /// </summary>
        /// <param name="x">The test number</param>
        /// <returns>Returns 1 if x > 0 and 0 otherwise</returns>
        [MethodImpl(Inline)]
        public ushort positive(ushort x)
            => gt(x, zero(x));

        /// <summary>
        /// Determines whether a number is negative
        /// </summary>
        /// <param name="x">The number to test</param>
        /// <returns>
        /// Always returns 0
        /// </returns>
        [MethodImpl(Inline)]
        public ushort negative(ushort x)
            => zero(x);

        /// <summary>
        /// Determines the sign of a number
        /// </summary>
        /// <param name="x">The number to evaluate</param>
        /// <returns>
        /// If x == 0, returns 0
        /// If x > 0, return 1
        /// </returns>
        [MethodImpl(Inline)]
        public ushort sign(ushort x) 
            => positive(x);
    
        [MethodImpl(Inline)]
        public ushort abs(ushort x)
            => x;

        [MethodImpl(Inline)]
        public ushort gcd(ushort lhs, ushort rhs)
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
        public Quorem<ushort> divrem(ushort lhs, ushort rhs)
        {
            var quo = div(lhs, rhs);
            return Quorem.define(quo, 
                sub(lhs, mul(quo, rhs)));
        }


    }
}