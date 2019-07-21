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
    public struct Char64
    {
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
        
        /// <summary>
        /// The number of characters represented by a value
        /// </summary>
        public const int CharCount = 64;
        
        /// <summary>
        /// The number of bytes required to represent <see cref='CharCount'/> characters
        /// </summary>
        public const int ByteCount = 128;

        [MethodImpl(Inline)]
        public static ref Char64 FromSpan(Span<char> src, int offset = 0)
            => ref src.AsIndividual<char,Char64>(offset, CharCount);

        [MethodImpl(Inline)]
        public static ref readonly Char64 FromSpan(ReadOnlySpan<char> src, int offset = 0)
            => ref src.AsIndividual<char,Char64>(offset, CharCount);

        [MethodImpl(Inline)]
        public static ref readonly Char64 FromString(string src)
            => ref src.PadRight(CharCount).Substring(0,CharCount).AsReadOnlySpan().AsIndividual<char,Char64>(0,CharCount);

        [MethodImpl(Inline)]
        public static implicit operator Span<char>(Char64 src)
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
        public unsafe Span<char> AsSpan()
            => SpanConvert.AsSpan<Char64,char>(ref this);

        [MethodImpl(Inline)]
        public ReadOnlySpan<char> AsReadOnlySpan()
            => SpanConvert.AsReadOnlySpan<Char64,char>(ref this);

        [MethodImpl(Inline)]
        public string Format()
            => new string(AsSpan().TrimEnd());

        public override string ToString()
            => Format();
    }
}