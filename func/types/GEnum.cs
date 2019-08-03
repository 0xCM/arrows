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

    public static class GEnum
    {
        public static GEnum<E> ToGeneric<E>(this E src)
            where E : Enum
                => new GEnum<E>(src);

        /// <summary>
        /// Attemts to parse an enum from a label
        /// </summary>
        /// <param name="label">The label</param>
        /// <typeparam name="E">The enum type</typeparam>
        public static Option<GEnum<E>> Parse<E>(string label)
            where E : Enum
                => GEnum<E>.Parse(label);

        /// <summary>
        /// Attemts to parse an enum from a label
        /// </summary>
        /// <param name="label">The label</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The underlying scalar type</typeparam>
        public static Option<GEnum<E,T>> Parse<E,T>(string label)
            where E : Enum
            where T : struct
                => GEnum<E,T>.Parse(label);

        /// <summary>
        /// Returns a (label,value) pair for each enumeration literal
        /// </summary>
        /// <param name="label">The literal identifier</param>
        /// <param name="value">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
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

        public static GEnum<E,T> ToGeneric<E,T>(this E src)
            where E : Enum
            where T : struct
                => new GEnum<E, T>(src);
        public static GEnum<E,T> FromScalar<E,T>(T scalar)
            where E : Enum
            where T : struct
                => new GEnum<E, T>(Unsafe.As<T,E>(ref scalar));

    }

    /// <summary>
    /// Makes enums suck less
    /// </summary>
    /// <typeparam name="E">The enum type</typeparam>
    /// <typeparam name="T">The underlying type</typeparam>
    public readonly struct GEnum<E>
        where E : Enum
    {        
        public static Option<GEnum<E>> Parse(string Label)
        {
            if(ValueIndex.TryGetValue(Label, out E value))
                return new GEnum<E>(value);
            else
                return default;
        }

        /// <summary>
        /// Implicitly forms a generic enum representation from a source value
        /// </summary>
        /// <param name="src">The soruce value</param>
        public static implicit operator GEnum<E>(E src)
            => new GEnum<E>(src);

        /// <summary>
        /// Implicitly casts the generic enum representation to an enum value
        /// </summary>
        /// <param name="src">The source representation</param>
        public static implicit operator E(GEnum<E> src)
            => src.Value;

        /// <summary>
        /// Implicitly casts the generic enum representation to the identifying label
        /// </summary>
        /// <param name="src">The source representation</param>
        public static implicit operator string(GEnum<E> src)
            => src.Label;
        
        /// <summary>
        /// Specifies the values in the enum domain for which explicit labels exist
        /// </summary>
        public static readonly E[] Values 
            = typeof(E).GetEnumValues().AsQueryable().Cast<E>().ToArray();


        /// <summary>
        /// Correlates a 0-based index with the declared literals in an enum
        /// </summary>
        public static readonly string[] Labels
            = typeof(E).GetEnumNames();

        static readonly Dictionary<E,int> PositionIndex
            = Values.Mapi((i,v) => (v,i)).ToDictionary();

        static readonly Dictionary<string,E> ValueIndex
            = Values.Mapi((i,v) => (Labels[i], v)).ToDictionary();

        public GEnum(E value)
            => this.Value = value;

        /// <summary>
        /// The value of the enum as an enum value
        /// </summary>
        public readonly E Value;

        /// <summary>
        /// The identifying label
        /// </summary>
        public string Label
            => Value.ToString();

    }

    /// <summary>
    /// Makes enums suck less
    /// </summary>
    /// <typeparam name="E">The enum type</typeparam>
    /// <typeparam name="T">The underlying type</typeparam>
    public readonly struct GEnum<E,T>
        where E : Enum
        where T : struct
    {
        
        public static Option<GEnum<E,T>> Parse(string Label)
        {
            if(ValueIndex.TryGetValue(Label, out E value))
                return new GEnum<E,T>(value);
            else
                return default;
        }

        /// <summary>
        /// Implicitly forms a generic enum representation from a source value
        /// </summary>
        /// <param name="src">The soruce value</param>
        public static implicit operator GEnum<E,T>(E src)
            => new GEnum<E, T>(src);

        /// <summary>
        /// Implicitly casts the generic enum representation to an enum value
        /// </summary>
        /// <param name="src">The source representation</param>
        public static implicit operator E(GEnum<E,T> src)
            => src.Value;

        /// <summary>
        /// Implicitly casts the generic enum representation to the identifying label
        /// </summary>
        /// <param name="src">The source representation</param>
        public static implicit operator string(GEnum<E,T> src)
            => src.Label;

        /// <summary>
        /// Implicitly casts the generic enum representation to the underlying scalar value
        /// </summary>
        /// <param name="src">The source representation</param>
        public static implicit operator T(GEnum<E,T> src)
            => src.Scalar;

        /// <summary>
        /// Specifies the values in the enum domain for which explicit labels exist
        /// </summary>
        public static readonly E[] Values 
            = typeof(E).GetEnumValues().AsQueryable().Cast<E>().ToArray();

        public static readonly T[] Scalars 
            = typeof(E).GetEnumValues().AsQueryable().Cast<T>().ToArray();

        /// <summary>
        /// Correlates a 0-based index with the declared literals in an enum
        /// </summary>
        public static readonly string[] Labels
            = typeof(E).GetEnumNames();

        static readonly Dictionary<E,int> PositionIndex
            = Values.Mapi((i,v) => (v,i)).ToDictionary();

        static readonly Dictionary<string,E> ValueIndex
            = Values.Mapi((i,v) => (Labels[i], v)).ToDictionary();
        

        public GEnum(E value)
            => this.Value = value;

        /// <summary>
        /// The value of the enum as an enum value
        /// </summary>
        public readonly E Value;

        /// <summary>
        /// The underlying scalar value of the enum
        /// </summary>
        public T Scalar
            => Scalars[PositionIndex[Value]];

        /// <summary>
        /// The identifying label
        /// </summary>
        public string Label
            => Value.ToString();

    }

}