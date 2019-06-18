//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Numerics;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using Z0;
 
    using static zfunc;
    
    partial class Bits
    {                
        /// <summary>
        /// Retrieves the operand's least significant bit
        /// </summary>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline)]
        public static Bit lobit(in sbyte src)
            => test(in src, 0);

        /// <summary>
        /// Retrieves the operand's least significant bit
        /// </summary>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline)]
        public static Bit lobit(in byte src)
            => test(in src, 0);

        /// <summary>
        /// Retrieves the operand's least significant bit
        /// </summary>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline)]
        public static Bit lobit(in short src)
            => test(in src, 0);

        /// <summary>
        /// Retrieves the operand's least significant bit
        /// </summary>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline)]
        public static Bit lobit(in ushort src)
            => test(in src, 0);

        /// <summary>
        /// Retrieves the operand's least significant bit
        /// </summary>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline)]
        public static Bit lobit(in int src)
            => test(in src, 0);

        /// <summary>
        /// Retrieves the operand's least significant bit
        /// </summary>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline)]
        public static Bit lobit(in uint src)
            => test(in src, 0);

        /// <summary>
        /// Retrieves the operand's least significant bit
        /// </summary>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline)]
        public static Bit lobit(in long src)
            => test(in src, 0);

        /// <summary>
        /// Retrieves the operand's least significant bit
        /// </summary>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline)]
        public static Bit lobit(in ulong src)
            => test(in src, 0);

        /// <summary>
        /// Retrieves the operand's least significant bit
        /// </summary>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline)]
        public static Bit lobit(in float src)
            => test(in src, 0);

        /// <summary>
        /// Retrieves the operand's least significant bit
        /// </summary>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline)]
        public static Bit lobit(in double src)
            => test(in src, 0);

    }

}