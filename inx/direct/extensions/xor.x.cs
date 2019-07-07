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
    partial class dinxx
    {
        [MethodImpl(Inline)]
        public static Vec256<sbyte> XOr(this in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => dinx.xor(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec256<byte> XOr(this in Vec256<byte> lhs, in Vec256<byte> rhs)
            => dinx.xor(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> XOr(this in Vec256<short> lhs, in Vec256<short> rhs)
            => dinx.xor(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec256<ushort> XOr(this in Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => dinx.xor(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec256<int> XOr(this in Vec256<int> lhs, in Vec256<int> rhs)
            => dinx.xor(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec256<uint> XOr(this in Vec256<uint> lhs, in Vec256<uint> rhs)
            => dinx.xor(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec256<long> XOr(this in Vec256<long> lhs, in Vec256<long> rhs)
            => dinx.xor(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec256<ulong> XOr(this in Vec256<ulong> lhs, in Vec256<ulong> rhs)
            => dinx.xor(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static void XOr(this in Vec256<sbyte> lhs, in Vec256<sbyte> rhs, ref sbyte dst)
            => dinx.xor(in lhs, in rhs, ref dst);

        [MethodImpl(Inline)]
        public static void XOr(this in Vec256<byte> lhs, in Vec256<byte> rhs, ref byte dst)
            => dinx.xor(in lhs, in rhs, ref dst);

        [MethodImpl(Inline)]
        public static void XOr(this in Vec256<short> lhs, in Vec256<short> rhs, ref short dst)
            => dinx.xor(in lhs, in rhs, ref dst);

        [MethodImpl(Inline)]
        public static void XOr(this in Vec256<ushort> lhs, in Vec256<ushort> rhs, ref ushort dst)
            => dinx.xor(in lhs, in rhs, ref dst);

        [MethodImpl(Inline)]
        public static void XOr(this in Vec256<int> lhs, in Vec256<int> rhs, ref int dst)
            => dinx.xor(in lhs, in rhs, ref dst);

        [MethodImpl(Inline)]
        public static void XOr(this in Vec256<uint> lhs, in Vec256<uint> rhs, ref uint dst)
            => dinx.xor(in lhs, in rhs, ref dst);

        [MethodImpl(Inline)]
        public static void XOr(this in Vec256<long> lhs, in Vec256<long> rhs, ref long dst)
            => dinx.xor(in lhs, in rhs, ref dst);

        [MethodImpl(Inline)]
        public static void XOr(this in Vec256<ulong> lhs, in Vec256<ulong> rhs, ref ulong dst)
            => dinx.xor(in lhs, in rhs, ref dst);


        public static Span128<sbyte> XOr(this ReadOnlySpan128<sbyte> lhs, ReadOnlySpan128<sbyte> rhs, in Span128<sbyte> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                xor(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        public static Span128<byte> XOr(this ReadOnlySpan128<byte> lhs, ReadOnlySpan128<byte> rhs, in Span128<byte> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                xor(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        public static Span128<short> XOr(this ReadOnlySpan128<short> lhs, ReadOnlySpan128<short> rhs, in Span128<short> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                xor(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        public static Span128<ushort> XOr(this ReadOnlySpan128<ushort> lhs, ReadOnlySpan128<ushort> rhs, in Span128<ushort> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                xor(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        public static Span128<int> XOr(this ReadOnlySpan128<int> lhs, ReadOnlySpan128<int> rhs, in Span128<int> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                xor(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        public static Span128<uint> XOr(this ReadOnlySpan128<uint> lhs, ReadOnlySpan128<uint> rhs, in Span128<uint> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                xor(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        public static Span128<long> XOr(this ReadOnlySpan128<long> lhs, ReadOnlySpan128<long> rhs, in Span128<long> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                xor(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        public static Span128<ulong> XOr(this ReadOnlySpan128<ulong> lhs, ReadOnlySpan128<ulong> rhs, in Span128<ulong> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                xor(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        public static Span128<float> XOr(this ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs, in Span128<float> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                xor(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        public static Span128<double> XOr(this ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs, in Span128<double> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                xor(lhs.LoadVec128(block), rhs.LoadVec128(block), ref dst.Block(block));
            return dst;            
        }

        public static Span256<sbyte> XOr(this ReadOnlySpan256<sbyte> lhs, ReadOnlySpan256<sbyte> rhs, in Span256<sbyte> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                xor(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        }

        public static Span256<byte> XOr(this ReadOnlySpan256<byte> lhs, ReadOnlySpan256<byte> rhs, in Span256<byte> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                xor(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        }

        public static Span256<short> XOr(this ReadOnlySpan256<short> lhs, ReadOnlySpan256<short> rhs, in Span256<short> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                xor(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        }

        public static Span256<ushort> XOr(this ReadOnlySpan256<ushort> lhs, ReadOnlySpan256<ushort> rhs, in Span256<ushort> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                xor(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        }

        public static Span256<int> XOr(this ReadOnlySpan256<int> lhs, ReadOnlySpan256<int> rhs, in Span256<int> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                xor(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        }

        public static Span256<uint> XOr(this ReadOnlySpan256<uint> lhs, ReadOnlySpan256<uint> rhs, in Span256<uint> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                xor(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        }

        public static Span256<long> XOr(this ReadOnlySpan256<long> lhs, ReadOnlySpan256<long> rhs, in Span256<long> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                xor(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        }

        public static Span256<ulong> XOr(this ReadOnlySpan256<ulong> lhs, ReadOnlySpan256<ulong> rhs, in Span256<ulong> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                xor(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        }

        public static Span256<float> XOr(this ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs, in Span256<float> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                xor(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        }

        public static Span256<double> XOr(this ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs, in Span256<double> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                xor(lhs.LoadVec256(block), rhs.LoadVec256(block), ref dst.Block(block));
            return dst;            
        } 
    }
}