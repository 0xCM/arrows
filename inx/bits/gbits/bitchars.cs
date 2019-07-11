//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;
    using static As;
    using static AsIn;

    partial class gbits
    {
        [MethodImpl(Inline), PrimalKinds(PrimalKind.All)]
        public static char bitchar<T>(in T src, int pos)
            where T : struct
                => gbits.test(in src, pos)  ? AsciDigits.A1 : AsciDigits.A0;                

        /// <summary>
        /// Constructs bitstring characters for integral values
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), PrimalKinds(PrimalKind.UnsignedInt)]
        public static ReadOnlySpan<char> bitchars<T>(in T src)
        {
            if(typeof(T) == typeof(byte))
                return Bits.bitchars(uint8(in src));
            else if(typeof(T) == typeof(sbyte))
                return Bits.bitchars(int8(in src));
            else if(typeof(T) == typeof(ushort))
                return Bits.bitchars(uint16(in src));
            else if(typeof(T) == typeof(short))
                return Bits.bitchars(int16(in src));
            else if(typeof(T) == typeof(uint))
                return Bits.bitchars(uint32(in src));
            else if(typeof(T) == typeof(int))
                return Bits.bitchars(int32(in src));
            else if(typeof(T) == typeof(ulong))
                return Bits.bitchars(uint64(in src));
            else if(typeof(T) == typeof(long))
                return Bits.bitchars(int64(in src));
            else            
                throw unsupported<T>();            
        }

        /// <summary>
        /// Converts a span of primal values to a span of characters, each of which represent a bit
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [PrimalKinds(PrimalKind.All)]
        public static Span<char> bitchars<T>(ReadOnlySpan<T> src)
            where T : struct
        {
            var seglen = Unsafe.SizeOf<T>()*8;
            var bitcount = src.Length * seglen;
            Span<char> dst = new char[bitcount];
            for(var i=0; i<src.Length; i++)
                bitchars(src[i]).CopyTo(dst, i*seglen);
            return dst;
        }

        [MethodImpl(Inline), PrimalKinds(PrimalKind.All)]
        public static Span<char> bitchars<T>(Span<T> src)
            where T : struct
            => bitchars(src.ReadOnly());    
    }
}