//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.IO;
    
    using static zfunc;

    /// <summary>
    /// Specifies a memory size UOM in bits
    /// </summary>
    public readonly struct BitSize
    {
        public static bool operator ==(BitSize lhs, BitSize rhs)
            => lhs.Bits == rhs.Bits;

        [MethodImpl(Inline)]
        public static bool operator !=(BitSize lhs, BitSize rhs)
            => lhs.Bits != rhs.Bits;

        [MethodImpl(Inline)]
        public static BitSize operator +(BitSize lhs, BitSize rhs)
            => lhs.Bits + rhs.Bits;

        [MethodImpl(Inline)]
        public static BitSize operator -(BitSize lhs, BitSize rhs)
            => lhs.Bits - rhs.Bits;

        [MethodImpl(Inline)]
        public static BitSize operator *(BitSize lhs, BitSize rhs)
            => lhs.Bits * rhs.Bits;

        [MethodImpl(Inline)]
        public static BitSize operator /(BitSize lhs, BitSize rhs)
            => lhs.Bits / rhs.Bits;

        [MethodImpl(Inline)]
        public static BitSize operator %(BitSize lhs, BitSize rhs)
            => lhs.Bits % rhs.Bits;

        [MethodImpl(Inline)]
        public static BitSize Define(int bits)
            => new BitSize((ulong)bits);

        [MethodImpl(Inline)]
        public static BitSize Define(long bits)
            => new BitSize((ulong)bits);

        [MethodImpl(Inline)]
        public static BitSize Define(ulong bits)
            => new BitSize(bits);

        [MethodImpl(Inline)]
        public static implicit operator int(BitSize src)
            => (int)src.Bits;

        [MethodImpl(Inline)]
        public static implicit operator uint(BitSize src)
            => (uint)src.Bits;

        [MethodImpl(Inline)]
        public static implicit operator long(BitSize src)
            => (long)src.Bits;

        [MethodImpl(Inline)]
        public static implicit operator ulong(BitSize src)
            => src.Bits;

        [MethodImpl(Inline)]
        public static implicit operator BitSize(int src)
            => new BitSize((ulong)src);

        [MethodImpl(Inline)]
        public static implicit operator BitSize(long src)
            => new BitSize((ulong)src);

        [MethodImpl(Inline)]
        public static implicit operator BitSize(byte src)
            => new BitSize((ulong)src);

        [MethodImpl(Inline)]
        public static implicit operator BitSize(ushort src)
            => new BitSize((ulong)src);

        [MethodImpl(Inline)]
        public static implicit operator BitSize(uint src)
            => new BitSize((ulong)src);

        [MethodImpl(Inline)]
        public static implicit operator BitSize(ulong src)
            => new BitSize(src);

        [MethodImpl(Inline)]
        public static implicit operator BitSize(ByteSize src)
            => src.Bytes * 8;


        [MethodImpl(Inline)]
        public BitSize(ulong Bits)
            => this.Bits = Bits;

        /// <summary>
        /// Specifies the number of bits
        /// </summary>
        public readonly ulong Bits;

        public ByteSize ToBytes()
            =>  Bits / 8;

        public override string ToString()
            => Bits.ToString();

        public bool Equals(BitSize rhs)
            => Bits == rhs.Bits;

        public override int GetHashCode()
            => Bits.GetHashCode();

        public override bool Equals(object obj)
            => obj is BitSize ? Equals((BitSize)obj) : false;
    }
}