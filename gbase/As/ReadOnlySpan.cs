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
        public static ReadOnlySpan<sbyte> int8<T>(in ReadOnlySpan<T> src)
            where T : struct
                => cast<T,sbyte>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> uint8<T>(in ReadOnlySpan<T> src)
            where T : struct
                => cast<T,byte>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<short> int16<T>(in ReadOnlySpan<T> src)
            where T : struct
                => cast<T,short>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<ushort> uint16<T>(in ReadOnlySpan<T> src)
            where T : struct
                => cast<T,ushort>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<int> int32<T>(in ReadOnlySpan<T> src)
            where T : struct
                => cast<T,int>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<uint> uint32<T>(in ReadOnlySpan<T> src)
            where T : struct
                => cast<T,uint>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<long> int64<T>(in ReadOnlySpan<T> src)
            where T : struct
                => cast<T,long>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<ulong> uint64<T>(in ReadOnlySpan<T> src)
            where T : struct
                => cast<T,ulong>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<float> float32<T>(in ReadOnlySpan<T> src)
            where T : struct
                => cast<T,float>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<double> float64<T>(in ReadOnlySpan<T> src)
            where T : struct
                => cast<T,double>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlySpan<sbyte> src)
            where T : struct
                => cast<sbyte,T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlySpan<byte> src)
            where T : struct
                => cast<byte,T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlySpan<short> src)
            where T : struct
                => cast<short,T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlySpan<ushort> src)
            where T : struct
                => cast<ushort,T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlySpan<int> src)
            where T : struct
                => cast<int,T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlySpan<uint> src)
            where T : struct
                => cast<uint,T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlySpan<long> src)
            where T : struct
                => cast<long,T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlySpan<ulong> src)
            where T : struct
                => cast<ulong,T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlySpan<float> src)
            where T : struct
                => cast<float,T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlySpan<double> src)
            where T : struct
                => cast<double,T>(src);
    }

}