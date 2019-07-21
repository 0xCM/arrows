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
    public struct Char32
    {
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

        /// <summary>
        /// The number of characters represented by a value
        /// </summary>
        const int CharCount = 32;

        /// <summary>
        /// The number of bytes required to represent <see cref='CharCount'/> characters
        /// </summary>
        const int ByteCount = 64;

        [MethodImpl(Inline)]
        public static ref Char32 FromSpan(Span<char> src, int offset = 0)
            => ref src.AsIndividual<char,Char32>(offset, CharCount);

        [MethodImpl(Inline)]
        public static ref readonly Char32 FromSpan(ReadOnlySpan<char> src, int offset = 0)
            => ref src.AsIndividual<char,Char32>(offset, CharCount);

        [MethodImpl(Inline)]
        public static ref readonly Char32 FromString(string src)
            => ref src.PadRight(CharCount).Substring(0,CharCount).AsReadOnlySpan().AsIndividual<char,Char32>(0,CharCount);

        [MethodImpl(Inline)]
        public static implicit operator Char32(Span<char> src)
            => FromSpan(src);

        [MethodImpl(Inline)]
        public static implicit operator Span<char>(Char32 src)
            => src.AsSpan();

        [MethodImpl(Inline)]
        public static implicit operator Char32(ReadOnlySpan<char> src)
            => FromSpan(src);

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<char>(Char32 src)
            => src.AsReadOnlySpan();

        [MethodImpl(Inline)]
        public static implicit operator Char32(string src)
            => FromString(src);

        /// <summary>
        /// Implicilty converts the source value to a string, removing any trailing whitespace characters
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator string(Char32 src)
            => src.ToString();

        [MethodImpl(Inline)]
        public unsafe Span<char> AsSpan()
            => SpanConvert.AsSpan<Char32,char>(ref this);

        [MethodImpl(Inline)]
        public ReadOnlySpan<char> AsReadOnlySpan()
            => SpanConvert.AsReadOnlySpan<Char32,char>(ref this);

        [MethodImpl(Inline)]
        public string Format()
            => new string(AsSpan().TrimEnd()); 

        public override string ToString()
            => Format();

    }

}