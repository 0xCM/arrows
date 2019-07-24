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
    using System.Runtime.Intrinsics;    
    using System.Diagnostics;
    
    
    using static zfunc;


    /// <summary>
    /// A System.Span[T] clone where the  encasulated data is always a multiple 
    /// of 16 bytes = 128 bits
    /// </summary>
    public ref struct Span256<T>
        where T : struct
    {
        /// <summary>
        /// The number of cells in the block
        /// </summary>
        public static readonly int BlockLength = Vector256<T>.Count;

        /// <summary>
        /// The size, in bytes, of a block 
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        /// <remarks>Should always be 16 irrespective of the cell type</remarks>
        public static readonly int BlockSize = Unsafe.SizeOf<T>() * BlockLength; 

        /// <summary>
        /// The size, in bytes, of a constituent block cell
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        public static readonly int CellSize = BlockSize / BlockLength;

        [MethodImpl(Inline)]
        public static implicit operator Span<T>(Span256<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<T> (Span256<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan256<T> (Span256<T> src)
            => Load(src);

        [MethodImpl(Inline)]
        public static bool operator == (Span256<T> lhs, Span256<T> rhs)
            => lhs.data == rhs.data;

        [MethodImpl(Inline)]
        public static bool operator != (Span256<T> lhs, Span256<T> rhs)
            => lhs.data != rhs.data;
        
        [MethodImpl(Inline)]
        public static bool Aligned(int length)
            => length % BlockLength == 0;
        
        [MethodImpl(Inline)]
        public static Span256<T> Alloc(int blocks)
            => new Span256<T>(new T[blocks * BlockLength]);
    
        [MethodImpl(Inline)]
        public static Span256<T> Load(T[] src)
        {
            require(Aligned(src.Length));
            return new Span256<T>(src);
        }

        [MethodImpl(Inline)]
        public static ReadOnlySpan256<T> Load(ReadOnlySpan<T> src, int offset = 0)
        {
            require(Aligned(src.Length - offset));
            return ReadOnlySpan256<T>.Load(src, offset);
        }

        [MethodImpl(Inline)]
        public static ReadOnlySpan256<T> Load(Span256<T> src)
            => ReadOnlySpan256<T>.Load(src);

        [MethodImpl(Inline)]
        public static Span256<T> Load(Span<T> src, int offset = 0)
        {
            require(Aligned(src.Length - offset));
            var slice = src.Slice(offset);
            return new Span256<T>(ref slice);
        }

        [MethodImpl(Inline)]
        public static unsafe Span256<T> Load(void* src, int length)
        {
            require(Aligned(length));
            return new Span256<T>(src,length);
        }

        [MethodImpl(Inline)]
        public static Span256<T> Load(ref T head, int length)
        {
            require(Aligned(length));
            return new Span256<T>(ref head, length);
        }

        Span<T> data;

        [MethodImpl(Inline)]
        unsafe Span256(void* src, int length)    
        {
            data = new Span<T>(src, length);  
        }

        [MethodImpl(Inline)]
        Span256(T[] src)
        {
            data = src;
        }
                
        [MethodImpl(Inline)]
        Span256(ReadOnlySpan<T> src)
        {
            data = src.ToArray();
        }

        [MethodImpl(Inline)]
        Span256(ref Span<T> src)
        {
            this.data = src;
        }

        [MethodImpl(Inline)]
        Span256(ref T head, int len)
        {
            this.data = MemoryMarshal.CreateSpan(ref head, len);
        }

        public ref T this[int ix] 
        {
            [MethodImpl(Inline)]
            get => ref data[ix];
        }

        [MethodImpl(Inline)]
        public ref T Block(int blockIndex)
            => ref this[blockIndex*BlockLength];

        [MethodImpl(Inline)]
        public Span<T> Slice(int start)
            => data.Slice(start);

        [MethodImpl(Inline)]
        public Span<T> Slice(int start, int length)
            => data.Slice(start,length);

        [MethodImpl(Inline)]
        public Span256<T> SliceBlock(int blockIndex)
        {
            var slice = data.Slice(blockIndex * BlockLength, BlockLength); 
            return new Span256<T>(ref slice);
        }
            
        [MethodImpl(Inline)]
        public Span256<T> Blocks(int blockIndex, int blockCount)
            => Span256.load(Slice(blockIndex * BlockLength, blockCount * BlockLength));
            
        [MethodImpl(Inline)]
        public Span<T> Unblock()
            => data;

        [MethodImpl(Inline)]
        public ReadOnlySpan256<T> ToReadOnlySpan()
            => (ReadOnlySpan256<T>)data;

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
        public Span256<S> As<S>()                
            where S : struct
                => Span256.load(MemoryMarshal.Cast<T,S>(data));                    
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

        public int BlockWidth
        {
            [MethodImpl(Inline)]
            get => BlockLength;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => data.IsEmpty;
        }

        [MethodImpl(Inline)]
        public Span<T> ToSpan()
            => data;

        public override bool Equals(object rhs) 
            => throw new NotSupportedException();

        public override int GetHashCode() 
            => throw new NotSupportedException();        
        
    }
}