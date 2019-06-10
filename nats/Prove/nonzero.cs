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

    using static nfunc;
    using static nconst;    

    
    partial class NatProve
    {
        /// <summary>
        /// Attempts to prove that k:K => k != 0
        /// Signals success by returning evidence
        /// Signals failure by raising an error
        /// </summary>
        /// <typeparam name="K">A nonzero natural type</typeparam>
        [MethodImpl(Inline)]
        public static Nonzero<K> nonzero<K>()
            where K: ITypeNat, new()
                => new Nonzero<K>(natrep<K>());                             

        /// <summary>
        /// Attempts to prove that k:K => k != 0
        /// Signals success by returning evidence
        /// Signals failure by raising an error
        /// </summary>
        /// <typeparam name="K">A nonzero natural type</typeparam>
        [MethodImpl(Inline)]
        public static Nonzero<K> nonzero<K>(K k)
            where K: ITypeNat, new()
                => new Nonzero<K>(k);                             

    }
}