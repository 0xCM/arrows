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

    using static zcore;
    using static Z0.Traits;

    partial class xcore
    {
        [MethodImpl(Inline)]
        public static T ValueOrDefault<T>(this T? x, T @default = default)
            where T : struct
                => x != null ? x.Value : @default;

        [MethodImpl(Inline)]
        public static T ValueOrElse<T>(this T? x,  Func<T> @else)
            where T : struct
                => x != null ? x.Value : @else();

        [MethodImpl(Inline)]
        public static T ValueOrElse<T>(this T? x, T @else)
            where T : struct
                => x != null ? x.Value : @else;

        [MethodImpl(Inline)]
        public static S MapValueOrDefault<T, S>(this T? x, Func<T, S> f, S @default = default(S))
            where T : struct
                => x != null ? f(x.Value) : @default;

        [MethodImpl(Inline)]
        public static S? TryMapValue<T, S>(this T? x, Func<T, S> f)
            where T : struct
            where S : struct
                => x != null ? f(x.Value) : (S?)null;

        [MethodImpl(Inline)]
        public static S Map<T, S>(this T? x, Func<T, S> ifSome, Func<S> ifNone)
            where T : struct
                 => x != null ? ifSome(x.Value) : ifNone();


        [MethodImpl(Inline)]
        public static S MapValueOrElse<T, S>(this T? x, Func<T, S> f, Func<S> @else)
            where T : struct
                => x != null ? f(x.Value) : @else();


        /// <summary>
        /// Transforms a nulluble value into an optional value
        /// </summary>
        /// <typeparam name="T">The underlying value type</typeparam>
        /// <param name="x">The potential value</param>
        [MethodImpl(Inline)]
        public static Option<T> ValueOrNone<T>(this T? x)
            where T : struct
                => x != null ? x.Value : none<T>();

        [MethodImpl(Inline)]
        public static void OnValue<T>(this T? x, Action<T> action)
            where T : struct
                => onTrue(x.HasValue, () => action(x.Value));


        [MethodImpl(Inline)]
        public static IEnumerable<Option<T>> Condense<T>(this IEnumerable<IEnumerable<Option<T>>> options)
            => options.SelectMany(x => x);

        /// <summary>
        /// Extracts the encapsluated value if present; otherwise reutrns the underlying value type default
        /// </summary>
        /// <typeparam name="T">The value type</typeparam>
        /// <param name="x"></param>
        [MethodImpl(Inline)]
        public static T Value<T>(this Option<T?> x)
            where T : struct => x.ValueOrElse(() => default(T)).Value;

        /// <summary>
        /// Extracts the encapsluated value if present; otherwise returns the default value of the type
        /// </summary>
        /// <typeparam name="T">The value type</typeparam>
        /// <param name="x">The optional value</param>
        [MethodImpl(Inline)]
        public static T Value<T>(this Option<T> x)
            where T : struct => x.ValueOrDefault();

        [MethodImpl(Inline)]
        public static IReadOnlyList<P> Items<P>(this Option<IReadOnlyList<P>> x)
            => x.ValueOrElse(() => new P[]{});

        [MethodImpl(Inline)]
        public static IEnumerable<T> Items<T>(this Option<IEnumerable<T>> x, Action error = null)
        {

            if (x)
                return x.ValueOrDefault();
            else
            {
                error?.Invoke();
                return new T[] { };
            }
        }

        [MethodImpl(Inline)]
        public static P First<P>(this Option<IReadOnlyList<P>> x)
            => x.Items().First();

        [MethodImpl(Inline)]
        public static P FirstOrDefault<P>(this Option<IReadOnlyList<P>> x)
            => x.Items().FirstOrDefault();

        /// <summary>
        /// Extracts the encapsulated values from a sequence of optional values (where Some)
        /// </summary>
        /// <typeparam name="T">The value type</typeparam>
        /// <param name="options">The options to examine</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static IEnumerable<T> Values<T>(this IEnumerable<Option<T>> options)
            => options.WhereSome().Select(x => x.ValueOrDefault());

        [MethodImpl(Inline)]
        public static T SingleOrDefault<T>(this Option<IEnumerable<T>> x)
            => x.MapValueOrDefault(seq => seq.SingleOrDefault());

        [MethodImpl(Inline)]
        public static T First<T>(this Option<IEnumerable<T>> x)
            => x.MapRequired(y => y.First());

        [MethodImpl(Inline)]
        public static T FirstOrDefault<T>(this Option<IEnumerable<T>> x)
            => x.MapValueOrDefault(seq => seq.FirstOrDefault());

        [MethodImpl(Inline)]
        public static T Single<T>(this Option<T> x)
            where T : IEnumerable<T>
                => x.MapRequired(z => z.Single());

        /// <summary>
        /// Transforms a <see cref="Option{T}"/> into a <see cref="Nullable{T}"/> when T is a CLR value type
        /// </summary>
        /// <typeparam name="T">The underlying CLR value type</typeparam>
        /// <param name="x">The potential value</param>
        [MethodImpl(Inline)]
        public static T? ToNullable<T>(this Option<T> x) where T : struct
            => x.IsSome() ? new T?(x.ValueOrDefault()) : new T?();


        [MethodImpl(Inline)]
        public static Option<T> TryGetFirst<T>(IEnumerable<Option<T>> potentials)
        {
            var o = potentials.TryFind(x => x.IsSome());
            return o.IsSome() ? o.Value() : none<T>();
        }

        /// <summary>
        /// Returns the first valued option from those supplied, if any
        /// </summary>
        /// <typeparam name="T">The potential value type</typeparam>
        /// <param name="potentials"></param>
        [MethodImpl(Inline)]
        public static Option<T> TryGetFirst<T>(params Option<T>[] potentials)
            => TryGetFirst((IEnumerable<Option<T>>)potentials);

        /// <summary>
        /// Selects the subsequence for which values exist, if any
        /// </summary>
        /// <typeparam name="T">The potential value type</typeparam>
        /// <param name="options">The sequence of options to examine</param>
        [MethodImpl(Inline)]
        public static IEnumerable<Option<T>> WhereNone<T>(this IEnumerable<Option<T>> options)
            => from option in options where option.IsNone() select option;

        /// <summary>
        /// Selects the subsequence for which values exist, if any
        /// </summary>
        /// <typeparam name="T">The potential value type</typeparam>
        /// <param name="options">The sequence of options to examine</param>
        [MethodImpl(Inline)]
        public static IEnumerable<Option<T>> WhereSome<T>(this IEnumerable<Option<T>> options)
            => from option in options where option.IsSome() select option;

        /// <summary>
        /// Applies a map to a valued option; otherwise, raises an exception
        /// </summary>
        /// <typeparam name="X">The source type</typeparam>
        /// <typeparam name="Y">The target type</typeparam>
        /// <param name="x"></param>
        /// <param name="F"></param>
        [MethodImpl(Inline)]
        public static Y MapRequired<X, Y>(this Option<X> x, Func<X, Y> F)
            => F(x.Require());

        /// <summary>
        /// Returns true if an optioal value exists an a specified predicate over the value is satisfied
        /// </summary>
        /// <typeparam name="T">The value type</typeparam>
        /// <param name="x">The value to examine</param>
        /// <param name="predicate">The adjudicating predicate</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static bool Satisfies<T>(this Option<T> x, Predicate<T> predicate)
            => x.TryMap(y => predicate(y)).ValueOrDefault();

        /// <summary>
        /// Bifurcates a stream of optional values into the haves/have nots
        /// </summary>
        /// <typeparam name="T">The optional value type</typeparam>
        /// <param name="options">The stream of options to evaluate</param>
        public static (IEnumerable<Option<T>> Left, IEnumerable<T> Right) Split<T>(this IEnumerable<Option<T>> options)
            => (options.WhereNone(), options.WhereSome().Select(x => x.ValueOrDefault()));

        /// <summary>
        /// Evaluates to true iff all options have values
        /// </summary>
        /// <param name="options">The options to evaluate</param>
        [MethodImpl(Inline)]
        public static bool All(params IOption[] options)
            => options.All(o => o.IsSome);

        /// <summary>
        /// Invokes an action when all supplied options have value
        /// </summary>
        /// <typeparam name="X1">The type of the first potential item</typeparam>
        /// <typeparam name="X2">The type of the second potential item</typeparam>
        /// <param name="x1">The first potential value</param>
        /// <param name="x2">The second potential value</param>
        /// <param name="f">The action to conditionally invoke</param>
        [MethodImpl(Inline)]
        public static void WhenAll<X1, X2>(Option<X1> x1, Option<X2> x2, Action<X1, X2> f)
            => onTrue(All(x1,x2), () => f(x1.Require(), x2.Require()));

        /// <summary>
        /// Invokes the supplied action if all values exist
        /// </summary>
        /// <typeparam name="X1">The type of the first potential value</typeparam>
        /// <typeparam name="X2">The type of the second potential value</typeparam>
        /// <typeparam name="X3">The type of the third potential value</typeparam>
        /// <param name="x1">The first potential value</param>
        /// <param name="x2">The second potential value</param>
        /// <param name="x3">The third potential value</param>
        /// <param name="f">The action to conditionally invoke</param>
        [MethodImpl(Inline)]
        public static void WhenAll<X1, X2, X3>(Option<X1> x1, Option<X2> x2, Option<X3> x3, Action<X1, X2, X3> f)
            => onTrue(All(x1,x2,x3), () => f(x1.Require(), x2.Require(), x3.Require()));        
    }
}