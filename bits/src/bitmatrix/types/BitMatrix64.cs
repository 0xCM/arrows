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
    /// Defines a 64x64 matrix of bits
    /// </summary>
    public ref struct BitMatrix64 //: IBitMatrix<BitMatrix64,N64,ulong>
    {                
        Span<ulong> data;

        /// <summary>
        /// The matrix order
        /// </summary>
        public static readonly N64 N = default;

        /// <summary>
        /// The number of bits per row
        /// </summary>
        public static readonly BitSize RowBitCount = N.value;        

        /// <summary>
        /// The number of bits per column
        /// </summary>
        public static readonly BitSize ColBitCount = N.value;

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
        /// Defines the 64x64 identity bitmatrix
        /// </summary>
        public static BitMatrix64 Identity => From(Identity64x64.ToArray());

        /// <summary>
        /// Defines the 64x64 zero bitmatrix
        /// </summary>
        public static BitMatrix64 Zero  => Alloc();
        
        [MethodImpl(Inline)]
        public static BitMatrix64 Alloc()        
            => new BitMatrix64(new ulong[N]);

        [MethodImpl(Inline)]
        public static BitMatrix64 From(params ulong[] src)        
            => src.Length == 0 ? Alloc() : new BitMatrix64(src);

        [MethodImpl(Inline)]
        public static BitMatrix64 From(BitMatrix<N64,ulong> src)        
            => From(src.Data.AsBytes());

        [MethodImpl(Inline)]
        public static BitMatrix64 From(Span<byte> src)        
            => new BitMatrix64(src.AsUInt64());

        [MethodImpl(Inline)]
        public static BitMatrix64 operator + (BitMatrix64 lhs, BitMatrix64 rhs)
            => XOr(ref lhs, rhs);

        [MethodImpl(Inline)]
        public static BitMatrix64 operator - (BitMatrix64 lhs, BitMatrix64 rhs)
            => lhs + -rhs;

        [MethodImpl(Inline)]
        public static BitMatrix64 operator * (BitMatrix64 lhs, BitMatrix64 rhs)
            => Mul(ref lhs, rhs);

        [MethodImpl(Inline)]
        public static BitVector64 operator * (BitMatrix64 lhs, BitVector64 rhs)
            => Mul(lhs,rhs);

        [MethodImpl(Inline)]
        public static BitMatrix64 operator & (BitMatrix64 lhs, BitMatrix64 rhs)
            => And(ref lhs, rhs);

        [MethodImpl(Inline)]
        public static BitMatrix64 operator - (BitMatrix64 src)
            => Flip(ref src);

        [MethodImpl(Inline)]
        public static BitMatrix64 operator ~ (BitMatrix64 src)
            => Flip(ref src);

        [MethodImpl(Inline)]
        public static BitMatrix64 operator | (BitMatrix64 lhs, BitMatrix64 rhs)
            => Or(ref lhs,rhs);

        [MethodImpl(Inline)]
        public static bool operator ==(BitMatrix64 lhs, BitMatrix64 rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(BitMatrix64 lhs, BitMatrix64 rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        BitMatrix64(ulong[] src)
        {                        
            require(src.Length == Pow2.T06);
            this.data = src;
        }

        [MethodImpl(Inline)]
        BitMatrix64(Span<ulong> src)
        {                        
            require(src.Length == Pow2.T06);
            this.data = src;
        }

        /// <summary>
        /// Specifies the number of rows in the matrix
        /// </summary>
        public readonly int RowCount
        {
            [MethodImpl(Inline)]
            get => N;
        }

        /// <summary>
        /// Specifies the number of columns in the matrix
        /// </summary>
        public readonly int ColCount
        {
            [MethodImpl(Inline)]
            get => N;
        }

        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => data.AsBytes();
        }

        /// <summary>
        /// Reads the bit in a specified cell
        /// </summary>
        /// <param name="row">The row index</param>
        /// <param name="col">The column index</param>
        [MethodImpl(Inline)]
        public readonly Bit GetBit(int row, int col)
            => BitMask.test(in data[row], col);

        /// <summary>
        /// Sets the bit in a specified cell
        /// </summary>
        /// <param name="row">The row index</param>
        /// <param name="col">The column index</param>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public void SetBit(int row, int col, Bit src)
            => BitMask.set(ref data[row], (byte)col, src);

        /// <summary>
        /// Reads/manipulates the bit in a specified cell
        /// </summary>
        /// <param name="row">The row index</param>
        /// <param name="col">The column index</param>
        /// <param name="src">The source value</param>
        public Bit this[int row, int col]
        {
            [MethodImpl(Inline)]
            get => GetBit(row, col);

            [MethodImpl(Inline)]
            set => SetBit(row,col,value);
        }            

        /// <summary>
        /// Creates a bitvector from the content of an index-identified row
        /// </summary>
        /// <param name="row">The row index</param>
        [MethodImpl(Inline)]
        public readonly BitVector64 RowVector(int row)
            => data[row];

        /// <summary>
        /// Returns a mutable reference for an index-identified matrix row
        /// </summary>
        /// <param name="row">The row index</param>
        [MethodImpl(Inline)]
        public ref ulong RowData(int row)
            => ref data[row];

        /// <summary>
        /// A mutable indexer, functionally equivalent to <see cref='RowData' /> function
        /// </summary>
        /// <param name="row">The row index</param>
        public ref ulong this[int row]
        {
            [MethodImpl(Inline)]
            get => ref RowData(row);
        }

        /// <summary>
        /// Interchanges the i'th and j'th rows where  0 <= i,j < 64
        /// </summary>
        /// <param name="i">A row index</param>
        /// <param name="j">A row index</param>
        [MethodImpl(Inline)]
        public void RowSwap(int i, int j)
            => data.Swap(i,j);

        /// <summary>
        /// Returns the data for an index-identified column
        /// </summary>
        public readonly ulong ColData(int index)
        {
            ulong col = 0;
            for(var r = 0; r < N; r++)
                BitMask.setif(in data[r], index, ref col, r);
            return  col;
        }
        
        /// <summary>
        /// Creates a bitvector from the content of an index-identified column
        /// </summary>
        /// <param name="row">The row index</param>
        [MethodImpl(Inline)]
        public readonly BitVector64 ColVector(int col)
            =>  ColData(col);

        /// <summary>
        /// Extracts the bits that comprise the matrix in row-major order
        /// </summary>
        [MethodImpl(Inline)]
        public Span<Bit> Unpack()
            => Bytes.Unpack(out Span<Bit> _);


        [MethodImpl(Inline)]
        public BitMatrix64 Compare(BitMatrix64 rhs)
            => this.AndNot(rhs);

        /// <summary>
        /// Determines whether this matrix is equivalent to the canonical 0 matrix
        /// </summary>
        public readonly bool IsZero()
        {
            const int rowstep = 4;
            for(var i=0; i< RowCount; i += rowstep)
            {
                this.LoadCpuVec(i, out Vec256<ulong> vSrc);
                if(!vSrc.TestZ(vSrc))
                    return false;
            }
            return true;
        }        

        public readonly BitVector64 Diagonal()
        {
            var dst = (ulong)0;
            for(byte i=0; i < N; i++)
                if(GetBit(i,i))
                    BitMask.enable(ref dst, i);
            return dst;                    
        }

        public readonly BitMatrix64 AndNot(in BitMatrix64 rhs)
        {
            const int rowstep = 4;
            for(var i=0; i< RowCount; i += rowstep)
            {
                this.LoadCpuVec(i, out Vec256<ulong> vLhs);
                rhs.LoadCpuVec(i, out Vec256<ulong> vRhs);
                vLhs.AndNot(vRhs).StoreTo(ref data[i]);                
            }
            return this;
        }

        public readonly BitMatrix64 Transpose()
        {
            var dst = Replicate();
            for(var i=0; i<N; i++)
                dst.data[i] = ColData(i);
            return dst;
        }


        /// <summary>
        /// Computes the Hadamard product of the source matrix and another of the same dimension
        /// </summary>
        /// <remarks>See https://en.wikipedia.org/wiki/Hadamard_product_(matrices)</remarks>
        public readonly BitMatrix64 HProd(BitMatrix64 rhs)
        {
            var dst = Alloc();
            for(var i=0; i<RowCount; i++)
            for(var j=0; j<ColCount; j++)
                dst[i,j] = GetBit(i,j) & rhs[i,j];
            return dst;
        }
 
        /// <summary>
        /// Loads a CPU vector from matrix content
        /// </summary>
        /// <param name="dst">The target vector</param>
        /// <param name="row">The row index of where the load should begin</param>
        [MethodImpl(Inline)]
        public readonly ref Vec256<ulong> LoadCpuVec(int row, out Vec256<ulong> dst)
        {
            dst = load(ref data[row]);
            return ref dst;
        }

        /// <summary>
        /// Counts the number of enabled bits in the matrix
        /// </summary>
        [MethodImpl(Inline)] 
        public readonly BitSize Pop()
            => Bits.pop(data);

        /// <summary>
        /// Computes the product the source matrix and the operand in-place
        /// </summary>
        /// <param name="rhs">The operand</param>
        [MethodImpl(Inline)]
        public void Mul(in BitMatrix64 rhs)
        {
            Mul(ref this, rhs);
        }

        /// <summary>
        /// Computes the bitwise AND of the source matrix and the operand in-place
        /// </summary>
        /// <param name="rhs">The operand</param>
        [MethodImpl(Inline)]
        public void And(in BitMatrix64 rhs)
        {
            And(ref this, rhs);
        }

        /// <summary>
        /// Computes the bitwise OR of the source matrix and the operand in-place
        /// </summary>
        /// <param name="rhs">The operand</param>
        [MethodImpl(Inline)]
        public void Or(in BitMatrix64 rhs)
        {
            Or(ref this, rhs);
        }

        /// <summary>
        /// Computes the bitwise XOR of the source matrix and the operand in-place
        /// </summary>
        /// <param name="rhs">The operand</param>
        [MethodImpl(Inline)]
        public void XOr(in BitMatrix64 rhs)
        {
            XOr(ref this, rhs);
        }

        /// <summary>
        /// Computes the complement source matrix in-place
        /// </summary>
        /// <param name="rhs">The operand</param>
        [MethodImpl(Inline)]
        public void Flip()
        {
            Flip(ref this);
        }

        /// <summary>
        /// Converts the matrix to a bitvector
        /// </summary>
        [MethodImpl(Inline)]
        public readonly BitVector<N4096,ulong> ToBitVector()
            => BitVector.Load(data, zfunc.n4096);

        /// <summary>
        /// Constructs a 64-node graph via the adjacency matrix interpretation
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)]    
        public Graph<byte> ToGraph()
            => BitGraph.FromMatrix<byte,N32,byte>(BitMatrix<N32,N32,byte>.Load(Bytes));            

        [MethodImpl(Inline)] 
        public readonly BitMatrix64 Replicate()
            => From(data.ToArray()); 

        [MethodImpl(Inline)]
        public string Format()
            => data.FormatMatrixBits(64);

        [MethodImpl(Inline)]
        public readonly bool Equals(BitMatrix64 rhs)
            => this.AndNot(rhs).IsZero();

        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode()
            => throw new NotSupportedException();
        
        public override string ToString()
            => throw new NotSupportedException();

        static ref BitMatrix64 And(ref BitMatrix64 lhs, in BitMatrix64 rhs)
        {
            const int rowstep = 4;
            for(var i=0; i< lhs.RowCount; i += rowstep)
            {
                lhs.LoadCpuVec(i, out Vec256<ulong> vLhs);
                rhs.LoadCpuVec(i, out Vec256<ulong> vRhs);
                vLhs.And(vRhs).StoreTo(ref lhs.data[i]);
            }
            return ref lhs;
        }

        static ref BitMatrix64 XOr(ref BitMatrix64 lhs, in BitMatrix64 rhs)
        {
            const int rowstep = 4;
            for(var i=0; i< lhs.RowCount; i += rowstep)
            {
                lhs.LoadCpuVec(i, out Vec256<ulong> vLhs);
                rhs.LoadCpuVec(i, out Vec256<ulong> vRhs);
                vLhs.XOr(vRhs).StoreTo(ref lhs.data[i]);                
            }
            return ref lhs;
        }

        static ref BitMatrix64 Flip(ref BitMatrix64 src)
        {
            const int rowstep = 4;
            for(var i=0; i< src.RowCount; i += rowstep)
            {
                src.LoadCpuVec(i, out Vec256<ulong> vSrc);
                vSrc.Flip().StoreTo(ref src.data[i]);
            }
            return ref src;
        }

        static ref BitMatrix64 Or(ref BitMatrix64 lhs, in BitMatrix64 rhs)
        {
            const int rowstep = 4;
            for(var i=0; i< lhs.RowCount; i += rowstep)
            {
                lhs.LoadCpuVec(i, out Vec256<ulong> vLhs);
                rhs.LoadCpuVec(i, out Vec256<ulong> vRhs);
                vLhs.Or(vRhs).StoreTo(ref lhs.data[i]);                
            }
            return ref lhs;
        }
        
        static BitVector64 Mul(in BitMatrix64 lhs, in BitVector64 rhs)
        {
            var dst = BitVector64.Alloc();
            for(var i=0; i< N; i++)
                dst[i] = lhs.RowVector(i) % rhs;
            return dst;        
        }

        static ref BitMatrix64 Mul(ref BitMatrix64 lhs, in BitMatrix64 rhs)
        {
            var x = lhs;
            var y = rhs.Transpose();
            ref var dst = ref lhs;

            for(var i=0; i< N; i++)
            {
                var r = x.RowVector(i);
                var z = BitVector64.Alloc();
                for(var j = 0; j< N; j++)
                    z[j] = r % y.RowVector(j);
                dst[i] = (ulong)z;
            }
            return ref dst;
        }

        [MethodImpl(Inline)]
        static unsafe Vec256<ulong> load(ref ulong head)
            => Avx.LoadVector256(refptr(ref head));


        static ReadOnlySpan<byte> Identity64x64 => new byte[]
        {
            Pow2.T00, 0, 0, 0, 0, 0, 0, 0,
            Pow2.T01, 0, 0, 0, 0, 0, 0, 0,
            Pow2.T02, 0, 0, 0, 0, 0, 0, 0,
            Pow2.T03, 0, 0, 0, 0, 0, 0, 0,
            Pow2.T04, 0, 0, 0, 0, 0, 0, 0,
            Pow2.T05, 0, 0, 0, 0, 0, 0, 0,
            Pow2.T06, 0, 0, 0, 0, 0, 0, 0,
            Pow2.T07, 0, 0, 0, 0, 0, 0, 0,
            0, Pow2.T00, 0, 0, 0, 0, 0, 0,
            0, Pow2.T01, 0, 0, 0, 0, 0, 0,
            0, Pow2.T02, 0, 0, 0, 0, 0, 0,
            0, Pow2.T03, 0, 0, 0, 0, 0, 0,
            0, Pow2.T04, 0, 0, 0, 0, 0, 0,
            0, Pow2.T05, 0, 0, 0, 0, 0, 0,
            0, Pow2.T06, 0, 0, 0, 0, 0, 0,
            0, Pow2.T07, 0, 0, 0, 0, 0, 0,
            0, 0, Pow2.T00, 0, 0, 0, 0, 0,
            0, 0, Pow2.T01, 0, 0, 0, 0, 0,
            0, 0, Pow2.T02, 0, 0, 0, 0, 0,
            0, 0, Pow2.T03, 0, 0, 0, 0, 0,
            0, 0, Pow2.T04, 0, 0, 0, 0, 0,
            0, 0, Pow2.T05, 0, 0, 0, 0, 0,
            0, 0, Pow2.T06, 0, 0, 0, 0, 0,
            0, 0, Pow2.T07, 0, 0, 0, 0, 0,
            0, 0, 0, Pow2.T00, 0, 0, 0, 0,
            0, 0, 0, Pow2.T01, 0, 0, 0, 0,
            0, 0, 0, Pow2.T02, 0, 0, 0, 0,
            0, 0, 0, Pow2.T03, 0, 0, 0, 0,
            0, 0, 0, Pow2.T04, 0, 0, 0, 0,
            0, 0, 0, Pow2.T05, 0, 0, 0, 0,
            0, 0, 0, Pow2.T06, 0, 0, 0, 0,
            0, 0, 0, Pow2.T07, 0, 0, 0, 0,
            0, 0, 0, 0, Pow2.T00, 0, 0, 0,
            0, 0, 0, 0, Pow2.T01, 0, 0, 0,
            0, 0, 0, 0, Pow2.T02, 0, 0, 0,
            0, 0, 0, 0, Pow2.T03, 0, 0, 0,
            0, 0, 0, 0, Pow2.T04, 0, 0, 0,
            0, 0, 0, 0, Pow2.T05, 0, 0, 0,
            0, 0, 0, 0, Pow2.T06, 0, 0, 0,
            0, 0, 0, 0, Pow2.T07, 0, 0, 0,
            0, 0, 0, 0, 0, Pow2.T00, 0, 0,
            0, 0, 0, 0, 0, Pow2.T01, 0, 0,
            0, 0, 0, 0, 0, Pow2.T02, 0, 0,
            0, 0, 0, 0, 0, Pow2.T03, 0, 0,
            0, 0, 0, 0, 0, Pow2.T04, 0, 0,
            0, 0, 0, 0, 0, Pow2.T05, 0, 0,
            0, 0, 0, 0, 0, Pow2.T06, 0, 0,
            0, 0, 0, 0, 0, Pow2.T07, 0, 0,
            0, 0, 0, 0, 0, 0, Pow2.T00, 0,
            0, 0, 0, 0, 0, 0, Pow2.T01, 0,
            0, 0, 0, 0, 0, 0, Pow2.T02, 0,
            0, 0, 0, 0, 0, 0, Pow2.T03, 0,
            0, 0, 0, 0, 0, 0, Pow2.T04, 0,
            0, 0, 0, 0, 0, 0, Pow2.T05, 0,
            0, 0, 0, 0, 0, 0, Pow2.T06, 0,
            0, 0, 0, 0, 0, 0, Pow2.T07, 0,
            0, 0, 0, 0, 0, 0, 0, Pow2.T00,
            0, 0, 0, 0, 0, 0, 0, Pow2.T01,
            0, 0, 0, 0, 0, 0, 0, Pow2.T02,
            0, 0, 0, 0, 0, 0, 0, Pow2.T03,
            0, 0, 0, 0, 0, 0, 0, Pow2.T04,
            0, 0, 0, 0, 0, 0, 0, Pow2.T05,
            0, 0, 0, 0, 0, 0, 0, Pow2.T06,
            0, 0, 0, 0, 0, 0, 0, Pow2.T07,
        };

    }
}