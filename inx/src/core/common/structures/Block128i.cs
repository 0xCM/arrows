//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    [StructLayout(LayoutKind.Explicit, Size = 16)]
    struct Block128i
    {
        /// <summary>
        /// 64 bits of storage codified as an unsigned 64-bit integer
        /// </summary>
        [FieldOffset(0)]
        public ulong x0u;

        /// <summary>
        /// 64 bits of storage codified as an unsigned 64-bit integer
        /// </summary>
        [FieldOffset(8)]
        public ulong x1u;

        /// <summary>
        /// 64 bits of storage codified as a signed 64-bit integer
        /// </summary>
        [FieldOffset(0)]
        public long x0i;

        /// <summary>
        /// 64 bits of storage codified as a signed 64-bit integer
        /// </summary>
        [FieldOffset(8)]
        public long x1i;

        /// <summary>
        /// 128 bits of storage codified as an intrinsic vector with signed 8-bit integer components
        /// </summary>
        [FieldOffset(0)]
        public Vector128<sbyte> v128x8i;

        /// <summary>
        /// 128 bits of storage codified as an intrinsic vector with unsigned 8-bit integer components
        /// </summary>
        [FieldOffset(0)]
        public Vector128<byte> v128x8u;

        /// <summary>
        /// 128 bits of storage codified as an intrinsic vector with signed 16-bit integer components
        /// </summary>
        [FieldOffset(0)]
        public Vector128<short> v128x16i;

        /// <summary>
        /// 128 bits of storage codified as an intrinsic vector with unsigned 16-bit integer components
        /// </summary>
        [FieldOffset(0)]
        public Vector128<ushort> v128x16u;

        /// <summary>
        /// 128 bits of storage codified as an intrinsic vector with signed 32-bit integer components
        /// </summary>
        [FieldOffset(0)]
        public Vector128<int> v128x32i;

        /// <summary>
        /// 128 bits of storage codified as an intrinsic vector with unsigned 32-bit integer components
        /// </summary>
        [FieldOffset(0)]
        public Vector128<uint> v128x32u;

        /// <summary>
        /// 128 bits of storage codified as an intrinsic vector with signed 64-bit integer components
        /// </summary>
        [FieldOffset(0)]
        public Vector128<long> v128x64i;

        /// <summary>
        /// 128 bits of storage codified as an intrinsic vector with unsigned 64-bit integer components
        /// </summary>
        [FieldOffset(0)]
        public Vector128<ulong> v128x64u;

    }


}