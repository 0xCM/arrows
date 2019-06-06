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

    using static nconst;    

    partial class NatProve
    {    
        /// <summary>
        /// Attempts to prove that k1:K1 & k2:K2 =>  k1 + k2 = expected 
        /// Signals success by returning evidence
        /// Signals failure by raising an error
        /// </summary>
        /// <typeparam name="K1">The first type</typeparam>
        /// <typeparam name="K2">The second type</typeparam>
        public static Add<K1,K2> add<K1,K2>(uint expected)
            where K1 : ITypeNat, new()
            where K2 : ITypeNat, new()
        {
            eq<Add<K1, K2>>((ulong)expected);
            return Nat.add<K1,K2>();
        } 

        public static Add<K1,K2> add<K1,K2>(int expected)
            where K1 : ITypeNat, new()
            where K2 : ITypeNat, new()
        {
            eq<Add<K1,K2>>(expected);
            return Nat.add<K1,K2>();
        } 

        /// <summary>
        /// Attempts to prove that k1:K1 & k2:K2 =>  k1 + k2 = expected 
        /// Signals success by returning evidence
        /// Signals failure by raising an error
        /// </summary>
        /// <param name="k1">The first operand value</param>
        /// <param name="k2">The second operand value</param>
        /// <typeparam name="K1">The first type</typeparam>
        /// <typeparam name="K2">The second type</typeparam>
        public static Add<K1,K2> sum<K1,K2>(K1 k1, K2 k2, uint expected)
            where K1 : ITypeNat, new()
            where K2 : ITypeNat, new()
        {
            eq<Add<K1, K2>>((ulong)expected);
            return Nat.add<K1,K2>();
        } 

        /// <summary>
        /// Attempts to prove that k1:K1 & k2:K2 =>  k1 + k2 = expected 
        /// Signals success by returning evidence
        /// Signals failure by raising an error
        /// </summary>
        /// <param name="k1">The first operand value</param>
        /// <param name="k2">The second operand value</param>
        /// <typeparam name="K1">The first type</typeparam>
        /// <typeparam name="K2">The second type</typeparam>
        public static Add<K1,K2> add<K1,K2>(K1 k1, K2 k2, ulong expected)
            where K1 : ITypeNat, new()
            where K2 : ITypeNat, new()
        {
            eq<Add<K1,K2>>(expected);
            return Nat.add<K1,K2>();
        } 

        /// <summary>
        /// Attempts to prove that k1:K1 & k2:K2 =>  k1 + k2 = expected 
        /// Signals success by returning evidence
        /// Signals failure by raising an error
        /// </summary>
        /// <typeparam name="K1">The first type</typeparam>
        /// <typeparam name="K2">The second type</typeparam>
        public static Option<Add<K1,K2>> tryAdd<K1,K2>(uint expected)
            where K1 : ITypeNat, new()
            where K2 : ITypeNat, new()
                => Try(() => add<K1,K2>(expected));

        /// <summary>
        /// Attempts to prove that k1:K1 & k2:K2 =>  k1 + k2 = expected 
        /// Signals success by returning evidence
        /// Signals failure by raising an error
        /// </summary>
        /// <param name="k1">The first operand value</param>
        /// <param name="k2">The second operand value</param>
        /// <typeparam name="K1">The first type</typeparam>
        /// <typeparam name="K2">The second type</typeparam>
        public static Option<Add<K1,K2>> tryAdd<K1,K2>(K1 k1, K2 k2, uint expected)
            where K1 : ITypeNat, new()
            where K2 : ITypeNat, new()
                => Try(() => sum(k1,k2,expected));
    }
}