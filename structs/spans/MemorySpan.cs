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
    using System.Buffers;

    using static nfunc;
    using static zfunc;

    public static class MemorySpan
    {
        /// <summary>
        /// Allocates a memory span of specified length
        /// </summary>
        /// <param name="len">The data length</param>
        /// <param name="fill">An optional fill value</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static MemorySpan<T> Alloc<T>(int len, T? fill = default)
            where T : unmanaged
                => new MemorySpan<T>(len,fill);
    
        /// <summary>
        /// Creates a memory span from array content
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static MemorySpan<T> From<T>(T[] src)
            where T : unmanaged
                => src;
    
        /// <summary>
        /// Creates a memory span from memory content
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static MemorySpan<T> From<T>(Memory<T> src)
            where T : unmanaged
                => src;

        /// <summary>
        /// Creates a memory span from readonly memory content (allocating?)
        /// </summary>
        /// <param name="src">The data source</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static MemorySpan<T> From<T>(ReadOnlyMemory<T> src)
            where T : unmanaged
                => MemoryMarshal.AsMemory(src);
    }

    /// <summary>
    /// Defines a span of natural length N
    /// </summary>
    /// <typeparam name="T">The cell type</typeparam>
    public struct MemorySpan<T>
        where T : unmanaged
    {
        Memory<T> data;

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
 
        public ref T this[int ix] 
        {
            [MethodImpl(Inline)]
            get => ref Span[ix];
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

        [MethodImpl(Inline)]
        public MemorySpan<T> Replicate()        
            => new MemorySpan<T>(Span.ToArray());
        
        public Span<T> Span
        {
            [MethodImpl(Inline)]
            get => data.Span;
        }
        public int Length 
        {
            [MethodImpl(Inline)]
            get => data.Length;
        }
                        
        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => data.Length == 0;
        }

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
    }


}