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
    using System.Runtime.CompilerServices;

    using static nfunc;
    using static nconst;
    
    partial class NatProve
    {
        /// <summary>
        /// Attempts to prove that k1:K1 & k2:K2 & k3:K3 => k1 % k2 = k3
        /// Signals success by returning evidence
        /// Signals failure by raising an error
        /// </summary>
        /// <typeparam name="K1">The first natural type</typeparam>
        /// <typeparam name="K2">The second natural type</typeparam>
        /// <typeparam name="K3">The third natural type</typeparam>
        [MethodImpl(Inline)]
        public static NatMod<K1,K2,K3> mod<K1,K2,K3>()
            where K1 : ITypeNat, new()
            where K2 : ITypeNat, new()
            where K3 : ITypeNat, new()
                => new NatMod<K1,K2,K3>(natrep<K1>(), natrep<K2>(),natrep<K3>());

        /// <summary>
        /// Attempts to prove that k1:K1 & k2:K2 & k3:K3 => k1 % k2 = k3
        /// Signals success by returning evidence
        /// Signals failure by raising an error
        /// </summary>
        /// <typeparam name="K1">The first natural type</typeparam>
        /// <typeparam name="K2">The second natural type</typeparam>
        /// <typeparam name="K3">The third natural type</typeparam>
        [MethodImpl(Inline)]
        public static NatMod<K1,K2,K3> mod<K1,K2,K3>(K1 k1, K2 k2, K3 k3)
            where K1 : ITypeNat, new()
            where K2 : ITypeNat, new()
            where K3 : ITypeNat, new()
                => new NatMod<K1,K2,K3>(k1, k2, k3);


        /// <summary>
        /// Attempts to prove that k:K1 => k % 2 == 0
        /// Signals success by returning evidence
        /// Signals failure by raising an error
        /// </summary>
        /// <typeparam name="K">An even natural type</typeparam>
        [MethodImpl(Inline)]
        public static NatEven<K> even<K>()
            where K: ITypeNat, new()
                => new NatEven<K>(natrep<K>());

        /// <summary>
        /// Attempts to prove that k:K1 => k % 2 == 0
        /// Signals success by returning evidence
        /// Signals failure by raising an error
        /// </summary>
        /// <typeparam name="K">An even natural type</typeparam>
        [MethodImpl(Inline)]
        public static NatEven<K> even<K>(K k)
            where K: ITypeNat, new()
                => new NatEven<K>(k);

        /// <summary>
        /// Attempts to prove that k:K1 => k % 2 != 0
        /// Signals success by returning evidence
        /// Signals failure by raising an error
        /// </summary>
        /// <typeparam name="K">An odd natural type</typeparam>
        [MethodImpl(Inline)]
        public static NatOdd<K> odd<K>()
            where K: ITypeNat, new()
                => new NatOdd<K>(natrep<K>());

        /// <summary>
        /// Attempts to prove that k:K1 => k % 2 != 0
        /// Signals success by returning evidence
        /// Signals failure by raising an error
        /// </summary>
        /// <typeparam name="K">An odd natural type</typeparam>
        [MethodImpl(Inline)]
        public static NatOdd<K> odd<K>(K k)
            where K: ITypeNat, new()
                => new NatOdd<K>(k);


    }

}