//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;

    public static class RegX 
    {

        /// <summary>
        /// Moves source vector content to a 128-bit register/memory target
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target location</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static ref XMEM MoveTo<T>(this Vector128<T> src, ref XMEM dst)
            where T : unmanaged
                => ref Reg.move(src, ref dst);

        /// <summary>
        /// Moves source vector content to a 256-bit register target
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target location</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static ref YMM MoveTo<T>(Vector256<T> src, ref YMM dst)
            where T : unmanaged
                => ref Reg.move(src, ref dst);
    }
}
