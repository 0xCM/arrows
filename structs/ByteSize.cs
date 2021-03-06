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
    /// Defines size with respect to bytes
    /// </summary>
    public readonly struct ByteSize
    {
        /// <summary>
        /// Specifies a number of bytes
        /// </summary>
        public readonly int Bytes;

        [MethodImpl(Inline)]
        public static bool operator ==(ByteSize lhs, ByteSize rhs)
            => lhs.Bytes == rhs.Bytes;

        [MethodImpl(Inline)]
        public static bool operator !=(ByteSize lhs, ByteSize rhs)
            => lhs.Bytes != rhs.Bytes;

        [MethodImpl(Inline)]
        public static ByteSize operator +(ByteSize lhs, ByteSize rhs)
            => lhs.Bytes + rhs.Bytes;

        [MethodImpl(Inline)]
        public static ByteSize operator -(ByteSize lhs, ByteSize rhs)
            => lhs.Bytes - rhs.Bytes;

        [MethodImpl(Inline)]
        public static ByteSize operator *(ByteSize lhs, ByteSize rhs)
            => lhs.Bytes * rhs.Bytes;

        [MethodImpl(Inline)]
        public static ByteSize operator /(ByteSize lhs, ByteSize rhs)
            => lhs.Bytes / rhs.Bytes;

        [MethodImpl(Inline)]
        public static ByteSize operator %(ByteSize lhs, ByteSize rhs)
            => lhs.Bytes % rhs.Bytes;

        [MethodImpl(Inline)]
        public static ByteSize Define(int bytes)
            => new ByteSize(bytes);

        [MethodImpl(Inline)]
        public static implicit operator int(ByteSize src)
            => src.Bytes;

        [MethodImpl(Inline)]
        public static implicit operator uint(ByteSize src)
            => (uint)src.Bytes;

        [MethodImpl(Inline)]
        public static implicit operator ByteSize(int src)
            => new ByteSize(src);

        [MethodImpl(Inline)]
        public static implicit operator ByteSize(ulong src)
            => new ByteSize((int)src);

        [MethodImpl(Inline)]
        public ByteSize(int Bytes)
            => this.Bytes = Bytes;

        [MethodImpl(Inline)]
        public ulong ToBits()
            => (ulong)Bytes * 8ul;

        public override string ToString()
            => Bytes.ToString();

        public override int GetHashCode()
            => Bytes.GetHashCode();

        public bool Equals(ByteSize rhs)
            => Bytes == rhs.Bytes;
    
        public override bool Equals(object obj)
            => obj is ByteSize ? Equals((ByteSize)obj) : false;
    }
}