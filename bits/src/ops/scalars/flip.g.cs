//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    using static As;
    using static AsIn;
    
    partial class gbits
    {

        /// <summary>
        /// Computes the bitwise complement of a primal source operand
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static T flip<T>(T src)
            where T : struct
                => gmath.flip(src);

        /// <summary>
        /// Computes the bitwise complement of a primal source operand
        /// and overwites the operand with the result
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref T flip<T>(ref T src)
            where T : struct
                => ref gmath.flip(ref src);

        /// <summary>
        /// Computes the bitwise complement of a primal source operand
        /// and stores the result in a target operand
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="dst">The target operand</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static ref T flip<T>(in T src, ref T dst)
            where T : struct
                => ref gmath.flip(in src, ref dst);
 


    }

}