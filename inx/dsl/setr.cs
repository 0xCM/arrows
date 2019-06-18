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
        [MethodImpl(Inline)]
        public static unsafe m256i _mm256_setr_epi8(
            sbyte x31, sbyte x30, sbyte x29, sbyte x28,  
            sbyte x27, sbyte x26, sbyte x25, sbyte x24, 
            sbyte x23, sbyte x22, sbyte x21, sbyte x20,
            sbyte x19, sbyte x18, sbyte x17, sbyte x16,
            sbyte x15, sbyte x14, sbyte x13, sbyte x12,  
            sbyte x11, sbyte x10, sbyte x9, sbyte x8, 
            sbyte x7, sbyte x6, sbyte x5, sbyte x4,
            sbyte x3, sbyte x2, sbyte x1, sbyte x0) 
                => Vec256.definer(
                    x31, x30, x29, x28, 
                    x27, x26, x25, x24,
                    x23, x22, x21, x20,
                    x19, x18, x17, x16,
                    x15, x14, x13, x12, 
                    x11, x10,  x9,  x8, 
                     x7,  x6,  x5,  x4,
                     x3,  x2,  x1,  x0);
 
        [MethodImpl(Inline)]
        public static unsafe m256i _mm256_setr_epi16(
            short x15, short x14, short x13, short x12,  
            short x11, short x10, short x9, short x8, 
            short x7, short x6, short x5, short x4,
            short x3, short x2, short x1, short x0)
                => Vec256.definer(
                    x15, x14, x13, x12, 
                    x11, x10,  x9,  x8, 
                     x7,  x6,  x5,  x4,
                     x3,  x2,  x1,  x0);
                    

        [MethodImpl(Inline)]
        public static unsafe m256i _mm256_setr_epi32(
            int x7, int x6, int x5, int x4, int x3, int x2, int x1, int x0 )
                => Vec256.definer(x7, x6, x5, x4, x3, x2, x1, x0);

        [MethodImpl(Inline)]
        public static m256i _mm256_setr_epi64x(long x3, long x2, long x1, long x0)
            => Vec256.definer(x3, x2, x1, x0);

    }

}