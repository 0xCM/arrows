//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    using static As;

    public static partial class ginxs
    {
        /// <summary>
        /// Loads a 128-bit vector from a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> LoadVec128<T>(this Span128<T> src, int block = 0)            
            where T : struct            
                => Vec128.load(src,block);

        /// <summary>
        /// Loads a 128-bit vector from a blocked readonly span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> LoadVec128<T>(this ReadOnlySpan128<T> src, int block = 0)            
            where T : struct            
                => Vec128.load(src,block);

        /// <summary>
        /// Loads a 256-bit vector from a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> LoadVec256<T>(this Span256<T> src, int block = 0)            
            where T : struct            
                => Vec256.load(src, block);

        /// <summary>
        /// Loads a 256-bit vector from a blocked readonly span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> LoadVec256<T>(this ReadOnlySpan256<T> src, int block = 0)            
            where T : struct            
                => Vec256.load(src,block);

        /// <summary>
        /// Loads a 128-bit vector from a span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vec128<T> LoadVec128<T>(this Span<T> src, int offset = 0)
            where T : struct            
                => Vec128.load(ref src[offset]);

        /// Loads a 128-bit vector from a span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vec128<T> LoadVec128<T>(this ReadOnlySpan<T> src, int offset = 0)
            where T : struct            
                => Vec128.load(ref As.asRef(in src[offset]));

        /// <summary>
        /// Loads a 256-bit vector from a span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vec256<T> LoadVec256<T>(this Span<T> src, int offset = 0)
            where T : struct            
                => Vec256.load(ref src[offset]);

        /// <summary>
        /// Loads a 256-bit vector from a span beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The position of the fist source element </param>
        [MethodImpl(Inline)]
        public static Vec256<T> LoadVec256<T>(this ReadOnlySpan<T> src, int offset = 0)
            where T : struct            
                => Vec256.load(ref As.asRef(in src[offset]));

    }
}