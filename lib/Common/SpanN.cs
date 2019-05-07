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
    
    using static zcore;
    using static nats;


    /// <summary>
    /// A selective clone/wrapper of System.Span[T] where the the 
    /// encasulated data is always of lenth 16 bytes = 128 bits
    /// </summary>
    public ref struct Span<N,T>
        where N : ITypeNat, new()
        where T : struct, IEquatable<T>
    {
        public static implicit operator Span<T>(Span<N,T> src)
            => src.data;

        public static implicit operator ReadOnlySpan<T> (Span<N,T> src)
            => src.data;

        public static implicit operator Span<N,T> (Array<N,T> src)
            => new Span<N,T>(src);
    
        public static bool operator == (Span<N,T> lhs, Span<N,T> rhs)
            => lhs.data == rhs.data;

        public static bool operator != (Span<N,T> lhs, Span<N,T> rhs)
            => lhs.data != rhs.data;

        static readonly int SpanLength = nati<N>();

        static Exception sizerr(int actual)
            => new ArgumentException($"Length mismatch: {actual}");

        Span<T> data;


        [MethodImpl(Inline)]
        public unsafe Span(void* src)    
            => data = new Span<T>(src, SpanLength);  

        [MethodImpl(Inline)]
        public Span(T[] src, int startpos = 0)
        {
            if((src.Length - startpos) < SpanLength)
                throw sizerr(src.Length);
            
            this.data = startpos == 0 ? src : new Span<T>(src, startpos, SpanLength);
        }

        [MethodImpl(Inline)]
        public Span(Array<N,T> value)
            => this.data = value.unwrap();


        [MethodImpl(Inline)]
        public Span(T value)
        {
         
            this.data = new Span<T>(new T[SpanLength]);
            this.data.Fill(value);
        }

        [MethodImpl(Inline)]
        public Span(Span<T> src)
        {
            if(src.Length != SpanLength)
                throw sizerr(src.Length);
         
            this.data = src;
        }

        [MethodImpl(Inline)]
        public Span(Array<N128,T> src)
            => this.data = src.unwrap();

        public ref T this[int ix] 
        {
            [MethodImpl(Inline)]
            get => ref data[ix];
        }

        public ref T this[Index ix] 
        {
            [MethodImpl(Inline)]
            get => ref data[ix];
        }

        [MethodImpl(Inline)]
        public Span<T> Unwrap()
            => data;

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
        public T GetPinnableReference()
            => data.GetPinnableReference();

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

        public override string ToString() 
            => data.ToString();

       public override bool Equals(object rhs) 
            => throw new NotSupportedException();

       public override int GetHashCode() 
            => throw new NotSupportedException();
        
    }
}