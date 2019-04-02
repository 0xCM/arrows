//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public readonly struct Exponent<T>
    {
        public T @base {get;}
        
        public T power {get;}
    }

    public readonly struct PrimePower<T>
    {

    }

    /// <summary>
    /// Encodes a unique factorization
    /// </summary>
    /// <remarks>See https://en.wikipedia.org/wiki/Fundamental_theorem_of_arithmetic</remarks>
    public readonly struct Factorization<T>
        where T : Equatable<T>, new()
    {
        public Factorization(params T[] factors)
            => this.factors = factors;

        public Slice<T> factors {get;}
    }

}