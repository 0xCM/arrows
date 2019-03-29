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

    using static zcore;

    partial class Prove
    {

        /// <summary>
        /// Registers natural constraint failure
        /// </summary>
        /// <param name="name">The name of the constraint that failed</param>
        /// <param name="value">The subject value</param>
        /// <param name="raise">Specifies whether to raise an error</param>
        /// <typeparam name="K">The natural type for which a constraint failed</typeparam>
        [MethodImpl(Inline)]   
        static bool failure<K>(string name, uint value, bool raise = true)
            where K : TypeNat, new()
            => raise ? throw new DemandException("eq", value, natval<K>())  : false;

        /// <summary>
        /// Registers a natural constraint failure
        /// </summary>
        /// <param name="name">The name of the constraint that failed</param>
        /// <param name="value">The subject value</param>
        /// <param name="raise">Specifies whether to raise an error</param>
        /// <typeparam name="K">The natural type for which a constraint failed</typeparam>
        /// <typeparam name="T">The subject type</typeparam>
        [MethodImpl(Inline)]   
        static T failure<K,T>(string name, T value, bool raise = true)
            where K : TypeNat, new()
                => raise ? throw new DemandException("eq", value, natval<K>())  : value;
   
        /// <summary>
        /// Registers a natural pair constraint failure
        /// </summary>
        /// <param name="name">The name of the constraint that failed</param>
        /// <param name="raise">Specifies whether to raise an error</param>
        /// <typeparam name="K1">The first natural type</typeparam>
        /// <typeparam name="K2">The second natural type</typeparam>
        [MethodImpl(Inline)]   
        static bool failure<K1,K2>(string name, bool raise = true)
            where K1 : TypeNat, new()
            where K2 : TypeNat, new()
                => raise ? throw new DemandException(name, Nat.pair<K1,K2>()) : false;
    }
}