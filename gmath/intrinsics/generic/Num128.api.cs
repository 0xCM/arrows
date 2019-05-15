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

    
    using static global::mfunc;
    
    public static class Num128
    {

        [MethodImpl(Inline)]
        public static void mul(float[] lhs, float[] rhs, float[] dst)
        {
            var len = length(lhs,rhs);
            
            for(var i = 0; i < len; i++)
            {
                var x = Num128.define(lhs[i]);
                var y = Num128.define(rhs[i]);
                dst[i] = dinx.mul(x,y);                
            }
        }

        [MethodImpl(Inline)]
        public static void mul(double[] lhs, double[] rhs, double[] dst)
        {
            var len = length(lhs,rhs);
            
            for(var i = 0; i < len; i++)
            {
                var x = Num128.define(lhs[i]);
                var y = Num128.define(rhs[i]);
                dst[i] = dinx.mul(x,y);                
            }
        }

        [MethodImpl(Inline)]
        public static void mul<T>(T[] lhs, T[] rhs, T[] dst)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();
            var len = length(lhs,rhs);

            for(var i= 0; i < len; i++)
            {
                var x = Num128.define(lhs[i]);
                var y = Num128.define(rhs[i]);
                dst[i] = ginx.mul(x,y);                
            }

        }

        
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
            where T : struct
        {
            var dst = stackalloc byte[16];            
            dst[0] = src;
            return Unsafe.AsRef<Num128<T>>(dst);
        }

        [MethodImpl(Inline)]
        static unsafe Num128<T> scalar<T>(sbyte src)
            where T : struct
        {
            var dst = stackalloc sbyte[16];            
            dst[0] = src;
            return Unsafe.AsRef<Num128<T>>(dst);
        }

        [MethodImpl(Inline)]
        static unsafe Num128<T> scalar<T>(short src)
            where T : struct
        {
            var dst = stackalloc short[8];            
            dst[0] = src;
            return Unsafe.AsRef<Num128<T>>(dst);
        }

        [MethodImpl(Inline)]
        static unsafe Num128<T> scalar<T>(ushort src)
            where T : struct
        {
            var dst = stackalloc ushort[8];            
            dst[0] = src;
            return Unsafe.AsRef<Num128<T>>(dst);
        }

        [MethodImpl(Inline)]
        static unsafe Num128<T> scalar<T>(int src)
            where T : struct
        {
            var dst = stackalloc int[4];            
            dst[0] = src;
            return Unsafe.AsRef<Num128<T>>(dst);
        }

        [MethodImpl(Inline)]
        static unsafe Num128<T> scalar<T>(uint src)
            where T : struct
        {
            var dst = stackalloc uint[4];            
            dst[0] = src;
            return Unsafe.AsRef<Num128<T>>(dst);
        }

        [MethodImpl(Inline)]
        static unsafe Num128<T> scalar<T>(long src)
            where T : struct
        {
            var dst = stackalloc long[2];            
            dst[0] = src;
            return Unsafe.AsRef<Num128<T>>(dst);
        }

        [MethodImpl(Inline)]
        static unsafe Num128<T> scalar<T>(ulong src)
            where T : struct
        {
            var dst = stackalloc ulong[2];            
            dst[0] = src;
            return Unsafe.AsRef<Num128<T>>(dst);
        }

        [MethodImpl(Inline)]
        static unsafe Num128<T> scalar<T>(float src)
            where T : struct
        {
            var dst = stackalloc float[4];            
            dst[0] = src;
            return Unsafe.AsRef<Num128<T>>(dst);
        }

        [MethodImpl(Inline)]
        static unsafe Num128<T> scalar<T>(double src)
            where T : struct
        {
            var dst = stackalloc double[2];            
            dst[0] = src;
            return Unsafe.AsRef<Num128<T>>(dst);
        }


        public static Num128<T> define<T>(T value)
            where T : struct        
        {
            var kind = PrimalKinds.kind<T>();
            
            if (kind == PrimalKind.int8)
                return  scalar<T>(As.int8(value));

            if(kind == PrimalKind.uint8)
                return  scalar<T>(As.uint8(value));

            if(kind == PrimalKind.int16)
                return  scalar<T>(As.int16(value));

            if(kind == PrimalKind.uint16)
                return  scalar<T>(As.uint16(value));

            if(kind == PrimalKind.int32)
                return  scalar<T>(As.int32(value));

            if(kind == PrimalKind.uint32)
                return  scalar<T>(As.uint32(value));

            if(kind == PrimalKind.int64)
                return  scalar<T>(As.int64(value));

            if(kind == PrimalKind.uint64)
                return  scalar<T>(As.uint64(value));

            if(kind == PrimalKind.float32)
                return  scalar<T>(As.float32(value));

            if(kind == PrimalKind.float64)
                return  scalar<T>(As.float64(value));

            throw new NotSupportedException($"Kind {kind} not supported");
        }
   }
}