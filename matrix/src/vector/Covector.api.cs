//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    
    using static zfunc;

    /// <summary>
    /// Defines the covector api surface
    /// </summary>
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
        public static Covector<N,T> Load<N,T>(T[] src, N length = default)
            where N : ITypeNat, new()
            where T : unmanaged
                => Covector<N,T>.Load(src);
     
    }

}