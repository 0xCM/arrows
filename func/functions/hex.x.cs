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
    
    partial class xfunc
    {
        [MethodImpl(Inline)]
        static string hexX(bool upper = false)
            => upper ? "X" : "x";

        /// <summary>
        /// Renders a number as a hexadecimal string
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content should be left-padded 
        /// with zeros commensurate with size of the source number's data type</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        [MethodImpl(Inline)]
        public static HexString ToHexString(this sbyte src, bool zpad = true, bool specifier = true, bool uppercase = false)
            => (specifier ? "0x" : string.Empty) 
            + (zpad ? src.ToString(hexX(uppercase)).PadLeft(2, '0') 
            : src.ToString(hexX(uppercase)));

        /// <summary>
        /// Renders a number as a hexadecimal string
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content should be left-padded 
        /// with zeros commensurate with size of the source number's data type</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        [MethodImpl(Inline)]
        public static HexString ToHexString(this byte src, bool zpad = true, bool specifier = true, bool uppercase = false)
            => (specifier ? "0x" : string.Empty) 
             + (zpad ? src.ToString(hexX(uppercase)).PadLeft(2, '0') 
                     : src.ToString(hexX(uppercase)));

        /// <summary>
        /// Renders a number as a hexadecimal string
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content should be left-padded 
        /// with zeros commensurate with size of the source number's data type</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        [MethodImpl(Inline)]
        public static HexString ToHexString(this short src, bool zpad = true, bool specifier = true, bool uppercase = false)
            => (specifier ? "0x" : string.Empty) 
             + (zpad ? src.ToString(hexX(uppercase)).PadLeft(4, '0') 
                     : src.ToString(hexX(uppercase)) );

        /// <summary>
        /// Renders a number as a hexadecimal string
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content should be left-padded 
        /// with zeros commensurate with size of the source number's data type</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        [MethodImpl(Inline)]
        public static HexString ToHexString(this ushort src, bool zpad = true, bool specifier = true, bool uppercase = false)
            => (specifier ? "0x" : string.Empty) 
             + (zpad ? src.ToString(hexX(uppercase)).PadLeft(4, '0') 
                     : src.ToString(hexX(uppercase)) );

        /// <summary>
        /// Renders a number as a hexadecimal string
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content should be left-padded 
        /// with zeros commensurate with size of the source number's data type</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        [MethodImpl(Inline)]
        public static HexString ToHexString(this int src, bool zpad = true, bool specifier = true, bool uppercase = false)
            => (specifier ? "0x" : string.Empty) 
             + (zpad ? src.ToString(hexX(uppercase)).PadLeft(8, '0') 
                     : src.ToString(hexX(uppercase)) );

        /// <summary>
        /// Renders a number as a hexadecimal string
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content should be left-padded 
        /// with zeros commensurate with size of the source number's data type</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        [MethodImpl(Inline)]
        public static HexString ToHexString(this uint src, bool zpad = true, bool specifier = true, bool uppercase = false)
            => (specifier ? "0x" : string.Empty) 
             + (zpad ? src.ToString(hexX(uppercase)).PadLeft(8, '0') 
                     : src.ToString(hexX(uppercase)) );

        /// <summary>
        /// Renders a number as a hexadecimal string
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content should be left-padded 
        /// with zeros commensurate with size of the source number's data type</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        [MethodImpl(Inline)]
        public static HexString ToHexString(this long src, bool zpad = true, bool specifier = true, bool uppercase = false)
            => (specifier ? "0x" : string.Empty) 
             + (zpad ? src.ToString(hexX(uppercase)).PadLeft(16, '0') 
                     : src.ToString(hexX(uppercase)) );

        /// <summary>
        /// Renders a number as a hexadecimal string
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content should be left-padded 
        /// with zeros commensurate with size of the source number's data type</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        [MethodImpl(Inline)]
        public static HexString ToHexString(this ulong src, bool zpad = true, bool specifier = true, bool uppercase = false)
            => (specifier ? "0x" : string.Empty) 
             + (zpad ? src.ToString(hexX(uppercase)).PadLeft(16, '0') 
                     : src.ToString(hexX(uppercase)) );

        /// <summary>
        /// Renders a number as a hexadecimal string
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content should be left-padded 
        /// with zeros commensurate with size of the source number's data type</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        [MethodImpl(Inline)]
        public static HexString ToHexString(this float src, bool zpad = true, bool specifier = true, bool uppercase = false)
            =>  BitConverter.SingleToInt32Bits(src).ToHexString(zpad, specifier, uppercase);
        
        /// <summary>
        /// Renders a number as a hexadecimal string
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content should be left-padded 
        /// with zeros commensurate with size of the source number's data type</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        [MethodImpl(Inline)]
        public static HexString ToHexString(this double src, bool zpad = true, bool specifier = true, bool uppercase = false)
            =>  BitConverter.DoubleToInt64Bits(src).ToHexString(zpad, specifier, uppercase);

        /// <summary>
        /// Renders a stream of numbers as a stream of hexadecimal strings
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content of each number should be left-padded 
        /// with zeros commensurate with size of the source number's data type</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        public static IEnumerable<HexString> ToHexStrings(this IEnumerable<byte> src, bool zpad = true, bool specifier = true, bool uppercase = false)
            => src.Select(x => x.ToHexString(zpad, specifier, uppercase));

        public static string ToBlockedHexString(this IEnumerable<byte> src, bool specifier = false, string sep = " ", bool uppercase = false)
            => src.ToHexStrings(true, specifier, uppercase).Select(x => x.ToString()).Concat(sep);

        /// <summary>
        /// Renders a stream of numbers as a stream of hexadecimal strings
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content of each number should be left-padded 
        /// with zeros commensurate with size of the source number's data type</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        public static IEnumerable<HexString> ToHexStrings(this IEnumerable<sbyte> src, bool zpad = true, bool specifier = true, bool uppercase = false)
            => src.Select(x => x.ToHexString(zpad, specifier, uppercase));

        /// <summary>
        /// Renders a stream of numbers as a stream of hexadecimal strings
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content of each number should be left-padded 
        /// with zeros commensurate with size of the source number's data type</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        public static IEnumerable<HexString> ToHexStrings(this IEnumerable<short> src, bool zpad = true, bool specifier = true, bool uppercase = false)
            => src.Select(x => x.ToHexString(zpad, specifier, uppercase));

        /// <summary>
        /// Renders a stream of numbers as a stream of hexadecimal strings
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content of each number should be left-padded 
        /// with zeros commensurate with size of the source number's data type</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        public static IEnumerable<HexString> ToHexStrings(this IEnumerable<ushort> src, bool zpad = true, bool specifier = true, bool uppercase = false)
            => src.Select(x => x.ToHexString(zpad, specifier, uppercase));

        /// <summary>
        /// Renders a stream of numbers as a stream of hexadecimal strings
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content of each number should be left-padded 
        /// with zeros commensurate with size of the source number's data type</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        public static IEnumerable<HexString> ToHexStrings(this IEnumerable<int> src, bool zpad = true, bool specifier = true, bool uppercase = false)
            => src.Select(x => x.ToHexString(zpad, specifier, uppercase));

        /// <summary>
        /// Renders a stream of numbers as a stream of hexadecimal strings
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content of each number should be left-padded 
        /// with zeros commensurate with size of the source number's data type</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        public static IEnumerable<HexString> ToHexStrings(this IEnumerable<uint> src, bool zpad = true, bool specifier = true, bool uppercase = false)
            => src.Select(x => x.ToHexString(zpad, specifier, uppercase));

        /// <summary>
        /// Renders a stream of numbers as a stream of hexadecimal strings
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content of each number should be left-padded 
        /// with zeros commensurate with size of the source number's data type</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether the hex digits A - F should be formmatted uppercase</param>
        public static IEnumerable<HexString> ToHexStrings(this IEnumerable<long> src, bool zpad = true, bool specifier = true, bool uppercase = false)
            => src.Select(x => x.ToHexString(zpad, specifier, uppercase));

        /// <summary>
        /// Renders a stream of numbers as a stream of hexadecimal strings
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content of each number should be left-padded 
        /// with zeros commensurate with size of the source number's data type</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether the hex digits A - F should be formmatted uppercase</param>
        public static IEnumerable<HexString> ToHexStrings(this IEnumerable<ulong> src, bool zpad = true, bool specifier = true, bool uppercase = false)
            => src.Select(x => x.ToHexString(zpad, specifier, uppercase));

        /// <summary>
        /// Renders a stream of numbers as a stream of hexadecimal strings
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content of each number should be left-padded 
        /// with zeros commensurate with size of the source number's data type</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether the hex digits A - F should be formmatted uppercase</param>
        public static IEnumerable<HexString> ToHexStrings(this IEnumerable<float> src, bool zpad = true, bool specifier = true, bool uppercase = false)
            => src.Select(x => x.ToHexString(zpad, specifier, uppercase));

        /// <summary>
        /// Renders a stream of numbers as a stream of hexadecimal strings
        /// </summary>
        /// <param name="src">The source number</param>
        /// <param name="zpad">Specifies whether the numeric content of each number should be left-padded 
        /// with zeros commensurate with size of the source number's data type</param>
        /// <param name="specifier">Specifies whether the hex numeric specifier shold prefix the output</param>
        /// <param name="uppercase">Specifies whether the hex digits A - F should be formmatted uppercase</param>
        public static IEnumerable<HexString> ToHexStrings(this IEnumerable<double> src, bool zpad = true, bool specifier = true, bool uppercase = false)
            => src.Select(x => x.ToHexString(zpad, specifier,uppercase));
 
    }

}