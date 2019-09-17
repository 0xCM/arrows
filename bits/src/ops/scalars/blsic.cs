//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;

    using static System.Runtime.Intrinsics.X86.Bmi1;
    using static System.Runtime.Intrinsics.X86.Bmi1.X64;
 
    using static zfunc;

    partial class Bits
    {                

        /// <summary>
        /// Isolate least set bit and complement, computed by dst := ~src | (src - 1),
        /// where all bits in the target are set except for the least set bit in the source
        /// For example, [11101010] |> blisc = [11111101]
        /// </summary>
        /// <param name="src">The source valeu</param>
        [MethodImpl(Inline)]
        public static byte blsic(byte src)
            => (byte)(~src | (src - 1));

        /// <summary>
        /// Isolate least set bit and complement, computed by dst := ~src | (src - 1),
        /// where all bits in the target are set except for the least set bit in the source
        /// For example, [11101010] |> blisc = [11111101]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ushort blsic(ushort src)
            => (ushort)(~src | (src - 1));

        /// <summary>
        /// Isolate least set bit and complement, computed by dst := ~src | (src - 1),
        /// where all bits in the target are set except for the least set bit in the source
        /// For example, [11101010] |> blisc = [11111101]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static uint blsic(uint src)
            => ~src | (src - 1);

        /// <summary>
        /// Isolate least set bit and complement, computed by dst := ~src | (src - 1),
        /// where all bits in the target are set except for the least set bit in the source
        /// For example, [11101010] |> blisc = [11111101]
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static ulong blsic(ulong src)
            => ~src | (src - 1);

    }

}