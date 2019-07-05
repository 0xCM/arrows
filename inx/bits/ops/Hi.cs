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
        [MethodImpl(Inline)]
        public static byte hi(in byte src)
            => (byte)(src >> 4);

        [MethodImpl(Inline)]
        public static byte lo(in byte src)
            => (byte)(src << 4);

        /// <summary>
        /// Extracts the high-order bits from a uint to produce a ushort
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static byte hi(in ushort src)
            => (byte)(src >> 8);

        /// <summary>
        /// Produces a byte by extracting bits [8 .. 15] from the source
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static sbyte hi(in short src)
            => (sbyte)(src >> 8);
            

        [MethodImpl(Inline)]
        public static short hi(in int src)
            => (short)(src >> 16);

            
        [MethodImpl(Inline)]
        public static ushort hi(in uint src)
            => (ushort)(src >> 16); 
            
        [MethodImpl(Inline)]
        public static int hi(in long src)
            => (int)(src >> 32);


        [MethodImpl(Inline)]
        public static uint hi(in ulong src)
            => (uint)(src >> 32);
    }

}