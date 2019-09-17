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
    using static System.Runtime.Intrinsics.X86.Ssse3;

    using static zfunc;    

    partial class dinx
    {    
        [MethodImpl(Inline)]
        public static Vec128<byte> abs(in Vec128<sbyte> src)
            => Abs(src);

        [MethodImpl(Inline)]
        public static Vec128<ushort> abs(in Vec128<short> src)
            => Abs(src);

        [MethodImpl(Inline)]
        public static Vec128<uint> abs(in Vec128<int> src)
            => Abs(src);

        [MethodImpl(Inline)]
        public static Vec128<long> abs(in Vec128<long> src)
        {
            var mask = negate(srl(src, 63));                        
            return sub(xor(mask, src), mask);
        }

        [MethodImpl(Inline)]
        public static Vec256<byte> abs(in Vec256<sbyte> src)
            => Abs(src);

        [MethodImpl(Inline)]
        public static Vec256<ushort> abs(in Vec256<short> src)
            => Abs(src);

        [MethodImpl(Inline)]
        public static Vec256<uint> abs(in Vec256<int> src)
            => Abs(src);        
 
        [MethodImpl(Inline)]
        public static Vec256<long> abs(Vec256<long> src)
        {
            var mask = negate(srl(src, 63));
            return sub(xor(mask, src), mask);
        }
 
        public static Span128<byte> abs(ReadOnlySpan128<sbyte> src, Span128<byte> dst)
        {
            for(var block = 0; block <src.BlockCount; block ++)                
            {
                var x =  Vec128.Loadi(in src.Block(block));
                vstore(dinx.abs(x), ref dst[block]);                
            }
            return dst;
        }

        public static Span128<ushort> abs(ReadOnlySpan128<short> src, Span128<ushort> dst)
        {
            for(var block = 0; block <src.BlockCount; block ++)                
            {
                var x =  Vec128.Loadi(in src.Block(block));
                vstore(dinx.abs(x), ref dst[block]);                
            }
            return dst;
        }

        public static Span128<uint> abs(ReadOnlySpan128<int> src, Span128<uint> dst)
        {
            for(var block = 0; block <src.BlockCount; block ++)                
            {
                var x = Vec128.Loadi(in src.Block(block));
                vstore(dinx.abs(x), ref dst[block]);                
            }
            return dst;
        }

        public static Span256<byte> abs(ReadOnlySpan256<sbyte> src, Span256<byte> dst)
        {
            for(var block = 0; block <src.BlockCount; block ++)                
            {
                var x =  Vec256.Loadi(in src.Block(block));
                vstore(dinx.abs(x), ref dst[block]);                
            }
            return dst;
        }

        public static Span256<ushort> abs(this ReadOnlySpan256<short> src, Span256<ushort> dst)
        {
            for(var block = 0; block <src.BlockCount; block ++)                
            {
                var x =  Vec256.Loadi(in src.Block(block));
                vstore(dinx.abs(x), ref dst[block]);                
            }
            return dst;
        }

        public static Span256<uint> abs(in ReadOnlySpan256<int> src, Span256<uint> dst)
        {
            for(var block = 0; block <src.BlockCount; block ++)                
            {
                var x =  Vec256.Loadi(in src.Block(block));
                vstore(dinx.abs(x), ref dst[block]);                
            }
            return dst;
        }
 
    }

}