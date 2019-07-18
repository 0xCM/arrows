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
    public struct Char8
    {
        /// <summary>
        /// Placeholder for the first character of the string
        /// </summary>
        [FieldOffset(0)]
        char c0;

        /// <summary>
        /// Placeholder for the second character of the string
        /// </summary>
        [FieldOffset(2)]
        char c1;

        /// <summary>
        /// Placeholder for the third character of the string
        /// </summary>
        [FieldOffset(4)]
        char c2;

        /// <summary>
        /// Placeholder for the fourth character of the string
        /// </summary>
        [FieldOffset(6)]
        char c3;

        /// <summary>
        /// Placeholder for the fifth character of the string
        /// </summary>
        [FieldOffset(8)]
        char c4;

        /// <summary>
        /// Placeholder for the sixth character of the string
        /// </summary>
        [FieldOffset(10)]
        char c5;

        /// <summary>
        /// Placeholder for the seventh character of the string
        /// </summary>
        [FieldOffset(12)]
        char c6;

        /// <summary>
        /// Placeholder for the eighth character of the string
        /// </summary>
        [FieldOffset(14)]
        char c7;

        /// <summary>
        /// The number of characters represented by a value
        /// </summary>
        public const int CharCount = 8;

        /// <summary>
        /// The number of bytes required to represent <see cref='CharCount'/> characters
        /// </summary>
        public const int ByteCount = 16;

        [MethodImpl(Inline)]
        public static ref Char8 FromSpan(Span<char> src, int offset = 0)
            => ref src.AsSingle<char,Char8>(offset, CharCount);

        [MethodImpl(Inline)]
        public static ref readonly Char8 FromSpan(ReadOnlySpan<char> src, int offset = 0)
            => ref src.AsSingle<char,Char8>(offset, CharCount);

        [MethodImpl(Inline)]
        public static ref readonly Char8 FromString(string src)
            =>ref src.PadRight(CharCount).Substring(0,CharCount).AsReadOnlySpan().AsSingle<char,Char8>();

        [MethodImpl(Inline)]
        public static implicit operator Span<char>(Char8 src)
            => src.AsSpan();

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<char>(Char8 src)
            => src.AsReadOnlySpan();

        [MethodImpl(Inline)]
        public static implicit operator Char8(Span<char> src)
            => src.AsSingle<char,Char8>();

        [MethodImpl(Inline)]
        public static implicit operator Char8(ReadOnlySpan<char> src)
            => src.AsSingle<char,Char8>();

        /// <summary>
        /// Implicilty converts the source value to a string, removing any trailing whitespace characters
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator Char8(string src)
            => FromString(src);

        [MethodImpl(Inline)]
        public unsafe Span<char> AsSpan()
            => MemBlock.AsSpan<Char8,char>(ref this);

        [MethodImpl(Inline)]
        public ReadOnlySpan<char> AsReadOnlySpan()
            => MemBlock.AsReadOnlySpan<Char8,char>(ref this);

        [MethodImpl(Inline)]
        public string Format()
            => new string(AsSpan().TrimEnd()); 

        public override string ToString()
            => Format();
    }
 
}