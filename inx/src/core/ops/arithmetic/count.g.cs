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

    using static As;
    

    partial class ginx
    {
        /// <summary>
        /// Increments each source vector component by a unit
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> next<T>(in Vec128<T> src)
            where T : unmanaged
                => add(in src, in Vec128Pattern.Units<T>());

        /// <summary>
        /// Increments each source vector component by a unit
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> next<T>(in Vec256<T> src)
            where T : unmanaged
                => add(in src, in Vec256Pattern.Units<T>());

        /// <summary>
        /// Decrements each source vector component by a unit
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec128<T> prior<T>(in Vec128<T> src)
            where T : unmanaged
                => sub(in src, in Vec128Pattern.Units<T>());

        /// <summary>
        /// Decrements each source vector component by a unit
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static Vec256<T> prior<T>(in Vec256<T> src)
            where T : unmanaged
                => sub(in src, in Vec256Pattern.Units<T>());
    }

}