//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;
    using static As;
    using static AsIn;

    partial class gbits
    {        
        /// <summary>
        /// Constructs a bytespan where each entry, ordered from lo to hi, represents a single bit in the source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The primal source type</typeparam>
        [MethodImpl(Inline), PrimalKinds(PrimalKind.UnsignedInt)]
        public static ReadOnlySpan<byte> bitseq<T>(T src)
            where T : struct
                => BitStore.BitSeq(src);

        [MethodImpl(Inline), PrimalKinds(PrimalKind.UnsignedInt)]
        public static ref T packseq<T>(ReadOnlySpan<byte> src, out T dst)
            where T : struct
        {
            if(typeof(T) == typeof(byte) || typeof(T) == typeof(sbyte))
                dst = generic<T>(ref packseq(src, out byte _));
            else if(typeof(T) == typeof(ushort) || typeof(T) == typeof(short))
                dst = generic<T>(ref packseq(src, out ushort _));
            else if(typeof(T) == typeof(uint) || typeof(T) == typeof(int))
                dst = generic<T>(ref packseq(src, out uint _));
            else if(typeof(T) == typeof(ulong) || typeof(T) == typeof(long))
                dst = generic<T>(ref packseq(src, out ulong _));
            else            
                throw unsupported<T>();            
            return ref dst;
        }        

        /// <summary>
        /// Constructs the bitstring text for an integral value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), PrimalKinds(PrimalKind.UnsignedInt)]
        public static string bstext<T>(in T src)
        {
            if(typeof(T) == typeof(byte))
                return Bits.bstext(uint8(in src));
            else if(typeof(T) == typeof(sbyte))
                return Bits.bstext(int8(in src));
            else if(typeof(T) == typeof(ushort))
                return Bits.bstext(uint16(in src));
            else if(typeof(T) == typeof(short))
                return Bits.bstext(int16(in src));
            else if(typeof(T) == typeof(uint))
                return Bits.bstext(uint32(in src));
            else if(typeof(T) == typeof(int))
                return Bits.bstext(int32(in src));
            else if(typeof(T) == typeof(ulong))
                return Bits.bstext(uint64(in src));
            else if(typeof(T) == typeof(long))
                return Bits.bstext(int64(in src));
            else            
                throw unsupported<T>();            
        }

        /// <summary>
        /// Packs a bitsequence determined by the first 8 (or fewer) bytes from the source into a single byte
        /// </summary>
        /// <param name="src">The source sequence</param>
        static ref byte packseq(ReadOnlySpan<byte> src, out byte dst)
        {
            dst = 0;
            var count = Math.Min(8, src.Length);
            for(var i=0; i< count; i++)
                if(src[i] == 1)
                    dst |= (byte)(1 << i);
            return ref dst;
        }

        /// <summary>
        /// Packs a bitsequence determined by the first 16 (or fewer) bytes from the source into an unsigned short
        /// </summary>
        /// <param name="src">The source sequence</param>
        static ref ushort packseq(ReadOnlySpan<byte> src, out ushort dst)
        {
            dst = 0;
            var count = Math.Min(16, src.Length);
            for(var i=0; i< count; i++)
                if(src[i] == 1)
                    dst |= (ushort)(1 << i);
            return ref dst;
        }

        /// <summary>
        /// Packs a bitsequence determined by the first 32 (or fewer) bytes from the source into an unsigned int
        /// </summary>
        /// <param name="src">The source sequence</param>
        static ref uint packseq(ReadOnlySpan<byte> src, out uint dst)
        {
            dst = 0u;
            var count = Math.Min(32, src.Length);
            for(var i=0; i< count; i++)
                if(src[i] == 1)
                    dst |= (1u << i);
            return ref dst;
        }

        /// <summary>
        /// Packs a bitsequence determined by the first 64 (or fewer) bytes from the source into an unsigned long
        /// </summary>
        /// <param name="src">The source sequence</param>
        static ref ulong packseq(ReadOnlySpan<byte> src, out ulong dst)
        {
            dst = 0ul;
            var count = Math.Min(64, src.Length);
            for(var i=0; i< count; i++)
                if(src[i] == 1)
                    dst |= (1ul << i);
            return ref dst;
        }
    }
}