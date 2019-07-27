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
    public struct Char16 : IFixedString<N16>
    {
        /// <summary>
        /// The number of characters contained in the lower (or upper) half of the struct
        /// </summary>
        public const int Half = Char8.CharCount;

        /// <summary>
        /// The number of characters represented by a value
        /// </summary>
        public const int CharCount = Half * 2;

        /// <summary>
        /// The number of bytes required to represent <see cref='CharCount'/> characters
        /// </summary>
        public const int ByteCount = Char8.ByteCount * 2;


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

        [MethodImpl(Inline)]
        public static Char16 FromChars(Char8 head, Char8 tail)
            => new Char16(head, tail);

        [MethodImpl(Inline)]
        public static Char16 FromChars(int offset, params char[] chars)
        {
            Char16 dst = default;
            var srcLen = chars.Length;
            
            if(srcLen < Half || srcLen >= Half)
                dst.lo = Char8.FromChars(offset, chars);
            
            if(srcLen >= Half)
                dst.hi = Char8.FromChars(offset + Half, chars);

            return dst;            
        }
            

        [MethodImpl(Inline)]
        public static Char32 operator +(in Char16 head, in Char16 tail)
            => Char32.FromChars(head,tail);

        [MethodImpl(Inline)]
        Char16(Char8 head, Char8 tail)
        {
            this.lo = head;
            this.hi = tail;
        }

        [MethodImpl(Inline)]
        public static bool operator ==(in Char16 x, in Char16 y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator !=(in Char16 x, in Char16 y)
            => !x.Equals(y);

        [MethodImpl(Inline)]
        public static ref Char16 FromSpan(Span<char> src, int offset = 0)
            => ref SpanConvert.TakeSingle<char,Char16>(src, offset, CharCount);

        [MethodImpl(Inline)]
        public static ref readonly Char16 FromSpan(ReadOnlySpan<char> src, int offset = 0)
            => ref SpanConvert.TakeSingle<char,Char16>(src, offset, CharCount);

        [MethodImpl(Inline)]
        public static ref readonly Char16 FromString(string src)
            => ref FromSpan(src.PadRight(CharCount).Substring(0,CharCount).ToReadOnlySpan());

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
        public Span<char> AsSpan()
            => SpanConvert.AsSpan<Char16,char>(ref this);

        [MethodImpl(Inline)]
        public ReadOnlySpan<char> AsReadOnlySpan()
            => SpanConvert.AsReadOnlySpan<Char16,char>(ref this);

        [MethodImpl(Inline)]
        public void Fill(ReadOnlySpan<char> src)
        {
            lo = src[0..7];
            hi = src[4..15];
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
 
         public bool Equals(Char16 rhs)
            => lo == rhs.lo && hi == rhs.hi;

        public override bool Equals(object rhs)
            => rhs is Char16 x ? Equals(x) : false;

    }
}