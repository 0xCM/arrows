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

    using static nfunc;
    using static zfunc;

    /// <summary>
    /// Defines a readonly span of natural length N
    /// </summary>
    public ref struct ReadOnlySpan<N,T>
        where N : ITypeNat, new()
    {
        ReadOnlySpan<T> data;

        public static readonly int SpanLength = nati<N>();

        public static implicit operator ReadOnlySpan<T> (ReadOnlySpan<N,T> src)
            => src.data;
    
        public static implicit operator ReadOnlySpan<N,T> (T[] src)
            => new ReadOnlySpan<N, T>(src);

        public static implicit operator ReadOnlySpan<N,T> (ReadOnlySpan<T> src)
            => new ReadOnlySpan<N, T>(src);

        public static bool operator == (ReadOnlySpan<N,T> lhs, ReadOnlySpan<N,T> rhs)
            => lhs.data == rhs.data;

        public static bool operator != (ReadOnlySpan<N,T> lhs, ReadOnlySpan<N,T> rhs)
            => lhs.data != rhs.data;

        [MethodImpl(Inline)]
        public ReadOnlySpan(ref T src)
            => data = MemoryMarshal.CreateReadOnlySpan(ref src, SpanLength);

        [MethodImpl(Inline)]
        public ReadOnlySpan(ref ReadOnlySpan<T> src)
        {
            require(src.Length == SpanLength, $"length(src) = {src.Length} != {SpanLength} = SpanLength");         
            this.data = src;
        }

        [MethodImpl(Inline)]
        public ReadOnlySpan(ReadOnlySpan<T> src)
        {
            require(src.Length == SpanLength, $"length(src) = {src.Length} != {SpanLength} = SpanLength");         
            this.data = src;
        }

        public ref readonly T this[int ix] 
        {
            [MethodImpl(Inline)]
            get => ref data[ix];
        }

        /// <summary>
        /// Provides access to the underlying storage
        /// </summary>
        public ReadOnlySpan<T> Unsized
        {
            [MethodImpl(Inline)]
            get => data;
        }

        [MethodImpl(Inline)]
        public T[] ToArray()
            => data.ToArray();   

        /// <summary>
        /// Returns the represented content modulo type-level size information
        /// </summary>
        [MethodImpl(Inline)]
        public ReadOnlySpan<T> Unsize()
            => data;

        [MethodImpl(Inline)]
        public ReadOnlySpan<T>.Enumerator GetEnumerator()
            => data.GetEnumerator();

        [MethodImpl(Inline)]
        public ref readonly T GetPinnableReference()
            => ref data.GetPinnableReference();

        [MethodImpl(Inline)]
        public void CopyTo (Span<T> dst)
            => data.CopyTo(dst);

        [MethodImpl(Inline)]
        public bool TryCopyTo (Span<T> dst)
            => data.TryCopyTo(dst);

        public int Length 
            => SpanLength;
            
        public bool IsEmpty
            => data.IsEmpty;

        public override bool Equals(object rhs) 
            => throw new NotSupportedException();

        public override int GetHashCode() 
            => throw new NotSupportedException();        
    }
}