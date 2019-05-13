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
    public readonly struct ByteSize : IEquatable<ByteSize>
    {
        public static bool operator ==(ByteSize lhs, ByteSize rhs)
            => lhs.Bytes == rhs.Bytes;

        public static bool operator !=(ByteSize lhs, ByteSize rhs)
            => lhs.Bytes != rhs.Bytes;

        public static ByteSize operator +(ByteSize lhs, ByteSize rhs)
            => lhs.Bytes + rhs.Bytes;

        public static ByteSize operator -(ByteSize lhs, ByteSize rhs)
            => lhs.Bytes - rhs.Bytes;

        public static ByteSize operator *(ByteSize lhs, ByteSize rhs)
            => lhs.Bytes * rhs.Bytes;

        public static ByteSize operator /(ByteSize lhs, ByteSize rhs)
            => lhs.Bytes / rhs.Bytes;

        public static ByteSize operator %(ByteSize lhs, ByteSize rhs)
            => lhs.Bytes % rhs.Bytes;

        public static ByteSize Define(int bytes)
            => new ByteSize(bytes);

        public static implicit operator int(ByteSize src)
            => src.Bytes;

        public static implicit operator ByteSize(int src)
            => new ByteSize(src);

        public ByteSize(int Bytes)
            => this.Bytes = Bytes;

        /// <summary>
        /// Specifies the number of bytes
        /// </summary>
        public readonly int Bytes;

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