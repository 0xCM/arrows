//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using static corefunc;
    
    partial class Traits
    {
        /// <summary>
        /// Characterizes a nonzero natural number
        /// </summary>
        /// <typeparam name="K">A nonzero nat type</typeparam>
        public interface Nonzero<K> : NatConstraint<K>
            where K : TypeNat, new()
        {

        }

    }

    /// <summary>
    /// Reifies evidence that k != 0
    /// </summary>
    public readonly struct Nonzero<K> : Traits.Nonzero<K>
        where K: TypeNat, new()
    {

    }

}