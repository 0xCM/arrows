//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Diagnostics;

    using static zfunc;

    public static class BitView
    {
        public static BitView<T> ToBitView<T>(ref this T src)
            where T: struct
                => new BitView<T>(src);
    }

    /// <summary>
    /// Represents a struct array as an ordered sequence of bits/bytes
    /// </summary>
    public ref struct BitView<T>
        where T : struct
    {
        [MethodImpl(Inline)]
        public static bool operator ==(BitView<T> lhs, BitView<T> rhs)
            => lhs.Bytes.Eq(rhs.Bytes);

        [MethodImpl(Inline)]
        public static bool operator !=(BitView<T> lhs, BitView<T> rhs)
            => !(lhs == rhs);

        Span<T> Source;

        Span<byte> Bytes;

        [MethodImpl(Inline)]
        public BitView(params T[] content)
        {
            Source = content;
            Bytes = MemoryMarshal.AsBytes(Source);            
        }

        /// <summary>
        /// The total number of represented bytes
        /// </summary>
        public ByteSize ByteCount
        {
            [MethodImpl(Inline)]
            get => Bytes.Length;
        }

        /// <summary>
        /// The total number of represented bits
        /// </summary>
        public BitSize BitCount
        {
            [MethodImpl(Inline)]
            get => ByteCount;
        }

        /// <summary>
        /// The number of source source elements
        /// </summary>
        public int ItemCount
        {
            [MethodImpl(Inline)]
            get => Source.Length;
        }
        
        /// <summary>
        /// Selects an offset-identified byte
        /// </summary>
        /// <value></value>
        public ref byte this[ByteSize offset]
        {
            [MethodImpl(Inline)]
            get => ref Bytes[offset];
        }

        public Bit this[ByteSize offset, byte pos]        
        {
            get => Bits.test(in Bytes[offset], pos);
            set
            {                
                 if(value) 
                    Bits.enable(ref Bytes[offset], pos);
                else
                    Bits.disable(ref Bytes[offset], pos);
            }
                
        }

        [MethodImpl(Inline)]
        public Span<byte> ToSpan()
            => Bytes;

        [MethodImpl(Inline)]
        public void CopyTo(Span<byte> dst, int offset = 0)
            => Bytes.CopyTo(dst,offset);

        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override int GetHashCode()
            => throw new NotSupportedException();
    }

}