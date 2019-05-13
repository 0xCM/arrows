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
    
    using static mfunc;
    using static zfunc;

    public static class As
    {
        #region generic => primal

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
        public static decimal float128<T>(T src)
            => Unsafe.As<T,decimal>(ref src);

        [MethodImpl(Inline)]
        public static ref decimal float128<T>(ref T src)
            => ref Unsafe.As<T,decimal>(ref src);

        #endregion

        #region primal => generic

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

        [MethodImpl(Inline)]
        public static T generic<T>(decimal src)
            => Unsafe.As<decimal,T>(ref src);

        [MethodImpl(Inline)]
        public static ref T generic<T>(ref decimal src)
            => ref Unsafe.As<decimal,T>(ref src);

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

        #region mem[T] => mem[Primal]

        [MethodImpl(Inline)]
        public static ref ReadOnlyMemory<sbyte> uint8<T>(ref ReadOnlyMemory<T> src)
            where T : struct
                => ref Unsafe.As<ReadOnlyMemory<T>,ReadOnlyMemory<sbyte>>(ref src);

        [MethodImpl(Inline)]
        public static ref ReadOnlyMemory<byte> int8<T>(ref ReadOnlyMemory<T> src)
            where T : struct
                => ref Unsafe.As<ReadOnlyMemory<T>,ReadOnlyMemory<byte>>(ref src);

        [MethodImpl(Inline)]
        public static ref ReadOnlyMemory<short> int16<T>(ref ReadOnlyMemory<T> src)
            where T : struct
                => ref Unsafe.As<ReadOnlyMemory<T>,ReadOnlyMemory<short>>(ref src);

        [MethodImpl(Inline)]
        public static ref ReadOnlyMemory<ushort> uint16<T>(ref ReadOnlyMemory<T> src)
            where T : struct
                => ref Unsafe.As<ReadOnlyMemory<T>,ReadOnlyMemory<ushort>>(ref src);

        [MethodImpl(Inline)]
        public static ref ReadOnlyMemory<int> int32<T>(ref ReadOnlyMemory<T> src)
            where T : struct
                => ref Unsafe.As<ReadOnlyMemory<T>,ReadOnlyMemory<int>>(ref src);

        [MethodImpl(Inline)]
        public static ref ReadOnlyMemory<uint> uint32<T>(ref ReadOnlyMemory<T> src)
            where T : struct
                => ref Unsafe.As<ReadOnlyMemory<T>,ReadOnlyMemory<uint>>(ref src);

        [MethodImpl(Inline)]
        public static ref ReadOnlyMemory<long> int64<T>(ref ReadOnlyMemory<T> src)
            where T : struct
                => ref Unsafe.As<ReadOnlyMemory<T>,ReadOnlyMemory<long>>(ref src);

        [MethodImpl(Inline)]
        public static ref ReadOnlyMemory<ulong> uint64<T>(ref ReadOnlyMemory<T> src)
            where T : struct
                => ref Unsafe.As<ReadOnlyMemory<T>,ReadOnlyMemory<ulong>>(ref src);

        [MethodImpl(Inline)]
        public static ref ReadOnlyMemory<float> float32<T>(ref ReadOnlyMemory<T> src)
            where T : struct
                => ref Unsafe.As<ReadOnlyMemory<T>,ReadOnlyMemory<float>>(ref src);

        [MethodImpl(Inline)]
        public static ref ReadOnlyMemory<double> float64<T>(ref ReadOnlyMemory<T> src)
            where T : struct
                => ref Unsafe.As<ReadOnlyMemory<T>,ReadOnlyMemory<double>>(ref src);

        #endregion

        #region Arrays

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

        #region span

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

        #endregion

        #region readonly span

        [MethodImpl(Inline)]
        public static ReadOnlySpan<sbyte> int8<T>(ReadOnlySpan<T> src)
            where T : struct
                => cast<T,sbyte>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<byte> uint8<T>(ReadOnlySpan<T> src)
            where T : struct
                => cast<T,byte>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<short> int16<T>(ReadOnlySpan<T> src)
            where T : struct
                => cast<T,short>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<ushort> uint16<T>(ReadOnlySpan<T> src)
            where T : struct
                => cast<T,ushort>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<int> int32<T>(ReadOnlySpan<T> src)
            where T : struct
                => cast<T,int>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<uint> uint32<T>(ReadOnlySpan<T> src)
            where T : struct
                => cast<T,uint>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<long> int64<T>(ReadOnlySpan<T> src)
            where T : struct
                => cast<T,long>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<ulong> uint64<T>(ReadOnlySpan<T> src)
            where T : struct
                => cast<T,ulong>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<float> float32<T>(ReadOnlySpan<T> src)
            where T : struct
                => cast<T,float>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<double> float64<T>(ReadOnlySpan<T> src)
            where T : struct
                => cast<T,double>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(ReadOnlySpan<sbyte> src)
            where T : struct
                => cast<sbyte,T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(ReadOnlySpan<byte> src)
            where T : struct
                => cast<byte,T>(src);


        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(ReadOnlySpan<short> src)
            where T : struct
                => cast<short,T>(src);


        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(ReadOnlySpan<ushort> src)
            where T : struct
                => cast<ushort,T>(src);


        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(ReadOnlySpan<int> src)
            where T : struct
                => cast<int,T>(src);


        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(ReadOnlySpan<uint> src)
            where T : struct
                => cast<uint,T>(src);


        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(ReadOnlySpan<long> src)
            where T : struct
                => cast<long,T>(src);


        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(ReadOnlySpan<ulong> src)
            where T : struct
                => cast<ulong,T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(ReadOnlySpan<float> src)
            where T : struct
                => cast<float,T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> generic<T>(ReadOnlySpan<double> src)
            where T : struct
                => cast<double,T>(src);

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
    
        #region pointers

        [MethodImpl(Inline)]
        public static unsafe void* pvoid<T>(ref T src)
            => Unsafe.AsPointer(ref src);

        [MethodImpl(Inline)]
        public static unsafe sbyte* pint8<T>(ref T src)
            => (sbyte*)pvoid(ref src);
        
        [MethodImpl(Inline)]
        public static unsafe byte* puint8<T>(ref T src)
            => (byte*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe short* pint16<T>(ref T src)
            => (short*)pvoid(ref src);
        
        [MethodImpl(Inline)]
        public static unsafe ushort* puint16<T>(ref T src)
            => (ushort*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe int* pint32<T>(ref T src)
            => (int*)pvoid(ref src);
        
        [MethodImpl(Inline)]
        public static unsafe uint* puint32<T>(ref T src)
            => (uint*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe long* pint64<T>(ref T src)
            => (long*)pvoid(ref src);
        
        [MethodImpl(Inline)]
        public static unsafe ulong* puint64<T>(ref T src)
            => (ulong*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe float* pfloat32<T>(ref T src)
            => (float*)pvoid(ref src);
        
        [MethodImpl(Inline)]
        public static unsafe double* pfloat64<T>(ref T src)
            => (double*)pvoid(ref src);

        [MethodImpl(Inline)]
        public static unsafe sbyte* int8(void* src)
            => (sbyte*)src;

        [MethodImpl(Inline)]
        public static unsafe byte* uint8(void* src)
            => (byte*)src;

        [MethodImpl(Inline)]
        public static unsafe short* int16(void* src)
            => (short*)src;

        [MethodImpl(Inline)]
        public static unsafe ushort* uint16(void* src)
            => (ushort*)src;

        [MethodImpl(Inline)]
        public static unsafe int* int32(void* src)
            => (int*)src;

        [MethodImpl(Inline)]
        public static unsafe uint* uint32(void* src)
            => (uint*)src;

        [MethodImpl(Inline)]
        public static unsafe long* int64(void* src)
            => (long*)src;

        [MethodImpl(Inline)]
        public static unsafe ulong* uint64(void* src)
            => (ulong*)src;

        [MethodImpl(Inline)]
        public static unsafe float* float32(void* src)
            => (float*)src;

        [MethodImpl(Inline)]
        public static unsafe double* float64(void* src)
            => (double*)src;

        #endregion    

        #region span128

        [MethodImpl(Inline)]
        public static Span128<sbyte> int8<T>(Span128<T> src)
            where T : struct, IEquatable<T>
                => cast<T,sbyte>(src);

        [MethodImpl(Inline)]
        public static Span128<byte> uint8<T>(Span128<T> src)
            where T : struct, IEquatable<T>
                => cast<T,byte>(src);

        [MethodImpl(Inline)]
        public static Span128<short> int16<T>(Span128<T> src)
            where T : struct, IEquatable<T>
                => cast<T,short>(src);

        [MethodImpl(Inline)]
        public static Span128<ushort> uint16<T>(Span128<T> src)
            where T : struct, IEquatable<T>
                => cast<T,ushort>(src);

        [MethodImpl(Inline)]
        public static Span128<int> int32<T>(Span128<T> src)
            where T : struct, IEquatable<T>
                => cast<T,int>(src);

        [MethodImpl(Inline)]
        public static Span128<uint> uint32<T>(Span128<T> src)
            where T : struct, IEquatable<T>
                => cast<T,uint>(src);

        [MethodImpl(Inline)]
        public static Span128<long> int64<T>(Span128<T> src)
            where T : struct, IEquatable<T>
                => cast<T,long>(src);

        [MethodImpl(Inline)]
        public static Span128<ulong> uint64<T>(Span128<T> src)
            where T : struct, IEquatable<T>
                => cast<T,ulong>(src);

        [MethodImpl(Inline)]
        public static Span128<float> float32<T>(Span128<T> src)
            where T : struct, IEquatable<T>
                => cast<T,float>(src);

        [MethodImpl(Inline)]
        public static Span128<double> float64<T>(Span128<T> src)
            where T : struct, IEquatable<T>
                => cast<T,double>(src);

        [MethodImpl(Inline)]
        public static Span128<T> generic<T>(Span128<sbyte> src)
            where T : struct, IEquatable<T>
                => cast<sbyte,T>(src);

        [MethodImpl(Inline)]
        public static Span128<T> generic<T>(Span128<byte> src)
            where T : struct, IEquatable<T>
                => cast<byte,T>(src);


        [MethodImpl(Inline)]
        public static Span128<T> generic<T>(Span128<short> src)
            where T : struct, IEquatable<T>
                => cast<short,T>(src);


        [MethodImpl(Inline)]
        public static Span128<T> generic<T>(Span128<ushort> src)
            where T : struct, IEquatable<T>
                => cast<ushort,T>(src);


        [MethodImpl(Inline)]
        public static Span128<T> generic<T>(Span128<int> src)
            where T : struct, IEquatable<T>
                => cast<int,T>(src);


        [MethodImpl(Inline)]
        public static Span128<T> generic<T>(Span128<uint> src)
            where T : struct, IEquatable<T>
                => cast<uint,T>(src);


        [MethodImpl(Inline)]
        public static Span128<T> generic<T>(Span128<long> src)
            where T : struct, IEquatable<T>
                => cast<long,T>(src);


        [MethodImpl(Inline)]
        public static Span128<T> generic<T>(Span128<ulong> src)
            where T : struct, IEquatable<T>
                => cast<ulong,T>(src);

        [MethodImpl(Inline)]
        public static Span128<T> generic<T>(Span128<float> src)
            where T : struct, IEquatable<T>
                => cast<float,T>(src);

        [MethodImpl(Inline)]
        public static Span128<T> generic<T>(Span128<double> src)
            where T : struct, IEquatable<T>
                => cast<double,T>(src);

        #endregion

        #region readonly span128

        [MethodImpl(Inline)]
        public static ReadOnlySpan128<sbyte> int8<T>(ReadOnlySpan128<T> src)
            where T : struct, IEquatable<T>
                => cast<T,sbyte>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan128<byte> uint8<T>(ReadOnlySpan128<T> src)
            where T : struct, IEquatable<T>
                => cast<T,byte>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan128<short> int16<T>(ReadOnlySpan128<T> src)
            where T : struct, IEquatable<T>
                => cast<T,short>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan128<ushort> uint16<T>(ReadOnlySpan128<T> src)
            where T : struct, IEquatable<T>
                => cast<T,ushort>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan128<int> int32<T>(ReadOnlySpan128<T> src)
            where T : struct, IEquatable<T>
                => cast<T,int>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan128<uint> uint32<T>(ReadOnlySpan128<T> src)
            where T : struct, IEquatable<T>
                => cast<T,uint>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan128<long> int64<T>(ReadOnlySpan128<T> src)
            where T : struct, IEquatable<T>
                => cast<T,long>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan128<ulong> uint64<T>(ReadOnlySpan128<T> src)
            where T : struct, IEquatable<T>
                => cast<T,ulong>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan128<float> float32<T>(ReadOnlySpan128<T> src)
            where T : struct, IEquatable<T>
                => cast<T,float>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan128<double> float64<T>(ReadOnlySpan128<T> src)
            where T : struct, IEquatable<T>
                => cast<T,double>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan128<T> generic<T>(ReadOnlySpan128<sbyte> src)
            where T : struct, IEquatable<T>
                => cast<sbyte,T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan128<T> generic<T>(ReadOnlySpan128<byte> src)
            where T : struct, IEquatable<T>
                => cast<byte,T>(src);


        [MethodImpl(Inline)]
        public static ReadOnlySpan128<T> generic<T>(ReadOnlySpan128<short> src)
            where T : struct, IEquatable<T>
                => cast<short,T>(src);


        [MethodImpl(Inline)]
        public static ReadOnlySpan128<T> generic<T>(ReadOnlySpan128<ushort> src)
            where T : struct, IEquatable<T>
                => cast<ushort,T>(src);


        [MethodImpl(Inline)]
        public static ReadOnlySpan128<T> generic<T>(ReadOnlySpan128<int> src)
            where T : struct, IEquatable<T>
                => cast<int,T>(src);


        [MethodImpl(Inline)]
        public static ReadOnlySpan128<T> generic<T>(ReadOnlySpan128<uint> src)
            where T : struct, IEquatable<T>
                => cast<uint,T>(src);


        [MethodImpl(Inline)]
        public static ReadOnlySpan128<T> generic<T>(ReadOnlySpan128<long> src)
            where T : struct, IEquatable<T>
                => cast<long,T>(src);


        [MethodImpl(Inline)]
        public static ReadOnlySpan128<T> generic<T>(ReadOnlySpan128<ulong> src)
            where T : struct, IEquatable<T>
                => cast<ulong,T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan128<T> generic<T>(ReadOnlySpan128<float> src)
            where T : struct, IEquatable<T>
                => cast<float,T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan128<T> generic<T>(ReadOnlySpan128<double> src)
            where T : struct, IEquatable<T>
                => cast<double,T>(src);

        #endregion

        #region span256

        [MethodImpl(Inline)]
        public static Span256<sbyte> int8<T>(Span256<T> src)
            where T : struct, IEquatable<T>
                => cast<T,sbyte>(src);

        [MethodImpl(Inline)]
        public static Span256<byte> uint8<T>(Span256<T> src)
            where T : struct, IEquatable<T>
                => cast<T,byte>(src);

        [MethodImpl(Inline)]
        public static Span256<short> int16<T>(Span256<T> src)
            where T : struct, IEquatable<T>
                => cast<T,short>(src);

        [MethodImpl(Inline)]
        public static Span256<ushort> uint16<T>(Span256<T> src)
            where T : struct, IEquatable<T>
                => cast<T,ushort>(src);

        [MethodImpl(Inline)]
        public static Span256<int> int32<T>(Span256<T> src)
            where T : struct, IEquatable<T>
                => cast<T,int>(src);

        [MethodImpl(Inline)]
        public static Span256<uint> uint32<T>(Span256<T> src)
            where T : struct, IEquatable<T>
                => cast<T,uint>(src);

        [MethodImpl(Inline)]
        public static Span256<long> int64<T>(Span256<T> src)
            where T : struct, IEquatable<T>
                => cast<T,long>(src);

        [MethodImpl(Inline)]
        public static Span256<ulong> uint64<T>(Span256<T> src)
            where T : struct, IEquatable<T>
                => cast<T,ulong>(src);

        [MethodImpl(Inline)]
        public static Span256<float> float32<T>(Span256<T> src)
            where T : struct, IEquatable<T>
                => cast<T,float>(src);

        [MethodImpl(Inline)]
        public static Span256<double> float64<T>(Span256<T> src)
            where T : struct, IEquatable<T>
                => cast<T,double>(src);

        [MethodImpl(Inline)]
        public static Span256<T> generic<T>(Span256<sbyte> src)
            where T : struct, IEquatable<T>
                => cast<sbyte,T>(src);

        [MethodImpl(Inline)]
        public static Span256<T> generic<T>(Span256<byte> src)
            where T : struct, IEquatable<T>
                => cast<byte,T>(src);


        [MethodImpl(Inline)]
        public static Span256<T> generic<T>(Span256<short> src)
            where T : struct, IEquatable<T>
                => cast<short,T>(src);


        [MethodImpl(Inline)]
        public static Span256<T> generic<T>(Span256<ushort> src)
            where T : struct, IEquatable<T>
                => cast<ushort,T>(src);


        [MethodImpl(Inline)]
        public static Span256<T> generic<T>(Span256<int> src)
            where T : struct, IEquatable<T>
                => cast<int,T>(src);


        [MethodImpl(Inline)]
        public static Span256<T> generic<T>(Span256<uint> src)
            where T : struct, IEquatable<T>
                => cast<uint,T>(src);


        [MethodImpl(Inline)]
        public static Span256<T> generic<T>(Span256<long> src)
            where T : struct, IEquatable<T>
                => cast<long,T>(src);


        [MethodImpl(Inline)]
        public static Span256<T> generic<T>(Span256<ulong> src)
            where T : struct, IEquatable<T>
                => cast<ulong,T>(src);

        [MethodImpl(Inline)]
        public static Span256<T> generic<T>(Span256<float> src)
            where T : struct, IEquatable<T>
                => cast<float,T>(src);

        [MethodImpl(Inline)]
        public static Span256<T> generic<T>(Span256<double> src)
            where T : struct, IEquatable<T>
                => cast<double,T>(src);

        #endregion

        #region readonly span256

        [MethodImpl(Inline)]
        public static ReadOnlySpan256<sbyte> int8<T>(ReadOnlySpan256<T> src)
            where T : struct, IEquatable<T>
                => cast<T,sbyte>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan256<byte> uint8<T>(ReadOnlySpan256<T> src)
            where T : struct, IEquatable<T>
                => cast<T,byte>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan256<short> int16<T>(ReadOnlySpan256<T> src)
            where T : struct, IEquatable<T>
                => cast<T,short>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan256<ushort> uint16<T>(ReadOnlySpan256<T> src)
            where T : struct, IEquatable<T>
                => cast<T,ushort>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan256<int> int32<T>(ReadOnlySpan256<T> src)
            where T : struct, IEquatable<T>
                => cast<T,int>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan256<uint> uint32<T>(ReadOnlySpan256<T> src)
            where T : struct, IEquatable<T>
                => cast<T,uint>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan256<long> int64<T>(ReadOnlySpan256<T> src)
            where T : struct, IEquatable<T>
                => cast<T,long>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan256<ulong> uint64<T>(ReadOnlySpan256<T> src)
            where T : struct, IEquatable<T>
                => cast<T,ulong>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan256<float> float32<T>(ReadOnlySpan256<T> src)
            where T : struct, IEquatable<T>
                => cast<T,float>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan256<double> float64<T>(ReadOnlySpan256<T> src)
            where T : struct, IEquatable<T>
                => cast<T,double>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan256<T> generic<T>(ReadOnlySpan256<sbyte> src)
            where T : struct, IEquatable<T>
                => cast<sbyte,T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan256<T> generic<T>(ReadOnlySpan256<byte> src)
            where T : struct, IEquatable<T>
                => cast<byte,T>(src);


        [MethodImpl(Inline)]
        public static ReadOnlySpan256<T> generic<T>(ReadOnlySpan256<short> src)
            where T : struct, IEquatable<T>
                => cast<short,T>(src);


        [MethodImpl(Inline)]
        public static ReadOnlySpan256<T> generic<T>(ReadOnlySpan256<ushort> src)
            where T : struct, IEquatable<T>
                => cast<ushort,T>(src);


        [MethodImpl(Inline)]
        public static ReadOnlySpan256<T> generic<T>(ReadOnlySpan256<int> src)
            where T : struct, IEquatable<T>
                => cast<int,T>(src);


        [MethodImpl(Inline)]
        public static ReadOnlySpan256<T> generic<T>(ReadOnlySpan256<uint> src)
            where T : struct, IEquatable<T>
                => cast<uint,T>(src);


        [MethodImpl(Inline)]
        public static ReadOnlySpan256<T> generic<T>(ReadOnlySpan256<long> src)
            where T : struct, IEquatable<T>
                => cast<long,T>(src);


        [MethodImpl(Inline)]
        public static ReadOnlySpan256<T> generic<T>(ReadOnlySpan256<ulong> src)
            where T : struct, IEquatable<T>
                => cast<ulong,T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan256<T> generic<T>(ReadOnlySpan256<float> src)
            where T : struct, IEquatable<T>
                => cast<float,T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan256<T> generic<T>(ReadOnlySpan256<double> src)
            where T : struct, IEquatable<T>
                => cast<double,T>(src);

        #endregion


    }
}