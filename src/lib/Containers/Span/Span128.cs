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

    public static class Span128
    {
        [MethodImpl(Inline)]
        public static void many<T>(T[] src)
            where T : struct, IEquatable<T>
        {
            
            var valueSize = SizeOf<T>.Size;
            var spanLength = 16/valueSize;
            var segments = src.Partition(spanLength);

        }

        [MethodImpl(Inline)]
        public static Span128<T> define<T>(params T[] src)
            where T : struct, IEquatable<T>
                => new Span128<T>(src);


        [MethodImpl(Inline)]
        public static Span128<T> define<T>(T[] src, int startpos = 0)
            where T : struct, IEquatable<T>
                => new Span128<T>(src,startpos);

        [MethodImpl(Inline)]
        public static Span128<T> define<T>(Span<T> src)
            where T : struct, IEquatable<T>
                => new Span128<T>(src);

        public static Span128<T> define<T>(ArraySegment<T> src)
            where T : struct, IEquatable<T>
                => new Span128<T>(src);            
    }


    /// <summary>
    /// A selective clone/wrapper of System.Span[T] where the the 
    /// encasulated data is always of lenth 16 bytes = 128 bits
    /// </summary>
    public ref struct Span128<T>
        where T : struct, IEquatable<T>
    {
        public static implicit operator Span<T>(Span128<T> src)
            => src.data;

        public static implicit operator ReadOnlySpan<T> (Span128<T> src)
            => src.data;

        public static implicit operator Span128<T> (T[] src)
            => new Span128<T>(src);

        public static implicit operator Span128<T> (Array<N128,T> src)
            => new Span128<T>(src);

        public static implicit operator Span128<T> (ArraySegment<T> src)
            => new Span128<T>(src);

        public static bool operator == (Span128<T> lhs, Span128<T> rhs)
            => lhs.data == rhs.data;

        public static bool operator != (Span128<T> lhs, Span128<T> rhs)
            => lhs.data != rhs.data;
        
        static readonly int ComponentByteSize = SizeOf<T>.Size;

        static readonly int ComponentBitSize = ComponentByteSize * 8;

        static readonly int SpanLength = 128 / ComponentBitSize;

        static Exception sizerr(int actual)
            => new ArgumentException($"Length mismatch: {actual}");

        Span<T> data;

        [MethodImpl(Inline)]
        public unsafe Span128(void* src)    
            => data = new Span<T>(src, SpanLength);  

        [MethodImpl(Inline)]
        public Span128(T[] src, int startpos = 0)
        {
            if((src.Length - startpos) < SpanLength)
                throw sizerr(src.Length);
            
            this.data = startpos == 0 ? src : new Span<T>(src, startpos, SpanLength);
        }

        [MethodImpl(Inline)]
        public Span128(T value)
        {
         
            this.data = new Span<T>(new T[SpanLength]);
            this.data.Fill(value);
        }

        [MethodImpl(Inline)]
        public Span128(Span<T> src)
        {
            if(src.Length != SpanLength)
                throw sizerr(src.Length);
         
            this.data = src;
        }

        [MethodImpl(Inline)]
        public Span128(ArraySegment<T> src)
        {
            if(src.Count != SpanLength)
                throw sizerr(src.Count);
            
            this.data = src;

        }

        [MethodImpl(Inline)]
        public Span128(Array<N128,T> src)
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