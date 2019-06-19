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

        static string ToBitString<T>(this Span<T> src, bool tlz = false)
            where T : struct
        {
            var bs = string.Empty;
            var it = src.GetEnumerator();
            var len = src.Length;
            for(var i=len - 1; i>= 0; i--)
                bs += BitStringConvert.FromValue(src[i],tlz).ToString();
            return bs;
        }

       public static string ToHexString<T>(this Vec128<T> src)
            where T : struct
                => src.ToSpan().Unblock().ToHexString();

       public static string ToBitString<T>(this Vec128<T> src, bool tlz = false)
            where T : struct
                => src.ToSpan().Unblock().ToBitString(tlz);

       public static string ToBitString<T>(this Vec256<T> src, bool tlz = false)
            where T : struct
                => src.ToSpan().Unblock().ToBitString(tlz);

        public static string ToBlockedBitString<T>(this Vec128<T> src, int? width = null, string sep = null)
            where T : struct
                => src.ToBitString(false).SeparateBlocks(width ?? SizeOf<T>.Size, sep ?? BlockSep );

        public static string ToBlockedBitString<T>(this Vec256<T> src, string sep = null, bool tlz = false)
            where T : struct
        {
            var len = src.Length();
            var dst = span<T>(len);
            src.StoreTo(dst);            
            var sb = sbuild();
            var start = len - 1;
            for(var i = start; i>= 0; i--)
            {
                if(i != start)
                    sb.Append(BlockSep);
                sb.Append(BitStringConvert.FromValue(src[i],tlz).ToString());                
            }
            return sb.ToString();
        }

        public static string ToBlockedBitString<T>(this m256i src, string sep = null, bool tlz = false)
            where T : struct
                => src.ToVec256<T>().ToBlockedBitString(sep, tlz);

        public static string ToBlockedHexString<T>(this Vec128<T> src, int? width = null, string sep = null)
            where T : struct
                => src.ToHexString().SeparateBlocks(width ?? SizeOf<T>.Size*2, sep ?? BlockSep );

       public static string ToHexString<T>(this Vec256<T> src)
            where T : struct
                => src.ToSpan().Unblock().ToHexString();

        public static string ToBlockedHexString<T>(this Vec256<T> src, int? width = null, string sep = null)
            where T : struct
                => src.ToHexString().SeparateBlocks(width ?? 2, sep ?? BlockSep );
    }

}