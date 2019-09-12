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
    /// Defines mod/div operations
    /// </summary>
    /// <remarks>
    /// The efficiency of the mod/div operations with natural modulus is due to https://github.com/lemire/fastmod
    /// </remarks>
     public struct Mod
     {
        /// <summary>
        /// Computes r = a*b + c (mod m) for nonzero unsigned integers a < m and b < m
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="c">The third operand</param>
        /// <param name="m">The modulus</param>
        [MethodImpl(Inline)]
        public static uint fma(uint a, uint b, uint c, uint m) 
            => (uint) (((ulong)a*(ulong)b + c) % m);

        /// <summary>
        /// Computes r = a*b + c (mod m) for nonzero unsigned 64-bit integers a < m and b < m
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="c">The third operand</param>
        /// <param name="m">The modulus</param>
        [MethodImpl(Inline)]
        public static ulong fma(ulong a, ulong b, ulong c, ulong m) 
            => (a*b + c) % m;

        /// <summary>
        /// Computes r = a*b + c (mod m) for 64-bit floating-point values a < m and b < m
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <param name="c">The third operand</param>
        /// <param name="m">The modulus</param>
        /// <remarks>
        /// Algorithm taken from SSJ; see LICENSE file in this project root
        /// </remarks>
        public static double fma (double a, double b, double c, double m) 
        {
            const double two17 = 131072.0;
            
            const double two53 = 9007199254740992.0;

            int a1;
            double v = a * b + c;
            if (v >= two53 || v <= -two53 ) 
            {
                a1 = (int)(a / two17);
                a -= a1 * two17;
                v  = a1 * b;
                a1 = (int)(v / m);
                v -= a1 * m;
                v  = v * two17 + a * b + c;
            }
            a1 = (int)(v / m);
            
            if ((v -= a1 * m) < 0.0)
                return v += m;
            else
                return v;
        }

        /// <summary>
        /// Constructs a modulus operator with a persistent type-natural divisor
        /// </summary>
        /// <param name="n">The divisor</param>
        [MethodImpl(Inline)]
        public static Mod<N> Define<N>(N n = default)
            where N : ITypeNat, new()
                => new Mod<N>();

        [MethodImpl(Inline)]
        public static Mod<N> Define<N>(uint state, N n = default)
            where N : ITypeNat, new()
                => Mod<N>.Define(state);
        
        /// <summary>
        /// Constructs a modulus operator with a persistent divisor
        /// </summary>
        /// <param name="n">The divisor</param>
        [MethodImpl(Inline)]
        public static Mod Define(uint n, uint state)
            => new Mod(n,state);

        /// <summary>
        /// Increments the source operand in-place
        /// </summary>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline)]
        public static Mod operator ++(Mod src)
        {
            if(src.state == src.stateMax)
            {
                src.state = 0;
                return src;
            }
            else
            {
                ++src.state;
                return src;
            }            
        }

        /// <summary>
        /// Decrements the source operand in-place
        /// </summary>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline)]
        public static Mod operator --(Mod src)
        {
            if(src.state == 0u)
                src.state = src.stateMax;
            else
                --src.state;
            return src;
        }

        [MethodImpl(Inline)]
        public static Mod operator +(Mod lhs, Mod rhs)
            => Define(lhs.n, lhs.state + rhs.state);

        [MethodImpl(Inline)]
        public static Mod operator *(Mod lhs, Mod rhs)
            => Define(lhs.n, lhs.state * rhs.state);

        [MethodImpl(Inline)]
        public static bool operator ==(Mod lhs, Mod rhs)
            => lhs.state == rhs.state && lhs.n == rhs.n;

        [MethodImpl(Inline)]
        public static bool operator !=(Mod lhs, Mod rhs)
            => lhs.state != rhs.state&& lhs.n == rhs.n;


        [MethodImpl(Inline)]
        Mod(uint n, uint state)
        {
            this.n = n;
            this.M = UInt64.MaxValue / n + 1;
            this.state = state;
            this.stateMax = n - 1;
        }

        readonly ulong M;

        /// <summary>
        /// Specifies the divisor for which the modulus was constructed
        /// </summary>
        public readonly uint n;
        
        uint state;

        /// <summary>
        /// The maximum state value
        /// </summary>
        readonly uint stateMax;

        /// <summary>
        /// Returns the current state
        /// </summary>
        public uint State
            => state;            

        /// <summary>
        /// Computes a % n
        /// </summary>
        /// <param name="a">The dividend</param>
        [MethodImpl(Inline)]
        public uint mod(uint a)
            => (uint) UMul.mulHi(M * a, n);

        /// <summary>
        /// Computes the quotient a / n
        /// </summary>
        /// <param name="a">The dividend</param>
        [MethodImpl(Inline)]
        public uint div(uint a)        
            => (uint) UMul.mulHi(M, a);

        /// <summary>
        /// Computes the quotient and remainder
        /// </summary>
        /// <param name="a">The dividend</param>
        /// <param name="rem">The remainder</param>
        [MethodImpl(Inline)]
        public uint divrem(uint a, out uint rem)
        {
            rem = mod(a);
            return div(a);
        }

        /// <summary>
        /// Computes whether a % n == 0
        /// </summary>
        /// <param name="a">The dividend</param>
        [MethodImpl(Inline)]
        public bool divisible(uint a)
            => a * M <= M - 1; 

        [MethodImpl(Inline)]
        public string Format()
            => $"{state}(mod {n})";

        public override int GetHashCode()
            => (int)(state | n);

        public override bool Equals(object rhs)
            => rhs is Mod x ? x.state == state : false;

        public override string ToString() 
            => Format();
    }


}