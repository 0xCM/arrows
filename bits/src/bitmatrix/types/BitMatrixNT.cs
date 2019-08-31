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
    /// Defines a square bitmatrix of natural order over a primal type
    /// </summary>
    /// <typeparam name="N">The matrix order</typeparam>
    /// <typeparam name="T">The element type</typeparam>
    public struct BitMatrix<N,T> : IEquatable<BitMatrix<N,T>>
        where N : ITypeNat, new()
        where T : struct
    {        
        Memory<T> data;

        /// <summary>
        /// Specifies the MxN matrix dimension
        /// </summary>
        static readonly Dim<N,N> Dim = default;

        static readonly GridSpec<T> GridSpec = (SizeOf<T>.BitSize, (int)Dim.I, (int)Dim.J);
        
        public static readonly GridLayout<T> GridLayout = GridSpec.CalcLayout();

        public static readonly BitMatrix<N,T> Identity = CreateIdentity();

        public static readonly BitMatrix<N,T> Ones = CreateOnes();

        /// <summary>
        /// Allocates a Zero-filled NxN matrix
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix<N,T> Alloc()
            => new BitMatrix<N, T>(new Memory<T>(new T[GridLayout.TotalCellCount]));

        /// <summary>
        /// Multiplies the left matrix by the right
        /// </summary>
        /// <param name="lhs">The left matrix</param>
        /// <param name="rhs">The right matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix<N,T> operator *(BitMatrix<N,T> lhs, BitMatrix<N,T> rhs)
            => Mul(ref lhs, rhs);

        /// <summary>
        /// Adds the left matrix to the right using bitwise semantics
        /// </summary>
        /// <param name="lhs">The left matrix</param>
        /// <param name="rhs">The right matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix<N,T> operator ^(BitMatrix<N,T> lhs, BitMatrix<N,T> rhs)
            => XOr(ref lhs, rhs);

        [MethodImpl(Inline)]
        public static BitMatrix<N,T> operator &(BitMatrix<N,T> lhs, BitMatrix<N,T> rhs)
            => And(ref lhs, rhs);

        [MethodImpl(Inline)]
        public static BitMatrix<N,T> operator |(BitMatrix<N,T> lhs, BitMatrix<N,T> rhs)
            => Or(ref lhs, rhs);

        [MethodImpl(Inline)]
        public static BitMatrix<N,T> operator -(BitMatrix<N,T> src)
            => Flip(ref src);

        [MethodImpl(Inline)]
        public static bool operator ==(BitMatrix<N,T> lhs, BitMatrix<N,T> rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(BitMatrix<N,T> lhs, BitMatrix<N,T> rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public BitMatrix(Memory<T> src)
        {
            require(src.Length == GridLayout.TotalCellCount, 
                $"A span of length {src.Length} was provided which differs from the required segment count of {GridLayout.TotalCellCount}");
            this.data = src;
        }

        [MethodImpl(Inline)]
        public BitMatrix(ReadOnlySpan<T> src)
            : this(src.ToArray().ToMemory())
        {
        }

        [MethodImpl(Inline)]
        readonly Bit GetBit(int row, int col)
        {
            var cell = GridLayout.Row(row)[col];
            return gbits.test(in Bits[cell.Segment], cell.Offset);                    
        }

        [MethodImpl(Inline)]
        void SetBit(int row, int col, Bit value)
        {
            var cell = GridLayout.Row(row)[col];
            gbits.set(ref Bits[cell.Segment], cell.Offset, value);
        }

        public Bit this[int row, int col]
        {
            [MethodImpl(Inline)]
            get => GetBit(row, col);

            [MethodImpl(Inline)]
            set => SetBit(row, col, value);
        }            

        /// <summary>
        /// The number of rows in the matrix
        /// </summary>
        public readonly int RowCount
        {
            [MethodImpl(Inline)]
            get => GridLayout.RowCount;
        }

        /// <summary>
        /// The (padded) length of a primal span/array required to store a row of grid data.
        /// </summary>
        public readonly int RowSegCount
        {
            [MethodImpl(Inline)]
            get => GridLayout.RowCellCount;
        }
        
        /// <summary>
        /// The number of columns in the matrix
        /// </summary>
        public readonly int ColCount
        {
            [MethodImpl(Inline)]
            get => GridLayout.ColCount;
        }

        /// <summary>
        /// Provides direct access to the underlying bitstore
        /// </summary>
        public readonly Span<T> Bits
        {
            [MethodImpl(Inline)]
            get => data.Span;
        }
        
        [MethodImpl(Inline)]
        readonly int RowOffset(int row)        
            => GridLayout.Row(row)[0].Segment;
                
        [MethodImpl(Inline)]
        readonly Memory<T> RowData(int row)
            => data.Slice(RowOffset(row), GridLayout.RowCellCount);

        [MethodImpl(Inline)]
        void ReplaceRow(int row, Memory<T> data)
            => data.CopyTo(this.data.Slice(RowOffset(row), GridLayout.RowCellCount));     

        /// <summary>
        /// Replaces an index-identied column of data with the content of a row vector
        /// </summary>
        /// <param name="col">The column index</param>
        [MethodImpl(Inline)]
        public readonly void RowVector(int row, BitVector<N,T> src)
            => src.Bits.CopyTo(Bits.Slice(RowOffset(row), GridLayout.RowCellCount));     

        /// <summary>
        /// Retrives an identified row of bits
        /// </summary>
        /// <param name="index">The 0-based row index</param>
        [MethodImpl(Inline)]
        public readonly BitVector<N,T> RowVector(int index)                    
            => new BitVector<N,T>(RowData(index));                

        public readonly BitVector<N,T> Diagonal()
        {
            var dst = BitVector.Alloc<N,T>();
            for(var i=0; i<RowCount; i++)
                dst[i] = GetBit(i,i);
            return dst;
        }

        /// <summary>
        /// Queries/Specifies a row
        /// </summary>
        public BitVector<N,T> this[int row]
        {
            [MethodImpl(Inline)]
            get => RowVector(row);
            
            [MethodImpl(Inline)]
            set => RowVector(row,value);
        }

        /// <summary>
        /// Replaces an index-identied column of data with the content of a column vector
        /// </summary>
        /// <param name="col">The column index</param>
        [MethodImpl(Inline)]
        public void SetCol(int col, BitVector<N,T> src)
        {
            for(var row=0; row < RowCount; row++)
                this[row,col] = src[row];
        }

        /// <summary>
        /// Retrieves an index-identied column of data presented as a bitvector
        /// </summary>
        /// <param name="col">The column index</param>
        [MethodImpl(Inline)]
        public BitVector<N,T> GetCol(int col)
        {
            var cv = default(BitVector<N,T>);
            for(var row=0; row < RowCount; row++)
                cv[row] = this[row, col];
            return cv;
        }

        /// <summary>
        /// Extracts the bits that comprise the matrix in row-major order
        /// </summary>
        [MethodImpl(Inline)]
        public Span<Bit> Unpack()
            => Bits.AsBytes().Unpack(out Span<Bit> dst).Slice(0, (int)Dim.Volume);

        /// <summary>
        /// Sets all the bits to align with the source value
        /// </summary>
        /// <param name="value">The source value</param>
        [MethodImpl(Inline)]
        public void Fill(Bit value)
        {
            var primal = PrimalInfo.Get<T>();
            if(value)
                Bits.Fill(primal.MaxVal);
            else
                Bits.Fill(primal.Zero);
        }

        [MethodImpl(Inline)]    
        public BitString ToBitString()
            => Bits.ToBitString();
 
        [MethodImpl(Inline)]
        public string Format()
        {
            var sb = sbuild();
            for(var i=0; i< RowCount; i++)
                 sb.AppendLine(RowVector(i).FormatBits());
            return sb.ToString();
        }
 
        public BitMatrix<N,T> Transpose()
        {
            var dst = Alloc();
            for(var row = 0; row < RowCount; row++)
                dst.SetCol(row, RowVector(row));            
            return dst;
        }

        public BitMatrix<N,T> Replicate()
            => new BitMatrix<N, T>(new Memory<T>(data.ToArray()));

        public bool Equals(BitMatrix<N,T> rhs)        
        {
            var eq = gmath.eq<T>(Bits, rhs.Bits);
            for(var i = 0; i< eq.Length; i++)
                if(!eq[i])
                    return false;
            return true;
        }

        public override bool Equals(object obj)
            => obj is BitMatrix<N,T> x ? Equals(x) : false;
        
        public override int GetHashCode()
            => 0;

        static ref BitMatrix<N,T> And(ref BitMatrix<N,T> lhs, in BitMatrix<N,T> rhs)        
        {
            gmath.and(lhs.Bits, rhs.Bits, lhs.Bits);
            return ref lhs;
        }

        static ref BitMatrix<N,T> Mul(ref BitMatrix<N,T> lhs, in BitMatrix<N,T> rhs)
        {
            var x = lhs;
            var y = rhs.Transpose();
            ref var dst = ref lhs;
            var n = (int)new N().value;

            for(var i=0; i< n; i++)
            {
                var r = x.RowVector(i);
                var z = BitVector.Alloc<N,T>();
                for(var j = 0; j< n; j++)
                    z[j] = r % y.RowVector(j);
                dst[i] = z;
            }
            return ref dst;
        }

        static BitMatrix<N,T> Mul(BitMatrix<N,T> lhs, in BitMatrix<N,T> rhs)
        {
            var copy = lhs.Replicate();
            return Mul(ref copy,in rhs);
        }

        static BitMatrix<N,T> XOr(BitMatrix<N,T> lhs, in BitMatrix<N,T> rhs)        
        {
            var copy = lhs.Replicate();
            return XOr(ref copy, rhs);
        }

        static ref BitMatrix<N,T> XOr(ref BitMatrix<N,T> lhs, in BitMatrix<N,T> rhs)        
        {
            gbits.xor(lhs.Bits, rhs.Bits, lhs.Bits);
            return ref lhs;
        }

        static ref BitMatrix<N,T> Or(ref BitMatrix<N,T> lhs, in BitMatrix<N,T> rhs)        
        {
            gbits.or(lhs.Bits, rhs.Bits, lhs.Bits);
            return ref lhs;
        }

        static ref BitMatrix<N,T> Flip(ref BitMatrix<N,T> src)        
        {
            gbits.flip(src.Bits);
            return ref src;
        }
        
        static BitMatrix<N,T> CreateIdentity()
        {            
            var dst = Alloc();
            for(var row = 0; row < dst.RowCount; row++)
            for(var col = 0; col < dst.ColCount; col++)
                if(row == col)
                    dst[row,col] = 1;            
            return dst;
        }    

        /// <summary>
        /// Allocates a One-filled mxn matrix
        /// </summary>
        static BitMatrix<N,T> CreateOnes()
        {                    
            Memory<T> data = new T[GridLayout.TotalCellCount];
            data.Span.Fill(PrimalInfo.Get<T>().MaxVal);
            return new BitMatrix<N, T>(data);
        }

    }
}