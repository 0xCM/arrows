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

    [StructLayout(LayoutKind.Explicit, Size = 32)]
    struct Block256i
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
        /// 64 bits of storage codified as an unsigned 64-bit integer
        /// </summary>
        [FieldOffset(16)]
        public ulong x2u;

        /// <summary>
        /// 64 bits of storage codified as an unsigned 64-bit integer
        /// </summary>
        [FieldOffset(24)]
        public ulong x3u;

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
        /// 64 bits of storage codified as a signed 64-bit integer
        /// </summary>
        [FieldOffset(16)]
        public long x2i;

        /// <summary>
        /// 64 bits of storage codified as a signed 64-bit integer
        /// </summary>
        [FieldOffset(24)]
        public long x3i;

        /// <summary>
        /// 256 bits of storage codified as an intrinsic vector with signed 8-bit integer components
        /// </summary>
        [FieldOffset(0)]
        public Vector256<sbyte> v256x8i;

        /// <summary>
        /// 256 bits of storage codified as an intrinsic vector with unsigned 8-bit integer components
        /// </summary>
        [FieldOffset(0)]
        public Vector256<byte> v256x8u;

        /// <summary>
        /// 256 bits of storage codified as an intrinsic vector with signed 16-bit integer components
        /// </summary>
        [FieldOffset(0)]
        public Vector256<short> v256x16i;

        /// <summary>
        /// 256 bits of storage codified as an intrinsic vector with unsigned 16-bit integer components
        /// </summary>
        [FieldOffset(0)]
        public Vector256<ushort> v256x16u;

        /// <summary>
        /// 256 bits of storage codified as an intrinsic vector with signed 32-bit integer components
        /// </summary>
        [FieldOffset(0)]
        public Vector256<int> v256x32i;

        /// <summary>
        /// 256 bits of storage codified as an intrinsic vector with unsigned 32-bit integer components
        /// </summary>
        [FieldOffset(0)]
        public Vector256<uint> v256x32u;

        /// <summary>
        /// 256 bits of storage codified as an intrinsic vector with signed 64-bit integer components
        /// </summary>
        [FieldOffset(0)]
        public Vector256<long> v256x64i;

        /// <summary>
        /// 256 bits of storage codified as an intrinsic vector with unsigned 64-bit integer components
        /// </summary>
        [FieldOffset(0)]
        public Vector256<ulong> v256x64u;

    }


}