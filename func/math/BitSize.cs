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
        /// <summary>
        /// Specifies a bit count
        /// </summary>
        public readonly ulong Bits;

        /// <summary>
        /// The canonical zero size
        /// </summary>
        public static readonly BitSize Zero = default;
         
        public static readonly BitSize x8 = 8;

        public static readonly BitSize x16 = 16;

        public static readonly BitSize x32 = 32;

        public static readonly BitSize x64 = 64;

        public static readonly BitSize x128 = 128;

        public static readonly BitSize x256 = 256;

        /// <summary>
        /// Returns the bit size of a type
        /// </summary>
        /// <typeparam name="T">The type to evaluate</typeparam>
        [MethodImpl(Inline)]
        public static BitSize Size<T>()
            where T : struct
                => Unsafe.SizeOf<T>()*8;
        
        [MethodImpl(Inline)]
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
        public static explicit operator byte(BitSize src)
            => (byte)src.Bits;

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

        public ByteSize ToBytes()
            =>  Bits / 8;

        public override string ToString()
            => Bits.ToString();

        [MethodImpl(Inline)]
        public bool Equals(BitSize rhs)
            => Bits == rhs.Bits;

        public override int GetHashCode()
            => Bits.GetHashCode();

        public override bool Equals(object obj)
            => obj is BitSize ? Equals((BitSize)obj) : false;
 
        public bool IsNonZero
        {
            [MethodImpl(Inline)]
            get => Bits != 0;
        }
    }
}