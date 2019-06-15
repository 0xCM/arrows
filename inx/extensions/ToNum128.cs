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

    public static class ToNum128X
    {
        [MethodImpl(Inline)]
        public static Num128<T> ToNum128<T>(this in Vec128<T> src, int index)
            where T : struct            
                => Num128.define(src[index]);

        /// <summary>
        /// Loads a single intrinsic vector from a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static Num128<T> ToNum128<T>(this in ReadOnlySpan128<T> src, int block = 0)            
            where T : struct            
                => Num128.load(src,block);
    }

}