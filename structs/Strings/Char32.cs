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
    public struct Char32 : IFixedString<N32>
    {

        /// <summary>
        /// The number of characters represented by a value
        /// </summary>
        public const int CharCount = Char16.CharCount * 2;

        /// <summary>
        /// The number of bytes required to represent <see cref='CharCount'/> characters
        /// </summary>
        public const int ByteCount = Char16.ByteCount * 2;

        /// <summary>
        /// Placeholder for first half of the string
        /// </summary>
        [FieldOffset(0)]
        Char16 lo;

        /// <summary>
        /// Placeholder for second half of the string
        /// </summary>
        [FieldOffset(CharCount)]
        Char16 hi;

        [MethodImpl(Inline)]
        public static Char32 FromChars(in Char16 head, in Char16 tail)
            => new Char32(head, tail);

        [MethodImpl(Inline)]
        Char32(in Char16 head, in Char16 tail)
        {
            this.lo = head;
            this.hi = tail;
        }

        [MethodImpl(Inline)]
        public static bool operator ==(in Char32 x, in Char32 y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator !=(in Char32 x, in Char32 y)
            => !x.Equals(y);

        [MethodImpl(Inline)]
        public static Char64 operator +(in Char32 lo, in Char32 hi)
            => Char64.FromChars(lo,hi);

        [MethodImpl(Inline)]
        public static ref Char32 FromSpan(Span<char> src, int offset = 0)
            => ref SpanConvert.TakeSingle<char,Char32>(src, offset, CharCount);

        [MethodImpl(Inline)]
        public static ref readonly Char32 FromSpan(ReadOnlySpan<char> src, int offset = 0)
            => ref SpanConvert.TakeSingle<char,Char32>(src, offset, CharCount);

        [MethodImpl(Inline)]
        public static ref readonly Char32 FromString(string src)
            => ref FromSpan(src.PadRight(CharCount).Substring(0,CharCount).ToReadOnlySpan());
        
        [MethodImpl(Inline)]
        public static implicit operator Char32(Span<char> src)
            => FromSpan(src);

        [MethodImpl(Inline)]
        public static implicit operator Span<char>(in Char32 src)
            => src.AsSpan();

        [MethodImpl(Inline)]
        public static implicit operator Char32(ReadOnlySpan<char> src)
            => FromSpan(src);

                [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<char>(in Char32 src)
            => src.AsReadOnlySpan();

        [MethodImpl(Inline)]
        public static implicit operator Char32(string src)
            => FromString(src);

        /// <summary>
        /// Implicilty converts the source value to a string, removing any trailing whitespace characters
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator string(in Char32 src)
            => src.ToString();

        [MethodImpl(Inline)]
        public unsafe Span<char> AsSpan()
            => SpanConvert.AsSpan<Char32,char>(ref this);

        [MethodImpl(Inline)]
        public ReadOnlySpan<char> AsReadOnlySpan()
            => SpanConvert.AsReadOnlySpan<Char32,char>(ref this);

        [MethodImpl(Inline)]
        public void Fill(ReadOnlySpan<char> src)
        {
            lo = src[0..15];
            hi = src[16..31];
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
 
         public bool Equals(Char32 rhs)
            => lo == rhs.lo && hi == rhs.hi;

        public override bool Equals(object rhs)
            => rhs is Char32 x ? Equals(x) : false;

    }

}