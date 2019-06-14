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
    using static constant;    

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


    }

}