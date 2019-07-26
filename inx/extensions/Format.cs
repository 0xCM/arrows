//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static zfunc;    

    partial class ginxs
    {

       [MethodImpl(Inline)]
       public static string FormatHex<T>(this ReadOnlySpan<T> src, bool vectorize = false, char? sep = null)
            where T : struct
        {
            var delimiter = sep ?? (vectorize ? AsciSym.Comma : AsciSym.Space);
            var fmt = sbuild();
            if(vectorize)
                fmt.Append(AsciSym.Lt);
            for(var i = 0; i<src.Length; i++)
            {
                fmt.Append(gmath.hexstring(src[i], true, false));
                if(i != src.Length - 1)
                    fmt.Append((char)delimiter);
            }
            
            if(vectorize)
                fmt.Append(AsciSym.Gt);
            return fmt.ToString();

        }

       [MethodImpl(Inline)]
       public static string FormatHex<T>(this Span<T> src, bool vectorize = false, char? sep = null)
            where T : struct
                => src.ReadOnly().FormatHex(vectorize, sep);

       [MethodImpl(Inline)]
       public static string FormatHex<N,T>(this Span<N,T> src, bool vectorize = false, char? sep = null)
            where N : ITypeNat, new()
            where T : struct
                => src.Unsize().FormatHex(vectorize, sep);

       [MethodImpl(Inline)]
       public static string FormatHex<N,T>(this ReadOnlySpan<N,T> src, bool vectorize = false, char? sep = null)
            where N : ITypeNat, new()
            where T : struct
                => src.Unsize().FormatHex(vectorize, sep);

       [MethodImpl(Inline)]
       public static string FormatHexBlocks<T>(this ReadOnlySpan<T> src,  int? width = null, char? sep = null)
            where T : struct
                => src.FormatHex().SeparateBlocks(width ?? Unsafe.SizeOf<T>(), sep ?? AsciSym.Space);

       [MethodImpl(Inline)]
       public static string FormatHexBlocks<T>(this Span<T> src, int? width = null, char? sep = null)
            where T : struct
                => src.ReadOnly().FormatHexBlocks(width, sep);

       [MethodImpl(Inline)]
       public static string FormatHexBlocks<N,T>(this Span<N,T> src, int? width = null, char? sep = null)
            where N : ITypeNat, new()
            where T : struct
                => src.Unsize().FormatHexBlocks(width,sep);

       [MethodImpl(Inline)]
       public static string FormatHexBlocks<N,T>(this ReadOnlySpan<N,T> src, int? width = null, char? sep = null)
            where N : ITypeNat, new()
            where T : struct
                => src.Unsize().FormatHexBlocks(width,sep);

       [MethodImpl(Inline)]
       public static string FormatHex<T>(this Vec128<T> src, bool vectorize = true, char? sep = null)
            where T : struct
                => src.ToSpan().FormatHex(vectorize,sep);

       [MethodImpl(Inline)]
       public static string FormatHex<T>(this Vec256<T> src, bool vectorize = true, char? sep = null)
            where T : struct
                => src.ToSpan().FormatHex(vectorize,sep);
 
    }
}