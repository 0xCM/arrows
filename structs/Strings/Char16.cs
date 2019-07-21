//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;


    [StructLayout(LayoutKind.Explicit, Size = ByteCount)]
    public struct Char16
    {
        /// <summary>
        /// Placeholder for first half of the string
        /// </summary>
        [FieldOffset(0)]
        Char8 lo;

        /// <summary>
        /// Placeholder for second half of the string
        /// </summary>
        [FieldOffset(CharCount)]
        Char8 hi;

        /// <summary>
        /// The number of characters represented by a value
        /// </summary>
        public const int CharCount = 16;

        /// <summary>
        /// The number of bytes required to represent <see cref='CharCount'/> characters
        /// </summary>
        public const int ByteCount = 32;

        [MethodImpl(Inline)]
        public static ref Char16 FromSpan(Span<char> src, int offset = 0)
            => ref src.AsIndividual<char,Char16>(offset, CharCount);

        [MethodImpl(Inline)]
        public static ref readonly Char16 FromSpan(ReadOnlySpan<char> src, int offset = 0)
            => ref src.AsIndividual<char,Char16>(offset, CharCount);

        [MethodImpl(Inline)]
        public static ref readonly Char16 FromString(string src)
            => ref src.PadRight(CharCount).Substring(0,CharCount).AsSpan().AsIndividual<char,Char16>(0,CharCount);

        [MethodImpl(Inline)]
        public static implicit operator Span<char>(Char16 src)
            => src.AsSpan();

        [MethodImpl(Inline)]
        public static implicit operator Char16(ReadOnlySpan<char> src)
            => FromSpan(src);

        [MethodImpl(Inline)]
        public static implicit operator Char16(Span<char> src)
            => FromSpan(src);

        [MethodImpl(Inline)]
        public static implicit operator Char16(string src)
            => FromString(src);

        /// <summary>
        /// Implicilty converts the source value to a string, removing any trailing whitespace characters
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator string(Char16 src)
            => src.Format();

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<char>(Char16 src)
            => src.AsReadOnlySpan();

        [MethodImpl(Inline)]
        public unsafe Span<char> AsSpan()
            => SpanConvert.AsSpan<Char16,char>(ref this);

        [MethodImpl(Inline)]
        public ReadOnlySpan<char> AsReadOnlySpan()
            => SpanConvert.AsReadOnlySpan<Char16,char>(ref this);

        [MethodImpl(Inline)]
        public string Format()
            => new string(AsSpan().TrimEnd()); 

        public override string ToString()
            => Format();
    }
}