//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse;
    
    
    using static zfunc;
    using static As;
    using static AsInX;

    partial class ginx
    {
        [MethodImpl(Inline)]
        public static Vec128<T> sub<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.sub(in int8(in lhs), in int8(in rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(dinx.sub(in uint8(in lhs), in uint8(in rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.sub(in int16(in lhs), in int16(in rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.sub(in uint16(in lhs), in uint16(in rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.sub(in int32(in lhs), in int32(in rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.sub(in uint32(in lhs), in uint32(in rhs)));
            else if(typeof(T) == typeof(long))
                return generic<T>(dinx.sub(in int64(in lhs), in int64(in rhs)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.sub(in uint64(in lhs), in uint64(in rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(dinx.sub(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dinx.sub(in float64(in lhs), in float64(in rhs)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vec256<T> sub<T>(in Vec256<T> lhs, in Vec256<T> rhs)
            where T : struct
        {
             if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.sub(in int8(in lhs), in int8(in rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(dinx.sub(in uint8(in lhs), in uint8(in rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.sub(in int16(in lhs), in int16(in rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.sub(in uint16(in lhs), in uint16(in rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.sub(in int32(in lhs), in int32(in rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.sub(in uint32(in lhs), in uint32(in rhs)));
            else if(typeof(T) == typeof(long))
                return generic<T>(dinx.sub(in int64(in lhs), in int64(in rhs)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.sub(in uint64(in lhs), in uint64(in rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(dinx.sub(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dinx.sub(in float64(in lhs), in float64(in rhs)));
            else 
                throw unsupported<T>();
       }

        [MethodImpl(Inline)]
        public static unsafe void sub<T>(in Vec128<T> lhs, in Vec128<T> rhs, ref T dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                dinx.sub(int8(lhs), int8(rhs), ref int8(ref dst));
            else if (typeof(T) == typeof(byte))
                dinx.sub(uint8(lhs), uint8(rhs), ref uint8(ref dst));                    
            else if (typeof(T) == typeof(short))
                dinx.sub(int16(lhs), int16(rhs), ref int16(ref dst));
            else if (typeof(T) == typeof(ushort))
                dinx.sub(uint16(lhs), uint16(rhs), ref uint16(ref dst));
            else if(typeof(T) == typeof(int))
                dinx.sub(int32(lhs), int32(rhs), ref int32(ref dst));
            else if(typeof(T) == typeof(uint))
                dinx.sub(uint32(lhs), uint32(rhs), ref uint32(ref dst));
            else if(typeof(T) == typeof(long))
                dinx.sub(int64(lhs), int64(rhs), ref int64(ref dst));
            else if(typeof(T) == typeof(ulong))
                dinx.sub(uint64(lhs), uint64(rhs), ref uint64(ref dst));
            else if(typeof(T) == typeof(float))
                dinx.sub(float32(lhs), float32(rhs), ref float32(ref dst));
            else if(typeof(T) == typeof(double))
                dinx.sub(float64(lhs), float64(rhs), ref float64(ref dst));                
            else    
                throw unsupported<T>();
        }
            
        [MethodImpl(Inline)]
        public static unsafe void sub<T>(in Vec256<T> lhs, in Vec256<T> rhs, ref T dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                dinx.sub(int8(lhs), int8(rhs), ref int8(ref dst));
            else if (typeof(T) == typeof(byte))
                dinx.sub(uint8(lhs), uint8(rhs), ref uint8(ref dst));                    
            else if (typeof(T) == typeof(short))
                dinx.sub(int16(lhs), int16(rhs), ref int16(ref dst));
            else if (typeof(T) == typeof(ushort))
                dinx.sub(uint16(lhs), uint16(rhs), ref uint16(ref dst));
            else if(typeof(T) == typeof(int))
                dinx.sub(int32(lhs), int32(rhs), ref int32(ref dst));
            else if(typeof(T) == typeof(uint))
                dinx.sub(uint32(lhs), uint32(rhs), ref uint32(ref dst));
            else if(typeof(T) == typeof(long))
                dinx.sub(int64(lhs), int64(rhs), ref int64(ref dst));
            else if(typeof(T) == typeof(ulong))
                dinx.sub(uint64(lhs), uint64(rhs), ref uint64(ref dst));
            else if(typeof(T) == typeof(float))
                dinx.sub(float32(lhs), float32(rhs), ref float32(ref dst));
            else if(typeof(T) == typeof(double))
                dinx.sub(float64(lhs), float64(rhs), ref float64(ref dst));                
            else    
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Num128<T> sub<T>(in Num128<T> lhs, in Num128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(float))
                return dinx.sub(in float32(in lhs), in float32(in rhs)).As<T>();
            else if(typeof(T) == typeof(double))
                return dinx.sub(in float64(in lhs), in float64(in rhs)).As<T>();
                throw unsupported<T>();
        }

        public static Span128<T> sub<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, Span128<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                int8(lhs).SubSpans(int8(rhs), int8(dst));
            else if(typeof(T) == typeof(byte))
                uint8(lhs).SubSpans(uint8(rhs), uint8(dst));
            else if(typeof(T) == typeof(short))
                int16(lhs).SubSpans(int16(rhs), int16(dst));
            else if(typeof(T) == typeof(ushort))
                uint16(lhs).SubSpans(uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                int32(lhs).SubSpans(int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                uint32(lhs).SubSpans(uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                int64(lhs).SubSpans(int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                uint64(lhs).SubSpans(uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                float32(lhs).SubSpans(float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                float64(lhs).SubSpans(float64(rhs), float64(dst));
            else 
                throw unsupported<T>();
            return dst;
        }

        public static Span256<T> sub<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, Span256<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                int8(lhs).SubSpans(int8(rhs), int8(dst));
            else if(typeof(T) == typeof(byte))
                uint8(lhs).SubSpans(uint8(rhs), uint8(dst));
            else if(typeof(T) == typeof(short))
                int16(lhs).SubSpans(int16(rhs), int16(dst));
            else if(typeof(T) == typeof(ushort))
                uint16(lhs).SubSpans(uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                int32(lhs).SubSpans(int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                uint32(lhs).SubSpans(uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                int64(lhs).SubSpans(int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                uint64(lhs).SubSpans(uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                float32(lhs).SubSpans(float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                float64(lhs).SubSpans(float64(rhs), float64(dst));
            else 
                throw unsupported<T>();
            return dst;
        }


        static Span128<sbyte> SubSpans(this ReadOnlySpan128<sbyte> lhs, ReadOnlySpan128<sbyte> rhs, Span128<sbyte> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span128<byte> SubSpans(this ReadOnlySpan128<byte> lhs, ReadOnlySpan128<byte> rhs, Span128<byte> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span128<short> SubSpans(this ReadOnlySpan128<short> lhs, ReadOnlySpan128<short> rhs, Span128<short> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span128<ushort> SubSpans(this ReadOnlySpan128<ushort> lhs, ReadOnlySpan128<ushort> rhs, Span128<ushort> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span128<int> SubSpans(this ReadOnlySpan128<int> lhs, ReadOnlySpan128<int> rhs, Span128<int> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span128<uint> SubSpans(this ReadOnlySpan128<uint> lhs, ReadOnlySpan128<uint> rhs, Span128<uint> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span128<long> SubSpans(this ReadOnlySpan128<long> lhs, ReadOnlySpan128<long> rhs, Span128<long> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span128<ulong> SubSpans(this ReadOnlySpan128<ulong> lhs, ReadOnlySpan128<ulong> rhs, Span128<ulong> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span128<float> SubSpans(this ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs, Span128<float> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span128<double> SubSpans(this ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs, Span128<double> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span256<sbyte> SubSpans(this ReadOnlySpan256<sbyte> lhs, ReadOnlySpan256<sbyte> rhs, Span256<sbyte> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span256<byte> SubSpans(this ReadOnlySpan256<byte> lhs, ReadOnlySpan256<byte> rhs, Span256<byte> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span256<short> SubSpans(this ReadOnlySpan256<short> lhs, ReadOnlySpan256<short> rhs, Span256<short> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span256<ushort> SubSpans(this ReadOnlySpan256<ushort> lhs, ReadOnlySpan256<ushort> rhs, Span256<ushort> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst[block]);            
            return dst;            
        }

        static Span256<int> SubSpans(this ReadOnlySpan256<int> lhs, ReadOnlySpan256<int> rhs, Span256<int> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span256<uint> SubSpans(this ReadOnlySpan256<uint> lhs, ReadOnlySpan256<uint> rhs, Span256<uint> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span256<long> SubSpans(this ReadOnlySpan256<long> lhs, ReadOnlySpan256<long> rhs, Span256<long> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span256<ulong> SubSpans(this ReadOnlySpan256<ulong> lhs, ReadOnlySpan256<ulong> rhs, Span256<ulong> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span256<float> SubSpans(this ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs, Span256<float> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span256<double> SubSpans(this ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs, Span256<double> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst.Block(block));            
            return dst;            
        }
 


    }
}