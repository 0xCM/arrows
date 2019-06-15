//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    

    public static class ToBitStringX
    {
        const string BlockSep = " | ";

        static string ToHexString<T>(this Span<T> src)
            where T : struct
        {
            var bs = string.Empty;
            var it = src.GetEnumerator();
            var len = src.Length;
            for(var i=len - 1; i>= 0; i--)
                bs += gmath.hexstring(src[i], specifier:false);
            return bs;
        }

        static string ToBitString<T>(this Span<T> src)
            where T : struct
        {
            var bs = string.Empty;
            var it = src.GetEnumerator();
            var len = src.Length;
            for(var i=len - 1; i>= 0; i--)
                bs += gbits.bitstring(src[i]);
            return bs;

        }

       public static string ToHexString<T>(this Vec128<T> src)
            where T : struct
                => src.ToSpan().Unblock().ToHexString();

       public static string ToBitString<T>(this Vec128<T> src)
            where T : struct
                => src.ToSpan().Unblock().ToBitString();
 
        public static string ToBlockedBitString<T>(this Vec128<T> src, int? width = null, string sep = null)
            where T : struct
                => src.ToBitString().SeparateBlocks(width ?? SizeOf<T>.Size, sep ?? BlockSep );

        public static string ToBlockedHexString<T>(this Vec128<T> src, int? width = null, string sep = null)
            where T : struct
                => src.ToHexString().SeparateBlocks(width ?? SizeOf<T>.Size*2, sep ?? BlockSep );

       public static string ToBitString<T>(this Vec256<T> src)
            where T : struct
                => src.ToSpan().Unblock().ToBitString();

       public static string ToHexString<T>(this Vec256<T> src)
            where T : struct
                => src.ToSpan().Unblock().ToHexString();

        public static string ToBlockedBitString<T>(this Vec256<T> src, int? width = null, string sep = null)
            where T : struct
                => src.ToBitString().SeparateBlocks(width ?? 8, sep ?? BlockSep );

        public static string ToBlockedHexString<T>(this Vec256<T> src, int? width = null, string sep = null)
            where T : struct
                => src.ToHexString().SeparateBlocks(width ?? 2, sep ?? BlockSep );

    }

}