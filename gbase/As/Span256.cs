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
        public static Span256<sbyte> int8<T>(Span256<T> src)
            where T : struct
                => cast<T,sbyte>(src);

        [MethodImpl(Inline)]
        public static Span256<byte> uint8<T>(Span256<T> src)
            where T : struct
                => cast<T,byte>(src);

        [MethodImpl(Inline)]
        public static Span256<short> int16<T>(Span256<T> src)
            where T : struct
                => cast<T,short>(src);

        [MethodImpl(Inline)]
        public static Span256<ushort> uint16<T>(Span256<T> src)
            where T : struct
                => cast<T,ushort>(src);

        [MethodImpl(Inline)]
        public static Span256<int> int32<T>(Span256<T> src)
            where T : struct
                => cast<T,int>(src);

        [MethodImpl(Inline)]
        public static Span256<uint> uint32<T>(Span256<T> src)
            where T : struct
                => cast<T,uint>(src);

        [MethodImpl(Inline)]
        public static Span256<long> int64<T>(Span256<T> src)
            where T : struct
                => cast<T,long>(src);

        [MethodImpl(Inline)]
        public static Span256<ulong> uint64<T>(Span256<T> src)
            where T : struct
                => cast<T,ulong>(src);

        [MethodImpl(Inline)]
        public static Span256<float> float32<T>(Span256<T> src)
            where T : struct
                => cast<T,float>(src);

        [MethodImpl(Inline)]
        public static Span256<double> float64<T>(Span256<T> src)
            where T : struct
                => cast<T,double>(src);

        [MethodImpl(Inline)]
        public static Span256<T> generic<T>(Span256<sbyte> src)
            where T : struct
                => cast<sbyte,T>(src);

        [MethodImpl(Inline)]
        public static Span256<T> generic<T>(Span256<byte> src)
            where T : struct
                => cast<byte,T>(src);


        [MethodImpl(Inline)]
        public static Span256<T> generic<T>(Span256<short> src)
            where T : struct
                => cast<short,T>(src);


        [MethodImpl(Inline)]
        public static Span256<T> generic<T>(Span256<ushort> src)
            where T : struct
                => cast<ushort,T>(src);


        [MethodImpl(Inline)]
        public static Span256<T> generic<T>(Span256<int> src)
            where T : struct
                => cast<int,T>(src);


        [MethodImpl(Inline)]
        public static Span256<T> generic<T>(Span256<uint> src)
            where T : struct
                => cast<uint,T>(src);


        [MethodImpl(Inline)]
        public static Span256<T> generic<T>(Span256<long> src)
            where T : struct
                => cast<long,T>(src);


        [MethodImpl(Inline)]
        public static Span256<T> generic<T>(Span256<ulong> src)
            where T : struct
                => cast<ulong,T>(src);

        [MethodImpl(Inline)]
        public static Span256<T> generic<T>(Span256<float> src)
            where T : struct
                => cast<float,T>(src);

        [MethodImpl(Inline)]
        public static Span256<T> generic<T>(Span256<double> src)
            where T : struct
                => cast<double,T>(src);



    }

}