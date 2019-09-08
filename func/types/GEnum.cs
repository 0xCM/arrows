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

    /// <summary>
    /// Makes enums suck less
    /// </summary>
    /// <typeparam name="E">The enum type</typeparam>
    /// <typeparam name="T">The underlying type</typeparam>
    public readonly struct GEnum<E>
        where E : Enum
    {        
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
            
        static readonly Dictionary<string,E> ValIndex
            = Values.Mapi((i,v) => (Labels[i], v)).ToDictionary();

        [MethodImpl(Inline)]
        public static Option<GEnum<E>> Parse(string Label)
        {
            if(ValIndex.TryGetValue(Label, out E value))
                return new GEnum<E>(value);
            else
                return default;
        }

        /// <summary>
        /// Implicitly forms a generic enum representation from a source value
        /// </summary>
        /// <param name="src">The soruce value</param>
        [MethodImpl(Inline)]
        public static implicit operator GEnum<E>(E src)
            => new GEnum<E>(src);

        /// <summary>
        /// Implicitly casts the generic enum representation to an enum value
        /// </summary>
        /// <param name="src">The source representation</param>
        [MethodImpl(Inline)]
        public static implicit operator E(GEnum<E> src)
            => src.Value;

        /// <summary>
        /// Implicitly casts the generic enum representation to the identifying label
        /// </summary>
        /// <param name="src">The source representation</param>
        public static implicit operator string(GEnum<E> src)
            => src.Label;
        
        [MethodImpl(Inline)]
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

        [MethodImpl(Inline)]
        public T Scalar<T>()
            where T : unmanaged
                => (T)Convert.ChangeType(Value, typeof(T));
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
        
        [MethodImpl(Inline)]
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
        [MethodImpl(Inline)]
        public static implicit operator GEnum<E,T>(E src)
            => new GEnum<E, T>(src);

        /// <summary>
        /// Implicitly casts the generic enum representation to an enum value
        /// </summary>
        /// <param name="src">The source representation</param>
        [MethodImpl(Inline)]
        public static implicit operator E(GEnum<E,T> src)
            => src.Value;

        /// <summary>
        /// Implicitly casts the generic enum representation to the identifying label
        /// </summary>
        /// <param name="src">The source representation</param>
        [MethodImpl(Inline)]
        public static implicit operator string(GEnum<E,T> src)
            => src.Label;

        /// <summary>
        /// Implicitly casts the generic enum representation to the underlying scalar value
        /// </summary>
        /// <param name="src">The source representation</param>
        [MethodImpl(Inline)]
        public static implicit operator T(GEnum<E,T> src)
            => src.Scalar;

        /// <summary>
        /// Specifies the values in the enum domain for which explicit labels exist
        /// </summary>
        public static readonly E[] Values 
            = typeof(E).GetEnumValues().AsQueryable().Cast<E>().ToArray();

        [MethodImpl(Inline)]
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