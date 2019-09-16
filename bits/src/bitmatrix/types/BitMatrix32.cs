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
    /// Defines a 32x32 matrix of bits
    /// </summary>
    
    public ref struct BitMatrix32  //: IBitMatrix<BitMatrix32,N32,uint>
    {                
        Span<uint> data;        

        /// <summary>
        /// The matrix order
        /// </summary>
        public static readonly N32 N = default;

        /// <summary>
        /// The number of bits per row = 32
        /// </summary>
        public static readonly BitSize RowBitCount = N.value;        

        /// <summary>
        /// The number of bits per column = 32
        /// </summary>
        public static readonly BitSize ColBitCount = N.value;

        /// <summary>
        /// The number of bits apprehended by the matrix = 1024 bits =  128 bytes
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
        /// Defines the 32x32 identity bitmatrix
        /// </summary>
        public static BitMatrix32 Identity => From(Identity32x32.ToSpan());

        /// <summary>
        /// Defines the 32x32 zero bitmatrix
        /// </summary>
        public static BitMatrix32 Zero => Alloc();
                
        [MethodImpl(Inline)]
        public static BitMatrix32 Alloc()        
            => new BitMatrix32(new uint[N]);

        [MethodImpl(Inline)]
        public static BitMatrix32 From(params uint[] src)        
            => src.Length == 0 ? Alloc() : new BitMatrix32(src);

        [MethodImpl(Inline)]
        public static BitMatrix32 From(BitMatrix<N32,uint> src)        
            => From(src.Data);

        [MethodImpl(Inline)]
        public static BitMatrix32 From(Span<uint> src)        
            => new BitMatrix32(src);

        [MethodImpl(Inline)]
        public static BitMatrix32 From(Span<byte> src)        
            => new BitMatrix32(src.AsUInt32());

        /// <summary>
        /// Negates the operand. 
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix32 operator - (BitMatrix32 src)
            => Flip(in src);

        [MethodImpl(Inline)]
        public static BitMatrix32 operator - (in BitMatrix32 lhs, in BitMatrix32 rhs)
            => lhs ^( -rhs);

        [MethodImpl(Inline)]
        public static BitMatrix32 operator * (in BitMatrix32 lhs, in BitMatrix32 rhs)
            => Mul(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static BitVector32 operator * (in BitMatrix32 lhs, in BitVector32 rhs)
            => Mul(in lhs,in rhs);

        [MethodImpl(Inline)]
        public static BitMatrix32 operator & (in BitMatrix32 lhs, in BitMatrix32 rhs)
            => And(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static BitMatrix32 operator | (in BitMatrix32 lhs, in BitMatrix32 rhs)
            => Or(in lhs, in rhs);

        /// <summary>
        /// Applies element-wise XOR to corresponding operand entries. Note that this
        /// is equivalent to the addition operator (+) 
        /// </summary>
        /// <param name="lhs">The left matrix</param>
        /// <param name="rhs">The right matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix32 operator ^ (BitMatrix32 lhs, BitMatrix32 rhs)
            => XOr(lhs, rhs);

        /// <summary>
        /// Computes the complement of the operand. 
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix32 operator ~ (BitMatrix32 src)
            => Flip(src);

        [MethodImpl(Inline)]
        public static bool operator ==(BitMatrix32 lhs, BitMatrix32 rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(BitMatrix32 lhs, BitMatrix32 rhs)
            => !(lhs.Equals(rhs));


        [MethodImpl(Inline)]
        BitMatrix32(Span<uint> src)
        {                        
            require(src.Length == Pow2.T05);
            this.data = src;
        }        

        [MethodImpl(Inline)]
        BitMatrix32(uint[] src)
        {                        
            require(src.Length == Pow2.T05);
            this.data = src;
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
        /// Queries/manipulates a bit in an identified cell
        /// </summary>
        /// <param name="row">The row index</param>
        /// <param name="col">The column index</param>
        public Bit this[int row, int col]
        {
            [MethodImpl(Inline)]
            get => GetBit(row,col);

            [MethodImpl(Inline)]
            set => SetBit(row,col,value);
        }            

        public readonly BitVector32 Diagonal()
        {
            var dst = (uint)0;
            for(byte i=0; i < BitMatrix32.N; i++)
                if(GetBit(i,i))
                    BitMask.enable(ref dst, i);
            return dst;                    
        }

        [MethodImpl(Inline)] 
        public readonly BitMatrix32 Replicate()
            => new BitMatrix32(data.ToArray());

        [MethodImpl(Inline)]
        public readonly BitVector32 RowVector(int index)
            => data[index];

        /// <summary>
        /// Returns a mutable reference for an index-identified matrix row
        /// </summary>
        /// <param name="row">The row index</param>
        [MethodImpl(Inline)]
        public ref uint RowData(int row)
            => ref data[row];

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
        public Span<uint> Data
        {
            [MethodImpl(Inline)]
            get => data;
        }

        /// <summary>
        /// Queries/manipulates row data
        /// </summary>
        /// <param name="row">The row index</param>
        public ref uint this[int row]
        {
            [MethodImpl(Inline)]
            get => ref RowData(row);
        }

        /// <summary>
        /// Interchanges the i'th and j'th rows where  0 <= i,j < 32
        /// </summary>
        /// <param name="i">A row index</param>
        /// <param name="j">A row index</param>
        [MethodImpl(Inline)]
        public void RowSwap(int i, int j)
            => data.Swap(i,j);

        public readonly uint ColData(int index)
        {
            uint col = 0;
            for(var r = 0; r < N; r++)
                BitMask.setif(in data[r], index, ref col, r);
            return col;
        }
        
        [MethodImpl(Inline)]
        public readonly BitVector32 ColVec(int index)
            => ColData(index);


        [MethodImpl(Inline)]
        public bool Equals(BitMatrix32 rhs)
            => this.AndNot(rhs).IsZero();

        public readonly bool IsZero()
        {
            const int rowstep = 8;
            for(var i=0; i< RowCount; i += rowstep)
            {
                this.LoadCpuVec(i, out Vec256<uint> vSrc);
                if(!vSrc.TestZ(vSrc))
                    return false;
            }
            return true;
        }

        public readonly BitMatrix32 AndNot(in BitMatrix32 rhs)
        {
            const int rowstep = 8;
            for(var i=0; i< RowCount; i += rowstep)
            {
                this.LoadCpuVec(i, out Vec256<uint> vLhs);
                rhs.LoadCpuVec(i, out Vec256<uint> vRhs);
                Bits.andn(vLhs,vRhs).StoreTo(ref data[i]);
            }
            return this;
        }
        
        public readonly BitMatrix32 Transpose()
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
        public readonly BitMatrix32 HProd(BitMatrix32 rhs)
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
        public readonly ref Vec256<uint> LoadCpuVec(int row, out Vec256<uint> dst)
        {
            dst = load(ref data[row]);
            return ref dst;
        }

        /// <summary>
        /// Counts the number of enabled bits in the matrix
        /// </summary>
        [MethodImpl(Inline)] 
        public readonly BitSize Pop()
            => Z0.Bits.pop(data);

        /// <summary>
        /// Converts the matrix to a bitvector
        /// </summary>
        [MethodImpl(Inline)]
        public readonly BitVector<N1024,uint> ToBitVector()
            => BitVector.Load(data, zfunc.n1024);

        /// <summary>
        /// Constructs a 32-node graph via the adjacency matrix interpretation
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)]    
        public Graph<byte> ToGraph()
            => BitGraph.FromMatrix<byte,N32,byte>(BitMatrix<N32,N32,byte>.Load(Bytes));

        [MethodImpl(Inline)]
        public string Format()
            => data.FormatMatrixBits(32);

        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode()
            => throw new NotSupportedException();
        
        public override string ToString()
            => Format();

        static BitMatrix32 And(in BitMatrix32 A, in BitMatrix32 B)
        {
            const int rowstep = 8;
            var dst = Alloc();
            for(var i=0; i< A.RowCount; i += rowstep)
            {
                var x1 = load(ref A[i]);
                var x2 = load(ref B[i]);
                dinx.and(x1,x2).StoreTo(ref dst[i]);
            }
            return dst;
        }

        static BitMatrix32 Or(in BitMatrix32 A, in BitMatrix32 B)
        {
            const int rowstep = 8;
            var dst = Alloc();
            for(var i=0; i< A.RowCount; i += rowstep)
            {
                var x1 = load(ref A[i]);
                var x2 = load(ref B[i]);
                Z0.Bits.or(in x1, in x2).StoreTo(ref dst[i]);
            }
            return dst;
        }

        static BitMatrix32 XOr(in BitMatrix32 A, in BitMatrix32 B)
        {
            const int rowstep = 8;
            var dst = Alloc();
            for(var i=0; i< A.RowCount; i += rowstep)
            {
                var x1 = load(ref A[i]);
                var x2 = load(ref B[i]);
                Z0.Bits.xor(in x1,in x2).StoreTo(ref dst[i]);
            }
            return dst;
        }

        static  BitMatrix32 Flip(in BitMatrix32 A)
        {
            const int rowstep = 8;
            var dst = Alloc();
            for(var i=0; i< A.RowCount; i += rowstep)
            {
                var x1 = load(ref A[i]);
                Z0.Bits.flip(in x1).StoreTo(ref dst[i]);
            }
            return dst;
        }

        static BitVector32 Mul(in BitMatrix32 A, in BitVector32 x)
        {
            var dst = BitVector32.Alloc();
            for(var i=0; i< N; i++)
                dst[i] = A.RowVector(i) % x;
            return dst;        
        }

        static BitMatrix32 Mul(in BitMatrix32 A, in BitMatrix32 B)
        {
            var dst = Alloc();
            var x = A;
            var y = B.Transpose();
            for(var row=0; row< N; row++)
            {
                var r = x.RowVector(row);
                for(var col = 0; col< N; col++)
                    dst[row,col] = y.RowVector(col) % r;
            }
            return dst;

        }

        [MethodImpl(Inline)]
        static unsafe Vec256<uint> load(ref uint head)
            => Avx.LoadVector256(refptr(ref head));

        static ReadOnlySpan<byte> Identity32x32 => new byte[]
        {
            Pow2.T00, 0, 0, 0,
            Pow2.T01, 0, 0, 0,
            Pow2.T02, 0, 0, 0,
            Pow2.T03, 0, 0, 0,
            Pow2.T04, 0, 0, 0,
            Pow2.T05, 0, 0, 0,
            Pow2.T06, 0, 0, 0,
            Pow2.T07, 0, 0, 0,
            0, Pow2.T00, 0, 0,
            0, Pow2.T01, 0, 0,
            0, Pow2.T02, 0, 0,
            0, Pow2.T03, 0, 0,
            0, Pow2.T04, 0, 0,
            0, Pow2.T05, 0, 0,
            0, Pow2.T06, 0, 0,
            0, Pow2.T07, 0, 0,
            0, 0, Pow2.T00, 0,
            0, 0, Pow2.T01, 0,
            0, 0, Pow2.T02, 0,
            0, 0, Pow2.T03, 0,
            0, 0, Pow2.T04, 0,
            0, 0, Pow2.T05, 0,
            0, 0, Pow2.T06, 0,
            0, 0, Pow2.T07, 0,
            0, 0, 0, Pow2.T00,
            0, 0, 0, Pow2.T01,
            0, 0, 0, Pow2.T02,
            0, 0, 0, Pow2.T03,
            0, 0, 0, Pow2.T04,
            0, 0, 0, Pow2.T05,
            0, 0, 0, Pow2.T06,
            0, 0, 0, Pow2.T07,

        };

    }
}