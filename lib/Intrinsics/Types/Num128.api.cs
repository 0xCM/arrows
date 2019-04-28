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
        public static unsafe Num128<int> load(int* src)
            => Avx2.LoadScalarVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Num128<uint> load(uint* src)
            => Avx2.LoadScalarVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Num128<long> load(long* src)
            => Avx2.LoadScalarVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Num128<ulong> load(ulong* src)
            => Avx2.LoadScalarVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Num128<float> load(float* src)
            => Avx2.LoadScalarVector128(src);

        [MethodImpl(Inline)]
        public static unsafe Num128<double> load(double* src)
            => Avx2.LoadScalarVector128(src);
     
        [MethodImpl(Inline)]
        public static Vec128<byte> broadcast(Num128<byte> src)
            => Avx2.BroadcastScalarToVector128(src);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> broadcast(Num128<sbyte> src)
            => Avx2.BroadcastScalarToVector128(src);

        [MethodImpl(Inline)]
        public static Vec128<short> broadcast(Num128<short> src)
            => Avx2.BroadcastScalarToVector128(src);

        [MethodImpl(Inline)]
        public static Vec128<ushort> broadcast(Num128<ushort> src)
            => Avx2.BroadcastScalarToVector128(src);

        [MethodImpl(Inline)]
        public static Vec128<int> broadcast(Num128<int> src)
            => Avx2.BroadcastScalarToVector128(src);

        [MethodImpl(Inline)]
        public static Vec128<uint> broadcast(Num128<uint> src)
            => Avx2.BroadcastScalarToVector128(src);

        [MethodImpl(Inline)]
        public static Vec128<long> broadcast(Num128<long> src)
            => Avx2.BroadcastScalarToVector128(src);

        [MethodImpl(Inline)]
        public static Vec128<ulong> broadcast(Num128<ulong> src)
            => Avx2.BroadcastScalarToVector128(src);

        [MethodImpl(Inline)]
        public static Vec128<float> broadcast(Num128<float> src)
            => Avx2.BroadcastScalarToVector128(src);

        [MethodImpl(Inline)]
        public static Vec128<double> broadcast(Num128<double> src)
            => Avx2.BroadcastScalarToVector128(src);

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
   }
}