//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class dinx
    {
        static readonly Vec256<int> Reverse256i32Control = Vec256.FromParts(7, 5, 6, 4, 3, 2, 1, 0);
        
        static readonly Vec256<uint> Reverse256u32Control = Vec256.FromParts(7u, 6u, 5u, 4u, 3u, 2u, 1u, 0u);
        
        static readonly Vec256<int> Reverse256f32Control = Vec256.FromParts(7, 6, 5, 4, 3, 2, 1, 0);
        

        
        [MethodImpl(Inline)]
        public static Vec256<int> reverse(in Vec256<int> src)
            => permute8x32(src,Reverse256i32Control);

        [MethodImpl(Inline)]
        public static Vec256<uint> reverse(in Vec256<uint> src)
            => permute8x32(src,Reverse256u32Control);

        [MethodImpl(Inline)]
        public static Vec256<float> reverse(in Vec256<float> src)
            => permute8x32(src,Reverse256f32Control);
        
 
    }

}