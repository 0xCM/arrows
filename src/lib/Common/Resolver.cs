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

        static Resolver()
        {            
            // define<Int8Ops,sbyte>();
            // define<UInt8Ops,byte>();
            // define<Int16Ops, short>();
            // define<UInt16Ops,ushort>();
            // define<Int32Ops, int>();
            // define<UInt32Ops, uint>();
            // define<Int64Ops, long>();
            // define<UInt64Ops, ulong>();
            // define<BigIntOps, BigInteger>();
            // define<DecimalOps, decimal>();
            // define<Float32Ops, float>();
            // define<Float64Ops, double>();
        }

        [MethodImpl(Inline)]
        static object define(Type key, object ops) 
            => index.GetOrAdd(key, _ => ops);

        /// <summary>
        /// Defines operations for a specified type
        /// </summary>
        /// <param name="operand">The operand type</param>
        /// <param name="ops">The reified operations</param>
        /// <returns></returns>

        [MethodImpl(Inline)]
        static object define(Type operand, Type ops) 
            => define(operand, Activator.CreateInstance(ops));

        /// <summary>
        /// Defines operations for a specified type
        /// </summary>
        /// <typeparam name="R">The reifying type</typeparam>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static R define<R,T>() 
            where R : TypeClass<R,T>, new()
                => (R)index.GetOrAdd(type<T>(), _ => new R());

        /// <summary>
        /// Resolves the requested operations, if possible; otherwise,
        /// rasies an error
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        /// <typeparam name="O">The operations type</typeparam>
        [MethodImpl(Inline)]
        public static O ops<T,O>()
            => cast<O>(index[type<T>()]);    

        /// <summary>
        /// Determines whether the operations over a type can be resolved
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        /// <typeparam name="O">The operations type</typeparam>
        [MethodImpl(Inline)]
        public static bool resolves<T,O>()
            => index[type<T>()] is O;

        [MethodImpl(Inline)]
        public static IReadOnlyList<object> define(params (Type key, object ops)[] ops) 
            => map(ops, x => index.GetOrAdd(x.key, x.ops)).ToList();


    }
}

