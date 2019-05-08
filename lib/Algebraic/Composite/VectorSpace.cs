//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Operative;
    
    /// <summary>
    /// Characterizes operational aspects of a N-dimensional vector space over 
    /// a field K inhabited by vectors from and abelian group A
    /// </summary>
    /// <typeparam name="N">The dimension type</typeparam>
    /// <typeparam name="K">The field type</typeparam>
    /// <typeparam name="G">The indidual type</typeparam>
    public interface IVectorSpaceOps<N,K,G> : ILeftModuleOps<K,G>
        where N : ITypeNat, new()
        where G : IGroupAOps<G>, new()
        where K : IFieldOps<K>, new()
    {

    }


}