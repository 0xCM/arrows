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
    using System.Linq.Expressions;
    
    using static zfunc;

    /// <summary>
    /// Encapsulates a delegate that implicitly converts into a LINQ expression
    /// </summary>
    /// <typeparam name="X">The function return type</typeparam>
    public readonly struct FuncExpression<X>
    {
        /// <summary>
        /// Implicitly converts a func expression to linq expression
        /// </summary>
        /// <param name="fx">The source func expression</param>
        public static implicit operator Expression<Func<X>>(FuncExpression<X> fx)
            => fx.Fx;

        /// <summary>
        /// Implicitly constructs a func expression from a func
        /// </summary>
        /// <param name="f">The source function</param>
        public static implicit operator FuncExpression<X>(Func<X> f)
            => new FuncExpression<X>(f);

        public FuncExpression(Func<X> f)
            => this.Fx = () => f();

        /// <summary>
        /// The expression derived from the source function
        /// </summary>
        public Expression<Func<X>> Fx { get; }

    }

    /// <summary>
    /// Encapsulates a delegate that implicitly converts into a LINQ expression
    /// </summary>
    /// <typeparam name="X">The function argument type</typeparam>
    /// <typeparam name="Y">The function return type</typeparam>
    public readonly struct FuncExpression<X, Y>
    {
        /// <summary>
        /// Implicitly converts a func expression to linq expression
        /// </summary>
        /// <param name="fx">The source func expression</param>
        public static implicit operator Expression<Func<X, Y>>(FuncExpression<X, Y> fx)
            => fx.Fx;

        /// <summary>
        /// Implicitly constructs a func expression from a func
        /// </summary>
        /// <param name="f">The source function</param>
        public static implicit operator FuncExpression<X, Y>(Func<X, Y> f)
            => new FuncExpression<X, Y>(f);

        public FuncExpression(Func<X, Y> f)
            => this.Fx = x => f(x);

        /// <summary>
        /// The expression derived from the source function
        /// </summary>
        public Expression<Func<X, Y>> Fx { get; }

    }

    /// <summary>
    /// Encapsulates a delegate that implicitly converts into a LINQ expression
    /// </summary>
    /// <typeparam name="X1">The type of the first argument</typeparam>
    /// <typeparam name="X2">The type of the second argument</typeparam>
    /// <typeparam name="Y">The function return type</typeparam>
    public readonly struct FuncExpression<X1, X2, Y>
    {
        /// <summary>
        /// Implicitly converts a func expression to linq expression
        /// </summary>
        /// <param name="fx">The source func expression</param>
        public static implicit operator Expression<Func<X1, X2, Y>>(FuncExpression<X1, X2, Y> fx)
            => fx.Fx;

        /// <summary>
        /// Implicitly constructs a func expression from a func
        /// </summary>
        /// <param name="f">The source function</param>
        public static implicit operator FuncExpression<X1, X2, Y>(Func<X1, X2, Y> f)
            => new FuncExpression<X1, X2, Y>(f);

        public FuncExpression(Func<X1, X2, Y> f)
            => this.Fx = (x1, x2) => f(x1,x2);

        /// <summary>
        /// The expression derived from the source function
        /// </summary>
        public Expression<Func<X1, X2, Y>> Fx { get; }

    }

    /// <summary>
    /// Encapsulates a delegate that implicitly converts into a LINQ expression
    /// </summary>
    /// <typeparam name="X1">The type of the first argument</typeparam>
    /// <typeparam name="X2">The type of the second argument</typeparam>
    /// <typeparam name="X3">The type of the third argument</typeparam>
    /// <typeparam name="Y">The function return type</typeparam>
    public readonly struct FuncExpression<X1, X2, X3, Y>
    {
        /// <summary>
        /// Implicitly converts a func expression to linq expression
        /// </summary>
        /// <param name="fx">The source func expression</param>
        public static implicit operator Expression<Func<X1, X2, X3, Y>>(FuncExpression<X1, X2, X3, Y> fx)
            => fx.Fx;

        /// <summary>
        /// Implicitly constructs a func expression from a func
        /// </summary>
        /// <param name="f">The source function</param>
        public static implicit operator FuncExpression<X1, X2, X3, Y>(Func<X1, X2, X3, Y> f)
            => new FuncExpression<X1, X2, X3, Y>(f);

        public FuncExpression(Func<X1, X2, X3, Y> f)
            => this.Fx = (x1, x2, x3) => f(x1, x2, x3);

        /// <summary>
        /// The expression derived from the source function
        /// </summary>
        public Expression<Func<X1, X2, X3, Y>> Fx {get;}
    }
}