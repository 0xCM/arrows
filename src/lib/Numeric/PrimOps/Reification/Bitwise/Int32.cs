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
            Bitwise<int> 


        {


            // !! int
            // !! -------------------------------------------------------------

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
            public int lshift(int lhs, int rhs) 
                => lhs << rhs;

            [MethodImpl(Inline)]   
            public int rshift(int lhs, int rhs) 
                => lhs >> rhs;

            [MethodImpl(Inline)]   
            public int flip(int src) 
                => ~ src;

            [MethodImpl(Inline)]   
            public BitString bitstring(int src) 
                => BitString.define(src);

            /// <summary>
            /// Extracts the data contained in the source as an array of bytes
            /// </summary>
            /// <param name="src">The source value</param>
            [MethodImpl(Inline)]
            public byte[] bytes(int src)
                => BitConverter.GetBytes(src); 

            /// <summary>
            /// Determines whether a position-specified bit in the source is on
            /// </summary>
            /// <param name="src">The bit source</param>
            [MethodImpl(Inline)]
            public bool testbit(int src, int pos)
                => (src & (1 << pos)) != 0;

        }
    }
}}

