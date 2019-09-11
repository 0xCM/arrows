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
    
    using static zfunc;

    using static As;

    partial class ginx
    {
        [MethodImpl(Inline)]
        public static Vec128<T> add<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.add(in int8(in lhs), in int8(in rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(dinx.add(in uint8(in lhs), in uint8(in rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.add(in int16(in lhs), in int16(in rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.add(in uint16(in lhs), in uint16(in rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.add(in int32(in lhs), in int32(in rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.add(in uint32(in lhs), in uint32(in rhs)));
            else if(typeof(T) == typeof(long))
                return generic<T>(dinx.add(in int64(in lhs), in int64(in rhs)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.add(in uint64(in lhs), in uint64(in rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(dfp.add(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.add(in float64(in lhs), in float64(in rhs)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vec256<T> add<T>(in Vec256<T> lhs, in Vec256<T> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.add(in int8(in lhs), in int8(in rhs)));
            else if(typeof(T) == typeof(byte))
                return generic<T>(dinx.add(in uint8(in lhs), in uint8(in rhs)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.add(in int16(in lhs), in int16(in rhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.add(in uint16(in lhs), in uint16(in rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.add(in int32(in lhs), in int32(in rhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.add(in uint32(in lhs), in uint32(in rhs)));
            else if(typeof(T) == typeof(long))
                return generic<T>(dinx.add(in int64(in lhs), in int64(in rhs)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.add(in uint64(in lhs), in uint64(in rhs)));
            else if(typeof(T) == typeof(float))
                return generic<T>(dfp.add(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.add(in float64(in lhs), in float64(in rhs)));
            else 
                throw unsupported<T>();
        }    

        [MethodImpl(Inline)]
        public static Span128<T> add<T>(ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, Span128<T> dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                int8(lhs).AddSpans(int8(rhs), int8(dst));
            else if (typeof(T) == typeof(byte))
                uint8(lhs).AddSpans(uint8(rhs), uint8(dst));
            else if (typeof(T) == typeof(short))
                int16(lhs).AddSpans(int16(rhs), int16(dst));
            else if (typeof(T) == typeof(ushort))
                uint16(lhs).AddSpans(uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                int32(lhs).AddSpans(int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                uint32(lhs).AddSpans(uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                int64(lhs).AddSpans(int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                uint64(lhs).AddSpans(uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                float32(lhs).AddSpans(float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                float64(lhs).AddSpans(float64(rhs), float64(dst));
            else    
                throw unsupported<T>();
            return dst;        
        }

        [MethodImpl(Inline)]
        public static Span256<T> add<T>(ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, Span256<T> dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                int8(lhs).AddSpans(int8(rhs), int8(dst));
            else if (typeof(T) == typeof(byte))
                uint8(lhs).AddSpans(uint8(rhs), uint8(dst));                    
            else if (typeof(T) == typeof(short))
                int16(lhs).AddSpans(int16(rhs), int16(dst));
            else if (typeof(T) == typeof(ushort))
                uint16(lhs).AddSpans(uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                int32(lhs).AddSpans(int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                uint32(lhs).AddSpans(uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                int64(lhs).AddSpans(int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                uint64(lhs).AddSpans(uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                float32(lhs).AddSpans(float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                float64(lhs).AddSpans(float64(rhs), float64(dst));                
            else    
                throw unsupported<T>();
            return dst;        
        } 

        /// <summary>
        /// Add the first vector to the second and populates the third with the result
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        /// <param name="z">The target vector</param>
        /// <typeparam name="N">The vector length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref BlockVector<N,T> add<N,T>(in BlockVector<N,T> x, in BlockVector<N,T> y, ref BlockVector<N,T> z)
            where N : ITypeNat, new()
            where T : struct    
        {
            add(x, y, z.ToSpan256());
            return ref z;
        }

        static Span128<sbyte> AddSpans(this ReadOnlySpan128<sbyte> lhs, ReadOnlySpan128<sbyte> rhs, Span128<sbyte> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(add(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span128<byte> AddSpans(this ReadOnlySpan128<byte> lhs, ReadOnlySpan128<byte> rhs, Span128<byte> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(add(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span128<short> AddSpans(this ReadOnlySpan128<short> lhs, ReadOnlySpan128<short> rhs, Span128<short> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(add(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span128<ushort> AddSpans(this ReadOnlySpan128<ushort> lhs, ReadOnlySpan128<ushort> rhs, Span128<ushort> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(add(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span128<int> AddSpans(this ReadOnlySpan128<int> lhs, ReadOnlySpan128<int> rhs, Span128<int> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(add(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span128<uint> AddSpans(this ReadOnlySpan128<uint> lhs, ReadOnlySpan128<uint> rhs, Span128<uint> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(add(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span128<long> AddSpans(this ReadOnlySpan128<long> lhs, ReadOnlySpan128<long> rhs, Span128<long> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(add(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span128<ulong> AddSpans(this ReadOnlySpan128<ulong> lhs, ReadOnlySpan128<ulong> rhs, Span128<ulong> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(add(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span128<float> AddSpans(this ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs, Span128<float> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(add(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span128<double> AddSpans(this ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs, Span128<double> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(add(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span256<sbyte> AddSpans(this ReadOnlySpan256<sbyte> lhs, ReadOnlySpan256<sbyte> rhs, Span256<sbyte> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(add(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span256<byte> AddSpans(this ReadOnlySpan256<byte> lhs, ReadOnlySpan256<byte> rhs, Span256<byte> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(add(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span256<short> AddSpans(this ReadOnlySpan256<short> lhs, ReadOnlySpan256<short> rhs, Span256<short> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(add(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span256<ushort> AddSpans(this ReadOnlySpan256<ushort> lhs, ReadOnlySpan256<ushort> rhs, Span256<ushort> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(add(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst[block]);            
            return dst;            
        }

        static Span256<int> AddSpans(this ReadOnlySpan256<int> lhs, ReadOnlySpan256<int> rhs, Span256<int> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(add(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span256<uint> AddSpans(this ReadOnlySpan256<uint> lhs, ReadOnlySpan256<uint> rhs, Span256<uint> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(add(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span256<long> AddSpans(this ReadOnlySpan256<long> lhs, ReadOnlySpan256<long> rhs, Span256<long> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(add(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span256<ulong> AddSpans(this ReadOnlySpan256<ulong> lhs, ReadOnlySpan256<ulong> rhs, Span256<ulong> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(add(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span256<float> AddSpans(this ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs, Span256<float> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(add(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst.Block(block));            
            return dst;            
        }

        static Span256<double> AddSpans(this ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs, Span256<double> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                store(add(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst.Block(block));            
            return dst;            
        }
 

    }
}
