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

    using static zfunc;

    public struct BitMatrix4 : IBitMatrix
    {        
        byte[] data;

        public static readonly N4 N = default;

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
        
        public static BitMatrix4 Identity 
        {
            [MethodImpl(Inline)]
            get => Define(Identity4x4);
        }

        public static BitMatrix4 Zero 
        {            
            [MethodImpl(Inline)]
            get => Define(0,0);
        }

        [MethodImpl(Inline)]
        public static BitMatrix4 Define(params byte[] src)        
            => src.Length == 0 ? new BitMatrix4(0,0)  : new BitMatrix4(src);

        public static BitMatrix4 Define(ushort src)
            => Define(BitConverter.GetBytes(src));

        [MethodImpl(Inline)]
        public static BitMatrix4 Define(Span<byte> src)        
            => new BitMatrix4(src);

        [MethodImpl(Inline)]
        public static BitMatrix4 Define(ReadOnlySpan<byte> src)        
            => new BitMatrix4(src);

        [MethodImpl(Inline)]
        public static explicit operator ushort(BitMatrix4 src)
            => BitConverter.ToUInt16(src.data);

        [MethodImpl(Inline)]
        public static explicit operator BitMatrix4(ushort src)
            => Define(src);

        [MethodImpl(Inline)]
        public static bool operator ==(BitMatrix4 lhs, BitMatrix4 rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(BitMatrix4 lhs, BitMatrix4 rhs)
            => !(lhs.Equals(rhs));

        [MethodImpl(Inline)]
        public static BitMatrix4 operator + (BitMatrix4 lhs, BitMatrix4 rhs)
            => XOr(ref lhs,rhs);

        [MethodImpl(Inline)]
        public static BitMatrix4 operator * (BitMatrix4 lhs, BitMatrix4 rhs)
            => And(ref lhs,rhs);

        [MethodImpl(Inline)]
        public static BitMatrix4 operator - (BitMatrix4 src)
            => Flip(ref src);

        [MethodImpl(Inline)]
        public static BitMatrix4 operator | (BitMatrix4 lhs, BitMatrix4 rhs)
            => Or(ref lhs, rhs);
            
        [MethodImpl(Inline)]
        BitMatrix4(params byte[] src)
        {                    
            require(src.Length == Pow2.T01);
            this.data = src;
            
        }

        [MethodImpl(Inline)]
        BitMatrix4(ushort src)
        {                    
            this.data = BitConverter.GetBytes(src);            
        }

        [MethodImpl(Inline)]
        BitMatrix4(ReadOnlySpan<byte> src)
        {                    
            require(src.Length == Pow2.T01);
            this.data = src.ToArray();
        }


        /// <summary>
        /// Loads a matrix from the source value
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static BitMatrix4 Load(ushort src)        
            => new BitMatrix4(src);

        /// <summary>
        /// Allocates a matrix, optionally assigning each element to the
        /// specified bit value
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix4 Alloc(Bit? fill = null)                
            => fill == Bit.On ? Load(UInt16.MaxValue) : Load(0);
        public int RowCount
        {
            [MethodImpl(Inline)]
            get => N;
        }

        public int ColCount
        {
            [MethodImpl(Inline)]
            get => N;
        }

        /// <summary>
        /// Returns a mutable reference for an index-identified matrix row
        /// </summary>
        /// <param name="row">The row index</param>
        [MethodImpl(Inline)]
        public ref byte RowData(int row)
            => ref data[row];

        /// <summary>
        /// Queries the matrix for the data in an index-identified row and returns
        /// the bitvector representative
        /// </summary>
        /// <param name="index">The row index</param>
        [MethodImpl(Inline)]
        public readonly BitVector4 RowVector(int index)
            => data[index];

        [MethodImpl(Inline)]
        readonly Bit GetBit(int row, int col)
        {
            var index = row <= 1 ? 0 : 1;
            var pos = (row == 0 || row == 2) ? col : col + 4;
            return gbits.test(in data[index], pos);
        }

        [MethodImpl(Inline)]
        void SetBit(int row, int col, Bit value)
        {
            var index = row <= 1 ? 0 : 1;
            var pos = (row == 0 || row == 2) ? col : col + 4;
            gbits.set(ref data[index], (byte)pos, value);
        }

        public Bit this[int row, int col]
        {
            [MethodImpl(Inline)]
            get => GetBit(row,col);

            [MethodImpl(Inline)]
            set => SetBit(row, col,value);
        }            

        /// <summary>
        /// A mutable indexer
        /// </summary>
        /// <param name="row">The row index</param>
        public ref byte this[int row]
        {
            [MethodImpl(Inline)]
            get => ref RowData(row);
        }

        [MethodImpl(Inline)]
        public readonly bool IsZero()
            => BitConverter.ToUInt16(data) == 0;

        /// <summary>
        /// Returns the underlying matrix bits as a span of bytes
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)] 
        public Span<byte> Bytes()
            => data;

        [MethodImpl(Inline)] 
        public BitMatrix4 AndNot(in BitMatrix4 rhs)
            => AndNot(ref this, rhs);

        public readonly BitVector4 Diagonal()
        {
            var dst = (byte)0;
            for(byte i=0; i < BitMatrix4.N; i++)
                if(GetBit(i,i))
                    BitMask.enable(ref dst, i);
            return dst;                    
        }

        /// <summary>
        /// Extracts the bits that comprise the matrix in row-major order
        /// </summary>
        [MethodImpl(Inline)]
        public readonly Span<Bit> Unpack()
            => data.Unpack(out Span<Bit> dst);

        [MethodImpl(Inline)] 
        public readonly BitMatrix4 Replicate()
            => BitMatrix4.Define(data.Replicate());

        [MethodImpl(Inline)]
        public readonly bool Equals(in BitMatrix4 rhs)
            => BitConverter.ToUInt16(data) == rhs.Bytes().TakeUInt16();

        [MethodImpl(Inline)]
        public readonly string Format()
            => data.FormatMatrixBits(4);

        /// <summary>
        /// Creates a new matrix by cloning the existing matrix or allocating
        /// a matrix with the same structure
        /// </summary>
        /// <param name="structureOnly">Specifies whether the replication reproduces
        /// only structure and is thus equivalent to an allocation</param>
        [MethodImpl(Inline)] 
        public readonly BitMatrix4 Replicate(bool structureOnly = false)
            => structureOnly ? Alloc() : Define(data.Replicate());

        /// <summary>
        /// Queries the matrix for the data in an index-identified column 
        /// </summary>
        /// <param name="index">The row index</param>
        public readonly byte ColData(int index)
        {
            byte col = 0;
            for(var r = 0; r < N; r++)
                if(BitMask.test(in data[r], index))
                    BitMask.enable(ref col, r);
            return col;
        }

        /// <summary>
        /// Transposes a copy of the matrix
        /// </summary>
        public readonly BitMatrix4 Transpose()
        {
            var dst = Replicate();
            for(var i=0; i<N; i++)
                dst.data[i] = ColData(i);
            return dst;
        }

        /// <summary>
        /// Converts the matrix to a bitvector
        /// </summary>
        [MethodImpl(Inline)]
        public BitVector16 ToBitVector()
            => BitVector16.FromScalar((ushort)this);

        [MethodImpl(Inline)]
        static ref BitMatrix4 And(ref BitMatrix4 lhs, in BitMatrix4 rhs)
        {
             lhs.data = BitConverter.GetBytes((ushort) ((ushort)lhs & (ushort)rhs));
             return ref lhs;
        }

        [MethodImpl(Inline)]
        static ref BitMatrix4 XOr(ref BitMatrix4 lhs, in BitMatrix4 rhs)
        {
             lhs.data = BitConverter.GetBytes((ushort) ((ushort)lhs ^ (ushort)rhs));
             return ref lhs;
        }

        [MethodImpl(Inline)]
        static ref BitMatrix4 Or(ref BitMatrix4 lhs, in BitMatrix4 rhs)
        {
             lhs.data =  BitConverter.GetBytes((ushort) ((ushort)lhs | (ushort)rhs));
             return ref lhs;
        }

        [MethodImpl(Inline)]
        static ref BitMatrix4 AndNot(ref BitMatrix4 lhs, in BitMatrix4 rhs)
        {
             lhs.data = BitConverter.GetBytes((ushort)lhs &~ (ushort)rhs);
             return ref lhs;
        }

        [MethodImpl(Inline)]
        static ref BitMatrix4 Flip(ref BitMatrix4 src)
        {
             src.data = BitConverter.GetBytes(((ushort) (~(ushort)src)));
             return ref src;
        }

        static ref BitMatrix4 Mul(ref BitMatrix4 lhs, in BitMatrix4 rhs)
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

        static ReadOnlySpan<byte> Identity4x4 => new byte[] 
        {
            0b1000_0100, 
            0b0010_0001
        };

    }
}