//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using Z0;
 
    using static zfunc;
    

    partial class Bits
    {                

        /// <summary>
        /// Extracts the upper 16 bits from the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static ushort hi(in uint src)
            => (ushort)(src >> 16); 

        /// <summary>
        /// Extracts the lower 16 bits from the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static ushort lo(in uint src)
            => (ushort)src;

        /// <summary>
        /// Extracts the upper 32 bits from the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static uint hi(in ulong src)
            => (uint)(src >> 32);

        /// <summary>
        /// Extracts the lower 32 bits from the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static uint lo(in ulong src)
            => (uint)src;

        /// <summary>
        /// Extracts the upper 4 bits from the source
        /// </summary>
        /// <param name="src">The soruce value</param>
        [MethodImpl(Inline)]        
        public static sbyte hi(in sbyte src)
            => (sbyte)(src >> 4);

        /// <summary>
        /// Extracts the lower 4 bits from the source
        /// </summary>
        /// <param name="src">The soruce value</param>
        [MethodImpl(Inline)]
        public static sbyte lo(in sbyte src)
            => (sbyte)(((sbyte)(src << 4)) >> 4);

        /// <summary>
        /// Extracts the upper 4 bits from the source
        /// </summary>
        /// <param name="src">The soruce value</param>
        [MethodImpl(Inline)]
        public static byte hi(in byte src)
            => (byte)(src >> 4);

        /// <summary>
        /// Extracts the lower 4 bits from the source
        /// </summary>
        /// <param name="src">The soruce value</param>
        [MethodImpl(Inline)]
        public static byte lo(in byte src)
            => (byte)(((byte)(src << 4)) >> 4);

        /// <summary>
        /// Extracts the upper 8 bits from the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte hi(in ushort src)
            => (byte)(src >> 8);

        /// <summary>
        /// Extracts the lower 8 bits from the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte lo(in ushort src)
            => (byte)src;

        /// <summary>
        /// Extracts the upper 8 bits from the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static sbyte hi(in short src)
            => (sbyte)(src >> 8);            

        /// <summary>
        /// Extracts the lower 8 bits from the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static sbyte lo(in short src)
            => (sbyte)src;

        /// <summary>
        /// Extracts the upper 16 bits from the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static short hi(in int src)
            => (short)(src >> 16);

        /// <summary>
        /// Extracts the lower 16 bits from the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static short lo(in int src)
            => (short)src;        

        /// <summary>
        /// Extracts the upper 16 bits from the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static int hi(in long src)
            => (int)(src >> 32);

        /// <summary>
        /// Extracts the lower half of the bits from the source
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline)]
        public static int lo(in long src)
            => (int)src;
     }
}