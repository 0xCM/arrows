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

    public static partial class dinx
    {
         

        public static Span128<sbyte> add(ReadOnlySpan128<sbyte> lhs, ReadOnlySpan128<sbyte> rhs, Span128<sbyte> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                vstore(dinx.add(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst.Block(block));            
            return dst;            
        }

        public static Span128<byte> add(ReadOnlySpan128<byte> lhs, ReadOnlySpan128<byte> rhs, Span128<byte> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                vstore(dinx.add(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst.Block(block));            
            return dst;            
        }

        public static Span128<short> add(ReadOnlySpan128<short> lhs, ReadOnlySpan128<short> rhs, Span128<short> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                vstore(dinx.add(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst.Block(block));            
            return dst;            
        }

        public static Span128<ushort> add(ReadOnlySpan128<ushort> lhs, ReadOnlySpan128<ushort> rhs, Span128<ushort> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                vstore(dinx.add(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst.Block(block));            
            return dst;            
        }

        public static Span128<int> add(ReadOnlySpan128<int> lhs, ReadOnlySpan128<int> rhs, Span128<int> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                vstore(dinx.add(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst.Block(block));            
            return dst;            
        }

        public static Span128<uint> add(ReadOnlySpan128<uint> lhs, ReadOnlySpan128<uint> rhs, Span128<uint> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                vstore(dinx.add(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst.Block(block));            
            return dst;            
        }

        public static Span128<long> add(ReadOnlySpan128<long> lhs, ReadOnlySpan128<long> rhs, Span128<long> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                vstore(dinx.add(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst.Block(block));            
            return dst;            
        }

        public static Span128<ulong> add(ReadOnlySpan128<ulong> lhs, ReadOnlySpan128<ulong> rhs, Span128<ulong> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                vstore(dinx.add(lhs.LoadVec128(block), rhs.LoadVec128(block)), ref dst.Block(block));            
            return dst;            
        }

        public static Span256<sbyte> add(ReadOnlySpan256<sbyte> lhs, ReadOnlySpan256<sbyte> rhs, Span256<sbyte> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                vstore(dinx.add(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst.Block(block));            
            return dst;            
        }

        public static Span256<byte> add(ReadOnlySpan256<byte> lhs, ReadOnlySpan256<byte> rhs, Span256<byte> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                vstore(dinx.add(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst.Block(block));            
            return dst;            
        }

        public static Span256<short> add(ReadOnlySpan256<short> lhs, ReadOnlySpan256<short> rhs, Span256<short> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                vstore(dinx.add(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst.Block(block));            
            return dst;            
        }

        public static Span256<ushort> add(ReadOnlySpan256<ushort> lhs, ReadOnlySpan256<ushort> rhs, Span256<ushort> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                vstore(dinx.add(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst[block]);            
            return dst;            
        }

        public static Span256<int> add(ReadOnlySpan256<int> lhs, ReadOnlySpan256<int> rhs, Span256<int> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                vstore(dinx.add(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst.Block(block));            
            return dst;            
        }

        public static Span256<uint> add(ReadOnlySpan256<uint> lhs, ReadOnlySpan256<uint> rhs, Span256<uint> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                vstore(dinx.add(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst.Block(block));            
            return dst;            
        }

        public static Span256<long> add(ReadOnlySpan256<long> lhs, ReadOnlySpan256<long> rhs, Span256<long> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                vstore(dinx.add(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst.Block(block));            
            return dst;            
        }

        public static Span256<ulong> add(ReadOnlySpan256<ulong> lhs, ReadOnlySpan256<ulong> rhs, Span256<ulong> dst)
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                vstore(dinx.add(lhs.LoadVec256(block), rhs.LoadVec256(block)), ref dst.Block(block));            
            return dst;            
        }


    }

}