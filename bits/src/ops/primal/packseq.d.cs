//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using Z0;
 
    using static zfunc;
    using static Constants;
    
    partial class Bits
    {         
        /// <summary>
        /// Packs a bitsequence determined by the first 8 (or fewer) bytes from the source into a single byte
        /// </summary>
        /// <param name="src">The source sequence</param>
        public static ref byte packseq(ReadOnlySpan<byte> src, out byte dst)
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
        public static ref ushort packseq(ReadOnlySpan<byte> src, out ushort dst)
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
        public static ref uint packseq(ReadOnlySpan<byte> src, out uint dst)
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
        public static ref ulong packseq(ReadOnlySpan<byte> src, out ulong dst)
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