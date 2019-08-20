//-----------------------------------------------------------------------------
// Copyrhs   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
        
    using static zfunc;    

    /// <summary>
    /// Represents div/mod operations for a divisor of type N; This type forms a commutative
    /// ring over the set of least residues {0,...,N-1}, i.e. the ring of integers modulo N,
    /// typically denoted Z/nZ. Moreover, Z/nZ is a field iff n is prime
    /// </summary>
    public struct Mod<N>
        where N : ITypeNat, new()
    {        
        uint state;

        /// <summary>
        /// The fixed 64-bit modulus for the generic closure
        /// </summary>
        public static readonly ulong M64 = new N().value;
        
        /// <summary>
        /// The fixed 32-bit modulus for the generic closure
        /// </summary>
        public static readonly uint M32 = (uint)M64;

        /// <summary>
        /// The fixed modulus reciprocal
        /// </summary>
        static readonly double MR = 1.0 / (double)M64;

        /// <summary>
        /// Constructs a modulus with a specified state
        /// </summary>
        /// <param name="state">The initial state</param>
        [MethodImpl(Inline)]
        public static Mod<N> Define(uint state = 0)
            => new Mod<N>(state <= StateMax ? state : mod(state));
        
        /// <summary>
        /// Implicitly constructs a typed modulus with an initial state, reducing as necessary
        /// </summary>
        /// <param name="state">The intial state</param>
        /// <typeparam name="N">The modulus type</typeparam>
        [MethodImpl(Inline)]
        public static implicit operator Mod<N>(uint state)
            => Define(state);

        /// <summary>
        /// Implicitly constructs a modulus with an initial state from a signed integer, converting/reducing as necessary
        /// </summary>
        /// <param name="state">The intial state</param>
        /// <typeparam name="N">The modulus type</typeparam>
        [MethodImpl(Inline)]
        public static implicit operator Mod<N>(int state)
            => Define((uint)state);

        /// <summary>
        /// Implicitly extracts the state value as an unsigned integer from the source
        /// </summary>
        /// <param name="src">The source modulus</param>
        [MethodImpl(Inline)]
        public static implicit operator uint(Mod<N> src)
            => src.state;

        /// <summary>
        /// Implicitly extracts the state value as a signed integer from the source
        /// </summary>
        /// <param name="src">The source modulus</param>
        [MethodImpl(Inline)]
        public static implicit operator int(Mod<N> src)
            => (int)src.state;
            
        /// <summary>
        /// Increments the source operand in-place
        /// </summary>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline)]
        public static Mod<N> operator ++(Mod<N> src)
        {
            if(src.state == StateMax)
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
        public static Mod<N> operator --(Mod<N> src)
        {
            if(src.state == 0u)
                src.state = StateMax;
            else
                --src.state;
            return src;
        }

        /// <summary>
        /// Subtracts the second operand from the first
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        [MethodImpl(Inline)]
        public static Mod<N> operator -(Mod<N> lhs, Mod<N> rhs)
        {            
            if(lhs.state >= rhs.state)
                return new Mod<N>(lhs.state - rhs.state);
            else
                return new Mod<N>(M32 - (rhs.state - lhs.state));            
        }

        [MethodImpl(Inline)]
        public static Mod<N> operator +(Mod<N> lhs, Mod<N> rhs)
            => Define(lhs.state + rhs.state);

        [MethodImpl(Inline)]
        public static Mod<N> operator *(Mod<N> lhs, Mod<N> rhs)
            => Define(lhs.state * rhs.state);

        [MethodImpl(Inline)]
        public static bool operator ==(Mod<N> lhs, Mod<N> rhs)
            => lhs.state == rhs.state;

        [MethodImpl(Inline)]
        public static bool operator !=(Mod<N> lhs, Mod<N> rhs)
            => lhs.state != rhs.state;

        /// <summary>
        /// Computes a % n
        /// </summary>
        /// <param name="a">The dividend</param>
        [MethodImpl(Inline)]
        public static uint mod(uint a)
            => _Mod.mod(a);

        /// <summary>
        /// Computes the quotient a / n
        /// </summary>
        /// <param name="a">The dividend</param>
        [MethodImpl(Inline)]
        public static uint div(uint a)        
            => _Mod.div(a);

        /// <summary>
        /// Computes the quotient a / n and remainder a % n
        /// </summary>
        /// <param name="a">The dividend</param>
        [MethodImpl(Inline)]
        public static uint divrem(uint a, out uint r)        
            => _Mod.divrem(a, out r);

        /// <summary>
        /// Computes whether a % n == 0
        /// </summary>
        /// <param name="a">The dividend</param>
        [MethodImpl(Inline)]
        public static bool divisible(uint a)
            => _Mod.divisible(a);        

        /// <summary>
        /// Computes the modular sum of the operands
        /// </summary>
        /// <param name="a">The lefdt operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline)]
        public static ulong add(ulong a, ulong b)
        {
            if (b == 0)  
                return a;                
            var c = M64 - b;
            return a >= c ? a - c : M64 - c + a;
        }

        /// <summary>
        /// Computes the modular difference of the operands
        /// </summary>
        /// <param name="a">The lefdt operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline)]
        public static ulong sub(ulong a, ulong b)
            => a >= b ? a - b : M64 - b + a;

        /// <summary>
        /// Computes the modular product of the operands
        /// </summary>
        /// <param name="a">The lefdt operand</param>
        /// <param name="b">The right operand</param>
        /// <remarks>Follows the approach of Arndt in Matters Computational, Chapter 39: Modular arithmetic and some number theory</remarks>
        [MethodImpl(Inline)]
        public static ulong mul(ulong a, ulong b)
        {            
            var x = a * b;
            var y = (ulong)((double)a*(double)b*MR +.5);
            var r = x - y;
            return r < 0 ? r + M64 : r;
        }

        /// <summary>
        ///  Modular increment
        /// </summary>
        /// <param name="a">The source operand</param>
        [MethodImpl(Inline)]
        public static ulong inc(ulong a)
            => a == M64 - 1 ? 0 : a + 1;

        /// <summary>
        ///  Modular decrement
        /// </summary>
        /// <param name="a">The source operand</param>
        [MethodImpl(Inline)]
        public static ulong dec(ulong a)
            => a == 0 ? M64 - 1 : a - 1;
        
        [MethodImpl(Inline)]
        public static ulong negate(ulong a)
            => a == 0 ? 0 : M64 - a;

        [MethodImpl(Inline)]
        Mod(uint state)
            => this.state = state;

        /// <summary>
        /// Returns the current state
        /// </summary>
        public uint State
        {
            [MethodImpl(Inline)]
            get => state;            
        }

        [MethodImpl(Inline)]
        public Mod<N> Invert()
            => new Mod<N>(Inverse(state));

        [MethodImpl(Inline)]
        public string Format()
            => $"{state}(mod {_Mod.n})";

        public override int GetHashCode()
            => (int)(state | _Mod.n);

        public override bool Equals(object rhs)
            => rhs is Mod<N> x ? x.state == state : false;

        public override string ToString() 
            => Format();

        /// <summary>
        /// The maximum state value
        /// </summary>
        static readonly uint StateMax = M32 - 1;

        /// <summary>
        /// The equivalent untyped modulus with nullary state
        /// </summary>
        static readonly Mod _Mod = Mod.Define(M32, 0);

        static uint[,] ProductTable()
        {
            var products = new uint[M32,M32];
            for(var i = 1u; i<M32; i++)
            for(var j = 1u; j<M32; j++)
                products[i,j] = _Mod.mod(i*j);                
            return products;            
        }

        static uint Inverse(uint a)
        {
            var prod = Products.Value;
            for(var i=1u; i<M32; i++)
                if(prod[i,a] == 1u) return i;
         
            throw new Exception($"Multiplicative inverse for {a} not found. Are you sure {M32} is prime?");
        }
        
        static Lazy<uint[,]> Products = new Lazy<uint[,]>(ProductTable);
    }
}