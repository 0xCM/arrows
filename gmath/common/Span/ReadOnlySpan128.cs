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
    
    using static zcore;
    using static inxfunc;
    using static Span128;

    public static class ReadOnlySpan128
    {
        [MethodImpl(Inline)]
        public static ReadOnlySpan128<T> load<T>(ReadOnlySpan<T> src)
            where T : struct, IEquatable<T>
            => new ReadOnlySpan128<T>(src.Slice(0, Span128.align<T>(src.Length)));            

        [MethodImpl(Inline)]
        public static ReadOnlySpan128<T> load<T>(Span<T> src)
            where T : struct, IEquatable<T>
            => new ReadOnlySpan128<T>(src.Slice(0, Span128.align<T>(src.Length)));            

        [MethodImpl(Inline)]
        public static ReadOnlySpan128<T> load<T>(T[] src, int offset, int len)
            where T : struct, IEquatable<T>
                => new ReadOnlySpan128<T>(src,offset,len);

        [MethodImpl(Inline)]
        public static ReadOnlySpan128<T> single<T>(params T[] src)
            where T : struct, IEquatable<T>
                => new ReadOnlySpan128<T>(src);
    }

    /// <summary>
    /// A selective clone/wrapper of System.Span[T] where the the 
    /// encasulated data is always a multiple of 16 bytes = 128 bits
    /// </summary>
    public readonly ref struct ReadOnlySpan128<T>
        where T : struct, IEquatable<T>
    {

        public static implicit operator ReadOnlySpan<T> (ReadOnlySpan128<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static explicit operator ReadOnlySpan128<T>(ReadOnlySpan<T> src)
            => new ReadOnlySpan128<T>(src);

        public static bool operator == (ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            => lhs.data == rhs.data;

        public static bool operator != (ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            => lhs.data != rhs.data;

        /// <summary>
        /// The number of values per block
        /// </summary>
        public static readonly int CellCount = Vec128<T>.Length;

        /// <summary>
        /// The size, in bytes, of a block constituent
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        public static readonly int CellSize = Unsafe.SizeOf<T>();

        static Exception unaligned(int actual)
            => new ArgumentException($"Length mismatch: {actual}");


        readonly ReadOnlySpan<T> data;

        [MethodImpl(Inline)]
        public unsafe ReadOnlySpan128(void* src, int len)    
        {
            assert(aligned<T>(len));
            
            data = new ReadOnlySpan<T>(src, len);  

        }

        [MethodImpl(Inline)]
        public ReadOnlySpan128(T[] src)
        {
            assert(aligned<T>(src.Length));
            data = rospan(src);
        }

        [MethodImpl(Inline)]
        public ReadOnlySpan128(T[] src, int offset, int len)
        {
            assert(aligned<T>(len - offset));
            data = rospan(src, offset, len);
        }

        [MethodImpl(Inline)]
        public ReadOnlySpan128(ReadOnlySpan<T> src)
        {
            assert(aligned<T>(src.Length));
            data = src;
        }

        [MethodImpl(Inline)]
        public ReadOnlySpan128(T value, int len)
        {
            assert(aligned<T>(len));
            
            var src = span<T>(len);
            src.Fill(value);
            this.data = src;
        }

        [MethodImpl(Inline)]
        public ReadOnlySpan128(ref Span<T> src)
        {
            assert(aligned<T>(src.Length));
         
            this.data = src;
        }

        [MethodImpl(Inline)]
        public ReadOnlySpan128(ArraySegment<T> src)
        {
            assert(aligned<T>(src.Count));
            
            this.data = src;

        }

        public ref readonly T this[int ix] 
        {
            [MethodImpl(Inline)]
            get => ref data[ix];
        }

        public ref readonly T this[Index ix] 
        {
            [MethodImpl(Inline)]
            get => ref data[ix];
        }

        public ReadOnlySpan<T> this[Range range]
        {
            [MethodImpl(Inline)]
            get => data[range];

        }

        [MethodImpl(Inline)]
        public ReadOnlySpan<T> Slice(int start)
            => data.Slice(start);

        [MethodImpl(Inline)]
        public ReadOnlySpan<T> Slice(int start, int length)
            => data.Slice(start,length);

        [MethodImpl(Inline)]
        public ReadOnlySpan<T> Slice(Range range)
            => data.Slice(range);

 
         [MethodImpl(Inline)]
        public ReadOnlySpan128<T> Block(int start)
        {
            assert(aligned<T>(start));
            return (ReadOnlySpan128<T>)Slice(start);
        }

        [MethodImpl(Inline)]
        public ReadOnlySpan128<T> Block(int start, int count)
        {
            assert(aligned<T>(start));
            return (ReadOnlySpan128<T>)Slice(start, count * CellCount);
        }

        [MethodImpl(Inline)]
        public Span<T> ToSpan()
            => span(data);

        [MethodImpl(Inline)]
        public ReadOnlySpan<T> ToReadOnlySpan()
            => data;

        [MethodImpl(Inline)]
        public T[] ToArray()
            => data.ToArray();   

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

        [MethodImpl(Inline)]
        public ReadOnlySpan128<S> As<S>()                
            where S : struct, IEquatable<S>
                => (ReadOnlySpan128<S>)MemoryMarshal.Cast<T,S>(data);            

        public int Length 
        {
            [MethodImpl(Inline)]
            get => data.Length;
        }

        public int BlockCount 
        {
            [MethodImpl(Inline)]
            get => data.Length / CellCount;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => data.IsEmpty;
        }
            
        public override string ToString() 
            => data.ToString();

       public override bool Equals(object rhs) 
            => throw new NotSupportedException();

       public override int GetHashCode() 
            => throw new NotSupportedException();        
    }
}