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
        
    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Avx;

    using static zfunc;
    using static Span256;
    using static Span128;
    using static As;
    using static dinx;

    partial class dinxx
    {

        public static Span128<T> Sub<T>(this ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, Span128<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                int8(lhs).Sub(int8(rhs), int8(dst));
            else if(typeof(T) == typeof(byte))
                uint8(lhs).Sub(uint8(rhs), uint8(dst));
            else if(typeof(T) == typeof(short))
                int16(lhs).Sub(int16(rhs), int16(dst));
            else if(typeof(T) == typeof(ushort))
                uint16(lhs).Sub(uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                int32(lhs).Sub(int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                uint32(lhs).Sub(uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                int64(lhs).Sub(int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                uint64(lhs).Sub(uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                float32(lhs).Sub(float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                float64(lhs).Sub(float64(rhs), float64(dst));
            else 
                throw unsupported<T>();
            return dst;
        }

        public static Span256<T> Sub<T>(this ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, Span256<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                int8(lhs).Sub(int8(rhs), int8(dst));
            else if(typeof(T) == typeof(byte))
                uint8(lhs).Sub(uint8(rhs), uint8(dst));
            else if(typeof(T) == typeof(short))
                int16(lhs).Sub(int16(rhs), int16(dst));
            else if(typeof(T) == typeof(ushort))
                uint16(lhs).Sub(uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                int32(lhs).Sub(int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                uint32(lhs).Sub(uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                int64(lhs).Sub(int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                uint64(lhs).Sub(uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                float32(lhs).Sub(float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                float64(lhs).Sub(float64(rhs), float64(dst));
            else 
                throw unsupported<T>();
            return dst;
        }


        static Span128<sbyte> Sub(this ReadOnlySpan128<sbyte> lhs, ReadOnlySpan128<sbyte> rhs, Span128<sbyte> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst[block]);            
            return dst;            
        }

        static Span128<byte> Sub(this ReadOnlySpan128<byte> lhs, ReadOnlySpan128<byte> rhs, Span128<byte> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst[block]);            
            return dst;            
        }

        static Span128<short> Sub(this ReadOnlySpan128<short> lhs, ReadOnlySpan128<short> rhs, Span128<short> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst[block]);            
            return dst;            
        }

        static Span128<ushort> Sub(this ReadOnlySpan128<ushort> lhs, ReadOnlySpan128<ushort> rhs, Span128<ushort> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst[block]);            
            return dst;            
        }

        static Span128<int> Sub(this ReadOnlySpan128<int> lhs, ReadOnlySpan128<int> rhs, Span128<int> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst[block]);            
            return dst;            
        }

        static Span128<uint> Sub(this ReadOnlySpan128<uint> lhs, ReadOnlySpan128<uint> rhs, Span128<uint> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst[block]);            
            return dst;            
        }

        static Span128<long> Sub(this ReadOnlySpan128<long> lhs, ReadOnlySpan128<long> rhs, Span128<long> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst[block]);            
            return dst;            
        }

        static Span128<ulong> Sub(this ReadOnlySpan128<ulong> lhs, ReadOnlySpan128<ulong> rhs, Span128<ulong> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst[block]);            
            return dst;            
        }

        static Span128<float> Sub(this ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs, Span128<float> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst[block]);            
            return dst;            
        }

        static Span128<double> Sub(this ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs, Span128<double> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst[block]);            
            return dst;            
        }

        static Span256<sbyte> Sub(this ReadOnlySpan256<sbyte> lhs, ReadOnlySpan256<sbyte> rhs, Span256<sbyte> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst[block]);            
            return dst;            
        }

        static Span256<byte> Sub(this ReadOnlySpan256<byte> lhs, ReadOnlySpan256<byte> rhs, Span256<byte> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst[block]);            
            return dst;            
        }

        static Span256<short> Sub(this ReadOnlySpan256<short> lhs, ReadOnlySpan256<short> rhs, Span256<short> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst[block]);            
            return dst;            
        }

        static Span256<ushort> Sub(this ReadOnlySpan256<ushort> lhs, ReadOnlySpan256<ushort> rhs, Span256<ushort> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst[block]);            
            return dst;            
        }

        static Span256<int> Sub(this ReadOnlySpan256<int> lhs, ReadOnlySpan256<int> rhs, Span256<int> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst[block]);            
            return dst;            
        }

        static Span256<uint> Sub(this ReadOnlySpan256<uint> lhs, ReadOnlySpan256<uint> rhs, Span256<uint> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst[block]);            
            return dst;            
        }

        static Span256<long> Sub(this ReadOnlySpan256<long> lhs, ReadOnlySpan256<long> rhs, Span256<long> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst[block]);            
            return dst;            
        }

        static Span256<ulong> Sub(this ReadOnlySpan256<ulong> lhs, ReadOnlySpan256<ulong> rhs, Span256<ulong> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst[block]);            
            return dst;            
        }

        static Span256<float> Sub(this ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs, Span256<float> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst[block]);            
            return dst;            
        }

        static Span256<double> Sub(this ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs, Span256<double> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Subtract(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst[block]);            
            return dst;            
        }
    }
}