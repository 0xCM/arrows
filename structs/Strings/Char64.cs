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
    public struct Char64 : IFixedString<N64>
    {
        /// <summary>
        /// The number of characters represented by a value
        /// </summary>
        public const int CharCount = Char32.CharCount * 2;
        
        /// <summary>
        /// The number of bytes required to represent <see cref='CharCount'/> characters
        /// </summary>
        public const int ByteCount = Char32.ByteCount * 2;


        /// <summary>
        /// Placeholder for first half of the string
        /// </summary>
        [FieldOffset(0)]
        Char32 lo;

        /// <summary>
        /// Placeholder for second half of the string
        /// </summary>
        [FieldOffset(CharCount)]
        Char32 hi;
        
        [MethodImpl(Inline)]
        public static Char64 FromChars(in Char32 lo, in Char32 hi)
            => new Char64(lo,hi);

        [MethodImpl(Inline)]
        Char64(in Char32 head, in Char32 tail)
        {
            this.lo = head;
            this.hi = tail;
        }

        [MethodImpl(Inline)]
        public static bool operator ==(in Char64 x, in Char64 y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator !=(in Char64 x, in Char64 y)
            => !x.Equals(y);

        [MethodImpl(Inline)]
        public static Char128 operator +(in Char64 lo, in Char64 hi)
            => Char128.FromChars(lo,hi);

        [MethodImpl(Inline)]
        public static ref Char64 FromSpan(Span<char> src, int offset = 0)
            => ref SpanConvert.TakeSingle<char,Char64>(src, offset, CharCount);

        [MethodImpl(Inline)]
        public static ref readonly Char64 FromSpan(ReadOnlySpan<char> src, int offset = 0)
            => ref SpanConvert.TakeSingle<char,Char64>(src, offset, CharCount);

        [MethodImpl(Inline)]
        public static ref readonly Char64 FromString(string src)
            => ref FromSpan(src.PadRight(CharCount).Substring(0,CharCount).ToReadOnlySpan());

        [MethodImpl(Inline)]
        public static implicit operator Span<char>(in Char64 src)
            => src.AsSpan();

        [MethodImpl(Inline)]
        public static implicit operator Char64(Span<char> src)
            => FromSpan(src);

        [MethodImpl(Inline)]
        public static implicit operator Char64(ReadOnlySpan<char> src)
            => FromSpan(src);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<char>(Char64 src)
            => src.AsReadOnlySpan();

        [MethodImpl(Inline)]
        public static implicit operator Char64(string src)
            => FromString(src);

        /// <summary>
        /// Implicilty converts the source value to a string, removing any trailing whitespace characters
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator string(Char64 src)
            => src.Format();

        [MethodImpl(Inline)]
        public Span<char> AsSpan()
            => SpanConvert.AsSpan<Char64,char>(ref this);

        [MethodImpl(Inline)]
        public ReadOnlySpan<char> AsReadOnlySpan()
            => SpanConvert.AsReadOnlySpan<Char64,char>(ref this);

        public ref char this[int i]
        {
            [MethodImpl(Inline)]
            get => ref AsSpan()[i];
        }

        [MethodImpl(Inline)]
        public void Fill(ReadOnlySpan<char> src)
        {
            lo = src[0..31];
            hi = src[32..63];
        }
       
       [MethodImpl(Inline)]
        public string Format()
            => new string(AsSpan().TrimEnd());

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => HashCode.Combine(lo,hi);
 
        [MethodImpl(Inline)]
        public bool Equals(Char64 rhs)
            => lo == rhs.lo && hi == rhs.hi;

        public override bool Equals(object rhs)
            => rhs is Char64 x ? Equals(x) : false;

    }
}