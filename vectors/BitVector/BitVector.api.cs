//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Numerics;


    using static zfunc;    

    public static class BitVector
    {
        /// <summary>
        /// Creates a generic bitvector from a source value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> Define<T>(in T src)        
            where T : struct
                => new BitVector<T>(in src);

    }
}