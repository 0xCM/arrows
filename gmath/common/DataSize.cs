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

    using static zcore;

    public readonly struct DataSize
    {
        public static implicit operator ByteSize(DataSize src)
            => src.Size;

        public static implicit operator int(DataSize src)
            => src.Size;

        const int DS1 = Pow2.T00;

        const int DS2 = Pow2.T01;

        const int DS4 = Pow2.T02;

        const int DS8 = Pow2.T03;

        const int DS16 = Pow2.T04;

        const int DS32 = Pow2.T05;

        /// <summary>
        /// Specifies a data length of 1 byte, e.g. byte | sbyte
        /// </summary>
        public static readonly DataSize Size1 = new DataSize(DS1);

        /// <summary>
        /// Specifies a data length of 2 bytes, e.g. short | ushort
        /// </summary>
        public static readonly DataSize Size2 = new DataSize(DS2);

        /// <summary>
        /// Specifies a data length of 4 bytes, e.g. int | uint | float
        /// </summary>
        public static readonly DataSize Size4 = new DataSize(DS4);

        /// <summary>
        /// Specifies a data length of 8 bytes, e.g. long | ulong | double
        /// </summary>
        public static readonly DataSize Size8 = new DataSize(DS8);

        /// <summary>
        /// Specifies a data length of 16 bytes, e.g, Guid | decimal | Vec128
        /// </summary>
        public static readonly DataSize Size16 = new DataSize(DS16);

        /// <summary>
        /// Specifies a data length of 32 bytes, e.g. Vec256
        /// </summary>
        public static readonly DataSize Size32 = new DataSize(DS32);


        DataSize(ByteSize Size)
            => this.Size = Size;

        public readonly ByteSize Size;

        public int BitCount
            => Size*8;

    }


}