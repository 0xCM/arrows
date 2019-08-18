//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using System.Security;
    
    using static zfunc;

    partial class As
    {
        [MethodImpl(Inline)]
        public static ReadOnlySpan<sbyte> int8<T>(ReadOnlyMemory<T> src)
            where T : struct
                => cast<T,sbyte>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> uint8<T>(ReadOnlyMemory<T> src)
            where T : struct
                => cast<T,byte>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<short> int16<T>(ReadOnlyMemory<T> src)
            where T : struct
                => cast<T,short>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<ushort> uint16<T>(ReadOnlyMemory<T> src)
            where T : struct
                => cast<T,ushort>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<int> int32<T>(ReadOnlyMemory<T> src)
            where T : struct
                => cast<T,int>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<uint> uint32<T>(ReadOnlyMemory<T> src)
            where T : struct
                => cast<T,uint>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<long> int64<T>(ReadOnlyMemory<T> src)
            where T : struct
                => cast<T,long>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<ulong> uint64<T>(ReadOnlyMemory<T> src)
            where T : struct
                => cast<T,ulong>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<float> float32<T>(ReadOnlyMemory<T> src)
            where T : struct
                => cast<T,float>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<double> float64<T>(ReadOnlyMemory<T> src)
            where T : struct
                => cast<T,double>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlyMemory<sbyte> src)
            where T : struct
                => cast<sbyte,T>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlyMemory<byte> src)
            where T : struct
                => cast<byte,T>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlyMemory<short> src)
            where T : struct
                => cast<short,T>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlyMemory<ushort> src)
            where T : struct
                => cast<ushort,T>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlyMemory<int> src)
            where T : struct
                => cast<int,T>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlyMemory<uint> src)
            where T : struct
                => cast<uint,T>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlyMemory<long> src)
            where T : struct
                => cast<long,T>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlyMemory<ulong> src)
            where T : struct
                => cast<ulong,T>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlyMemory<float> src)
            where T : struct
                => cast<float,T>(src.Span);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlyMemory<double> src)
            where T : struct
                => cast<double,T>(src.Span);
    }

}