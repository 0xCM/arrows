//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zcore;
    using static inxfunc;

    public static class Num128
    {
        [MethodImpl(Inline)]
        static unsafe Num128<T> scalar<T>(byte src)
            where T : struct, IEquatable<T>
        {
            var dst = stackalloc byte[16];            
            dst[0] = src;
            return Unsafe.AsRef<Num128<T>>(dst);
        }


        [MethodImpl(Inline)]
        static unsafe Num128<T> scalar<T>(sbyte src)
            where T : struct, IEquatable<T>
        {
            var dst = stackalloc sbyte[16];            
            dst[0] = src;
            return Unsafe.AsRef<Num128<T>>(dst);
        }

        [MethodImpl(Inline)]
        static unsafe Num128<T> scalar<T>(short src)
            where T : struct, IEquatable<T>
        {
            var dst = stackalloc short[8];            
            dst[0] = src;
            return Unsafe.AsRef<Num128<T>>(dst);
        }

        [MethodImpl(Inline)]
        static unsafe Num128<T> scalar<T>(ushort src)
            where T : struct, IEquatable<T>
        {
            var dst = stackalloc ushort[8];            
            dst[0] = src;
            return Unsafe.AsRef<Num128<T>>(dst);
        }


        [MethodImpl(Inline)]
        static unsafe Num128<T> scalar<T>(int src)
            where T : struct, IEquatable<T>
        {
            var dst = stackalloc int[4];            
            dst[0] = src;
            return Unsafe.AsRef<Num128<T>>(dst);
        }

        [MethodImpl(Inline)]
        static unsafe Num128<T> scalar<T>(uint src)
            where T : struct, IEquatable<T>
        {
            var dst = stackalloc uint[4];            
            dst[0] = src;
            return Unsafe.AsRef<Num128<T>>(dst);
        }

        [MethodImpl(Inline)]
        static unsafe Num128<T> scalar<T>(long src)
            where T : struct, IEquatable<T>
        {
            var dst = stackalloc long[2];            
            dst[0] = src;
            return Unsafe.AsRef<Num128<T>>(dst);
        }

        [MethodImpl(Inline)]
        static unsafe Num128<T> scalar<T>(ulong src)
            where T : struct, IEquatable<T>
        {
            var dst = stackalloc ulong[2];            
            dst[0] = src;
            return Unsafe.AsRef<Num128<T>>(dst);
        }

        [MethodImpl(Inline)]
        static unsafe Num128<T> scalar<T>(float src)
            where T : struct, IEquatable<T>
        {
            var dst = stackalloc float[4];            
            dst[0] = src;
            return Unsafe.AsRef<Num128<T>>(dst);
        }

        [MethodImpl(Inline)]
        static unsafe Num128<T> scalar<T>(double src)
            where T : struct, IEquatable<T>
        {
            var dst = stackalloc double[2];            
            dst[0] = src;
            return Unsafe.AsRef<Num128<T>>(dst);
        }

        static readonly PrimalIndex Factories = PrimalIndex.define(
            @sbyte : new Num128Factory<sbyte>(scalar<sbyte>), 
            @byte : new Num128Factory<byte>(scalar<byte>), 
            @short : new Num128Factory<short>(scalar<short>), 
            @ushort : new Num128Factory<ushort>(scalar<ushort>), 
            @int : new Num128Factory<int>(scalar<int>), 
            @uint : new Num128Factory<uint>(scalar<uint>), 
            @long : new Num128Factory<long>(scalar<long>), 
            @ulong : new Num128Factory<ulong>(scalar<ulong>), 
            @float : new Num128Factory<float>(scalar<float>), 
            @double : new Num128Factory<double>(scalar<double>) 

        );

        [MethodImpl(Inline)]
        public static unsafe Num128<T> define<T>(T value)
            where T : struct, IEquatable<T>
                => Factories.lookup<T,Num128Factory<T>>()(value);
        // {
        //     return typecode<T>() switch 
        //     {
        //         TypeCode.SByte => scalar<T>(convert<T,sbyte>(value)),
        //         TypeCode.Byte => scalar<T>(convert<T,byte>(value)),
        //         TypeCode.Int16 => scalar<T>(convert<T,short>(value)),
        //         TypeCode.UInt16 => scalar<T>(convert<T,ushort>(value)),
        //         TypeCode.Int32 => scalar<T>(convert<T,int>(value)),
        //         TypeCode.UInt32 => scalar<T>(convert<T,uint>(value)),
        //         TypeCode.Int64 => scalar<T>(convert<T,long>(value)),
        //         TypeCode.UInt64 => scalar<T>(convert<T,ulong>(value)),
        //         TypeCode.Single => scalar<T>(convert<T,float>(value)),
        //         TypeCode.Double => scalar<T>(convert<T,double>(value)),
        //         _ => throw new NotSupportedException()
        //     };        

        //  }

   }
}