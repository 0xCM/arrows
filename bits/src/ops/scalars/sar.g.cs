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
    
    partial class gbits
    {

        /// <summary>
        /// Computes an arithmetic rightwards shift
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The number of bits to shift</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T sar<T>(T src, int offset)
            where T : struct
                => gmath.sar(src,offset);

        /// <summary>
        /// Applies an arithmetic rightwards shift to the source operand in-place
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The number of bits to shift</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref T sar<T>(ref T src, int offset)
            where T : struct
                => ref gmath.sar(ref src, offset);
    }
}