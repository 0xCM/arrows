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
    
    public static class AsIn
    {
        [MethodImpl(Inline)]
        static ref T asRef<T>(in T src)
            => ref Unsafe.AsRef(in src);
    
        [MethodImpl(Inline)]
        public static ref sbyte int8<T>(in T src)
            => ref Unsafe.As<T,sbyte>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref byte uint8<T>(in T src)
            => ref Unsafe.As<T,byte>(ref asRef(in src));            

        [MethodImpl(Inline)]
        public static ref short int16<T>(in T src)
            => ref Unsafe.As<T,short>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref ushort uint16<T>(in T src)
            => ref Unsafe.As<T,ushort>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref int int32<T>(in T src)
            => ref Unsafe.As<T,int>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref uint uint32<T>(in T src)
            => ref Unsafe.As<T,uint>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref long int64<T>(in T src)
            => ref Unsafe.As<T,long>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref ulong uint64<T>(in T src)
            => ref Unsafe.As<T,ulong>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref float float32<T>(in T src)
            => ref Unsafe.As<T,float>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref double float64<T>(in T src)
            => ref Unsafe.As<T,double>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref decimal float128<T>(in T src)
            => ref Unsafe.As<T,decimal>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref T generic<T>(in sbyte src)
            => ref Unsafe.As<sbyte,T>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref T generic<T>(in byte src)
            => ref Unsafe.As<byte,T>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref T generic<T>(in short src)
            => ref Unsafe.As<short,T>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref T generic<T>(in ushort src)
            => ref Unsafe.As<ushort,T>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref T generic<T>(in int src)
            => ref Unsafe.As<int,T>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref T generic<T>(in uint src)
            => ref Unsafe.As<uint,T>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref T generic<T>(in long src)
            => ref Unsafe.As<long,T>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref T generic<T>(in ulong src)
            => ref Unsafe.As<ulong,T>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref T generic<T>(in float src)
            => ref Unsafe.As<float,T>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref T generic<T>(in double src)
            => ref Unsafe.As<double,T>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref T generic<T>(in decimal src)
            => ref Unsafe.As<decimal,T>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static ref T generic<S,T>(in S src)
            => ref Unsafe.As<S,T>(ref asRef(in src));

        [MethodImpl(Inline)]
        public static unsafe void* pvoid<T>(in T src)
            => Unsafe.AsPointer(ref asRef(in src));

    }

    partial class As
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
        public static ref uint uint32<T>(ref T src)
            => ref Unsafe.As<T,uint>(ref src);

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
        public static decimal float128<T>(T src)
            => Unsafe.As<T,decimal>(ref src);

        [MethodImpl(Inline)]
        public static ref sbyte int8<T>(ref T src)
            => ref Unsafe.As<T,sbyte>(ref src);

        [MethodImpl(Inline)]
        public static ref byte uint8<T>(ref T src)
            => ref Unsafe.As<T,byte>(ref src);

        [MethodImpl(Inline)]
        public static ref short int16<T>(ref T src)
            => ref Unsafe.As<T,short>(ref src);

        [MethodImpl(Inline)]
        public static ref ushort uint16<T>(ref T src)
            => ref Unsafe.As<T,ushort>(ref src);

        [MethodImpl(Inline)]
        public static ref int int32<T>(ref T src)
            => ref Unsafe.As<T,int>(ref src);

        [MethodImpl(Inline)]
        public static ref long int64<T>(ref T src)
            => ref Unsafe.As<T,long>(ref src);

        [MethodImpl(Inline)]
        public static ref ulong uint64<T>(ref T src)
            => ref Unsafe.As<T,ulong>(ref src);

        [MethodImpl(Inline)]
        public static ref float float32<T>(ref T src)
            => ref Unsafe.As<T,float>(ref src);

        [MethodImpl(Inline)]
        public static ref double float64<T>(ref T src)
            => ref Unsafe.As<T,double>(ref src);

        [MethodImpl(Inline)]
        public static ref decimal float128<T>(ref T src)
            => ref Unsafe.As<T,decimal>(ref src);


        [MethodImpl(Inline)]
        public static sbyte? int8<T>(T? src)
            where T : struct
                => Unsafe.As<T?, sbyte?>(ref src);

        [MethodImpl(Inline)]
        public static byte? uint8<T>(T? src)
            where T : struct
                => Unsafe.As<T?, byte?>(ref src);

        [MethodImpl(Inline)]
        public static short? int16<T>(T? src)
            where T : struct
                => Unsafe.As<T?, short?>(ref src);


        [MethodImpl(Inline)]
        public static ushort? uint16<T>(T? src)
            where T : struct
                => Unsafe.As<T?, ushort?>(ref src);

        [MethodImpl(Inline)]
        public static int? int32<T>(T? src)
            where T : struct
                => Unsafe.As<T?, int?>(ref src);

        [MethodImpl(Inline)]
        public static uint? uint32<T>(T? src)
            where T : struct
                => Unsafe.As<T?, uint?>(ref src);

        [MethodImpl(Inline)]
        public static long? int64<T>(T? src)
            where T : struct
                => Unsafe.As<T?, long?>(ref src);

        [MethodImpl(Inline)]
        public static ulong? uint64<T>(T? src)
            where T : struct
                => Unsafe.As<T?, ulong?>(ref src);

        [MethodImpl(Inline)]
        public static float? float32<T>(T? src)
            where T : struct
                => Unsafe.As<T?, float?>(ref src);

        [MethodImpl(Inline)]
        public static double? float64<T>(T? src)
            where T : struct
                => Unsafe.As<T?, double?>(ref src);


        [MethodImpl(Inline)]
        public static ref sbyte int8<T>(T src, out sbyte dst)
        {
            dst = Unsafe.As<T,sbyte>(ref src);
            return ref dst;
        }            

        [MethodImpl(Inline)]
        public static ref byte uint8<T>(T src, out byte dst)
        {
            dst = Unsafe.As<T,byte>(ref src);
            return ref dst;
        }            

        [MethodImpl(Inline)]
        public static ref short int16<T>(T src, out short dst)
        {
            dst = Unsafe.As<T,short>(ref src);
            return ref dst;
        }            

        [MethodImpl(Inline)]
        public static ref ushort uint16<T>(T src, out ushort dst)
        {
            dst = Unsafe.As<T,ushort>(ref src);
            return ref dst;
        }            

        [MethodImpl(Inline)]
        public static ref int int32<T>(T src, out int dst)
        {
            dst = Unsafe.As<T,int>(ref src);
            return ref dst;
        }            

        [MethodImpl(Inline)]
        public static ref uint uint32<T>(T src, out uint dst)
        {
            dst = Unsafe.As<T,uint>(ref src);
            return ref dst;
        }            
        
        [MethodImpl(Inline)]
        public static ref long int64<T>(T src, out long dst)
        {
            dst = Unsafe.As<T,long>(ref src);
            return ref dst;
        }            

        [MethodImpl(Inline)]
        public static ref ulong uint64<T>(T src, out ulong dst)
        {
            dst = Unsafe.As<T,ulong>(ref src);
            return ref dst;
        }            

        [MethodImpl(Inline)]
        public static ref float float32<T>(T src, out float dst)
        {
            dst = Unsafe.As<T,float>(ref src);
            return ref dst;
        }            

        [MethodImpl(Inline)]
        public static ref double float64<T>(T src, out double dst)
        {
            dst = Unsafe.As<T,double>(ref src);
            return ref dst;
        }            

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

        [MethodImpl(Inline)]
        public static ref T generic<T>(sbyte src, out T dst)
        {
            dst = Unsafe.As<sbyte,T>(ref src);
            return ref dst;
        }
            
        [MethodImpl(Inline)]
        public static ref T generic<T>(byte src, out T dst)
        {
            dst = Unsafe.As<byte,T>(ref src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref T generic<T>(short src, out T dst)
        {
            dst = Unsafe.As<short,T>(ref src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref T generic<T>(ushort src, out T dst)
        {
            dst = Unsafe.As<ushort,T>(ref src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref T generic<T>(int src, out T dst)
        {
            dst = Unsafe.As<int,T>(ref src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref T generic<T>(uint src, out T dst)
        {
            dst = Unsafe.As<uint,T>(ref src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref T generic<T>(long src, out T dst)
        {
            dst = Unsafe.As<long,T>(ref src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref T generic<T>(ulong src, out T dst)
        {
            dst = Unsafe.As<ulong,T>(ref src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref T generic<T>(float src, out T dst)
        {
            dst = Unsafe.As<float,T>(ref src);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref T generic<T>(double src, out T dst)
        {
            dst = Unsafe.As<double,T>(ref src);
            return ref dst;
        }

    }

}