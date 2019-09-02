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
    
    public struct BitMatrix32
    {                
        Memory<uint> data;        

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
            get => new BitMatrix32(new uint[N]);
        }
                
        [MethodImpl(Inline)]
        public static BitMatrix32 Alloc()        
            => new BitMatrix32(new Memory<uint>(new uint[N]));

        [MethodImpl(Inline)]
        public static BitMatrix32 FromParts(params uint[] src)        
            => src.Length == 0 ? Alloc() : new BitMatrix32(src.ToMemory());

        [MethodImpl(Inline)]
        public static BitMatrix32 Load(ReadOnlySpan<byte> src)        
            => new BitMatrix32(src.As<byte,uint>().ToMemory());

        [MethodImpl(Inline)]
        public static BitMatrix32 Load(ReadOnlySpan<uint> src)        
            => new BitMatrix32(src.ToMemory());

        [MethodImpl(Inline)]
        public static BitMatrix32 Load(Memory<uint> src)        
            => new BitMatrix32(src);

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
        BitMatrix32(Memory<uint> src)
        {                        
            require(src.Length == Pow2.T05);
            this.data = src.ToArray();
        }        

        [MethodImpl(Inline)]
        BitMatrix32(uint[] src)
        {                        
            require(src.Length == Pow2.T05);
            this.data = src;
        }        

        readonly Span<uint> Bits
        {
            [MethodImpl(Inline)]
            get => data.Span;
        }

        /// <summary>
        /// Reads the bit in a specified cell
        /// </summary>
        /// <param name="row">The row index</param>
        /// <param name="col">The column index</param>
        [MethodImpl(Inline)]
        public readonly Bit GetBit(int row, int col)
            => BitMask.test(in Bits[row], col);

        /// <summary>
        /// Sets the bit in a specified cell
        /// </summary>
        /// <param name="row">The row index</param>
        /// <param name="col">The column index</param>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public void SetBit(int row, int col, Bit src)
            => BitMask.set(ref Bits[row], (byte)col, src);

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
            => new BitMatrix32(data.ToArray());

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
        /// A readonly view of the matrix storage
        /// </summary>
        public readonly ReadOnlyMemory<uint> Data
        {
            [MethodImpl(Inline)]
            get => data;
        }

        [MethodImpl(Inline)]
        public readonly BitVector32 RowVec(int index)
            => Bits[index];

        /// <summary>
        /// Returns a mutable reference for an index-identified matrix row
        /// </summary>
        /// <param name="row">The row index</param>
        [MethodImpl(Inline)]
        public ref uint RowData(int row)
            => ref Bits[row];

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
            => Bits.Swap(i,j);

        public readonly uint ColData(int index)
        {
            uint col = 0;
            for(var r = 0; r < N; r++)
                BitMask.setif(in Bits[r], index, ref col, r);
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
        public readonly Span<byte> Bytes()
            => Bits.AsBytes();

        [MethodImpl(Inline)]
        public bool Equals(in BitMatrix32 rhs)
            => this.AndNot(rhs).IsZero();

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
                vLhs.AndNot(vRhs).StoreTo(ref Bits[i]);
            }
            return this;
        }
        
        public readonly BitMatrix32 Transpose()
        {
            var dst = Replicate();
            for(var i=0; i<N; i++)
                dst.Bits[i] = ColData(i);
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
            dst = load(ref Bits[row]);
            return ref dst;
        }

        /// <summary>
        /// Counts the number of enabled bits in the matrix
        /// </summary>
        [MethodImpl(Inline)] 
        public readonly BitSize Pop()
            => Z0.Bits.pop(Bits);

        /// <summary>
        /// Converts the matrix to a bitvector
        /// </summary>
        [MethodImpl(Inline)]
        public readonly BitVector<N1024,uint> ToBitVector()
            => BitVector.FromCells(Bits, Nats.N1024);

        /// <summary>
        /// Constructs a 32-node graph via the adjacency matrix interpretation
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)]    
        public Graph<byte> ToGraph()
            => BitGraph.FromMatrix<byte,N32,byte>(new BitMatrix<N32,N32,byte>(Bytes().ToMemory()));

        [MethodImpl(Inline)]
        public readonly string Format()
            => Bytes().FormatMatrixBits(32);

        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode()
            => throw new NotSupportedException();

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
                dst[i] = A.RowVec(i) % x;
            return dst;        
        }

        static BitMatrix32 Mul(in BitMatrix32 A, in BitMatrix32 B)
        {
            var dst = Alloc();
            var x = A;
            var y = B.Transpose();
            for(var row=0; row< N; row++)
            {
                var r = x.RowVec(row);
                for(var col = 0; col< N; col++)
                    dst[row,col] = y.RowVec(col) % r;
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