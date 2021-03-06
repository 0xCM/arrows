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

    partial struct BitString
    {
        /// <summary>
        /// Allocates a bitstring with a specified length
        /// </summary>
        /// <param name="len">The length of the bitstring</param>
        [MethodImpl(Inline)]
        public static BitString Alloc(int len)
            => new BitString(new byte[len]);

        /// <summary>
        /// Constructs a bitstring from a clr string of 0's and 1's 
        /// </summary>
        /// <param name="src">The bit source</param>
        public static BitString Parse(string src)                
        {
            src = src.RemoveWhitespace();
            var len = src.Length;
            var lastix = len - 1;
            Span<byte> dst = new byte[len];
            for(var i=0; i<= lastix; i++)
                dst[lastix - i] = src[i] == Bit.Zero ? (byte)0 : (byte)1;
            return new BitString(dst);                        
        }

        /// <summary>
        /// Constructs a bitstring from a pattern replicated a specified number of times
        /// </summary>
        /// <param name="src">The source pattern</param>
        /// <param name="reps">The number of times to repeat the pattern</param>
        /// <typeparam name="T">The primal source type</typeparam>
        public static BitString FromPattern<T>(T src, int reps)                
            where T : struct
        {
            BitSize capacity = Unsafe.SizeOf<T>() * 8;
            Span<byte> bitseq = new byte[capacity*reps];            
            var pattern = FromScalar(src);
            for(var i=0; i<reps; i++)
                pattern.BitSeq.CopyTo(bitseq, i*capacity);
            return FromBitSeq(bitseq);            
        }

        /// <summary>
        /// Constructs a bitstring from primal value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline)]
        public static BitString FromScalar<T>(in T src)
            where T : struct
                => new BitString(BitStore.BitSeq(in src));

        /// <summary>
        /// Constructs a bitstring from span of scalar values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitString FromScalars<T>(Span<T> src, BitSize? maxlen = null)
            where T : struct
        {
            var segbits = bitsize<T>();
            var bitcount = maxlen ?? segbits*src.Length;
            var k = 0;
            var bitseq = new byte[bitcount];
            for(int i=0; i<src.Length; i++)
            {
                var bits = BitStore.BitSeq(in src[i]);
                for(var j = 0; j<segbits && k<bitcount; j++, k++)
                    bitseq[k] = bits[j];                        
            }
            return new BitString(bitseq);
        }

        /// <summary>
        /// Assembles a bitstring from primal parts ordered from lo to hi
        /// </summary>
        /// <param name="parts">The primal values that define bitstring segments</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitString FromScalars<T>(params T[] parts)
            where T : struct
                => FromScalars(parts.AsSpan());

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
        /// Constructs a bitstring from bitseq parameter array
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static BitString FromBitSeq(params byte[] src)                
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
        /// Constructs a bitstring from a parameter array of bits, ordered hi -> lo
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static BitString FromHiToLo(params Bit[] src)                
            => new BitString(src.Reverse());

        /// <summary>
        /// Constructs a bitstring bitstream
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static BitString FromBits(IEnumerable<Bit> src)                
            => new BitString(src.ToArray());

        /// <summary>
        /// Assembles a bistring given parts ordered from lo to hi
        /// </summary>
        /// <param name="parts">The source parts</param>
        [MethodImpl(Inline)]
        public static BitString Assemble(params string[] parts)
            => Parse(string.Join(string.Empty, parts.Reverse()));
    }
}