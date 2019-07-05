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
        /// Retrieves the operand's most significant bit
        /// </summary>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline)]
        public static Bit hibit(in sbyte src)
            => test(in src, SizeOf<sbyte>.BitSize - 1);

        /// <summary>
        /// Retrieves the operand's most significant bit
        /// </summary>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline)]
        public static Bit hibit(in byte src)
            => test(in src, SizeOf<byte>.BitSize - 1);

        /// <summary>
        /// Retrieves the operand's most significant bit
        /// </summary>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline)]
        public static Bit hibit(in short src)
            => test(in src, SizeOf<short>.BitSize - 1);

        /// <summary>
        /// Retrieves the operand's most significant bit
        /// </summary>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline)]
        public static Bit hibit(in ushort src)
            => test(in src, SizeOf<ushort>.BitSize - 1);

        /// <summary>
        /// Retrieves the operand's most significant bit
        /// </summary>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline)]
        public static Bit hibit(in int src)
            => test(in src, SizeOf<int>.BitSize - 1);

        /// <summary>
        /// Retrieves the operand's most significant bit
        /// </summary>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline)]
        public static Bit hibit(in uint src)
            => test(in src, SizeOf<uint>.BitSize - 1);

        /// <summary>
        /// Retrieves the operand's most significant bit
        /// </summary>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline)]
        public static Bit hibit(in long src)
            => test(in src, SizeOf<long>.BitSize - 1);

        /// <summary>
        /// Retrieves the operand's most significant bit
        /// </summary>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline)]
        public static Bit hibit(in ulong src)
            => test(in src, SizeOf<ulong>.BitSize - 1);

        /// <summary>
        /// Retrieves the operand's most significant bit
        /// </summary>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline)]
        public static Bit hibit(in float src)
            => test(in src, SizeOf<float>.BitSize - 1);

        /// <summary>
        /// Retrieves the operand's most significant bit
        /// </summary>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline)]
        public static Bit hibit(in double src)
            => test(in src, SizeOf<double>.BitSize - 1);

    }

}