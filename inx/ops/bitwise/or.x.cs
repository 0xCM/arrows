//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static zfunc;    
    using static dinx;
    using static As;
    using static AsInX;
    
    partial class dinxx
    {
        /// <summary>
        /// Computes the bitwise or of the operands
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        public static Vec128<T> Or<T>(in this Vec128<T> lhs, in Vec128<T> rhs)
            where T : struct
                => ginx.or(in lhs,in rhs);

        /// <summary>
        /// Computes the bitwise or of the operands
        /// </summary>
        /// <param name="lhs">The left source vector</param>
        /// <param name="rhs">The right source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        public static Vec256<T> Or<T>(in this Vec256<T> lhs, in Vec256<T> rhs)
            where T : struct
                => ginx.or(in lhs,in rhs);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> Or(this in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => dinx.or(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec128<byte> Or(this in Vec128<byte> lhs, in Vec128<byte> rhs)
            => dinx.or(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> Or(this in Vec128<short> lhs, in Vec128<short> rhs)
            => dinx.or(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> Or(this in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => dinx.or(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> Or(this in Vec128<int> lhs, in Vec128<int> rhs)
            => dinx.or(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec128<uint> Or(this in Vec128<uint> lhs, in Vec128<uint> rhs)
            => dinx.or(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec128<long> Or(this in Vec128<long> lhs, in Vec128<long> rhs)
            => dinx.or(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec128<ulong> Or(this in Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => dinx.or(in lhs, in rhs);


        [MethodImpl(Inline)]
        public static Vec256<sbyte> Or(this in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => dinx.or(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec256<byte> Or(this in Vec256<byte> lhs, in Vec256<byte> rhs)
            => dinx.or(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> Or(this in Vec256<short> lhs, in Vec256<short> rhs)
            => dinx.or(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec256<ushort> Or(this in Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => dinx.or(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec256<int> Or(this in Vec256<int> lhs, in Vec256<int> rhs)
            => dinx.or(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec256<uint> Or(this in Vec256<uint> lhs, in Vec256<uint> rhs)
            => dinx.or(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec256<long> Or(this in Vec256<long> lhs, in Vec256<long> rhs)
            => dinx.or(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec256<ulong> Or(this in Vec256<ulong> lhs, in Vec256<ulong> rhs)
            => dinx.or(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static void Or(this in Vec256<sbyte> lhs, in Vec256<sbyte> rhs, ref sbyte dst)
            => dinx.or(in lhs, in rhs, ref dst);

        [MethodImpl(Inline)]
        public static void Or(this in Vec256<byte> lhs, in Vec256<byte> rhs, ref byte dst)
            => dinx.or(in lhs, in rhs, ref dst);

        [MethodImpl(Inline)]
        public static void Or(this in Vec256<short> lhs, in Vec256<short> rhs, ref short dst)
            => dinx.or(in lhs, in rhs, ref dst);

        [MethodImpl(Inline)]
        public static void Or(this in Vec256<ushort> lhs, in Vec256<ushort> rhs, ref ushort dst)
            => dinx.or(in lhs, in rhs, ref dst);

        [MethodImpl(Inline)]
        public static void Or(this in Vec256<int> lhs, in Vec256<int> rhs, ref int dst)
            => dinx.or(in lhs, in rhs, ref dst);

        [MethodImpl(Inline)]
        public static void Or(this in Vec256<uint> lhs, in Vec256<uint> rhs, ref uint dst)
            => dinx.or(in lhs, in rhs, ref dst);

        [MethodImpl(Inline)]
        public static void Or(this in Vec256<long> lhs, in Vec256<long> rhs, ref long dst)
            => dinx.or(in lhs, in rhs, ref dst);

        [MethodImpl(Inline)]
        public static void Or(this in Vec256<ulong> lhs, in Vec256<ulong> rhs, ref ulong dst)
            => dinx.or(in lhs, in rhs, ref dst);

        public static Span128<T> Or<T>(this ReadOnlySpan128<T> lhs, ReadOnlySpan128<T> rhs, Span128<T> dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                int8(lhs).Or(int8(rhs), int8(dst));
            else if (typeof(T) == typeof(byte))
                uint8(lhs).Or(uint8(rhs), uint8(dst));                    
            else if (typeof(T) == typeof(short))
                int16(lhs).Or(int16(rhs), int16(dst));
            else if (typeof(T) == typeof(ushort))
                uint16(lhs).Or(uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                int32(lhs).Or(int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                uint32(lhs).Or(uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                int64(lhs).Or(int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                uint64(lhs).Or(uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                float32(lhs).Or(float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                float64(lhs).Or(float64(rhs), float64(dst));
            else    
                throw unsupported<T>();
            return dst;   
        }


        public static Span256<T> Or<T>(this ReadOnlySpan256<T> lhs, ReadOnlySpan256<T> rhs, Span256<T> dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                int8(lhs).Or(int8(rhs), int8(dst));
            else if (typeof(T) == typeof(byte))
                uint8(lhs).Or(uint8(rhs), uint8(dst));                    
            else if (typeof(T) == typeof(short))
                int16(lhs).Or(int16(rhs), int16(dst));
            else if (typeof(T) == typeof(ushort))
                uint16(lhs).Or(uint16(rhs), uint16(dst));
            else if(typeof(T) == typeof(int))
                int32(lhs).Or(int32(rhs), int32(dst));
            else if(typeof(T) == typeof(uint))
                uint32(lhs).Or(uint32(rhs), uint32(dst));
            else if(typeof(T) == typeof(long))
                int64(lhs).Or(int64(rhs), int64(dst));
            else if(typeof(T) == typeof(ulong))
                uint64(lhs).Or(uint64(rhs), uint64(dst));
            else if(typeof(T) == typeof(float))
                float32(lhs).Or(float32(rhs), float32(dst));
            else if(typeof(T) == typeof(double))
                float64(lhs).Or(float64(rhs), float64(dst));
            else    
                throw unsupported<T>();
            return dst;   
        }


        static Span128<sbyte> Or(this ReadOnlySpan128<sbyte> lhs, ReadOnlySpan128<sbyte> rhs, in Span128<sbyte> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                or(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        static Span128<byte> Or(this ReadOnlySpan128<byte> lhs, ReadOnlySpan128<byte> rhs, in Span128<byte> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                or(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        static Span128<short> Or(this ReadOnlySpan128<short> lhs, ReadOnlySpan128<short> rhs, in Span128<short> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                or(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        static Span128<ushort> Or(this ReadOnlySpan128<ushort> lhs, ReadOnlySpan128<ushort> rhs, in Span128<ushort> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                or(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        static Span128<int> Or(this ReadOnlySpan128<int> lhs, ReadOnlySpan128<int> rhs, in Span128<int> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                or(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        static Span128<uint> Or(this ReadOnlySpan128<uint> lhs, ReadOnlySpan128<uint> rhs, in Span128<uint> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                or(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        static Span128<long> Or(this ReadOnlySpan128<long> lhs, ReadOnlySpan128<long> rhs, in Span128<long> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                or(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        static Span128<ulong> Or(this ReadOnlySpan128<ulong> lhs, ReadOnlySpan128<ulong> rhs, in Span128<ulong> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                or(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        static Span128<float> Or(this ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs, in Span128<float> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                or(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        static Span128<double> Or(this ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs, in Span128<double> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                or(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        static Span256<sbyte> Or(this ReadOnlySpan256<sbyte> lhs, ReadOnlySpan256<sbyte> rhs, in Span256<sbyte> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                or(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        }

        static Span256<byte> Or(this ReadOnlySpan256<byte> lhs, ReadOnlySpan256<byte> rhs, in Span256<byte> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                or(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        }

        static Span256<short> Or(this ReadOnlySpan256<short> lhs, ReadOnlySpan256<short> rhs, in Span256<short> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                or(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        }

        static Span256<ushort> Or(this ReadOnlySpan256<ushort> lhs, ReadOnlySpan256<ushort> rhs, in Span256<ushort> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                or(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        }

        static Span256<int> Or(this ReadOnlySpan256<int> lhs, ReadOnlySpan256<int> rhs, in Span256<int> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                or(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        }

        static Span256<uint> Or(this ReadOnlySpan256<uint> lhs, ReadOnlySpan256<uint> rhs, in Span256<uint> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                or(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        }

        static Span256<long> Or(this ReadOnlySpan256<long> lhs, ReadOnlySpan256<long> rhs, in Span256<long> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                or(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        }

        static Span256<ulong> Or(this ReadOnlySpan256<ulong> lhs, ReadOnlySpan256<ulong> rhs, in Span256<ulong> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                or(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        }

        static Span256<float> Or(this ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs, in Span256<float> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                or(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        }

        static Span256<double> Or(this ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs, in Span256<double> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                or(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        } 
    }
}