//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core.Contracts
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using static corefunc;

    public interface NatConstraint
    {

    }
    
    /// <summary>
    /// Characterizes a constraint on a nat
    /// </summary>
    /// <typeparam name="K1">The Nat type</typeparam>
    public interface NatConstraint<K1> : NatConstraint
        where K1 : TypeNat
    {

    }
    
    /// <summary>
    /// Characterizes binary relationship between two nats
    /// </summary>
    /// <typeparam name="K1">The first nat type</typeparam>
    /// <typeparam name="K2">The second nat type</typeparam>
    public interface NatConstraint<K1,K2> : NatConstraint
        where K1 : TypeNat
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
        where K1 : TypeNat
        where K2 : TypeNat
        where K3 : TypeNat
    {
        
    }

    public static class NatConstraints
    {

        /// <summary>
        /// Characterizes equality between two nats
        /// </summary>
        /// <typeparam name="K1">The first nat type</typeparam>
        /// <typeparam name="K2">The second nat type</typeparam>
        public interface EQ<K1,K2> : NatConstraint<K1,K2>
            where K1 : TypeNat
            where K2 : TypeNat
        {
            
        }

        /// <summary>
        /// Characterizes inequality between two nats
        /// </summary>
        /// <typeparam name="K1">The first nat type</typeparam>
        /// <typeparam name="K2">The second nat type</typeparam>
        public interface NEQ<K1,K2> : NatConstraint<K1,K2>
            where K1 : TypeNat
            where K2 : TypeNat
        {
            
        }

        /// <summary>
        /// Characterizes a disjunction between two nat constraints:
        /// Given nats k1 and k2, One or both of the constraints c1
        /// and c2 hold
        /// </summary>
        /// <typeparam name="K1">The first nat type</typeparam>
        /// <typeparam name="K2">The second nat type</typeparam>
        /// <typeparam name="C1">The first constraint type</typeparam>
        /// <typeparam name="C2">The second constraint type</typeparam>
        public interface Or<K1,K2,C1,C2> : NatConstraint<K1,K2>
            where K1 : TypeNat
            where K2 : TypeNat
            where C1 : NatConstraint
            where C2 : NatConstraint
        {

        }

        /// <summary>
        /// Characterizes a conjunction between two nat constraints:
        /// Given nats k1 and k2, both constraints c1 and c2 hold
        /// </summary>
        /// <typeparam name="K1">The first nat type</typeparam>
        /// <typeparam name="K2">The second nat type</typeparam>
        /// <typeparam name="C1">The first constraint type</typeparam>
        /// <typeparam name="C2">The second constraint type</typeparam>
        public interface And<K1,K2,C1,C2> : NatConstraint<K1,K2>
            where K1 : TypeNat
            where K2 : TypeNat
            where C1 : NatConstraint
            where C2 : NatConstraint
        {

        }

        
        public interface LT<K1,K2> : NatConstraint<K1,K2>
            where K1 : TypeNat
            where K2 : TypeNat
        {
            
        }

        public interface LTEQ<K1,K2> : Or<K1,K2,LT<K1,K2>,EQ<K1,K2>>
            where K1 : TypeNat
            where K2 : TypeNat
        {
            
        }

        public interface GT<K1,K2> : NatConstraint<K1,K2>
            where K1 : TypeNat
            where K2 : TypeNat
        {
            
        }
        public interface GTEQ<K1,K2> : Or<K1,K2,GT<K1,K2>,EQ<K1,K2>>
            where K1 : TypeNat
            where K2 : TypeNat
        {
            
        }

        /// <summary>
        /// Characterizes a constraint that requires a nat to be nonzero
        /// </summary>
        /// <typeparam name="K">A nonzero nat type</typeparam>
        public interface Nonzero<K> : NatConstraint<K>
            where K : TypeNat
        {

        }

        /// <summary>
        /// Characterizes a constraint that requires a nat to be prime
        /// </summary>
        /// <typeparam name="K">A prime nat type</typeparam>
        public interface Prime<K> : NatConstraint<K>
            where K : TypeNat
        {

        }

        /// <summary>
        /// Characterizes a constraint that for nats k1 and k2, k1 + 1 = k2
        /// </summary>
        /// <typeparam name="K1">The first nat type</typeparam>
        /// <typeparam name="K2">The second nat type</typeparam>
        public interface Adjacent<K1,K2> : LT<K1,K2> 
            where K1 : TypeNat
            where K2 : TypeNat
        {


        }        

        /// <summary>
        /// Characterizes a relationship among three nats k1,k2 and k3 
        /// where k1 + k2 = k3
        /// </summary>
        /// <typeparam name="K1"></typeparam>
        /// <typeparam name="K2"></typeparam>
        /// <typeparam name="K3"></typeparam>
        public interface Sum<K1,K2,K3> : NatConstraint<K1,K2,K3>
            where K1 : TypeNat
            where K2 : TypeNat
            where K3 : TypeNat
        {

        }

        /// <summary>
        /// Characterizes a relationship among three nats k1,k2 and k3 
        /// where k1 * k2 = k3
        /// </summary>
        /// <typeparam name="K1"></typeparam>
        /// <typeparam name="K2"></typeparam>
        /// <typeparam name="K3"></typeparam>
        public interface Product<K1,K2,K3> : NatConstraint<K1,K2,K3>
            where K1 : TypeNat
            where K2 : TypeNat
            where K3 : TypeNat
        {

        }

        /// <summary>
        /// Characterizes a relationship among three nats k1,k2 and k3 
        /// where k1 % k2 = k3
        /// </summary>
        /// <typeparam name="K1"></typeparam>
        /// <typeparam name="K2"></typeparam>
        /// <typeparam name="K3"></typeparam>
        public interface Mod<K1,K2,K3> : NatConstraint<K1,K2,K3>
            where K1 : TypeNat
            where K2 : TypeNat
            where K3 : TypeNat
        {

        }

    }    

}