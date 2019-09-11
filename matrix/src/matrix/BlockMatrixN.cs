//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    
    using static nfunc;
    using static zfunc;

    /// <summary>
    /// Defines a primal square matrix of natural order
    /// </summary>
    /// <typeparam name="N">The order type</typeparam>
    /// <typeparam name="T">The primal type</typeparam>
    public ref struct BlockMatrix<N,T>
        where N : ITypeNat, new()
        where T : struct    
    {        
        Span256<T> data;

        public static readonly Dim<N,N> Dim = default;        

        /// <summary>
        /// The number of rows in the structure
        /// </summary>
        public static readonly int RowCount = nati<N>();

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

        /// <summary>
        /// The size, in bytes, of each cell
        /// </summary>
        public static readonly ByteSize CellSize = Span256<T>.CellSize;

        static readonly int AlignedRowLength = Span256<T>.BlockLength;

        /// <summary>
        /// The Row dimension representative
        /// </summary>
        public static N RowRep = default;

        /// <summary>
        /// The Column dimension representative
        /// </summary>
        public static N ColRep = default;

        [MethodImpl(Inline)]
        public static implicit operator BlockMatrix<N,T>(Span256<T> src)
            => new BlockMatrix<N,T>(src);

        [MethodImpl(Inline)]
        public static implicit operator BlockMatrix<N,T>(BlockMatrix<N,N,T> src)
            => new BlockMatrix<N,T>(src);

        [MethodImpl(Inline)]
        public static implicit operator BlockMatrix<N,N,T>(BlockMatrix<N,T> src)
            => src.ToRectantular();

        [MethodImpl(Inline)]
        public static implicit operator Span<N,T>(BlockMatrix<N,T> src)
            => src.Natural;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<T>(BlockMatrix<N,T> src)
            => src.Unsized;

        [MethodImpl(Inline)]
        public static implicit operator Span256<T>(BlockMatrix<N,T> src)
            => src.Unsized;

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan256<T>(BlockMatrix<N,T> src)
            => src.Unsized;

        [MethodImpl(Inline)]
        public static bool operator == (BlockMatrix<N,T> lhs, in BlockMatrix<N,T> rhs) 
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator != (BlockMatrix<N,T> lhs, in BlockMatrix<N,T> rhs) 
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public BlockMatrix(Span256<T> src)
        {
            require(src.Length >= CellCount);
            data = src;
        }
        
        [MethodImpl(Inline)]        
        public ref T Cell(int r, int c)
            => ref data[RowLenth*r + c];

        public ref T this[int r, int c]
        {
            [MethodImpl(Inline)]        
            get => ref Cell(r,c);
        }

        public ref T this[uint r, uint c]
        {
            [MethodImpl(Inline)]        
            get => ref Cell((int)r,(int)c);
        }

        [MethodImpl(Inline)]
        public BlockVector<N,T> Row(int row)
        {
            if(row < 0 || row >= RowCount)
                throw Errors.OutOfRange(row, 0, RowCount - 1);
            
            return BlockVector.Load<N,T>(data.Slice(row * RowLenth, RowLenth));
        }

        [MethodImpl(Inline)]
        public ref BlockVector<N,T> Row(int row, ref BlockVector<N,T> dst)
        {
            if(row < 0 || row >= RowCount)
                throw Errors.OutOfRange(row, 0, RowCount - 1);
             var src = data.Slice(row * RowLenth, RowLenth);
             src.CopyTo(dst.Unsized);
             return ref dst;
        }

        public ref BlockVector<N,T> Col(int col, ref BlockVector<N,T> dst)
        {
            if(col < 0 || col >= ColCount)
                throw Errors.OutOfRange(col, 0, ColCount - 1);
            
            for(var row = 0; row < ColLength; row++)
                dst[row] = data[row*RowLenth + col];
            return ref dst;
        }

        [MethodImpl(Inline)]
        public BlockVector<N,T> Col(int col)
        {
            var alloc = BlockVector.Alloc<N,T>();
            return Col(col, ref alloc);
        }

        /// <summary>
        /// Provides access to the underlying data as a linear unblocked span
        /// </summary>
        public Span<T> Unblocked
        {            
            [MethodImpl(Inline)]
            get => data;
        }

        /// <summary>
        /// Provides access to the underlying data as a 256-bit blocked span
        /// </summary>
        public Span256<T> Unsized
        {            
            [MethodImpl(Inline)]
            get => data;
        }

        /// <summary>
        /// Provides access to the underlying data as a span of natural dimensions
        /// </summary>
        public Span<N,T> Natural
        {
            [MethodImpl(Inline)]
            get => data;
        }

        /// <summary>
        /// Applies a function to each cell and overwites the existing cell value with the result
        /// </summary>
        /// <param name="f">The function to apply</param>
        public void Apply(Func<T,T> f)
        {
            for(var r = 0; r < RowCount; r++)
            for(var c = 0; c < ColCount; c++)
                this[r,c] = f(this[r,c]);
        }

        public bool IsZero
        {
            get
            {
                for(var i = 0; i < data.Length; i++)
                    if(gmath.nonzero(data[i]))
                        return false;
                return true;
            }
        }

        public bool Equals(BlockMatrix<N,T> rhs)
        {
            for(var r = 0; r < (int)RowCount; r ++)
            for(var c = 0; c < (int)ColCount; c ++)
                if(!gmath.eq(this[r,c], rhs[r,c]))
                    return false;
            return true;
        }

        /// <summary>
        /// Returns the first cell value, if any, that satisfies a supplied predicate
        /// </summary>
        /// <param name="f">The predicate</param>
        /// <param name="pos">The cell position where the match was found</param>
        public Option<T> First(Func<T,bool> f, out (int i, int j) pos)
        {
            pos = (0,0);
            for(var r = 0; r < (int)RowCount; r ++)
            for(var c = 0; c < (int)ColCount; c ++)
            {                
                if(f(this[r,c]))
                {
                    pos = (r,c);
                    return this[r,c];
                }
            }
            return default;            
        }

        public Option<T> First(Func<T,bool> f)
        {
            for(var r = 0; r < (int)RowCount; r ++)
            for(var c = 0; c < (int)ColCount; c ++)
                if(f(this[r,c]))
                    return this[r,c];
            return default;            
        }

        [MethodImpl(Inline)]
        public BlockMatrix<N,N,T> ToRectantular()
            => new BlockMatrix<N,N,T>(this.data);

        [MethodImpl(Inline)]
        public ref BlockMatrix<N,T> CopyTo(ref BlockMatrix<N,T> dst)
        {
            Unblocked.CopyTo(dst.Unblocked);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public BlockMatrix<N,U> Convert<U>()
            where U : struct
               => new BlockMatrix<N,U>(convert<T,U>(data));

        [MethodImpl(Inline)]
        public BlockMatrix<N,U> As<U>()
            where U : struct
                => new BlockMatrix<N,U>(data.As<U>());

        /// <summary>
        /// Creates a copy of the matrix
        /// </summary>
        [MethodImpl(Inline)]
        public BlockMatrix<N,T> Replicate(bool structureOnly = false)
            => new BlockMatrix<N,T>(data.ReadOnly().Replicate(structureOnly));

        public override bool Equals(object other)
            => throw new NotSupportedException();
 
        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}
