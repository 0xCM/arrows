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
        /// Disables an identified source bit
        /// </summary>
        /// <param name="src">The source segment</param>
        /// <param name="pos">The 0-based index of the bit to change</param>
        /// <typeparam name="T">The source element type</typeparam>
        [MethodImpl(Inline)]
        public static ref T disable<T>(ref T src, byte pos)
            where T : struct
                => ref BitMaskG.disable(ref src, (byte)pos);
    }

}