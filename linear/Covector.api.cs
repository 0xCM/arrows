//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
        
    using static zfunc;

    public static class Covector
    {        
        /// <summary>
        /// Loads a natural span from an existing span that is required to have
        /// the specified natural length. This operation performs no allocation.
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="length">The natural length</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Covector<N,T> Load<N,T>(Span<T> src, N length = default)
            where N : ITypeNat, new()
            where T : struct
                => Covector<N,T>.Define(src);

        [MethodImpl(Inline)]
        public static Covector<N,T> Load<N,T>(Span<N,T> src)
            where N : ITypeNat, new()
            where T : struct
                => Covector<N,T>.Define(src);

        /// <summary>
        /// Loads a natural span from a readonly span that is required to have
        /// the specified natural length. This operation replicates
        /// the source readonly span.
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="length">The natural length</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Covector<N,T> Load<N,T>(in ReadOnlySpan<T> src, N length = default)
            where N : ITypeNat, new()
            where T : struct
                => Covector<N,T>.Define(in src);
        
 
    }


}