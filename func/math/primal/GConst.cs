//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static zfunc;


    /// <summary>
    /// Provides access to widely-used generic constants
    /// </summary>
    public static class GConst
    {
        /// <summary>
        /// Returns a readonly reference to 0:T
        /// </summary>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T zero<T>()            
            where T : unmanaged
                => ref GConst<T>.Zero;

        /// <summary>
        /// Returns a readonly reference to 1:T
        /// </summary>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T one<T>()            
            where T : unmanaged
                => ref GConst<T>.One;

        /// <summary>
        /// Returns a readonly reference to minval:T
        /// </summary>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T minval<T>()            
            where T : unmanaged
                => ref GConst<T>.MinVal;

        /// <summary>
        /// Returns a readonly reference to maxval:T
        /// </summary>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly T maxval<T>()            
            where T : unmanaged
                => ref GConst<T>.MaxVal;
    }
    
    readonly struct GConst<T>
        where T : unmanaged
    {
        public static readonly T Zero = PrimalInfo.zero<T>();

        public static readonly T One = PrimalInfo.one<T>();

        public static readonly T MinVal = PrimalInfo.minval<T>();

        public static readonly T MaxVal = PrimalInfo.maxval<T>();
    }
}