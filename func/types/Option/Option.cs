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

    using static zfunc;

    /// <summary>
    /// Represents a potential value
    /// </summary>
    /// <typeparam name="T">The potential value type</typeparam>
    public readonly struct Option<T> : IEquatable<Option<T>>, IOption<T>
    {
        /// <summary>
        /// Defines a non-valued option
        /// </summary>
        [MethodImpl(Inline)]
        public static Option<T> None()
            => new Option<T>();
        
        /// <summary>
        /// Defines a valued option
        /// </summary>
        /// <param name="Value">The encapsulated value</param>
        [MethodImpl(Inline)]
        public static Option<T> Some(T Value)
            => new Option<T>(Value);
        
        [MethodImpl(Inline)]
        public static implicit operator Option<T>(T x)
            => x != null  ? Some(x) : None();

        /// <summary>
        /// Implmements value-based equality
        /// </summary>
        /// <param name="lhs">The first value</param>
        /// <param name="rhs">The second value</param>
        [MethodImpl(Inline)]
        public static bool operator == (Option<T> lhs, Option<T> rhs)
            => (lhs.IsNone() && rhs.IsNone())  
                ? true 
                : (lhs.Exists && rhs.Exists && lhs.value.Equals(rhs.value));

        /// <summary>
        /// Implements value-based equality negation
        /// </summary>
        /// <param name="lhs">The first value</param>
        /// <param name="rhs">The second value</param>
        [MethodImpl(Inline)]
        public static bool operator != (Option<T> lhs, Option<T> rhs)
            => !(lhs == rhs);

        /// <summary>
        /// Returns true if the option has a value and false otherwise
        /// </summary>
        /// <param name="x">The option to test</param>
        [MethodImpl(Inline)]
        public static bool operator true(Option<T> x)
            => x.Exists;

        /// <summary>
        /// Returns false if the option is non-valued and true otherwise
        /// </summary>
        /// <param name="x">The option to test</param>
        [MethodImpl(Inline)]
        public static bool operator false(Option<T> x)
            => !x.Exists;

        /// <summary>
        /// Returns false if the option is non-valued and true otherwise
        /// </summary>
        /// <param name="x">The option to test</param>
        [MethodImpl(Inline)]
        public static bool operator !(Option<T> x)
            => !x.Exists;

        /// <summary>
        /// The encapsulated value, iff Exists is true
        /// </summary>
        readonly T value;

        [MethodImpl(Inline)]
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
        [MethodImpl(Inline)]
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
        [MethodImpl(Inline)]
        public bool IsSome()
            => Exists;

        /// <summary>
        /// Returns true if the value does not exist
        /// </summary>
        [MethodImpl(Inline)]
        public bool IsNone()
            => !Exists;

        /// <summary>
        /// Applies the a function to evaluate the underlying value if it exists
        /// </summary>
        /// <typeparam name="X"></typeparam>
        /// <param name="F"></param>
        [MethodImpl(Inline)]
        public Option<X> IfSome<X>(Func<T, X> F)
            => Exists ? F(value) : Option.none<X>();

        /// <summary>
        /// Invokes an action if the value exists
        /// </summary>
        /// <param name="ifSome">The action to potentially ivoke</param>
        [MethodImpl(Inline)]
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
        [MethodImpl(Inline)]
        public Option<T> OnNone(Action ifNone)
        {
            if (IsNone())
                ifNone();
            return this;
        }
            
        /// <summary>
        /// Yields the encapulated value if present; otherwise, raises an exception
        /// </summary>
        [MethodImpl(Inline)]
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
        [MethodImpl(Inline)]
        public T ValueOrDefault(T @default = default(T))
            => Exists ? value : @default;

        /// <summary>
        /// Returns the encapsulated value if it exists; otherwise, invokes the fallback function <paramref name="fallback"/>
        /// to obtain value
        /// </summary>
        /// <param name="fallback">The function called to produce a value when there is no value in the source</param>
        [MethodImpl(Inline)]
        public T ValueOrElse(Func<T> fallback)
            => Exists ? value : fallback();

        /// <summary>
        /// Applies supplied function to value if present, otherwise returns the 
        /// value obtained by invoking the fallback function
        /// </summary>
        /// <typeparam name="S">The output type</typeparam>
        /// <param name="f">The function to apply when value exists</param>
        /// <param name="fallback">The function to invoke when no value exists</param>
        [MethodImpl(Inline)]
        public S Map<S>(Func<T, S> f, Func<S> fallback)
            => Exists  ? f(value)  : fallback();

        /// <summary>
        /// Applies supplied function to value if present, otherwise returns the fallback value
        /// </summary>
        /// <typeparam name="S">The output type</typeparam>
        /// <param name="f">The function to apply when value exists</param>
        /// <param name="fallback">The function to invoke when no value exists</param>
        [MethodImpl(Inline)]
        public S Map<S>(Func<T, S> f, S fallback)
            => Exists  ? f(value)  : fallback;

        /// <summary>
        /// Applies a function to value if present, otherwise returns None
        /// </summary>
        /// <typeparam name="S">The output type</typeparam>
        /// <param name="f">The function to apply when value exists</param>
        [MethodImpl(Inline)]
        public Option<S> TryMap<S>(Func<T, S> f)
            => Exists ? Option.some(f(value)) : Option.none<S>();

        /// <summary>
        /// Transforms the value, if present, otherwise invokes a function
        /// to produce an appropriate value of the target type if not
        /// </summary>
        /// <typeparam name="S">The target type</typeparam>
        /// <param name="ifSome">The transformer</param>
        /// <param name="fallback">The alternate transformer</param>
        [MethodImpl(Inline)]
        public S MapValueOrElse<S>(Func<T, S> ifSome, Func<S> fallback)
            => Exists  ? ifSome(value)  : fallback();

        /// <summary>
        /// Applies a function to the encapsulated value if it exists; otherwise, returns a default value
        /// </summary>
        /// <typeparam name="S">The projected value type</typeparam>
        /// <param name="ifSome">The function to apply when a value exists</param>
        /// <param name="default">The value to return when no value exists</param>
        [MethodImpl(Inline)]
        public S MapValueOrDefault<S>(Func<T, S> ifSome, S @default = default)
            => Exists ? ifSome(value) :  @default;

        /// <summary>
        /// Drops the encapsulated value, if any, and projects None to target space
        /// </summary>
        /// <typeparam name="S">The target space type</typeparam>
        [MethodImpl(Inline)]
        public  Option<S> ToNone<S>()
            => Option.none<S>();


        /// <summary>
        /// LINQ integration function
        /// </summary>
        /// <typeparam name="Y"></typeparam>
        /// <param name="apply"></param>
        [MethodImpl(Inline)]
        public Option<Y> Select<Y>(Func<T, Y> apply)
            => TryMap(_x => apply(_x));

        /// <summary>
        /// LINQ integration function
        /// </summary>
        /// <typeparam name="Y"></typeparam>
        /// <typeparam name="Z"></typeparam>
        /// <param name="eval"></param>
        /// <param name="project"></param>
        [MethodImpl(Inline)]
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
        [MethodImpl(Inline)]
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
            => Exists ? value.GetHashCode() : typeof(T).Name.GetHashCode();

        public override string ToString()
            => Option.render(this);

        public bool Equals(Option<T> other)
            => Option.eq(this, other);
    }


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
