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
        public static Vec256<byte> abs(in Vec256<sbyte> src)
            => Abs(src);

        [MethodImpl(Inline)]
        public static Vec256<ushort> abs(in Vec256<short> src)
            => Abs(src);

        [MethodImpl(Inline)]
        public static Vec256<uint> abs(in Vec256<int> src)
            => Abs(src);
 
        [MethodImpl(Inline)]
        public static void abs(in Vec128<sbyte> src, ref sbyte dst)
            => Abs(src);

        [MethodImpl(Inline)]
        public static void abs(in Vec128<short> src, ref short dst)
            => Abs(src);

        [MethodImpl(Inline)]
        public static void abs(in Vec128<int> src, ref uint dst)
            => store(Abs(src), ref dst);

        [MethodImpl(Inline)]
        public static void abs(in Vec256<sbyte> src, ref byte dst)
            => store(Abs(src), ref dst);

        [MethodImpl(Inline)]
        public static void abs(in Vec256<short> src, ref ushort dst)
            => store(Abs(src), ref dst);

        [MethodImpl(Inline)]
        public static void abs(in Vec256<int> src, ref uint dst)
            => store(Abs(src), ref dst);
 
        public static Span128<byte> abs(in Span128<sbyte> src, Span128<byte> dst)
        {
            for(var block = 0; block <src.BlockCount; block ++)                
            {
                var x =  Vec128.load(ref src.Block(block));
                store(Abs(x), ref dst[block]);                
            }
            return dst;
        }

        public static Span128<ushort> abs(in Span128<short> src, Span128<ushort> dst)
        {
            for(var block = 0; block <src.BlockCount; block ++)                
            {
                var x =  Vec128.load(ref src.Block(block));
                store(Abs(x), ref dst[block]);                
            }
            return dst;
        }

        public static Span128<uint> abs(in Span128<int> src, Span128<uint> dst)
        {
            for(var block = 0; block <src.BlockCount; block ++)                
            {
                var x =  Vec128.load(ref src.Block(block));
                store(Abs(x), ref dst[block]);                
            }
            return dst;
        }

        public static Span256<byte> abs(in Span256<sbyte> src, Span256<byte> dst)
        {
            for(var block = 0; block <src.BlockCount; block ++)                
            {
                var x =  Vec256.load(ref src.Block(block));
                store(Abs(x), ref dst[block]);                
            }
            return dst;
        }

        public static Span256<ushort> abs(in Span256<short> src, Span256<ushort> dst)
        {
            for(var block = 0; block <src.BlockCount; block ++)                
            {
                var x =  Vec256.load(ref src.Block(block));
                store(Abs(x), ref dst[block]);                
            }
            return dst;
        }

        public static Span256<uint> abs(in Span256<int> src, Span256<uint> dst)
        {
            for(var block = 0; block <src.BlockCount; block ++)                
            {
                var x =  Vec256.load(ref src.Block(block));
                store(Abs(x), ref dst[block]);                
            }
            return dst;
        }

    }

}