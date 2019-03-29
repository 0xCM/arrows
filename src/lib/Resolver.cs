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


        /// <summary>
        /// Defines an operational reification of type R indexed by an operand type T
        /// </summary>
        /// <typeparam name="R">The reifying type</typeparam>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static void define<T,R>() 
            where R : Operational<R,T>, new()
                => index.GetOrAdd(type<T>(), _ => new R());

        /// <summary>
        /// Resolves a reification of the Integer[T] trait
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static Traits.Integer<T> integer<T>()
            => resolve<T,Traits.Integer<T>>();

        /// <summary>
        /// Resolves a reification of the SignedInt[T] trait
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static Traits.SignedInt<T> signedint<T>()
            => resolve<T,Traits.SignedInt<T>>();

        /// <summary>
        /// Resolves a reification of the Natural[T] trait
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static Traits.Natural<T> natural<T>()
            => resolve<T,Traits.Natural<T>>();

        /// <summary>
        /// Resolves a reification of the Number[T] trait
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static Traits.Number<T> number<T>()
            => resolve<T, Traits.Number<T>>();

        /// <summary>
        /// Resolves a reification of the OrderedNumber[T] trait
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static Traits.OrderedNumber<T> ordnum<T>()
            => resolve<T, Traits.OrderedNumber<T>>();

        /// <summary>
        /// Resolves a reification of the Real[T] trait
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static Traits.RealNumber<T> real<T>()
            => resolve<T, Traits.RealNumber<T>>();

        /// <summary>
        /// Resolves a reification of the FiniteFloat[T] trait
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static Traits.FiniteFloat<T> floating<T>()
            => resolve<T,Traits.FiniteFloat<T>>();
    }
}

