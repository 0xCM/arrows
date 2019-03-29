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
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static zcore;

    partial class Prove
    {

        /// <summary>
        /// Attempts to prove that k1:K1 & k2:K2 =>  k1 * k2 = expected 
        /// Signals success by returning evidence
        /// Signals failure by raising an error
        /// </summary>
        /// <typeparam name="K1">The first type</typeparam>
        /// <typeparam name="K2">The second type</typeparam>
        public static Mul<K1,K2> product<K1,K2>(uint expected)
            where K1 : TypeNat, new()
            where K2 : TypeNat, new()
        {
            claim<Mul<K1,K2>>(expected);
            return Nat.mul<K1,K2>();
        } 

        /// <summary>
        /// Attempts to prove that k1:K1 & k2:K2 =>  k1 * k2 = expected 
        /// Signals success by returning evidence
        /// Signals failure by raising an error
        /// </summary>
        /// <param name="k1">The first operand value</param>
        /// <param name="k2">The second operand value</param>
        /// <typeparam name="K1">The first type</typeparam>
        /// <typeparam name="K2">The second type</typeparam>
        public static Mul<K1,K2> product<K1,K2>(K1 k1, K2 k2, uint expected)
            where K1 : TypeNat, new()
            where K2 : TypeNat, new()
        {
            claim<Mul<K1,K2>>(expected);
            return Nat.mul<K1,K2>();
        } 

        /// <summary>
        /// Attempts to prove that k1:K1 & k2:K2 =>  k1 * k2 = expected 
        /// Signals success by returning evidence
        /// Signals failure by raising an error
        /// </summary>
        /// <typeparam name="K1">The first type</typeparam>
        /// <typeparam name="K2">The second type</typeparam>
        public static Option<Mul<K1,K2>> tryProduct<K1,K2>(uint expected)
            where K1 : TypeNat, new()
            where K2 : TypeNat, new()
                => Try(() => product<K1,K2>(expected));

        /// <summary>
        /// Attempts to prove that k1:K1 & k2:K2 =>  k1 * k2 = expected 
        /// Signals success by returning evidence
        /// Signals failure by raising an error
        /// </summary>
        /// <param name="k1">The first operand value</param>
        /// <param name="k2">The second operand value</param>
        /// <typeparam name="K1">The first type</typeparam>
        /// <typeparam name="K2">The second type</typeparam>
        public static Option<Mul<K1,K2>> tryProduct<K1,K2>(K1 k1, K2 k2, uint expected)
            where K1 : TypeNat, new()
            where K2 : TypeNat, new()
                => Try(() => product(k1,k2,expected));


    }

}