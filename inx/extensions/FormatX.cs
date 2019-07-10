//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static zfunc;    

    public static class ToHexStringX
    {
        public static string FormatHex<T>(this Span<T> src)
            where T : struct
        {
            var bs = string.Empty;
            var it = src.GetEnumerator();
            var len = src.Length;
            for(var i=len - 1; i>= 0; i--)
                bs += gmath.hexstring(src[i], specifier:false);
            return bs;
        }
     
       [MethodImpl(Inline)]
       public static string FormatHex<T>(this Vec128<T> src)
            where T : struct
                => src.Extract().FormatHex();

        [MethodImpl(Inline)]
        public static string ToBlockedHexString<T>(this Vec128<T> src, int? width = null, char? sep = null)
            where T : struct
                => src.FormatHex().SeparateBlocks(width ?? SizeOf<T>.Size*2, sep ?? AsciSym.Space );

        [MethodImpl(Inline)]
       public static string ToHexString<T>(this Vec256<T> src, bool blocked = false, int? bwidth = null, char? bsep = null)
            where T : struct
                => blocked ? src.ToHexString().SeparateBlocks(bwidth ?? 2, bsep ?? AsciSym.Space ) 
                    :  src.Extract().FormatHex();
    }
}