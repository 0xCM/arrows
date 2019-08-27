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
        static readonly Vec256<int> MRev256i32 = Vec256.FromParts(7, 5, 6, 4, 3, 2, 1, 0);
        
        static readonly Vec256<uint> MRev256u32 = Vec256.FromParts(7u, 6u, 5u, 4u, 3u, 2u, 1u, 0u);
        
        static readonly Vec256<int> MRev256f32 = Vec256.FromParts(7, 6, 5, 4, 3, 2, 1, 0);    

        static readonly Vec128<byte> MRev128u8 = Vec128.Decrements((byte)15);

        static readonly Vec128<sbyte> MRev128i8 = Vec128.Decrements((sbyte)15);

        static readonly Vec256<byte> MRev256u8 = Vec256Pattern.Decrements((byte)31);

        /// <summary>
        /// Creates a mask that, when applied to a source vector, effects a sequence of transpositions
        /// </summary>
        /// <param name="swaps">The transpositions</param>
        [MethodImpl(Inline)]
        static Vec128<byte> MSwap128u8(params Swap[] swaps)
            => Vec128.Increments((byte)0, swaps);

        const byte MRev128i32 = 0b00_01_10_11;

        const byte MRev128u32 = 0b00_01_10_11;
        

        [MethodImpl(Inline)]
        public static Vec128<byte> swap(in Vec128<byte> src, params Swap[] swaps)
            => shuffle(src, MSwap128u8(swaps));

        /// <summary>
        /// Creates a new vector by reversing the componets in the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<byte> reverse(in Vec128<byte> src)
            => shuffle(src, MRev128u8);

        /// <summary>
        /// Creates a new vector by reversing the componets in the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<sbyte> reverse(in Vec128<sbyte> src)
            => shuffle(src, MRev128i8);

        /// <summary>
        /// Creates a new vector by reversing the componets in the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<int> reverse(in Vec128<int> src)
            => shuffle(src, MRev128i32);

        /// <summary>
        /// Creates a new vector by reversing the componets in the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> reverse(in Vec128<uint> src)
            => shuffle(src, MRev128u32);

        [MethodImpl(Inline)]
        public static Vec256<byte> reverse(in Vec256<byte> src)
            => permute(src,MRev256u8);

        [MethodImpl(Inline)]
        public static Vec256<int> reverse(in Vec256<int> src)
            => perm8x32(src,MRev256i32);

        [MethodImpl(Inline)]
        public static Vec256<uint> reverse(in Vec256<uint> src)
            => perm8x32(src,MRev256u32);

        [MethodImpl(Inline)]
        public static Vec256<float> reverse(in Vec256<float> src)
            => perm8x32(src,MRev256f32);
        
 
    }

}