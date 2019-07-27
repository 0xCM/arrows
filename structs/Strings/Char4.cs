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
    public struct Char4 : IFixedString<N4>
    {
        /// <summary>
        /// The number of characters contained in the lower (or upper) half of the struct
        /// </summary>
        public const int Half = Char2.CharCount;

        /// <summary>
        /// The number of characters represented by a value
        /// </summary>
        public const int CharCount = Half * 2;

        /// <summary>
        /// The number of bytes required to represent <see cref='CharCount'/> characters
        /// </summary>
        public const int ByteCount = Char2.ByteCount * 2;


        /// <summary>
        /// Placeholder for the first half of the string
        /// </summary>
        [FieldOffset(0)]
        Char2 lo;

        /// <summary>
        /// Placeholder for the second character of the string
        /// </summary>
        [FieldOffset(CharCount)]
        Char2 hi;


        [MethodImpl(Inline)]
        public static Char4 FromChars(Char2 head, Char2 tail)
            => new Char4(head,tail);

        [MethodImpl(Inline)]
        public static Char4 FromChars(int offset, params char[] chars)
        {
            Char4 dst = default;
            var srcLen = chars.Length;
            
            if(srcLen < Half || srcLen >= Half)
                dst.lo = Char2.FromChars(offset, chars);
            
            if(srcLen >= Half)
                dst.hi = Char2.FromChars(offset + Half, chars);

            return dst;            
        }

        [MethodImpl(Inline)]
        public static Char8 operator +(in Char4 head, in Char4 tail)
            => Char8.FromChars(head,tail);

        [MethodImpl(Inline)]
        public static bool operator ==(in Char4 x, in Char4 y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator !=(in Char4 x, in Char4 y)
            => !x.Equals(y);


        [MethodImpl(Inline)]
        Char4(Char2 head, Char2 tail)
        {
            this.lo = head;
            this.hi = tail;
        }


        [MethodImpl(Inline)]
        public static ref Char4 FromSpan(Span<char> src, int offset = 0)
            => ref SpanConvert.TakeSingle<char,Char4>(src, offset, CharCount);

        [MethodImpl(Inline)]
        public static ref readonly Char4 FromSpan(ReadOnlySpan<char> src, int offset = 0)
            => ref SpanConvert.TakeSingle<char,Char4>(src, offset, CharCount);

        [MethodImpl(Inline)]
        public static ref readonly Char4 FromString(string src)
            => ref FromSpan(src.PadRight(CharCount).Substring(0,CharCount).ToReadOnlySpan());

        [MethodImpl(Inline)]
        public static implicit operator Span<char>(Char4 src)
            => src.AsSpan();

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<char>(Char4 src)
            => src.AsReadOnlySpan();

        [MethodImpl(Inline)]
        public static implicit operator Char4(Span<char> src)
            => SpanConvert.TakeSingle<char, Char4>((ReadOnlySpan<char>)src);

        [MethodImpl(Inline)]
        public static implicit operator Char4(ReadOnlySpan<char> src)
            => SpanConvert.TakeSingle<char,Char4>(src);

        /// <summary>
        /// Implicilty converts the source value to a string, removing any trailing whitespace characters
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator Char4(string src)
            => FromString(src);

        [MethodImpl(Inline)]
        public unsafe Span<char> AsSpan()
            => SpanConvert.AsSpan<Char4,char>(ref this);

        [MethodImpl(Inline)]
        public ReadOnlySpan<char> AsReadOnlySpan()
            => SpanConvert.AsReadOnlySpan<Char4,char>(ref this);

        [MethodImpl(Inline)]
        public void Fill(ReadOnlySpan<char> src)
        {
            lo = src[0..1];
            hi = src[2..3];
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
        public bool Equals(Char4 rhs)
            => lo == rhs.lo && hi == rhs.hi;

        public override bool Equals(object rhs)
            => rhs is Char4 x ? Equals(x) : false;

    }
 
}