//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static zfunc;    

    partial class InXtend
    {

       [MethodImpl(Inline)]
       public static string FormatHex<T>(this ReadOnlySpan<T> src, bool vectorize = false)
            where T : struct
        {
            var fmt = sbuild();
            var it = src.GetEnumerator();
            var len = src.Length;
            var lastix = len - 1;
            if(!vectorize)
            {
                for(var i=lastix; i>= 0; i--)
                    fmt.Append(gmath.hexstring(src[i], specifier:false));
            }
            else
            {
                fmt.Append(AsciSym.Lt);
                for(var i=lastix; i>= 0; i--)
                {
                    fmt.Append(gmath.hexstring(src[i]));
                    if(i!= lastix)
                        fmt.Append($", ");                
                }
                fmt.Append(AsciSym.Gt);
            }
            return fmt.ToString();
        }

       [MethodImpl(Inline)]
       public static string FormatHex<T>(this Span<T> src, bool vectorize = false)
            where T : struct
                => src.ReadOnly().FormatHex(vectorize);

       [MethodImpl(Inline)]
       public static string FormatHex<N,T>(this Span<N,T> src, bool vectorize = false)
            where N : ITypeNat, new()
            where T : struct
                => src.Unsize().FormatHex(vectorize);

       [MethodImpl(Inline)]
       public static string FormatHex<N,T>(this ReadOnlySpan<N,T> src, bool vectorize = false)
            where N : ITypeNat, new()
            where T : struct
                => src.Unsize().FormatHex(vectorize);

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
       public static string FormatHex<T>(this Vec128<T> src)
            where T : struct
                => src.Extract().FormatHex(true);

       [MethodImpl(Inline)]
       public static string FormatHex<T>(this Vec256<T> src)
            where T : struct
                => src.Extract().FormatHex(true);

 
    }
}