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
        [MethodImpl(Inline)]   
        public static char ToCharDigit(this BinaryDigit src)
            => src switch{
                BinaryDigit.Zed => '0',
                BinaryDigit.One => '1',
                _ => throw unsupported(src)
            };


        [MethodImpl(Inline)]   
        public static char ToCharDigit(this DeciDigit src)
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
        public static char ToCharDigit(this HexDigit src)
            => src switch{
                HexDigit.X0 => '0',
                HexDigit.X1 => '1',
                HexDigit.X2 => '2',
                HexDigit.X3 => '3',
                HexDigit.X4 => '4',
                HexDigit.X5 => '5',
                HexDigit.X6 => '6',
                HexDigit.X7 => '7',
                HexDigit.X8 => '8',
                HexDigit.X9 => '9',
                HexDigit.XA => 'A',
                HexDigit.XB => 'B',
                HexDigit.XC => 'C',
                HexDigit.XD => 'D',
                HexDigit.XE => 'E',
                HexDigit.XF => 'F',
                                
                _ => throw unsupported(src)
            };

        [MethodImpl(NotInline)]   
        public static string Format(this ReadOnlySpan<BinaryDigit> src)
        {
            var dst = new char[src.Length + 2]; 
            dst[0] = '0';
            dst[1] = 'b';
            for(var i = 0; i < src.Length; i++)
                dst[i + 2] = src[i].ToCharDigit();
            return new string(dst);
        }

        [MethodImpl(Inline)]   
        public static string Format(this Span<BinaryDigit> src)
            => src.ToReadOnlySpan().Format();

        public static string Format(this ReadOnlySpan<DeciDigit> src)
        {
            var dst = new char[src.Length]; 
            for(var i = 0; i< src.Length; i++)
                dst[i] = (char) src[i].ToCharDigit();
            return new string(dst);
        }

        [MethodImpl(Inline)]   
        public static string Format(this Span<DeciDigit> src)
            => src.ToReadOnlySpan().Format();

        public static string Format(this ReadOnlySpan<HexDigit> src)
        {
            var dst = new char[src.Length + 2]; 
            dst[0] = '0';
            dst[1] = 'x';
            for(var i = 0; i < src.Length; i++)
                dst[i + 2] = src[i].ToCharDigit();
            return new string(dst);
        }

        [MethodImpl(Inline)]   
        public static string Format(this Span<HexDigit> src)
            => src.ToReadOnlySpan().Format();




    }
}