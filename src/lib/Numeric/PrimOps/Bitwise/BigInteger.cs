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
            Bitwise<BigInteger> 


        {

            // !! BigInteger
            // !! -------------------------------------------------------------

            [MethodImpl(Inline)]   
            public BigInteger and(BigInteger lhs, BigInteger rhs) 
                => lhs & rhs;

            [MethodImpl(Inline)]   
            public BigInteger or(BigInteger lhs, BigInteger rhs) 
                => lhs | rhs;

            [MethodImpl(Inline)]   
            public BigInteger xor(BigInteger lhs, BigInteger rhs) 
                => lhs ^ rhs;

            [MethodImpl(Inline)]   
            public BigInteger lshift(BigInteger lhs, int rhs) 
                => lhs << rhs;

            [MethodImpl(Inline)]   
            public BigInteger rshift(BigInteger lhs, int rhs) 
                => lhs >> rhs;

            [MethodImpl(Inline)]   
            public BigInteger flip(BigInteger x) 
                => ~ x;

            [MethodImpl(Inline)]   
            public BitString bitstring(BigInteger src) 
                => BitString.define(src);

            /// <summary>
            /// Interprets the source as an array of bytes
            /// </summary>
            /// <param name="src">The soruce value</param>
            [MethodImpl(Inline)]
            public byte[] bytes(BigInteger src)
                => src.ToByteArray();

            /// <summary>
            /// Determines whether a position-specified bit in the source is on
            /// </summary>
            /// <param name="src">The bit source</param>
            [MethodImpl(Inline)]
            public bool testbit(BigInteger src, int pos)
                => (src & (1 << pos)) != 0;

            /// <summary>
            /// Counts the number of trailing zero bits in the source
            /// </summary>
            /// <param name="src">The bit source</param>
            [MethodImpl(Inline)]
            public static int countTrailingOff(int src)
                => BitOperations.TrailingZeroCount(src);


        }
    }
}}

