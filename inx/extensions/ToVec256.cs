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

    public static class ToVec256X
    {
        /// <summary>
        /// Loads a single intrinsic vector from a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> ToVec256<T>(this in Span256<T> src, int block = 0)            
            where T : struct            
                => Vec256.load(src, block);

        /// <summary>
        /// Loads a single intrinsic vector from a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> ToVec256<T>(this in ReadOnlySpan256<T> src, int block = 0)            
            where T : struct            
                => Vec256.load(src,block);
 
 
        [MethodImpl(Inline)]
        public static Vec256<ulong> ToVec256(this in Span<ulong> src, int offset = 0)
            => Vec256.load(ref src[offset]);

    }

}