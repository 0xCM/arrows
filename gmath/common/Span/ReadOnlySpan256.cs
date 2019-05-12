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
    
    using static mfunc;

    /// <summary>
    /// A System.Span[T] clone where the  encasulated data is always a multiple 
    /// of 16 bytes = 256 bits
    /// </summary>
    public ref struct ReadOnlySpan256<T>
        where T : struct, IEquatable<T>
    {
        /// <summary>
        /// The number of cells in the block
        /// </summary>
        public static readonly int BlockLength = Span256<T>.BlockLength;

        /// <summary>
        /// The size, in bytes, of a block 
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        /// <remarks>Should always be 16 irrespective of the cell type</remarks>
        public static readonly int BlockSize = Span256<T>.BlockSize;

        /// <summary>
        /// The size, in bytes, of a constituent block cell
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        public static readonly int CellSize = Span256<T>.CellSize;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<T>(ReadOnlySpan256<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static explicit operator ReadOnlySpan256<T>(Span<T> src)
            => new ReadOnlySpan256<T>(src);

        [MethodImpl(Inline)]
        public static explicit operator ReadOnlySpan256<T>(ReadOnlySpan<T> src)
            => new ReadOnlySpan256<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan256<T> (T[] src)
            => new ReadOnlySpan256<T>(src);

        [MethodImpl(Inline)]
        public static bool operator == (ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
            => lhs.data == rhs.data;

        [MethodImpl(Inline)]
        public static bool operator != (ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs)
            => lhs.data != rhs.data;
        
        [MethodImpl(Inline)]
        public static bool Aligned(int length)
            => Span256<T>.Aligned(length);

        [MethodImpl(Inline)]
        public static ReadOnlySpan256<T> Load(T[] src)
        {
            assert(Aligned(src.Length));
            return new ReadOnlySpan256<T>(src);
        }

        [MethodImpl(Inline)]
        public static ReadOnlySpan256<T> Load(Span256<T> src)
            => new ReadOnlySpan256<T>(src);


        [MethodImpl(Inline)]
        public static ReadOnlySpan256<T> Load(Span<T> src, int offset, int length)
        {
            assert(Aligned(length));
            return new ReadOnlySpan256<T>(src.Slice(offset, length));
        }

        [MethodImpl(Inline)]
        public static ReadOnlySpan256<T> Load(ReadOnlySpan<T> src, int offset, int length)
        {
            assert(Aligned(length));
            return new ReadOnlySpan256<T>(src.Slice(offset, length));
        }

        [MethodImpl(Inline)]
        public static unsafe ReadOnlySpan256<T> Load(void* src, int length)
        {
            assert(Aligned(length));
            return new ReadOnlySpan256<T>(src,length);
        }

        ReadOnlySpan<T> data;

        [MethodImpl(Inline)]
        unsafe ReadOnlySpan256(void* src, int length)    
        {
            data = new ReadOnlySpan<T>(src, length);  
        }

        [MethodImpl(Inline)]
        ReadOnlySpan256(T[] src)
            => data = span(src);
        
        
        [MethodImpl(Inline)]
        ReadOnlySpan256(ReadOnlySpan<T> src)
            => data = src;

        [MethodImpl(Inline)]
        ReadOnlySpan256(Span<T> src)        
            => this.data = src;
        
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
        public ReadOnlySpan256<T> Block(int blockIndex)
            => new ReadOnlySpan256<T>(data.Slice(blockIndex * BlockLength, BlockLength));
        
        [MethodImpl(Inline)]
        public ReadOnlySpan256<T> Blocks(int blockIndex, int blockCount)
            => (ReadOnlySpan256<T>)Slice(blockIndex * BlockLength, blockCount * BlockLength );
            
        [MethodImpl(Inline)]
        public Span256<T> ToSpan256()
            => Span256.load(data);

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
        public ReadOnlySpan256<S> As<S>()                
            where S : struct, IEquatable<S>
                => (ReadOnlySpan256<S>)MemoryMarshal.Cast<T,S>(data);                    
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