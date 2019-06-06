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

    using static nfunc;
    using static nconst;    

    partial class NatProve
    {

       /// <summary>
        /// If possible, constructs evidence that n:K => n prime; otherwise,
        /// raises an error
        /// </summary>
        /// <typeparam name="K">The subject</typeparam>
        public static NatPrime<K> prime<K>()
            where K: ITypeNat, new()
                => new NatPrime<K>(natrep<K>());

        /// <summary>
        /// If possible, constructs evidence that n:K => n prime; otherwise,
        /// raises an error
        /// </summary>
        /// <typeparam name="K">The subject</typeparam>
        public static NatPrime<K> prime<K>(K k)
            where K: ITypeNat, new()
                => new NatPrime<K>(k);

        /// <summary>
        /// If possible, constructs evidence that n:K => n prime; otherwise,
        /// yields none
        /// </summary>
        /// <typeparam name="K">The subject</typeparam>
        public static Option<NatPrime<K>> tryPrime<K>()
            where K: ITypeNat, new()
                => Try(() => prime<K>());

        /// <summary>
        /// If possible, constructs evidence that n:K => n prime; otherwise,
        /// yields none
        /// </summary>
        /// <typeparam name="K">The subject</typeparam>
        public static Option<NatPrime<K>> tryPrime<K>(K k)
            where K: ITypeNat, new()
                => Try(() => prime<K>(k));

    }

}