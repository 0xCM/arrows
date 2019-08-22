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
    public ref struct BitMatrix32
    {                
        Span<uint> bits;

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
        /// Allocates an identity matrix
        /// </summary>
        public static BitMatrix32 Identity 
        {
            [MethodImpl(Inline)]
            get => Load(Identity32x32);
        }

        /// <summary>
        /// Allocates a zero matrix
        /// </summary>
        public static BitMatrix32 Zero 
        {
            [MethodImpl(Inline)]
            get => Load(new uint[N]);
        }
        
        [MethodImpl(Inline)]
        public static BitMatrix32 Alloc()        
            => Load(new uint[N]);

        [MethodImpl(Inline)]
        public static BitMatrix32 FromParts(params uint[] src)        
            => src.Length == 0 ? Alloc() : new BitMatrix32(src);

        [MethodImpl(Inline)]
        public static BitMatrix32 Load(ReadOnlySpan<byte> src)        
            => new BitMatrix32(src.As<byte,uint>());

        [MethodImpl(Inline)]
        public static BitMatrix32 Load(Span<uint> src)        
            => new BitMatrix32(src);

        [MethodImpl(Inline)]
        public static BitMatrix32 Load(ReadOnlySpan<uint> src)        
            => new BitMatrix32(src);

        /// <summary>
        /// Applies element-wise addition to corresponding operand entries. Note that this operator
        /// is equivalent to the XOr (^) operator
        /// </summary>
        /// <param name="lhs">The left matrix</param>
        /// <param name="rhs">The right matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix32 operator + (BitMatrix32 lhs, BitMatrix32 rhs)
            => XOr(ref lhs, rhs);

        /// <summary>
        /// Negates the operand. Note that this operator is equivalent to the complement operator (~)
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix32 operator - (BitMatrix32 src)
            => Flip(ref src);

        [MethodImpl(Inline)]
        public static BitMatrix32 operator - (BitMatrix32 lhs, BitMatrix32 rhs)
            => lhs + -rhs;

        [MethodImpl(Inline)]
        public static BitMatrix32 operator * (BitMatrix32 lhs, BitMatrix32 rhs)
            => Mul(ref lhs, rhs);

        [MethodImpl(Inline)]
        public static BitVector32 operator * (BitMatrix32 lhs, BitVector32 rhs)
            => Mul(lhs,rhs);

        [MethodImpl(Inline)]
        public static BitMatrix32 operator & (BitMatrix32 lhs, BitMatrix32 rhs)
            => And(ref lhs, rhs);

        [MethodImpl(Inline)]
        public static BitMatrix32 operator | (BitMatrix32 lhs, BitMatrix32 rhs)
            => Or(ref lhs, rhs);

        /// <summary>
        /// Applies element-wise XOR to corresponding operand entries. Note that this
        /// is equivalent to the addition operator (+) 
        /// </summary>
        /// <param name="lhs">The left matrix</param>
        /// <param name="rhs">The right matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix32 operator ^ (BitMatrix32 lhs, BitMatrix32 rhs)
            => XOr(ref lhs, rhs);

        /// <summary>
        /// Computes the complement of the operand. Note that this operator is 
        /// equivalent to the negation operator (-)
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)]
        public static BitMatrix32 operator ~ (BitMatrix32 src)
            => Flip(ref src);

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
            this.bits = src;
        }

        [MethodImpl(Inline)]
        BitMatrix32(ReadOnlySpan<uint> src)
        {                        
            require(src.Length == Pow2.T05);
            this.bits = src.Replicate();
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
            => Load(bits.ReadOnly()); 

        /// <summary>
        /// Extracts the bits that comprise the matrix in row-major order
        /// </summary>
        [MethodImpl(Inline)]
        public readonly Span<Bit> Unpack()
            => bits.Unpack(out Span<Bit> dst);

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
 
        [MethodImpl(Inline)]
        public readonly BitVector32 RowVec(int index)
            => bits[index];

        /// <summary>
        /// Returns a mutable reference for an index-identified matrix row
        /// </summary>
        /// <param name="row">The row index</param>
        [MethodImpl(Inline)]
        public ref uint RowData(int row)
            => ref bits[row];

        /// <summary>
        /// A mutable indexer, functionally equivalent to <see cref='RowData' /> function
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
            => bits.Swap(i,j);

        public readonly uint ColData(int index)
        {
            uint col = 0;
            for(var r = 0; r < N; r++)
                BitMask.setif(in bits[r], index, ref col, r);
            return col;
        }
        
        [MethodImpl(Inline)]
        public readonly BitVector32 ColVec(int index)
            => ColData(index);

        /// <summary>
        /// Returns the underlying matrix data as a span of bytes
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)] 
        public Span<byte> Bytes()
            => bits.AsBytes();

        [MethodImpl(Inline)]
        public bool Equals(in BitMatrix32 rhs)
            => this.AndNot(rhs).IsZero();

        [MethodImpl(Inline)]
        public readonly bool IsZero()
        {
            const int rowstep = 8;
            for(var i=0; i< RowCount; i += rowstep)
            {
                this.LoadVector(out Vec256<uint> vSrc, i);
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
                this.LoadVector(out Vec256<uint> vLhs, i);
                rhs.LoadVector(out Vec256<uint> vRhs, i);
                vLhs.AndNot(vRhs).StoreTo(ref bits[i]);
            }
            return this;
        }

        
        public readonly BitMatrix32 Transpose()
        {
            var dst = Replicate();
            for(var i=0; i<N; i++)
                dst.bits[i] = ColData(i);
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
        public readonly ref Vec256<uint> LoadVector(out Vec256<uint> dst, int row)
        {
            dst = load(ref bits[row]);
            return ref dst;
        }

        /// <summary>
        /// Counts the number of enabled bits in the matrix
        /// </summary>
        [MethodImpl(Inline)] 
        public readonly BitSize Pop()
            => Bits.pop(bits);

        /// <summary>
        /// Converts the matrix to a bitvector
        /// </summary>
        [MethodImpl(Inline)]
        public readonly BitVector<N1024,uint> ToBitVector()
            => BitVector.Load(bits, Nats.N1024);

        /// <summary>
        /// Constructs a 32-node graph via the adjacency matrix interpretation
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)]    
        public Graph<byte> ToGraph()
            => BitMatrix.ToGraph<byte,N32,byte>(new BitMatrix<N32,N32,byte>(Bytes()));

        [MethodImpl(Inline)]
        public readonly string Format()
            => MemoryMarshal.AsBytes(bits).FormatMatrixBits(32);

        static ref BitMatrix32 And(ref BitMatrix32 lhs, in BitMatrix32 rhs)
        {
            const int rowstep = 8;
            for(var i=0; i< lhs.RowCount; i += rowstep)
            {
                lhs.LoadVector(out Vec256<uint> vLhs, i);
                rhs.LoadVector(out Vec256<uint> vRhs, i);
                vLhs.And(vRhs).StoreTo(ref lhs.bits[i]);                
            }
            return ref lhs;
        }

        static ref BitMatrix32 Or(ref BitMatrix32 lhs, in BitMatrix32 rhs)
        {
            const int rowstep = 8;
            for(var i=0; i< lhs.RowCount; i += rowstep)
            {
                lhs.LoadVector(out Vec256<uint> vLhs, i);
                rhs.LoadVector(out Vec256<uint> vRhs, i);
                vLhs.Or(vRhs).StoreTo(ref lhs.bits[i]);                
            }
            return ref lhs;
        }

        static ref BitMatrix32 XOr(ref BitMatrix32 lhs, in BitMatrix32 rhs)
        {
            const int rowstep = 8;
            for(var i=0; i< lhs.RowCount; i += rowstep)
            {
                lhs.LoadVector(out Vec256<uint> vLhs, i);
                rhs.LoadVector(out Vec256<uint> vRhs, i);
                vLhs.XOr(vRhs).StoreTo(ref lhs.bits[i]);                
            }
            return ref lhs;
        }

        static ref BitMatrix32 Flip(ref BitMatrix32 src)
        {
            const int rowstep = 8;
            for(var i=0; i< src.RowCount; i += rowstep)
            {
                src.LoadVector(out Vec256<uint> vSrc, i);
                vSrc.Flip().StoreTo(ref src.bits[i]);
            }
            return ref src;
        }

        static BitVector32 Mul(in BitMatrix32 x, in BitVector32 y)
        {
            var dst = BitVector32.Alloc();
            for(var i=0; i< N; i++)
                dst[i] = x.RowVec(i) % y;
            return dst;        
        }


        static ref BitMatrix32 Mul(ref BitMatrix32 lhs, in BitMatrix32 rhs)
        {
            var x = lhs.Replicate();
            var y = rhs.Transpose();

            for(var i=0; i< N; i++)
            {
                var r = x.RowVec(i);
                for(var j = 0; j< N; j++)
                    lhs[i,j] = y.RowVec(j) % r;
            }
            return ref lhs;

        }

        [MethodImpl(Inline)]
        static unsafe Vec256<uint> load(ref uint head)
            => Avx.LoadVector256(refptr(ref head));

        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode()
            => throw new NotSupportedException();


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