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
    using System.Runtime.InteropServices;
    using System.IO;
    
    using static zfunc;
    using static As;
    using static Constants;

    public partial struct BitString : IWord<BitString, BinaryAlphabet>
    {
        byte[] bitseq;

        /// <summary>
        /// Defines the canonical emtpy bitstring of 0 length
        /// </summary>
        public static readonly BitString Empty = Parse(string.Empty);

        [MethodImpl(Inline)]
        public static implicit operator string(BitString src)                
            => src.Format();

        public static bool operator ==(BitString lhs, BitString rhs)
            => lhs.Equals(rhs);

        public static bool operator !=(BitString lhs, BitString rhs)
            => !lhs.Equals(rhs);

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

        [MethodImpl(Inline)]
        BitString(byte[] src)
        {
            this.bitseq = src;
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

        public readonly bool IsEmpty
            => this.bitseq.Length == 0;

        public readonly Bit this[int index]
        {
            [MethodImpl(Inline)]
            get => bitseq[index];
        }
            
        public readonly int Length
        {
            [MethodImpl(Inline)]
            get => bitseq.Length;
        }            

        uint ILengthwise.Length 
            => (uint)Length;

        /// <summary>
        /// Renders a segment as a packed primal value
        /// </summary>
        /// <typeparam name="T">The primal type</typeparam>
        /// <param name="offset">The index of the first bit </param>
        [MethodImpl(Inline)]
        public T TakeValue<T>(int offset = 0)
            where T : struct
                => Pack<T>(offset, Unsafe.SizeOf<T>());

        [MethodImpl(Inline)]
        readonly T Pack<T>(int offset = 0, int? minlen = null)
            where T : struct
        {            
            var src = bitseq.ToReadOnlySpan();
            var packed = PackedBits(src,offset,minlen);
            return SpanConvert.TakeSingle<byte,T>(packed);
        }

        /// <summary>
        /// Renders a bitstring segment as a packed primal value
        /// </summary>
        /// <param name="offset">The index of the first bit </param>
        [MethodImpl(Inline)]
        public byte TakeUInt8(int offset = 0)
            => TakeValue<byte>(offset);

        /// <summary>
        /// Renders a bitstring segment as a packed primal value
        /// </summary>
        /// <param name="offset">The index of the first bit </param>
        [MethodImpl(Inline)]
        public ushort TakeUInt16(int offset = 0)
            => TakeValue<ushort>(offset);

        /// <summary>
        /// Renders a bitstring segment as a packed primal value
        /// </summary>
        /// <param name="offset">The index of the first bit </param>
        [MethodImpl(Inline)]
        public uint TakeUInt32(int offset = 0)
            => TakeValue<uint>(offset);

        /// <summary>
        /// Renders a bitstring segment as a packed primal value
        /// </summary>
        /// <param name="offset">The index of the first bit </param>
        [MethodImpl(Inline)]
        public ulong TakeUInt64(int offset = 0)
            => TakeValue<ulong>(offset);

        [MethodImpl(Inline)]
        public Span<byte> PackedBits(int offset = 0, int? minlen = null)
            => PackedBits(bitseq, offset, minlen);

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
        /// Counts the number of leading zero bits
        /// </summary>
        public int Nlz()
        {
            var lastix = bitseq.Length - 1;
            var count = 0;
            for(var i=lastix; i>= 0; i--)
            {
                if(bitseq[i] != 0)
                    break;
                else
                    count++;                
            }
            return count;
        }

        /// <summary>
        /// Determines whether the value that another <see cref='BitString'/> represents is 
        /// equivalent to the value that this bitstring represents
        /// </summary>
        /// <param name="rhs">The bitstring with which the comparison will be made</param>
        [MethodImpl(Inline)]
        public bool Equals(BitString rhs)
        {                                                            
            var xNlz = this.Nlz();
            var yNlz = rhs.Nlz();
            var xLastIx = bitseq.Length - 1 - xNlz;
            var yLastIx = rhs.bitseq.Length - 1 - yNlz;
            if(xLastIx != yLastIx)
                return false;
            
            for(var i=xLastIx; i >=0; i--)
                if(bitseq[i] != rhs.bitseq[i])
                    return false;
           
            return true;
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

        [MethodImpl(Inline)]        
        public BitString Replicate()
        {
            Span<byte> dst = new byte[Length];
            bitseq.CopyTo(dst);
            return new BitString(dst);
        }

        public void RotL(uint offset)
        {
            Span<byte> dst = bitseq;
            Span<byte> src = stackalloc byte[Length];
            dst.CopyTo(src);
            // dst.Fill(0);
            var cut = Length - (int)offset;
            var seg1 = src.Slice(0, cut);
            var seg2 = src.Slice(cut);
            seg2.CopyTo(dst, 0);
            seg1.CopyTo(dst, (int)offset);
        }

        /// <summary>
        /// Formats bitstring content
        /// </summary>
        /// <param name="tlz">Indicates whether leading zero bits should be eliminated from the result</param>
        /// <param name="specifier">True if the canonical 0b specifier is to precede bitstring content, false if to omit the speicifier</param>
        /// <param name="blockWidth">If unspecified, no blocking will be applied; otherwise, indicates the width of the block partitions</param>
        /// <param name="blocksep">If unspecified, when block formatting, indicates the default block delimiter (An ASCII space) will be used;
        /// if specified, when block formatting, indicates the block delimiter to place between the block partitions</param>
        public string Format(bool tlz = false, bool specifier = false, int? blockWidth = null, char? blocksep = null)
        {                                            
            if(blockWidth == null)
                return FormatUnblocked(tlz,specifier);
            else
            {
                var sep = blocksep ?? ' ';
                var sb = sbuild();
                var blocks = Blocks(blockWidth.Value).Reverse();
                var lastix = blocks.Length - 1;
                for(var i=0; i<=lastix; i++)
                {
                    sb.Append(blocks[i].FormatUnblocked(false,false));
                    if(i != lastix)
                        sb.Append(sep);
                }
                var x = sb.ToString();
                return  
                    (specifier ? "0b" : string.Empty) 
                +   (tlz ? x.TrimStart('0') : x);
            }            
        }

        [MethodImpl(Inline)]
        public string Format()
            => Format(false, false, null, null);

        public ReadOnlySpan<BinaryDigit> ToDigits()
        {
            Span<BinaryDigit> dst = new BinaryDigit[bitseq.Length];
            for(var i=0; i< bitseq.Length; i++)
                dst[i] = (BinaryDigit)bitseq[i];
            return dst;
        }

        /// <summary>
        /// Renders the content as a span of bits
        /// </summary>
        public ReadOnlySpan<Bit> ToBits()
        {
            Span<Bit> dst = new Bit[bitseq.Length];
            for(var i=0; i< bitseq.Length; i++)
                dst[i] = bitseq[i] == 1;
            return dst;
        }

        /// <summary>
        /// Returns the underlying sequence of bits represented by the bitstring
        /// </summary>
        public Span<byte> BitSeq
        {
            [MethodImpl(Inline)]
            get => bitseq;
        }

        readonly string FormatUnblocked(bool tlz, bool specifier)
        {
            Span<char> dst = stackalloc char[bitseq.Length];
            var lastix = dst.Length - 1;
            for(var i=0; i< dst.Length; i++)
                dst[lastix - i] = bitseq[i] == 0 ? '0' : '1';
            
            var x = new string(dst);
            return  
                (specifier ? "0b" : string.Empty) 
              + (tlz ? x.TrimStart('0') : x);
        }

        public override string ToString()
            => Format();
        
        public override int GetHashCode()
            => bitseq.GetHashCode();

        public override bool Equals(object rhs)
            => (rhs is BitString x)  ? Equals(x) : false;

        public BitString Concat(BitString rhs)
            => new BitString(concat(bitseq, rhs.bitseq));

        [MethodImpl(Inline)]
        static bool HasBitSpecifier(in string bs)
        {
            if(bs.Length < 2)
                return false;            
            return bs[0] == '0' && bs[1] == 'b';        
        }

        /// <summary>
        /// Constructs a bitstring from a span of primal values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        static BitString FromScalars<T>(ReadOnlySpan<T> src, int? maxlen = null)
            where T : struct
                 => new BitString(ReadBitSeq(src, maxlen));

        [PrimalKinds(PrimalKind.All)]
        static Span<byte> ReadBitSeq<T>(ReadOnlySpan<T> src, int? maxlen = null)
            where T : struct
        {
            require(typeof(T) != typeof(char));            
            var seglen = Unsafe.SizeOf<T>()*8;
            Span<byte> dst = new byte[src.Length * seglen];
            for(var i=0; i<src.Length; i++)
                BitStore.BitSeq(src[i]).CopyTo(dst, i*seglen);
            return maxlen != null && dst.Length >= maxlen ?  dst.Slice(0,maxlen.Value) :  dst;
        }

        static Span<byte> PackedBits(ReadOnlySpan<byte> src, int offset = 0, int? minlen = null)
        {            
            if(src.Length <= offset)
                return new byte[minlen ?? 1];

            var srcLen = (uint)(src.Length - offset);
            var dstLen = Mod<N8>.div(srcLen) + (Mod<N8>.mod(srcLen) == 0 ? 0 : 1);   
            if(minlen != null && dstLen < minlen)
                dstLen = minlen.Value;

            Span<byte> dst = new byte[dstLen];
            for(int i=0, j=0; j < dstLen; i+=8, j++)
            {
                ref var x = ref dst[j];
                for(var k=0; k<8; k++)
                {
                    var srcIx = i + k + offset;
                    if(srcIx < srcLen && src[srcIx] != 0)
                        BitMask.enable(ref x, in k);
                }
            }
            return dst;
        }

    }
}