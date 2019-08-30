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
    using System.Diagnostics;
    
    using static zfunc;    
    
    partial class math
    {
        /// <summary>
        /// Raises e to a specified exponent
        /// </summary>
        /// <param name="pow">The exponent</param>
        [MethodImpl(Inline)]
        public static sbyte exp(sbyte pow)
            => (sbyte)MathF.Exp(pow);

        /// <summary>
        /// Raises e to a specified exponent
        /// </summary>
        /// <param name="pow">The exponent</param>
        [MethodImpl(Inline)]
        public static byte exp(byte pow)
            => (byte)MathF.Exp(pow);

        /// <summary>
        /// Raises e to a specified exponent
        /// </summary>
        /// <param name="pow">The exponent</param>
        [MethodImpl(Inline)]
        public static short exp(short pow)
            => (short)MathF.Exp(pow);

        /// <summary>
        /// Raises e to a specified exponent
        /// </summary>
        /// <param name="pow">The exponent</param>
        [MethodImpl(Inline)]
        public static ushort exp(ushort pow)
            => (ushort)MathF.Exp(pow);

        /// <summary>
        /// Raises e to a specified exponent
        /// </summary>
        /// <param name="pow">The exponent</param>
        [MethodImpl(Inline)]
        public static int exp(int pow)
            => (int)MathF.Exp(pow);

        /// <summary>
        /// Raises e to a specified exponent
        /// </summary>
        /// <param name="pow">The exponent</param>
        [MethodImpl(Inline)]
        public static uint exp(uint pow)
            => (uint)MathF.Exp(pow);

        /// <summary>
        /// Raises e to a specified exponent
        /// </summary>
        /// <param name="pow">The exponent</param>
        [MethodImpl(Inline)]
        public static long exp(long pow)
            => (long)Math.Exp(pow);

        /// <summary>
        /// Raises e to a specified exponent
        /// </summary>
        /// <param name="pow">The exponent</param>
        [MethodImpl(Inline)]
        public static ulong exp(ulong pow)
            => (ulong)Math.Exp(pow);

        /// <summary>
        /// Raises e to a specified exponent
        /// </summary>
        /// <param name="pow">The exponent</param>
        [MethodImpl(Inline)]
        public static float exp(float pow)
            => MathF.Exp(pow);

        /// <summary>
        /// Raises e to a specified exponent
        /// </summary>
        /// <param name="pow">The exponent</param>
        [MethodImpl(Inline)]
        public static double exp(double pow)
            => Math.Exp(pow);
        
    }

}