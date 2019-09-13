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

    public static class FuncExpression
    {
        /// <summary>
        /// Defines a function expression for an emitter
        /// </summary>
        /// <typeparam name="X">The emission type</typeparam>
        /// <param name="f">The emitter</param>
        public static FuncExpression<X> make<X>(Func<X> f)
            => f;

        /// <summary>
        /// Defines a function expression for a heterogenous fuction of arity 1
        /// </summary>
        /// <typeparam name="X">The function argument type</typeparam>
        /// <typeparam name="Y">The return type</typeparam>
        /// <param name="f">The source function</param>
        public static FuncExpression<X,Y> make<X,Y>(Func<X,Y> f)
            => f;

        /// <summary>
        /// Defines a function expression for a heterogenous fuction of arity 2
        /// </summary>
        /// <typeparam name="X1">The type of the first argument</typeparam>
        /// <typeparam name="X2">The type of the second argument</typeparam>
        /// <typeparam name="Y">The return type</typeparam>
        /// <param name="f">The source function</param>
        public static FuncExpression<X1, X2, Y> make<X1, X2, Y>(Func<X1, X2, Y> f)
            => f;

        /// <summary>
        /// Defines a function expression for an arity 2 operator
        /// </summary>
        /// <typeparam name="X">The operand type</typeparam>
        /// <param name="f">The source function</param>
        public static FuncExpression<X, X, X> make<X>(Func<X, X, X> f)
            => f;

        /// <summary>
        /// Produces a 3-argument func expression
        /// </summary>
        /// <typeparam name="X1">The type of the first argument</typeparam>
        /// <typeparam name="X2">The type of the second argument</typeparam>
        /// <typeparam name="X3">The type of the third argument</typeparam>
        /// <typeparam name="Y">The return type</typeparam>
        /// <param name="f">The source function</param>
        /// <returns></returns>
        public static FuncExpression<X1, X2, X3, Y> make<X1, X2, X3, Y>(Func<X1, X2, X3, Y> f)
            => f;


        /// <summary>
        /// Defines a function expression for an arity 3 operator
        /// </summary>
        /// <typeparam name="X">The operand type</typeparam>
        /// <param name="f">The source function</param>
        public static FuncExpression<X, X, X,X> make<X>(Func<X, X, X,X> f)
            => f;
    }

}