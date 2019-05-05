//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Diagnostics;
    using System.Reflection;
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;
    
    using static zcore;
    
    public static class FluentReflection
    {
        public static IEnumerable<Type> Realize<T>(this IEnumerable<Type> src)
            => src.Where(t => t.GetInterfaces().Contains(typeof(T)));

        public static IEnumerable<Type> Concrete(this IEnumerable<Type> src)
            => src.Where(t => !t.IsAbstract);

        public static IEnumerable<MethodInfo> Concrete(this IEnumerable<MethodInfo> src)
            => src.Where(t => !t.IsAbstract);

        public static IEnumerable<MethodInfo> Abstract(this IEnumerable<MethodInfo> src)
            => src.Where(t => t.IsAbstract);


        public static IEnumerable<Type> Abstract(this IEnumerable<Type> src)
            => src.Where(t => t.IsAbstract);


        public static IEnumerable<Type> Nested(this IEnumerable<Type> src)
            => src.Where(t => t.IsNested);

        /// <summary>
        /// Selects the static fields from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<FieldInfo> Static(this IEnumerable<FieldInfo> src)
            => src.Where(x => x.IsStatic);

        /// <summary>
        /// Selects the static methods from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> Static(this IEnumerable<MethodInfo> src)
                    => src.Where(x => x.IsStatic);
        

        [MethodImpl(Inline)]
        static bool IsStatic(this PropertyInfo p)
            => p.GetGetMethod()?.IsStatic == true 
            || p.GetSetMethod().IsStatic == true;

        /// <summary>
        /// Determines whether a type is static
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        static bool IsStatic(this Type t)
            => t.IsAbstract && t.IsSealed;

        /// <summary>
        /// Selects the static properties from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<PropertyInfo> Static(this IEnumerable<PropertyInfo> src)
            => src.Where(p => p.IsStatic());

        /// <summary>
        /// Selects the static types from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<Type> Static(this IEnumerable<Type> src)
            => src.Where(p => p.IsStatic());

        /// <summary>
        /// Selects the instance fields from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<FieldInfo> Instance(this IEnumerable<FieldInfo> src)
            => src.Where(x => !x.IsStatic);

        /// <summary>
        /// Selects the instance methods from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> Instance(this IEnumerable<MethodInfo> src)
            => src.Where(t => !t.IsStatic);

        /// <summary>
        /// Selects the literal fields from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<FieldInfo> Literal(this IEnumerable<FieldInfo> src)
            => src.Where(x => x.IsLiteral);


        /// <summary>
        /// Selects the immutable fields from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<FieldInfo> Immutable(this IEnumerable<FieldInfo> src)
            => src.Where(x => x.IsInitOnly || x.IsLiteral);

        /// <summary>
        /// Selects the mmutable fields from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<FieldInfo> Mutable(this IEnumerable<FieldInfo> src)
            => src.Where(x => !(x.IsInitOnly || x.IsLiteral));


        public static IEnumerable<Type> Public(this IEnumerable<Type> src)
            => src.Where(t => t.IsPublic);

        /// <summary>
        /// Selects the public fields from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<FieldInfo> Public(this IEnumerable<FieldInfo> src)
            => src.Where(x => x.IsPublic);

        /// <summary>
        /// Selects the public methods from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> Public(this IEnumerable<MethodInfo> src)
            => src.Where(t => t.IsPublic);

        /// <summary>
        /// Selects the non-public types from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<Type> NonPublic(this IEnumerable<Type> src)
            => src.Where(t => !t.IsPublic);

        /// <summary>
        /// Selects the non-public fields from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<FieldInfo> NonPublic(this IEnumerable<FieldInfo> src)
            => src.Where(x => !x.IsPublic);

        /// <summary>
        /// Selects the non-public methods from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> NonPublic(this IEnumerable<MethodInfo> src)
            => src.Where(t => !t.IsPublic);

        /// <summary>
        /// Selects the methods from a stream that return a particular type of value
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> Returns<T>(this IEnumerable<MethodInfo> src)
            => src.Where(x => x.ReturnType == typeof(T));

        /// <summary>
        /// Selects the methods from a stream that return a particular type of value
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> Returns(this IEnumerable<MethodInfo> src, Type returnType)
            => src.Where(x => x.ReturnType == returnType);

        public static IEnumerable<MethodInfo> WithParameterCount(this IEnumerable<MethodInfo> src, int count)
            => src.Where(m => m.GetParameters().Length == count);

        /// <summary>
        /// Selects the properties with set methods from the stream
        /// </summary>
        /// <param name="src">The properties to examine</param>
        public static IEnumerable<PropertyInfo> WithSet(this IEnumerable<PropertyInfo> src)
            => src.Where(p => p.GetSetMethod() != null);

        /// <summary>
        /// Selects the properties with get methods from the stream
        /// </summary>
        /// <param name="src">The properties to examine</param>
        public static IEnumerable<PropertyInfo> WithGet(this IEnumerable<PropertyInfo> src)
            => src.Where(p => p.GetGetMethod() != null);

        /// <summary>
        /// Selects the properties with both get/set methods from the stream
        /// </summary>
        /// <param name="src">The properties to examine</param>
        public static IEnumerable<PropertyInfo> WithGetAndSet(this IEnumerable<PropertyInfo> src)
            => src.Where(p => p.GetGetMethod() != null && p.GetSetMethod() != null);


        /// <summary>
        /// Selects the members with a particular name
        /// </summary>
        /// <param name="src">The members to examine</param>
        /// <param name="name">The name to match</param>
        public static IEnumerable<T> WithName<T>(this IEnumerable<T> src, string name)
            where T : MemberInfo
            => src.Where(x => x.Name == name);
    }

}