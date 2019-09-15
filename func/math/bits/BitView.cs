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
        /// <summary>
        /// Wraps a bitview around a generic reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The generic type</typeparam>
        public static BitView<T> ViewBits<T>(ref T src)
            where T: struct
                => new BitView<T>(ref src);
    }

    /// <summary>
    /// Represents a value as an ordered sequence of bits/bytes
    /// </summary>
    public unsafe ref struct BitView<T>
        where T : struct
    {
        public readonly Span<byte> Bytes;

        [MethodImpl(Inline)]
        public static bool operator ==(BitView<T> lhs, BitView<T> rhs)
            => lhs.Bytes.Eq(rhs.Bytes);

        [MethodImpl(Inline)]
        public static bool operator !=(BitView<T> lhs, BitView<T> rhs)
            => !(lhs == rhs);

        [MethodImpl(Inline)]
        public BitView(ref T src)
        {
            Bytes = new Span<byte>(Unsafe.AsPointer(ref src), Unsafe.SizeOf<T>());
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
            get => (BitSize)ByteCount;
        }
        
        /// <summary>
        /// Selects an offset-identified byte
        /// </summary>
        public ref byte this[ByteSize offset]
        {
            [MethodImpl(Inline)]
            get => ref Bytes[offset];
        }

        /// <summary>
        /// Queries/Manipulates the source at the bit-level
        /// </summary>
        public Bit this[ByteSize offset, byte pos]        
        {
            [MethodImpl(Inline)]
            get => BitMask.test(in Bytes[offset], pos);
            
            [MethodImpl(Inline)]
            set => BitMask.set(ref Bytes[offset], pos, value);
                
        }

        [MethodImpl(Inline)]
        public void CopyTo(Span<byte> dst, int offset = 0)
            => Bytes.CopyTo(dst,offset);

        public override bool Equals(object obj)
            => throw new NotSupportedException();

        public override int GetHashCode()
            => throw new NotSupportedException();
    }
}