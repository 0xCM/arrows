//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using static zfunc;

    public readonly struct BlockSize
    {
        [MethodImpl(Inline)]
        public static implicit operator ByteSize(BlockSize src)
            => src.Size;

        [MethodImpl(Inline)]
        public static implicit operator int(BlockSize src)
            => src.Size;

        /// <summary>
        /// Specifies the unit block lengh of 1 byte / 8 bits
        /// </summary>
        public static readonly BlockSize BS1 = new BlockSize(1);

        /// <summary>
        /// Specifies a block length of 2 bytes / 16 bits
        /// </summary>
        public static readonly BlockSize BS2 = new BlockSize(2);

        /// <summary>
        /// Specifies a block length of 4 bytes / 32 bits
        /// </summary>
        public static readonly BlockSize BS4 = new BlockSize(4);

        /// <summary>
        /// Specifies a block length of 8 bytes / 64 bits
        /// </summary>
        public static readonly BlockSize BS8 = new BlockSize(8);

        /// <summary>
        /// Specifies a block length of 16 bytes / 128 bits
        /// </summary>
        public static readonly BlockSize BS16 = new BlockSize(16);

        /// <summary>
        /// Specifies a block length of 32 bytes / 256 bits
        /// </summary>
        public static readonly BlockSize BS32 = new BlockSize(32);

        /// <summary>
        /// Specifies a block length of 64 bytes / 512 bits
        /// </summary>
        public static readonly BlockSize BS64 = new BlockSize(64);

        [MethodImpl(Inline)]
        public BlockSize(ByteSize Size)
            => this.Size = Size;

        public readonly ByteSize Size;

        public int BitCount
            => Size*8;
    }
}