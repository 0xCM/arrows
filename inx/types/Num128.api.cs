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
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse41;

 
    using static zfunc;
    using static As;
    using static AsInX;
    
    public static class Num128
    {
        [MethodImpl(Inline)]
        public static Num128<T> define<T>(T value)
            where T : struct        
        {
            if(typeof(T) == typeof(sbyte))
                return  scalar<T>(int8(value));
            else if(typeof(T) == typeof(byte))
                return  scalar<T>(uint8(value));
            else if(typeof(T) == typeof(short))
                return  scalar<T>(int16(value));
            else if(typeof(T) == typeof(ushort))
                return  scalar<T>(uint16(value));
            else if(typeof(T) == typeof(int))
                return  scalar<T>(int32(value));
            else if(typeof(T) == typeof(uint))
                return  scalar<T>(uint32(value));
            else if(typeof(T) == typeof(long))
                return  scalar<T>(int64(value));
            else if(typeof(T) == typeof(ulong))
                return  scalar<T>(uint64(value));
            else if(typeof(T) == typeof(float))
                return  scalar<T>(float32(value));
            else if(typeof(T) == typeof(double))
                return  scalar<T>(float64(value));
            else
                throw unsupported(PrimalKinds.kind<T>());

        }

        [MethodImpl(Inline)]
        public static unsafe ref Num128<float> load(float src, out Num128<float> dst)
        {
             dst = LoadScalarVector128(pfloat32(ref src));
             return ref dst;
        }

        [MethodImpl(Inline)]
        public static unsafe ref Num128<double> load(double src, out Num128<double> dst)
        {
             dst = LoadScalarVector128(pfloat64(ref src));
             return ref dst;
        }
        
        [MethodImpl(Inline)]
        public static unsafe Num128<int> load(ref int src)
            => Avx2.LoadScalarVector128(pint32(ref src));

        [MethodImpl(Inline)]
        public static unsafe Num128<uint> load(ref uint src)
            => Avx2.LoadScalarVector128(puint32(ref src));

        [MethodImpl(Inline)]
        public static unsafe Num128<long> load(ref long src)
            => Avx2.LoadScalarVector128(pint64(ref src));

        [MethodImpl(Inline)]
        public static unsafe Num128<ulong> load(ref ulong src)
            => Avx2.LoadScalarVector128(puint64(ref src));

        [MethodImpl(Inline)]
        public static unsafe Num128<float> load(ref float src)
            => Avx2.LoadScalarVector128(pfloat32(ref src));

        [MethodImpl(Inline)]
        public static unsafe Num128<double> load(ref double src)
            => Avx2.LoadScalarVector128(pfloat64(ref src));
                 


        [MethodImpl(Inline)]
        public static Num128<T> load<T>(in ReadOnlySpan128<T> src, int block = 0)
            where T : struct  
                => define<T>(src[block* Span128<T>.BlockLength]);

        [MethodImpl(Inline)]
        public static Num128<T> load<T>(in Span128<T> src, int block = 0)
            where T : struct  
                => define<T>(src[block* Span128<T>.BlockLength]);
 
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
   }
}