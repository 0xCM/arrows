//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static nfunc;

    partial class Prove
    {


        /// <summary>
        /// If possible, constructs evidence that k1:K1 & k2:K2 => k1 + 1 = k2; otherwise
        /// rasies an error
        /// </summary>
        /// <typeparam name="K1">The source type</typeparam>
        /// <typeparam name="K2">The successor type</typeparam>
        /// <returns></returns>
        public static Next<K1,K2> next<K1,K2>()
            where K1: ITypeNat, new()
            where K2: ITypeNat, new()
                => new Next<K1,K2>(natrep<K1>(),natrep<K2>());                             

        /// <summary>
        /// If possible, constructs evidence that k1:K1 & k2:K2 => k1 + 1 = k2; otherwise
        /// rasies an error
        /// </summary>
        /// <typeparam name="K1">The source type</typeparam>
        /// <typeparam name="K2">The successor type</typeparam>
        /// <returns></returns>
        public static Next<K1,K2> next<K1,K2>(K1 k1, K2 k2)
            where K1: ITypeNat, new()
            where K2: ITypeNat, new()
                => new Next<K1,K2>(k1,k2);                             

        /// <summary>
        /// If possible, constructs evidence that k1:K1 & k2:K2 => k1 + 1 = k2; otherwise
        /// returns none
        /// </summary>
        /// <typeparam name="K1">The source type</typeparam>
        /// <typeparam name="K2">The successor type</typeparam>
        /// <returns></returns>
        public static Option<Next<K1,K2>> tryNext<K1,K2>()
            where K1: ITypeNat, new()
            where K2: ITypeNat, new()
                => Try(() => new Next<K1,K2>(natrep<K1>(),natrep<K2>()));                             

        /// <summary>
        /// If possible, constructs evidence that k1:K1 & k2:K2 => k1 + 1 = k2; otherwise
        /// returns none
        /// </summary>
        /// <typeparam name="K1">The source type</typeparam>
        /// <typeparam name="K2">The successor type</typeparam>
        /// <returns></returns>
        public static Option<Next<K1,K2>> tryNext<K1,K2>(K1 k1, K2 k2)
            where K1: ITypeNat, new()
            where K2: ITypeNat, new()
                => Try(() => new Next<K1,K2>(k1,k2));                             

    }
}