//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static corefunc;

    /// <summary>
    /// Represents a potential value
    /// </summary>
    public readonly struct Option<T> 
    {
        public static readonly Option<T> None = default;

        [MethodImpl(Inline)]
        public static implicit operator Option<T>(T potential)
            => potential != null ? some(potential) : none<T>();
            
        readonly T potential;
        
        readonly bool realized;

        [MethodImpl(Inline)]
        public Option(T value)
        {
            potential = value;
            realized = value != null;
        }

        public bool exists 
            => realized;

        T value 
            => realized ? potential 
            : throw new ArgumentNullException();

        /// <summary>
        /// Applies a function to the encapsulated value if it exists
        /// </summary>
        /// <param name="f">The function to apply</param>
        /// <typeparam name="S">The function codomain type</typeparam>
        [MethodImpl(Inline)]
        public Option<S> trymap<S>(Func<T,S> f)
            => exists ? f(value) : Option<S>.None;

        /// <summary>
        /// Applies a function to the encapsulated value if it exists 
        /// otherwise, applies a function to a supplied value
        /// </summary>
        /// <param name="f">The function to apply</param>
        /// <typeparam name="S">The function codomain type</typeparam>
        public S map<S>(Func<T,S> f, T @default = default)
            => exists ? f(value) : f(@default);

        /// <summary>
        /// Returns the encapsulated value if it exists; otherwise,
        /// returns a default value
        /// </summary>
        [MethodImpl(Inline)]
        public T extract(T @default = default)
            => exists ? value : @default;
        
        /// <summary>
        /// Returns the encapsulated value if it exists; otherwise,
        /// raises an error
        /// </summary>
        [MethodImpl(Inline)]
        public T require()
            => exists ? value : throw new ArgumentException();
    }


}