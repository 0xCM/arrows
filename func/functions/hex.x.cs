//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;    
    
    using static zfunc;
    using static As;
    
    partial class xfunc
    {
        const int HexPad8 = 2;

        const int HexPad16 = 4;

        const int HexPad32 = 8;

        const int HexPad64 = 16;
        
        const string HexPrefix = "0x";

        const string HexPostfix = "h";

        [MethodImpl(Inline)]
        static string hexX(bool upper = false)
            => upper ? "X" : "x";

        [MethodImpl(Inline)]
        static string FormatHexScalar<T>(T src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return int8(ref src).FormatHex(zpad,specifier,uppercase,prespec);
            else if(typeof(T) == typeof(byte))
                return uint8(ref src).FormatHex(zpad,specifier,uppercase,prespec);
            else if(typeof(T) == typeof(short))
                return int16(ref src).FormatHex(zpad,specifier,uppercase,prespec);
            else if(typeof(T) == typeof(ushort))
                return uint16(ref src).FormatHex(zpad,specifier,uppercase,prespec);
            else if(typeof(T) == typeof(int))
                return int32(ref src).FormatHex(zpad,specifier,uppercase,prespec);
            else if(typeof(T) == typeof(uint))
                return uint32(ref src).FormatHex(zpad,specifier,uppercase,prespec);
            else if(typeof(T) == typeof(long))
                return int64(ref src).FormatHex(zpad,specifier,uppercase,prespec);
            else if(typeof(T) == typeof(ulong))
                return uint64(ref src).FormatHex(zpad,specifier,uppercase,prespec);
            else if(typeof(T) == typeof(float))
                return float32(ref src).FormatHex(zpad,specifier,uppercase,prespec);
            else if(typeof(T) == typeof(double))
                return float64(ref src).FormatHex(zpad,specifier,uppercase,prespec);
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Renders a number as a hexadecimal string
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content should be left-padded with zeros</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether hex characters should be upper-cased</param>
        /// <param name="prespec">Indicates where the specifier, if applied, is a prefix specifier (true) or a postfix specifier (false)</param>
        [MethodImpl(Inline)]
        public static string FormatHex(this sbyte src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => (specifier && prespec ? "0x" : string.Empty) 
            + (zpad ? src.ToString(hexX(uppercase)).PadLeft(HexPad8, '0') 
            : src.ToString(hexX(uppercase)))
             + (specifier && !prespec ? "h" : string.Empty);

        /// <summary>
        /// Renders a number as a hexadecimal string
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content should be left-padded with zeros</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether hex characters should be upper-cased</param>
        /// <param name="prespec">Indicates where the specifier, if applied, is a prefix specifier (true) or a postfix specifier (false)</param>
        [MethodImpl(Inline)]
        public static string FormatHex(this byte src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => (specifier && prespec ? "0x" : string.Empty) 
             + (zpad ? src.ToString(hexX(uppercase)).PadLeft(HexPad8, '0') 
                     : src.ToString(hexX(uppercase)))
             + (specifier && !prespec ? "h" : string.Empty);

        /// <summary>
        /// Renders a number as a hexadecimal string
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content should be left-padded with zeros</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether hex characters should be upper-cased</param>
        /// <param name="prespec">Indicates where the specifier, if applied, is a prefix specifier (true) or a postfix specifier (false)</param>
        [MethodImpl(Inline)]
        public static string FormatHex(this short src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => (specifier && prespec ? "0x" : string.Empty) 
             + (zpad ? src.ToString(hexX(uppercase)).PadLeft(HexPad16, '0') 
                     : src.ToString(hexX(uppercase)))
             + (specifier && !prespec ? "h" : string.Empty);

        /// <summary>
        /// Renders a number as a hexadecimal string
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content should be left-padded with zeros</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether hex characters should be upper-cased</param>
        /// <param name="prespec">Indicates where the specifier, if applied, is a prefix specifier (true) or a postfix specifier (false)</param>
        [MethodImpl(Inline)]
        public static string FormatHex(this ushort src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => (specifier && prespec ? "0x" : string.Empty) 
             + (zpad ? src.ToString(hexX(uppercase)).PadLeft(HexPad16, '0') 
                     : src.ToString(hexX(uppercase)))
             + (specifier && !prespec ? "h" : string.Empty);

        /// <summary>
        /// Renders a number as a hexadecimal string
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content should be left-padded with zeros</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether hex characters should be upper-cased</param>
        /// <param name="prespec">Indicates where the specifier, if applied, is a prefix specifier (true) or a postfix specifier (false)</param>
        [MethodImpl(Inline)]
        public static string FormatHex(this int src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => (specifier && prespec ? "0x" : string.Empty) 
             + (zpad ? src.ToString(hexX(uppercase)).PadLeft(HexPad32, '0') 
                     : src.ToString(hexX(uppercase)))
             + (specifier && !prespec ? "h" : string.Empty);

        /// <summary>
        /// Renders a number as a hexadecimal string
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content should be left-padded with zeros</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether hex characters should be upper-cased</param>
        /// <param name="prespec">Indicates where the specifier, if applied, is a prefix specifier (true) or a postfix specifier (false)</param>
        [MethodImpl(Inline)]
        public static string FormatHex(this uint src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => (specifier && prespec ? "0x" : string.Empty) 
             + (zpad ? src.ToString(hexX(uppercase)).PadLeft(HexPad32, '0') 
                     : src.ToString(hexX(uppercase)))
             + (specifier && !prespec ? "h" : string.Empty);

        /// <summary>
        /// Renders a number as a hexadecimal string
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content should be left-padded with zeros</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether hex characters should be upper-cased</param>
        /// <param name="prespec">Indicates where the specifier, if applied, is a prefix specifier (true) or a postfix specifier (false)</param>
        [MethodImpl(Inline)]
        public static string FormatHex(this long src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => (specifier && prespec ? "0x" : string.Empty) 
             + (zpad ? src.ToString(hexX(uppercase)).PadLeft(HexPad64, '0') 
                     : src.ToString(hexX(uppercase)))
             + (specifier && !prespec  ? "h" : string.Empty);

        /// <summary>
        /// Renders a number as a hexadecimal string
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content should be left-padded with zeros</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether hex characters should be upper-cased</param>
        /// <param name="prespec">Indicates where the specifier, if applied, is a prefix specifier (true) or a postfix specifier (false)</param>
        [MethodImpl(Inline)]
        public static string FormatHex(this ulong src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => (specifier && prespec ? "0x" : string.Empty) 
             + (zpad ? src.ToString(hexX(uppercase)).PadLeft(HexPad64, '0') 
                     : src.ToString(hexX(uppercase)))
             + (specifier && !prespec  ? "h" : string.Empty);
    
        /// <summary>
        /// Renders a number as a hexadecimal string
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content should be left-padded 
        /// with zeros commensurate with size of the source number's data type</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        [MethodImpl(Inline)]
        public static string FormatHex(this float src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            =>  BitConverter.SingleToInt32Bits(src).FormatHex(zpad, specifier, uppercase, prespec);
        
        /// <summary>
        /// Renders a number as a hexadecimal string
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content should be left-padded 
        /// with zeros commensurate with size of the source number's data type</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        [MethodImpl(Inline)]
        public static string FormatHex(this double src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            =>  BitConverter.DoubleToInt64Bits(src).FormatHex(zpad, specifier, uppercase, prespec);

        /// <summary>
        /// Renders a stream of numbers as a stream of hexadecimal strings
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content of each number should be left-padded 
        /// with zeros commensurate with size of the source number's data type</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        public static IEnumerable<string> FormatHex(this IEnumerable<byte> src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => src.Select(x => x.FormatHex(zpad, specifier, uppercase, prespec));

        /// <summary>
        /// Renders a stream of numbers as a stream of hexadecimal strings
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content of each number should be left-padded 
        /// with zeros commensurate with size of the source number's data type</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        public static IEnumerable<string> FormatHex(this IEnumerable<sbyte> src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => src.Select(x => x.FormatHex(zpad, specifier, uppercase, prespec));

        /// <summary>
        /// Renders a stream of numbers as a stream of hexadecimal strings
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content of each number should be left-padded 
        /// with zeros commensurate with size of the source number's data type</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        public static IEnumerable<string> FormatHex(this IEnumerable<short> src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => src.Select(x => x.FormatHex(zpad, specifier, uppercase, prespec));

        /// <summary>
        /// Renders a stream of numbers as a stream of hexadecimal strings
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content of each number should be left-padded 
        /// with zeros commensurate with size of the source number's data type</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        public static IEnumerable<string> FormatHex(this IEnumerable<ushort> src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => src.Select(x => x.FormatHex(zpad, specifier, uppercase, prespec));

        /// <summary>
        /// Renders a stream of numbers as a stream of hexadecimal strings
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content of each number should be left-padded 
        /// with zeros commensurate with size of the source number's data type</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        public static IEnumerable<string> FormatHex(this IEnumerable<int> src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => src.Select(x => x.FormatHex(zpad, specifier, uppercase, prespec));

        /// <summary>
        /// Renders a stream of numbers as a stream of hexadecimal strings
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content of each number should be left-padded 
        /// with zeros commensurate with size of the source number's data type</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        public static IEnumerable<string> FormatHex(this IEnumerable<uint> src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => src.Select(x => x.FormatHex(zpad, specifier, uppercase, prespec));

        /// <summary>
        /// Renders a stream of numbers as a stream of hexadecimal strings
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content of each number should be left-padded 
        /// with zeros commensurate with size of the source number's data type</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether the hex digits A - F should be formmatted uppercase</param>
        public static IEnumerable<string> FormatHex(this IEnumerable<long> src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => src.Select(x => x.FormatHex(zpad, specifier, uppercase, prespec));

        /// <summary>
        /// Renders a stream of numbers as a stream of hexadecimal strings
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content of each number should be left-padded 
        /// with zeros commensurate with size of the source number's data type</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether the hex digits A - F should be formmatted uppercase</param>
        public static IEnumerable<string> FormatHex(this IEnumerable<ulong> src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => src.Select(x => x.FormatHex(zpad, specifier, uppercase, prespec));

        /// <summary>
        /// Renders a stream of numbers as a stream of hexadecimal strings
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content of each number should be left-padded 
        /// with zeros commensurate with size of the source number's data type</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether the hex digits A - F should be formmatted uppercase</param>
        public static IEnumerable<string> FormatHex(this IEnumerable<float> src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => src.Select(x => x.FormatHex(zpad, specifier, uppercase, prespec));

        /// <summary>
        /// Renders a stream of numbers as a stream of hexadecimal strings
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content of each number should be left-padded 
        /// with zeros commensurate with size of the source number's data type</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether the hex digits A - F should be formmatted uppercase</param>
        public static IEnumerable<string> FormatHex(this IEnumerable<double> src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            => src.Select(x => x.FormatHex(zpad, specifier,uppercase, prespec));
 
         public static string FormatHexBlocks(this IEnumerable<byte> src, bool specifier = false, string sep = " ", bool uppercase = false, bool prespec = true)
            => src.FormatHex(true, specifier, uppercase, prespec).Select(x => x.ToString()).Concat(sep);

    }

}