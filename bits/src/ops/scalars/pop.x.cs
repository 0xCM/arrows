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
    using System.Runtime.InteropServices;    
    
    using static zfunc;

    partial class BitsX
    {
        public static ulong PopCount(this ReadOnlySpan<Bit> src)
        {
            var count = 0ul;
            for(var i=0; i<src.Length; i++)
                if(src[i]) 
                    count++;
            return count;
        }

        [MethodImpl(Inline)]        
        public static ulong PopCount(this Span<Bit> src)
            => src.ReadOnly().PopCount();

               
        [MethodImpl(Inline)]   
        public static ulong PopCount(this Span<byte> src)
            => bitspan.pop(src);
    }

}