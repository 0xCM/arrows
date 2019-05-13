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
        public static char Format(this BinaryDigit src)
            => src switch{
                BinaryDigit.Zed => '0',
                BinaryDigit.One => '1',
                _ => throw unsupported(src)
            };

        [MethodImpl(NotInline)]   
        public static string Format(this ReadOnlySpan<BinaryDigit> src)
        {
            var dst = new char[src.Length + 2]; 
            dst[0] = '0';
            dst[1] = 'b';
            for(var i = 0; i < src.Length; i++)
                dst[i + 2] = src[i].Format();
            return new string(dst);
        }

        [MethodImpl(Inline)]   
        public static string Format(this Span<BinaryDigit> src)
            => src.ToReadOnlySpan().Format();

        [MethodImpl(Inline)]   
        public static char Format(this DeciDigit src)
            => src switch{
                DeciDigit.D0 => '0',
                DeciDigit.D1 => '1',
                DeciDigit.D2 => '2',
                DeciDigit.D3 => '3',
                DeciDigit.D4 => '4',
                DeciDigit.D5 => '5',
                DeciDigit.D6 => '6',
                DeciDigit.D7 => '7',
                DeciDigit.D8 => '8',
                DeciDigit.D9 => '9',                                
                _ => throw unsupported(src)
            };

        [MethodImpl(NotInline)]   
        public static string Format(this ReadOnlySpan<DeciDigit> src)
        {
            var dst = new char[src.Length]; 
            for(var i = 0; i< src.Length; i++)
                dst[i] = (char) src[i].Format();
            return new string(dst);
        }

        [MethodImpl(Inline)]   
        public static string Format(this Span<DeciDigit> src)
            => src.ToReadOnlySpan().Format();

        [MethodImpl(Inline)]   
        public static char Format(this HexDigit src)
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
        public static string Format(this ReadOnlySpan<HexDigit> src)
        {
            var dst = new char[src.Length + 2]; 
            dst[0] = '0';
            dst[1] = 'x';
            for(var i = 0; i < src.Length; i++)
                dst[i + 2] = src[i].Format();
            return new string(dst);
        }

        [MethodImpl(Inline)]   
        public static string Format(this Span<HexDigit> src)
            => src.ToReadOnlySpan().Format();

    }
}