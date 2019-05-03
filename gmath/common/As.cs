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

    using static zcore;

    public static class As
    {
        #region primitives

        [MethodImpl(Inline)]
        public static sbyte int8<T>(T src)
            => Unsafe.As<T,sbyte>(ref src);

        [MethodImpl(Inline)]
        public static ref sbyte int8<T>(ref T src)
            => ref Unsafe.As<T,sbyte>(ref src);

        [MethodImpl(Inline)]
        public static byte uint8<T>(T src)
            => Unsafe.As<T,byte>(ref src);

        [MethodImpl(Inline)]
        public static ref byte uint8<T>(ref T src)
            => ref Unsafe.As<T,byte>(ref src);

        [MethodImpl(Inline)]
        public static short int16<T>(T src)
            => Unsafe.As<T,short>(ref src);

        [MethodImpl(Inline)]
        public static ref short int16<T>(ref T src)
            => ref Unsafe.As<T,short>(ref src);

        [MethodImpl(Inline)]
        public static ushort uint16<T>(T src)
            => Unsafe.As<T,ushort>(ref src);

        [MethodImpl(Inline)]
        public static ref ushort uint16<T>(ref T src)
            => ref Unsafe.As<T,ushort>(ref src);

        [MethodImpl(Inline)]
        public static int int32<T>(T src)
            => Unsafe.As<T,int>(ref src);

        [MethodImpl(Inline)]
        public static ref int int32<T>(ref T src)
            => ref Unsafe.As<T,int>(ref src);

        [MethodImpl(Inline)]
        public static uint uint32<T>(T src)
            => Unsafe.As<T,uint>(ref src);

        [MethodImpl(Inline)]
        public static ref uint uint32<T>(ref T src)
            => ref Unsafe.As<T,uint>(ref src);

        [MethodImpl(Inline)]
        public static long int64<T>(T src)
            => Unsafe.As<T,long>(ref src);

        [MethodImpl(Inline)]
        public static ref long int64<T>(ref T src)
            => ref Unsafe.As<T,long>(ref src);

        [MethodImpl(Inline)]
        public static ulong uint64<T>(T src)
            => Unsafe.As<T,ulong>(ref src);

        [MethodImpl(Inline)]
        public static ref ulong uint64<T>(ref T src)
            => ref Unsafe.As<T,ulong>(ref src);

        [MethodImpl(Inline)]
        public static float float32<T>(T src)
            => Unsafe.As<T,float>(ref src);

        [MethodImpl(Inline)]
        public static ref float float32<T>(ref T src)
            => ref Unsafe.As<T,float>(ref src);

        [MethodImpl(Inline)]
        public static double float64<T>(T src)
            => Unsafe.As<T,double>(ref src);

        [MethodImpl(Inline)]
        public static ref double float64<T>(ref T src)
            => ref Unsafe.As<T,double>(ref src);

        [MethodImpl(Inline)]
        public static T generic<T>(sbyte src)
            => Unsafe.As<sbyte,T>(ref src);

        [MethodImpl(Inline)]
        public static ref T generic<T>(ref sbyte src)
            => ref Unsafe.As<sbyte,T>(ref src);

        [MethodImpl(Inline)]
        public static T generic<T>(byte src)
            => Unsafe.As<byte,T>(ref src);


        [MethodImpl(Inline)]
        public static ref T generic<T>(ref byte src)
            => ref Unsafe.As<byte,T>(ref src);

        [MethodImpl(Inline)]
        public static T generic<T>(short src)
            => Unsafe.As<short,T>(ref src);

        [MethodImpl(Inline)]
        public static ref T generic<T>(ref short src)
            => ref Unsafe.As<short,T>(ref src);

        [MethodImpl(Inline)]
        public static T generic<T>(ushort src)
            => Unsafe.As<ushort,T>(ref src);

        [MethodImpl(Inline)]
        public static ref T generic<T>(ref ushort src)
            => ref Unsafe.As<ushort,T>(ref src);

        [MethodImpl(Inline)]
        public static T generic<T>(int src)
            => Unsafe.As<int,T>(ref src);

        [MethodImpl(Inline)]
        public static ref T generic<T>(ref int src)
            => ref Unsafe.As<int,T>(ref src);

        [MethodImpl(Inline)]
        public static T generic<T>(uint src)
            => Unsafe.As<uint,T>(ref src);

        [MethodImpl(Inline)]
        public static ref T generic<T>(ref uint src)
            => ref Unsafe.As<uint,T>(ref src);

        [MethodImpl(Inline)]
        public static T generic<T>(long src)
            => Unsafe.As<long,T>(ref src);

        [MethodImpl(Inline)]
        public static ref T generic<T>(ref long src)
            => ref Unsafe.As<long,T>(ref src);

        [MethodImpl(Inline)]
        public static T generic<T>(ulong src)
            => Unsafe.As<ulong,T>(ref src);

        [MethodImpl(Inline)]
        public static ref T generic<T>(ref ulong src)
            => ref Unsafe.As<ulong,T>(ref src);

        [MethodImpl(Inline)]
        public static T generic<T>(float src)
            => Unsafe.As<float,T>(ref src);


        [MethodImpl(Inline)]
        public static ref T generic<T>(ref float src)
            => ref Unsafe.As<float,T>(ref src);

        [MethodImpl(Inline)]
        public static T generic<T>(double src)
            => Unsafe.As<double,T>(ref src);

        [MethodImpl(Inline)]
        public static ref T generic<T>(ref double src)
            => ref Unsafe.As<double,T>(ref src);

        #endregion

        #region num

        [MethodImpl(Inline)]
        public static T[] data<T>(num<T>[] src)
            where T : struct, IEquatable<T>
                => Unsafe.As<num<T>[], T[]>(ref src);

        [MethodImpl(Inline)]
        public static num<T>[] numbers<T>(T[] src)
            where T : struct, IEquatable<T>
                => Unsafe.As<T[],num<T>[]>(ref src);

        #endregion


        #region arrays

        [MethodImpl(Inline)]
        public static sbyte[] int8<T>(T[] src)
            => Unsafe.As<T[],sbyte[]>(ref src);

        [MethodImpl(Inline)]
        public static ref sbyte[] int8<T>(ref T[] src)
            => ref Unsafe.As<T[],sbyte[]>(ref src);

        [MethodImpl(Inline)]
        public static byte[] uint8<T>(T[] src)
            => Unsafe.As<T[],byte[]>(ref src);

        [MethodImpl(Inline)]
        public static ref byte[] uint8<T>(ref T[] src)
            => ref Unsafe.As<T[],byte[]>(ref src);

        [MethodImpl(Inline)]
        public static short[] int16<T>(T[] src)
            => Unsafe.As<T[],short[]>(ref src);

        [MethodImpl(Inline)]
        public static ref short[] int16<T>(ref T[] src)
            => ref Unsafe.As<T[],short[]>(ref src);

        [MethodImpl(Inline)]
        public static ushort[] uint16<T>(T[] src)
            => Unsafe.As<T[],ushort[]>(ref src);

        [MethodImpl(Inline)]
        public static ref ushort[] uint16<T>(ref T[] src)
            => ref Unsafe.As<T[],ushort[]>(ref src);

        [MethodImpl(Inline)]
        public static int[] int32<T>(T[] src)
            => Unsafe.As<T[],int[]>(ref src);

        [MethodImpl(Inline)]
        public static ref int[] int32<T>(ref T[] src)
            => ref Unsafe.As<T[],int[]>(ref src);

        [MethodImpl(Inline)]
        public static ref uint[] uint32<T>(ref T[] src)
            => ref Unsafe.As<T[],uint[]>(ref src);

        [MethodImpl(Inline)]
        public static uint[] uint32<T>(T[] src)
            => Unsafe.As<T[],uint[]>(ref src);


        [MethodImpl(Inline)]
        public static long[] int64<T>(T[] src)
            => Unsafe.As<T[],long[]>(ref src);

        [MethodImpl(Inline)]
        public static ref long[] int64<T>(ref T[] src)
            => ref Unsafe.As<T[],long[]>(ref src);

        [MethodImpl(Inline)]
        public static ref ulong[] uint64<T>(ref T[] src)
            => ref Unsafe.As<T[],ulong[]>(ref src);

        [MethodImpl(Inline)]
        public static ulong[] uint64<T>(T[] src)
            => Unsafe.As<T[],ulong[]>(ref src);


        [MethodImpl(Inline)]
        public static float[] float32<T>(T[] src)
            => Unsafe.As<T[],float[]>(ref src);

        [MethodImpl(Inline)]
        public static ref float[] float32<T>(ref T[] src)
            => ref Unsafe.As<T[],float[]>(ref src);

        [MethodImpl(Inline)]
        public static double[] float64<T>(T[] src)
            => Unsafe.As<T[],double[]>(ref src);

        [MethodImpl(Inline)]
        public static ref double[] float64<T>(ref T[] src)
            => ref Unsafe.As<T[],double[]>(ref src);


        [MethodImpl(Inline)]
        public static T[] generic<T>(sbyte[] src)
            => Unsafe.As<sbyte[],T[]>(ref src);

        [MethodImpl(Inline)]
        public static ref T[] generic<T>(ref sbyte[] src)
            => ref Unsafe.As<sbyte[],T[]>(ref src);

        [MethodImpl(Inline)]
        public static T[] generic<T>(byte[] src)
            => Unsafe.As<byte[],T[]>(ref src);

        [MethodImpl(Inline)]
        public static ref T[] generic<T>(ref byte[] src)
            => ref Unsafe.As<byte[],T[]>(ref src);

        [MethodImpl(Inline)]
        public static T[] generic<T>(short[] src)
            => Unsafe.As<short[],T[]>(ref src);

        [MethodImpl(Inline)]
        public static ref T[] generic<T>(ref short[] src)
            => ref Unsafe.As<short[],T[]>(ref src);

        [MethodImpl(Inline)]
        public static T[] generic<T>(ushort[] src)
            => Unsafe.As<ushort[],T[]>(ref src);

        [MethodImpl(Inline)]
        public static ref T[] generic<T>(ref ushort[] src)
            => ref Unsafe.As<ushort[],T[]>(ref src);

        [MethodImpl(Inline)]
        public static T[] generic<T>(int[] src)
            => Unsafe.As<int[],T[]>(ref src);

        [MethodImpl(Inline)]
        public static ref T[] generic<T>(ref int[] src)
            => ref Unsafe.As<int[],T[]>(ref src);

        [MethodImpl(Inline)]
        public static T[] generic<T>(uint[] src)
            => Unsafe.As<uint[],T[]>(ref src);

        [MethodImpl(Inline)]
        public static ref T[] generic<T>(ref uint[] src)
            => ref Unsafe.As<uint[],T[]>(ref src);


        [MethodImpl(Inline)]
        public static T[] generic<T>(long[] src)
            => Unsafe.As<long[],T[]>(ref src);

        [MethodImpl(Inline)]
        public static ref T[] generic<T>(ref long[] src)
            => ref Unsafe.As<long[],T[]>(ref src);

        [MethodImpl(Inline)]
        public static T[] generic<T>(ulong[] src)
            => Unsafe.As<ulong[],T[]>(ref src);

        [MethodImpl(Inline)]
        public static ref T[] generic<T>(ref ulong[] src)
            => ref Unsafe.As<ulong[],T[]>(ref src);

        [MethodImpl(Inline)]
        public static T[] generic<T>(float[] src)
            => Unsafe.As<float[],T[]>(ref src);

        [MethodImpl(Inline)]
        public static ref T[] generic<T>(ref float[] src)
            => ref Unsafe.As<float[],T[]>(ref src);

        [MethodImpl(Inline)]
        public static T[] generic<T>(double[] src)
            => Unsafe.As<double[],T[]>(ref src);

        [MethodImpl(Inline)]
        public static ref T[] generic<T>(ref double[] src)
            => ref Unsafe.As<double[],T[]>(ref src);


        #endregion

        #region Num128

        //! Num128
        //! -------------------------------------------------------------------

        [MethodImpl(Inline)]
        internal static Num128<sbyte> int8<T>(Num128<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Num128<T>,Num128<sbyte>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Num128<sbyte> int8<T>(ref Num128<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Num128<T>,Num128<sbyte>>(ref src);

        [MethodImpl(Inline)]
        internal static Num128<byte> uint8<T>(Num128<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Num128<T>,Num128<byte>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Num128<byte> uint8<T>(ref Num128<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Num128<T>,Num128<byte>>(ref src);

        [MethodImpl(Inline)]
        internal static Num128<short> int16<T>(Num128<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Num128<T>,Num128<short>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Num128<short> int16<T>(ref Num128<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Num128<T>,Num128<short>>(ref src);

        [MethodImpl(Inline)]
        internal static Num128<ushort> uint16<T>(Num128<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Num128<T>,Num128<ushort>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Num128<ushort> uint16<T>(ref Num128<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Num128<T>,Num128<ushort>>(ref src);

        [MethodImpl(Inline)]
        internal static Num128<int> int32<T>(Num128<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Num128<T>,Num128<int>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Num128<int> int32<T>(ref Num128<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Num128<T>,Num128<int>>(ref src);

        [MethodImpl(Inline)]
        internal static Num128<uint> uint32<T>(Num128<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Num128<T>,Num128<uint>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Num128<uint> uint32<T>(ref Num128<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Num128<T>,Num128<uint>>(ref src);


        [MethodImpl(Inline)]
        internal static Num128<long> int64<T>(Num128<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Num128<T>,Num128<long>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Num128<long> int64<T>(ref Num128<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Num128<T>,Num128<long>>(ref src);

        [MethodImpl(Inline)]
        internal static Num128<ulong> uint64<T>(Num128<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Num128<T>,Num128<ulong>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Num128<ulong> uint64<T>(ref Num128<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Num128<T>,Num128<ulong>>(ref src);

        [MethodImpl(Inline)]
        internal static Num128<float> float32<T>(Num128<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Num128<T>,Num128<float>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Num128<float> float32<T>(ref Num128<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Num128<T>,Num128<float>>(ref src);

        [MethodImpl(Inline)]
        internal static Num128<double> float64<T>(Num128<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Num128<T>,Num128<double>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Num128<double> float64<T>(ref Num128<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Num128<T>,Num128<double>>(ref src);


        [MethodImpl(Inline)]
        internal static Num128<T> generic<T>(Num128<sbyte> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Num128<sbyte>,Num128<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Num128<T> generic<T>(ref Num128<sbyte> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Num128<sbyte>,Num128<T>>(ref src);

        [MethodImpl(Inline)]
        internal static Num128<T> generic<T>(Num128<byte> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Num128<byte>,Num128<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Num128<T> generic<T>(ref Num128<byte> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Num128<byte>,Num128<T>>(ref src);


        [MethodImpl(Inline)]
        internal static Num128<T> generic<T>(Num128<short> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Num128<short>,Num128<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Num128<T> generic<T>(ref Num128<short> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Num128<short>,Num128<T>>(ref src);


        [MethodImpl(Inline)]
        internal static Num128<T> generic<T>(Num128<ushort> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Num128<ushort>,Num128<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Num128<T> generic<T>(ref Num128<ushort> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Num128<ushort>,Num128<T>>(ref src);


        [MethodImpl(Inline)]
        internal static Num128<T> generic<T>(Num128<int> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Num128<int>,Num128<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Num128<T> generic<T>(ref Num128<int> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Num128<int>,Num128<T>>(ref src);

        [MethodImpl(Inline)]
        internal static Num128<T> generic<T>(Num128<uint> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Num128<uint>,Num128<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Num128<T> generic<T>(ref Num128<uint> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Num128<uint>,Num128<T>>(ref src);


        [MethodImpl(Inline)]
        internal static Num128<T> generic<T>(Num128<long> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Num128<long>,Num128<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Num128<T> generic<T>(ref Num128<long> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Num128<long>,Num128<T>>(ref src);

        [MethodImpl(Inline)]
        internal static Num128<T> generic<T>(Num128<ulong> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Num128<ulong>,Num128<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Num128<T> generic<T>(ref Num128<ulong> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Num128<ulong>,Num128<T>>(ref src);

        [MethodImpl(Inline)]
        internal static Num128<T> generic<T>(Num128<float> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Num128<float>,Num128<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Num128<T> generic<T>(ref Num128<float> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Num128<float>,Num128<T>>(ref src);


        [MethodImpl(Inline)]
        internal static Num128<T> generic<T>(Num128<double> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Num128<double>,Num128<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Num128<T> generic<T>(ref Num128<double> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Num128<double>,Num128<T>>(ref src);

        #endregion

        #region Num256

        //! Num256
        //! -------------------------------------------------------------------

        [MethodImpl(Inline)]
        internal static Num256<sbyte> int8<T>(Num256<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Num256<T>,Num256<sbyte>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Num256<sbyte> int8<T>(ref Num256<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Num256<T>,Num256<sbyte>>(ref src);

        [MethodImpl(Inline)]
        internal static Num256<byte> uint8<T>(Num256<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Num256<T>,Num256<byte>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Num256<byte> uint8<T>(ref Num256<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Num256<T>,Num256<byte>>(ref src);

        [MethodImpl(Inline)]
        internal static Num256<short> int16<T>(Num256<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Num256<T>,Num256<short>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Num256<short> int16<T>(ref Num256<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Num256<T>,Num256<short>>(ref src);

        [MethodImpl(Inline)]
        internal static Num256<ushort> uint16<T>(Num256<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Num256<T>,Num256<ushort>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Num256<ushort> uint16<T>(ref Num256<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Num256<T>,Num256<ushort>>(ref src);

        [MethodImpl(Inline)]
        internal static Num256<int> int32<T>(Num256<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Num256<T>,Num256<int>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Num256<int> int32<T>(ref Num256<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Num256<T>,Num256<int>>(ref src);

        [MethodImpl(Inline)]
        internal static Num256<uint> uint32<T>(Num256<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Num256<T>,Num256<uint>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Num256<uint> uint32<T>(ref Num256<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Num256<T>,Num256<uint>>(ref src);


        [MethodImpl(Inline)]
        internal static Num256<long> int64<T>(Num256<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Num256<T>,Num256<long>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Num256<long> int64<T>(ref Num256<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Num256<T>,Num256<long>>(ref src);

        [MethodImpl(Inline)]
        internal static Num256<ulong> uint64<T>(Num256<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Num256<T>,Num256<ulong>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Num256<ulong> uint64<T>(ref Num256<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Num256<T>,Num256<ulong>>(ref src);

        [MethodImpl(Inline)]
        internal static Num256<float> float32<T>(Num256<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Num256<T>,Num256<float>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Num256<float> float32<T>(ref Num256<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Num256<T>,Num256<float>>(ref src);

        [MethodImpl(Inline)]
        internal static Num256<double> float64<T>(Num256<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Num256<T>,Num256<double>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Num256<double> float64<T>(ref Num256<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Num256<T>,Num256<double>>(ref src);


        [MethodImpl(Inline)]
        internal static Num256<T> generic<T>(Num256<sbyte> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Num256<sbyte>,Num256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Num256<T> generic<T>(ref Num256<sbyte> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Num256<sbyte>,Num256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static Num256<T> generic<T>(Num256<byte> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Num256<byte>,Num256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Num256<T> generic<T>(ref Num256<byte> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Num256<byte>,Num256<T>>(ref src);


        [MethodImpl(Inline)]
        internal static Num256<T> generic<T>(Num256<short> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Num256<short>,Num256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Num256<T> generic<T>(ref Num256<short> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Num256<short>,Num256<T>>(ref src);


        [MethodImpl(Inline)]
        internal static Num256<T> generic<T>(Num256<ushort> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Num256<ushort>,Num256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Num256<T> generic<T>(ref Num256<ushort> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Num256<ushort>,Num256<T>>(ref src);


        [MethodImpl(Inline)]
        internal static Num256<T> generic<T>(Num256<int> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Num256<int>,Num256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Num256<T> generic<T>(ref Num256<int> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Num256<int>,Num256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static Num256<T> generic<T>(Num256<uint> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Num256<uint>,Num256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Num256<T> generic<T>(ref Num256<uint> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Num256<uint>,Num256<T>>(ref src);


        [MethodImpl(Inline)]
        internal static Num256<T> generic<T>(Num256<long> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Num256<long>,Num256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Num256<T> generic<T>(ref Num256<long> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Num256<long>,Num256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static Num256<T> generic<T>(Num256<ulong> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Num256<ulong>,Num256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Num256<T> generic<T>(ref Num256<ulong> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Num256<ulong>,Num256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static Num256<T> generic<T>(Num256<float> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Num256<float>,Num256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Num256<T> generic<T>(ref Num256<float> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Num256<float>,Num256<T>>(ref src);


        [MethodImpl(Inline)]
        internal static Num256<T> generic<T>(Num256<double> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Num256<double>,Num256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Num256<T> generic<T>(ref Num256<double> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Num256<double>,Num256<T>>(ref src);

        #endregion

        #region Vec128

        //! Vec128
        //! -------------------------------------------------------------------

        [MethodImpl(Inline)]
        internal static Vec128<sbyte> int8<T>(Vec128<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vec128<T>,Vec128<sbyte>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Vec128<sbyte> int8<T>(ref Vec128<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vec128<T>,Vec128<sbyte>>(ref src);

        [MethodImpl(Inline)]
        internal static Vec128<byte> uint8<T>(Vec128<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vec128<T>,Vec128<byte>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Vec128<byte> uint8<T>(ref Vec128<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vec128<T>,Vec128<byte>>(ref src);

        [MethodImpl(Inline)]
        internal static Vec128<short> int16<T>(Vec128<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vec128<T>,Vec128<short>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Vec128<short> int16<T>(ref Vec128<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vec128<T>,Vec128<short>>(ref src);

        [MethodImpl(Inline)]
        internal static Vec128<ushort> uint16<T>(Vec128<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vec128<T>,Vec128<ushort>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Vec128<ushort> uint16<T>(ref Vec128<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vec128<T>,Vec128<ushort>>(ref src);

        [MethodImpl(Inline)]
        internal static Vec128<int> int32<T>(Vec128<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vec128<T>,Vec128<int>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Vec128<int> int32<T>(ref Vec128<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vec128<T>,Vec128<int>>(ref src);

        [MethodImpl(Inline)]
        internal static Vec128<uint> uint32<T>(Vec128<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vec128<T>,Vec128<uint>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Vec128<uint> uint32<T>(ref Vec128<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vec128<T>,Vec128<uint>>(ref src);


        [MethodImpl(Inline)]
        internal static Vec128<long> int64<T>(Vec128<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vec128<T>,Vec128<long>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Vec128<long> int64<T>(ref Vec128<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vec128<T>,Vec128<long>>(ref src);

        [MethodImpl(Inline)]
        internal static Vec128<ulong> uint64<T>(Vec128<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vec128<T>,Vec128<ulong>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Vec128<ulong> uint64<T>(ref Vec128<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vec128<T>,Vec128<ulong>>(ref src);

        [MethodImpl(Inline)]
        internal static Vec128<float> float32<T>(Vec128<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vec128<T>,Vec128<float>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Vec128<float> float32<T>(ref Vec128<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vec128<T>,Vec128<float>>(ref src);

        [MethodImpl(Inline)]
        internal static Vec128<double> float64<T>(Vec128<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vec128<T>,Vec128<double>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Vec128<double> float64<T>(ref Vec128<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vec128<T>,Vec128<double>>(ref src);


        [MethodImpl(Inline)]
        internal static Vec128<T> generic<T>(Vec128<sbyte> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Vec128<sbyte>,Vec128<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vec128<T> generic<T>(ref Vec128<sbyte> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Vec128<sbyte>,Vec128<T>>(ref src);

        [MethodImpl(Inline)]
        internal static Vec128<T> generic<T>(Vec128<byte> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Vec128<byte>,Vec128<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vec128<T> generic<T>(ref Vec128<byte> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Vec128<byte>,Vec128<T>>(ref src);


        [MethodImpl(Inline)]
        internal static Vec128<T> generic<T>(Vec128<short> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Vec128<short>,Vec128<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vec128<T> generic<T>(ref Vec128<short> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Vec128<short>,Vec128<T>>(ref src);


        [MethodImpl(Inline)]
        internal static Vec128<T> generic<T>(Vec128<ushort> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Vec128<ushort>,Vec128<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vec128<T> generic<T>(ref Vec128<ushort> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Vec128<ushort>,Vec128<T>>(ref src);


        [MethodImpl(Inline)]
        internal static Vec128<T> generic<T>(Vec128<int> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Vec128<int>,Vec128<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vec128<T> generic<T>(ref Vec128<int> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Vec128<int>,Vec128<T>>(ref src);

        [MethodImpl(Inline)]
        internal static Vec128<T> generic<T>(Vec128<uint> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Vec128<uint>,Vec128<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vec128<T> generic<T>(ref Vec128<uint> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Vec128<uint>,Vec128<T>>(ref src);


        [MethodImpl(Inline)]
        internal static Vec128<T> generic<T>(Vec128<long> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Vec128<long>,Vec128<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vec128<T> generic<T>(ref Vec128<long> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Vec128<long>,Vec128<T>>(ref src);

        [MethodImpl(Inline)]
        internal static Vec128<T> generic<T>(Vec128<ulong> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Vec128<ulong>,Vec128<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vec128<T> generic<T>(ref Vec128<ulong> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Vec128<ulong>,Vec128<T>>(ref src);

        [MethodImpl(Inline)]
        internal static Vec128<T> generic<T>(Vec128<float> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Vec128<float>,Vec128<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vec128<T> generic<T>(ref Vec128<float> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Vec128<float>,Vec128<T>>(ref src);


        [MethodImpl(Inline)]
        internal static Vec128<T> generic<T>(Vec128<double> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Vec128<double>,Vec128<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vec128<T> generic<T>(ref Vec128<double> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Vec128<double>,Vec128<T>>(ref src);

        #endregion

        #region Vec256

        //! Vec256
        //! -------------------------------------------------------------------

        [MethodImpl(Inline)]
        internal static Vec256<sbyte> int8<T>(Vec256<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vec256<T>,Vec256<sbyte>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Vec256<sbyte> int8<T>(ref Vec256<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vec256<T>,Vec256<sbyte>>(ref src);

        [MethodImpl(Inline)]
        internal static Vec256<byte> uint8<T>(Vec256<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vec256<T>,Vec256<byte>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Vec256<byte> uint8<T>(ref Vec256<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vec256<T>,Vec256<byte>>(ref src);

        [MethodImpl(Inline)]
        internal static Vec256<short> int16<T>(Vec256<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vec256<T>,Vec256<short>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Vec256<short> int16<T>(ref Vec256<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vec256<T>,Vec256<short>>(ref src);

        [MethodImpl(Inline)]
        internal static Vec256<ushort> uint16<T>(Vec256<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vec256<T>,Vec256<ushort>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Vec256<ushort> uint16<T>(ref Vec256<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vec256<T>,Vec256<ushort>>(ref src);

        [MethodImpl(Inline)]
        internal static Vec256<int> int32<T>(Vec256<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vec256<T>,Vec256<int>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Vec256<int> int32<T>(ref Vec256<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vec256<T>,Vec256<int>>(ref src);

        [MethodImpl(Inline)]
        internal static Vec256<uint> uint32<T>(Vec256<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vec256<T>,Vec256<uint>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Vec256<uint> uint32<T>(ref Vec256<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vec256<T>,Vec256<uint>>(ref src);


        [MethodImpl(Inline)]
        internal static Vec256<long> int64<T>(Vec256<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vec256<T>,Vec256<long>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Vec256<long> int64<T>(ref Vec256<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vec256<T>,Vec256<long>>(ref src);

        [MethodImpl(Inline)]
        internal static Vec256<ulong> uint64<T>(Vec256<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vec256<T>,Vec256<ulong>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Vec256<ulong> uint64<T>(ref Vec256<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vec256<T>,Vec256<ulong>>(ref src);

        [MethodImpl(Inline)]
        internal static Vec256<float> float32<T>(Vec256<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vec256<T>,Vec256<float>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Vec256<float> float32<T>(ref Vec256<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vec256<T>,Vec256<float>>(ref src);

        [MethodImpl(Inline)]
        internal static Vec256<double> float64<T>(Vec256<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vec256<T>,Vec256<double>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Vec256<double> float64<T>(ref Vec256<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vec256<T>,Vec256<double>>(ref src);


        [MethodImpl(Inline)]
        internal static Vec256<T> generic<T>(Vec256<sbyte> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Vec256<sbyte>,Vec256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vec256<T> generic<T>(ref Vec256<sbyte> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Vec256<sbyte>,Vec256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static Vec256<T> generic<T>(Vec256<byte> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Vec256<byte>,Vec256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vec256<T> generic<T>(ref Vec256<byte> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Vec256<byte>,Vec256<T>>(ref src);


        [MethodImpl(Inline)]
        internal static Vec256<T> generic<T>(Vec256<short> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Vec256<short>,Vec256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vec256<T> generic<T>(ref Vec256<short> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Vec256<short>,Vec256<T>>(ref src);


        [MethodImpl(Inline)]
        internal static Vec256<T> generic<T>(Vec256<ushort> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Vec256<ushort>,Vec256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vec256<T> generic<T>(ref Vec256<ushort> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Vec256<ushort>,Vec256<T>>(ref src);


        [MethodImpl(Inline)]
        internal static Vec256<T> generic<T>(Vec256<int> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Vec256<int>,Vec256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vec256<T> generic<T>(ref Vec256<int> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Vec256<int>,Vec256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static Vec256<T> generic<T>(Vec256<uint> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Vec256<uint>,Vec256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vec256<T> generic<T>(ref Vec256<uint> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Vec256<uint>,Vec256<T>>(ref src);


        [MethodImpl(Inline)]
        internal static Vec256<T> generic<T>(Vec256<long> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Vec256<long>,Vec256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vec256<T> generic<T>(ref Vec256<long> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Vec256<long>,Vec256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static Vec256<T> generic<T>(Vec256<ulong> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Vec256<ulong>,Vec256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vec256<T> generic<T>(ref Vec256<ulong> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Vec256<ulong>,Vec256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static Vec256<T> generic<T>(Vec256<float> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Vec256<float>,Vec256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vec256<T> generic<T>(ref Vec256<float> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Vec256<float>,Vec256<T>>(ref src);


        [MethodImpl(Inline)]
        internal static Vec256<T> generic<T>(Vec256<double> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Vec256<double>,Vec256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vec256<T> generic<T>(ref Vec256<double> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Vec256<double>,Vec256<T>>(ref src);

        #endregion

        #region Vector128

        //! Vector128
        //! -------------------------------------------------------------------

         [MethodImpl(Inline)]
        internal static Vector128<sbyte> int8<T>(Vector128<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vector128<T>,Vector128<sbyte>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Vector128<sbyte> int8<T>(ref Vector128<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vector128<T>,Vector128<sbyte>>(ref src);

        [MethodImpl(Inline)]
        internal static Vector128<byte> uint8<T>(Vector128<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vector128<T>,Vector128<byte>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Vector128<byte> uint8<T>(ref Vector128<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vector128<T>,Vector128<byte>>(ref src);

        [MethodImpl(Inline)]
        internal static Vector128<short> int16<T>(Vector128<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vector128<T>,Vector128<short>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Vector128<short> int16<T>(ref Vector128<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vector128<T>,Vector128<short>>(ref src);

        [MethodImpl(Inline)]
        internal static Vector128<ushort> uint16<T>(Vector128<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vector128<T>,Vector128<ushort>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Vector128<ushort> uint16<T>(ref Vector128<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vector128<T>,Vector128<ushort>>(ref src);

        [MethodImpl(Inline)]
        internal static Vector128<int> int32<T>(Vector128<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vector128<T>,Vector128<int>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Vector128<int> int32<T>(ref Vector128<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vector128<T>,Vector128<int>>(ref src);

        [MethodImpl(Inline)]
        internal static Vector128<uint> uint32<T>(Vector128<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vector128<T>,Vector128<uint>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Vector128<uint> uint32<T>(ref Vector128<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vector128<T>,Vector128<uint>>(ref src);


        [MethodImpl(Inline)]
        internal static Vector128<long> int64<T>(Vector128<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vector128<T>,Vector128<long>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Vector128<long> int64<T>(ref Vector128<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vector128<T>,Vector128<long>>(ref src);

        [MethodImpl(Inline)]
        internal static Vector128<ulong> uint64<T>(Vector128<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vector128<T>,Vector128<ulong>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Vector128<ulong> uint64<T>(ref Vector128<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vector128<T>,Vector128<ulong>>(ref src);

        [MethodImpl(Inline)]
        internal static Vector128<float> float32<T>(Vector128<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vector128<T>,Vector128<float>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Vector128<float> float32<T>(ref Vector128<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vector128<T>,Vector128<float>>(ref src);

        [MethodImpl(Inline)]
        internal static Vector128<double> float64<T>(Vector128<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vector128<T>,Vector128<double>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Vector128<double> float64<T>(ref Vector128<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vector128<T>,Vector128<double>>(ref src);


        [MethodImpl(Inline)]
        internal static Vector128<T> generic<T>(Vector128<sbyte> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Vector128<sbyte>,Vector128<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vector128<T> generic<T>(ref Vector128<sbyte> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Vector128<sbyte>,Vector128<T>>(ref src);

        [MethodImpl(Inline)]
        internal static Vector128<T> generic<T>(Vector128<byte> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Vector128<byte>,Vector128<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vector128<T> generic<T>(ref Vector128<byte> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Vector128<byte>,Vector128<T>>(ref src);


        [MethodImpl(Inline)]
        internal static Vector128<T> generic<T>(Vector128<short> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Vector128<short>,Vector128<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vector128<T> generic<T>(ref Vector128<short> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Vector128<short>,Vector128<T>>(ref src);


        [MethodImpl(Inline)]
        internal static Vector128<T> generic<T>(Vector128<ushort> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Vector128<ushort>,Vector128<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vector128<T> generic<T>(ref Vector128<ushort> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Vector128<ushort>,Vector128<T>>(ref src);


        [MethodImpl(Inline)]
        internal static Vector128<T> generic<T>(Vector128<int> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Vector128<int>,Vector128<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vector128<T> generic<T>(ref Vector128<int> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Vector128<int>,Vector128<T>>(ref src);

        [MethodImpl(Inline)]
        internal static Vector128<T> generic<T>(Vector128<uint> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Vector128<uint>,Vector128<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vector128<T> generic<T>(ref Vector128<uint> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Vector128<uint>,Vector128<T>>(ref src);


        [MethodImpl(Inline)]
        internal static Vector128<T> generic<T>(Vector128<long> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Vector128<long>,Vector128<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vector128<T> generic<T>(ref Vector128<long> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Vector128<long>,Vector128<T>>(ref src);

        [MethodImpl(Inline)]
        internal static Vector128<T> generic<T>(Vector128<ulong> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Vector128<ulong>,Vector128<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vector128<T> generic<T>(ref Vector128<ulong> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Vector128<ulong>,Vector128<T>>(ref src);

        [MethodImpl(Inline)]
        internal static Vector128<T> generic<T>(Vector128<float> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Vector128<float>,Vector128<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vector128<T> generic<T>(ref Vector128<float> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Vector128<float>,Vector128<T>>(ref src);


        [MethodImpl(Inline)]
        internal static Vector128<T> generic<T>(Vector128<double> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Vector128<double>,Vector128<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vector128<T> generic<T>(ref Vector128<double> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Vector128<double>,Vector128<T>>(ref src);

        #endregion

        #region Vector256

        //! Vector128
        //! -------------------------------------------------------------------

         [MethodImpl(Inline)]
        internal static Vector256<sbyte> int8<T>(Vector256<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vector256<T>,Vector256<sbyte>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Vector256<sbyte> int8<T>(ref Vector256<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vector256<T>,Vector256<sbyte>>(ref src);

        [MethodImpl(Inline)]
        internal static Vector256<byte> uint8<T>(Vector256<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vector256<T>,Vector256<byte>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Vector256<byte> uint8<T>(ref Vector256<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vector256<T>,Vector256<byte>>(ref src);

        [MethodImpl(Inline)]
        internal static Vector256<short> int16<T>(Vector256<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vector256<T>,Vector256<short>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Vector256<short> int16<T>(ref Vector256<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vector256<T>,Vector256<short>>(ref src);

        [MethodImpl(Inline)]
        internal static Vector256<ushort> uint16<T>(Vector256<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vector256<T>,Vector256<ushort>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Vector256<ushort> uint16<T>(ref Vector256<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vector256<T>,Vector256<ushort>>(ref src);

        [MethodImpl(Inline)]
        internal static Vector256<int> int32<T>(Vector256<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vector256<T>,Vector256<int>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Vector256<int> int32<T>(ref Vector256<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vector256<T>,Vector256<int>>(ref src);

        [MethodImpl(Inline)]
        internal static Vector256<uint> uint32<T>(Vector256<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vector256<T>,Vector256<uint>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Vector256<uint> uint32<T>(ref Vector256<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vector256<T>,Vector256<uint>>(ref src);


        [MethodImpl(Inline)]
        internal static Vector256<long> int64<T>(Vector256<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vector256<T>,Vector256<long>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Vector256<long> int64<T>(ref Vector256<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vector256<T>,Vector256<long>>(ref src);

        [MethodImpl(Inline)]
        internal static Vector256<ulong> uint64<T>(Vector256<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vector256<T>,Vector256<ulong>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Vector256<ulong> uint64<T>(ref Vector256<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vector256<T>,Vector256<ulong>>(ref src);

        [MethodImpl(Inline)]
        internal static Vector256<float> float32<T>(Vector256<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vector256<T>,Vector256<float>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Vector256<float> float32<T>(ref Vector256<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vector256<T>,Vector256<float>>(ref src);

        [MethodImpl(Inline)]
        internal static Vector256<double> float64<T>(Vector256<T> src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vector256<T>,Vector256<double>>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Vector256<double> float64<T>(ref Vector256<T> src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vector256<T>,Vector256<double>>(ref src);


        [MethodImpl(Inline)]
        internal static Vector256<T> generic<T>(Vector256<sbyte> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Vector256<sbyte>,Vector256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vector256<T> generic<T>(ref Vector256<sbyte> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Vector256<sbyte>,Vector256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static Vector256<T> generic<T>(Vector256<byte> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Vector256<byte>,Vector256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vector256<T> generic<T>(ref Vector256<byte> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Vector256<byte>,Vector256<T>>(ref src);


        [MethodImpl(Inline)]
        internal static Vector256<T> generic<T>(Vector256<short> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Vector256<short>,Vector256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vector256<T> generic<T>(ref Vector256<short> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Vector256<short>,Vector256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static Vector256<T> generic<T>(Vector256<ushort> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Vector256<ushort>,Vector256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vector256<T> generic<T>(ref Vector256<ushort> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Vector256<ushort>,Vector256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static Vector256<T> generic<T>(Vector256<int> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Vector256<int>,Vector256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vector256<T> generic<T>(ref Vector256<int> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Vector256<int>,Vector256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static Vector256<T> generic<T>(Vector256<uint> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Vector256<uint>,Vector256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vector256<T> generic<T>(ref Vector256<uint> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Vector256<uint>,Vector256<T>>(ref src);


        [MethodImpl(Inline)]
        internal static Vector256<T> generic<T>(Vector256<long> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Vector256<long>,Vector256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vector256<T> generic<T>(ref Vector256<long> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Vector256<long>,Vector256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static Vector256<T> generic<T>(Vector256<ulong> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Vector256<ulong>,Vector256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vector256<T> generic<T>(ref Vector256<ulong> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Vector256<ulong>,Vector256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static Vector256<T> generic<T>(Vector256<float> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Vector256<float>,Vector256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vector256<T> generic<T>(ref Vector256<float> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Vector256<float>,Vector256<T>>(ref src);


        [MethodImpl(Inline)]
        internal static Vector256<T> generic<T>(Vector256<double> src)
            where T : struct, IEquatable<T>        
            => Unsafe.As<Vector256<double>,Vector256<T>>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vector256<T> generic<T>(ref Vector256<double> src)
            where T : struct, IEquatable<T>        
            => ref Unsafe.As<Vector256<double>,Vector256<T>>(ref src);

        #endregion

        #region Vec128[]

        [MethodImpl(Inline)]
        internal static Vec128<sbyte>[] int8<T>(Vec128<T>[] src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vec128<T>[],Vec128<sbyte>[]>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vec128<sbyte>[] int8<T>(ref Vec128<T>[] src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vec128<T>[],Vec128<sbyte>[]>(ref src);

        [MethodImpl(Inline)]
        internal static Vec128<byte>[] uint8<T>(Vec128<T>[] src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vec128<T>[],Vec128<byte>[]>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vec128<byte>[] uint8<T>(ref Vec128<T>[] src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vec128<T>[],Vec128<byte>[]>(ref src);


        [MethodImpl(Inline)]
        internal static Vec128<short>[] int16<T>(Vec128<T>[] src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vec128<T>[],Vec128<short>[]>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vec128<short>[] int16<T>(ref Vec128<T>[] src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vec128<T>[],Vec128<short>[]>(ref src);

        [MethodImpl(Inline)]
        internal static Vec128<ushort>[] uint16<T>(Vec128<T>[] src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vec128<T>[],Vec128<ushort>[]>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vec128<ushort>[] uint16<T>(ref Vec128<T>[] src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vec128<T>[],Vec128<ushort>[]>(ref src);


        [MethodImpl(Inline)]
        internal static Vec128<int>[] int32<T>(Vec128<T>[] src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vec128<T>[],Vec128<int>[]>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vec128<int>[] int32<T>(ref Vec128<T>[] src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vec128<T>[],Vec128<int>[]>(ref src);

        [MethodImpl(Inline)]
        internal static Vec128<uint>[] uint32<T>(Vec128<T>[] src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vec128<T>[],Vec128<uint>[]>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vec128<uint>[] uint32<T>(ref Vec128<T>[] src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vec128<T>[],Vec128<uint>[]>(ref src);

        [MethodImpl(Inline)]
        internal static Vec128<long>[] int64<T>(Vec128<T>[] src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vec128<T>[],Vec128<long>[]>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vec128<long>[] int64<T>(ref Vec128<T>[] src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vec128<T>[],Vec128<long>[]>(ref src);

        [MethodImpl(Inline)]
        internal static Vec128<ulong>[] uint64<T>(Vec128<T>[] src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vec128<T>[],Vec128<ulong>[]>(ref src);

        [MethodImpl(Inline)]
        internal static ref Vec128<ulong>[] uint64<T>(ref Vec128<T>[] src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vec128<T>[],Vec128<ulong>[]>(ref src);

        [MethodImpl(Inline)]
        internal static Vec128<float>[] float32<T>(Vec128<T>[] src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vec128<T>[],Vec128<float>[]>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Vec128<float>[] float32<T>(ref Vec128<T>[] src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vec128<T>[],Vec128<float>[]>(ref src);

        [MethodImpl(Inline)]
        internal static Vec128<double>[] float64<T>(Vec128<T>[] src)
            where T : struct, IEquatable<T>        
                => Unsafe.As<Vec128<T>[],Vec128<double>[]>(ref src);

        [MethodImpl(Inline)]
        internal static ref  Vec128<double>[] float64<T>(ref Vec128<T>[] src)
            where T : struct, IEquatable<T>        
                => ref Unsafe.As<Vec128<T>[],Vec128<double>[]>(ref src);


        #endregion
    
    }
}