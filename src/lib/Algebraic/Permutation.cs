//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static zcore;

    /// <summary>
    /// Represents a transposition in the context of a permutation
    /// </summary>
    /// <remarks>
    /// A transposition (l,r) is interpreted as a function composition 
    /// that carries the l-value (from the domain) to the r-value
    /// (in the l-relative codomain) and then the r-value to the l-value
    /// (in the r-relative codomain & l-relative domain). So, if
    /// a function f sends l to r and a function g sends r to l then
    /// the transposition t is the function t(l) = g(f(l)) == l. 
    /// </remarks>
    public readonly struct Transposition<N> : Traits.Formattable
    {
        public Transposition(ulong left, ulong right)
        {
            this.left = left;
            this.right = right;
        }
        
        public ulong left {get;}
        
        public ulong right {get;}

        public string format()
            => paren(space(embrace(left),embrace(right)));
    }

    /// <summary>
    /// See https://en.wikipedia.org/wiki/Inversion_(discrete_mathematics)
    /// </summary>
    public readonly struct Inversion<N>
    {

    }
    
    /// <summary>
    /// Defines a permutation as a bijective function 
    /// from the set of natural numbers {1,2,..., N} onto itself
    /// </summary>
    /// <remarks>
    /// See https://en.wikipedia.org/wiki/Permutation
    /// </remarks>
    public readonly struct Permutaton<N>
        where N : TypeNat, new()        
    {
        readonly (ulong k, ulong v)[] assigments;

        public Permutaton(params (ulong k, ulong v)[] assigments)
            => this.assigments = assigments;

        public ulong map(ulong index)            
            =>  first(assigments, a => a.k == index).TryMap(a => a.v).ValueOrDefault(index);
    }


}