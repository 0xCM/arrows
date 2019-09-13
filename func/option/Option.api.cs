//-------------------------------------------------------------------------------------------
// MetaCore
// Author: Chris Moore, 0xCM@gmail.com
// License: MIT
//-------------------------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    public static class Option
    {
        /// <summary>
        /// Defines a T-option with no value together with an optional message
        /// </summary>
        /// <typeparam name="T">The underlying type</typeparam>
        /// <param name="message">A related message, if any</param>
        internal static Option<T> none<T>()
            => Option<T>.None();

        /// <summary>
        /// Defines a valued option win an optional message
        /// </summary>
        /// <typeparam name="T">The underlying type</typeparam>
        /// <param name="value">The option value</param>
        /// <param name="message">A related message, if any</param>
        /// <returns></returns>
        internal static Option<T> some<T>(T value)
            => Option<T>.Some(value);

        /// <summary>
        /// Implements the canonical join operation that reduces the monadic depth by one level
        /// </summary>
        /// <typeparam name="T">The encapsulated value</typeparam>
        /// <param name="option"></param>
        /// <returns></returns>
        public static Option<T> collapse<T>(Option<Option<T>> option)
            => option.ValueOrDefault(none<T>());

        /// <summary>
        /// Classifies the value as some or none and manufactures the appropriate option encapsulation
        /// </summary>
        /// <typeparam name="T">The type of value</typeparam>
        /// <param name="value">The value to lift into option-space</param>
        /// <returns></returns>
        public static Option<T> eval<T>(T value)
            where T : class
                => value is null ? none<T>()  : some(value);

        /// <summary>
        /// Defines canonical functor for <see cref="Option{T}"/>
        /// </summary>
        /// <typeparam name="A">The source type</typeparam>
        /// <typeparam name="B">The target type</typeparam>
        /// <param name="f"></param>
        /// <returns></returns>
        public static Func<Option<A>, Option<B>> fmap<A, B>(Func<A, B> f)
            => x => x.TryMap(a => f(a));

        /// <summary>
        /// Implements the canonical bind operation
        /// </summary>
        /// <typeparam name="X">The source domain type</typeparam>
        /// <typeparam name="Y">The target domain type</typeparam>
        /// <param name="x">The point in the monadic space over X</param>
        /// <param name="f">The function to apply to effect the bind</param>
        /// <returns></returns>
        public static Option<Y> bind<X, Y>(Option<X> x, Func<X, Option<Y>> f)
            => x ? f(x.ValueOrDefault()) : none<Y>();        

        /// <summary>
        ///  Determines whether the values of the operands are identical
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <typeparam name="T">The option value type</typeparam>
        public static bool eq<T>(Option<T> x, Option<T> y)
        {
            if (!x.Exists && !y.Exists)
                return true;

            if (x.Exists && y.Exists)
                return  Object.Equals(x.ValueOrDefault(), y.ValueOrDefault());

            return false;
        }

        /// <summary>
        /// Formats the the option for display
        /// </summary>
        /// <typeparam name="X">The underlying type</typeparam>
        /// <param name="x">The potential value</param>
        public static string format<X>(in Option<X> x)
            => x.MapValueOrElse(value => value?.ToString() ?? string.Empty, () => string.Empty);

        /// <summary>
        /// Returns the first option with a value, if possible; otherwise, raises an exception
        /// </summary>
        /// <typeparam name="K">A constraint to which all supplied options conform</typeparam>
        /// <param name="options">To options to search</param>
        /// <returns></returns>
        public static K first<K>(params IOption[] options)
            => (K)options.First(o => o.IsSome).Value;
    }
}