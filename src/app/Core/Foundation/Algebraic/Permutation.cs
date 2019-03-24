//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using static corefunc;
    /// <summary>
    /// Represents a transposition in the context of a permutation
    /// </summary>
    public readonly struct Transposition<N>
    {

    }
    
    public readonly struct Permutaton<N>
        where N : TypeNat, new()        
    {
        readonly Slice<(int k, int v)> assigments;

        public Permutaton(params (int k, int v)[] assigments)
            => this.assigments = assigments;

        public int map(int index)            
            =>  first(assigments, a => a.k == index).trymap(a => a.v).extract(index);
    }


}