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

    public static class FixedString
    {
        [MethodImpl(Inline)]
        public static ref Char8 ToChar8(this Span<char> src, int offset = 0)
            => ref Char8.FromSpan(src, offset);

        [MethodImpl(Inline)]
        public static ref readonly Char8 ToChar8(this ReadOnlySpan<char> src, int offset = 0)
            => ref Char8.FromSpan(src, offset);

        [MethodImpl(Inline)]
        public static ref readonly Char8 ToChar8(this string src)
            => ref Char8.FromString(src);

        [MethodImpl(Inline)]
        public static ref Char16 ToChar16(this Span<char> src, int offset = 0)
            => ref Char16.FromSpan(src, offset);

        [MethodImpl(Inline)]
        public static ref readonly Char16 ToChar16(this ReadOnlySpan<char> src, int offset = 0)
            => ref Char16.FromSpan(src, offset);

        [MethodImpl(Inline)]
        public static ref readonly Char16 ToChar16(this string src)
            => ref Char16.FromString(src);

        [MethodImpl(Inline)]
        public static ref Char32 ToChar32(this Span<char> src, int offset = 0)
            => ref Char32.FromSpan(src, offset);

        [MethodImpl(Inline)]
        public static ref readonly Char32 ToChar32(this ReadOnlySpan<char> src, int offset = 0)
            => ref Char32.FromSpan(src, offset);

        [MethodImpl(Inline)]
        public static ref readonly Char32 ToChar32(this string src)
            => ref Char32.FromString(src);

        [MethodImpl(Inline)]
        public static ref Char64 ToChar64(this Span<char> src, int offset = 0)
            => ref Char64.FromSpan(src, offset);

        [MethodImpl(Inline)]
        public static ref readonly Char64 ToChar64(this ReadOnlySpan<char> src, int offset = 0)
            => ref Char64.FromSpan(src, offset);

        [MethodImpl(Inline)]
        public static ref readonly Char64 ToChar64(this string src)
            => ref Char64.FromString(src);
    }
}