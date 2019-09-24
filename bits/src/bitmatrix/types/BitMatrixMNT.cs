//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    /// <summary>
    /// Defines bitmatrix of natural dimensions over a primal type
    /// </summary>
    /// <typeparam name="M">The row dimension</typeparam>
    /// <typeparam name="N">The column dimension</typeparam>
    /// <typeparam name="T">The element type</typeparam>
    public ref struct BitMatrix<M,N,T> 
        where M : ITypeNat, new()        
        where N : ITypeNat, new()
        where T : unmanaged
    {        
        Span<T> data;

        /// <summary>
        /// The row count representative
        /// </summary>
        public static readonly M I = default;

        /// <summary>
        /// The col count representative
        /// </summary>
        public static readonly N J = default;

        /// <summary>
        /// The number of bits per row
        /// </summary>
        public static readonly BitSize RowBitCount = I.value;        

        /// <summary>
        /// The number of bits per column
        /// </summary>
        public static readonly BitSize ColBitCount = J.value;

        /// <summary>
        /// The number of bits apprehended by the matrix
        /// </summary>
        public static readonly BitSize TotalBitCount = RowBitCount * ColBitCount;
                        
        /// <summary>
        /// The (aligned) number of bytes needed for a row
        /// </summary>
        public static readonly ByteSize RowByteCount = (ByteSize)RowBitCount;                        

        /// <summary>
        /// The (aligned) number of bytes needed for a column
        /// </summary>
        public static readonly ByteSize ColByteCount = (ByteSize)ColBitCount;

        /// <summary>
        /// The number of bits a cell is capable of storing
        /// </summary>
        static readonly BitSize CellBitSize = Unsafe.SizeOf<T>()*8;

        static readonly GridSpec<T> GridSpec = (CellBitSize, RowBitCount, ColBitCount);
        
        public static readonly GridLayout<T> Layout = GridSpec.CalcLayout();

        /// <summary>
        /// Allocates a Zero-filled mxn matrix
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix<M,N,T> Alloc()
            => new BitMatrix<M, N, T>(new T[Layout.TotalCellCount]);

        /// <summary>
        /// Loads a matrix from an array of appopriate length
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix<M,N,T> Load(T[] src)
        {
            require(src.Length == Layout.TotalCellCount);
            return new BitMatrix<M, N, T>(src);
        }

        /// <summary>
        /// Loads a matrix from an array of appopriate length
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix<M,N,T> Load(Span<T> src)
        {
            require(src.Length == Layout.TotalCellCount);
            return new BitMatrix<M, N, T>(src);
        }

        /// <summary>
        /// Allocates a One-filled mxn matrix
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix<M,N,T> Ones()
        {
            var dst = Alloc();
            var data = dst.data;
            var length = BitSize.Size<T>();    
            for(var i = 0; i< data.Length; i++)
            for(var j = 0; j< length; j++)
                gbits.enable(ref data[i], j);
            return dst;
        }

        /// <summary>
        /// Computes the bitwise XOR between the operands
        /// </summary>
        /// <param name="lhs">The left matrix</param>
        /// <param name="rhs">The right matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix<M,N,T> operator ^(BitMatrix<M,N,T> lhs, BitMatrix<M,N,T> rhs)
            => XOr(ref lhs, rhs);

        /// <summary>
        /// Computes the bitwise AND between the operands
        /// </summary>
        /// <param name="lhs">The left matrix</param>
        /// <param name="rhs">The right matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix<M,N,T> operator &(BitMatrix<M,N,T> lhs, BitMatrix<M,N,T> rhs)
            => And(ref lhs, rhs);

        /// <summary>
        /// Negates the operand via complemnt
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix<M,N,T> operator -(BitMatrix<M,N,T> src)
            => Flip(ref src);

        [MethodImpl(Inline)]
        BitMatrix(T[] src)
        {
            this.data = src;
        }

        [MethodImpl(Inline)]
        BitMatrix(Span<T> src)
        {
            this.data = src;
        }


        /// <summary>
        /// Gets the the value of bit identified by row/col indices
        /// </summary>
        /// <param name="row">The zero-based row index</param>
        /// <param name="col">The zero-based col index</param>
        [MethodImpl(Inline)]
        public Bit GetBit(int row, int col)
        {
            var cell = Layout.Row(row)[col];
            return gbits.test(in Data[cell.Segment], cell.Offset);                    
        }

        /// <summary>
        /// Sets the the value of bit identified by row/col indices
        /// </summary>
        /// <param name="row">The zero-based row index</param>
        /// <param name="col">The zero-based col index</param>
        [MethodImpl(Inline)]
        public void SetBit(int row, int col, Bit value)
        {
            var cell = Layout.Row(row)[col];
            gbits.set(ref data[cell.Segment], cell.Offset, value);
        }

        /// <summary>
        /// Queries/manipulates a bit at a specified row/col
        /// </summary>
        public Bit this[int row, int col]
        {
            [MethodImpl(Inline)]
            get => GetBit(row, col);

            [MethodImpl(Inline)]
            set => SetBit(row, col, value);
        }            

        /// <summary>
        /// Queries mainpulates a row
        /// </summary>
        public BitVector<N,T> this[int row]
        {
            [MethodImpl(Inline)]
            get => RowVector(row);
            
            [MethodImpl(Inline)]
            set => RowVector(row,value);
        }

        /// <summary>
        /// The number of rows in the matrix
        /// </summary>
        public readonly int RowCount
        {
            [MethodImpl(Inline)]
            get => Layout.RowCount;
        }

        /// <summary>
        /// The number of columns in the matrix
        /// </summary>
        public readonly int ColCount
        {
            [MethodImpl(Inline)]
            get => Layout.ColCount;
        }

        /// <summary>
        /// Presents matrix storage as a bytespan
        /// </summary>
        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => data.AsBytes();
        }

        /// <summary>
        /// Presents matrix storage as a span of generic cells
        /// </summary>
        public Span<T> Data
        {
            [MethodImpl(Inline)]
            get => data;
        }
        
        [MethodImpl(Inline)]
        readonly int RowOffset(int row)        
            => Layout.Row(row)[0].Segment;
                
        [MethodImpl(Inline)]
        Span<T> RowData(int row)
            => data.Slice(RowOffset(row), Layout.RowCellCount);

        [MethodImpl(Inline)]
        void SetRow(int row, Span<T> data)
            => data.CopyTo(data.Slice(RowOffset(row), Layout.RowCellCount));     

        /// <summary>
        /// Replaces an index-identied column of data with the content of a row vector
        /// </summary>
        /// <param name="col">The column index</param>
        [MethodImpl(Inline)]
        public void RowVector(int row, BitVector<N,T> src)
            => src.Data.CopyTo(Data.Slice(RowOffset(row), Layout.RowCellCount));     

        /// <summary>
        /// Retrives an identified row of bits
        /// </summary>
        /// <param name="index">The 0-based row index</param>
        [MethodImpl(Inline)]
        public BitVector<N,T> RowVector(int index)                    
            => BitVector<N,T>.Load(RowData(index));                

        [MethodImpl(Inline)]
        public readonly BitVector<N,T> CopyRow(int index)                    
            => BitVector<N,T>.Load(data.Slice(RowOffset(index), Layout.RowCellCount).Replicate());

        /// <summary>
        /// Replaces an index-identied column of data with the content of a column vector
        /// </summary>
        /// <param name="col">The column index</param>
        [MethodImpl(Inline)]
        public void SetCol(int col, BitVector<M,T> src)
        {
            for(var row=0; row < RowCount; row++)
                this[row,col] = src[row];
        }

        /// <summary>
        /// Retrieves an index-identied column of data presented as a bitvector
        /// </summary>
        /// <param name="col">The column index</param>
        [MethodImpl(Inline)]
        public BitVector<M,T> GetCol(int col)
        {
            var cv = default(BitVector<M,T>);
            for(var row=0; row < RowCount; row++)
                cv[row] = this[row, col];
            return cv;
        }

        /// <summary>
        /// Sets all the bits to align with the source value
        /// </summary>
        /// <param name="value">The source value</param>
        [MethodImpl(Inline)]
        public void Fill(Bit value)
        {
            var primal = PrimalInfo.Get<T>();
            if(value)
                Data.Fill(primal.MaxVal);
            else
                Data.Fill(primal.Zero);
        }

        /// <summary>
        /// The world's most inefficient bitmatrix transpose
        /// </summary>
        public readonly BitMatrix<N,M,T> Transpose()
        {
            var dst = BitMatrix.Alloc<N,M,T>();
            for(var row = 0; row < RowCount; row++)
                dst.SetCol(row, CopyRow(row));            
            return dst;
        }

        /// <summary>
        /// Extracts the bits that comprise the matrix in row-major order
        /// </summary>
        [MethodImpl(Inline)]
        public Span<byte> Unpack()
            => Bytes.Unpack();

        [MethodImpl(Inline)]
        public string Format()
        {
            var sb = sbuild();
            for(var i=0; i< RowCount; i++)
                 sb.AppendLine(RowVector(i).FormatBits());
            return sb.ToString();
        }

        public bool Equals(BitMatrix<M,N,T> rhs)        
        {
            var eq = gmath.eq<T>(Data, rhs.Data);
            for(var i = 0; i< eq.Length; i++)
                if(!eq[i])
                    return false;
            return true;
        }

        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode()
            => 0;

        static ref BitMatrix<M,N,T> XOr(ref BitMatrix<M,N,T> lhs, in BitMatrix<M,N,T> rhs)        
        {
            gbitspan.xor(lhs.Data, rhs.Data, lhs.Data);
            return ref lhs;
        }

        static ref BitMatrix<M,N,T> And(ref BitMatrix<M,N,T> lhs, in BitMatrix<M,N,T> rhs)        
        {
            gbitspan.and(lhs.Data, rhs.Data, lhs.Data);
            return ref lhs;
        }

        static ref BitMatrix<M,N,T> Flip(ref BitMatrix<M,N,T> src)        
        {
            gbitspan.flip(src.Data);
            return ref src;
        }

        static ref BitMatrix<M,N,T> Or(ref BitMatrix<M,N,T> lhs, in BitMatrix<M,N,T> rhs)        
        {
            gbitspan.or(lhs.Data, rhs.Data, lhs.Data);
            return ref lhs;
        }

    }
}