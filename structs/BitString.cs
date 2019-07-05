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

    public readonly struct BitString
    {
        [MethodImpl(Inline)]
        public static BitString Define(string content)                
            => new BitString(content);

        [MethodImpl(Inline)]
        public static BitString Define(ReadOnlySpan<char> content)                
            => new BitString(content);

        public static BitString Assemble(params string[] parts)
            => Define(string.Join(string.Empty, parts.Reverse()));

        public static BitString Assemble(params BitString[] parts)
            => Define(string.Join(string.Empty, parts.Reverse()));

        public static readonly BitString Empty = Define(string.Empty);


        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<char>(BitString src)                
            => src.content;

        [MethodImpl(Inline)]
        public static implicit operator string(BitString src)                
            => src.content;

        public static bool operator ==(BitString lhs, BitString rhs)
            => lhs.content == rhs.content;

        public static bool operator !=(BitString lhs, BitString rhs)
            => lhs.content == rhs.content;

        [MethodImpl(Inline)]
        public static BitString operator +(BitString hi, BitString lo)
            => Define(hi.content + lo.content);

        readonly string content;

        [MethodImpl(Inline)]
        BitString(string content)
        {
            this.content = content;
        }

        [MethodImpl(Inline)]
        BitString(ReadOnlySpan<char> content)
        {
            this.content = new string(content);
        }

        public bool IsEmpty
            => string.IsNullOrWhiteSpace(content);

        public Bit this[int index]
        {
            [MethodImpl(Inline)]
            get => content[index];
        }

        [MethodImpl(Inline)]
        BitString RangeRev(BitPos start, int length)
        {
            int offset = start;
            var dst = new char[length];
            for(var i = 1; i<= length; i++)
                dst[length - i] = content[offset + i - 1];
            return BitString.Define(dst);
        }

        public BitString Range(BitPos start, int length)
        {
            var src = new Span<char>(content.Reverse().ToArray());
            return Define(src.Slice(start, length));
        }
            
        public int Length
        {
            [MethodImpl(Inline)]
            get => content.Length;
        }

        /// <summary>
        ///  Partitions the bitstring into blocks of a specified maximum width
        /// </summary>
        /// <param name="width">The maximum block width</param>
        public BitString[] Blocks(int width)
        {
            var q = Math.DivRem(content.Length, width, out int r);
            var dst = new BitString[q + r];
            var len = dst.Length;
            var lastix = (len - 1);
            var j = 0;
            
            for(var i = 0; i < len; i++, j+= width)
            {                                
                if(i != lastix)
                    dst[i] = Define(content.Substring(j, width));
                else
                {
                    if(r == 0)
                        dst[i] = Define(content.Substring(j, width));
                    else 
                        dst[i] = Define(content.Substring(j, r));
                }                    
            }
            Array.Reverse(dst);
            return dst;
        }

        public string Format(int? blockWidth = null)
        {
            if(blockWidth != null)
            {
                var blocks = Blocks(blockWidth.Value);
                return string.Join(' ',blocks);
            }
            else
                return content;

        }

        public override string ToString()
            => content;
        
        public override int GetHashCode()
            => content.GetHashCode();

       public override bool Equals(object rhs)
            => (rhs is BitString x) 
                ? x.content == content 
                : false;
    }

}