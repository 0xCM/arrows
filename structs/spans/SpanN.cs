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
    /// Defines a span of natural length N
    /// </summary>
    public ref struct Span<N,T>
        where N : ITypeNat, new()
    {
        Span<T> data;

        public static readonly int SpanLength = nati<N>();

        public static implicit operator Span<T>(Span<N,T> src)
            => src.data;

        public static implicit operator Span<N,T>(Span<T> src)
            => new Span<N,T>(src);

        public static implicit operator ReadOnlySpan<T> (Span<N,T> src)
            => src.data;
    
        public static bool operator == (Span<N,T> lhs, Span<N,T> rhs)
            => lhs.data == rhs.data;

        public static bool operator != (Span<N,T> lhs, Span<N,T> rhs)
            => lhs.data != rhs.data;            

        [MethodImpl(Inline)]
        public Span(T value)
        {         
            
            this.data = new Span<T>(new T[SpanLength]);
            this.data.Fill(value);
        }

        [MethodImpl(Inline)]
        public Span(Span<T> src)
        {
            require(src.Length == SpanLength, $"length(src) = {src.Length} != {SpanLength} = SpanLength");
            this.data = src;
        }

        [MethodImpl(Inline)]
        public Span(Span<N,T> src)
        {
            this.data = src;
        }

        [MethodImpl(Inline)]
        public Span(ref T src)
        {
            data = MemoryMarshal.CreateSpan(ref src, SpanLength);
        }

        [MethodImpl(Inline)]
        public Span(ReadOnlySpan<N,T> src)
        {
            data = src.ToArray();
        }

        [MethodImpl(Inline)]
        public Span(ReadOnlySpan<T> src)
        {
            require(src.Length == SpanLength, $"length(src) = {src.Length} != {SpanLength} = SpanLength");         
            data = src.ToArray();            
        }

        public ref T this[int ix] 
        {
            [MethodImpl(Inline)]
            get => ref data[ix];
        }

        public Span<T> Unsized
        {
            [MethodImpl(Inline)]
            get => data;
        }

        [MethodImpl(Inline)]
        public T[] ToArray()
            => data.ToArray();   

        [MethodImpl(Inline)]
        public void Fill(T value)
            => data.Fill(value);

        [MethodImpl(Inline)]
        public Span<T>.Enumerator GetEnumerator()
            => data.GetEnumerator();

        [MethodImpl(Inline)]
        public ref T GetPinnableReference()
            => ref data.GetPinnableReference();

        [MethodImpl(Inline)]
        public void CopyTo (Span<T> dst)
            => data.CopyTo(dst);

        [MethodImpl(Inline)]
        public bool TryCopyTo (Span<T> dst)
            => data.TryCopyTo(dst);        
        
        [MethodImpl(Inline)]
        public Span<T> Unsize()
            => data;

        [MethodImpl(Inline)]
        public Span<N,T> Replicate()        
            => new Span<N,T>(data.ToArray());
        
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