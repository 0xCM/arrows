//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Runtime.CompilerServices;
    using static zcore;

    using static Operative;

    partial class PrimOps { partial class Reify {
        public readonly partial struct Bitwise : 
            Bitwise<decimal> 


        {

            // !! decimal
            // !! -------------------------------------------------------------

            [MethodImpl(Inline)]   
            public decimal and(decimal lhs, decimal rhs)
                => (long)lhs & (long)rhs;

            [MethodImpl(Inline)]   
            public decimal or(decimal lhs, decimal rhs)
                => (long)lhs | (long)rhs;

            [MethodImpl(Inline)]   
            public decimal xor(decimal lhs, decimal rhs)
                => (long)lhs ^ (long)rhs;

            [MethodImpl(Inline)]   
            public decimal flip(decimal x)
                => ~(long)x;

            [MethodImpl(Inline)]   
            public decimal lshift(decimal lhs, int rhs)
                => (long)lhs << rhs;

            [MethodImpl(Inline)]   
            public decimal rshift(decimal lhs, int rhs)
                => (long)lhs >> rhs;

            [MethodImpl(Inline)]   
            public BitString bitstring(decimal src) 
                => BitString.define(src);

            /// <summary>
            /// Determines whether a position-specified bit in the source is on
            /// </summary>
            /// <param name="src">The bit source</param>
            [MethodImpl(Inline)]
            public bool testbit(decimal src, int pos)
            {
                var bits = Decimal.GetBits(src);
                if(pos < 32)
                    return testbit(bits[0], pos);
                if(pos < 64)
                    return testbit(bits[1], pos);
                if(pos < 96)
                    return testbit(bits[2], pos);
                if(pos < 128)
                    return testbit(bits[3], pos);
                throw new ArgumentException($"Bit position {pos} out of range");
            }

            /// <summary>
            /// Interprets the source as an array of bytes
            /// </summary>
            /// <param name="src">The soruce value</param>
            [MethodImpl(Inline)]
            public byte[] bytes(decimal src)
                => zcore.concat(map(Decimal.GetBits(src), bytes));


        }
    }
}}

