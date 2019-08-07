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


    public ref struct BitMatrix4
    {        
        Memory<byte> data;

        internal Span<byte> bits
            => data.Span;

        public const uint Size = 16;

        public const uint RowSize = 4;
        
        public static readonly N4 N = default;

        public static BitMatrix4 Identity 
        {
            [MethodImpl(Inline)]
            get => Define(BitMatrixStore.Identity4x4);
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
            => BitConverter.ToUInt16(src.bits);

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
        public static BitMatrix4 operator & (BitMatrix4 lhs, BitMatrix4 rhs)
            => And(ref lhs,rhs);

        [MethodImpl(Inline)]
        public static BitMatrix4 operator * (BitMatrix4 lhs, BitMatrix4 rhs)
            => And(ref lhs,rhs);

        [MethodImpl(Inline)]
        public static BitMatrix4 operator | (BitMatrix4 lhs, BitMatrix4 rhs)
            => Or(ref lhs, rhs);

        [MethodImpl(Inline)]
        public static BitMatrix4 operator ^ (BitMatrix4 lhs, BitMatrix4 rhs)
            => XOr(ref lhs, rhs);

        [MethodImpl(Inline)]
        public static BitMatrix4 operator ~ (BitMatrix4 src)
            => Flip(ref src);
            
        [MethodImpl(Inline)]
        BitMatrix4(params byte[] src)
        {                    
            require(src.Length == Pow2.T01);
            this.data = src;
        }

        [MethodImpl(Inline)]
        BitMatrix4(ReadOnlySpan<byte> src)
        {                    
            require(src.Length == Pow2.T01);
            this.data = src.ToArray();
        }

        [MethodImpl(Inline)]
        BitMatrix4(Span<byte> src)
        {
            require(src.Length == Pow2.T01);
            this.data = src.ToArray();
        }

        public int RowDim
            => N;

        public int ColDim
            => N;

        [MethodImpl(Inline)]
        Bit GetBit(int row, int col)
        {
            var index = row <= 1 ? 0 : 1;
            var pos = (row == 0 || row == 2) ? col : col + 4;
            return gbits.test(in bits[index],pos);
        }

        [MethodImpl(Inline)]
        void SetBit(int row, int col, Bit value)
        {
            var index = row <= 1 ? 0 : 1;
            var pos = (row == 0 || row == 2) ? col : col + 4;
            gbits.set(ref bits[index], (byte)pos, value);
        }

        public Bit this[int row, int col]
        {
            [MethodImpl(Inline)]
            get => GetBit(row,col);

            [MethodImpl(Inline)]
            set => SetBit(row, col,value);
        }            

        [MethodImpl(Inline)]
        public bool IsZero()
            => BitConverter.ToUInt16(bits) == 0;

        /// <summary>
        /// Returns the underlying matrix data as a span of bytes
        /// </summary>
        /// <param name="src">The source matrix</param>
        [MethodImpl(Inline)] 
        public Span<byte> Bytes()
            => bits;

        [MethodImpl(Inline)] 
        public BitMatrix4 AndNot(in BitMatrix4 rhs)
            => AndNot(ref this, rhs);

        public BitVector4 Diagonal()
        {
            var dst = (byte)0;
            for(byte i=0; i < BitMatrix4.N; i++)
                if(this[i,i])
                    BitMask.enable(ref dst, i);
            return dst;                    
        }


        /// <summary>
        /// Extracts the bits that comprise the matrix in row-major order
        /// </summary>
        [MethodImpl(Inline)]
        public Span<Bit> Unpack()
            => bits.Unpack(out Span<Bit> dst);


        [MethodImpl(Inline)] 
        public BitMatrix4 Replicate()
            => BitMatrix4.Define(bits.ReadOnly());


        [MethodImpl(Inline)]
        public bool Equals(in BitMatrix4 rhs)
            => bits.TakeUInt16() == rhs.bits.TakeUInt16();

        [MethodImpl(Inline)]
        public string Format()
            => bits.FormatMatrixBits(4);

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


        public override bool Equals(object obj)
            => throw new NotSupportedException();
        
        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}