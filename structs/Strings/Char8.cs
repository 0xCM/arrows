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
    public struct Char8 : IFixedString<N8>
    {
        /// <summary>
        /// The number of characters represented by a value
        /// </summary>
        public const int CharCount = Char4.CharCount * 2;

        /// <summary>
        /// The number of bytes required to represent <see cref='CharCount'/> characters
        /// </summary>
        public const int ByteCount = Char4.ByteCount * 2;

        /// <summary>
        /// Placeholder for first half of the string
        /// </summary>
        [FieldOffset(0)]
        Char4 lo;

        /// <summary>
        /// Placeholder for second half of the string
        /// </summary>
        [FieldOffset(CharCount)]
        Char4 hi;

        [MethodImpl(Inline)]
        public static Char8 FromChars(in Char4 head, in Char4 tail)
            => new Char8(head,tail);
        
        [MethodImpl(Inline)]
        Char8(in Char4 head, in Char4 tail)
        {
            this.lo = head;
            this.hi = tail;
        }

        [MethodImpl(Inline)]
        public static bool operator ==(in Char8 x, in Char8 y)
            => x.Equals(y);

        [MethodImpl(Inline)]
        public static bool operator !=(in Char8 x, in Char8 y)
            => !x.Equals(y);

        [MethodImpl(Inline)]
        public static Char16 operator +(in Char8 x, in Char8 y)
            => Char16.FromChars(x,y);

        [MethodImpl(Inline)]
        public static ref Char8 FromSpan(Span<char> src, int offset = 0)
            => ref src.AsIndividual<char,Char8>(offset, CharCount);

        [MethodImpl(Inline)]
        public static ref readonly Char8 FromSpan(ReadOnlySpan<char> src, int offset = 0)
            => ref src.AsIndividual<char,Char8>(offset, CharCount);

        [MethodImpl(Inline)]
        public static ref readonly Char8 FromString(string src)
            =>ref src.PadRight(CharCount).Substring(0,CharCount).AsReadOnlySpan().AsIndividual<char,Char8>();

        [MethodImpl(Inline)]
        public static implicit operator Span<char>(in Char8 src)
            => src.AsSpan();

        [MethodImpl(Inline)]
        public static implicit operator ReadOnlySpan<char>(in Char8 src)
            => src.AsReadOnlySpan();

        [MethodImpl(Inline)]
        public static implicit operator Char8(Span<char> src)
            => src.AsIndividual<char,Char8>();

        [MethodImpl(Inline)]
        public static implicit operator Char8(ReadOnlySpan<char> src)
            => src.AsIndividual<char,Char8>();

        /// <summary>
        /// Implicilty converts the source value to a string, removing any trailing whitespace characters
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static implicit operator Char8(string src)
            => FromString(src);

        [MethodImpl(Inline)]
        public unsafe Span<char> AsSpan()
            => SpanConvert.AsSpan<Char8,char>(ref this);


        [MethodImpl(Inline)]
        public ReadOnlySpan<char> AsReadOnlySpan()
            => SpanConvert.AsReadOnlySpan<Char8,char>(ref this);

        [MethodImpl(Inline)]
        public void Fill(ReadOnlySpan<char> src)
        {
            lo = src[0..3];
            hi = src[4..7];
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
        public bool Equals(Char8 rhs)
            => lo == rhs.lo && hi == rhs.hi;

        public override bool Equals(object rhs)
            => rhs is Char8 x ? Equals(x) : false;

   }
 
}