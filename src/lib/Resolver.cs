//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using System.Runtime.CompilerServices;
    using System.Numerics;
    using System.Reflection;

    using static zcore;
    

    /// <summary>
    /// Provides a mechanism to specify and retrieve type class instances
    /// </summary>
    public static class Resolver
    {
        static readonly ConcurrentDictionary<Type,object> index
            = new ConcurrentDictionary<Type, object>();


        /// <summary>
        /// Resolves the requested operations, if possible; otherwise,
        /// rasies an error
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        /// <typeparam name="R">The operations type</typeparam>
        [MethodImpl(Inline)]
        static R resolve<T,R>()
            => cast<R>(index[type<T>()]);    

        /// <summary>
        /// Defines an operational reification of type R indexed by an operand type T
        /// </summary>
        /// <typeparam name="R">The reifying type</typeparam>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static void define(Type operand, Type reifier) 
            => index.GetOrAdd(operand, _ => Activator.CreateInstance(reifier));

    }
}

