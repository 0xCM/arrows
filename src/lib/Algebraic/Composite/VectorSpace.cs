//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    partial class Operative
    {
        /// <summary>
        /// Characterizes operational aspects of a N-dimensional vector space over 
        /// a field K inhabited by vectors from and abelian group A
        /// </summary>
        /// <typeparam name="N">The dimension type</typeparam>
        /// <typeparam name="K">The field type</typeparam>
        /// <typeparam name="A">The indidual type</typeparam>
        public interface VectorSpace<N,K,A> : LeftModule<K,A>
            where K : Field<K>, new()
            where A : GroupA<A>, new()
            where N : TypeNat, new()
        {

        }
            
    }


}