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

    public readonly struct BitString : IWord<BitString, BinaryAlphabet>
    {
        /// <summary>
        /// The state
        /// </summary>
        readonly char[] content;

        readonly byte[] content2;

        /// <summary>
        /// Constructs a bitstring from primal value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static BitString From<T>(in T src)
            where T : struct
                => From(gbits.bstext(in src));

        /// <summary>
        /// Constructs a bitstring from a power of 2
        /// </summary>
        /// <param name="exp">The value of the expoonent</param>
        [MethodImpl(Inline)]
        public static BitString FromPow2(int exp)
        {
            Span<Bit> dst = stackalloc Bit[exp + 1];
            dst[exp] = 1;
            return From(dst);
        }

        /// <summary>
        /// Constructs a bitstring from a span of primal values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        static BitString From<T>(ReadOnlySpan<T> src)
            where T : struct
                => gbits.bitchars(src).Reverse();

        /// <summary>
        /// Constructs a bitstring from a span of primal values
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitString From<T>(Span<T> src)
            where T : struct
                => From(src.ReadOnly());

        /// <summary>
        /// Constructs a bitstring from a clr string of 0's and 1's 
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static BitString From(string src)                
            => new BitString(src);

        /// <summary>
        /// Constructs a bitstring from bitspan
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static BitString From(Span<Bit> src)                
            => new BitString(src);

        /// <summary>
        /// Constructs a bitstring from bitspan
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static BitString From(ReadOnlySpan<Bit> src)                
            => new BitString(src);

        /// <summary>
        /// Constructs a bitstring from a span of '0' and '1' characters
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static BitString From(Span<char> src)                
            => new BitString(src);

        /// <summary>
        /// Constructs a bitstring from a readonly span of '0' and '1' characters
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static BitString From(ReadOnlySpan<char> src)                
            => new BitString(src);

        /// <summary>
        /// Assembles a bistring given parts ordered from lo to hi
        /// </summary>
        /// <param name="parts">The source parts</param>
        [MethodImpl(Inline)]
        public static BitString Assemble(params string[] parts)
            => From(string.Join(string.Empty, parts.Reverse()));

        /// <summary>
        /// Assembles a bitstring from primal parts ordered from lo to hi
        /// </summary>
        /// <param name="parts">The primal values that define bitstring segments</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitString From<T>(params T[] parts)
            where T : struct
                => From(parts.ToSpan());

        /// <summary>
        /// Defines the canonical emtpy bitstring of 0 length
        /// </summary>
        public static readonly BitString Empty = From(string.Empty);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<char>(BitString src)                
            => src.Content;

        [MethodImpl(Inline)]
        public static implicit operator BitString(ReadOnlySpan<char> src)                
            => new BitString(src);

        [MethodImpl(Inline)]
        public static implicit operator BitString(Span<char> src)                
            => new BitString(src);

        [MethodImpl(Inline)]
        static string str(char[] src)
            => new string(src);

        [MethodImpl(Inline)]
        public static implicit operator string(BitString src)                
            => str(src.content);

        public static bool operator ==(BitString lhs, BitString rhs)
            => lhs.content == rhs.content;

        public static bool operator !=(BitString lhs, BitString rhs)
            => lhs.content == rhs.content;

        [MethodImpl(Inline)]
        public static BitString operator +(BitString hi, BitString lo)
            => From(str(hi.content) + str(lo.content));
    
        static ReadOnlySpan<char> Check(ReadOnlySpan<char> src, bool active = false)
        {
            if(active)
            {
                var lastix = src.Length -1;
                for(var i=0; i<src.Length; i++)
                {
                    ref readonly var c = ref src[i];
                    if(c != '0' || c != '1')
                    {
                        throw new ArgumentException("Found non-digit characters in the source");
                    }
                }
            }
            return src;
        }

        BitString(Span<byte> src)
        {
            this.content2 = src.ToArray();
            this.content = new char[src.Length];
            for(var i=0; i<src.Length; i++)
                this.content[i] = src[i] == 0 ? '0': '1';
        }

        [MethodImpl(Inline)]
        BitString(string content)            
        {
            this.content = content.ToCharArray();
            Check(this.content);
            this.content2 = new byte[content.Length];

            var len = content.Length;
            var lastix = len - 1;
            for(var i=0; i<content.Length; i++)
                content2[lastix - i] = (byte)(content[i] == '0' ? 0 : 1);
        }
            
        [MethodImpl(Inline)]
        BitString(ReadOnlySpan<Bit> content)
        {
            this.content = new char[content.Length];
            this.content2 = new byte[content.Length];
            for(var i=0; i<content.Length; i++)
            {
                this.content[i] = content[i];
                this.content2[i] = (byte)(content[i] ? 1 : 0);
            }
        }

        [MethodImpl(Inline)]
        BitString(ReadOnlySpan<char> content)
        {
            this.content = content.ToArray();
            Check(this.content);
            this.content2 = new byte[content.Length];
            for(var i=0; i< content.Length; i++)
                this.content2[i] = (byte)(content[i] == '0' ? 0 : 1);
        }

        public bool IsEmpty
            => this.content.Length == 0;

        public Bit this[int index]
        {
            [MethodImpl(Inline)]
            get => content[index];
        }
            
        public uint Length
        {
            [MethodImpl(Inline)]
            get => (uint)content.Length;
        }

        /// <summary>
        ///  Partitions the bitstring into blocks of a specified maximum width
        /// </summary>
        /// <param name="width">The maximum block width</param>
        /// <param name="tlz">Specifies whether leading source zeros should be exlcuded </param>
        public BitString[] Blocks(int width, bool tlz = false)
        {
            var strSrc = str(content);
            var src = tlz ? strSrc.TrimStart('0') : strSrc;

            var q = Math.DivRem(src.Length, width, out int r);
            var dst = new BitString[q + r];
            var len = dst.Length;
            var lastix = (len - 1);
            var j = 0;

            for(var i = 0; i < len; i++, j+= width)
            {                                
                if(i != lastix)
                    dst[i] = From(src.Substring(j, width));
                else
                {
                    if(r == 0)
                        dst[i] = From(src.Substring(j, width));
                    else 
                        dst[i] = From(src.Substring(j, r));
                }                    
            }
            Array.Reverse(dst);
            return dst;
        }

        /// <summary>
        ///  Partitions the bitstring into blocks of a specified maximum width
        /// </summary>
        /// <param name="width">The maximum block width</param>
        /// <param name="tlz">Specifies whether leading source zeros should be exlcuded </param>
        public BitString[] Blocks2(int width)
        {
            var minCount = Math.DivRem(content2.Length, width, out int remainder);
            var count = remainder != 0 ? minCount + 1 : minCount;
            Span<byte> src = content2;
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
            var x = Format2(true);
            var y = Format2(true);
            return x == y;
        }
             
        public ReadOnlySpan<char> Content
        {
            [MethodImpl(Inline)]
            get => content;
        }

        public BitString Zero 
            => Empty;

        const string Specifier = "0b";

        /// <summary>
        /// Copies the bit characters from this bitstring to a span at a specified offset
        /// </summary>
        /// <param name="dst">The target span</param>
        /// <param name="offset">The target span offset</param>
        [MethodImpl(Inline)]
        public void CopyTo(Span<char> dst, int offset = 0)
            => Content.CopyTo(dst.Slice(offset));

        /// <summary>
        /// Formats the bitstring content with optional specifier and blocking
        /// </summary>
        /// <param name="tlz">Indicates whether leading zero bits should be eliminated from the result</param>
        /// <param name="specifier">True if the canonical 0b specifier is to precede bitstring content, false if to omit the speicifier</param>
        /// <param name="blockWidth">If unspecified, no blocking will be applied; otherwise, indicates the width of the block partitions</param>
        /// <param name="blocksep">If unspecified, when block formatting, indicates the default block delimiter (An ASCII space) will be used;
        /// if specified, when block formatting, indicates the block delimiter to place between the block partitions</param>
        public string Format(bool tlz = false, bool specifier = false, int? blockWidth = null, char? blocksep = null)
        {            
            var fmt = tlz ? str(content).TrimStart('0') : str(content);
            if(blockWidth != null)
            {
                var sep = blocksep ?? ' ';
                var blocks = Blocks(blockWidth.Value);
                return (specifier ? Specifier : string.Empty) + string.Join(sep,blocks);
            }
            else
                return (specifier ? Specifier : string.Empty) + fmt;
        }

        public string Format2(bool tlz = false, bool specifier = false, int? blockWidth = null, char? blocksep = null)
        {            
                                
            if(blockWidth == null)
            {
                Span<char> dst = stackalloc char[content2.Length];
                var lastix = dst.Length - 1;
                for(var i=0; i< dst.Length; i++)
                    dst[lastix - i] = content2[i] == 0 ? '0' : '1';
                
                var x = new string(dst);
                return tlz ? x.TrimStart('0') : x;
            }
            else
            {
                var sb = sbuild();
                var blocks = Blocks2(blockWidth.Value).Reverse();
                for(var i=0; i<blocks.Length; i++)
                {
                    sb.Append(blocks[i].Format2());
                    sb.Append(blocksep ?? ' ');
                }
                return sb.ToString();
            }
            
        }

        /// <summary>
        /// Renders the bitstring as a primal value
        /// </summary>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public T ToPrimalValue<T>()
            where T : struct
        {
            var src = content;
            if(typeof(T) == typeof(sbyte))
                return generic<T>(parse(src, 0, out sbyte _));
            else if(typeof(T) == typeof(byte))
                return generic<T>(parse(src, 0, out byte _));
            else if(typeof(T) == typeof(short))
                return generic<T>(parse(src, 0, out short _));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(parse(src, 0, out ushort _));
            else if(typeof(T) == typeof(int))
                return generic<T>(parse(src, 0, out int _));
            else if(typeof(T) == typeof(uint))
                return generic<T>(parse(src, 0, out uint _));
            else if(typeof(T) == typeof(long))
                return generic<T>(parse(src, 0, out long _));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(parse(src, 0, out ulong _));
            else
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        static bool HasBitSpecifier(in ReadOnlySpan<char> bs)
        {
            if(bs.Length < 2)
                return false;
            var last = bs.Length - 1;
            return bs[0] == '0' && bs[1] == 'b';        
        }

        [MethodImpl(Inline)]
        static ReadOnlySpan<char> IgnoreBitSpecifier(in ReadOnlySpan<char> bs)
            =>  HasBitSpecifier(bs) ? bs.Slice(2) : bs;

        /// <summary>
        /// Extracts 8 characters from the source beginning at a specified offset and
        /// encodes the extract as a byte
        /// </summary>
        /// <param name="bs">A bitchar span</param>
        /// <param name="offset">The offset at which to begin extraction</param>
        /// <param name="dst">Receives the encoded result</param>
        static byte parse(in ReadOnlySpan<char> bs, in int offset, out byte dst)
        {
            var src = IgnoreBitSpecifier(bs);
            var last = Math.Min(U8BitCount, src.Length) - 1;                        
            var pos = last - 1;            
            
            dst = (byte)0;
            for(var i=offset; i<= last; i++)
                if(src[i] == Bit.One)
                    Bits.enable(ref dst, last - i);
                        
            return dst;
        }

        [MethodImpl(Inline)]
        static sbyte parse(in ReadOnlySpan<char> bs, in int offset, out sbyte dst)
            => dst = (sbyte)parse(bs, offset, out byte x);

        static ref ushort parse(in ReadOnlySpan<char> bs, in int offset, out ushort dst)
        {
            var src = IgnoreBitSpecifier(bs);
            var last = Math.Min(U16BitCount, src.Length) - 1;                        
            var pos = last - 1;            
            
            dst = 0;
            for(var i=offset; i<= last; i++)
                if(src[i] == Bit.One)
                    Bits.enable(ref dst, last - i);
                        
            return ref dst;
        }

        [MethodImpl(Inline)]
        static short parse(in ReadOnlySpan<char> bs, in int offset, out short dst)
            => dst = (short)parse(bs, offset, out ushort x);

        static ref uint parse(in ReadOnlySpan<char> bs, in int offset, out uint dst)
        {
            var src = IgnoreBitSpecifier(bs);
            var last = Math.Min(U32BitCount, src.Length) - 1;                        
            var pos = last - 1;            
            
            dst = 0;
            for(var i=offset; i<= last; i++)
                if(src[i] == Bit.One)
                    Bits.enable(ref dst, last - i);
                        
            return ref dst;
        }

        [MethodImpl(Inline)]
        static int parse(in ReadOnlySpan<char> bs, in int offset, out int dst)
            => dst = (int)parse(bs, offset, out uint x);

        static ref ulong parse(in ReadOnlySpan<char> bs, in int offset, out ulong dst)
        {            
            var src = IgnoreBitSpecifier(bs);
            var last = Math.Min(U64BitCount, src.Length) - 1;                        
            var pos = last - 1;                        
            dst = 0;
            for(var i=offset; i<= last; i++)
                if(src[i] == Bit.One)
                    Bits.enable(ref dst, last - i);
                        
            return ref dst;
        }

        [MethodImpl(Inline)]
        static long parse(in ReadOnlySpan<char> bs, in int offset, out long dst)
            => dst = (long)parse(bs, offset, out ulong x);
 
        public string Format()
            => Format2(false, false, null, null);

        public override string ToString()
            => Format();
        
        public override int GetHashCode()
            => content.GetHashCode();

        public override bool Equals(object rhs)
            => (rhs is BitString x)  ? Eq(x) : false;

        public BitString Concat(BitString rhs)
            => this + rhs;
 
         

    }
}