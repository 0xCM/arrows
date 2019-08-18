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

    public static partial class As
    {

        [MethodImpl(Inline)]
        public static Span<sbyte> int8<T>(Memory<T> src)
            where T : struct
                => cast<T,sbyte>(src.Span);

        [MethodImpl(Inline)]
        public static Span<byte> uint8<T>(Memory<T> src)
            where T : struct
                => cast<T,byte>(src.Span);

        [MethodImpl(Inline)]
        public static Span<short> int16<T>(Memory<T> src)
            where T : struct
                => cast<T,short>(src.Span);

        [MethodImpl(Inline)]
        public static Span<ushort> uint16<T>(Memory<T> src)
            where T : struct
                => cast<T,ushort>(src.Span);

        [MethodImpl(Inline)]
        public static Span<int> int32<T>(Memory<T> src)
            where T : struct
                => cast<T,int>(src.Span);

        [MethodImpl(Inline)]
        public static Span<uint> uint32<T>(Memory<T> src)
            where T : struct
                => cast<T,uint>(src.Span);

        [MethodImpl(Inline)]
        public static Span<long> int64<T>(Memory<T> src)
            where T : struct
                => cast<T,long>(src.Span);

        [MethodImpl(Inline)]
        public static Span<ulong> uint64<T>(Memory<T> src)
            where T : struct
                => cast<T,ulong>(src.Span);

        [MethodImpl(Inline)]
        public static Span<float> float32<T>(Memory<T> src)
            where T : struct
                => cast<T,float>(src.Span);

        [MethodImpl(Inline)]
        public static Span<double> float64<T>(Memory<T> src)
            where T : struct
                => cast<T,double>(src.Span);

        [MethodImpl(Inline)]
        public static Span<T> generic<T>(Memory<sbyte> src)
            where T : struct
                => cast<sbyte,T>(src.Span);

        [MethodImpl(Inline)]
        public static Span<T> generic<T>(Memory<byte> src)
            where T : struct
                => cast<byte,T>(src.Span);

        [MethodImpl(Inline)]
        public static Span<T> generic<T>(Memory<short> src)
            where T : struct
                => cast<short,T>(src.Span);

        [MethodImpl(Inline)]
        public static Span<T> generic<T>(Memory<ushort> src)
            where T : struct
                => cast<ushort,T>(src.Span);

        [MethodImpl(Inline)]
        public static Span<T> generic<T>(Memory<int> src)
            where T : struct
                => cast<int,T>(src.Span);

        [MethodImpl(Inline)]
        public static Span<T> generic<T>(Memory<uint> src)
            where T : struct
                => cast<uint,T>(src.Span);

        [MethodImpl(Inline)]
        public static Span<T> generic<T>(Memory<long> src)
            where T : struct
                => cast<long,T>(src.Span);

        [MethodImpl(Inline)]
        public static Span<T> generic<T>(Memory<ulong> src)
            where T : struct
                => cast<ulong,T>(src.Span);

        [MethodImpl(Inline)]
        public static Span<T> generic<T>(Memory<float> src)
            where T : struct
                => cast<float,T>(src.Span);

        [MethodImpl(Inline)]
        public static Span<T> generic<T>(Memory<double> src)
            where T : struct
                => cast<double,T>(src.Span);


    }

}