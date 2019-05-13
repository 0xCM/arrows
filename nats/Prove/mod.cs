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

    partial class Prove
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
        public static Mod<K1,K2,K3> mod<K1,K2,K3>()
            where K1 : ITypeNat, new()
            where K2 : ITypeNat, new()
            where K3 : ITypeNat, new()
                => new Mod<K1,K2,K3>(natrep<K1>(), natrep<K2>(),natrep<K3>());

        /// <summary>
        /// Attempts to prove that k1:K1 & k2:K2 & k3:K3 => k1 % k2 = k3
        /// Signals success by returning evidence
        /// Signals failure by raising an error
        /// </summary>
        /// <typeparam name="K1">The first natural type</typeparam>
        /// <typeparam name="K2">The second natural type</typeparam>
        /// <typeparam name="K3">The third natural type</typeparam>
        [MethodImpl(Inline)]
        public static Mod<K1,K2,K3> mod<K1,K2,K3>(K1 k1, K2 k2, K3 k3)
            where K1 : ITypeNat, new()
            where K2 : ITypeNat, new()
            where K3 : ITypeNat, new()
                => new Mod<K1,K2,K3>(k1, k2, k3);

        /// <summary>
        /// Attempts to prove that k1:K1 & k2:K2 & k3:K3 => k1 % k2 = k3
        /// Signals success by returning evidence
        /// Signals failure by returning none
        /// </summary>
        /// <typeparam name="K1">The first natural type</typeparam>
        /// <typeparam name="K2">The second natural type</typeparam>
        /// <typeparam name="K3">The third natural type</typeparam>
        [MethodImpl(Inline)]
        public static Option<Mod<K1,K2,K3>> tryMod<K1,K2,K3>()
            where K1 : ITypeNat, new()
            where K2 : ITypeNat, new()
            where K3 : ITypeNat, new()
                => Try( () => new Mod<K1,K2,K3>(natrep<K1>(), natrep<K2>(),natrep<K3>()));

        /// <summary>
        /// Attempts to prove that k1:K1 & k2:K2 & k3:K3 => k1 % k2 = k3
        /// Signals success by returning evidence
        /// Signals failure by returning none
        /// </summary>
        /// <typeparam name="K1">The first natural type</typeparam>
        /// <typeparam name="K2">The second natural type</typeparam>
        /// <typeparam name="K3">The third natural type</typeparam>
        [MethodImpl(Inline)]
        public static Option<Mod<K1,K2,K3>> tryMod<K1,K2,K3>(K1 k1, K2 k2, K3 k3)
            where K1 : ITypeNat, new()
            where K2 : ITypeNat, new()
            where K3 : ITypeNat, new()
                => Try( () => new Mod<K1,K2,K3>(k1, k2, k3));


        /// <summary>
        /// Attempts to prove that k:K1 => k % 2 == 0
        /// Signals success by returning evidence
        /// Signals failure by raising an error
        /// </summary>
        /// <typeparam name="K">An even natural type</typeparam>
        [MethodImpl(Inline)]
        public static Even<K> even<K>()
            where K: ITypeNat, new()
                => new Even<K>(natrep<K>());

        /// <summary>
        /// Attempts to prove that k:K1 => k % 2 == 0
        /// Signals success by returning evidence
        /// Signals failure by raising an error
        /// </summary>
        /// <typeparam name="K">An even natural type</typeparam>
        [MethodImpl(Inline)]
        public static Even<K> even<K>(K k)
            where K: ITypeNat, new()
                => new Even<K>(k);

        /// <summary>
        /// Attempts to prove that k:K1 => k % 2 == 0
        /// Signals success by returning evidence
        /// Signals failure by returning none
        /// </summary>
        /// <typeparam name="K">An even natural type</typeparam>
        [MethodImpl(Inline)]
        public static Option<Even<K>> tryEven<K>()
            where K: ITypeNat, new()
                => Try(() => new Even<K>(natrep<K>()));

        /// <summary>
        /// Attempts to prove that k:K1 => k % 2 == 0
        /// Signals success by returning evidence
        /// Signals failure by returning none
        /// </summary>
        /// <typeparam name="K">An even natural type</typeparam>
        [MethodImpl(Inline)]
        public static Option<Even<K>> tryEven<K>(K k)
            where K: ITypeNat, new()
                => Try(() => new Even<K>(k));

        /// <summary>
        /// Attempts to prove that k:K1 => k % 2 != 0
        /// Signals success by returning evidence
        /// Signals failure by raising an error
        /// </summary>
        /// <typeparam name="K">An odd natural type</typeparam>
        [MethodImpl(Inline)]
        public static Odd<K> odd<K>()
            where K: ITypeNat, new()
                => new Odd<K>(natrep<K>());

        /// <summary>
        /// Attempts to prove that k:K1 => k % 2 != 0
        /// Signals success by returning evidence
        /// Signals failure by raising an error
        /// </summary>
        /// <typeparam name="K">An odd natural type</typeparam>
        [MethodImpl(Inline)]
        public static Odd<K> odd<K>(K k)
            where K: ITypeNat, new()
                => new Odd<K>(k);

        /// <summary>
        /// Attempts to prove that k:K1 => k % 2 != 0
        /// Signals success by returning evidence
        /// Signals failure by returning none
        /// </summary>
        /// <typeparam name="K">An odd natural type</typeparam>
        [MethodImpl(Inline)]
        public static Option<Odd<K>> tryOdd<K>()
            where K: ITypeNat, new()
                => Try(() => new Odd<K>(natrep<K>()));

        /// <summary>
        /// Attempts to prove that k:K1 => k % 2 != 0
        /// Signals success by returning evidence
        /// Signals failure by returning none
        /// </summary>
        /// <typeparam name="K">An odd natural type</typeparam>
        [MethodImpl(Inline)]
        public static Option<Odd<K>> tryOdd<K>(K k)
            where K: ITypeNat, new()
                => Try( () => new Odd<K>(k));

    }

}