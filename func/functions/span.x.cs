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

    partial class xfunc
    {
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
        /// Constructs a span from the entireity of a sequence
        /// </summary>
        /// <param name="src">The source sequence</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> ToSpan<T>(this IEnumerable<T> src)
            => span(src);

        [MethodImpl(Inline)]
        public static Span<T> TakeSpan<T>(this IEnumerable<T> src, int length)
            => span(src.Take(length));

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

        [MethodImpl(Inline)]
        public static Span<T> Replicate<T>(this ReadOnlySpan<T> src)
        {
            var dst = span<T>(src.Length);
            src.CopyTo(dst);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<T> Replicate<T>(this Span<T> src)
            => src.ReadOnly().Replicate();

        [MethodImpl(Inline)]
        public static Span<T> FillWith<T>(this Span<T> io, T value)
        {
            io.Fill(value);
            return io;
        }

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> ToBytes<T>(this ReadOnlySpan<T> src)
            where T : struct
            => MemoryMarshal.AsBytes(src);
        
        [MethodImpl(Inline)]
        public static Span<byte> ToBytes<T>(this Span<T> src)
            where T : struct
            => MemoryMarshal.AsBytes(src);

        public static (int Index, T Value)[] ToIndexedValues<T>(this ReadOnlySpan<T> src)
        {
            var dst = alloc<(int,T)>(src.Length);
            for(var i = 0; i< dst.Length; i++)
                dst[i] = (i,src[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static (int Index, T Value)[] ToIndexedValues<T>(this Span<T> src)        
            => src.ReadOnly().ToIndexedValues();

        [MethodImpl(Inline)]
        public static (T[] Left, T[] Right) PairReplicate<T>(this ReadOnlySpan<T> src)
            where T : struct
                => (src.Replicate().ToArray(), src.Replicate().ToArray());

        /// <summary>
        /// Formats a readonly span as a vector
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="sep">The item separator</param>
        /// <typeparam name="T">The item type</typeparam>
        [MethodImpl(Inline)]
        public static string FormatAsVector<T>(this ReadOnlySpan<T> src, string sep = ", ")
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
        public static string FormatAsVector<T>(this Span<T> src, string sep = ", ")
            => src.ReadOnly().FormatAsVector(sep);


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
    
        [MethodImpl(Inline)]
        public static Span256<T> Replicate<T>(this Span256<T> src)
            where T : struct
        {
            var dst = span<T>(src.Length);
            src.CopyTo(dst);
            return Z0.Span256.load<T>(dst);
        }

        [MethodImpl(Inline)]
        public static Span256<T> Replicate<T>(this ReadOnlySpan256<T> src)
            where T : struct
        {
            var dst = span<T>(src.Length);
            src.CopyTo(dst);
            return Z0.Span256.load<T>(dst);
        }

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
        public static Span<N,T> ToNatSpan<N,T>(this Span<T> src, N size = default)
            where T : struct
            where N : ITypeNat, new()
                => new Span<N, T>(src);
       
    }
}