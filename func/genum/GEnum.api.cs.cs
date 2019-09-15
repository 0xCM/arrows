//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using static zfunc;
    using static As;

    public static class GEnum
    {
        public static T ToScalar<E,T>(E src)
            where E : Enum
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>((byte)(object)src);
            else if(typeof(T) == typeof(sbyte))
                return generic<T>((sbyte)(object)src);
            else if(typeof(T) == typeof(short))
                return generic<T>((short)(object)src);
            else if(typeof(T) == typeof(ushort))
                return generic<T>((ushort)(object)src);
            else if(typeof(T) == typeof(int))
                return generic<T>((int)(object)src);
            else if(typeof(T) == typeof(uint))
                return generic<T>((uint)(object)src);
            else if(typeof(T) == typeof(long))
                return generic<T>((long)(object)src);
            else if(typeof(T) == typeof(ulong))
                return generic<T>((ulong)(object)src);
            else
                throw unsupported<T>();        
        }

        /// <summary>
        /// Creates a generic enum value
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static GEnum<E> FromValue<E>(E src)
            where E : Enum
                => new GEnum<E>(src);

        /// <summary>
        /// Creates a generic enum value parametrized by the underlying scalar type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="rep">A representative value of the underlying type, used only for type inference</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static GEnum<E,T> FromValue<E,T>(E src, T rep = default)
            where E : Enum
            where T : struct
                => new GEnum<E, T>(src);

        /// <summary>
        /// Creates a generic enum value from a value of the underlying scalar type
        /// </summary>
        /// <param name="scalar">The scalar value</param>
        /// <param name="rep">A representative value of the enum, used only for type inference</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static GEnum<E,T> FromScalar<E,T>(T scalar, E rep = default)
            where E : Enum
            where T : struct
                => new GEnum<E, T>(Unsafe.As<T,E>(ref scalar));

        /// <summary>
        /// Attemts to parse an enum from a label
        /// </summary>
        /// <param name="label">The label</param>
        /// <param name="rep">A representative value of the enum, used only for type inference</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static Option<GEnum<E>> Parse<E>(string label, E rep = default)
            where E : Enum
                => GEnum<E>.Parse(label);

        /// <summary>
        /// Attemts to parse an enum from a label
        /// </summary>
        /// <param name="label">The label</param>
        /// <param name="eRep">A representative value of the enum, used only for type inference</param>
        /// <param name="sRep">A representative value of the underlying scalar, used only for type inference</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The underlying scalar type</typeparam>
        [MethodImpl(Inline)]
        public static Option<GEnum<E,T>> Parse<E,T>(string label, E eRep = default, T sRep = default)
            where E : Enum
            where T : struct
                => GEnum<E,T>.Parse(label);

        /// <summary>
        /// Returns a (label,value) pair for each enumeration literal
        /// </summary>
        /// <param name="label">The literal identifier</param>
        /// <param name="value">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static (string label, E value)[] LabeledValues<E>()
            where E : Enum
                => GEnum<E>.Labels.Zip(GEnum<E>.Values).ToArray();

        /// <summary>
        /// Returns a (label,scalar) pair for each enumeration literal
        /// </summary>
        /// <param name="label">The literal identifier</param>
        /// <param name="scalar">The underlying scalar value</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The underlying scalar type</typeparam>
        [MethodImpl(Inline)]
        public static (string label, T scalar)[] LabeledScalars<E,T>()
            where E : Enum
            where T : struct
                => GEnum<E,T>.Labels.Zip(GEnum<E,T>.Scalars).ToArray();

        /// <summary>
        /// Returns a (label,value,scalar) triple for each enumeration literal
        /// </summary>
        /// <param name="label">The literal identifier</param>
        /// <param name="value">The enumeration value</param>
        /// <param name="scalar">The underlying scalar value</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The underlying scalar type</typeparam>
        public static (string label, E value, T scalar)[] LabeledValues<E,T>()
            where E : Enum
            where T : struct
        {
            var dst = new (string,E,T)[GEnum<E,T>.Labels.Length];
            for(var i=0; i<dst.Length; i++)
                dst[i] = (GEnum<E,T>.Labels[i], GEnum<E,T>.Values[i], GEnum<E,T>.Scalars[i]);
            return dst;
        }
    }
}