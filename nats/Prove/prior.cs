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

    using static nfunc;

    partial class NatProve
    {
        /// <summary>
        /// Attempts to prove that k:K1 & k:K2 => k1 = k2 + 1
        /// Signals success by returning true
        /// Signals failure by either returning false or raising an error
        /// </summary>
        /// <param name="raise">Specifies whether an error should be raised if the check fails</param>
        /// <typeparam name="K1">The next type</typeparam>
        /// <typeparam name="K2">The prior</typeparam>
        [MethodImpl(Inline)]   
        public static bool successor<K1,K2>(bool raise = true)
            where K1 : ITypeNat, new() 
            where K2 : ITypeNat, new()
                =>  natu<K1>() == natu<K2>() + 1 ? true : failure<K1,K2>(nameof(successor), raise);

        /// <summary>
        /// Attempts to prove that k1:K1 & k2:K2 => k1 = k2 + 1;
        /// Signals success by returning evidence
        /// Signals failure by raising an error
        /// </summary>
        /// <typeparam name="K1">The source type</typeparam>
        /// <typeparam name="K2">The successor type</typeparam>
        [MethodImpl(Inline)]   
        public static NatPrior<K1,K2> prior<K1,K2>()
            where K1: ITypeNat, new()
            where K2: ITypeNat, new()
                => new NatPrior<K1,K2>(natrep<K1>(),natrep<K2>());                             

        /// <summary>
        /// Attempts to prove that k1:K1 & k2:K2 => k1 = k2 + 1;
        /// Signals success by returning evidence
        /// Signals failure by raising an error
        /// </summary>
        /// <typeparam name="K1">The source type</typeparam>
        /// <typeparam name="K2">The successor type</typeparam>
        [MethodImpl(Inline)]   
        public static NatPrior<K1,K2> prior<K1,K2>(K1 k1, K2 k2)
            where K1: ITypeNat, new()
            where K2: ITypeNat, new()
                => new NatPrior<K1,K2>(k1,k2);                             

        /// <summary>
        /// Attempts to prove that k1:K1 & k2:K2 => k1 = k2 + 1;
        /// Signals success by returning evidence
        /// Signals failure by returning none
        /// </summary>
        /// <typeparam name="K1">The source type</typeparam>
        /// <typeparam name="K2">The successor type</typeparam>
        [MethodImpl(Inline)]   
        public static Option<NatPrior<K1,K2>> tryPrior<K1,K2>()
            where K1: ITypeNat, new()
            where K2: ITypeNat, new()
                => Try(() => new NatPrior<K1,K2>(natrep<K1>(),natrep<K2>()));                             

        /// <summary>
        /// Attempts to prove that k1:K1 & k2:K2 => k1 = k2 + 1;
        /// Signals success by returning evidence
        /// Signals failure by returning none
        /// </summary>
        /// <typeparam name="K1">The source type</typeparam>
        /// <typeparam name="K2">The successor type</typeparam>
        [MethodImpl(Inline)]   
        public static Option<NatPrior<K1,K2>> tryPrior<K1,K2>(K1 k1, K2 k2)
            where K1: ITypeNat, new()
            where K2: ITypeNat, new()
                => Try(() => new NatPrior<K1,K2>(k1,k2));  


    }
}