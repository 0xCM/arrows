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

    partial class C : C.Number<uint>
    {
        // !! uint
        // !! -----------------------------------------------------------------

        readonly NumberInfo<uint> u32i
            = new NumberInfo<uint>((UInt32.MinValue,UInt32.MaxValue), true, 0, 1, 32);

        [MethodImpl(Inline)]
        public uint u32(bool x)
            => u32(x ? u32i.One : u32i.Zero);

        [MethodImpl(Inline)]
        public uint u32(uint x)
            => x;

        [MethodImpl(Inline)]
        public NumberInfo<uint> numinfo(uint x)
            => u32i;

        [MethodImpl(Inline)]
        public uint bitsize(uint x)
            => numinfo(x).BitSize;

        [MethodImpl(Inline)]
        public uint zero(uint x)
            => numinfo(x).Zero;

        [MethodImpl(Inline)]
        public uint one(uint x)
            => numinfo(x).One;

        [MethodImpl(Inline)]
        public uint eq(uint lhs, uint rhs)
            => u32(lhs == rhs);

        [MethodImpl(Inline)]
        public uint neq(uint lhs, uint rhs)
            => u32(lhs != rhs);

        [MethodImpl(Inline)]
        public uint lt(uint lhs, uint rhs)
            => u32(lhs < rhs);

        [MethodImpl(Inline)]
        public uint lteq(uint lhs, uint rhs)
            => u32(lhs <= rhs);

        [MethodImpl(Inline)]
        public uint gt(uint lhs, uint rhs)
            => u32(lhs > rhs);

        [MethodImpl(Inline)]
        public uint gteq(uint lhs, uint rhs)
            => u32(lhs >= rhs);

        [MethodImpl(Inline)]
        public uint add(uint lhs, uint rhs)
            => (uint)(lhs + rhs);

        [MethodImpl(Inline)]
        public uint sub(uint lhs, uint rhs)
            => (uint)(lhs - rhs);

        [MethodImpl(Inline)]
        public uint mul(uint lhs, uint rhs)
            => (uint)(lhs * rhs);

        [MethodImpl(Inline)]
        public uint div(uint lhs, uint rhs)
            => (uint)(lhs / rhs);

        [MethodImpl(Inline)]
        public uint mod(uint lhs, uint rhs)
            => (uint)(lhs % rhs);

        [MethodImpl(Inline)]
        public uint and(uint lhs, uint rhs)
            => (uint)(lhs & rhs);

        [MethodImpl(Inline)]
        public uint or(uint lhs, uint rhs)
            => (uint)(lhs | rhs);

        [MethodImpl(Inline)]
        public uint xor(uint lhs, uint rhs)
            => (uint)(lhs ^ rhs);

        [MethodImpl(Inline)]
        public uint flip(uint x)
            => (uint)(~x);

        [MethodImpl(Inline)]
        public uint lshift(uint lhs, int rhs)
            => (uint)(lhs << rhs);

        [MethodImpl(Inline)]
        public uint rshift(uint lhs, int rhs)
            => (uint)(lhs >> rhs);

        [MethodImpl(Inline)]
        public uint positive(uint x)
            => gt(x, 0u);

        [MethodImpl(Inline)]
        public uint negative(uint x)
            => 0u;

        [MethodImpl(Inline)]
        public uint sign(uint x)
            => positive(x);
  
        [MethodImpl(Inline)]
        public uint gcd(uint lhs, uint rhs)
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
        public Quorem<uint> divrem(uint lhs, uint rhs)
        {
            var quo = div(lhs, rhs);
            return Quorem.define(quo, 
                sub(lhs, mul(quo, rhs)));
        }

    }
}