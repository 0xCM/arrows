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
    

    partial class Bits
    {

        /// <summary>
        /// Applies an arithmetic rightwards shift to the source operand in-place
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static ref sbyte sra(ref sbyte src, int offset)
        {
            src >>= offset;
            return ref src;
        }

        /// <summary>
        /// Applies an arithmetic rightwards shift to the source operand in-place
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static ref short sra(ref short src, int offset)
        {
            src >>= offset;
            return ref src;
        }

        /// <summary>
        /// Applies an arithmetic rightwards shift to the source operand in-place
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static ref int sra(ref int src, int offset)
        {
            src >>= offset;
            return ref src;
        }


        /// <summary>
        /// Applies an arithmetic rightwards shift to the source operand in-place
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="offset">The number of bits to shift</param>
        [MethodImpl(Inline)]
        public static ref long sra(ref long src, int offset)
        {
            src >>= offset;
            return ref src;
        }


    }

}