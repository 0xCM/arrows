//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    using static HexDigit;


    public static class DigitsX
    {

        /// <summary>
        /// Returns the character corresponding to a digit
        /// </summary>
        /// <param name="src">The source digit</param>
        [MethodImpl(Inline)]   
        public static char ToChar(this BinaryDigit src)
        {
            if(src == BinaryDigit.Zed)
                return AsciDigits.A0;
            else if(src == BinaryDigit.One)
                return AsciDigits.A1;
            else
                return MathSym.EmptySet;
        }


        [MethodImpl(Inline)]   
        public static char ToChar(this DeciDigit src)
        {
            if(src == DeciDigit.D0)
                return AsciDigits.A0;
            else if(src == DeciDigit.D1)
                return AsciDigits.A1;
            else if(src == DeciDigit.D2)
                return AsciDigits.A2;
            else if(src == DeciDigit.D3)
                return AsciDigits.A3;
            else if(src == DeciDigit.D4)
                return AsciDigits.A4;
            else if(src == DeciDigit.D5)
                return AsciDigits.A5;
            else if(src == DeciDigit.D6)
                return AsciDigits.A6;
            else if(src == DeciDigit.D7)
                return AsciDigits.A7;
            else if(src == DeciDigit.D8)
                return AsciDigits.A8;
            else if(src == DeciDigit.D9)
                return AsciDigits.A9;
            else 
                return MathSym.EmptySet;
        }

        [MethodImpl(Inline)]   
        public static char ToChar(this HexDigit src)
        {
            if(src == HexDigit.X0)
                return AsciDigits.A0;
            else if(src == HexDigit.X1)
                return AsciDigits.A1;
            else if(src == HexDigit.X2)
                return AsciDigits.A2;
            else if(src == HexDigit.X3)
                return AsciDigits.A3;
            else if(src == HexDigit.X4)
                return AsciDigits.A4;
            else if(src == HexDigit.X5)
                return AsciDigits.A5;
            else if(src == HexDigit.X6)
                return AsciDigits.A6;
            else if(src == HexDigit.X7)
                return AsciDigits.A7;
            else if(src == HexDigit.X8)
                return AsciDigits.A8;
            else if(src == HexDigit.X9)
                return AsciDigits.A9;
            else if(src == HexDigit.XA)
                return AsciLower.a;
            else if(src == HexDigit.XB)
                return AsciLower.b;
            else if(src == HexDigit.XC)
                return AsciLower.c;
            else if(src == HexDigit.XD)
                return AsciLower.d;
            else if(src == HexDigit.XE)
                return AsciLower.e;
            else if(src == HexDigit.XF)
                return AsciLower.f;
            else 
                return MathSym.EmptySet;
        }

        public static Span<DeciDigit> ToDeciDigits(this long src)
            => DeciDigits.Parse(src.ToString());


        /// <summary>
        /// Formats a span of binary digits as a contiguous block
        /// </summary>
        /// <param name="src">The source digits</param>
        public static string Format(this ReadOnlySpan<BinaryDigit> src, bool reorient = true)
        {
            if(reorient)
                src = src.Reverse();
            var dst = new char[src.Length + 2];             
            dst[0] = '0';
            dst[1] = 'b';
            for(var i = 0; i < src.Length; i++)
                dst[i + 2] = src[i].ToChar();
            return new string(dst);
        }

        /// <summary>
        /// Formats a span of binary digits as a contiguous block
        /// </summary>
        /// <param name="src">The source digits</param>
        [MethodImpl(Inline)]   
        public static string Format(this Span<BinaryDigit> src)
            => src.ReadOnly().Format(true);

        /// <summary>
        /// Formats a span of decimal digits as a contiguous block
        /// </summary>
        /// <param name="src">The source digits</param>
        public static string Format(this ReadOnlySpan<DeciDigit> src)
        {
            var dst = new char[src.Length]; 
            for(var i = 0; i< src.Length; i++)
                dst[i] = (char) src[i].ToChar();
            return new string(dst);
        }

        /// <summary>
        /// Formats a span of decimal digits as a contiguous block
        /// </summary>
        /// <param name="src">The source digits</param>
        [MethodImpl(Inline)]   
        public static string Format(this Span<DeciDigit> src)
            => src.ReadOnly().Format();

        /// <summary>
        /// Formats a span of hex digits as a contiguous block
        /// </summary>
        /// <param name="src">The source digits</param>
        public static string Format(this ReadOnlySpan<HexDigit> src, bool specifier = true)
        {
            var dst = new char[src.Length + 2]; 
            var dstStart = specifier ? 2 : 0;
            dst[0] = '0';
            dst[1] = 'x';
            for(var i = 0; i < src.Length; i++)
                dst[i + 2] = src[i].ToChar();
            return new string(dst);
        }

        /// <summary>
        /// Formats a span of hex digits as a contiguous block
        /// </summary>
        /// <param name="src">The source digits</param>
        [MethodImpl(Inline)]   
        public static string Format(this Span<HexDigit> src, bool specifier = true)
            => src.ReadOnly().Format(specifier);
    }
}