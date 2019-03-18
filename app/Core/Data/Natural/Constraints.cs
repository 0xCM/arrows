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

    using C = Contracts;
    using NC = Contracts.NatConstraints;


    public static class NatConstraints
    {
        public static class EQ
        {
            public static NC.EQ<K1,K2> require<K1,K2>()
                where K1: C.TypeNat
                where K2: C.TypeNat
            {
                var k1 = natval<K1>();
                var k2 = natval<K2>();
                demand(k1 == k2);
                return new EQ<K1,K2>();                             
            }
        }

        public static class Nonzero
        {
            public static NC.Nonzero<K> require<K>()
                where K: C.TypeNat
            {
                var k = natval<K>();
                demand(k != 0);
                return new Nonzero<K>();                             
            }

        }

        public static class LT
        {
            public static NC.LT<K1,K2> require<K1,K2>()
                where K1: C.TypeNat
                where K2: C.TypeNat
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
                where K1: C.TypeNat
                where K2: C.TypeNat
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
                where K1: C.TypeNat
                where K2: C.TypeNat
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
                where K1: C.TypeNat
                where K2: C.TypeNat
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
                where K1: C.TypeNat
                where K2: C.TypeNat
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
                where K1: C.TypeNat
                where K2: C.TypeNat
                where K3: C.TypeNat

            {
                var k1 = natval<K1>();
                var k2 = natval<K2>();
                var k3 = natval<K3>();
                demand(k1 + k2 == k3);
                return new Sum<K1,K2,K3>();                             
            }
        }


        /// <summary>
        /// Provides evidence that K1 == K2
        /// </summary>
        readonly struct EQ<K1,K2> : NC.EQ<K1,K2>
            where K1: C.TypeNat
            where K2: C.TypeNat
        {

        }

        /// <summary>
        /// Provides evidence that K1 < K2
        /// </summary>
        readonly struct LT<K1,K2> : NC.LT<K1,K2>
            where K1: C.TypeNat
            where K2: C.TypeNat
        {

        }

        /// <summary>
        /// Provides evidence that K1 <= K2
        /// </summary>
        readonly struct LTEQ<K1,K2> : NC.LTEQ<K1,K2>
            where K1: C.TypeNat
            where K2: C.TypeNat
        {

        }

        /// <summary>
        /// Provides evidence that K1 > K2
        /// </summary>
        readonly struct GT<K1,K2> : NC.GT<K1,K2>
            where K1: C.TypeNat
            where K2: C.TypeNat
        {

        }

        /// <summary>
        /// Provides evidence that K1 > K2
        /// </summary>
        readonly struct GTEQ<K1,K2> : NC.GTEQ<K1,K2>
            where K1: C.TypeNat
            where K2: C.TypeNat
        {

        }

        /// <summary>
        /// Provides evidence that K1 is directly succeeded by K2
        /// </summary>
        readonly struct Adjacent<K1,K2> : NC.Adjacent<K1,K2>
            where K1: C.TypeNat
            where K2: C.TypeNat
        {

        }

        /// <summary>
        /// Provides evidence that k1 + k2 = k3
        /// </summary>
        readonly struct Sum<K1,K2,K3> : NC.Sum<K1,K2,K3>
            where K1: C.TypeNat
            where K2: C.TypeNat
            where K3: C.TypeNat
        {

        }

        /// <summary>
        /// Provides evidence that k != 0
        /// </summary>
        readonly struct Nonzero<K> : NC.Nonzero<K>
            where K: C.TypeNat
        {

        }

    }
}