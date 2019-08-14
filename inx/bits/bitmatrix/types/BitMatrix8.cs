//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics.X86;

    using static As;

    using static zfunc;

    /// <summary>
    /// Defines an 8x8 matrix of bits
    /// </summary>
    public ref struct BitMatrix8
    {        
        Span<byte> bits;

        /// <summary>
        /// The matrix order
        /// </summary>
        public static readonly N8 N = default;

        /// <summary>
        /// The number of bits per row
        /// </summary>
        public static readonly BitSize RowBitCount = N.value;        

        /// <summary>
        /// The number of bits per column
        /// </summary>
        public static readonly BitSize ColBitCount = N.value;

        /// <summary>
        /// The number of bits apprehended by the matrix = 64
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
        /// Allocates an copy of the identity matrix
        /// </summary>
        public static BitMatrix8 Identity 
        {
            [MethodImpl(Inline)]
            get => Load(BitMatrixStore.Identity8x8);
        }

        /// <summary>
        /// Allocates an copy of the 0 matrix
        /// </summary>
        public static BitMatrix8 Zero 
        {
            [MethodImpl(Inline)]
            get => Alloc();
        }        

        /// <summary>
        /// Loads a matrix from the source vaue
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static BitMatrix8 Load(ulong src)        
            => new BitMatrix8(BitConverter.GetBytes(src));

        /// <summary>
        /// Allocates a matrix, optionally assigning each element to the
        /// specified bit value
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix8 Alloc(Bit? fill = null)                
            => fill == Bit.On ? Load(UInt64.MaxValue) : Load(0);

        /// <summary>
        /// Defines a matrix by the explicit specification of 8 bytes
        /// </summary>
        /// <param name="row0">Specifies the bits in row0</param>
        /// <param name="row1">Specifies the bits in row1</param>
        /// <param name="row2">Specifies the bits in row2</param>
        /// <param name="row3">Specifies the bits in row3</param>
        /// <param name="row4">Specifies the bits in row4</param>
        /// <param name="row5">Specifies the bits in row5</param>
        /// <param name="row6">Specifies the bits in row6</param>
        /// <param name="row7">Specifies the bits in row7</param>
        [MethodImpl(Inline)]
        public static BitMatrix8 FromParts(byte row0, byte row1, byte row2, byte row3, byte row4, byte row5, byte row6, byte row7)        
            => new BitMatrix8(new byte[]{row0,row1,row2,row3,row4,row5,row6,row7});

        /// <summary>
        /// Creates an 8x8 bitmatrix from a span that contains exactly 8 entries
        /// </summary>
        /// <param name="src">The source array</param>
        [MethodImpl(Inline)]
        public static BitMatrix8 Load(Span<byte> src)        
            => new BitMatrix8(src);

        /// <summary>
        /// Creates an 8x8 bitmatrix from a readonly span that contains exactly 8 entries
        /// </summary>
        /// <param name="src">The source array</param>
        [MethodImpl(Inline)]
        public static BitMatrix8 Load(ReadOnlySpan<byte> src)        
            => new BitMatrix8(src);

        [MethodImpl(Inline)]
        public static BitMatrix8 operator + (BitMatrix8 lhs, BitMatrix8 rhs)
            => XOr(ref lhs,rhs);

        [MethodImpl(Inline)]
        public static BitMatrix8 operator - (BitMatrix8 lhs, BitMatrix8 rhs)
            => lhs + -rhs;

        [MethodImpl(Inline)]
        public static BitMatrix8 operator - (BitMatrix8 src)
            => Flip(ref src);

        [MethodImpl(Inline)]
        public static BitMatrix8 operator & (BitMatrix8 lhs, BitMatrix8 rhs)
            => And(ref lhs,rhs);

        [MethodImpl(Inline)]
        public static BitMatrix8 operator * (BitMatrix8 lhs, BitMatrix8 rhs)
            => Mul(ref lhs,rhs);

        [MethodImpl(Inline)]
        public static BitVector8 operator * (BitMatrix8 lhs, BitVector8 rhs)
            => Mul(lhs,rhs);

        [MethodImpl(Inline)]
        public static BitMatrix8 operator | (BitMatrix8 lhs, BitMatrix8 rhs)
            => Or(ref lhs, rhs);

        [MethodImpl(Inline)]
        public static bool operator ==(BitMatrix8 lhs, BitMatrix8 rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(BitMatrix8 lhs, BitMatrix8 rhs)
            => !(lhs.Equals(rhs));

        [MethodImpl(Inline)]
        public static explicit operator ulong(BitMatrix8 src)
            => BitConverter.ToUInt64(src.bits);

        [MethodImpl(Inline)]
        public static explicit operator BitMatrix8(ulong src)
            => Load(src);

        /// <summary>
        /// Initializes the matrix by replicating data from a readonly span
        /// </summary>
        [MethodImpl(Inline)]
        BitMatrix8(ReadOnlySpan<byte> src)
        {                    
            var len = src.Length;
            require(len == Pow2.T03);
            this.bits = src.Replicate();
        }

        [MethodImpl(Inline)]
        BitMatrix8(Span<byte> src)
        {
            require(src.Length == Pow2.T03);
            this.bits = src;
        }

        /// <summary>
        /// The number of rows in the matrix
        /// </summary>
        public readonly int RowCount
        {
            [MethodImpl(Inline)]
            get => N;
        }

        /// <summary>
        /// The number of columns in the matrix
        /// </summary>
        public readonly int ColCount
        {
            [MethodImpl(Inline)]
            get => N;
        }

        /// <summary>
        /// Reads the bit in a specified cell
        /// </summary>
        /// <param name="row">The row index</param>
        /// <param name="col">The column index</param>
        [MethodImpl(Inline)]
        public readonly Bit GetBit(int row, int col)
            => BitMask.test(in bits[row], col);

        /// <summary>
        /// Sets the bit in a specified cell
        /// </summary>
        /// <param name="row">The row index</param>
        /// <param name="col">The column index</param>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public void SetBit(int row, int col, Bit src)
            => BitMask.set(ref bits[row], (byte)col, src);

        /// <summary>
        /// Reads/manipulates the bit in a specified cell
        /// </summary>
        /// <param name="row">The row index</param>
        /// <param name="col">The column index</param>
        /// <param name="src">The source value</param>
        public Bit this[int row, int col]
        {
            [MethodImpl(Inline)]
            get => GetBit(row,col);

            [MethodImpl(Inline)]
            set => SetBit(row,col,value);
        }            

        /// <summary>
        /// A mutable indexer, functionally equivalent to <see cref='RowData' /> function
        /// </summary>
        /// <param name="row">The row index</param>
        public ref byte this[int row]
        {
            [MethodImpl(Inline)]
            get => ref RowData(row);
        }

        [MethodImpl(Inline)]
        public readonly bool IsZero()
            => BitConverter.ToUInt64(bits) == 0;

        [MethodImpl(Inline)]
        public BitMatrix8 AndNot(in BitMatrix8 rhs)
        {
             bits = ((ulong)this &~ (ulong)rhs).ToBytes();
             return this;
        }

        /// <summary>
        /// Retrives the bitvector determined by the matrix diagonal
        /// </summary>
        public readonly BitVector8 Diagonal()
        {
            var dst = (byte)0;
            for(byte i=0; i < RowCount; i++)
                if(GetBit(i,i))
                    BitMask.enable(ref dst, i);
            return dst;                    
        }

        /// <summary>
        /// Returns a mutable reference for an index-identified matrix row
        /// </summary>
        /// <param name="row">The row index</param>
        [MethodImpl(Inline)]
        public ref byte RowData(int row)
            => ref bits[row];

        /// <summary>
        /// Queries the matrix for the data in an index-identified row and returns
        /// the bitvector representative
        /// </summary>
        /// <param name="index">The row index</param>
        [MethodImpl(Inline)]
        public readonly BitVector8 RowVector(int index)
            => bits[index];

        /// <summary>
        /// Replaces the data in an index-identified row with the data
        /// represented by a bitvector source
        /// </summary>
        /// <param name="index">The row index</param>
        [MethodImpl(Inline)]
        public BitVector8 RowVector(int index, BitVector8 src)
            => bits[index] = (byte)src;

        /// <summary>
        /// Transposes a copy of the matrix
        /// </summary>
        public readonly BitMatrix8 Transpose()
        {
            var dst = Replicate();
            for(var i=0; i<N; i++)
                dst.bits[i] = ColData(i);
            return dst;
        }

        /// <summary>
        /// Queries the matrix for the data in an index-identified column 
        /// </summary>
        /// <param name="index">The row index</param>
        public readonly byte ColData(int index)
        {
            byte col = 0;
            for(var r = 0; r < N; r++)
                if(BitMask.test(in bits[r], index))
                    BitMask.enable(ref col, r);
            return col;
        }

        /// <summary>
        /// Queries the matrix for the data in an index-identified column and returns
        /// the bitvector representative
        /// </summary>
        /// <param name="index">The row index</param>
        [MethodImpl(Inline)]
        public readonly BitVector8 ColVector(int index)
            => ColData(index);


        /// <summary>
        /// Interchanges the i'th and j'th rows where  0 <= i,j < 8
        /// </summary>
        /// <param name="i">A row index</param>
        /// <param name="j">A row index</param>
        [MethodImpl(Inline)]
        public void RowSwap(int i, int j)
            => bits.Swap(i,j);

        /// <summary>
        /// Creates a new matrix by cloning the existing matrix or allocating
        /// a matrix with the same structure
        /// </summary>
        /// <param name="structureOnly">Specifies whether the replication reproduces
        /// only structure and is thus equivalent to an allocation</param>
        [MethodImpl(Inline)] 
        public readonly BitMatrix8 Replicate(bool structureOnly = false)
            => structureOnly ? Alloc() : Load(bits.ReadOnly());

        /// <summary>
        /// Counts the number of enabled bits in the matrix
        /// </summary>
        [MethodImpl(Inline)]
        public readonly BitSize Pop()
            => Bits.pop((ulong)this);

        [MethodImpl(Inline)]
        public readonly string Format()
            => bits.FormatMatrixBits(8);

        /// <summary>
        /// Extracts the bits that comprise the matrix in row-major order
        /// </summary>
        [MethodImpl(Inline)]
        public readonly Span<Bit> Unpack()
            => bits.Unpack(out Span<Bit> dst);

        /// <summary>
        /// Constructs an 8-node graph via the adjacency matrix interpretation
        /// </summary>
        public readonly Graph<byte> ToGraph()
            => BitMatrix.ToGraph<byte,N8,byte>(new BitMatrix<N8,N8,byte>(bits));            

        /// <summary>
        /// Converts the matrix to a bitvector
        /// </summary>
        [MethodImpl(Inline)]
        public readonly BitVector64 ToBitVector()
            => BitVector64.Load((ulong)this);

        [MethodImpl(Inline)]
        public readonly bool Equals(in BitMatrix8 rhs)
            => BitConverter.ToUInt64(bits) == BitConverter.ToUInt64(rhs.bits);

        [MethodImpl(Inline)]
        static ref BitMatrix8 And(ref BitMatrix8 lhs, in BitMatrix8 rhs)
        {
             lhs.bits =((ulong)lhs & (ulong)rhs).ToBytes();
             return ref lhs;
        }

        [MethodImpl(Inline)]
        static ref BitMatrix8 Or(ref BitMatrix8 lhs, in BitMatrix8 rhs)
        {
             lhs.bits = ((ulong)lhs | (ulong)rhs).ToBytes();
             return ref lhs;
        }

        [MethodImpl(Inline)]
        static ref BitMatrix8 XOr(ref BitMatrix8 lhs, in BitMatrix8 rhs)
        {
             lhs.bits = ((ulong)lhs ^ (ulong)rhs).ToBytes();
             return ref lhs;
        }

        [MethodImpl(Inline)]
        static ref BitMatrix8 Flip(ref BitMatrix8 src)
        {
             src.bits = (~(ulong)src).ToBytes();
             return ref src;
        }

        static BitVector8 Mul(in BitMatrix8 lhs, in BitVector8 rhs)
        {
            var dst = BitVector8.Alloc();
            for(var i=0; i< N; i++)
                dst[i] = lhs.RowVector(i) % rhs;
            return dst;        
        }

        static ref BitMatrix8 Mul(ref BitMatrix8 lhs, in BitMatrix8 rhs)
        {
            var x = lhs;
            var y = rhs.Transpose();
            ref var dst = ref lhs;

            for(var i=0; i< N; i++)
            {
                var r = x.RowVector(i);
                var z = BitVector8.Alloc();
                for(var j = 0; j< N; j++)
                    z[j] = r % y.RowVector(j);
                dst[i] = (byte)z;
            }
            return ref dst;
        }


        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode() 
            => throw new NotSupportedException();
    }
}