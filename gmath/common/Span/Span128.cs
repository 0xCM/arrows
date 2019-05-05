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
    using static inxfunc;

    /// <summary>
    /// A System.Span[T] clone where the  encasulated data is always a multiple 
    /// of 16 bytes = 128 bits
    /// </summary>
    public ref struct Span128<T>
        where T : struct, IEquatable<T>
    {
        [MethodImpl(Inline)]
        public static implicit operator Span<T>(Span128<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static explicit operator Span128<T>(Span<T> src)
            => new Span128<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<T> (Span128<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator Span128<T> (T[] src)
            => new Span128<T>(src);

        [MethodImpl(Inline)]
        public static bool operator == (Span128<T> lhs, Span128<T> rhs)
            => lhs.data == rhs.data;

        [MethodImpl(Inline)]
        public static bool operator != (Span128<T> lhs, Span128<T> rhs)
            => lhs.data != rhs.data;
        
        public static readonly int BlockLength = Vec128<T>.Length;

        /// <summary>
        /// The size, in bytes, of a block 
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        public static readonly int BlockSize = 16;

        /// <summary>
        /// The size, in bytes, of a block constituent
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        public static readonly int CellSize = BlockSize / BlockLength;

        Span<T> data;

        [MethodImpl(Inline)]
        public unsafe Span128(void* src, int len)    
        {
            //assert(aligned<T>(len));            
            data = new Span<T>(src, len);  
        }

        [MethodImpl(Inline)]
        public Span128(T[] src)
        {
            assert(src.Length % BlockLength == 0);
            data = span(src);
        }

        [MethodImpl(Inline)]
        public Span128(ReadOnlySpan<T> src)
        {
            assert(src.Length % BlockLength == 0);
            data = span<T>(src.Length);
            src.CopyTo(data);
        }

        [MethodImpl(Inline)]
        public Span128(Span<T> src)
        {
            assert(src.Length % BlockLength == 0);
            this.data = src;
        }

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

        public Span<T> this[Range range]
        {
            [MethodImpl(Inline)]
            get => data[range];
        }

        [MethodImpl(Inline)]
        public Span<T> Slice(int start)
            => data.Slice(start);

        [MethodImpl(Inline)]
        public Span<T> Slice(int start, int length)
            => data.Slice(start,length);

        [MethodImpl(Inline)]
        public Span128<T> Block(int blockIndex)
            => new Span128<T>(data.Slice(blockIndex * BlockLength, BlockLength));
        
        [MethodImpl(Inline)]
        public Span128<T> Blocks(int blockIndex, int blockCount)
            => (Span128<T>)Slice(blockIndex * BlockLength, blockCount * BlockLength );
            
        [MethodImpl(Inline)]
        public Span<T> ToSpan()
            => data;

        [MethodImpl(Inline)]
        public ReadOnlySpan<T> ToReadOnlySpan()
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
        public ref T GetPinnableReference()
            => ref data.GetPinnableReference();

        [MethodImpl(Inline)]
        public void CopyTo (Span<T> dst)
            => data.CopyTo(dst);

        [MethodImpl(Inline)]
        public bool TryCopyTo (Span<T> dst)
            => data.TryCopyTo(dst);
                
        [MethodImpl(Inline)]
        public Span128<S> As<S>()                
            where S : struct, IEquatable<S>
                => (Span128<S>)MemoryMarshal.Cast<T,S>(data);            
        
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