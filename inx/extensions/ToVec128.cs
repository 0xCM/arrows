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


    public static class ToVec128X
    {
       
        /// <summary>
        /// Loads a single intrinsic vector from a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> ToVec128<T>(this in Span128<T> src, int block = 0)            
            where T : struct            
                => Vec128.load(src,block);

        /// <summary>
        /// Loads a single intrinsic vector from a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> ToVec128<T>(this in ReadOnlySpan128<T> src, int block = 0)            
            where T : struct            
                => Vec128.single(src,block);

       
        [MethodImpl(Inline)]
        public static Vec128<byte> ToVec128(this byte src)
            => Vec128.define(src);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> ToVec128(this sbyte src)
            => Vec128.define(src);

        [MethodImpl(Inline)]
        public static Vec128<short> ToVec128(this short src)
            => Vec128.define(src);

        [MethodImpl(Inline)]
        public static Vec128<ushort> ToVec128(this ushort src)
            => Vec128.define(src);

        [MethodImpl(Inline)]
        public static Vec128<int> ToVec128(this int src)
            => Vec128.define(src);

        [MethodImpl(Inline)]
        public static Vec128<uint> ToVec128(this uint src)
            => Vec128.define(src);


        [MethodImpl(Inline)]
        public static Vec128<long> ToVec128(this long src)
            => Vec128.define(src);

        [MethodImpl(Inline)]
        public static Vec128<ulong> ToVec128(this ulong src)
            => Vec128.define(src);

        [MethodImpl(Inline)]
        public static Vec128<float> ToVec128(this float src)
            => Vec128.define(src);

        [MethodImpl(Inline)]
        public static Vec128<double> ToVec128(this double src)
            => Vec128.define(src);

    }

}