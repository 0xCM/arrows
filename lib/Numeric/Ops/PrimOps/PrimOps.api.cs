//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using static zcore;

    using static Operative;
    using Primal = PrimOps.Reify;

    /// <summary>
    /// Provies access to all primitive operations that are defined
    /// </summary>
    public static class primops
    {
        /// <summary>
        /// Returns the primitive operations available for a speicified type, if any; otherwise,
        /// raises an error
        /// </summary>
        /// <typeparam name="T">The type for which primitive operations are desired</typeparam>
        [MethodImpl(Inline)]    
        public static Operative.PrimOps<T> typeops<T>()
            where T : struct
                => Z0.Reify.PrimOps<T>.Inhabitant;

        /// <summary>
        /// For fixed-size types, returns the number of storage bits required;
        /// otherwise, returns 0.
        /// </summary>
        /// <typeparam name="T">The primitive type</typeparam>
        [MethodImpl(Inline)]
        public static uint bitsize<T>()        
            where T : struct
                => (uint)Unsafe.SizeOf<T>()*8;

                 
    }
}