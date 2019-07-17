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
    /// Enbles efficient computation of a % n and a / n for a fixed n
    /// </summary>
    /// <remarks>
    /// The efficiency of the mod/div operations is due to https://github.com/lemire/fastmod
    /// </remarks>
     public struct Mod
     {
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
            => (uint) dinx.umulHi(M * a, n);

        /// <summary>
        /// Computes the quotient a / n
        /// </summary>
        /// <param name="a">The dividend</param>
        [MethodImpl(Inline)]
        public uint div(uint a)        
            => (uint) dinx.umulHi(M, a);

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

    /// <summary>
    /// Represents div/mod operations for a divisor of type N; This type forms a commutative
    /// ring over the set of least residues {0,...,N-1}, i.e. the ring of integers modulo N,
    /// typically denoted Z/nZ. Moreover, Z/nZ is a field iff n is prime
    /// </summary>
    public struct Mod<N>
        where N : ITypeNat, new()
    {        
        Mod(uint state)
            => this.state = state;

        uint state;

        /// <summary>
        /// Returns the current state
        /// </summary>
        public uint State
            => state;            

        [MethodImpl(Inline)]
        public Mod<N> Invert()
            => new Mod<N>(Inverse(state));

        /// <summary>
        /// Constructs a modulus with a specified state
        /// </summary>
        /// <param name="state">The initial state</param>
        [MethodImpl(Inline)]
        public static Mod<N> Define(uint state = 0)
            => new Mod<N>(state <= StateMax ? state : mod(state));
        
        /// <summary>
        /// Implicitely constructs a typed modulus with an initial state,
        /// reducing as necessary
        /// </summary>
        /// <param name="state">The intial state</param>
        /// <typeparam name="N">The modulus type</typeparam>
        [MethodImpl(Inline)]
        public static implicit operator Mod<N>(uint state)
            => Define(state);

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
                return new Mod<N>(_N - (rhs.state - lhs.state));            
        }
            
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
        /// Computes whether a % n == 0
        /// </summary>
        /// <param name="a">The dividend</param>
        [MethodImpl(Inline)]
        public static bool divisible(uint a)
            => _Mod.divisible(a);        

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
        /// The divisor expressed as an integer
        /// </summary>
        static readonly uint _N = (uint)new N().value;

        /// <summary>
        /// The maximum state value
        /// </summary>
        static readonly uint StateMax = _N - 1;

        /// <summary>
        /// The equivalent untyped modulus with nullary state
        /// </summary>
        static readonly Mod _Mod = Mod.Define(_N, 0);

        static uint[,] ProductTable()
        {
            var products = new uint[_N,_N];
            for(var i = 1u; i<_N; i++)
            for(var j = 1u; j<_N; j++)
                products[i,j] = _Mod.mod(i*j);                
            return products;            
        }

        static uint Inverse(uint a)
        {
            var prod = Products.Value;
            for(var i=1u; i<_N; i++)
                if(prod[i,a] == 1u) return i;
         
            throw new Exception($"Multiplicative inverse for {a} not found. Are you sure {_N} is prime?");
        }
        
        static Lazy<uint[,]> Products = new Lazy<uint[,]>(ProductTable);
    }

}