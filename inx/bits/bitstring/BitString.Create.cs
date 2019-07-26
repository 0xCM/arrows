//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.IO;
    
    using static zfunc;
    using static As;
    using static Constants;

    partial struct BitString
    {
        /// <summary>
        /// Constructs a bitstring from primal value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static BitString FromScalar<T>(in T src)
            where T : struct
                => new BitString(gbits.bitseq(src));

        /// <summary>
        /// Constructs a bitstring from a span of primal values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        static BitString FromScalars<T>(ReadOnlySpan<T> src)
            where T : struct
                 =>  typeof(T) == typeof(char) 
                  ? FromBitChars(MemoryMarshal.Cast<T,char>(src)) 
                  : new BitString(gbits.bitseq(src));

        /// <summary>
        /// Constructs a bitstring from span of scalar values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitString FromScalars<T>(Span<T> src)
            where T : struct
                => FromScalars(src.ReadOnly());

        /// <summary>
        /// Constructs a bitstring from span of scalar values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="bitcount">The length of the bitstring</param>
        /// <typeparam name="T">The primal type</typeparam>
        /// <returns></returns>
        [MethodImpl(Inline)]        
        public static BitString FromScalars<T>(Span<T> src, int bitcount)
            where T : struct
                => BitString.FromScalars(gbits.bitchars(src.AsBytes(), bitcount));

        /// <summary>
        /// Assembles a bitstring from primal parts ordered from lo to hi
        /// </summary>
        /// <param name="parts">The primal values that define bitstring segments</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitString FromScalars<T>(params T[] parts)
            where T : struct
                => FromScalars(parts.ToReadOnlySpan());

        /// <summary>
        /// Constructs a bitstring from a power of 2
        /// </summary>
        /// <param name="exp">The value of the expoonent</param>
        [MethodImpl(Inline)]
        public static BitString FromPow2(int exp)
        {
            Span<byte> dst = stackalloc byte[exp + 1];
            dst[exp] = 1;
            return FromBitSeq(dst);
        }

        /// <summary>
        /// Constructs a bitstring from a span of bit characters
        /// </summary>
        /// <param name="src">The source characters, ordered from lo to hi</param>
        [MethodImpl(Inline)]
        public static BitString FromBitChars(ReadOnlySpan<char> src)
            => new BitString(src);         

        /// <summary>
        /// Constructs a bitstring from a clr string of 0's and 1's 
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static BitString Parse(string src)                
        {
            var len = src.Length;
            var lastix = len - 1;
            Span<byte> dst = new byte[len];
            for(var i=0; i<= lastix; i++)
                dst[lastix - i] = src[i] == '0' ? (byte)0 : (byte)1;
            return new BitString(dst);            
        }

        [MethodImpl(Inline)]
        static bool HasBitSpecifier(in string bs)
        {
            if(bs.Length < 2)
                return false;            
            return bs[0] == '0' && bs[1] == 'b';        
        }

        /// <summary>
        /// Constructs a bitstring from bitseq
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static BitString FromBitSeq(Span<byte> src)                
            => new BitString(src);

        /// <summary>
        /// Constructs a bitstring from bitseq
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static BitString FromBitSeq(ReadOnlySpan<byte> src)                
            => new BitString(src);

        /// <summary>
        /// Constructs a bitstring from bitspan
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static BitString FromBits(ReadOnlySpan<Bit> src)                
            => new BitString(src);

        /// <summary>
        /// Assembles a bistring given parts ordered from lo to hi
        /// </summary>
        /// <param name="parts">The source parts</param>
        [MethodImpl(Inline)]
        public static BitString Assemble(params string[] parts)
            => Parse(string.Join(string.Empty, parts.Reverse()));

    }
}