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

        /// <summary>
        /// Formats the terms of a permutation
        /// </summary>
        /// <param name="terms">The permutation terms</param>
        /// <param name="colwidth">The width of each column</param>
        /// <typeparam name="T">The term type</typeparam>
        internal static string FormatPerm<T>(this ReadOnlySpan<T> terms,  int? colwidth = null)
        {
            var line1 = sbuild();
            var line2 = sbuild();
            var pad = colwidth ?? 3;
            var leftBoundary = $"{AsciSym.Pipe}".PadRight(2);
            var rightBoundary = $"{AsciSym.Pipe}";
            
            line1.Append(leftBoundary);
            line2.Append(leftBoundary);
            for(var i=0; i < terms.Length; i++)
            {
                line1.Append($"{i}".PadRight(pad));
                line2.Append($"{terms[i]}".PadRight(pad));
            }
            line1.Append(rightBoundary);
            line2.Append(rightBoundary);
            
            return line1.ToString() + eol() + line2.ToString();
        }

        /// <summary>
        /// Formats the terms of a permutation
        /// </summary>
        /// <param name="terms">The permutation terms</param>
        /// <param name="colwidth">The width of each column</param>
        /// <typeparam name="T">The term type</typeparam>
        internal static string FormatPerm<T>(this Span<T> terms,  int? colwidth = null)
            => terms.ReadOnly().FormatPerm(colwidth);

        /// <summary>
        /// Applies a sequence of transpositions to source span elements
        /// </summary>
        /// <param name="io">The source and target span</param>
        /// <param name="i">The first index</param>
        /// <param name="j">The second index</param>
        /// <typeparam name="T">The element type</typeparam>
        public static Span<T> Swap<T>(this Span<T> io, params Swap[] swaps)           
            where T : struct
        {
            for(var k = 0; k< swaps.Length; k++)
            {
                (var i, var j) = swaps[k];
                swap(ref io[i], ref io[j]);
            }
            return io;
        }

        /// <summary>
        /// Applies a sequence of transpositions to source span elements
        /// </summary>
        /// <param name="src">The source and target span</param>
        /// <param name="i">The first index</param>
        /// <param name="j">The second index</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> Swap<T>(this Span256<T> src, params Swap[] swaps)           
            where T : struct
        {
             if(swaps.Length == 0)
                return src;

             src.Unblocked.Swap(swaps);
             return src;
        }
                
        /// <summary>
        /// Applies a sequence of transpositions to source span elements
        /// </summary>
        /// <param name="src">The source and target span</param>
        /// <param name="i">The first index</param>
        /// <param name="j">The second index</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span128<T> Swap<T>(this Span128<T> src, params Swap[] swaps)           
            where T : struct
        {
             if(swaps.Length == 0)
                return src;
                
             src.Unblocked.Swap(swaps);
             return src;
        }        

        /// <summary>
        /// Effects (i j) -> ((i + 1) (j+ 1))
        /// </summary>
        [MethodImpl(Inline)]
        public static ref Swap Inc(this ref Swap src)
        {
            ++src;
            return ref src;
        }

        /// <summary>
        /// Effects (i j) -> ((i - 1) (j - 1)) where decremented indices are clamped to 0 
        /// </summary>
        [MethodImpl(Inline)]
        public static ref Swap Dec(this ref Swap src)
        {
            --src;
            return ref src;
        }

        public static Swap[] Unsized<N>(this Swap<N>[] src)
            where N : ITypeNat, new()
        {
            var dst = new Swap[src.Length];
            for(var i=0; i<src.Length; i++)
                dst[i] = src[i];
            return dst;
        }

        /// <summary>
        /// Formats a sequence of successive transpositions (a chain)
        /// </summary>
        /// <param name="src">The transpositions</param>
        [MethodImpl(Inline)]
        public static string Format(this Swap[] src)
            => string.Join(" -> ", src.Map(x => x.Format()));

        /// <summary>
        /// Usefully formats the permutation spec
        /// </summary>
        /// <param name="src">The permutation spec</param>
        [MethodImpl(Inline)]
        public static string Format(this Perm4 src)
            => $"{src} = {((byte)src).ToBitString()} = {((byte)src).FormatHex()}"; 
 
        [MethodImpl(Inline)]
        public static bool Includes(this Perm16 src, int index)
            => (((int)src & (4 << index)) != 0);

        [MethodImpl(Inline)]
        public static PermCycle Cycle(this Perm16 src)
        {            
            Span<PermTerm> terms = stackalloc PermTerm[16];
            var counter = 0;
            for(var i=0; i<16; i++)   
            {
                if(src.Includes(i))
                    terms[counter] = new PermTerm(counter,i);
                counter++;
            }
            return new PermCycle(terms.Slice(0, counter));

        }

        /// <summary>
        /// Maps a permutation on 8 symbols to its canonical scalar representation
        /// </summary>
        /// <param name="src">The source permutation</param>
        public static Perm8 ToScalar(this Perm<N8> src)
        {
            var dst = 0u;            
            for(int i=0, offset = 0; i< src.Length; i++, offset +=3)
                dst |= (uint)src[i] << offset;                        
            return (Perm8)dst;
        }

        /// <summary>
        /// Reifies a permutation of length 8 from its canonical scalar representative 
        /// </summary>
        /// <param name="rep">The representative</param>
        public static Perm<N8> ToPerm(this Perm8 rep)
        {
            uint data = (uint)rep;
            var dst = Perm<N8>.Alloc();
            for(int i=0, offset = 0; i<dst.Length; i++, offset +=3)
                dst[i] = (int)BitMask.between(in data, offset, offset + 2);
            return dst;
        }
 
        /// <summary>
        /// Maps a permutation on 16 symbols to its canonical scalar representation
        /// </summary>
        /// <param name="src">The source permutation</param>
        public static Perm16 ToEnum(this Perm<N16> src)
        {
            var dst = 0ul;            
            for(int i=0, offset = 0; i< src.Length; i++, offset +=3)
                dst |= (ulong)src[i] << offset;                        
            return (Perm16)dst;
        }

        /// <summary>
        /// Reifies a permutation of length 16 from its canonical scalar representative 
        /// </summary>
        /// <param name="rep">The representative</param>
        public static Perm<N16> ToPerm(this Perm16 rep)
        {
            uint data = (uint)rep;
            var dst = Perm<N16>.Alloc();
            for(int i=0, offset = 0; i<dst.Length; i++, offset +=4)
                dst[i] = (int)BitMask.between(in data, offset, offset + 3);
            return dst;
        }

        /// <summary>
        /// Returns the source enum's underlying scalar value
        /// </summary>
        /// <param name="src">The source enum value</param>
        [MethodImpl]
        public static ulong ToScalar(this Perm16 src)
            => (ulong)src;
        

    }
}