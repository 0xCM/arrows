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
    public readonly struct EnumG<E>
        where E : Enum
    {                    

        [MethodImpl(Inline)]
        public static Option<EnumG<E>> Parse(string Label)
            => EnumValues.Get<E>().Parse(Label).TryMap(x => EnumValues.ToGeneric(x));

        /// <summary>
        /// Implicitly forms a generic enum representation from a source value
        /// </summary>
        /// <param name="src">The soruce value</param>
        [MethodImpl(Inline)]
        public static implicit operator EnumG<E>(E src)
            => new EnumG<E>(src);

        /// <summary>
        /// Implicitly casts the generic enum representation to an enum value
        /// </summary>
        /// <param name="src">The source representation</param>
        [MethodImpl(Inline)]
        public static implicit operator E(EnumG<E> src)
            => src.Value;

        /// <summary>
        /// Implicitly casts the generic enum representation to the identifying label
        /// </summary>
        /// <param name="src">The source representation</param>
        public static implicit operator string(EnumG<E> src)
            => src.Label;
        
        [MethodImpl(Inline)]
        public EnumG(E value)
            => this.Value = value;

        /// <summary>
        /// The value of the enum as an enum value
        /// </summary>
        public readonly E Value;

        /// <summary>
        /// The identifying label
        /// </summary>
        public string Label
        {
            [MethodImpl(Inline)]
            get => Value.ToString();
        }

        [MethodImpl(Inline)]
        public T Scalar<T>()
            where T : unmanaged
                => EnumValues.Get<E,T>().ToScalar(Value);
    }

    /// <summary>
    /// Makes enums suck less
    /// </summary>
    /// <typeparam name="E">The enum type</typeparam>
    /// <typeparam name="T">The underlying type</typeparam>
    public readonly struct EnumG<E,T>
        where E : Enum
        where T : unmanaged
    {                
        /// <summary>
        /// The encapsulated value
        /// </summary>
        public readonly E Value;


        static readonly EnumValues<E,T> _Values = EnumValues.Get<E,T>();

        public static ReadOnlySpan<E> Values 
            => _Values.ToSpan();
        
        [MethodImpl(Inline)]
        public static Option<EnumG<E,T>> Parse(string Label)
            => _Values.Parse(Label).TryMap(x => new EnumG<E, T>(x));

        /// <summary>
        /// Implicitly forms a generic enum representation from a source value
        /// </summary>
        /// <param name="src">The soruce value</param>
        [MethodImpl(Inline)]
        public static implicit operator EnumG<E,T>(E src)
            => new EnumG<E, T>(src);

        /// <summary>
        /// Implicitly casts the generic enum representation to an enum value
        /// </summary>
        /// <param name="src">The source representation</param>
        [MethodImpl(Inline)]
        public static implicit operator E(EnumG<E,T> src)
            => src.Value;

        /// <summary>
        /// Implicitly casts the generic enum representation to the identifying label
        /// </summary>
        /// <param name="src">The source representation</param>
        [MethodImpl(Inline)]
        public static implicit operator string(EnumG<E,T> src)
            => src.Label;

        /// <summary>
        /// Implicitly casts the generic enum representation to the underlying scalar value
        /// </summary>
        /// <param name="src">The source representation</param>
        [MethodImpl(Inline)]
        public static implicit operator T(EnumG<E,T> src)
            => src.Scalar;


        [MethodImpl(Inline)]
        public EnumG(E value)
            => this.Value = value;

        /// <summary>
        /// The underlying scalar value of the enum
        /// </summary>
        public T Scalar
            => _Values.ToScalar(Value);

        /// <summary>
        /// The identifying label
        /// </summary>
        public string Label
            => Value.ToString();
    }
}