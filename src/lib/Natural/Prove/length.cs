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
        /// Attempts to prove that the k:K => src.length = k
        /// Registers success by returning src
        /// Registers failure by raising an error
        /// </summary>
        /// <param name="src">The source array</param>
        /// <typeparam name="K">The natural type</typeparam>
        /// <typeparam name="T">The list element type</typeparam>
        [MethodImpl(Inline)]   
        public static IReadOnlyList<T> length<K,T>(IReadOnlyList<T> src)
            where K : TypeNat, new()
                => natval<K>() == (ulong)src.Count 
                ? src : failure<K,IReadOnlyList<T>>(nameof(length), src);

        /// <summary>
        /// Attempts to prove that the k:K => src.length = k
        /// Registers success by returning src
        /// Registers failure by raising an error
        /// </summary>
        /// <param name="src">The source array</param>
        /// <typeparam name="K">The natural type</typeparam>
        /// <typeparam name="T">The list element type</typeparam>
        [MethodImpl(Inline)]   
        public static IReadOnlyList<T> length<K,T>(K k, IReadOnlyList<T> src)
            where K : TypeNat, new()
                => k.value == (ulong)src.Count ? src : failure<K,IReadOnlyList<T>>(nameof(length), src);

        /// <summary>
        /// Attempts to prove that the k:K => src.length = k
        /// Registers success by returning src
        /// Registers failure by raising an error
        /// </summary>
        /// <param name="src">The source array</param>
        /// <typeparam name="K">The natural type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]   
        public static T[] length<K,T>(K k, params T[] src)
            where K : TypeNat, new()
                => k.value == (ulong)src.Length ? src : failure<K,T[]>(nameof(length),src); 

        /// <summary>
        /// Attempts to prove that the k:K => src.length = k
        /// Registers success by returning src
        /// Registers failure by raising an error
        /// </summary>
        /// <param name="src">The source array</param>
        /// <typeparam name="K">The natural type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]   
        public static T[] length<K,T>(params T[] src)
            where K : TypeNat, new()
                => natval<K>() == (ulong)src.Length ? src : failure<K,T[]>(nameof(length), src); 
    }

}