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
            Bitwise<double> 
        {
            
            [MethodImpl(Inline)]   
            public double and(double lhs, double rhs)
                => (long)lhs & (long)rhs;

            [MethodImpl(Inline)]   
            public double or(double lhs, double rhs)
                => (long)lhs | (long)rhs;

            [MethodImpl(Inline)]   
            public double xor(double lhs, double rhs)
                => (long)lhs ^ (long)rhs;

            [MethodImpl(Inline)]   
            public double flip(double x)
                => ~(long)x;

            [MethodImpl(Inline)]   
            public double lshift(double lhs, int rhs)
                => (long)lhs << rhs;

            [MethodImpl(Inline)]   
            public double rshift(double lhs, int rhs)
                => (long)lhs >> rhs;

            /// <summary>
            /// Renders a number as a base-2 formatted string
            /// </summary>
            /// <param name="src">The source number</param>
            [MethodImpl(Inline)]
            public string bitchars(double src)
                => bitchars(BitConverter.DoubleToInt64Bits(src));

            [MethodImpl(Inline)]   
            public BitString bitstring(double src) 
                => BitString.define(Bits.parse(bitchars(src)));

            /// <summary>
            /// Interprets the source as an array of bytes
            /// </summary>
            /// <param name="src">The soruce value</param>
            [MethodImpl(Inline)]
            public byte[] bytes(double src)
                => BitConverter.GetBytes(src);

            /// <summary>
            /// Determines whether a position-specified bit in the source is on
            /// </summary>
            /// <param name="src">The bit source</param>
            [MethodImpl(Inline)]
            public bool testbit(double src, int pos)
                => testbit(BitConverter.DoubleToInt64Bits(src),pos);


            [MethodImpl(Inline)]
            public bit[] bits(double src)
                => bits(BitConverter.DoubleToInt64Bits(src));
        }
    }
}}

