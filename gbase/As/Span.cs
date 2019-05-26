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

    public static partial class As
    {


        [MethodImpl(Inline)]
        public static Span<sbyte> int8<T>(Span<T> src)
            where T : struct
                => cast<T,sbyte>(src);

        [MethodImpl(Inline)]
        public static Span<byte> uint8<T>(Span<T> src)
            where T : struct
                => cast<T,byte>(src);

        [MethodImpl(Inline)]
        public static Span<short> int16<T>(Span<T> src)
            where T : struct
                => cast<T,short>(src);

        [MethodImpl(Inline)]
        public static Span<ushort> uint16<T>(Span<T> src)
            where T : struct
                => cast<T,ushort>(src);

        [MethodImpl(Inline)]
        public static Span<int> int32<T>(Span<T> src)
            where T : struct
                => cast<T,int>(src);

        [MethodImpl(Inline)]
        public static Span<uint> uint32<T>(Span<T> src)
            where T : struct
                => cast<T,uint>(src);

        [MethodImpl(Inline)]
        public static Span<long> int64<T>(Span<T> src)
            where T : struct
                => cast<T,long>(src);

        [MethodImpl(Inline)]
        public static Span<ulong> uint64<T>(Span<T> src)
            where T : struct
                => cast<T,ulong>(src);

        [MethodImpl(Inline)]
        public static Span<float> float32<T>(Span<T> src)
            where T : struct
                => cast<T,float>(src);

        [MethodImpl(Inline)]
        public static Span<double> float64<T>(Span<T> src)
            where T : struct
                => cast<T,double>(src);


        [MethodImpl(Inline)]
        public static Span<T> generic<T>(Span<sbyte> src)
            where T : struct
                => cast<sbyte,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> generic<T>(Span<byte> src)
            where T : struct
                => cast<byte,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> generic<T>(Span<short> src)
            where T : struct
                => cast<short,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> generic<T>(Span<ushort> src)
            where T : struct
                => cast<ushort,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> generic<T>(Span<int> src)
            where T : struct
                => cast<int,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> generic<T>(Span<uint> src)
            where T : struct
                => cast<uint,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> generic<T>(Span<long> src)
            where T : struct
                => cast<long,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> generic<T>(Span<ulong> src)
            where T : struct
                => cast<ulong,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> generic<T>(Span<float> src)
            where T : struct
                => cast<float,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> generic<T>(Span<double> src)
            where T : struct
                => cast<double,T>(src);



    }

}