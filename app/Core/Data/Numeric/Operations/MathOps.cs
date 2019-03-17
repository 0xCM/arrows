//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Numerics;

    using Root;
    using Data;
    using static corefunc;

    using C = Core.Contracts;

    public static partial class MathOps
    {
        /// <summary>
        /// Obtains the arithmetic operators for a specified type
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        /// <returns></returns>
        public static C.Arithmetic<T> arithmetic<T>()
            => cast<C.Arithmetic<T>>(operations[type<T>()]);

        /// <summary>
        /// Obtains the bitwise operators for a specified type
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        /// <returns></returns>
        public static C.Bitwise<T> bitwise<T>()
            => cast<C.Bitwise<T>>(operations[type<T>()]);

        /// <summary>
        /// Obtains the integer division for a specified type
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        /// <returns></returns>
        public static C.IntDiv<T> intdiv<T>()
            => cast<C.IntDiv<T>>(operations[type<T>()]);

        /// <summary>
        /// Provides access to operations specific to double-precision floating point values
        /// </summary>
        /// <returns></returns>
        public static C.Floating<double> float64()
            => Float64Ops.Inhabitant;

        /// <summary>
        /// Provides access to operations specific to single-precision floating point values
        /// </summary>
        /// <returns></returns>
        public static C.Floating<float> float32()
            => Float32Ops.Inhabitant;

        /// <summary>
        /// Provides access to operations specific to 64-bit signed integer values
        /// </summary>
        /// <returns></returns>
        public static C.SignedInt<long> int64()
            => Int64Ops.Inhabitant;

        /// <summary>
        /// Provides access to operations specific to 32-bit signed integer values
        /// </summary>
        /// <returns></returns>
        public static C.SignedInt<int> int32()
            => Int32Ops.Inhabitant;

        /// <summary>
        /// Provides access to operations specific to 16-bit signed integer values
        /// </summary>
        /// <returns></returns>
        public static C.SignedInt<short> int16()
            => Int16Ops.Inhabitant;

        /// <summary>
        /// Provides access to operations specific to 16-bit signed integer values
        /// </summary>
        /// <returns></returns>
        public static C.SignedInt<sbyte> int8()
            => Int8Ops.Inhabitant;

        /// <summary>
        /// Provides access to operations specific to 64-bit unsigned integer values
        /// </summary>
        /// <returns></returns>
        public static C.Integer<ulong> uint64()
            => UInt64Ops.Inhabitant;

        /// <summary>
        /// Provides access to operations specific to 32-bit unsigned integer values
        /// </summary>
        /// <returns></returns>
        public static C.Integer<uint> uint32()
            => UInt32Ops.Inhabitant;

        /// <summary>
        /// Provides access to operations specific to 16-bit unsigned integer values
        /// </summary>
        /// <returns></returns>
        public static C.Integer<ushort> uint16()
            => UInt16Ops.Inhabitant;

        /// <summary>
        /// Provides access to operations specific to 8-bit usigned integer values
        /// </summary>
        /// <returns></returns>
        public static C.Integer<byte> uint8()
            => UInt8Ops.Inhabitant;

        /// <summary>
        /// Provides access to operations specific signed integer values
        /// </summary>
        /// <returns></returns>
        public static C.SignedInt<BigInteger> bigint()
            => BigIntOps.Inhabitant;

        /// <summary>
        /// Retrieves the operations for a signed integral type
        /// </summary>
        /// <typeparam name="T">The system type</typeparam>
        /// <returns></returns>
        public static C.SignedInt<T> signedint<T>()
            where T : new()
                => cast<C.SignedInt<T>>(operations[type<T>()]);

        /// <summary>
        /// Retrieves the operations for an integral type
        /// </summary>
        /// <typeparam name="T">The system type</typeparam>
        /// <returns></returns>
        public static C.Integer<T> integer<T>()
            where T : new()
                => cast<C.Integer<T>>(operations[type<T>()]);

        /// <summary>
        /// Retrieves the floating point operations for either float or double types
        /// </summary>
        /// <typeparam name="T">The system type</typeparam>
        /// <returns></returns>
        public static C.Floating<T> floating<T>()
            where T : new()
                => cast<C.Floating<T>>(operations[type<T>()]);

        public static C.BoundFloat<T> boundfloat<T>()
            where T : new()
                => cast<C.BoundFloat<T>>(operations[type<T>()]);

        public static C.BoundInt<T> boundint<T>()
            where T : new()
                => cast<C.BoundInt<T>>(operations[type<T>()]);

        public static C.BoundUnsignedInt<T> bounduint<T>()
            where T : new()
                => cast<C.BoundUnsignedInt<T>>(operations[type<T>()]);

        public static C.BoundSignedInt<T> boundsint<T>()
            where T : new()
                => cast<C.BoundSignedInt<T>>(operations[type<T>()]);

        public static C.BoundFractional<T> boundfractional<T>()
            where T : new()
                => cast<C.BoundFractional<T>>(operations[type<T>()]);

        static readonly Index<Type, object> operations 
            = index(seq(
                (type<sbyte>(), cast<object>(Int8Ops.Inhabitant)),
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


                ));
    }

}

