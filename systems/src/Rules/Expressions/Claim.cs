//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
    
    
    using static zfunc;

    /// <summary>
    /// Defines an assertion of truth
    /// </summary>
    public readonly struct ClaimExpr<T> : IRuleExpr
    {
        public ClaimExpr(string name, Func<T,T,bool> predicate)
        {
            this.Name = name;
            this.Predicate = predicate;
        }

        /// <summary>
        /// The predicate that adjudicates truth
        /// </summary>
        public Func<T,T,bool> Predicate {get;}
        
        /// <summary>
        /// The name/label used to identify the claim
        /// </summary>
        public string Name {get;}

        public string Evaluate(T lhs, T rhs)
        {
            if(!Predicate(lhs,rhs))
                throw new Exception($"The claim {lhs} {Name} {rhs} does not hold");
            else
                return $"The claim {lhs} {Name} {rhs} is satisfied";
        }
    }

}