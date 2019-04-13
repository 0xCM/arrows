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
            Bitwise<float> 
        {
        
            [MethodImpl(Inline)]   
            public float and(float lhs, float rhs)
                => (int)lhs & (int)rhs;

            [MethodImpl(Inline)]   
            public float or(float lhs, float rhs)
                => (int)lhs | (int)rhs;

            [MethodImpl(Inline)]   
            public float xor(float lhs, float rhs)
                => (int)lhs ^ (int)rhs;

            [MethodImpl(Inline)]   
            public float flip(float x)
                => ~(int)x;

            [MethodImpl(Inline)]   
            public float lshift(float lhs, int rhs)
                => (int)lhs << rhs;

            [MethodImpl(Inline)]   
            public float rshift(float lhs, int rhs)
                => (int)lhs >> rhs;
        
            /// <summary>
            /// Renders a number as a base-2 formatted string
            /// </summary>
            /// <param name="src">The source number</param>
            [MethodImpl(Inline)]
            public string bitchars(float src)
                => bitchars(BitConverter.SingleToInt32Bits(src));
         
            [MethodImpl(Inline)]   
            public BitString bitstring(float src) 
                => BitString.define(Bits.parse(bitchars(src)));

            /// <summary>
            /// Interprets the source as an array of bytes
            /// </summary>
            /// <param name="src">The soruce value</param>
            [MethodImpl(Inline)]
            public byte[] bytes(float src)
                => BitConverter.GetBytes(src);

            /// <summary>
            /// Determines whether a position-specified bit in the source is on
            /// </summary>
            /// <param name="src">The bit source</param>
            [MethodImpl(Inline)]
            public bool testbit(float src, int pos)
                => testbit(BitConverter.SingleToInt32Bits(src),pos);

            [MethodImpl(Inline)]
            public bit[] bits(float src)
                => bits(BitConverter.SingleToInt32Bits(src));


        }
    }
}}
