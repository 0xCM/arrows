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
        /// Applies a logical rightwards shift to the source operand in-place
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static ref T srl<T>(ref T src, int offset)
            where T : unmanaged
                => ref gmath.srl(ref src, offset);

        /// <summary>
        /// Applies a logical rightwards shift to the source operand
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static T srl<T>(T src, int offset)
            where T : unmanaged
                => gmath.srl(src, offset);


    }

}