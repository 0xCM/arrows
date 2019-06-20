//-----------------------------------------------------------------------------
// Copyrhs   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
        
    using static zfunc;    

    partial class x86
    {
        /// <summary>
        /// Creates a vector for which all components have been initialized to a common value
        /// </summary>
        /// <param name="x">The value with which each component will be initialized</param>
        /// <intrinsic></intrinsic>
        [MethodImpl(Inline)]
        public static m256i _mm256_set1_epi8(sbyte x)
            => Vec256.define(x);

        /// <summary>
        /// Creates a vector for which all components have been initialized to a common value
        /// </summary>
        /// <param name="x">The value with which each component will be initialized</param>
        /// <intrinsic></intrinsic>
        [MethodImpl(Inline)]
        public static m256i _mm256_set1_epi8(byte x)
            => Vec256.define(x);


        /// <summary>
        /// Creates a vector for which all components have been initialized to a common value
        /// </summary>
        /// <param name="x">The value with which each component will be initialized</param>
        /// <intrinsic></intrinsic>
        [MethodImpl(Inline)]
        public static m256i _mm256_set1_epi16(short x)
            => Vec256.define(x);

        /// <summary>
        /// Creates a vector for which all components have been initialized to a common value
        /// </summary>
        /// <param name="x">The value with which each component will be initialized</param>
        /// <intrinsic></intrinsic>
        [MethodImpl(Inline)]
        public static m256i _mm256_set1_epi16(ushort x)
            => Vec256.define(x);

        /// <summary>
        /// Creates a vector for which all components have been initialized to a common value
        /// </summary>
        /// <param name="x">The value with which each component will be initialized</param>
        /// <intrinsic></intrinsic>
        [MethodImpl(Inline)]
        public static m256i _mm256_set1_epi32(int x)
            => Vec256.define(x);

        /// <summary>
        /// Creates a vector for which all components have been initialized to a common value
        /// </summary>
        /// <param name="x">The value with which each component will be initialized</param>
        /// <intrinsic></intrinsic>
        [MethodImpl(Inline)]
        public static m256i _mm256_set1_epi32(uint x)
            => Vec256.define(x);

        /// <summary>
        /// Creates a vector for which all components have been initialized to a common value
        /// </summary>
        /// <param name="x">The value with which each component will be initialized</param>
        /// <intrinsic></intrinsic>
        [MethodImpl(Inline)]
        public static m256i _mm256_set1_epi64x(long x)
            => Vec256.define(x);

        /// <summary>
        /// Creates a vector for which all components have been initialized to a common value
        /// </summary>
        /// <param name="x">The value with which each component will be initialized</param>
        /// <intrinsic></intrinsic>
        [MethodImpl(Inline)]
        public static m256i _mm256_set1_epi64x(ulong x)
            => Vec256.define(x);
    }

}