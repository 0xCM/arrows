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
    public struct Char128 : IFixedString<N128>
    {
        /// <summary>
        /// The number of characters represented by a value
        /// </summary>
        public const int CharCount = Char64.CharCount * 2;
        
        /// <summary>
        /// The number of bytes required to represent <see cref='CharCount'/> characters
        /// </summary>
        public const int ByteCount = Char64.ByteCount * 2;

        /// <summary>
        /// Placeholder for first half of the string
        /// </summary>
        [FieldOffset(0)]
        Char64 lo;

        /// <summary>
        /// Placeholder for second half of the string
        /// </summary>
        [FieldOffset(CharCount)]
        Char64 hi;

        [MethodImpl(Inline)]
        public static Char128 FromChars(in Char64 lo, in Char64 hi)
            => new Char128(lo,hi);

        [MethodImpl(Inline)]
        Char128(in Char64 head, in Char64 tail)
        {
            this.lo = head;
            this.hi = tail;
        }

        [MethodImpl(Inline)]
        public static bool operator ==(in Char128 x, in Char128 y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator !=(in Char128 x, in Char128 y)
            => !x.Equals(y);

        [MethodImpl(Inline)]
        public static ref Char128 FromSpan(Span<char> src, int offset = 0)
            => ref SpanConvert.TakeSingle<char,Char128>(src, offset, CharCount);

        [MethodImpl(Inline)]
        public static ref readonly Char128 FromSpan(ReadOnlySpan<char> src, int offset = 0)
            => ref SpanConvert.TakeSingle<char,Char128>(src, offset, CharCount);

        [MethodImpl(Inline)]
        public static ref readonly Char128 FromString(string src)
            => ref FromSpan(src.PadRight(CharCount).Substring(0,CharCount).ToReadOnlySpan());

        [MethodImpl(Inline)]
        public static implicit operator Span<char>(Char128 src)
            => src.AsSpan();

        [MethodImpl(Inline)]
        public static implicit operator Char128(Span<char> src)
            => FromSpan(src);

        [MethodImpl(Inline)]
        public static implicit operator Char128(ReadOnlySpan<char> src)
            => FromSpan(src);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<char>(Char128 src)
            => src.AsReadOnlySpan();

        [MethodImpl(Inline)]
        public static implicit operator Char128(string src)
            => FromString(src);

        /// <summary>
        /// Implicilty converts the source value to a string, removing any trailing whitespace characters
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator string(Char128 src)
            => src.Format();

        [MethodImpl(Inline)]
        public Span<char> AsSpan()
            => SpanConvert.AsSpan<Char128,char>(ref this);

        [MethodImpl(Inline)]
        public ReadOnlySpan<char> AsReadOnlySpan()
            => SpanConvert.AsReadOnlySpan<Char128,char>(ref this);

        public ref char this[int i]
        {
            [MethodImpl(Inline)]
            get => ref AsSpan()[i];
        }

        [MethodImpl(Inline)]
        public void Fill(ReadOnlySpan<char> src)
        {
            lo = src[0..63];
            hi = src[64..127];
        }

        [MethodImpl(Inline)]
        public string Format()
            => new string(AsSpan().TrimEnd());

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => HashCode.Combine(lo,hi);
   
        [MethodImpl(Inline)]
        public bool Equals(Char128 rhs)
            => lo == rhs.lo && hi == rhs.hi;

        public override bool Equals(object rhs)
            => rhs is Char128 x ? Equals(x) : false;
   
   }
}