//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;

    [StructLayout(LayoutKind.Explicit, Size = ByteCount)]
    public struct Char2 : IFixedString<N2>
    {
        /// <summary>
        /// Placeholder for the first character of the string
        /// </summary>
        [FieldOffset(0)]
        char hi;

        /// <summary>
        /// Placeholder for the second character of the string
        /// </summary>
        [FieldOffset(2)]
        char lo;

        /// <summary>
        /// The number of characters represented by a value
        /// </summary>
        public const int CharCount = 2;

        /// <summary>
        /// The number of bytes required to represent <see cref='CharCount'/> characters
        /// </summary>
        public const int ByteCount = 4;


        [MethodImpl(Inline)]
        public static Char2 FromChars(char head, char tail)
            => new Char2(head, tail);

        [MethodImpl(Inline)]
        public static Char2 FromChars(int offset, params char[] chars)
        {
            Char2 dst = default;

            if(chars.Length >= 1)
                dst.lo = chars[offset + 0];
            
            if(chars.Length >= 2)
                dst.hi = chars[offset + 1];

            return dst;            
        }

        [MethodImpl(Inline)]
        public static Char4 operator +(in Char2 head, in Char2 tail)
            => Char4.FromChars(head,tail);


        [MethodImpl(Inline)]
        Char2(char head, char tail)
        {
            this.lo = tail;
            this.hi = head;
        }

        [MethodImpl(Inline)]
        public static bool operator ==(in Char2 x, in Char2 y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator !=(in Char2 x, in Char2 y)
            => !x.Equals(y);
        
        [MethodImpl(Inline)]
        public static ref readonly Char2 FromSpan(ReadOnlySpan<char> src, int offset = 0)
            => ref SpanConvert.TakeSingle<char,Char2>(src, offset, CharCount);

        [MethodImpl(Inline)]
        public static ref Char2 FromSpan(Span<char> src, int offset = 0)
            => ref SpanConvert.TakeSingle<char,Char2>(src, offset, CharCount);

        [MethodImpl(Inline)]
        public static ref readonly Char2 FromString(string src)
            => ref FromSpan(src.PadRight(CharCount).Substring(0,CharCount).ToReadOnlySpan());

        [MethodImpl(Inline)]
        public static implicit operator Span<char>(Char2 src)
            => src.AsSpan();

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<char>(Char2 src)
            => src.AsReadOnlySpan();

        [MethodImpl(Inline)]
        public static implicit operator Char2(Span<char> src)
            => SpanConvert.TakeSingle<char, Char2>((ReadOnlySpan<char>)src);

        [MethodImpl(Inline)]
        public static implicit operator Char2(ReadOnlySpan<char> src)
            => SpanConvert.TakeSingle<char,Char2>(src);

        /// <summary>
        /// Implicilty converts the source value to a string, removing any trailing whitespace characters
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator Char2(string src)
            => FromString(src);

        [MethodImpl(Inline)]
        public Span<char> AsSpan()
            => SpanConvert.AsSpan<Char2,char>(ref this);

        [MethodImpl(Inline)]
        public ReadOnlySpan<char> AsReadOnlySpan()
            => SpanConvert.AsReadOnlySpan<Char2,char>(ref this);

        [MethodImpl(Inline)]
        public void Fill(ReadOnlySpan<char> src)
        {
            lo = src[0];
            hi = src[1];
        }

        public ref char this[int i]
        {
            [MethodImpl(Inline)]
            get => ref AsSpan()[i];
        }

        [MethodImpl(Inline)]
        public string Format()
            => new string(AsSpan().TrimEnd()); 

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => HashCode.Combine(lo,hi);
        
        [MethodImpl(Inline)]
        public bool Equals(Char2 rhs)
            => lo == rhs.lo && hi == rhs.hi;

        public override bool Equals(object rhs)
            => rhs is Char2 x ? Equals(x) : false;
    
    }
 
}