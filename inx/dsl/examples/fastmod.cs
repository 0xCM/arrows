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
        static ulong mul128_u32(ulong lowbits, uint d) 
            => dinx.umulh(lowbits, d);

        [MethodImpl(Inline)]
        static UInt128 mul128_u64(ulong lhs, ulong rhs)
            => dinx.umul128(lhs,rhs, out UInt128 _);

        [MethodImpl(Inline)]
        public static ulong computeM_u32(uint d)         
            => FF / d + 1;                

        // fastmod computes (a % d) given precomputed M
        [MethodImpl(Inline)]
        public static uint mod_u32(uint a, ulong M, uint d) 
            => (uint)mul128_u32(M * a, d);

        // fastmod computes (a / d) given precomputed M for d>1
        [MethodImpl(Inline)]
        public static uint div_u32(uint a, ulong M) 
            => (uint) mul128_u32(M, a);

        // given precomputed M, checks whether n % d == 0
        [MethodImpl(Inline)]
        public static bool divisible_u32(uint n, ulong M) 
            => n * M <= M - 1;

        public static void Example()
        {
            var m = FastMod.computeM_u32(4);
            var x = FastMod.mod_u32(17, m, 4); //17 % 4
            var y = FastMod.div_u32(20,m); // 20/4
            var id = FastMod.divisible_u32(16,m); //16 % 4 == 0
            print($"17 % 4 = {x}");
            print($"20 / 4 = {y}");
            print($"16 % 4 == 0 ? {id}");
        }
    }

    /// <summary>
    /// Provides a means for efficiently computing a % n and a / n for a fixed n
    /// </summary>
    public readonly struct Mod
    {
        /// <summary>
        /// Constructs a modulus operator with a persistent and type-natural divisor
        /// </summary>
        /// <param name="n">The divisor</param>
        [MethodImpl(Inline)]
        public static Mod<N> Define<N>(N n = default)
            where N : ITypeNat, new()
                => new Mod<N>();

        /// <summary>
        /// Constructs a modulus operator with a persistent divisor
        /// </summary>
        /// <param name="n">The divisor</param>
        [MethodImpl(Inline)]
        public static Mod Define(uint n)
            => new Mod(n);
        
        [MethodImpl(Inline)]
        private Mod(uint n)
        {
            this.n = n;
            this.M = FastMod.computeM_u32(n);
        }

        readonly ulong M;

        /// <summary>
        /// Specifies the divisor for which the modulus was constructed
        /// </summary>
        public readonly uint n;

        /// <summary>
        /// Computes a % n
        /// </summary>
        /// <param name="a">The dividend</param>
        [MethodImpl(Inline)]
        public uint Rem(uint a)
            => FastMod.mod_u32(a, M, n);

        /// <summary>
        /// Computes the quotient a / n
        /// </summary>
        /// <param name="a">The dividend</param>
        [MethodImpl(Inline)]
        public uint Quotient(uint a)        
            => FastMod.div_u32(a, M);

        /// <summary>
        /// Computes whether a % n == 0
        /// </summary>
        /// <param name="a">The dividend</param>
        [MethodImpl(Inline)]
        public bool Divisible(uint a)
            => FastMod.divisible_u32(a, M);
    }

    /// <summary>
    /// Provides a means for efficiently computing a % N and a / N
    /// </summary>
    public readonly struct Mod<N>
        where N : ITypeNat, new()
    {
        static readonly uint _N = (uint)new N().value;
        
        static readonly ulong M = FastMod.computeM_u32(_N);

        /// <summary>
        /// Specifies the divisor for which the modulus was constructed
        /// </summary>
        public readonly uint n
            => _N;

        /// <summary>
        /// Computes a % n
        /// </summary>
        /// <param name="a">The dividend</param>
        [MethodImpl(Inline)]
        public uint Rem(uint a)
            => FastMod.mod_u32(a, M, n);

        /// <summary>
        /// Computes the quotient a / n
        /// </summary>
        /// <param name="a">The dividend</param>
        [MethodImpl(Inline)]
        public uint Quotient(uint a)        
            => FastMod.div_u32(a, M);

        /// <summary>
        /// Computes whether a % n == 0
        /// </summary>
        /// <param name="a">The dividend</param>
        [MethodImpl(Inline)]
        public bool Divisible(uint a)
            => FastMod.divisible_u32(a, M);
    }
}