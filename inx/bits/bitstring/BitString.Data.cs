//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;
    using static As;
    using static Constants;

    public readonly partial struct BitString : IWord<BitString, BinaryAlphabet>
    {
        readonly byte[] bitseq;

        /// <summary>
        /// Defines the canonical emtpy bitstring of 0 length
        /// </summary>
        public static readonly BitString Empty = Parse(string.Empty);

        [MethodImpl(Inline)]
        public static implicit operator string(BitString src)                
            => src.Format();

        public static bool operator ==(BitString lhs, BitString rhs)
            => lhs.Eq(rhs);

        public static bool operator !=(BitString lhs, BitString rhs)
            => !lhs.Eq(rhs);

        [MethodImpl(Inline)]
        public static BitString operator +(BitString lhs, BitString rhs)
            => lhs.Concat(rhs);
    
        [MethodImpl(Inline)]
        BitString(ReadOnlySpan<char> src)
        {
            var len = src.Length;            
            var lastix = len - 1;
            this.bitseq = new byte[len];

            for(var i=0; i <= lastix; i++)
                this.bitseq[i] = src[i] == '0' ? (byte)0 : (byte)1;
        }

        BitString(ReadOnlySpan<byte> src)
        {
            var len = src.Length;            
            var lastix = len - 1;
            this.bitseq = new byte[len];
            for(var i=0; i <= lastix; i++)
                this.bitseq[i] = src[i] == 0 ? (byte)0 : (byte)1;            
        }

        [MethodImpl(Inline)]
        BitString(ReadOnlySpan<Bit> src)
        {
            this.bitseq = new byte[src.Length];
            for(var i=0; i<src.Length; i++)
                this.bitseq[i] = (byte)src[i];
        }

        public bool IsEmpty
            => this.bitseq.Length == 0;

        public Bit this[int index]
        {
            [MethodImpl(Inline)]
            get => bitseq[index];
        }
            
        public int Length
        {
            [MethodImpl(Inline)]
            get => bitseq.Length;
        }            

        uint ILengthwise.Length 
            => (uint)Length;

        /// <summary>
        ///  Partitions the bitstring into blocks of a specified maximum width
        /// </summary>
        /// <param name="width">The maximum block width</param>
        /// <param name="tlz">Specifies whether leading source zeros should be exlcuded </param>
        public BitString[] Blocks(int width)
        {
            var minCount = Math.DivRem(bitseq.Length, width, out int remainder);
            var count = remainder != 0 ? minCount + 1 : minCount;
            Span<byte> src = bitseq;
            var dst = new BitString[count];
            var lastix = dst.Length - 1;            
            for(int i=0, offset = 0; i< dst.Length; i++, offset += width)
            {   
                if(i == lastix && remainder != 0)
                {
                    Span<byte> fullBlock = new byte[width];
                    src.Slice(offset,remainder).CopyTo(fullBlock);
                    dst[i] = new BitString(fullBlock);
                }                    
                else
                    dst[i] = new BitString(src.Slice(offset, width));
            }
            return dst;
        }

        /// <summary>
        /// Determines whether the value that another <see cref='BitString'/> represents is 
        /// equivalent to the value that this bitstring represents
        /// </summary>
        /// <param name="other">The bitstring with which the comparison will be made</param>
        [MethodImpl(Inline)]
        public bool Eq(BitString other)
        {                        
            var x = Format(true);
            var y = Format(true);
            return x == y;
        }
                  
        public BitString Zero 
            => Empty;

        public int PopCount()
        {
            var count = 0;
            for(var i=0; i<bitseq.Length; i++)
                if(bitseq[i] == 1)
                    count++;
            return count;
        }
        
        public ReadOnlySpan<char> ToBitChars()
        {
            Span<char> dst = new char[bitseq.Length];
            for(var i=0; i<dst.Length; i++)
                dst[i] =  bitseq[i] == 0 ? '0' : '1';
            return dst;
        }

        public ReadOnlySpan<BinaryDigit> ToDigits()
        {
            Span<BinaryDigit> digits = new BinaryDigit[bitseq.Length];
            for(var i=0; i< bitseq.Length; i++)
                digits[i] = (BinaryDigit)bitseq[i];
            return digits;
        }

        public ReadOnlySpan<byte> ToBitSeq()
            => bitseq;

        public override string ToString()
            => Format();
        
        public override int GetHashCode()
            => bitseq.GetHashCode();

        public override bool Equals(object rhs)
            => (rhs is BitString x)  ? Eq(x) : false;

        public BitString Concat(BitString rhs)
            => new BitString(concat(bitseq, rhs.bitseq));
    }
}