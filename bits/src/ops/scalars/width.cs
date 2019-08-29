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
    
    partial class Bits
    {
        /// <summary>
        /// Computes the minimal number of bits required to represent the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitSize width(in byte src)
            => 8 - nlz(in src);

        /// <summary>
        /// Computes the minimal number of bits required to represent the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitSize width(in ushort src)
            => 16 - nlz(in src);

        /// <summary>
        /// Computes the minimal number of bits required to represent the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitSize width(in uint src)
            => 32 - nlz(in src);

        /// <summary>
        /// Computes the minimal number of bits required to represent the source value
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline)]
        public static BitSize width(in ulong src)
            => 64 - nlz(in src);
    }

}