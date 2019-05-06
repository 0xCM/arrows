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
    using System.Diagnostics;
    
    using static zcore;
    using static mfunc;

    /// <summary>
    /// A System.Span[T] clone where the  encasulated data is always a multiple 
    /// of 16 bytes = 128 bits
    /// </summary>
    public ref struct ReadOnlySpan128<T>
        where T : struct, IEquatable<T>
    {
        /// <summary>
        /// The number of cells in the block
        /// </summary>
        public static readonly int BlockLength = Span128<T>.BlockLength;

        /// <summary>
        /// The size, in bytes, of a block 
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        /// <remarks>Should always be 16 irrespective of the cell type</remarks>
        public static readonly int BlockSize = Span128<T>.BlockSize;

        /// <summary>
        /// The size, in bytes, of a constituent block cell
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        public static readonly int CellSize = Span128<T>.CellSize;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<T>(ReadOnlySpan128<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static explicit operator ReadOnlySpan128<T>(Span<T> src)
            => new ReadOnlySpan128<T>(src);

        [MethodImpl(Inline)]
        public static explicit operator ReadOnlySpan128<T>(ReadOnlySpan<T> src)
            => new ReadOnlySpan128<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan128<T> (T[] src)
            => new ReadOnlySpan128<T>(src);

        [MethodImpl(Inline)]
        public static bool operator == (ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            => lhs.data == rhs.data;

        [MethodImpl(Inline)]
        public static bool operator != (ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs)
            => lhs.data != rhs.data;
        
        [MethodImpl(Inline)]
        public static bool aligned(int length)
            => Span128<T>.Aligned(length);

        [MethodImpl(Inline)]
        public static ReadOnlySpan128<T> Load(T[] src)
        {
            assert(aligned(src.Length));
            return new ReadOnlySpan128<T>(src);
        }

        [MethodImpl(Inline)]
        public static ReadOnlySpan128<T> Load(Span128<T> src)
            => new ReadOnlySpan128<T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan128<T> load(Span<T> src, int offset, int length)
        {
            assert(aligned(length));
            return new ReadOnlySpan128<T>(src.Slice(offset, length));
        }

        [MethodImpl(Inline)]
        public static ReadOnlySpan128<T> load(ReadOnlySpan<T> src, int offset, int length)
        {
            assert(aligned(length));
            return new ReadOnlySpan128<T>(src.Slice(offset, length));
        }

        [MethodImpl(Inline)]
        public static unsafe ReadOnlySpan128<T> load(void* src, int length)
        {
            assert(aligned(length));
            return new ReadOnlySpan128<T>(src,length);
        }

        ReadOnlySpan<T> data;

        [MethodImpl(Inline)]
        unsafe ReadOnlySpan128(void* src, int length)    
        {
            data = new ReadOnlySpan<T>(src, length);  
        }

        [MethodImpl(Inline)]
        ReadOnlySpan128(T[] src)
        {
            data = span(src);
        }
        
        
        [MethodImpl(Inline)]
        ReadOnlySpan128(ReadOnlySpan<T> src)
        {
            data = src;
        }

        [MethodImpl(Inline)]
        ReadOnlySpan128(Span128<T> src)
        {
            data = src.ToReadOnlySpan();
        }

        [MethodImpl(Inline)]
        ReadOnlySpan128(Span<T> src)
        {
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
        public ReadOnlySpan128<T> Block(int blockIndex)
            => new ReadOnlySpan128<T>(data.Slice(blockIndex * BlockLength, BlockLength));
        
        [MethodImpl(Inline)]
        public ReadOnlySpan128<T> Blocks(int blockIndex, int blockCount)
            => (ReadOnlySpan128<T>)Slice(blockIndex * BlockLength, blockCount * BlockLength );
            
        [MethodImpl(Inline)]
        public Span128<T> ToSpan128()
            => Span128.load(data);

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
            get => data.Length / BlockLength; 
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