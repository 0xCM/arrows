//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    // public static partial class As
    // {
    //     [MethodImpl(Inline)]
    //     public static MemorySpan<sbyte> int8<T>(in MemorySpan<T> src)
    //         where T : unmanaged
    //             => src.As<sbyte>();

    //     [MethodImpl(Inline)]
    //     public static MemorySpan<byte> uint8<T>(in MemorySpan<T> src)
    //         where T : unmanaged
    //             => src.As<byte>();

    //     [MethodImpl(Inline)]
    //     public static MemorySpan<short> int16<T>(in MemorySpan<T> src)
    //         where T : unmanaged
    //             => src.As<short>();

    //     [MethodImpl(Inline)]
    //     public static MemorySpan<ushort> uint16<T>(in MemorySpan<T> src)
    //         where T : unmanaged
    //             => src.As<ushort>();

    //     [MethodImpl(Inline)]
    //     public static MemorySpan<int> int32<T>(in MemorySpan<T> src)
    //         where T : unmanaged
    //             => src.As<int>();

    //     [MethodImpl(Inline)]
    //     public static MemorySpan<uint> uint32<T>(in MemorySpan<T> src)
    //         where T : unmanaged
    //             => src.As<uint>();

    //     [MethodImpl(Inline)]
    //     public static MemorySpan<long> int64<T>(in MemorySpan<T> src)
    //         where T : unmanaged
    //             => src.As<long>();

    //     [MethodImpl(Inline)]
    //     public static MemorySpan<ulong> uint64<T>(in MemorySpan<T> src)
    //         where T : unmanaged
    //             => src.As<ulong>();

    //     [MethodImpl(Inline)]
    //     public static MemorySpan<float> float32<T>(in MemorySpan<T> src)
    //         where T : unmanaged
    //             => src.As<float>();

    //     [MethodImpl(Inline)]
    //     public static MemorySpan<double> float64<T>(in MemorySpan<T> src)
    //         where T : unmanaged
    //             => src.As<double>();

    //     [MethodImpl(Inline)]
    //     public static MemorySpan<T> generic<T>(in MemorySpan<sbyte> src)
    //         where T : unmanaged
    //             => src.As<T>();

    //     [MethodImpl(Inline)]
    //     public static MemorySpan<T> generic<T>(in MemorySpan<byte> src)
    //         where T : unmanaged
    //             => src.As<T>();

    //     [MethodImpl(Inline)]
    //     public static MemorySpan<T> generic<T>(in MemorySpan<short> src)
    //         where T : unmanaged
    //             => src.As<T>();

    //     [MethodImpl(Inline)]
    //     public static MemorySpan<T> generic<T>(in MemorySpan<ushort> src)
    //         where T : unmanaged
    //             => src.As<T>();

    //     [MethodImpl(Inline)]
    //     public static MemorySpan<T> generic<T>(in MemorySpan<int> src)
    //         where T : unmanaged
    //             => src.As<T>();

    //     [MethodImpl(Inline)]
    //     public static MemorySpan<T> generic<T>(in MemorySpan<uint> src)
    //         where T : unmanaged
    //             => src.As<T>();

    //     [MethodImpl(Inline)]
    //     public static MemorySpan<T> generic<T>(in MemorySpan<long> src)
    //         where T : unmanaged
    //             => src.As<T>();

    //     [MethodImpl(Inline)]
    //     public static MemorySpan<T> generic<T>(in MemorySpan<ulong> src)
    //         where T : unmanaged
    //             => src.As<T>();

    //     [MethodImpl(Inline)]
    //     public static MemorySpan<T> generic<T>(in MemorySpan<float> src)
    //         where T : unmanaged
    //             => src.As<T>();

    //     [MethodImpl(Inline)]
    //     public static MemorySpan<T> generic<T>(in MemorySpan<double> src)
    //         where T : unmanaged
    //             => src.As<T>();
    // }
}