//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;



    public interface NatConstraint
    {

    }


    /// <summary>
    /// Characterizes a constraint on a nat
    /// </summary>
    /// <typeparam name="K1">The Nat type</typeparam>
    public interface NatConstraint<K1> : NatConstraint
        where K1 : TypeNat, new()
    {

    }
    
    /// <summary>
    /// Characterizes binary relationship between two nats
    /// </summary>
    /// <typeparam name="K1">The first nat type</typeparam>
    /// <typeparam name="K2">The second nat type</typeparam>
    public interface NatConstraint<K1,K2> : NatConstraint
        where K1 : TypeNat, new()
        where K2 : TypeNat
    {
        
    }

    /// <summary>
    /// Characterizes ternary relationship among three nats
    /// </summary>
    /// <typeparam name="K1">The first nat type</typeparam>
    /// <typeparam name="K2">The second nat type</typeparam>
    /// <typeparam name="K3">The third nat type</typeparam>
    public interface NatConstraint<K1,K2,K3> : NatConstraint
        where K1 : TypeNat, new()
        where K2 : TypeNat, new()
        where K3 : TypeNat, new()
    {
        
    }




}