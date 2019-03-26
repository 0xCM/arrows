//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Linq;

    using static zcore;

    partial class Prove
    {

        /// <summary>
        /// Constructs evidence that k1:K1 & k2:K2 => k1 + 1 = k2
        /// </summary>
        /// <typeparam name="K1">The source type</typeparam>
        /// <typeparam name="K2">The successor type</typeparam>
        /// <returns></returns>
        public static Adjacent<K1,K2> adjacent<K1,K2>()
            where K1: TypeNat, new()
            where K2: TypeNat, new()
                => new Adjacent<K1,K2>(natrep<K1>(),natrep<K2>());                             

        /// <summary>
        /// Constructs evidence that k1:K1 & k2:K2 => k1 = k2
        /// </summary>
        /// <typeparam name="K1">The source type</typeparam>
        /// <typeparam name="K2">The successor type</typeparam>
        /// <returns></returns>
        public static Same<K1,K2> same<K1,K2>()
            where K1: TypeNat, new()
            where K2: TypeNat, new()
                => new Same<K1,K2>(natrep<K1>(),natrep<K2>());                             

        /// <summary>
        /// Constructs evidence that k1:K1 & k2:K2 => k1 = k2
        /// </summary>
        /// <typeparam name="K1">The first type</typeparam>
        /// <typeparam name="K2">The second type</typeparam>
        /// <returns></returns>
        public static Different<K1,K2> different<K1,K2>()
            where K1: TypeNat, new()
            where K2: TypeNat, new()
                => new Different<K1,K2>(natrep<K1>(),natrep<K2>());                             

        /// <summary>
        /// Constructs evidence that k1:K1 & k2:K2 => k1 > k2
        /// </summary>
        /// <typeparam name="K1">The first type</typeparam>
        /// <typeparam name="K2">The second type</typeparam>
        /// <returns></returns>
        public static Larger<K1,K2> larger<K1,K2>()
            where K1: TypeNat, new()
            where K2: TypeNat, new()
                => new Larger<K1,K2>(natrep<K1>(),natrep<K2>());                             

        /// <summary>
        /// Constructs evidence that k1:K1 & k2:K2 => k1 > k2
        /// </summary>
        /// <typeparam name="K1">The first type</typeparam>
        /// <typeparam name="K2">The second type</typeparam>
        /// <returns></returns>
        public static Smaller<K1,K2> smaller<K1,K2>()
            where K1: TypeNat, new()
            where K2: TypeNat, new()
                => new Smaller<K1,K2>(natrep<K1>(),natrep<K2>());                             

        /// <summary>
        /// Attemps to construct evidence that n:K & n1:K1 & n2:K2 => n1 <= n <= n2
        /// and returns said evidence if successful; othewise, raises an error
        /// </summary>
        /// <typeparam name="K">The claimed interior point</typeparam>
        /// <typeparam name="K1">The lower inclusive bound</typeparam>
        /// <typeparam name="K2">The upper inclusive bound</typeparam>
        public static Between<K, K1, K2> between<K,K1,K2>()
            where K: TypeNat, new()
            where K1: TypeNat, new()
            where K2: TypeNat, new()
                => new Between<K,K1,K2>(natrep<K>(), natrep<K1>(), natrep<K2>());
    
        /// <summary>
        /// Returns constructed evidence if n:K & n1:K1 & n2:K2 => n1 <= n <= n2
        /// </summary>
        /// <typeparam name="K">The claimed interior point</typeparam>
        /// <typeparam name="K1">The lower inclusive bound</typeparam>
        /// <typeparam name="K2">The upper inclusive bound</typeparam>
        /// <returns></returns>
        public static Option<Between<K,K1,K2>> tryBetween<K,K1,K2>()
            where K: TypeNat, new()
            where K1: TypeNat, new()
            where K2: TypeNat, new()
                => Try(() => between<K,K1,K2>());

    }


}