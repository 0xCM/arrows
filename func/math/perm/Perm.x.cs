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
    using System.Text;

    using static zfunc;    

    public static class PermX
    {
        /// <summary>
        /// Formats a permutation as a 2-column matrix
        /// </summary>
        /// <param name="src">The source permutation</param>
        /// <param name="colwidth">The width of the matrix columns, if specified</param>
        public static string Format<N,T>(this Perm<N,T> src,  int? colwidth = null)        
            where T : struct
            where N : ITypeNat,new()
                => Format<T>(src.Terms,colwidth);

        /// <summary>
        /// Formats a permutation as a 2-column matrix
        /// </summary>
        /// <param name="src">The source permutation</param>
        /// <param name="colwidth">The width of the matrix columns, if specified</param>
        [MethodImpl(Inline)]
        public static string Format(this Perm src,  int? colwidth = null)        
                => Format(src.Terms,colwidth);

        /// <summary>
        /// Shuffles bitstring content as determined by a permutation
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="p">The permutation to apply</param>
        public static BitString Permute(this BitString src, Perm p)
        {
            var dst = BitString.Alloc(p.Length);
            for(var i = 0; i < p.Length; i++)
                dst[i] = src[p[i]];
            return dst;
        }

        /// <summary>
        /// Shuffles span content as determined by a permutation
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="p">The permutation to apply</param>
        public static Span<T> Permute<T>(this ReadOnlySpan<T> src, Perm p)
        {
            Span<T> dst = new T[src.Length];
            for(var i=0; i<p.Length; i++)
                dst[i] = src[p[i]];                
            return dst;
        }

        /// <summary>
        /// Shuffles span content as determined by a permutation
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="p">The permutation to apply</param>
        [MethodImpl(Inline)]
        public static Span<T> Permute<T>(this Span<T> src, Perm p)
            => src.ReadOnly().Permute(p);

        static string Format<T>(ReadOnlySpan<T> Terms,  int? colwidth = null)
        {
            var line1 = sbuild();
            var line2 = sbuild();
            var pad = colwidth ?? 3;
            var leftBoundary = $"{AsciSym.Pipe}".PadRight(2);
            var rightBoundary = $"{AsciSym.Pipe}";
            
            line1.Append(leftBoundary);
            line2.Append(leftBoundary);
            for(var i=0; i < Terms.Length; i++)
            {
                line1.Append($"{i}".PadRight(pad));
                line2.Append($"{Terms[i]}".PadRight(pad));
            }
            line1.Append(rightBoundary);
            line2.Append(rightBoundary);
            
            return line1.ToString() + eol() + line2.ToString();
        }

    }


}