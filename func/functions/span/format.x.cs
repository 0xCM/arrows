//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Diagnostics;

    using static zfunc;
    using static As;

    partial class xfunc
    {

        /// <summary>
        /// Formats a span as a delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="delimiter">The delimiter</param>
        /// <param name="offset">The position at which formatting should begin</param>
        /// <typeparam name="T">The element type</typeparam>
        public static string Format<T>(this ReadOnlySpan<T> src, char delimiter = ',', int offset = 0)
        {
            var sb = new StringBuilder();            
            for(var i = offset; i< src.Length; i++)
            {
                if(i != offset)
                    sb.Append(delimiter);
                sb.Append($"{src[i]}");
            }
            return sb.ToString();
        }

        /// <summary>
        /// Formats a span as a delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="delimiter">The delimiter</param>
        /// <param name="offset">The position at which formatting should begin</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]        
        public static string Format<T>(this Span<T> src, char delimiter = ',', int offset = 0)
            => src.ReadOnly().Format(delimiter, offset);

        /// <summary>
        /// Formats a span as a delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="delimiter">The delimiter</param>
        /// <param name="offset">The position at which formatting should begin</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]        
        public static string Format<T>(this ReadOnlySpan128<T> src, char delimiter = ',', int offset = 0)
            where T : struct
            => src.Unblock().Format(delimiter, offset);

        /// <summary>
        /// Formats a blocked span as a delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="delimiter">The delimiter</param>
        /// <param name="offset">The position at which formatting should begin</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]        
        public static string Format<T>(this Span128<T> src, char delimiter = ',', int offset = 0)
            where T : struct
            => src.Unblock().Format(delimiter, offset);

        /// <summary>
        /// Formats a blocked span as a delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="delimiter">The delimiter</param>
        /// <param name="offset">The position at which formatting should begin</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]        
        public static string Format<T>(this ReadOnlySpan256<T> src, char delimiter = ',', int offset = 0)
            where T : struct
            => src.UnBlock().Format(delimiter, offset);

        /// <summary>
        /// Formats a blocked span as a delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="delimiter">The delimiter</param>
        /// <param name="offset">The position at which formatting should begin</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]        
        public static string Format<T>(this Span256<T> src, char delimiter = ',', int offset = 0)
            where T : struct
            => src.Unblock().Format(delimiter, offset);

        /// <summary>
        /// Formats a span of natural length as a delimited list
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="delimiter">The delimiter</param>
        /// <param name="offset">The position at which formatting should begin</param>
        /// <typeparam name="T">The element type</typeparam>
        /// <typeparam name="N">The length type</typeparam>
        [MethodImpl(Inline)]        
        public static string Format<N,T>(this Span<N,T> src, char delimiter = ',', int offset = 0)
            where N : ITypeNat, new()
                => src.Unsize().Format(delimiter,offset);

        /// <summary>
        /// Formats a readonly span as a vector
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="sep">The item separator</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatAsVector<T>(this ReadOnlySpan<T> src, string sep = ",")
        {
            var components = src.Map(x => x.ToString());
            var body = concat(components, sep);
            return AsciSym.Lt + body + AsciSym.Gt;
        }
            
        /// <summary>
        /// Formats a span as a vector
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="sep">The item separator</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatAsVector<T>(this Span<T> src, string sep = ",")
            => src.ReadOnly().FormatAsVector(sep);



    }
}