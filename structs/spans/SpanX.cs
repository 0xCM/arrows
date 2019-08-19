//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;
    using System.Linq;

    using static zfunc;
    using static nfunc;

    public static class SpanExtensions
    {
        /// <summary>
        /// Presents selected span content as a readonly span of bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The source offset</param>
        /// <param name="length">The source length</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> AsBytes<T>(this ReadOnlySpan<T> src, int offset = 0, int ? length = null)
            where T : struct
            =>   (offset == 0 && length == null) 
                ? MemoryMarshal.AsBytes(src)
                : length == null  
                ? MemoryMarshal.AsBytes(src.Slice(offset)) 
                : MemoryMarshal.AsBytes(src.Slice(offset, length.Value));

        /// <summary>
        /// Presents selected span content as a span of bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The source offset</param>
        /// <param name="length">The source length</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<byte> AsBytes<T>(this Span<T> src, int offset = 0, int ? length = null)
            where T : struct
            =>   (offset == 0 && length == null) 
                ? MemoryMarshal.AsBytes(src)
                : length == null  
                ? MemoryMarshal.AsBytes(src.Slice(offset)) 
                : MemoryMarshal.AsBytes(src.Slice(offset, length.Value));


        [MethodImpl(Inline)]
        public static void CopyTo<T>(this Span<T> src, Span<T> dst, int offset)
            => src.CopyTo(dst.Slice(offset));

        [MethodImpl(Inline)]
        public static void CopyTo<T>(this ReadOnlySpan<T> src, Span<T> dst, int offset)
            => src.CopyTo(dst.Slice(offset));

        /// <summary>
        /// Forms a new span by the concatenation [head,tail]
        /// </summary>
        /// <param name="head">The first span</param>
        /// <param name="tail">The second span</param>
        /// <typeparam name="T">The span element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Concat<T>(this ReadOnlySpan<T> head, ReadOnlySpan<T> tail)
        {
            Span<T> dst = new T[head.Length + tail.Length];
            head.CopyTo(dst);
            tail.CopyTo(dst, head.Length);
            return dst;
        }

        /// <summary>
        /// Forms a new span by the concatenation [head,tail]
        /// </summary>
        /// <param name="head">The first span</param>
        /// <param name="tail">The second span</param>
        /// <typeparam name="T">The span element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Concat<T>(this Span<T> head, ReadOnlySpan<T> tail)
            => head.ReadOnly().Concat(tail);

        /// <summary>
        /// Presents a mutable span as a readonly span
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
            => src.Take(length).ToArray();            

        /// <summary>
        /// Fills an allocated span from a sequence
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <param name="dst">The target spn</param>
        /// <typeparam name="T">The element type</typeparam>
        public static Span<T> StreamTo<T>(this IEnumerable<T> src, Span<T> dst)
        {
            var i = 0;
            var e = src.GetEnumerator();
            while(e.MoveNext() && i < dst.Length)
                dst[i++] = e.Current;
            return dst;
        }            

        /// <summary>
        /// Fills a span of natural length with streamed elements
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="N">The span length type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        public static void StreamTo<N,T>(this IEnumerable<T> src, Span<N,T> dst, N n = default)
            where N : ITypeNat, new()
            where T : struct
                => src.Take(nati<N>()).StreamTo(dst.Unsized);

        /// <summary>
        /// Fills a tabular span of natural dimensions with streamed elements
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="M">The row dimension type</typeparam>
        /// <typeparam name="N">The column dimension type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        public static void StreamTo<M,N,T>(this IEnumerable<T> src, Span<M,N,T> dst)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : struct
                => src.Take(nati<M>() *nati<N>()).StreamTo(dst.Unsized);

        /// <summary>
        /// Clones the source span into a new span
        /// </summary>
        /// <param name="src">The span to replicate</param>
        /// <typeparam name="T">The element type</typeparam>
        /// <returns>Returns the replicated span</returns>
        [MethodImpl(Inline)]
        public static Span<T> Replicate<T>(this ReadOnlySpan<T> src, bool structureOnly = false)
        {
            Span<T> dst = new T[src.Length];
            if(!structureOnly)
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
        public static Span<T> Replicate<T>(this Span<T> src, bool structureOnly = false)
            => src.ReadOnly().Replicate(structureOnly);

        /// <summary>
        /// Creates a new span by interposing a specified element between each element of an existing span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="x">The value to place between each element in the new span</param>
        /// <typeparam name="T">The element type</typeparam>
        public static Span<T> Intersperse<T>(this ReadOnlySpan<T> src, T x)
        {
            Span<T> dst = new T[src.Length*2 - 1];
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
        /// Evaluates whether two spans have identical content
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <typeparam name="T">The value type</typeparam>
        public static bool Eq<T>(this ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct, IEquatable<T>
        {
            if(lhs.Length != rhs.Length)
                return false;
            for(var i=0; i< lhs.Length; i++)
                if(!lhs[i].Equals(rhs[i]))
                    return false;
            return true;
        }

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

        /// <summary>
        /// Evaluates whether two spans have identical content
        /// </summary>
        /// <param name="lhs">The left span</param>
        /// <param name="rhs">The right span</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline)]
        public static bool Eq<T>(this Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : struct, IEquatable<T>
                => lhs.ReadOnly().Eq(rhs);
        
        /// <summary>
        /// Populates a span of natural length from an unsized span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="size">The target size</param>
        /// <typeparam name="N">The target type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]        
        public static Span<N,T> ToNatural<N,T>(this Span<T> src, N size = default)
            where N : ITypeNat, new()
            where T : struct
                => new Span<N, T>(src);       

        /// <summary>
        /// Clones a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> Replicate<T>(this Span256<T> src, bool structureOnly = false)
            where T : struct
        {
            Span<T> dst = new T[src.Length];
            if(!structureOnly)
                src.CopyTo(dst);
            return Z0.Span256<T>.LoadAligned(dst);
        }

        /// <summary>
        /// Clones a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> Replicate<T>(this ReadOnlySpan256<T> src, bool structureOnly = false)
            where T : struct
        {
            Span<T> dst = new T[src.Length];
            if(!structureOnly)
                src.CopyTo(dst);
            return Z0.Span256<T>.LoadAligned(dst);
        }

        /// <summary>
        /// Projects a source span to target span via a supplied transformation
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="f">The transformation</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        public static Span<T> Map<S,T>(this ReadOnlySpan<S> src, Func<S, T> f)
        {
            Span<T> dst = new T[src.Length];
            for(var i= 0; i<src.Length; i++)
                dst[i] = f(src[i]);
            return dst;
        }

        /// <summary>
        /// Creates a copy of the source span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="N">The natural length</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]   
        public static Span<N,T> Replicate<N,T>(this ReadOnlySpan<N,T> src)    
            where N : ITypeNat, new()
            where T : struct
                => new Span<N,T>(src);

        /// <summary>
        /// Projects a source span to target span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="f">The projector</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Map<S,T>(this Span<S> src, Func<S, T> f)
            => src.ReadOnly().Map(f);

        /// <summary>
        /// Projects a range of elements from a source span to a target span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The source offset</param>
        /// <param name="length">The length of the segment to project</param>
        /// <param name="f">The projector</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        public static Span<T> MapRange<S,T>(this ReadOnlySpan<S> src, int offset, int length, Func<S, T> f)
        {
            Span<T> dst = new T[length];
            for (int i = offset; i < length; i++)
                dst[i] = f(src[i]);
            return dst;
        }

        /// <summary>
        /// Projects a range of elements from a source span to a target span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The source offset</param>
        /// <param name="length">The length of the segment to project</param>
        /// <param name="f">The projector</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> MapRange<S,T>(this Span<S> src, int offset, int length, Func<S, T> f)
            => src.ReadOnly().MapRange(offset,length, f);

        public static Span<T> Map<M,N,S,T>(this Span<M,N,S> src, Func<S, T> f)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where S : struct
            where T : struct
        {
            var dst = NatSpan.Alloc<M,N,T>();
            var m = nfunc.nati<M>();
            var n = nfunc.nati<N>();
            for(var i=0; i < m; i++)
            for(var j=0; j < n; j++)
                dst[i,j] = f(src[i,j]);
            return dst;
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

        /// <summary>
        /// Interchanges span elements i and j
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="i">An index of a span element</param>
        /// <param name="j">An index of a span element</param>
        /// <typeparam name="T"></typeparam>
        [MethodImpl(Inline)]
        public static ref Span<T> Swap<T>(this ref Span<T> src, int i, int j)
        {
            if(i != j)
            {
                var tmp = src[i];
                src[i] = src[j];
                src[j] = tmp;
            }
            return ref src;
        }

        /// <summary>
        /// Produces a reversed span from a readonly span
        /// </summary>
        /// <param name="src">The soruce span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Reverse<T>(this ReadOnlySpan<T> src) 
        {       
            var dst = src.ToSpan();
            dst.Reverse();
            return dst;
        }


        [MethodImpl(Inline)]
        public static ReadOnlySpanPair<T> PairWith<T>(this ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)        
            => new ReadOnlySpanPair<T>(lhs,rhs);

        /// <summary>
        /// Creates a set from a source span, thus removing any duplicates and rendering index order asunder
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="N">The source span length type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ISet<T> ToSet<N,T>(this ReadOnlySpan<N,T> src)        
            where N : ITypeNat, new()
            => new HashSet<T>(src.ToArray());   

    }

}