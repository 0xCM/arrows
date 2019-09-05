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
    using System.Runtime.InteropServices;    
        
    using static zfunc;

    public static class Dataset
    {
        /// <summary>
        /// Loads a sample from a span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="dim">The sample dimension</param>
        /// <param name="offset">The offset into the source span from to begin the load</param>
        /// <typeparam name="T">The sample data type</typeparam>
        [MethodImpl(Inline)]
        public static Dataset<T> Load<T>(T[] src, int dim = 1)
            where T : unmanaged
                => Dataset<T>.Load(src, dim);

        /// <summary>
        /// Loads a sample from a memory source
        /// </summary>
        /// <param name="src">The memory source</param>
        /// <param name="dim">The sample dimension</param>
        /// <typeparam name="T">The sample data type</typeparam>
        [MethodImpl(Inline)]
        public static Dataset<T> Load<T>(MemorySpan<T> src, int dim = 1)
            where T : unmanaged
                => Dataset<T>.Load(src, dim);

        /// <summary>
        /// Allocates a sample 
        /// </summary>
        /// <param name="dim">The sample dimension</param>
        /// <param name="count">The number of observation vectors in the sample</param>
        /// <typeparam name="T">The sample data type</typeparam>
        [MethodImpl(Inline)]
        public static Dataset<T> Alloc<T>(int dim, int count)
            where T : unmanaged
            => Dataset<T>.Alloc(dim, count);
    }
}