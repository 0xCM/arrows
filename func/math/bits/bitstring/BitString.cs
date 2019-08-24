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

    /// <summary>
    /// Represents a sequence of bits
    /// </summary>
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

        [MethodImpl(Inline)]
        public static bool operator ==(BitString lhs, BitString rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(BitString lhs, BitString rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static BitString operator +(BitString lhs, BitString rhs)
            => lhs.Concat(rhs);
        

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

        /// <summary>
        /// Queries/manipulates bit at specified index
        /// </summary>
        public Bit this[int index]
        {
            [MethodImpl(Inline)]
            get => bitseq[index];

            [MethodImpl(Inline)]
            set => bitseq[index] = (byte)value;
        }

        /// <summary>
        /// Extracts a substring determined by start/end indices
        /// </summary>
        public BitString this[BitPos i0, BitPos i1]
        {
            [MethodImpl(Inline)]
            get => new BitString(BitSeq.Slice(i0, i1 - i0));
        }

        /// <summary>
        /// Extracts a substring determined by a range
        /// </summary>
        public BitString this[Range range]
        {
            [MethodImpl(Inline)]
            get => this[range.Start.Value, range.End.Value];
        }

        public readonly int Length
        {
            [MethodImpl(Inline)]
            get => bitseq.Length;
        }            

        public readonly bool IsEmpty
            => this.bitseq.Length == 0;

        public BitString Zero 
            => Empty;

        /// <summary>
        /// The (unpacked) sequence of bits represented by the bitstring
        /// </summary>
        public Span<byte> BitSeq
        {
            [MethodImpl(Inline)]
            get => bitseq ?? Span<byte>.Empty;
        }

        /// <summary>
        /// Renders a segment as a packed primal value
        /// </summary>
        /// <typeparam name="T">The primal type</typeparam>
        /// <param name="offset">The index of the first bit </param>
        [MethodImpl(Inline)]
        public T TakeValue<T>(int offset = 0)
            where T : struct
                => PackSingle<T>(offset, Unsafe.SizeOf<T>());

        /// <summary>
        /// Renders a bitstring segment as a packed byte value
        /// </summary>
        /// <param name="offset">The index of the first bit </param>
        [MethodImpl(Inline)]
        public byte TakeUInt8(int offset = 0)
            => TakeValue<byte>(offset);

        /// <summary>
        /// Renders a bitstring segment as a packed ushort value
        /// </summary>
        /// <param name="offset">The index of the first bit </param>
        [MethodImpl(Inline)]
        public ushort TakeUInt16(int offset = 0)
            => TakeValue<ushort>(offset);

        /// <summary>
        /// Renders a bitstring segment as a packed uint value
        /// </summary>
        /// <param name="offset">The index of the first bit </param>
        [MethodImpl(Inline)]
        public uint TakeUInt32(int offset = 0)
            => TakeValue<uint>(offset);

        /// <summary>
        /// Renders a bitstring segment as a packed ulong value
        /// </summary>
        /// <param name="offset">The index of the first bit </param>
        [MethodImpl(Inline)]
        public ulong TakeUInt64(int offset = 0)
            => TakeValue<ulong>(offset);

        /// <summary>
        /// Packs a section of the represented bits into a bytespan
        /// </summary>
        /// <param name="offset">The position of the first bit</param>
        /// <param name="minlen">The the minimum length of the produced span</param>
        [MethodImpl(Inline)]
        public readonly Span<byte> Pack(int offset = 0, int? minlen = null)
            => PackedBits(bitseq, offset, minlen);

        /// <summary>
        /// Packs represented bits span of specified scalar type
        /// </summary>
        /// <typeparam name="T">The target scalar type</typeparam>
        public Span<T> Pack<T>()
            where T : struct
        {            
            if(Length == 0)
                return new T[1];
            else            
            {
                var src = BitSeq;
                var seglen = 8;
                var segcount = divrem<N8>(Length, out int r);
                var dstLen = (segcount == 0 ? 1 : (r == 0 ? segcount : segcount + 1));
                var dst = new byte[dstLen];
                
                for(int i = 0, j=0; i< segcount - seglen;  j++, i+= seglen)
                    pack(src.Slice(i,seglen), ref dst[j]);
                
                if(r != 0)    
                    pack(src.Slice(segcount), ref dst[dstLen - 1]);
                
                return MemoryMarshal.Cast<byte,T>(dst);
            }                                
        }            

        static ref byte pack(in Span<byte> src, ref byte dst)
        {
            var last = Math.Min(Pow2.T03, src.Length) - 1;
            for(var i = 0; i <= last; i++)
                dst |= (byte)(src[i] << i);
            return ref dst;
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
        /// Counts the number of enabled bits
        /// </summary>
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

        /// <summary>
        /// Rotates the bits leftwards by a specified offset
        /// </summary>
        /// <param name="offset">The magnitude of the rotation</param>
        public void RotL(uint offset)
        {
            Span<byte> dst = bitseq;
            Span<byte> src = stackalloc byte[Length];
            dst.CopyTo(src);
            var cut = Length - (int)offset;
            var seg1 = src.Slice(0, cut);
            var seg2 = src.Slice(cut);
            seg2.CopyTo(dst, 0);
            seg1.CopyTo(dst, (int)offset);
        }

        /// <summary>
        /// Forms a new bitstring by concatenation
        /// </summary>
        /// <param name="tail">The trailing bits</param>
        public BitString Concat(BitString tail)
        {
            Span<byte> dst = new byte[Length + tail.Length];
            tail.BitSeq.CopyTo(dst);
            BitSeq.CopyTo(dst, tail.Length);
            return new BitString(dst);
        }

        /// <summary>
        /// Returns a new bitstring of length no greater than a specified maximum
        /// </summary>
        /// <param name="maxlen">The maximum length</param>
        public BitString Truncate(int maxlen)
        {
            if(Length <= maxlen)
                return new BitString(bitseq);
            
            Span<byte> src = bitseq;
            var dst = src.Slice(0,maxlen);
            return new BitString(dst.ToArray());
        }

        /// <summary>
        /// Returns a new bitstring of length no less than a specified minimum
        /// </summary>
        /// <param name="minlen">The minimum length</param>
        public BitString Pad(int minlen)
        {
            if(Length >= minlen)
                return new BitString(bitseq);
            
            Span<byte> src = bitseq;
            var dst = new byte[minlen];
            src.CopyTo(dst);
            return new BitString(dst);            
        }

        /// <summary>
        /// Converts the bistring to a binary digit representation
        /// </summary>
        public Span<BinaryDigit> ToDigits()
        {
            Span<BinaryDigit> dst = new BinaryDigit[bitseq.Length];
            for(var i=0; i< bitseq.Length; i++)
                dst[i] = (BinaryDigit)bitseq[i];
            return dst;
        }


        /// <summary>
        /// Renders the content as a span of bits
        /// </summary>
        public Span<Bit> ToBits()
        {
            Span<Bit> dst = new Bit[bitseq.Length];
            for(var i=0; i< bitseq.Length; i++)
                dst[i] = bitseq[i] == 1;
            return dst;
        }

        /// <summary>
        /// Determines whether this bitstring represents the same value as another, ignoring
        /// leading zeroes
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

        /// <summary>
        /// Partitions the bitstring into blocks of a specified maximum width
        /// </summary>
        /// <param name="width">The maximum block width</param>
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

        /// <summary>
        /// Formats bitstring using default parameter values
        /// </summary>
        [MethodImpl(Inline)]
        public string Format()
            => Format(false, false, null, null);

        public override string ToString()
            => Format();
        
        public override int GetHashCode()
            => bitseq.GetHashCode();

        public override bool Equals(object rhs)
            => (rhs is BitString x)  ? Equals(x) : false;

        readonly string FormatUnblocked(bool tlz, bool specifier)
        {
            if(bitseq == null || bitseq.Length == 0)
                return string.Empty;

            Span<char> dst = stackalloc char[bitseq.Length];
            var lastix = dst.Length - 1;
            for(var i=0; i< dst.Length; i++)
                dst[lastix - i] = bitseq[i] == 0 ? '0' : '1';
            
            var x = new string(dst);
            return  
                (specifier ? "0b" : string.Empty) 
              + (tlz ? x.TrimStart('0') : x);
        }

        [MethodImpl(Inline)]
        readonly T PackSingle<T>(int offset = 0, int? minlen = null)
            where T : struct
        {                        
            var src = bitseq.ToReadOnlySpan();
            var packed = PackedBits(src,offset,minlen);
            return packed.Length != 0 ? SpanConvert.TakeSingle<byte,T>(packed) : default;
        }


        /// <summary>
        /// Projects the bitstring onto a span via a supplied transformation
        /// </summary>
        /// <param name="f">The transformation</param>
        /// <typeparam name="T">The span element type</typeparam>
        public Span<T> Map<T>(Func<Bit,T> f)
        {
            Span<T> dst = new T[Length];
            for(var i=0; i<dst.Length; i++)
                dst[i] = f(bitseq[i]);
            return dst;
        }

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