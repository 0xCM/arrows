//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Security;

    using static zcore;

    public static class As
    {
        [MethodImpl(Inline)]
        public static sbyte int8<T>(T src)
            => Unsafe.As<T,sbyte>(ref src);

        [MethodImpl(Inline)]
        public static byte uint8<T>(T src)
            => Unsafe.As<T,byte>(ref src);

        [MethodImpl(Inline)]
        public static short int16<T>(T src)
            => Unsafe.As<T,short>(ref src);

        [MethodImpl(Inline)]
        public static ushort uint16<T>(T src)
            => Unsafe.As<T,ushort>(ref src);

        [MethodImpl(Inline)]
        public static int int32<T>(T src)
            => Unsafe.As<T,int>(ref src);

        [MethodImpl(Inline)]
        public static uint uint32<T>(T src)
            => Unsafe.As<T,uint>(ref src);

        [MethodImpl(Inline)]
        public static long int64<T>(T src)
            => Unsafe.As<T,long>(ref src);

        [MethodImpl(Inline)]
        public static ulong uint64<T>(T src)
            => Unsafe.As<T,ulong>(ref src);

        [MethodImpl(Inline)]
        public static float float32<T>(T src)
            => Unsafe.As<T,float>(ref src);

        [MethodImpl(Inline)]
        public static double float64<T>(T src)
            => Unsafe.As<T,double>(ref src);

        [MethodImpl(Inline)]
        public static T generic<T>(sbyte src)
            => Unsafe.As<sbyte,T>(ref src);

        [MethodImpl(Inline)]
        public static T generic<T>(byte src)
            => Unsafe.As<byte,T>(ref src);
        
        [MethodImpl(Inline)]
        public static T generic<T>(short src)
            => Unsafe.As<short,T>(ref src);

        [MethodImpl(Inline)]
        public static T generic<T>(ushort src)
            => Unsafe.As<ushort,T>(ref src);

        [MethodImpl(Inline)]
        public static T generic<T>(int src)
            => Unsafe.As<int,T>(ref src);

        [MethodImpl(Inline)]
        public static T generic<T>(uint src)
            => Unsafe.As<uint,T>(ref src);

        [MethodImpl(Inline)]
        public static T generic<T>(long src)
            => Unsafe.As<long,T>(ref src);

        [MethodImpl(Inline)]
        public static T generic<T>(ulong src)
            => Unsafe.As<ulong,T>(ref src);

        [MethodImpl(Inline)]
        public static T generic<T>(float src)
            => Unsafe.As<float,T>(ref src);

        [MethodImpl(Inline)]
        public static T generic<T>(double src)
            => Unsafe.As<double,T>(ref src);
    }
}