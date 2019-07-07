//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    

    public static class FillVec
    {
        /// <summary>
        /// Loads a 128-bit vector where each component is set to the same value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Vec128<byte> FillVec128(this byte src)
            => Vec128.define(src);

        /// <summary>
        /// Loads a 128-bit vector where each component is set to the same value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Vec128<sbyte> FillVec128(this sbyte src)
            => Vec128.define(src);

        /// <summary>
        /// Loads a 128-bit vector where each component is set to the same value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Vec128<short> FillVec128(this short src)
            => Vec128.define(src);

        /// <summary>
        /// Loads a 128-bit vector where each component is set to the same value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> FillVec128(this ushort src)
            => Vec128.define(src);

        /// <summary>
        /// Loads a 128-bit vector where each component is set to the same value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Vec128<int> FillVec128(this int src)
            => Vec128.define(src);

        /// <summary>
        /// Loads a 128-bit vector where each component is set to the same value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> FillVec128(this uint src)
            => Vec128.define(src);

        /// <summary>
        /// Loads a 128-bit vector where each component is set to the same value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Vec128<long> FillVec128(this long src)
            => Vec128.define(src);

        /// <summary>
        /// Loads a 128-bit vector where each component is set to the same value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> FillVec128(this ulong src)
            => Vec128.define(src);

        /// <summary>
        /// Loads a 128-bit vector where each component is set to the same value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Vec128<float> FillVec128(this float src)
            => Vec128.define(src);

        /// <summary>
        /// Loads a 128-bit vector where each component is set to the same value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Vec128<double> FillVec128(this double src)
            => Vec128.define(src);

        /// <summary>
        /// Loads a 256-bit vector where each component is set to the same value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Vec256<byte> FillVec256(this byte src)
            => Vec256.define(src);

        /// <summary>
        /// Loads a 256-bit vector where each component is set to the same value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Vec256<sbyte> FillVec256(this sbyte src)
            => Vec256.define(src);

        /// <summary>
        /// Loads a 256-bit vector where each component is set to the same value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Vec256<short> FillVec256(this short src)
            => Vec256.define(src);

        /// <summary>
        /// Loads a 256-bit vector where each component is set to the same value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> FillVec256(this ushort src)
            => Vec256.define(src);

        /// <summary>
        /// Loads a 256-bit vector where each component is set to the same value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Vec256<int> FillVec256(this int src)
            => Vec256.define(src);

        /// <summary>
        /// Loads a 256-bit vector where each component is set to the same value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> FillVec256(this uint src)
            => Vec256.define(src);

        /// <summary>
        /// Loads a 256-bit vector where each component is set to the same value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Vec256<long> FillVec256(this long src)
            => Vec256.define(src);

        /// <summary>
        /// Loads a 256-bit vector where each component is set to the same value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> FillVec256(this ulong src)
            => Vec256.define(src);

        /// <summary>
        /// Loads a 256-bit vector where each component is set to the same value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Vec256<float> FillVec256(this float src)
            => Vec256.define(src);

        /// <summary>
        /// Loads a 256-bit vector where each component is set to the same value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static Vec256<double> FillVec256(this double src)
            => Vec256.define(src);

    }

}
