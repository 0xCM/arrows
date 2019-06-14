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
    public ref struct ReadOnlySpan<M,N,T>
        where M : ITypeNat, new()        
        where N : ITypeNat, new()
    {
        ReadOnlySpan<T> data;


        public static readonly Dim<M,N> Dim = default;    

        /// <summary>
        /// The number of rows in the structure
        /// </summary>
        public static readonly int RowCount = nati<M>();

        /// <summary>
        /// The number of columns in the structure
        /// </summary>
        public static readonly int ColCount = nati<N>();

        /// <summary>
        /// The number of cells in each row
        /// </summary>
        public static readonly int RowLenth = ColCount;

        /// <summary>
        /// The number of cells in each column
        /// </summary>
        public static readonly int ColLength = RowCount;

        /// <summary>
        /// The total number of allocated elements
        /// </summary>
        public static readonly int CellCount = RowLenth * ColLength;

        public static implicit operator ReadOnlySpan<T> (ReadOnlySpan<M,N,T> src)
            => src.data;
    
        public static bool operator == (ReadOnlySpan<M,N,T> lhs, ReadOnlySpan<M,N,T> rhs)
            => lhs.data == rhs.data;

        public static bool operator != (ReadOnlySpan<M,N,T> lhs, ReadOnlySpan<M,N,T> rhs)
            => lhs.data != rhs.data;
            
        [MethodImpl(Inline)]
        public ReadOnlySpan(ref T src)
            => data = MemoryMarshal.CreateReadOnlySpan(ref src, CellCount);

        [MethodImpl(Inline)]
        public ReadOnlySpan(ref ReadOnlySpan<T> src)
        {
            require(src.Length == CellCount, $"length(src) = {src.Length} != {CellCount} = SpanLength");         
            this.data = src;
        }

        [MethodImpl(Inline)]
        public ReadOnlySpan(ReadOnlySpan<T> src)
        {
            require(src.Length == CellCount, $"length(src) = {src.Length} != {CellCount} = SpanLength");         
            this.data = src;
        }


        public ref readonly T this[int ix] 
        {
            [MethodImpl(Inline)]
            get => ref data[ix];
        }

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

        
        public int Length 
            => CellCount;
            
        public bool IsEmpty
            => data.IsEmpty;

        public override bool Equals(object rhs) 
            => throw new NotSupportedException();

        public override int GetHashCode() 
            => throw new NotSupportedException();        
    }
}