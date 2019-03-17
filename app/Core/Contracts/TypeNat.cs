//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{
    using System;
    using System.Numerics;



    public interface TypeNat
    {
        int natval {get;}
    }

    public interface NatSeq : TypeNat
    {
        
    }


    public interface TypeNat<T0> : TypeNat 
    {

    }

    public interface TypeNat<T0,T1> : TypeNat<T0>
    {
        T1 next {get;}
    }

}