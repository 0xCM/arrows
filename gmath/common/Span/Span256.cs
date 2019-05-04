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
    using static Span256;

    public static class Span256
    {
        /// <summary>
        /// Calculates the number of cells in a specified number of blocks
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static int cellcount<T>(int blocks = 1)
            where T : struct, IEquatable<T>        
                => Span256<T>.CellCount * blocks;

        /// <summary>
        /// Calculates the number of bytes required to represent a block constituent
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static int cellsize<T>()
            where T : struct, IEquatable<T>        
                => Span256<T>.CellSize;

        /// <summary>
        /// Calculates the number of bytes requred to represent a block
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static int blocksize<T>()
            where T : struct, IEquatable<T>        
                => cellsize<T>() * cellcount<T>();

        /// <summary>
        /// Calculates the number of bytes required to represent a specified
        /// number of blocks
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static int datasize<T>(int blocks)
            where T : struct, IEquatable<T>        
                => cellcount<T>(blocks) * cellsize<T>();


        /// <summary>
        /// Calculates the number blocks that can be covered by a specified number of bytes
        /// </summary>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static int blockcount<T>(int datasize)
            where T : struct, IEquatable<T>        
                => datasize / blocksize<T>();


        [MethodImpl(Inline)]
        public static int align<T>(int datasize)
            where T : struct, IEquatable<T>        
                => datasize - datasize % cellcount<T>();

        /// <summary>
        /// Determines whether data of a specified length can be evenly covered by blocks
        /// </summary>
        /// <param name="datasize">The length, in bytes, of the source data</param>
        /// <typeparam name="T">The block constituent type</typeparam>
        [MethodImpl(Inline)]
        public static bool aligned<T>(int datasize)
            where T : struct, IEquatable<T>        
            => datasize % blockcount<T>(datasize) == 0;

        [MethodImpl(Inline)]
        public static Span256<T> load<T>(Span<T> src)
            where T : struct, IEquatable<T>
                => new Span256<T>(src.Slice(0, align<T>(src.Length)));

        [MethodImpl(Inline)]
        public static Span256<T> load<T>(ReadOnlySpan<T> src)
            where T : struct, IEquatable<T>
                => new Span256<T>(src.Slice(0, align<T>(src.Length)));

        [MethodImpl(Inline)]
        public static Span256<T> load<T>(T[] src)
            where T : struct, IEquatable<T>
                => new Span256<T>(src, 0, align<T>(src.Length));

        [MethodImpl(Inline)]
        public static Span256<T> load<T>(T[] src, int offset, int len)
            where T : struct, IEquatable<T>
                => new Span256<T>(src, offset, len);

        [MethodImpl(Inline)]
        public static Span256<T> single<T>(params T[] src)
            where T : struct, IEquatable<T>
                => new Span256<T>(src);

    }

    /// <summary>
    /// A selective clone/wrapper of System.Span[T] where the the 
    /// encasulated data is always a multiple of 16 bytes = 128 bits
    /// </summary>
    public ref struct Span256<T>
        where T : struct, IEquatable<T>
    {
        /// <summary>
        /// The number of values per block
        /// </summary>
        public static readonly int CellCount = Vec256<T>.Length;

        /// <summary>
        /// The size, in bytes, of a block constituent
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        public static readonly int CellSize = Unsafe.SizeOf<T>();


        [MethodImpl(Inline)]
        public static implicit operator Span<T>(Span256<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static explicit operator Span256<T>(Span<T> src)
            => new Span256<T>(src);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<T> (Span256<T> src)
            => src.data;

        [MethodImpl(Inline)]
        public static implicit operator Span256<T> (T[] src)
            => new Span256<T>(src);

        [MethodImpl(Inline)]
        public static bool operator == (Span256<T> lhs, Span256<T> rhs)
            => lhs.data == rhs.data;

        [MethodImpl(Inline)]
        public static bool operator != (Span256<T> lhs, Span256<T> rhs)
            => lhs.data != rhs.data;
        
        static Exception unaligned(int actual)
            => new ArgumentException($"Length mismatch: {actual}");

        Span<T> data;

        [MethodImpl(Inline)]
        public unsafe Span256(void* src, int len)    
        {
            assert(aligned<T>(len));
            
            data = new Span<T>(src, len);  

        }

        [MethodImpl(Inline)]
        public Span256(T[] src)
        {
            assert(aligned<T>(src.Length));
            data = span(src);
        }

        [MethodImpl(Inline)]
        public Span256(T[] src, int offset,  int len)
        {
            assert(aligned<T>(len - offset));
            data = span(src, offset, len);
        }

        [MethodImpl(Inline)]
        public Span256(ReadOnlySpan<T> src)
        {
            assert(aligned<T>(src.Length));
            data = span<T>(src.Length);
            src.CopyTo(data);
        }

        [MethodImpl(Inline)]
        public Span256(T value, int len)
        {
            assert(aligned<T>(len));
            this.data = new Span<T>(new T[len]);
            this.data.Fill(value);
        }

        [MethodImpl(Inline)]
        public Span256(ref Span<T> src)
        {
            assert(aligned<T>(src.Length));         
            this.data = src;
        }

        [MethodImpl(Inline)]
        public Span256(ArraySegment<T> src)
        {
            assert(aligned<T>(src.Count));            
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
        public Span<T> Slice(Range range)
            => data.Slice(range);

        [MethodImpl(Inline)]
        public Span256<T> Block(int start)
        {
            assert(aligned<T>(start));
            return (Span256<T>)Slice(start);
        }

        [MethodImpl(Inline)]
        public Span256<T> Block(int start, int blocks)
        {
            assert(aligned<T>(start));
            return (Span256<T>)Slice(start, datasize<T>(blocks));
        }

            
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
        public Span256<S> As<S>()                
            where S : struct, IEquatable<S>
                => (Span256<S>)MemoryMarshal.Cast<T,S>(data);            
        

        public int Length 
        {
            [MethodImpl(Inline)]
            get => data.Length;
        }

        public int BlockCount 
        {
            [MethodImpl(Inline)]
            get => blockcount<T>(data.Length);
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