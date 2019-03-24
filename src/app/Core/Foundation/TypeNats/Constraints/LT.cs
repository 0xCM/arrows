//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using static corefunc;

    partial class Traits
    {

        /// <summary>
        /// Requires n1:T1 & n2:T2 => n1 < T2
        /// </summary>
        public interface LT<K1,K2> : NatConstraint<K1,K2>
            where K1: TypeNat, new()
            where K2: TypeNat, new()
        {
            
        }
    }

    /// <summary>
    /// Reifies evidence that n1:T1 & n2:T2 => n1 < T2
    /// </summary>
    public readonly struct LT<T1,T2> : Traits.LT<T1,T2>
        where T1: TypeNat, new()
        where T2: TypeNat, new()
    {

    }
}