//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
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
    using static Traits;



    public static partial class Operations
    {
        static readonly ConcurrentDictionary<Type,object> index
            = new ConcurrentDictionary<Type, object>();

        static Operations()
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
        
        public static O ops<T,O>()
            => cast<O>(index[type<T>()]);
        
        /// <summary>
        /// Obtains the basic numeric operators for a specified type
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        /// <returns></returns>
        public static Number<T> number<T>()
            => cast<Number<T>>(index[type<T>()]);

        /// <summary>
        /// Retrieves the operations for any integral type
        /// </summary>
        /// <typeparam name="T">The system type</typeparam>
        /// <returns></returns>
        public static Integer<T> integer<T>()
                => cast<Integer<T>>(index[type<T>()]);

        /// <summary>
        /// Retrieves operations for a unsigned integral type
        /// </summary>
        /// <typeparam name="T">The system type</typeparam>
        /// <returns></returns>
        public static Natural<T> natural<T>()
                => cast<Natural<T>>(index[type<T>()]);

        /// <summary>
        /// Retrieves operations for a signed integral types
        /// </summary>
        /// <typeparam name="T">The system type</typeparam>
        /// <returns></returns>
        public static FiniteSignedInt<T> signedint<T>()
            => cast<FiniteSignedInt<T>>(index[type<T>()]);

        /// <summary>
        /// Retrieves the operations for bounded floating point types
        /// </summary>
        /// <typeparam name="T">The system type</typeparam>
        /// <returns></returns>
        public static FiniteFloat<T> floating<T>()
            where T : new()
                => cast<FiniteFloat<T>>(index[type<T>()]);

        /// <summary>
        /// Retrieves the operations for numbers that support stepwise operations
        /// </summary>
        /// <typeparam name="T">The system type</typeparam>
        public static Stepwise<T> stepwise<T>()
            where T : new()
                => cast<Stepwise<T>>(index[type<T>()]);

        /// <summary>
        /// Retrieves the operations for numbers for which an ordering is defined
        /// </summary>
        /// <typeparam name="T">The system type</typeparam>
        public static Ordered<T> ordered<T>()
            where T : new()
                => cast<Ordered<T>>(index[type<T>()]);


        /// <summary>
        /// Provides access to operations specific to 16-bit signed integer values
        /// </summary>
        public static SignedInt<sbyte> int8()
            => Int8Ops.Inhabitant;

        /// <summary>
        /// Provides access to operations specific to 8-bit usigned integer values
        /// </summary>
        public static Integer<byte> uint8()
            => UInt8Ops.Inhabitant;

        /// <summary>
        /// Provides access to operations specific to 16-bit signed integer values
        /// </summary>
        public static SignedInt<short> int16()
            => Int16Ops.Inhabitant;

        /// <summary>
        /// Provides access to operations specific to 16-bit unsigned integer values
        /// </summary>
        /// <returns></returns>
        public static Integer<ushort> uint16()
            => UInt16Ops.Inhabitant;

        /// <summary>
        /// Provides access to operations specific to 32-bit signed integer values
        /// </summary>
        /// <returns></returns>
        public static SignedInt<int> int32()
            => Int32Ops.Inhabitant;

        /// <summary>
        /// Provides access to operations specific to 32-bit unsigned integer values
        /// </summary>
        /// <returns></returns>
        public static Integer<uint> uint32()
            => UInt32Ops.Inhabitant;

        /// <summary>
        /// Provides access to operations specific to 64-bit signed integer values
        /// </summary>
        /// <returns></returns>
        public static SignedInt<long> int64()
            => Int64Ops.Inhabitant;

        /// <summary>
        /// Provides access to operations specific to 64-bit unsigned integer values
        /// </summary>
        /// <returns></returns>
        public static Integer<ulong> uint64()
            => UInt64Ops.Inhabitant;

        /// <summary>
        /// Provides access to operations specific signed integer values
        /// </summary>
        /// <returns></returns>
        public static InfiniteSignedInt<BigInteger> bigint()
            => BigIntOps.Inhabitant;

        /// <summary>
        /// Provides access to operations specific to single-precision floating point values
        /// </summary>
        /// <returns></returns>
        public static Floating<float> float32()
            => Float32Ops.Inhabitant;

        /// <summary>
        /// Provides access to operations specific to double-precision floating point values
        /// </summary>
        /// <returns></returns>
        public static Floating<double> float64()
            => Float64Ops.Inhabitant;

        /// <summary>
        /// Provides access to operations specific to double-precision floating point values
        /// </summary>
        /// <returns></returns>
        public static Currency<decimal> currency()
            => DecimalOps.Inhabitant;

        public static O define<T,O>() 
            where O : new()
                => (O)index.GetOrAdd(type<T>(), t => new O());

        public static object define(Type key, object ops) 
            => index.GetOrAdd(key, _ => ops);

        public static object define(Type key, Type ops) 
            => define(key, Activator.CreateInstance(ops));


        public static object define( (Type key, Type ops) x) 
            => index.GetOrAdd(x.key, _ => Activator.CreateInstance(x.ops) );

        public static IReadOnlyList<object> define(params (Type key, Type ops)[] ops) 
            => map(ops, x => define(x.key,x.ops)).ToList();

        public static IReadOnlyList<object> define(params (Type key, object ops)[] ops) 
            => map(ops, x => index.GetOrAdd(x.key, x.ops)).ToList();
    }
}

