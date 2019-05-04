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
    using System.Reflection;
    using System.Linq;

    using static nats;

    partial class Prove
    {
        /// <summary>
        /// Attempts to prove t:uint & k:K => t < k
        /// Signals success by returning true
        /// Signals failure by either returning false or raising an error
        /// </summary>
        /// <param name="t">The value to test</param>
        /// <param name="raise">Specifies whether an error should be raised if the check fails</param>
        /// <typeparam name="K">The natural representative</typeparam>
        [MethodImpl(Inline)]   
        public static bool lt<K>(uint t, bool raise = true)
            where K : TypeNat, new() 
                =>  natu<K>() < t ? true : failure<K>("lt", t, raise);

        /// <summary>
        /// Attempts to prove t:uint & k:K => t <= k
        /// Signals success by returning true
        /// Signals failure by either returning false or raising an error
        /// </summary>
        /// <param name="t">The value to test</param>
        /// <param name="raise">Specifies whether an error should be raised if the check fails</param>
        /// <typeparam name="K">The natural representative</typeparam>
        [MethodImpl(Inline)]   
        public static bool lteq<K>(uint t, bool raise = true)
            where K : TypeNat, new() 
                =>  natu<K>() <= t ? true : failure<K>("lteq", t, raise);

        /// <summary>
        /// Attempts to prove k1:K1 & k2:K2 => k1 > k2
        /// Signals success by returning evidence
        /// Signals failure by raising an error
        /// </summary>
        /// <typeparam name="K1">The smaller type</typeparam>
        /// <typeparam name="K2">The larger type</typeparam>
        [MethodImpl(Inline)]   
        public static Smaller<K1,K2> smaller<K1,K2>()
            where K1: TypeNat, new()
            where K2: TypeNat, new()
                => new Smaller<K1,K2>(natrep<K1>(),natrep<K2>());                             

        /// <summary>
        /// Attempts to prove k1:K1 & k2:K2 => k1 < k2
        /// Signals success by returning evidence
        /// Signals failure by raising an error
        /// </summary>
        /// <typeparam name="K1">The smaller type</typeparam>
        /// <typeparam name="K2">The larger type</typeparam>
        [MethodImpl(Inline)]   
        public static Smaller<K1,K2> smaller<K1,K2>(K1 k1, K2 k2)
            where K1: TypeNat, new()
            where K2: TypeNat, new()
                => new Smaller<K1,K2>(k1,k2);

        /// <summary>
        /// Attempts to prove k1:K1 & k2:K2 => k1 < k2
        /// Signals success by returning evidence
        /// Signals failure by returning none
        /// </summary>
        /// <typeparam name="K1">The smaller type</typeparam>
        /// <typeparam name="K2">The larger type</typeparam>
        [MethodImpl(Inline)]   
        public static Option<Smaller<K1,K2>> trySmaller<K1,K2>()
            where K1: TypeNat, new()
            where K2: TypeNat, new()
                => Try(() => new Smaller<K1,K2>(natrep<K1>(),natrep<K2>())); 

        /// <summary>
        /// Attempts to prove k1:K1 & k2:K2 => k1 < k2
        /// Signals success by returning evidence
        /// Signals failure by returning none
        /// </summary>
        /// <typeparam name="K1">The smaller type</typeparam>
        /// <typeparam name="K2">The larger type</typeparam>
        [MethodImpl(Inline)]   
        public static Option<Smaller<K1,K2>> trySmaller<K1,K2>(K1 k1, K2 k2)
            where K1: TypeNat, new()
            where K2: TypeNat, new()
                => Try(() => new Smaller<K1,K2>(k1,k2));
    }
}