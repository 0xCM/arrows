//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Numerics;
using System.Reflection;
using Core;
using static Core.Traits;

namespace Core
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using System.Runtime.CompilerServices;
    using System.Numerics;
    using System.Reflection;

    using static corefunc;
    using static Operations;
    


    /// <summary>
    /// Provides a mechanism to specify and retrieve type class instances
    /// </summary>
    public static class Resolve
    {
        static readonly ConcurrentDictionary<Type,object> index
            = new ConcurrentDictionary<Type, object>();

        static Resolve()
        {
            define(
                (type<sbyte>(), Int8Ops.Inhabitant),

                (type<byte>(), cast<object>(UInt8Ops.Inhabitant)),
                
                (type<short>(), cast<object>(Int16Ops.Inhabitant)),
                (type<ushort>(), cast<object>(UInt16Ops.Inhabitant)),
                
                (type<int>(), cast<object>(Int32Ops.Inhabitant)),
                (type<uint>(), cast<object>(UInt32Ops.Inhabitant)),
                
                (type<long>(), cast<object>(Int64Ops.Inhabitant)),
                (type<ulong>(),cast<object>(UInt64Ops.Inhabitant)),

                (type<BigInteger>(),cast<object>(BigIntOps.Inhabitant)),

                (type<Decimal>(),cast<object>(DecimalOps.Inhabitant)),
                (type<float>(),cast<object>(Float32Ops.Inhabitant)),
                (type<double>(),cast<object>(Float64Ops.Inhabitant))
                
                );
        }


        [MethodImpl(Inline)]
        public static O ops<T,O>()
                => cast<O>(index[type<T>()]);    

        [MethodImpl(Inline)]
        public static object define(Type key, object ops) 
            => index.GetOrAdd(key, _ => ops);

        [MethodImpl(Inline)]
        public static object define(Type key, Type ops) 
            => define(key, Activator.CreateInstance(ops));


        [MethodImpl(Inline)]
        public static object define( (Type key, Type ops) x) 
            => index.GetOrAdd(x.key, _ => Activator.CreateInstance(x.ops) );

        [MethodImpl(Inline)]
        public static IReadOnlyList<object> define(params (Type key, Type ops)[] ops) 
            => map(ops, x => define(x.key,x.ops)).ToList();

        [MethodImpl(Inline)]
        public static IReadOnlyList<object> define(params (Type key, object ops)[] ops) 
            => map(ops, x => index.GetOrAdd(x.key, x.ops)).ToList();


        /// <summary>
        /// Provides access to operations specific signed integer values
        /// </summary>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static InfiniteSignedInt<BigInteger> bigint()
            => BigIntOps.Inhabitant;


        [MethodImpl(Inline)]
        public static O define<T,O>() 
            where O : new()
                => (O)index.GetOrAdd(type<T>(), t => new O());

    }
}

public static partial class corefunc
{

    [MethodImpl(Inline)]   
    public static O ops<T,O>()
        => Resolve.ops<T,O>();
    
    /// <summary>
    /// Retrieves semigroup operations for a specified type
    /// </summary>
    [MethodImpl(Inline)]
    public static Traits.Semigroup<T> semigroup<T>() 
        => ops<T,Traits.Semigroup<T>>();


    /// <summary>
    /// Retrieves semiring operations for a specified type
    /// </summary>
    [MethodImpl(Inline)]
    public static Traits.Semiring<T> semiring<T>() 
        => ops<T,Traits.Semiring<T>>();

    /// <summary>
    /// Retrieves the operations for any integral type
    /// </summary>
    /// <typeparam name="T">The system type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static Integer<T> integer<T>()
        => ops<T,Integer<T>>();

    /// <summary>
    /// Retrieves operations for signed integral types
    /// </summary>
    /// <typeparam name="T">The system type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static SignedInt<T> signedint<T>()
        => ops<T,SignedInt<T>>();

    /// <summary>
    /// Retrieves operations for a unsigned integral type
    /// </summary>
    /// <typeparam name="T">The system type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static Natural<T> natural<T>()
        => ops<T,Natural<T>>();

    /// <summary>
    /// Retrieves operations valid for any number type
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static Number<T> number<T>()
        => ops<T, Traits.Number<T>>();

    /// <summary>
    /// Retrieves operations valid for any real number type
    /// </summary>
    /// <typeparam name="T">The operand type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static Real<T> real<T>()
        => ops<T, Traits.Real<T>>();

    /// <summary>
    /// Retrieves the operations for bounded floating point types
    /// </summary>
    /// <typeparam name="T">The system type</typeparam>
    /// <returns></returns>
    [MethodImpl(Inline)]
    public static FiniteFloat<T> floating<T>()
        => ops<T,FiniteFloat<T>>();

    /// <summary>
    /// Retrieves the ordering operations defined for a specified type
    /// </summary>
    /// <typeparam name="T">The system type</typeparam>
    [MethodImpl(Inline)]
    public static Ordered<T> ordered<T>()
        => ops<T,Ordered<T>>();


    /// <summary>
    /// Retrieves the operations for numbers that support stepwise operations
    /// </summary>
    /// <typeparam name="T">The system type</typeparam>
    [MethodImpl(Inline)]
    public static Stepwise<T> stepwise<T>()
        => ops<T,Stepwise<T>>();
}
