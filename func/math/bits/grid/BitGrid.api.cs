//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public static class BitGrid
    {
        /// <summary>
        /// Defines a bit layout grid as determined by specified type parameters
        /// </summary>
        /// <param name="m">The number of grid rows</param>
        /// <param name="n">The number of grid columns</param>
        /// <param name="rep"></param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The column count type</typeparam>
        /// <typeparam name="T">The storage type</typeparam>
        public static GridSpec<T> Specify<M,N,T>(M m = default, N n = default, T rep = default)
            where N : ITypeNat, new()
            where M : ITypeNat, new()
            where T : struct
                => new GridSpec<T>(bitsize<T>(), (int)m.value, (int)n.value);
    }
}