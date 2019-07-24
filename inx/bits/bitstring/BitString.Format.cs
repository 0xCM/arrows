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
    using System.IO;
    
    using static zfunc;
    using static As;

    partial struct BitString
    {
        /// <summary>
        /// Formats bitstring content
        /// </summary>
        /// <param name="tlz">Indicates whether leading zero bits should be eliminated from the result</param>
        /// <param name="specifier">True if the canonical 0b specifier is to precede bitstring content, false if to omit the speicifier</param>
        /// <param name="blockWidth">If unspecified, no blocking will be applied; otherwise, indicates the width of the block partitions</param>
        /// <param name="blocksep">If unspecified, when block formatting, indicates the default block delimiter (An ASCII space) will be used;
        /// if specified, when block formatting, indicates the block delimiter to place between the block partitions</param>
        public string Format(bool tlz = false, bool specifier = false, int? blockWidth = null, char? blocksep = null)
        {                                            
            if(blockWidth == null)
                return FormatUnblocked(tlz,specifier);
            else
            {
                var sep = blocksep ?? ' ';
                var sb = sbuild();
                var blocks = Blocks(blockWidth.Value).Reverse();
                var lastix = blocks.Length - 1;
                for(var i=0; i<=lastix; i++)
                {
                    sb.Append(blocks[i].FormatUnblocked(false,false));
                    if(i != lastix)
                        sb.Append(sep);
                }
                var x = sb.ToString();
                return  
                    (specifier ? "0b" : string.Empty) 
                +   (tlz ? x.TrimStart('0') : x);
            }            
        }

        [MethodImpl(Inline)]
        public string Format()
            => Format(false, false, null, null);

        string FormatUnblocked(bool tlz, bool specifier)
        {
            Span<char> dst = stackalloc char[bitseq.Length];
            var lastix = dst.Length - 1;
            for(var i=0; i< dst.Length; i++)
                dst[lastix - i] = bitseq[i] == 0 ? '0' : '1';
            
            var x = new string(dst);
            return  
                (specifier ? "0b" : string.Empty) 
              + (tlz ? x.TrimStart('0') : x);
        }

    }

}