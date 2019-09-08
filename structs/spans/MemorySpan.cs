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
    using System.Runtime.InteropServices;

    using static zfunc;

    /// <summary>
    /// Defines a contiguous sequence of memory cells
    /// </summary>
    /// <typeparam name="T">The cell type</typeparam>
    public struct MemorySpan<T>
        where T : unmanaged
    {
        Memory<T> data;

        /// <summary>
        /// Returns the source as a reference
        /// </summary>
        /// <param name="src">The source data</param>
        public static ref MemorySpan<T> AsRef(in MemorySpan<T> src)
            => ref Unsafe.AsRef(in src);

        public static readonly MemorySpan<T> Empty = new MemorySpan<T>(Memory<T>.Empty);

        public static implicit operator Span<T>(MemorySpan<T> src)
            => src.Span;

        public static implicit operator MemorySpan<T>(T[] src)
            => new MemorySpan<T>(src);

        public static implicit operator Memory<T>(MemorySpan<T> src)
            => src.data;

        public static implicit operator ReadOnlySpan<T> (MemorySpan<T> src)
            => src.Span;

        public static implicit operator MemorySpan<T> (Memory<T> src)
            => new MemorySpan<T>(src);

        public static implicit operator ReadOnlyMemory<T> (MemorySpan<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public MemorySpan(int len, T? fill = null)
        {                    
            this.data = new T[len];
            if(fill != null)
            this.Span.Fill(fill.Value);
        }

        [MethodImpl(Inline)]
        public MemorySpan(T[] src)
        {
            this.data = src;
        }

        [MethodImpl(Inline)]
        public MemorySpan(Memory<T> src)
        {
            this.data = src;
        }

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => MemoryMarshal.AsBytes(Span);
        }

        /// <summary>
        /// Queries/manipulates an index-identified cell
        /// </summary>
        public ref T this[int ix] 
        {
            [MethodImpl(Inline)]
            get => ref Span[ix];
        }

        /// <summary>
        /// Presents the memory allocation as a span
        /// </summary>
        public Span<T> Span
        {
            [MethodImpl(Inline)]
            get => data.Span;
        }

        /// <summary>
        /// Returns the number of allocated cells
        /// </summary>
        public int Length 
        {
            [MethodImpl(Inline)]
            get => data.Length;
        }

        /// <summary>
        /// Returns true if the number of allocated cells is 0 and false otherwise
        /// </summary>
        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => data.Length == 0;
        }

        [MethodImpl(Inline)]
        public T[] ToArray()
            => data.ToArray();

        [MethodImpl(Inline)]
        public void Fill(T value)
            => Span.Fill(value);

        [MethodImpl(Inline)]
        public Span<T>.Enumerator GetEnumerator()
            => Span.GetEnumerator();

        [MethodImpl(Inline)]
        public ref T GetPinnableReference()
            => ref Span.GetPinnableReference();

        [MethodImpl(Inline)]
        public void CopyTo (Span<T> dst)
            => Span.CopyTo(dst);

        [MethodImpl(Inline)]
        public bool TryCopyTo (Span<T> dst)
            => Span.TryCopyTo(dst);                

        /// <summary>
        /// Creates a copy
        /// </summary>
        [MethodImpl(Inline)]
        public MemorySpan<T> Replicate()        
            => new MemorySpan<T>(Span.ToArray());        

        [MethodImpl(Inline)]
        public MemorySpan<T> Slice(int start)
            => data.Slice(start);

        [MethodImpl(Inline)]
        public MemorySpan<T> Slice(int start, int len)
            => data.Slice(start, len);

        public IEnumerable<T> ToEnumerable()
            => MemoryMarshal.ToEnumerable<T>(data);
            
        [MethodImpl(Inline)]
        public MemorySpan<U> As<U>()
            where U : unmanaged
                => new MemorySpan<U>(MemoryCast.As<T,U>(data));

        public override bool Equals(object rhs) 
            => throw new NotSupportedException();

        public override int GetHashCode() 
            => throw new NotSupportedException();    

        /// <summary>
        /// Allocates/populates the span obtained by applying a supplied projector
        /// to the current span
        /// </summary>
        /// <param name="f">A projector</param>
        /// <typeparam name="U">The target type</typeparam>
        public MemorySpan<U> Map<U>(Func<T,U> f)
            where U : unmanaged
        {
            var dst = new U[Length];
            for(var i= 0; i<Length; i++)
                dst[i] = f(this[i]);
            return dst;
        }

        /// <summary>
        /// Allocates/populates the span obtained by applying a supplied projector
        /// to the current span
        /// </summary>
        /// <param name="f">A projector that accepts a cell value and its index</param>
        /// <typeparam name="U">The target type</typeparam>
        public MemorySpan<U> Map<U>(Func<int,T,U> f)
            where U : unmanaged
        {
            var dst = new U[Length];
            for(var i= 0; i<Length; i++)
                dst[i] = f(i,this[i]);
            return dst;
        }

        /// <summary>
        /// Projects span data into a caller-allocated target
        /// </summary>
        /// <param name="f">The projector</param>
        /// <param name="dst">The receiving span</param>
        /// <typeparam name="U">The target type</typeparam>
        public MemorySpan<U> Map<U>(Func<T,U> f, MemorySpan<U> dst)
            where U : unmanaged
        {
            for(var i= 0; i<Length; i++)
                dst[i] = f(this[i]);
            return dst;
        }

        /// <summary>
        /// Projects span data into a caller-allocated target
        /// </summary>
        /// <param name="f">A projector that accepts a cell value and its index</param>
        /// <param name="dst">The receiving span</param>
        /// <typeparam name="U">The target type</typeparam>
        public MemorySpan<U> Map<U>(Func<int,T,U> f, MemorySpan<U> dst)
            where U : unmanaged
        {
            for(var i= 0; i<Length; i++)
                dst[i] = f(i,this[i]);
            return dst;
        }

        /// <summary>
        /// Applies the supplied function to each cell to effect an in-place update
        /// </summary>
        /// <param name="f">A projector</param>
        public void Iter(Func<T,T> f)
        {
            for(var i=0; i<Length; i++)
                this[i] = f(this[i]);
        }

        /// <summary>
        /// Applies the supplied function to each cell to effect an in-place update
        /// </summary>
        /// <param name="f">An index projector that accepts both the cell value and its index</param>
        public void Iter(Func<int,T,T> f)
        {
            for(var i=0; i<Length; i++)
                this[i] = f(i,this[i]);
        }
    }
}