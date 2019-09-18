//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;
    using static As;
    using static AsIn;

    partial class gbits
    {

        /// <summary>
        /// Sets an identified bit to a supplied value
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <param name="pos">The bit position</param>
        /// <param name="value">The value to be applied</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static ref T set<T>(ref T src, byte pos, in Bit value)            
            where T : struct
                => ref BitMaskG.set(ref src, pos, value);

        /// <summary>
        /// Enaables a bit in the target if it is enabled in the source
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="srcpos">The source bit position</param>
        /// <param name="dst">The target value</param>
        /// <param name="dstpos">The target bit position</param>
        [MethodImpl(Inline)]
        public static ref T setif<T>(in T src, int srcpos, ref T dst, int dstpos)
            where T : struct
                => ref BitMaskG.setif(in src, srcpos, ref dst, dstpos);

    }
}