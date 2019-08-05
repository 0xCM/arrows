//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Diagnostics;

    using static zfunc;
    using static As;

    partial class xfunc
    {
        [MethodImpl(Inline)]
        public static void CopyTo<T>(this Span<T> src, Span<T> dst, int offset)
            => src.CopyTo(dst.Slice(offset));

        [MethodImpl(Inline)]
        public static void CopyTo<T>(this ReadOnlySpan<T> src, Span<T> dst, int offset)
            => src.CopyTo(dst.Slice(offset));

        [MethodImpl(Inline)]
        public static Span<T> Concat<T>(this ReadOnlySpan<T> head, ReadOnlySpan<T> tail)
        {
            Span<T> dst = new T[head.Length + tail.Length];
            head.CopyTo(dst);
            tail.CopyTo(dst, head.Length);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<T> Concat<T>(this Span<T> head, ReadOnlySpan<T> tail)
            => head.ReadOnly().Concat(tail);

        /// <summary>
        /// Constructs a readonly span from a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> ReadOnly<T>(this Span<T> src)
            => src;

        /// <summary>
        /// Constructs a span of a specified length from a sequence
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <param name="length">The length of the result span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> TakeSpan<T>(this IEnumerable<T> src, int length)
            => span(src.Take(length));

        /// <summary>
        /// Fills an allocated span from a sequence
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <param name="dst">The target spn</param>
        /// <typeparam name="T">The element type</typeparam>
        public static Span<T> FillSpan<T>(this IEnumerable<T> src, Span<T> dst)
        {
            var i = 0;
            var e = src.GetEnumerator();
            while(e.MoveNext() && i < dst.Length)
                dst[i++] = e.Current;
            return dst;
        }            

        public static T Reduce<T>(this ReadOnlySpan<T> src, Func<T,T,T> f)
        {
            if(src.IsEmpty)
                throw Errors.EmptySourceSpan();
            else if(src.Length == 1)
                return src[0];            
            
            var x = src[0];
            for(var i=1; i<src.Length; i++)
                x = f(x,src[i]);
            return x;            
        }

        public static T Reduce<M,N,T>(this Span<M,N,T> src, Func<T,T,T> f)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
                => Reduce(src.ReadOnly(), f);

        [MethodImpl(Inline)]
        public static T Reduce<T>(this Span<T> src, Func<T,T,T> f)
            => src.ReadOnly().Reduce(f);
            
        /// <summary>
        /// Clones the source span into a new span
        /// </summary>
        /// <param name="src">The span to replicate</param>
        /// <typeparam name="T">The element type</typeparam>
        /// <returns>Returns the replicated span</returns>
        [MethodImpl(Inline)]
        public static Span<T> Replicate<T>(this ReadOnlySpan<T> src)
        {
            var dst = span<T>(src.Length);
            src.CopyTo(dst);
            return dst;
        }

        /// <summary>
        /// Clones the source span into a new span
        /// </summary>
        /// <param name="src">The span to replicate</param>
        /// <typeparam name="T">The element type</typeparam>
        /// <returns>Returns the replicated span</returns>
        [MethodImpl(Inline)]
        public static Span<T> Replicate<T>(this Span<T> src)
            => src.ReadOnly().Replicate();

        /// <summary>
        /// Fills a span with a supplied valuie
        /// </summary>
        /// <param name="io">The span to manipulate</param>
        /// <typeparam name="T">The element type</typeparam>
        /// <returns>The manipulated span</returns>
        [MethodImpl(Inline)]
        public static Span<T> FillWith<T>(this Span<T> io, T value)
        {
            io.Fill(value);
            return io;
        }

        /// <summary>
        /// Overwrites span content with the default/zero value
        /// </summary>
        /// <param name="io">The span to manipulate</param>
        /// <typeparam name="T">The element type</typeparam>
        /// <returns>The manipulated span</returns>
        [MethodImpl(Inline)]
        public static Span<T> ZeroFill<T>(this Span<T> io)
            where T : struct
        {
            io.Fill(default(T));
            return io;
        }
        
        /// <summary>
        /// Creates a dictionary from a span using the element indices as keys
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        public static IDictionary<int,T> ToDictionary<T>(this ReadOnlySpan<T> src)
        {
            var dst = new Dictionary<int,T>(src.Length);
            for(var i = 0; i< src.Length; i++)
                dst[i] = src[i];
            return dst;
        }

        [MethodImpl(Inline)]
        public static ReadOnlySpanPair<T> PairWith<T>(this ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)        
            => new ReadOnlySpanPair<T>(lhs,rhs);
    
        /// <summary>
        /// Clones a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> Replicate<T>(this Span256<T> src, bool structureOnly = false)
            where T : struct
        {
            var dst = span<T>(src.Length);
            if(!structureOnly)
                src.CopyTo(dst);
            return Z0.Span256.load<T>(dst);
        }

        /// <summary>
        /// Clones a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> Replicate<T>(this ReadOnlySpan256<T> src)
            where T : struct
        {
            var dst = span<T>(src.Length);
            src.CopyTo(dst);
            return Z0.Span256.load<T>(dst);
        }


        [MethodImpl(Inline)]
        public static Span<char> Replicate(this char src, int count)
        {
            Span<char> dst = new char[count];
            dst.Fill(src);
            return dst;
        }

        /// <summary>
        /// Creates a new span by interposing a specified element between each element of an existing span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="x">The value to place between each element in the new span</param>
        /// <typeparam name="T">The element type</typeparam>
        public static Span<T> Intersperse<T>(this ReadOnlySpan<T> src, T x)
        {
            var dst = span<T>(src.Length*2 - 1);
            for(int i=0, j=0; i<src.Length; i++, j+= 2)
            {
                dst[j] = src[i];                
                if(i != src.Length - 1)
                    dst[j + 1] = x;                    
            }
            return dst;
        }

        /// <summary>
        /// Creates a new span by interposing a specified element between each element of an existing span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="x">The value to place between each element in the new span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]        
        public static Span<T> Intersperse<T>(this Span<T> src, T x)
            => src.ReadOnly().Intersperse(x);


        /// <summary>
        /// Populates a span of natural length from an unsized span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="size">The target size</param>
        /// <typeparam name="N">The target type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]        
        public static Span<N,T> ToNatSpan<N,T>(this Span<T> src, N size = default)
            where N : ITypeNat, new()
                => new Span<N, T>(src);       
  
        [MethodImpl(Inline)]
        public static Span<T> Reverse<T>(this ReadOnlySpan<T> src)        
        {
            var dst = span<T>(src.Length);
            var lastix = dst.Length - 1;
            for(var i=0; i<dst.Length; i++)
                dst[lastix - i] = src[i];
            return dst;
        }              

        [MethodImpl(Inline)]
        public static Span<T> Reverse<T>(this Span<T> src)        
            => src.ReadOnly().Reverse();
            
 
        [MethodImpl(Inline)]
        public static Span<byte> ToBytes<T>(this T src)
            where T : struct
        {
            Span<T> s = new T[1]{src};
            return MemoryMarshal.AsBytes(s);
        }        

        [MethodImpl(Inline)]
        public static T FromBytes<T>(this Span<byte> src)
            where T : struct
        {
            if(MemoryMarshal.TryRead(src, out T value))
                return value;
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// If the length of a source span is less than a specified length, a new span of the desired length
        /// is allocated and then filled with the source span content; otherwise, the source span is returned
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="minlen">The desired minimum length</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Extend<T>(this Span<T> src, int minlen)
        {
            if(src.Length >= minlen)
                return src;
            else
            {
                Span<T> dst = new T[minlen];
                src.CopyTo(dst); 
                return dst;               
            }
        }
        
        [MethodImpl(Inline)]
        public static Span<T> ExtendSlice<T>(this Span<T> src, int offset, int slicelen)
        {
            var available = src.Length - offset;            
            if(available <= slicelen)
                return src.Slice(offset,slicelen);
            else
            {
                Span<T> dst = new T[slicelen];
                if(available <= 0)
                    return dst;

                src.Slice(offset).CopyTo(dst);
                    return dst;
            }                        
        }
    }
}