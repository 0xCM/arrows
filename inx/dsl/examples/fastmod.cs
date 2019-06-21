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


    /// <summary>
    /// Partial port of https://github.com/lemire/fastmod
    /// </summary>
    public static class FastMod
    {
        const ulong FF = 0xFFFFFFFFFFFFFFFFul;

        [MethodImpl(Inline)]
        public static ulong mul128_u32(ulong lowbits, uint d) 
            => dinx.umulh(lowbits, d);

        [MethodImpl(Inline)]
        public static UInt128 mul128_u64(ulong lhs, ulong rhs)
            => dinx.umul128(lhs,rhs, out UInt128 _);


        // M = ceil( (1<<64) / d ), d > 0
        [MethodImpl(Inline)]
        public static ulong computeM_u32(uint d)         
            => FF / d + 1;        
        

        // fastmod computes (a % d) given precomputed M
        [MethodImpl(Inline)]
        public static uint mod(uint a, ulong M, uint d) 
            => (uint)mul128_u32(M * a, d);

        // fastmod computes (a / d) given precomputed M for d>1
        [MethodImpl(Inline)]
        public static uint div(uint a, ulong M) 
            => (uint)mul128_u32(M, a);

        // given precomputed M, checks whether n % d == 0
        [MethodImpl(Inline)]
        public static bool is_divisible(uint n, ulong M) 
            => n * M <= M - 1;


    }

}