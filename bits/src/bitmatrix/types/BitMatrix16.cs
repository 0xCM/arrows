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
    /// Defines a 16x16 matrix of bits
    /// </summary>
    public ref struct BitMatrix16 //: IBitMatrix<BitMatrix16,N16,ushort>
    {   
        Span<ushort> data;

        /// <summary>
        /// The matrix order
        /// </summary>
        public static readonly N16 N = default;

        /// <summary>
        /// The number of bits per row = 16
        /// </summary>
        public static readonly BitSize RowBitCount = N.value;        

        /// <summary>
        /// The number of bits per column = 16
        /// </summary>
        public static readonly BitSize ColBitCount = N.value;

        /// <summary>
        /// The (aligned) number of bytes needed for a row = 2
        /// </summary>
        public static readonly ByteSize RowByteCount = (ByteSize)RowBitCount;                        

        /// <summary>
        /// The (aligned) number of bytes needed for a column = 2
        /// </summary>
        public static readonly ByteSize ColByteCount = (ByteSize)ColBitCount;

        /// <summary>
        /// The number of bits apprehended by the matrix = 256 bits
        /// </summary>
        public static readonly BitSize TotalBitCount = RowBitCount * ColBitCount;

        /// <summary>
        /// The number of bytes required to store the matrix bits = 32
        /// </summary>
        public static readonly ByteSize StorageBytes = (ByteSize)TotalBitCount;
                                
        /// <summary>
        /// Defines the 16x16 identity bitmatrix
        /// </summary>
        public static BitMatrix16 Identity => From(Identity16x16.ToSpan());

        /// <summary>
        /// Defines the 16x16 zero bitmatrix
        /// </summary>
        public static BitMatrix16 Zero => Alloc();

        [MethodImpl(Inline)]
        public static BitMatrix16 Alloc()        
            => From(new ushort[N]);

        [MethodImpl(Inline)]
        public static BitMatrix16 From(params ushort[] src)        
            => src.Length == 0 ? Alloc() : new BitMatrix16(src);

        [MethodImpl(Inline)]
        public static BitMatrix16 From(Span<ushort> src)        
            => new BitMatrix16(src);

        [MethodImpl(Inline)]
        public static BitMatrix16 From(BitMatrix<N16,ushort> src)        
            => From(src.Data);

        [MethodImpl(Inline)]
        public static BitMatrix16 From(Span<byte> src)        
            => new BitMatrix16(src.AsUInt16());

        /// <summary>
        /// Loads a bitmatrix from the bits in cpu vector
        /// </summary>
        /// <param name="src">The matrix bits</param>
        [MethodImpl(Inline)]
        public static BitMatrix16 From<T>(in Vec256<T> src)
            where T : struct
                => BitMatrix16.From(ByteSpan.FromValue(src));

        [MethodImpl(Inline)]
        public static BitMatrix16 operator + (BitMatrix16 lhs, BitMatrix16 rhs)
            => XOr(ref lhs, rhs);

        [MethodImpl(Inline)]
        public static BitMatrix16 operator - (BitMatrix16 src)
            => Flip(ref src);

        [MethodImpl(Inline)]
        public static BitMatrix16 operator - (BitMatrix16 lhs, BitMatrix16 rhs)
            => lhs + -rhs;

        [MethodImpl(Inline)]
        public static BitMatrix16 operator * (BitMatrix16 lhs, BitMatrix16 rhs)
            => Mul(ref lhs, rhs);

        [MethodImpl(Inline)]
        public static BitVector16 operator * (BitMatrix16 lhs, BitVector16 rhs)
            => Mul(lhs,rhs);

        /// <summary>
        /// Computes the bitwise and of the operands
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix16 operator & (BitMatrix16 lhs, BitMatrix16 rhs)
            => And(ref lhs, rhs);

        /// <summary>
        /// Computes the bitwise or of the operands
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix16 operator | (BitMatrix16 lhs, BitMatrix16 rhs)
            => Or(ref lhs, rhs);

        /// <summary>
        /// Computes the complement of the operand
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix16 operator ~ (BitMatrix16 src)
            => Flip(ref src);

        [MethodImpl(Inline)]
        public static bool operator ==(BitMatrix16 lhs, BitMatrix16 rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(BitMatrix16 lhs, BitMatrix16 rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        BitMatrix16(ushort[] src)
        {                        
            require(src.Length == Pow2.T04);
            this.data = src;
        }

        [MethodImpl(Inline)]
        BitMatrix16(Span<ushort> src)
        {                        
            require(src.Length == Pow2.T04);
            this.data = src;
        }

        /// <summary>
        /// The underlying matrix presented as a bytespan
        /// </summary>
        public Span<byte> Bytes
        {
            [MethodImpl(Inline)]
            get => data.AsBytes();
        }

        /// <summary>
        /// The underlying matrix data
        /// </summary>
        public Span<ushort> Data
        {
            [MethodImpl(Inline)]
            get => data;
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
            get => GetBit(row,col);

            [MethodImpl(Inline)]
            set => SetBit(row,col,value);
        }            

        public readonly int RowCount
        {
            [MethodImpl(Inline)]
            get => N;
        }

        public readonly int ColCount
        {
            [MethodImpl(Inline)]
            get => N;
        }

        public readonly ushort ColData(int index)
        {
            ushort col = 0;
            for(var r = 0; r < N; r++)
                BitMask.setif(in data[r], index, ref col, r);
            return col;
        }
        
        [MethodImpl(Inline)]
        public readonly BitVector16 ColVector(int index)
            => ColData(index);

        /// <summary>
        /// Interchanges the i'th and j'th rows where  0 <= i,j < 16
        /// </summary>
        /// <param name="i">A row index</param>
        /// <param name="j">A row index</param>
        [MethodImpl(Inline)]
        public void RowSwap(int i, int j)
            => data.Swap(i,j);

        [MethodImpl(Inline)]
        public readonly BitVector16 RowVector(int index)
            => data[index];

        /// <summary>
        /// Returns a mutable reference for an index-identified matrix row
        /// </summary>
        /// <param name="row">The row index</param>
        [MethodImpl(Inline)]
        public ref ushort RowData(int row)
            => ref data[row];

        /// <summary>
        /// A mutable indexer, functionally equivalent to <see cref='RowData' /> function
        /// </summary>
        /// <param name="row">The row index</param>
        public ref ushort this[int row]
        {
            [MethodImpl(Inline)]
            get => ref RowData(row);
        }

        [MethodImpl(Inline)]
        public readonly BitMatrix16 AndNot(in BitMatrix16 rhs)
        {
            this.LoadCpuVec(out Vec256<ushort> vLhs);
            rhs.LoadCpuVec(out Vec256<ushort> vRhs);
            Bits.andn(vLhs,vRhs).StoreTo(ref data[0]);
            return this;
        }

        [MethodImpl(Inline)]
        public BitMatrix16 Compare(in BitMatrix16 rhs)
            => this.AndNot(in rhs);

        public readonly BitVector16 Diagonal()
        {
            var dst = (ushort)0;
            for(byte i=0; i < BitMatrix16.N; i++)
                if(GetBit(i,i))
                    BitMask.enable(ref dst, i);
            return dst;                    
        }

        public readonly BitMatrix16 Transpose()
        {
            var dst = Replicate();
            for(var i=0; i<N; i++)
                dst.data[i] = ColData(i);
            return dst;
        }

        /// <summary>
        /// Constructs a 16-node graph via the adjacency matrix interpretation
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)]    
        public Graph<byte> ToGraph()
            => BitGraph.FromMatrix<byte,N16,byte>(BitMatrix<N16,N16,byte>.Load(Bytes));            

        /// <summary>
        /// Computes the Hadamard product of the source matrix and another of the same dimension
        /// </summary>
        /// <remarks>See https://en.wikipedia.org/wiki/Hadamard_product_(matrices)</remarks>
        public readonly BitMatrix16 HProd(BitMatrix16 rhs)
        {
            var dst = Alloc();
            for(var i=0; i<RowCount; i++)
            for(var j=0; j<ColCount; j++)
                dst[i,j] = GetBit(i,j) & rhs[i,j];
            return dst;
        }

        [MethodImpl(Inline)] 
        public readonly BitMatrix16 Replicate()
            => From(data.ToArray());
        
        /// <summary>
        /// Counts the number of enabled bits in the matrix
        /// </summary>
        [MethodImpl(Inline)] 
        public readonly BitSize Pop()
            => Bits.pop(data);

        /// <summary>
        /// Extracts the bits that comprise the matrix in row-major order
        /// </summary>
        [MethodImpl(Inline)]
        public Span<Bit> Unpack()
            => Bytes.Unpack(out Span<Bit> _);

        [MethodImpl(Inline)]
        public bool IsZero()
        {
            this.LoadCpuVec(out Vec256<ushort> vSrc);
            return vSrc.TestZ(vSrc);            
        }

        public readonly BitMatrix8 Block(N0 r0, N0 c0)
        {
            var r1 = r0 + 8;
            var c1 = c0 + 8;
            var dst = new byte[8];
            for(int i=r0; i< r0; i++)                
                dst[i] = Bits.lo(in data[i]);
            return BitMatrix8.From(dst);
        }

        [MethodImpl(Inline)]
        public string Format()
            => Bytes.FormatMatrixBits(16);

        /// <summary>
        /// Converts the matrix to a bitvector
        /// </summary>
        [MethodImpl(Inline)]
        public readonly BitVector<N256,ushort> ToBitVector()
            => BitVector.Load(data, zfunc.n256);

        [MethodImpl(Inline)]
        static unsafe Vec256<ushort> load(ref ushort head)
            => Avx.LoadVector256(refptr(ref head));

        [MethodImpl(Inline)]
        public bool Equals(BitMatrix16 rhs)
            => this.AndNot(rhs).IsZero();

        [MethodImpl(Inline)]
        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode()
            => throw new NotSupportedException();

        /// <summary>
        /// Loads a cpu vector with the full content of the matrix
        /// </summary>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline)]
        public readonly ref Vec256<ushort> LoadCpuVec(out Vec256<ushort> dst)
        {
            dst = load(ref data[0]);
            return ref dst;
        }

        [MethodImpl(Inline)]
        static ref BitMatrix16 And(ref BitMatrix16 lhs, in BitMatrix16 rhs)
        {
            lhs.LoadCpuVec(out Vec256<ushort> vLhs);
            rhs.LoadCpuVec(out Vec256<ushort> vRhs);
            vLhs.And(vRhs).StoreTo(ref lhs.data[0]);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        static ref BitMatrix16 Or(ref BitMatrix16 lhs, in BitMatrix16 rhs)
        {
            lhs.LoadCpuVec(out Vec256<ushort> vLhs);
            rhs.LoadCpuVec(out Vec256<ushort> vRhs);
            vLhs.Or(vRhs).StoreTo(ref lhs.data[0]);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        static ref BitMatrix16 XOr(ref BitMatrix16 lhs, in BitMatrix16 rhs)
        {
            lhs.LoadCpuVec(out Vec256<ushort> vLhs);
            rhs.LoadCpuVec(out Vec256<ushort> vRhs);
            vLhs.XOr(vRhs).StoreTo(ref lhs.data[0]);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        static ref BitMatrix16 Flip(ref BitMatrix16 src)
        {
            src.LoadCpuVec(out Vec256<ushort> vSrc);
            vSrc.Flip().StoreTo(ref src.data[0]);
            return ref src;
        }

        static BitVector16 Mul(in BitMatrix16 m, in BitVector16 y)
        {
            var dst = BitVector16.Alloc();
            for(var i=0; i< N; i++)
                dst[i] = m.RowVector(i) % y;
            return dst;        
        }

        static ref BitMatrix16 Mul(ref BitMatrix16 lhs, in BitMatrix16 rhs)
        {
            var x = lhs.Replicate();
            var y = rhs.Transpose();

            for(var i=0; i< N; i++)
            {
                var r = x.RowVector(i);
                for(var j = 0; j< N; j++)
                    lhs[i,j] = y.RowVector(j) % r;
            }
            return ref lhs;
        }

        static ReadOnlySpan<byte> Identity16x16 => new byte[]
        {
            Pow2.T00, 0,
            Pow2.T01, 0,
            Pow2.T02, 0,
            Pow2.T03, 0,
            Pow2.T04, 0,
            Pow2.T05, 0,
            Pow2.T06, 0,
            Pow2.T07, 0,
            0, Pow2.T00,
            0, Pow2.T01,
            0, Pow2.T02,
            0, Pow2.T03,
            0, Pow2.T04,
            0, Pow2.T05,
            0, Pow2.T06,
            0, Pow2.T07,
        };


   }
}