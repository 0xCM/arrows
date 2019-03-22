//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using static corefunc;

    using NC = NatConstraints;

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

    public static partial class NatConstraints
    {


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
            where K1 : TypeNat, new()
            where K2 : TypeNat, new()
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
            where K1 : TypeNat, new()
            where K2 : TypeNat, new()
            where C1 : NatConstraint
            where C2 : NatConstraint
        {

        }

        

        /// <summary>
        /// Characterizes a constraint that requires a nat to be nonzero
        /// </summary>
        /// <typeparam name="K">A nonzero nat type</typeparam>
        public interface Nonzero<K> : NatConstraint<K>
            where K : TypeNat, new()
        {

        }

        /// <summary>
        /// Characterizes a constraint that requires a nat to be prime
        /// </summary>
        /// <typeparam name="K">A prime nat type</typeparam>
        public interface Prime<K> : NatConstraint<K>
            where K : TypeNat, new()
        {

        }

        /// <summary>
        /// Characterizes a constraint that for nats k1 and k2, k1 + 1 = k2
        /// </summary>
        /// <typeparam name="K1">The first nat type</typeparam>
        /// <typeparam name="K2">The second nat type</typeparam>
        public interface Adjacent<K1,K2> : LT<K1,K2> 
            where K1 : TypeNat, new()
            where K2 : TypeNat, new()
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
            where K1 : TypeNat, new()
            where K2 : TypeNat, new()
            where K3 : TypeNat, new()
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
            where K1 : TypeNat, new()
            where K2 : TypeNat, new()
            where K3 : TypeNat, new()
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
            where K1 : TypeNat, new()
            where K2 : TypeNat, new()
            where K3 : TypeNat, new()
        {

        }

    }    

    partial class Reify
    {
        public static class NatConstraints
        {

            public static class Nonzero
            {
                public static NC.Nonzero<K> require<K>()
                    where K: TypeNat, new()
                {
                    var k = natval<K>();
                    demand(k != 0);
                    return new Nonzero<K>();                             
                }

            }

            public static class LT
            {
                public static NC.LT<K1,K2> require<K1,K2>()
                    where K1:TypeNat, new()
                    where K2:TypeNat, new()
                {
                    var k1 = natval<K1>();
                    var k2 = natval<K2>();
                    demand(k1 < k2);
                    return new LT<K1,K2>();                                 
                }
            }

            public static class LTEQ
            {
                public static NC.LTEQ<K1,K2> require<K1,K2>()
                    where K1: TypeNat, new()
                    where K2: TypeNat, new()
                {
                    var k1 = natval<K1>();
                    var k2 = natval<K2>();
                    demand(k1 <= k2);
                    return new LTEQ<K1,K2>(); 
                    
                    
                }
            }

    
            public static class GT
            {
                public static NC.GT<K1,K2> require<K1,K2>()
                    where K1: TypeNat, new()
                    where K2: TypeNat, new()
                {
                    var k1 = natval<K1>();
                    var k2 = natval<K2>();
                    demand(k1 > k2);
                    return new GT<K1,K2>();                
                    
                }
            }

            public static class GTEQ
            {
                public static NC.GTEQ<K1,K2> require<K1,K2>()
                    where K1: TypeNat, new()
                    where K2: TypeNat, new()
                {
                    var k1 = natval<K1>();
                    var k2 = natval<K2>();
                    demand(k1 >= k2);
                    return new GTEQ<K1,K2>(); 
                    
                    
                }
            }


            public static class Adjacent
            {
                public static NC.Adjacent<K1,K2> require<K1,K2>()
                    where K1: TypeNat, new()
                    where K2: TypeNat, new()
                {
                    var k1 = natval<K1>();
                    var k2 = natval<K2>();
                    demand(k1 + 1 == k2);
                    return new Adjacent<K1,K2>();                             
                }
            }

            public static class Sum
            {
                public static NC.Sum<K1,K2,K3> require<K1,K2,K3>()
                    where K1: TypeNat, new()
                    where K2: TypeNat, new()
                    where K3: TypeNat, new()

                {
                    var k1 = natval<K1>();
                    var k2 = natval<K2>();
                    var k3 = natval<K3>();
                    demand(k1 + k2 == k3);
                    return new Sum<K1,K2,K3>();                             
                }
            }



            /// <summary>
            /// Provides evidence that K1 < K2
            /// </summary>
            readonly struct LT<K1,K2> : NC.LT<K1,K2>
                where K1: TypeNat, new()
                where K2: TypeNat, new()
            {

            }

            /// <summary>
            /// Provides evidence that K1 <= K2
            /// </summary>
            readonly struct LTEQ<K1,K2> : NC.LTEQ<K1,K2>
                where K1: TypeNat, new()
                where K2: TypeNat, new()
            {

            }

            /// <summary>
            /// Provides evidence that K1 > K2
            /// </summary>
            readonly struct GT<K1,K2> : NC.GT<K1,K2>
                where K1: TypeNat, new()
                where K2: TypeNat, new()
            {

            }

            /// <summary>
            /// Provides evidence that K1 > K2
            /// </summary>
            readonly struct GTEQ<K1,K2> : NC.GTEQ<K1,K2>
                where K1: TypeNat, new()
                where K2: TypeNat, new()
            {

            }

            /// <summary>
            /// Provides evidence that K1 is directly succeeded by K2
            /// </summary>
            readonly struct Adjacent<K1,K2> : NC.Adjacent<K1,K2>
                where K1: TypeNat, new()
                where K2: TypeNat, new()
            {

            }

            /// <summary>
            /// Provides evidence that k1 + k2 = k3
            /// </summary>
            readonly struct Sum<K1,K2,K3> : NC.Sum<K1,K2,K3>
                where K1: TypeNat, new()
                where K2: TypeNat, new()
                where K3: TypeNat, new()
            {

            }

            /// <summary>
            /// Provides evidence that k != 0
            /// </summary>
            readonly struct Nonzero<K> : NC.Nonzero<K>
                where K: TypeNat, new()
            {

            }
        }
    }

}