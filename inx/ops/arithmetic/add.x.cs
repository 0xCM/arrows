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

    using static As;
    using static AsInX;
    using static dinx;
    using static zfunc;

    public static partial class dinxx
    {
        /// <summary>
        /// Computes the sum of the operands
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> Add<T>(this Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct
                => ginx.add(in lhs,in rhs);

        /// <summary>
        /// Computes the sum of the operands
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> Add<T>(this Vec256<T> lhs, in Vec256<T> rhs)
            where T : struct
                => ginx.add(in lhs,in rhs);

        [MethodImpl(Inline)]
        public static Span128<T> Add<T>(this ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, Span128<T> dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                int8(lhs).Add(int8(rhs), int8(dst));
            else if (typeof(T) == typeof(byte))
                uint8(lhs).Add(uint8(rhs), uint8(dst));
            else if (typeof(T) == typeof(short))
                int16(lhs).Add(int16(rhs), int16(dst));
            else if (typeof(T) == typeof(ushort))
                uint16(lhs).Add(uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                int32(lhs).Add(int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                uint32(lhs).Add(uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                int64(lhs).Add(int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                uint64(lhs).Add(uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                float32(lhs).Add(float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                float64(lhs).Add(float64(rhs), float64(dst));
            else    
                throw unsupported<T>();
            return dst;        
        }

        [MethodImpl(Inline)]
        public static Span256<T> Add<T>(this ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, Span256<T> dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                int8(lhs).Add(int8(rhs), int8(dst));
            else if (typeof(T) == typeof(byte))
                uint8(lhs).Add(uint8(rhs), uint8(dst));                    
            else if (typeof(T) == typeof(short))
                int16(lhs).Add(int16(rhs), int16(dst));
            else if (typeof(T) == typeof(ushort))
                uint16(lhs).Add(uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                int32(lhs).Add(int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                uint32(lhs).Add(uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                int64(lhs).Add(int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                uint64(lhs).Add(uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                float32(lhs).Add(float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                float64(lhs).And(float64(rhs), float64(dst));                
            else    
                throw unsupported<T>();
            return dst;        
        } 

        static Span128<sbyte> Add(this ReadOnlySpan128<sbyte> lhs, ReadOnlySpan128<sbyte> rhs, Span128<sbyte> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Sse2.Add(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span128<byte> Add(this ReadOnlySpan128<byte> lhs, ReadOnlySpan128<byte> rhs, Span128<byte> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Sse2.Add(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span128<short> Add(this ReadOnlySpan128<short> lhs, ReadOnlySpan128<short> rhs, Span128<short> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Sse2.Add(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span128<ushort> Add(this ReadOnlySpan128<ushort> lhs, ReadOnlySpan128<ushort> rhs, Span128<ushort> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Sse2.Add(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span128<int> Add(this ReadOnlySpan128<int> lhs, ReadOnlySpan128<int> rhs, Span128<int> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Sse2.Add(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span128<uint> Add(this ReadOnlySpan128<uint> lhs, ReadOnlySpan128<uint> rhs, Span128<uint> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Sse2.Add(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span128<long> Add(this ReadOnlySpan128<long> lhs, ReadOnlySpan128<long> rhs, Span128<long> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Sse2.Add(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span128<ulong> Add(this ReadOnlySpan128<ulong> lhs, ReadOnlySpan128<ulong> rhs, Span128<ulong> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Sse2.Add(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span128<float> Add(this ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs, Span128<float> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Sse.Add(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span128<double> Add(this ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs, Span128<double> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Sse2.Add(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span256<sbyte> Add(this ReadOnlySpan256<sbyte> lhs, ReadOnlySpan256<sbyte> rhs, Span256<sbyte> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Avx2.Add(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span256<byte> Add(this ReadOnlySpan256<byte> lhs, ReadOnlySpan256<byte> rhs, Span256<byte> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Avx2.Add(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span256<short> Add(this ReadOnlySpan256<short> lhs, ReadOnlySpan256<short> rhs, Span256<short> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Avx2.Add(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span256<ushort> Add(this ReadOnlySpan256<ushort> lhs, ReadOnlySpan256<ushort> rhs, Span256<ushort> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Avx2.Add(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst[block]);            
            return dst;            
        }

        static Span256<int> Add(this ReadOnlySpan256<int> lhs, ReadOnlySpan256<int> rhs, Span256<int> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Avx2.Add(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span256<uint> Add(this ReadOnlySpan256<uint> lhs, ReadOnlySpan256<uint> rhs, Span256<uint> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Avx2.Add(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span256<long> Add(this ReadOnlySpan256<long> lhs, ReadOnlySpan256<long> rhs, Span256<long> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Avx2.Add(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span256<ulong> Add(this ReadOnlySpan256<ulong> lhs, ReadOnlySpan256<ulong> rhs, Span256<ulong> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Avx2.Add(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span256<float> Add(this ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs, Span256<float> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Avx.Add(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span256<double> Add(this ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs, Span256<double> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(Avx.Add(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst.Block(block));            
            return dst;            
        }
 

 
    }
}