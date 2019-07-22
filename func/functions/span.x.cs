//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Concurrent;
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
        /// Constructs a span from an aray
        /// </summary>
        /// <param name="src">The source aray</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> ToReadOnlySpan<T>(this T[] src)
            => src;

        /// <summary>
        /// Constructs a readonly span from readonly memory
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> ToReadOnlySpan<T>(this ReadOnlyMemory<T> src)
            => new ReadOnlySpan<T>(src.ToArray());

        /// <summary>
        /// Constructs a readonly span from a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> ReadOnly<T>(this Span<T> src)
            => src;

        /// <summary>
        /// Constructs a span from an array selection
        /// </summary>
        /// <param name="src">The source array</param>
        /// <param name="start">The array index where the span is to begin</param>
        /// <param name="length">The number of elements to cover from the aray</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> ToSpan<T>(this T[] src, Index start, int length)
            => span(src,start.Value,length);

        /// <summary>
        /// Splits a range into a left/right tuple index
        /// </summary>
        /// <param name="left">The index at which the selection begins</param>
        /// <param name="right">The index at which the selection ends</param>
        [MethodImpl(Inline)]
        public static (Index left, Index right) Split(this Range selection)
            => (selection.Start, selection.End);

        /// <summary>
        /// Constructs a span from a readonly span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> ToSpan<T>(this ReadOnlySpan<T> src)
        {
            var dst = span<T>(src.Length);
            src.CopyTo(dst);
            return dst;
        }

        /// <summary>
        /// Determines whether any elements of the source match the target
        /// </summary>
        /// <param name="src">The source values</param>
        /// <param name="target">The target value to match</param>
        /// <typeparam name="T">The value type</typeparam>
        public static bool Contains<T>(this ReadOnlySpan<T> src, T target)        
            where T : struct
        {
            var enumerator = src.GetEnumerator();
            while(enumerator.MoveNext())
                if(enumerator.Current.Equals(target))
                    return true;
            return false;
        }

        [MethodImpl(Inline)]
        public static bool Contains<T>(this Span<T> src, T match)        
            where T : struct
                => src.ReadOnly().Contains(match);

        /// <summary>
        /// Returns a reference to the first element of a nonempty span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref T First<T>(this Span<T> src)
        {
            if(src.IsEmpty)
                throw Errors.EmptySourceSpan();
            return ref src[0];
        }

        /// <summary>
        /// Returns a reference to the last element of a nonempty span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref T Last<T>(this Span<T> src)
        {
            if(src.IsEmpty)
                throw Errors.EmptySourceSpan();
            return ref src[src.Length - 1];
        }

        /// <summary>
        /// Returns a readonly reference to the first element of a nonempty span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T First<T>(this ReadOnlySpan<T> src)
        {
            if(src.IsEmpty)
                throw Errors.EmptySourceSpan();
            return ref src[0];
        }

        /// <summary>
        /// Returns a readonly reference to the last element of a nonempty span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T Last<T>(this ReadOnlySpan<T> src)
        {
            if(src.IsEmpty)
                throw Errors.EmptySourceSpan();
            return ref src[src.Length - 1];
        }

        /// <summary>
        /// Determines whether any elements of a span satisfy a supplied predicate
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="f">The predicate</param>
        /// <typeparam name="T">The element type</typeparam>
        public static bool Any<T>(this ReadOnlySpan<T> src, Func<T,bool> f)
        {
            var it = src.GetEnumerator();
            while(it.MoveNext())
                if(f(it.Current))
                    return true;
            return false;
        }

        [MethodImpl(Inline)]
        public static bool Any<T>(this Span<T> src, Func<T,bool> f)
             where T : struct
                => src.ReadOnly().Any(f);

        /// <summary>
        /// Determines whether all of the elements of a source span satisfy a supplied predicate
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="f">The predicate</param>
        /// <typeparam name="T">The element type</typeparam>
        public static bool All<T>(this ReadOnlySpan<T> src, Func<T,bool> f)
             where T : struct
        {
            var it = src.GetEnumerator();
            while(it.MoveNext())
                if(!f(it.Current))
                    return false;
            return true;
        }

        /// <summary>
        /// Determines whether all of the elements of a source span satisfy a supplied predicate
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="f">The predicate</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static bool All<T>(this Span<T> src, Func<T,bool> f)
             where T : struct
                => src.ReadOnly().All(f);

        /// <summary>
        /// Constructs a span from a (presumeably finite) sequence
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> ToSpan<T>(this IEnumerable<T> src)
            => span(src);

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
            
        /// <summary>
        /// Constructs a span from a sequence selection
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <param name="offset">The number of elements to skip from the head of the sequence</param>
        /// <param name="length">The number of elements to take from the sequence</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> ToSpan<T>(this IEnumerable<T> src, int? offset = null, int? length = null)
            => span(src,offset,length);

        /// <summary>
        /// Constructs a span from a sequence selection
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> ToSpan<T>(this T[] src)
            => src;

        /// <summary>
        /// Projects a source span to target span via a supplied transformation
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="f">The transformation</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        public static Span<T> Map<S,T>(this ReadOnlySpan<S> src, Func<S, T> f)
        {
            var dst = span<T>(src.Length);
            for(var i= 0; i<src.Length; i++)
                dst[i] = f(src[i]);
            return dst;
        }

        /// <summary>
        /// Projects a source span to target span via a supplied transformation
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="f">The transformation</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Map<S,T>(this Span<S> src, Func<S, T> f)
            => src.ReadOnly().Map(f);

        public static Span<T> MapRange<S,T>(this ReadOnlySpan<S> src, int offset, int length, Func<S, T> f)
        {
            var dst = span<T>(length);
            for (int i = offset; i < length; i++)
                dst[i] = f(src[i]);
            return dst;
        }

        public static Span<T> Map<M,N,S,T>(this Span<M,N,S> src, Func<S, T> f)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
        {
            var dst = NatSpan.alloc<M,N,T>();
            var m = nfunc.nati<M>();
            var n = nfunc.nati<N>();
            for(var i=0; i < m; i++)
            for(var j=0; j < n; j++)
                dst[i,j] = f(src[i,j]);
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
            
        [MethodImpl(Inline)]
        public static Span<T> MapRange<S,T>(this Span<S> src, int offset, int length, Func<S, T> f)
            => src.ReadOnly().MapRange(offset,length, f);

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

        /// <summary>
        /// Creates a dictionary from a span using the element indices as keys
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static IDictionary<int,T> ToDictionary<T>(this Span<T> src)        
            => src.ReadOnly().ToDictionary();

        /// <summary>
        /// Constructs a span from a sequence selection
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> ToSpan256<T>(this T[] src)
            where T : struct
            => Z0.Span256.load<T>(src);

        [MethodImpl(Inline)]
        public static Span128<T> ToSpan128<T>(this Span<T> src)
             where T : struct
                => Z0.Span128.load(src);

        [MethodImpl(Inline)]
        public static Span256<T> ToSpan256<T>(this Span<T> src)
             where T : struct
                => Z0.Span256.load(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpanPair<T> PairWith<T>(this ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)        
            => new ReadOnlySpanPair<T>(lhs,rhs);
    
        /// <summary>
        /// Clones a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> Replicate<T>(this Span256<T> src)
            where T : struct
        {
            var dst = span<T>(src.Length);
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

        /// <summary>
        /// Replicates a source value into a span and returns the result
        /// </summary>
        /// <param name="src">The value to replicate</param>
        /// <param name="count">The number of clones</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> Replicate<T>(this T src, int count)
            where T : struct
        {
            Span<T> dst = new T[count];
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
 
        /// <summary>
        /// Presents a readonly span of one value-type as a span of another value-type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source span element type</typeparam>
        /// <typeparam name="T">The target span element type</typeparam>
        [MethodImpl(Inline)]        
        public static ReadOnlySpan<T> As<S,T>(this ReadOnlySpan<S> src)
            where S : struct
            where T : struct
                => MemoryMarshal.Cast<S,T>(src);                                    

        /// <summary>
        /// Presents a span of one value-type as a span of another value-type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source span element type</typeparam>
        /// <typeparam name="T">The target span element type</typeparam>
        [MethodImpl(Inline)]        
        public static Span<T> As<S,T>(this Span<S> src)
            where S : struct
            where T : struct
                => MemoryMarshal.Cast<S,T>(src);                                    

        /// <summary>
        /// Presents a value-type readonly span as a span of bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source span element type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> AsBytes<T>(this ReadOnlySpan<T> src)
            where T : struct
                => MemoryMarshal.AsBytes(src);
        
        /// <summary>
        /// Presents a value-type span as a span of bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source span element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<byte> AsBytes<T>(this Span<T> src)
            where T : struct
                => MemoryMarshal.AsBytes(src);
 
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
            
        /// <summary>
        /// Lifts the content of a span into a LINQ enumerable
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        public static IEnumerable<T> ToEnumerable<T>(this ReadOnlySpan<T> src)
            => src.ToArray();
            
        /// <summary>
        /// Lifts the content of a span into a LINQ enumerable
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static IEnumerable<T> ToEnumerable<T>(this Span<T> src)
            => src.ReadOnly().ToEnumerable();

        /// <summary>
        /// Creates a set from a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ISet<T> ToSet<T>(this Span<T> src)        
            => new HashSet<T>(src.ToEnumerable());

        /// <summary>
        /// Creates a set from a readonly span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ISet<T> ToSet<T>(this ReadOnlySpan<T> src)        
            => new HashSet<T>(src.ToEnumerable());

        [MethodImpl(Inline)]        
        public static string Format<T>(this Span<T> src, char delimiter = ',', int offset = 0)
            => src.ReadOnly().Format(delimiter, offset);

        [MethodImpl(Inline)]        
        public static string Format<T>(this ReadOnlySpan128<T> src, char delimiter = ',', int offset = 0)
            where T : struct
            => src.Unblock().Format(delimiter, offset);

        [MethodImpl(Inline)]        
        public static string Format<T>(this Span128<T> src, char delimiter = ',', int offset = 0)
            where T : struct
            => src.Unblock().Format(delimiter, offset);

        [MethodImpl(Inline)]        
        public static string Format<T>(this ReadOnlySpan256<T> src, char delimiter = ',', int offset = 0)
            where T : struct
            => src.UnBlock().Format(delimiter, offset);

        [MethodImpl(Inline)]        
        public static string Format<T>(this Span256<T> src, char delimiter = ',', int offset = 0)
            where T : struct
            => src.Unblock().Format(delimiter, offset);

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


        [MethodImpl(Inline)]
        public static Span<sbyte> AsInt8<T>(this Span<T> src)
            where T : struct        
                => MemoryMarshal.Cast<T,sbyte>(src);

        [MethodImpl(Inline)]
        public static Span<byte> AsUInt8<T>(this Span<T> src)
            where T : struct        
                => MemoryMarshal.AsBytes(src);

       [MethodImpl(Inline)]
        public static Span<short> AsInt16<T>(this Span<T> src)
            where T : struct        
                => MemoryMarshal.Cast<T,short>(src);

        [MethodImpl(Inline)]
        public static Span<ushort> AsUInt16<T>(this Span<T> src)
            where T : struct        
                => MemoryMarshal.Cast<T,ushort>(src);

        [MethodImpl(Inline)]
        public static Span<int> AsInt32<T>(this Span<T> src)
            where T : struct        
                => MemoryMarshal.Cast<T,int>(src);

        [MethodImpl(Inline)]
        public static Span<uint> AsUInt32<T>(this Span<T> src)
            where T : struct        
                => MemoryMarshal.Cast<T,uint>(src);

        [MethodImpl(Inline)]
        public static Span<long> AsInt64<T>(this Span<T> src)
            where T : struct        
                => MemoryMarshal.Cast<T,long>(src);

        [MethodImpl(Inline)]
        public static Span<ulong> AsUInt64<T>(this Span<T> src)
            where T : struct        
                => MemoryMarshal.Cast<T,ulong>(src);
        
        [MethodImpl(Inline)]
        public static ReadOnlySpan<sbyte> AsInt8<T>(this ReadOnlySpan<T> src)
            where T : struct        
                => MemoryMarshal.Cast<T,sbyte>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of bytes
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> AsUInt8<T>(this ReadOnlySpan<T> src)
            where T : struct        
                => MemoryMarshal.AsBytes(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of int16
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
       [MethodImpl(Inline)]
        public static ReadOnlySpan<short> AsInt16<T>(this ReadOnlySpan<T> src)
            where T : struct        
                => MemoryMarshal.Cast<T,short>(src);

        /// <summary>
        /// Reimagines a span of generic values as a span of uint16
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<ushort> AsUInt16<T>(this ReadOnlySpan<T> src)
            where T : struct        
                => MemoryMarshal.Cast<T,ushort>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<int> AsInt32<T>(this ReadOnlySpan<T> src)
            where T : struct        
                => MemoryMarshal.Cast<T,int>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<uint> AsUInt32<T>(this ReadOnlySpan<T> src)
            where T : struct        
                => MemoryMarshal.Cast<T,uint>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<long> AsInt64<T>(this ReadOnlySpan<T> src)
            where T : struct        
                => MemoryMarshal.Cast<T,long>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<ulong> AsUInt64<T>(this ReadOnlySpan<T> src)
            where T : struct        
                => MemoryMarshal.Cast<T,ulong>(src);

        [MethodImpl(Inline)]
        public static T ReadValue<T>(this ReadOnlySpan<byte> src, int offset = 0)
            where T : struct
        {
            if(MemoryMarshal.TryRead(src.Slice(offset), out T value))                
                return value;
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static T ReadValue<T>(this Span<byte> src, int offset = 0)
            where T : struct
                => src.ReadOnly().ReadValue<T>(offset);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> ReadValues<T>(this ReadOnlySpan<byte> src, int offset, int count)
            where T : struct
                => MemoryMarshal.Cast<byte,T>(src.Slice(offset, count * Unsafe.SizeOf<T>()));

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> ReadValues<T>(this Span<byte> src, int offset, int count)
            where T : struct
                => src.ReadOnly().ReadValues<T>(offset,count);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> ReadValues<T>(this ReadOnlySpan<byte> src)
            where T : struct
                => src.ReadValues<T>(0, src.Length/Unsafe.SizeOf<T>());

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> ReadValues<T>(this Span<byte> src)
            where T : struct        
                => src.ReadOnly().ReadValues<T>();


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
        /// Reads a readonly span of bytes from a span of value types
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The number of source elements to skip from the head</param>
        /// <param name="length">Tne number of source elements to read</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> ReadBytes<T>(this ReadOnlySpan<T> src, int? offset = null, int? length = null)
            where T : struct
        {
            if(offset == null && length == null)
                return MemoryMarshal.AsBytes(src);
            else if(offset != null && length == null)
                return MemoryMarshal.AsBytes(src.Slice(offset.Value));
            else
                return MemoryMarshal.AsBytes(src.Slice(offset.Value,length.Value));
        }
                
        /// <summary>
        /// Reads a span of bytes from a span of value types
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The number of source elements to skip from the head</param>
        /// <param name="length">Tne number of source elements to read</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<byte> ReadBytes<T>(this Span<T> src, int? offset = null, int? length = null)
            where T : struct
        {
            if(offset == null && length == null)
                return MemoryMarshal.AsBytes(src);
            else if(offset != null && length == null)
                return MemoryMarshal.AsBytes(src.Slice(offset.Value));
            else
                return MemoryMarshal.AsBytes(src.Slice(offset.Value,length.Value));
        }


    }
}