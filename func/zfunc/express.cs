//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using System.Reflection;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;

    using static zfunc;

    using XPR = System.Linq.Expressions.Expression;
    using PX = System.Linq.Expressions.ParameterExpression;

    public static class express
    {
        static ConcurrentDictionary<MethodInfo, Delegate> _cache { get; }
            = new ConcurrentDictionary<MethodInfo, Delegate>();

        /// <summary>
        /// Defines a conversion from a source expression to a target type
        /// </summary>
        /// <param name="e">The source expression</param>
        /// <param name="dstType">The target type</param>
        public static UnaryExpression conversion(XPR e, Type dstType)
            => XPR.Convert(e, dstType);

        /// <summary>
        /// Defines a conversion from a source expression to a target type
        /// </summary>
        /// <typeparam name="T">The target type</typeparam>
        /// <param name="e">The source expression</param>
        public static UnaryExpression conversion<T>(XPR e)
            => conversion(e, typeof(T));

        /// <summary>
        /// Creates a constant expression from a value
        /// </summary>
        /// <param name="src">The source value</param>
        public static ConstantExpression constant(object src)
            => XPR.Constant(src);

        /// <summary>
        /// Creates an expression from an emitter
        /// </summary>
        /// <typeparam name="T">The emission type</typeparam>
        /// <param name="f">The emitter</param>
        public static Expression<Func<T>> func<T>(Func<T> f)
            => FuncExpression.make(f);

        /// <summary>
        /// Creates and caches a delegate for a method realizing an emitter
        /// </summary>
        /// <typeparam name="X">The emission type</typeparam>
        /// <param name="m">The source method</param>
        /// <param name="instance">An object instance for the method, if applicable</param>
        public static Option<Func<X>> func<X>(MethodInfo m, object instance = null)
            => Try(() => (Func<X>)_cache.GetOrAdd(m, method =>
            {
                var result = conversion<X>(call(instance, m));
                return XPR.Lambda<Func<X>>(result).Compile();
            }));

        /// <summary>
        /// Creates an expression from a function delegate of arity 1
        /// </summary>
        /// <typeparam name="X">The function operand type</typeparam>
        /// <typeparam name="Y">The function return type</typeparam>
        /// <param name="f">The source delegate</param>
        public static Expression<Func<X, Y>> func<X, Y>(Func<X, Y> f)
            => FuncExpression.make(f);

        /// <summary>
        /// Creates and caches a delegate for a method realizing a function f:X->Y 
        /// </summary>
        /// <typeparam name="X">The operand type</typeparam>
        /// <typeparam name="Y">The return type</typeparam>
        /// <param name="m">The source method</param>
        /// <param name="instance">An object instance for the method, if applicable</param>
        public static Option<Func<X, Y>> func<X, Y>(MethodInfo m, object instance = null)
            => Try(() => (Func<X, Y>)_cache.GetOrAdd(m, method =>
            {
                var args = items(paramX<X>("x1"));
                var f = call(instance, m, args.ToArray());
                return lambda<X, Y>(args, f).Compile();
            }));

        /// <summary>
        /// Creates and caches a delegate for a method realizing a function f:X->Y 
        /// </summary>
        /// <typeparam name="X">The operand type</typeparam>
        /// <typeparam name="Y">The return type</typeparam>
        /// <param name="declarer">The declaring type</param>
        /// <param name="name">The name of the method</param>
        /// <param name="instance">An object instance for the method, if applicable</param>
        public static Option<Func<X, Y>> func<X, Y>(Type declarer, string name, object instance = null)
            => from m in declarer.MatchMethod(name, typeof(X))
                from f in func<X, Y>(m, instance)
                select f;

        /// <summary>
        /// Creates and caches a weakly-typed delegate for a function f:X->Y
        /// </summary>
        /// <param name="m">The source method</param>
        /// <param name="instance">The instance of the declaring type, if method is not static</param>
        public static Func<object, object> func1(MethodInfo method, object instance = null)
        {
            var paramInfo = method.GetParameters().Single();
            var typeDef = typeof(Func<,>).GetGenericTypeDefinition();
            var type = typeDef.MakeGenericType(array(paramInfo.ParameterType, method.ReturnType));
            var args = paramX(paramInfo.ParameterType, paramInfo.Name);
            var call = Expression.Call(ifNotNull(instance, x => constant(x)), method, args);
            var l = Expression.Lambda(type, call, args);
            var del = l.Compile();
            return x => del.DynamicInvoke(x);
        }

        /// <summary>
        /// Creates an expression from a function delegate of arity 2
        /// </summary>
        /// <typeparam name="X1">The type of the first operand</typeparam>
        /// <typeparam name="X2">The type of the second operand</typeparam>
        /// <typeparam name="Y">The function return type</typeparam>
        /// <param name="f">The source delegate</param>
        public static Expression<Func<X1, X2, Y>> func<X1, X2, Y>(Func<X1, X2, Y> f)
            => FuncExpression.make(f);

        /// <summary>
        /// Creates and caches a function delegate for a method realizing a function f:(X1,X2) -> Y
        /// </summary>
        /// <typeparam name="X1">The first operand type</typeparam>
        /// <typeparam name="X2">The second operand type</typeparam>
        /// <typeparam name="Y">The return type</typeparam>
        /// <param name="m">The source method</param>
        /// <param name="instance">The instance of the declaring type, if method is not static</param>
        public static Option<Func<X1, X2, Y>> func<X1, X2, Y>(MethodInfo m, object instance = null)
            => Try(() => (Func<X1, X2, Y>)_cache.GetOrAdd(m, method =>
            {
                var args = items(paramX<X1>("x1"), paramX<X2>("x2"));
                var f = call(instance, m, args.ToArray());
                return lambda<X1, X2, Y>(args, f).Compile();
            }));

        /// <summary>
        /// Creates an expression from a function delegate of arity 3
        /// </summary>
        /// <typeparam name="X1">The type of the first operand</typeparam>
        /// <typeparam name="X2">The type of the second operand</typeparam>
        /// <typeparam name="X3">The type of the third operand</typeparam>
        /// <typeparam name="Y">The function return type</typeparam>
        /// <param name="f">The source delegate</param>
        public static Expression<Func<X1, X2, X3, Y>> func<X1, X2, X3, Y>(Func<X1, X2, X3, Y> f)
            => FuncExpression.make(f);

        /// <summary>
        /// Creates and caches a function delegate for a method realizing a function f:(X1,X2,X3) -> Y
        /// </summary>
        /// <typeparam name="X1">The first operand type</typeparam>
        /// <typeparam name="X2">The second operand type</typeparam>
        /// <typeparam name="X3">The third operand type</typeparam>
        /// <typeparam name="Y">The return type</typeparam>
        /// <param name="m">The source method</param>
        /// <param name="instance">The instance of the declaring type, if method is not static</param>
        public static Func<X1, X2, X3, Y> func<X1, X2, X3, Y>(MethodInfo m, object instance = null)
            => (Func<X1, X2, X3, Y>)_cache.GetOrAdd(m, method =>
            {
                var args = items(paramX<X1>("x1"), paramX<X2>("x2"), paramX<X3>("x3"));
                var f = call(instance, m, args.ToArray());
                return lambda<X1, X2, X3, Y>(args, f).Compile();
            });

        /// <summary>
        /// Creates a parameter expression
        /// </summary>
        /// <typeparam name="X">The parameter type</typeparam>
        /// <param name="name">The parameter name</param>
        public static PX paramX<X>(string name = "x1")
            => XPR.Parameter(typeof(X), name);

        /// <summary>
        /// Creates a parameter expression where the parameter name is predicated on an integer value
        /// </summary>
        /// <param name="i">The paremeter index</param>
        /// <typeparam name="X">The parameter type</typeparam>
        public static PX paramX<X>(int i)
            => XPR.Parameter(typeof(X), "x" + i.ToString());

        /// <summary>
        /// Creates a parameter expression
        /// </summary>
        /// <param name="t">The parameter type</param>
        /// <param name="name">The parameter name</param>
        public static PX paramX(Type t, string name = "x1")
            => Expression.Parameter(t, name);

        /// <summary>
        /// Creates a parameter expression from a reflected parameter
        /// </summary>
        /// <param name="p">The reflected parameter</param>
        public static PX paramX(ParameterInfo p)
            => Expression.Parameter(p.ParameterType, p.Name);

        /// <summary>
        /// Creates a parameter expression where the parameter name is predicated on an integer value
        /// </summary>
        /// <param name="i">The paremeter index</param>
        public static PX paramX(Type paramType, int i)
            => Expression.Parameter(paramType, "x" + i.ToString());

        /// <summary>
        /// Creates a parameter expression 2-tuple
        /// </summary>
        /// <typeparam name="X1">The type of the first parameter</typeparam>
        /// <typeparam name="X2">The type of the second parameter</typeparam>
        /// <param name="name1">The name of the first parameter</param>
        /// <param name="name2">The name of the second parameter</param>
        public static (PX x1, PX x2) paramsX<X1, X2>(string name1 = "x1", string name2 = "x2")
            => (paramX<X1>(name1), paramX<X2>(name2));

        /// <summary>
        /// Creates a parameter expression 3-tuple
        /// </summary>
        /// <typeparam name="X1">The type of the first parameter</typeparam>
        /// <typeparam name="X2">The type of the second parameter</typeparam>
        /// <typeparam name="X3">The type of the third parameter</typeparam>
        /// <param name="name1">The name of the first parameter</param>
        /// <param name="name2">The name of the second parameter</param>
        /// <param name="name3">The name of the third parameter</param>
        public static (PX x1, PX x2, PX x3) paramsX<X1, X2, X3>(string name1 = "x1", string name2 = "x2", string name3 = "x3")
            => (paramX<X1>(name1), paramX<X2>(name2), paramX<X3>(name3));

        /// <summary>
        /// Creates an auto-named parameter expression array from an array of parameter types
        /// </summary>
        /// <param name="paramTypes">The parameter types</param>
        public static PX[] @params(params Type[] paramTypes)
            => Enumerable.Range(0, paramTypes.Length)
                    .Map(i => XPR.Parameter(paramTypes[i], "x" + (i + 1).ToString()))
                    .ToArray();

        /// <summary>
        /// Creates a lambda expression
        /// </summary>
        /// <typeparam name="T">The aligned delegate type</typeparam>
        /// <param name="parameters">The expression parameters</param>
        /// <param name="body"></param>
        public static Expression<T> lambda<T>(IEnumerable<PX> parameters, Expression body)
            where T : Delegate => XPR.Lambda<T>(body, parameters);

        /// <summary>
        /// Creates a 2-parameter lambda expression
        /// </summary>
        /// <typeparam name="T">The aligned delegate type</typeparam>
        /// <param name="parameters">The expression parameters</param>
        /// <param name="body"></param>
        /// <returns></returns>
        public static Expression<T> lambda<T>((PX p1, PX p2) parameters, Expression body)
            where T : Delegate
                => XPR.Lambda<T>(body, items(parameters.p1, parameters.p2));

        /// <summary>
        /// Defines a lambda expression
        /// </summary>
        /// <typeparam name="T">The aligned delegate type</typeparam>
        /// <param name="parameters">The expression parameters</param>
        /// <param name="body"></param>
        /// <returns></returns>
        public static Expression<T> lambda<T>((PX p1, PX p2, PX p3) parameters, Expression body)
            where T : Delegate
                => XPR.Lambda<T>(body, items(parameters.p1, parameters.p2, parameters.p3));

        /// <summary>
        /// Defines a lambda expression sans parameters
        /// </summary>
        /// <typeparam name="T">The aligned delegate type</typeparam>
        /// <param name="body"></param>
        public static Expression<T> lambda<T>(XPR body)
            where T : Delegate => XPR.Lambda<T>(body);

        /// <summary>
        /// Creates a 1-argument lambda expression
        /// </summary>
        /// <param name="parameters"></param>
        /// <param name="body"></param>
        public static Expression<Func<X, Y>> lambda<X, Y>(IEnumerable<PX> parameters, XPR body)
                => XPR.Lambda<Func<X, Y>>(body, parameters);

        /// <summary>
        /// Creates a 2-argument lambda expression
        /// </summary>
        /// <param name="parameters">The expression parameters</param>
        /// <param name="body">The expression body</param>
        /// <returns></returns>
        public static Expression<Func<X1, X2, Y>> lambda<X1, X2, Y>(IEnumerable<PX> parameters, XPR body)
            => XPR.Lambda<Func<X1, X2, Y>>(body, parameters);

        /// <summary>
        /// Creates a 3-argument lambda expression
        /// </summary>
        /// <param name="parameters">The expression parameters</param>
        /// <param name="body">The expression body</param>
        public static Expression<Func<X1, X2, X3, Y>> lambda<X1, X2, X3, Y>(IEnumerable<PX> parameters, XPR body)
            => XPR.Lambda<Func<X1, X2, X3, Y>>(body, parameters);

        /// <summary>
        /// Creates a unary lambda expression 
        /// </summary>
        /// <param name="f">The defining function</param>
        public static Expression<Func<X, Y>> lambda<X, Y>(Func<XPR, UnaryExpression> f)
        {
            var p1 = paramX<X>("p1");
            var eval = f(p1);            
            return lambda<Func<X, Y>>(items(p1), eval);

        }

        /// <summary>
        /// Creates a binary lambda expression
        /// </summary>
        /// <param name="f">The defining function</param>
        public static Expression<Func<X, Y, Z>> lambda<X, Y, Z>(Func<XPR, XPR, BinaryExpression> f)
        {
            var p1 = paramX<X>("p1");
            var p2 = paramX<Y>("p2");
            var eval = f(p1, p2);
            return lambda<Func<X, Y, Z>>(items(p1, p2), eval);
        }

        /// <summary>
        /// Defines a function that will invoke the default constructor to create
        /// an instance of type <typeparamref name="X"/>
        /// </summary>
        /// <typeparam name="X">The type of instance to create</typeparam>
        public static Option<Func<X>> factory<X>()
            => from c in constructor<X>()
                let x = XPR.New(c)
                select XPR.Lambda<Func<X>>(x).Compile();
    
        /// <summary>                                                               
        /// Defines a function that will invoke a one parameter constructor to create
        /// an instance of type <typeparamref name="Y"/>
        /// </summary>
        /// <typeparam name="X">The constructor parameter type</typeparam>
        /// <typeparam name="Y">The type of instance to create</typeparam>
        public static Option<Func<X, Y>> factory<X, Y>()
            => from c in constructor<Y>(typeof(X))
                let parameters = array(paramX<X>("a1"))
                let body = XPR.New(c, parameters)
                select lambda<Func<X, Y>>(parameters, body).Compile();

        /// <summary>
        /// Defines a function that will invoke a one parameter constructor to create
        /// an instance of type <paramref name="targetType"/>
        /// </summary>
        /// <param name="targetType">The type of object to construct</param>
        /// <param name="arg1Type">The constuctor argument type</param>
        public static Option<Func<object, object>> factory(Type targetType, Type arg1Type)
            => from c in constructor(targetType, arg1Type)
                let cParams = array(paramX(arg1Type, "a1"))
                let lParams = array(paramX(typeof(object), "o1"))
                let converted = array(conversion(lParams[0], arg1Type))
                let body = XPR.New(c, converted)
                select lambda<Func<object, object>>(lParams, body).Compile();

        /// <summary>                                                               
        /// Defines a function that will invoke a two parameter constructor to create
        /// an instance of type <typeparamref name="Y"/>
        /// </summary>
        /// <typeparam name="X1">The first constructor parameter type</typeparam>
        /// <typeparam name="X2">The second constructor parameter type</typeparam>
        /// <typeparam name="Y">The type of instance to create</typeparam>
        public static Option<Func<X1, X2, Y>> factory<X1, X2, Y>()
            => from c in constructor<Y>(typeof(X1), typeof(X2))
                let parameters = array(paramX<X1>("a1"), paramX<X2>("a2"))
                let body = XPR.New(c, parameters)
                select lambda<Func<X1, X2, Y>>(parameters, body).Compile();

        /// <summary>
        /// Defines a function that will invoke a one parameter constructor to create
        /// an instance of type <paramref name="targetType"/>
        /// </summary>
        /// <param name="targetType">The type of object to construct</param>
        /// <param name="arg1Type">The constuctor argument type</param>
        public static Option<Func<object, object, object>> factory(Type targetType, Type arg1Type, Type arg2Type)
            => from c in constructor(targetType, arg1Type, arg2Type)
                let lParams = array(paramX<object>("o1"), paramX<object>("o2"))
                let converted = array(conversion(lParams[0], arg1Type), conversion(lParams[1], arg2Type))
                let body = conversion(XPR.New(c, converted), typeof(object))
                let final = lambda<Func<object, object, object>>(lParams, body)
                select final.Compile();

        /// <summary>                                                               
        /// Defines a function that will invoke a three-parameter constructor to create
        /// an instance of type <typeparamref name="Y"/>
        /// </summary>
        /// <typeparam name="X1">The first constructor parameter type</typeparam>
        /// <typeparam name="X2">The second constructor parameter type</typeparam>
        /// <typeparam name="X3">The third constructor parameter type</typeparam>
        /// <typeparam name="Y">The type of instance to create</typeparam>
        public static Option<Func<X1, X2, X3, Y>> factory<X1, X2, X3, Y>()
            => from c in constructor<Y>(typeof(X1), typeof(X2))
                let parameters = array(paramX<X1>("a1"), paramX<X2>("a2"), paramX<X3>("a3"))
                let body = Expression.New(c, parameters)
                select lambda<Func<X1, X2, X3, Y>>(parameters, body).Compile();

        /// <summary>
        /// Creates an expression that invokes a static or instance method
        /// </summary>
        /// <param name="Host">The object that exposes the method if not static; otherwise null</param>
        /// <param name="m">The method to be invoked</param>
        /// <param name="args">The arguments supplied to the method when invoked</param>
        public static MethodCallExpression call(object Host, MethodInfo m, params PX[] args)
            => XPR.Call(ifNotNull(Host, h => constant(h)), m, args);

        /// <summary>
        /// Creates an expression that invokes a static method
        /// </summary>
        /// <param name="m">The method to be invoked</param>
        /// <param name="args">The arguments supplied to the method when invoked</param>
        public static MethodCallExpression call(MethodInfo m, params PX[] args)
            => call(null, m, args);

        /// <summary>
        /// Creates an invocation expression for a function f:X->Y
        /// </summary>
        /// <typeparam name="X">The function argument type</typeparam>
        /// <typeparam name="Y">The function return type</typeparam>
        /// <param name="f">The function delegate</param>
        /// <param name="argName">The name of argument</param>
        public static InvocationExpression invoke<X, Y>(Func<X, Y> f, string argName)
            => XPR.Invoke(func(f), paramX<X>(argName));

        /// <summary>
        /// Creates an invocation expression for a function f:X1->X2->Y
        /// </summary>
        /// <typeparam name="X1">The type of the first function argument</typeparam>
        /// <typeparam name="X2">The type of the second function argument</typeparam>
        /// <typeparam name="Y">The function return type</typeparam>
        /// <param name="f">The source function</param>
        /// <param name="arg1">The name of the first argument</param>
        /// <param name="arg2">The name of the second argument</param>
        public static InvocationExpression invoke<X1, X2, Y>(Func<X1, X2, Y> f, string arg1 = "x1", string arg2 = "x2")
            => XPR.Invoke(func(f), paramX<X1>(arg1), paramX<X2>(arg2));

        /// <summary>
        /// Creates a conjunction of a left and right expression
        /// </summary>
        /// <param name="lhs">The left expression</param>
        /// <param name="rhs">The right expression</param>
        public static BinaryExpression and(XPR lhs, XPR rhs)
            => XPR.AndAlso(lhs, rhs);

        /// <summary>
        /// Creates a disjunction of a left and right expression
        /// </summary>
        /// <param name="lhs">The left expression</param>
        /// <param name="rhs">The right expression</param>
        public static BinaryExpression or(XPR lhs, XPR rhs)
            => XPR.OrElse(lhs, rhs);

        /// <summary>
        /// Creates a type-test expression
        /// </summary>
        /// <param name="value">The value to test</param>
        /// <param name="t">The type to test against</param>
        public static TypeBinaryExpression typeIs(object value, Type t)
            => XPR.TypeIs(constant(value), t);

        /// <summary>
        /// Creates an expression to adjudicate whether a value if of a specified type
        /// </summary>
        /// <param name="value">The value to test</param>
        /// <typeparam name="T">The type to test against</typeparam>
        /// <returns></returns>
        public static TypeBinaryExpression typeIs<T>(object value)
            => XPR.TypeIs(constant(value), typeof(T));

        /// <summary>
        /// Creates an expression to call a function
        /// </summary>
        /// <param name="f">An expression representing the function to invoke</param>
        /// <param name="args"></param>
        public static InvocationExpression invoke(XPR f, params XPR[] args)
            => XPR.Invoke(f, args);

        /// <summary>
        /// Forms a conjunction from two function predicates
        /// </summary>
        /// <typeparam name="X1">The first predicate argument type</typeparam>
        /// <typeparam name="X2">The second predicate argument type</typeparam>
        /// <param name="p1">The first predicate</param>
        /// <param name="p2">The second predicate</param>
        public static Option<Func<X1, X2, bool>> and<X1, X2>(Func<X1, bool> p1, Func<X2, bool> p2)
            => from args in some(paramsX<X1, X2>())
                let left = invoke(func(p1), args.x1)
                let right = invoke(func(p2), args.x2)
                let body = and(left, right)
                select lambda<Func<X1, X2, bool>>(args, body).Compile();

        /// <summary>
        /// Forms a disjunction from two function predicates
        /// </summary>
        /// <typeparam name="X1">The first predicate argument type</typeparam>
        /// <typeparam name="X2">The second predicate argument type</typeparam>
        /// <param name="p1">The first predicate</param>
        /// <param name="p2">The second predicate</param>
        public static Option<Func<X1, X2, bool>> or<X1, X2>(Func<X1, bool> p1, Func<X2, bool> p2)
            => from args in some(paramsX<X1, X2>())
                let left = invoke(func(p1), args.x1)
                let right = invoke(func(p2), args.x2)
                let body = or(left, right)
                select lambda<Func<X1, X2, bool>>(args, body).Compile();

    }
}