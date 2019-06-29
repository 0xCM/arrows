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
        public static bool eq<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return dinx.eq(in float32(in lhs), in float32(in rhs));
            else if(typeof(T) == typeof(double))
                return dinx.eq(in float64(in lhs), in float64(in rhs));
            throw 
                unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool neq<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return dinx.neq(in float32(in lhs), in float32(in rhs));
            else if(typeof(T) == typeof(double))
                return dinx.neq(in float64(in lhs), in float64(in rhs));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool gt<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return dinx.gt(in float32(in lhs), in float32(in rhs));
            else if(typeof(T) == typeof(double))
                return dinx.gt(in float64(in lhs), in float64(in rhs));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool gteq<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return dinx.gteq(in float32(in lhs), in float32(in rhs));
            else if(typeof(T) == typeof(double))
                return dinx.gteq(in float64(in lhs), in float64(in rhs));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool lt<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return dinx.lt(in float32(in lhs), in float32(in rhs));
            else if(typeof(T) == typeof(double))
                return dinx.lt(in float64(in lhs), in float64(in rhs));
            throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        public static bool cmpf<T>(in Num128<T> lhs, in Num128<T> rhs, FloatComparisonMode mode)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return dinx.cmpf(in float32(in lhs), in float32(in rhs), mode);            
            else if(typeof(T) == typeof(double))
                return dinx.cmpf(in float64(in lhs), in float64(in rhs), mode);
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool ngt<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return dinx.ngt(in float32(in lhs), in float32(in rhs));            
            else if(typeof(T) == typeof(double))
                return dinx.ngt(in float32(in lhs), in float32(in rhs));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool nlt<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return dinx.nlt(in float32(in lhs), in float32(in rhs));            
            else if(typeof(T) == typeof(double))
                return dinx.nlt(in float32(in lhs), in float32(in rhs));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool lteq<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return dinx.lteq(in float32(in lhs), in float32(in rhs));            
            else if(typeof(T) == typeof(double))
                return dinx.lteq(in float32(in lhs), in float32(in rhs));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Num128<T> mul<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return dinx.mul(in float32(in lhs), in float32(in rhs)).As<T>();            
            else if(typeof(T) == typeof(double))
                return dinx.mul(in float32(in lhs), in float32(in rhs)).As<T>();
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Num128<T> div<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return dinx.div(in float32(in lhs), in float32(in rhs)).As<T>();            
            else if(typeof(T) == typeof(double))
                return dinx.div(in float32(in lhs), in float32(in rhs)).As<T>();
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Num128<T> max<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return dinx.max(in float32(in lhs), in float32(in rhs)).As<T>();            
            else if(typeof(T) == typeof(double))
                return dinx.max(in float32(in lhs), in float32(in rhs)).As<T>();
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Num128<T> min<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return dinx.min(in float32(in lhs), in float32(in rhs)).As<T>();            
            else if(typeof(T) == typeof(double))
                return dinx.min(in float32(in lhs), in float32(in rhs)).As<T>();
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Num128<T> muladd<T>(ref Num128<T> x, in Num128<T> y, in Num128<T> z)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return dinx.mulAdd(in float64(in x), in float64(in y), in float64(in z)).As<T>();                
            else if(typeof(T) == typeof(double))
                return dinx.mulAdd(in float64(in x), in float64(in y), in float64(in z)).As<T>();
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Num128<T> recip<T>(in Num128<T> src)
            where T : struct
                => throw unsupported<T>();

        [MethodImpl(Inline)]
        public static Num128<T> sqrt<T>(in Num128<T> src)
            where T : struct
                => throw unsupported<T>();

        [MethodImpl(Inline)]
        public static Num128<T> recipsqrt<T>(in Num128<T> src)
            where T : struct
                => throw unsupported<T>();

        [MethodImpl(Inline)]
        public static Num128<T> ceiling<T>(in Num128<T> src)
            where T : struct
                => throw unsupported<T>();

        [MethodImpl(Inline)]
        public static Num128<T> floor<T>(in Num128<T> src)
            where T : struct
                => throw unsupported<T>();


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