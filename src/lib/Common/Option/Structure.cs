//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Z0.Traits;


    partial class Traits
    {
    
        /// <summary>
        /// Characterizes an untyped optional value
        /// </summary>
        public interface IOption
        {
            /// <summary>
            /// The encapsualted value, if any
            /// </summary>
            object Value { get; }

            /// <summary>
            /// True if a value does exists, false otherwise
            /// </summary>
            bool IsSome { get; }

            /// <summary>
            /// True if a value does not exist, false otherwise
            /// </summary>
            bool IsNone { get; }

            /// <summary>
            /// The type of the encapsulated value, if present
            /// </summary>
            Type ValueType { get; }
        }

        /// <summary>
        /// Characterizes an typed optional value
        /// </summary>
        public interface IOption<T> : IOption
        {
            /// <summary>
            /// The encapsualted value, if any
            /// </summary>
            new T Value { get; }
        }
    }

    /// <summary>
    /// Represents a potential value
    /// </summary>
    /// <typeparam name="T">The potential value type</typeparam>
    public readonly struct Option<T> : IEquatable<Option<T>>, IOption<T>
    {
        /// <summary>
        /// Defines a non-valued option
        /// </summary>
        /// <returns></returns>
        public static Option<T> None()
            => new Option<T>();
        
        /// <summary>
        /// Defines a valued option
        /// </summary>
        /// <param name="Value">The encapsulated value</param>
        /// <returns></returns>
        public static Option<T> Some(T Value)
            => new Option<T>(Value);


        public static explicit operator T(Option<T> x)
            => x ? x.value : throw new ArgumentNullException();

        public static T operator ~ (Option<T> x)
            => x ? x.value : throw new ArgumentNullException();
        
        public static implicit operator Option<T>(T x)
            => x != null  ? Some(x) : None();

        /// <summary>
        /// Implmements value-based equality
        /// </summary>
        /// <param name="lhs">The first value</param>
        /// <param name="rhs">The second value</param>
        public static bool operator == (Option<T> lhs, Option<T> rhs)
            => (lhs.IsNone() && rhs.IsNone())  
                ? true 
                : (lhs.Exists && rhs.Exists && lhs.value.Equals(rhs.value));

        /// <summary>
        /// Implements value-based equality negation
        /// </summary>
        /// <param name="lhs">The first value</param>
        /// <param name="rhs">The second value</param>
        public static bool operator != (Option<T> lhs, Option<T> rhs)
            => !(lhs == rhs);

        /// <summary>
        /// Returns true if the option has a value and false otherwise
        /// </summary>
        /// <param name="x">The option to test</param>
        public static bool operator true(Option<T> x)
            => x.Exists;

        /// <summary>
        /// Returns false if the option is non-valued and true otherwise
        /// </summary>
        /// <param name="x">The option to test</param>
        public static bool operator false(Option<T> x)
            => !x.Exists;

        /// <summary>
        /// Returns false if the option is non-valued and true otherwise
        /// </summary>
        /// <param name="x">The option to test</param>
        public static bool operator !(Option<T> x)
            => !x.Exists;

        /// <summary>
        /// The encapsulated value, iff Exists is true
        /// </summary>
        readonly T value;

        Option(bool isSome, T value)
        {
            this.Exists = isSome;
            this.value = value;
        }

        /// <summary>
        /// Initializes a valued option
        /// </summary>
        /// <param name="value">The encapsulated value</param>
        /// <param name="message">An optional message</param>
        public Option(T value)
        {
            if (value is IOption)
            {
                var o = value as IOption;
                this.Exists = o.IsSome;
                this.value = this.Exists ?
                    (o.Value is T ? (T)o.Value : value)                
                    : default;
            }
            else
            {
                this.Exists = (value != null);
                this.value = value;
            }
            
        }



        /// <summary>
        /// Specifies whether the option has a value
        /// </summary>
        public bool Exists { get; }


        /// <summary>
        /// Returns true if the value exists
        /// </summary>
        /// <returns></returns>
        public bool IsSome()
            => Exists;

        /// <summary>
        /// Returns true if the value does not exist
        /// </summary>
        /// <returns></returns>
        public bool IsNone()
            => !Exists;

        /// <summary>
        /// Applies the a function to evaluate the underlying value if it exists
        /// </summary>
        /// <typeparam name="X"></typeparam>
        /// <param name="F"></param>
        /// <returns></returns>
        public Option<X> IfSome<X>(Func<T, X> F)
            => Exists ? F(value) : Option.none<X>();

        /// <summary>
        /// Invokes an action if the value exists
        /// </summary>
        /// <param name="ifSome">The action to potentially ivoke</param>
        /// <returns></returns>
        public Option<T> OnSome(Action<T> ifSome)
        {
            if (Exists)
                ifSome(value);
            return this;
        }


        /// <summary>
        /// Invokes an action if the value doesn't exist
        /// </summary>
        /// <param name="ifNone">The action to invoke</param>
        /// <returns></returns>
        public Option<T> OnNone(Action ifNone)
        {
            if (IsNone())
                ifNone();
            return this;
        }
            

        /// <summary>
        /// Yields the encapulated value if present; otherwise, raises an exception
        /// </summary>
        /// <returns></returns>
        public T Require(
            [CallerMemberName] string caller = null, 
            [CallerFilePath] string file = null, 
            [CallerLineNumber] int linenumber = 0)
                =>  Exists ? value : throw new Exception<T>("Value doesn't exist", caller, file, linenumber);
        

        static readonly T _Default = default;
            
        public T Default 
            => _Default;

        T IOption<T>.Value 
            => value;

        object IOption.Value 
            => value;

        bool IOption.IsSome 
            => Exists;

        bool IOption.IsNone 
            => !Exists;

        /// <summary>
        /// The type of the encapsulated value, if present
        /// </summary>
        public Type ValueType
            => typeof(T);

        /// <summary>
        /// Extracts the encapulated value if it exists; otherwise, returns the default value for
        /// the underlying type which is NULL for reference types
        /// </summary>
        /// <param name="default"></param>
        /// <returns></returns>
        public T ValueOrDefault(T @default = default(T))
            => Exists ? value : @default;

        /// <summary>
        /// Returns the encapsulated value if it exists; otherwise, invokes the fallback function <paramref name="fallback"/>
        /// to obtain value
        /// </summary>
        /// <param name="fallback"></param>
        /// <returns></returns>
        public T ValueOrElse(Func<T> fallback)
            => Exists ? value : fallback();

        /// <summary>
        /// Applies supplied function to value if present, otherwise invokes fallback <paramref name="fallback"/>
        /// </summary>
        /// <typeparam name="S">The output type</typeparam>
        /// <param name="f">The function to apply when value exists</param>
        /// <param name="fallback">The function to invoke when no value exists</param>
        /// <returns></returns>
        public S Map<S>(Func<T, S> f, Func<S> fallback)
            => Exists  ? f(value)  : fallback();


        /// <summary>
        /// Applies a function to value if present, otherwise returns None
        /// </summary>
        /// <typeparam name="S">The output type</typeparam>
        /// <param name="f">The function to apply when value exists</param>
        /// <returns></returns>
        public Option<S> TryMap<S>(Func<T, S> f)
            => Exists ? Option.some(f(value)) : Option.none<S>();

        /// <summary>
        /// Transforms the value, if present, otherwise invokes a function
        /// to produce an appropriate value of the target type if not
        /// </summary>
        /// <typeparam name="S">The target type</typeparam>
        /// <param name="ifSome">The transformer</param>
        /// <param name="fallback">The alternate transformer</param>
        /// <returns></returns>
        public S MapValueOrElse<S>(Func<T, S> ifSome, Func<S> fallback)
            => Exists  ? ifSome(value)  : fallback();


        /// <summary>
        /// Applies a function to the encapsulated value if it exists; otherwise, returns a default value
        /// </summary>
        /// <typeparam name="S">The projected value type</typeparam>
        /// <param name="ifSome">The function to apply when a value exists</param>
        /// <param name="default">The value to return when no value exists</param>
        /// <returns></returns>
        public S MapValueOrDefault<S>(Func<T, S> ifSome, S @default = default)
            => Exists ? ifSome(value) :  @default;

        /// <summary>
        /// Drops the encapsulated value, if any, and projects None to target space
        /// </summary>
        /// <typeparam name="S">The target space type</typeparam>
        /// <returns></returns>
        public  Option<S> ToNone<S>()
            => Option.none<S>();


        /// <summary>
        /// LINQ integration function
        /// </summary>
        /// <typeparam name="Y"></typeparam>
        /// <param name="apply"></param>
        /// <returns></returns>    
        public Option<Y> Select<Y>(Func<T, Y> apply)
            => TryMap(_x => apply(_x));

        /// <summary>
        /// LINQ integration function
        /// </summary>
        /// <typeparam name="Y"></typeparam>
        /// <typeparam name="Z"></typeparam>
        /// <param name="eval"></param>
        /// <param name="project"></param>
        /// <returns></returns>
        public Option<Z> SelectMany<Y, Z>(Func<T, Option<Y>> eval, Func<T, Y, Z> project)
        {
            if (Exists)
            {
                var v = value;
                var y = eval(v);
                var z = Option.bind(y, yVal => Option.some(project(v, yVal)));
                return z;
            }
            else
                return Option.none<Z>();
        }

        /// <summary>
        /// LINQ integration function
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public Option<T> Where(Func<T, bool> predicate)
        {
            if (Exists)
            {
                if (predicate(value))
                    return value;
                else
                    return new Option<T>();
            }
            else
                return value;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (Exists)
            {
                if (obj is IOption)
                {
                    var other = obj as IOption;
                    if (other.IsSome)
                        return object.Equals(value, other.Value);
                    else
                        return false;
                }
                else if (obj is T)
                    return object.Equals(this.value, obj);
                else
                    return false;
            }
            else
            {
                if (obj is Option<T>)
                    return (obj as IOption).IsNone;
                else
                    return false;
            }
        }

        public override int GetHashCode()
            => Exists 
            ? value.GetHashCode() 
            : typeof(T).Name.GetHashCode();

        public override string ToString()
            => Option.render(this);

        public bool Equals(Option<T> other)
            => Option.eq(this, other);
    }

    public static class OptionX
    {
        public static Option<int> Condense<T>(this IEnumerable<Option<T>> options)
        {
            var failure = options.Any(o => o.IsNone());
            if (failure)
                return options.First(x => x.IsNone()).ToNone<int>();
            return options.Count();
        }

        /// <summary>
        /// Extracts the encapsluated value if present; otherwise reutrns the underlying value type default
        /// </summary>
        /// <typeparam name="T">The value type</typeparam>
        /// <param name="x"></param>
        /// <returns></returns>
        public static T Value<T>(this Option<T?> x)
            where T : struct => x.ValueOrElse(() => default(T)).Value;

        /// <summary>
        /// Extracts the encapsluated value if present; otherwise returns the default value of the type
        /// </summary>
        /// <typeparam name="T">The value type</typeparam>
        /// <param name="x">The optional value</param>
        /// <returns></returns>
        public static T Value<T>(this Option<T> x)
            where T : struct => x.ValueOrDefault();

        public static IReadOnlyList<P> Items<P>(this Option<IReadOnlyList<P>> x)
            => x.IsSome() ? ~x : new P[] { };

        public static IEnumerable<T> Items<T>(this Option<IEnumerable<T>> x, Action error = null)
        {

            if (x)
            {
                return x.ValueOrDefault();
            }
            else
            {
                error?.Invoke();
                return new T[] { };
            }
        }

        public static P First<P>(this Option<IReadOnlyList<P>> x)
            => x.Items().First();

        public static P FirstOrDefault<P>(this Option<IReadOnlyList<P>> x)
            => x.Items().FirstOrDefault();

        /// <summary>
        /// Extracts the encapsulated values from a sequence of optional values (where Some)
        /// </summary>
        /// <typeparam name="T">The value type</typeparam>
        /// <param name="options">The options to examine</param>
        /// <returns></returns>
        public static IEnumerable<T> Values<T>(this IEnumerable<Option<T>> options)
            => options.WhereSome().Select(x => x.ValueOrDefault());

        public static T SingleOrDefault<T>(this Option<IEnumerable<T>> x)
            => x.MapValueOrDefault(seq => seq.SingleOrDefault());

        public static T First<T>(this Option<IEnumerable<T>> x)
            => x.MapRequired(y => y.First());

        public static T FirstOrDefault<T>(this Option<IEnumerable<T>> x)
            => x.MapValueOrDefault(seq => seq.FirstOrDefault());

        public static T Single<T>(this Option<T> x)
            where T : IEnumerable<T>
                => x.MapRequired(z => z.Single());

        public static Option<T> TryGetSingle<T>(this Option<IReadOnlyList<T>> src)
            => src.TryMap(x => x.SingleOrDefault());

        /// <summary>
        /// Transforms a <see cref="Option{T}"/> into a <see cref="Nullable{T}"/> when T is a CLR value type
        /// </summary>
        /// <typeparam name="T">The underlying CLR value type</typeparam>
        /// <param name="x">The potential value</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T? ToNullable<T>(this Option<T> x) where T : struct
            => x.IsSome() ? new T?(x.ValueOrDefault()) : new T?();


        /// <summary>
        /// Returns the first valued option from those supplied, if any
        /// </summary>
        /// <typeparam name="T">The potential value type</typeparam>
        /// <param name="potentials"></param>
        /// <returns></returns>
        public static Option<T> TryGetFirst<T>(params Option<T>[] potentials)
        {
            foreach (var possibility in potentials)
                if (possibility.IsSome())
                    return possibility;
            return Option.none<T>();
        }

        /// <summary>
        /// Selects subsequence for which no encapsulated value exists
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="options"></param>
        /// <returns></returns>
        public static IEnumerable<Option<T>> WhereNone<T>(this IEnumerable<Option<T>> options)
            => from option in options where option.IsNone() select option;

        /// <summary>
        /// Selects subsequence for which an encapsulated value exists
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="options"></param>
        /// <returns></returns>
        public static IEnumerable<Option<T>> WhereSome<T>(this IEnumerable<Option<T>> options)
            => from option in options where option.IsSome() select option;

        /// <summary>
        /// Applies a map to a valued option; otherwise, raises an exception
        /// </summary>
        /// <typeparam name="X">The source type</typeparam>
        /// <typeparam name="Y">The target type</typeparam>
        /// <param name="x"></param>
        /// <param name="F"></param>
        /// <returns></returns>
        public static Y MapRequired<X, Y>(this Option<X> x, Func<X, Y> F)
            => F(x.Require());

        /// <summary>
        /// Returns true if an optioal value exists an a specified predicate over the value is satisfied
        /// </summary>
        /// <typeparam name="T">The value type</typeparam>
        /// <param name="x">The value to examine</param>
        /// <param name="predicate">The adjudicating predicate</param>
        /// <returns></returns>
        public static bool Satisfies<T>(this Option<T> x, Predicate<T> predicate)
            => x.TryMap(y => predicate(y)).ValueOrDefault();

        /// <summary>
        /// Bifurcates a stream of optional values into the haves/have nots
        /// </summary>
        /// <typeparam name="T">The optional value type</typeparam>
        /// <param name="options">The stream of options to evaluate</param>
        /// <returns></returns>
        public static (IEnumerable<Option<T>> Left, IEnumerable<T> Right) Split<T>(this IEnumerable<Option<T>> options)
            => (options.WhereNone(), options.WhereSome().Select(x => x.ValueOrDefault()));

        /// <summary>
        /// Evaluates to true iff all options have values
        /// </summary>
        /// <param name="options">The options to evaluate</param>
        /// <returns></returns>
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
        public static void WhenAll<X1, X2>(Option<X1> x1, Option<X2> x2, Action<X1, X2> f)
        {
            if (All(x1, x2))
                f(x1.Require(), x2.Require());
        }

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
        public static void WhenAll<X1, X2, X3>(Option<X1> x1, Option<X2> x2, Option<X3> x3, Action<X1, X2, X3> f)
        {
            if (All(x1, x2, x3))
                f(x1.Require(), x2.Require(), x3.Require());
        }
     }
}
