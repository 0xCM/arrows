//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
        
    using static zfunc;

    public readonly struct Claim<T>
    {
        public Claim(T lhs, T rhs, string name,  Func<T,T,bool> predicate)
        {
            this.name = name;
            this.lhs = lhs;            
            this.rhs = rhs;
            this.predicate = predicate;
        }

        Func<T,T,bool> predicate {get;}
        
        public string name {get;}
        public T lhs {get;}

        public T rhs {get;}

        public string demand()
        {
            if(!predicate(lhs,rhs))
                throw new Exception($"The claim {lhs} {name} {rhs} does not hold");
            else
                return $"The claim {lhs} {name} {rhs} is satisfied";
        }
    }

    public enum ClaimOpKind
    {
        Eq,
        
        EqItem,

        Neq,

        Lt,

        Gt,
        
        False,

        True,

        Fail,

        Nonzero
    }


}