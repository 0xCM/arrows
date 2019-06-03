//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;    
    using System.Runtime.Intrinsics;
    using System.Diagnostics;

    using static zfunc;

    public static class VecXX
    {
        /// <summary>
        /// Returns the vector component for a specified index
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The index</param>
        /// <typeparam name="T">The vector primitive type</typeparam>
        [MethodImpl(Inline)]
        public static T component<T>(in Vector128<T> src, int index)
            where T : struct
                => src.GetElement(index);

        /// <summary>
        /// Returns the vector component for a specified index
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="index">The index</param>
        /// <typeparam name="T">The vector primitive type</typeparam>
        [MethodImpl(Inline)]
        public static T component<T>(in Vector256<T> src, int index)
            where T : struct
                => src.GetElement(index);



    }
}