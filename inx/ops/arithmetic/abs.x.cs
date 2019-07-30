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
    using static System.Runtime.Intrinsics.X86.Sse3;
    using static System.Runtime.Intrinsics.X86.Ssse3;

    using static zfunc;    

    partial class dinxx
    {
        public static Span128<byte> abs(this ReadOnlySpan128<sbyte> src, Span128<byte> dst)
        {
            for(var block = 0; block <src.BlockCount; block ++)                
            {
                var x =  Vec128.loadi(in src.Block(block));
                dinx.store(dinx.abs(x), ref dst[block]);                
            }
            return dst;
        }

        public static Span128<ushort> abs(this ReadOnlySpan128<short> src, Span128<ushort> dst)
        {
            for(var block = 0; block <src.BlockCount; block ++)                
            {
                var x =  Vec128.loadi(in src.Block(block));
                dinx.store(dinx.abs(x), ref dst[block]);                
            }
            return dst;
        }

        public static Span128<uint> abs(this ReadOnlySpan128<int> src, Span128<uint> dst)
        {
            for(var block = 0; block <src.BlockCount; block ++)                
            {
                var x = Vec128.loadi(in src.Block(block));
                dinx.store(dinx.abs(x), ref dst[block]);                
            }
            return dst;
        }

        public static Span256<byte> abs(this ReadOnlySpan256<sbyte> src, Span256<byte> dst)
        {
            for(var block = 0; block <src.BlockCount; block ++)                
            {
                var x =  Vec256.loadi(in src.Block(block));
                dinx.store(dinx.abs(x), ref dst[block]);                
            }
            return dst;
        }

        public static Span256<ushort> abs(this ReadOnlySpan256<short> src, Span256<ushort> dst)
        {
            for(var block = 0; block <src.BlockCount; block ++)                
            {
                var x =  Vec256.loadi(in src.Block(block));
                dinx.store(dinx.abs(x), ref dst[block]);                
            }
            return dst;
        }

        public static Span256<uint> abs(in ReadOnlySpan256<int> src, Span256<uint> dst)
        {
            for(var block = 0; block <src.BlockCount; block ++)                
            {
                var x =  Vec256.loadi(in src.Block(block));
                dinx.store(dinx.abs(x), ref dst[block]);                
            }
            return dst;
        }

    }

}