//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.ComponentModel;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    using static ReflectionFlags;

    partial class Reflections
    {        
        /// <summary>
        /// Determines whether a property is an indexer
        /// </summary>
        /// <param name="p">The property to examine</param>
        /// <returns></returns>
        public static bool IsIndexer(this PropertyInfo p)
            => p.GetIndexParameters().Length > 0;

        /// <summary>
        /// Determines whether the property has a public or non-public setter
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool HasSetter(this PropertyInfo p)
            => p.Setter().Exists;

        /// <summary>
        /// Determines whether the property has a public or non-public getter
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool HasGetter(this PropertyInfo p)
            => p.Getter().Exists;

        /// <summary>
        /// Attempts to determine whether a method is sporting the "new" keyword
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// Approach adapted from https://stackoverflow.com/questions/288357/how-does-reflection-tell-me-when-a-property-is-hiding-an-inherited-member-with-t
        /// </remarks>
        public static bool IsHidingBaseMember(this MethodInfo self)
        {
            Type baseType = self.DeclaringType.BaseType;
            var baseMethod = baseType.GetMethod(self.Name, self.GetParameters().Select(p => p.ParameterType).ToArray());

            if (baseMethod == null)
                return false;

            if (baseMethod.DeclaringType == self.DeclaringType)
                return false;

            var baseMethodDefinition = baseMethod.GetBaseDefinition();
            var thisMethodDefinition = self.GetBaseDefinition();

            return baseMethodDefinition.DeclaringType != thisMethodDefinition.DeclaringType;
        }

        /// <summary>
        /// Determines whether a method is an action
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <returns></returns>
        public static bool IsAction(this MethodInfo m)
            => m.ReturnType == typeof(void);

        /// <summary>
        /// Determines whether a method is a function
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <returns></returns>
        public static bool IsFunction(this MethodInfo m)
            => m.ReturnType != typeof(void);

        /// <summary>
        /// Determines whether the method is an implicit conversion operator
        /// </summary>
        /// <param name="m">The method to test</param>
        /// <returns></returns>
        public static bool IsImplicitConverter(this MethodInfo m)
            => string.Equals(m.Name, "op_Implicit", StringComparison.InvariantCultureIgnoreCase);

        /// <summary>
        /// Determines whether the method is an explicit conversion operator
        /// </summary>
        /// <param name="m">The method to test</param>
        /// <returns></returns>
        public static bool IsExplicitConverter(this MethodInfo m)
            => string.Equals(m.Name, "op_Explicit", StringComparison.InvariantCultureIgnoreCase);

        /// <summary>
        /// Determines whether an attribute is applied to a member
        /// </summary>
        /// <typeparam name="A">The type of attribute for which to check</typeparam>
        /// <param name="m">The member to examine</param>
        /// <returns></returns>
        public static bool HasAttribute<A>(this MemberInfo m) where A : Attribute
            => System.Attribute.IsDefined(m, typeof(A));

        /// <summary>
        /// Gets the value of a specified field or property
        /// </summary>
        /// <param name="m">The field or property</param>
        /// <param name="o">The object on which the member is defined</param>
        [MethodImpl(Inline)]
        public static object MemberValue(this MemberInfo m, object o)
        {
            if (m is FieldInfo)
                return (m as FieldInfo).GetValue(o);
            else if (m is PropertyInfo)
                return (m as PropertyInfo).GetValue(o);
            else
                throw new NotSupportedException();
        }

        /// <summary>
        /// Gets the value of the identified member field or property
        /// </summary>
        /// <typeparam name="T">The value type</typeparam>
        /// <param name="m">The member</param>
        /// <param name="o">The instance from which to access the member</param>
        [MethodImpl(Inline)]
        public static T MemberValue<T>(this MemberInfo m, object o)
            => (T)m.MemberValue(o);

        /// <summary>
        /// Determines whether a field has been generated by the compiler
        /// </summary>
        /// <param name="f">The field to examine</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static bool IsCompilerGenerated(this FieldInfo f)
            => f.HasAttribute<CompilerGeneratedAttribute>();

        /// <summary>
        /// Returns a method's parameter types
        /// </summary>
        /// <param name="src">The soruce method</param>
        [MethodImpl(Inline)]
        public static IEnumerable<Type> ParameterTypes(this MethodInfo src)
            => src.GetParameters().Select(p => p.ParameterType);

        /// <summary>
        /// Searches a type for any method that matches the supplied signature
        /// </summary>
        /// <param name="declaringType">The type to search</param>
        /// <param name="name">The name of the method</param>
        /// <param name="argTypes">The method parameter types in ordinal position</param>
        [MethodImpl(Inline)]
        public static Option<MethodInfo> MatchMethod(this Type declaringType, string name, params Type[] argTypes)
            => argTypes.Length != 0
                ? declaringType.GetMethod(name, 
                        bindingAttr: AnyVisibilityOrInstanceType, 
                        binder: null, 
                        types: argTypes, 
                        modifiers: null
                        )
                : declaringType.GetMethod(name, AnyVisibilityOrInstanceType);

 
        /// <summary>
        /// Determines an expression for the name of the method relative to the supplied type parameter
        /// </summary>
        /// <typeparam name="T">The relative type</typeparam>
        /// <param name="src">The source method</param> 
        [MethodImpl(Inline)]
        public static string RelativeName<T>(this MethodBase src)
            => typeof(T).Name
            + $"/{src.Name.Replace(typeof(T).FullName + ".", string.Empty)}";

        /// <summary>
        /// Constructs a display name for a method
        /// </summary>
        /// <param name="src">The source method</param>
        [MethodImpl(Inline)]
        public static string FullDisplayName(this MethodBase src)
            => $"{src.DeclaringType.DisplayName()}{src.DisplayName()}";

        [MethodImpl(Inline)]
        public static Func<T,T,T> ToBinaryOperator<T>(this MethodInfo target)
            => binop<T>(target);

        [MethodImpl(Inline)]
        public static string DisplayName(this MethodBase src)
        {
            var attrib = src.GetCustomAttribute<DisplayNameAttribute>();
            return attrib != null ? attrib.DisplayName.TrimEnd('/') : src.Name;
        }

        /// <summary>
        /// Constructs a display name for a type
        /// </summary>
        /// <param name="src">The source type</param>
        public static string DisplayName(this Type src)
        {
            var attrib = src.GetCustomAttribute<DisplayNameAttribute>();
            if (attrib != null)
                return attrib.DisplayName;

            if (!src.IsGenericType)
                return src.Name;

            if (src.IsConstructedGenericType)
            {
                var typeArgs = src.GenericTypeArguments;
                var argFmt = string.Join(",", typeArgs.Select(a => a.DisplayName()).ToArray());
                var typeName = src.Name.Replace($"`{typeArgs.Length}", string.Empty);
                return concat(typeName, "<", argFmt, ">");
            }
            else
            {
                var typeArgs = src.GetGenericTypeDefinition().GetGenericArguments();
                var argFmt = string.Join(",", typeArgs.Select(a => a.DisplayName()).ToArray());
                var typeName = src.Name.Replace($"`{typeArgs.Length}", string.Empty);
                return concat(typeName, "<", argFmt, ">");
            }
        }

        public static IEnumerable<Type> Realize<T>(this IEnumerable<Type> src)
            => src.Where(t => t.Interfaces().Contains(typeof(T)));

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
        /// Selects the literals provided by a type
        /// </summary>
        /// <param name="src">The source type</param>
        /// <param name="declared">Whether a literal is rquired to be declared by the type</param>
        /// <returns></returns>
        public static IEnumerable<FieldInfo> Literals(this Type src, bool declared = true)
            => src.Fields(declared).Literal();

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
        /// Selects the open generic methods from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> OpenGeneric(this IEnumerable<MethodInfo> src)
            => src.Where(t => t.ContainsGenericParameters);

        /// <summary>
        /// Selects the closed generic methods from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> ClosedGeneric(this IEnumerable<MethodInfo> src)
            => src.Where(t => t.IsConstructedGenericMethod);

        /// <summary>
        /// Selects the non-generic methods from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> NonGeneric(this IEnumerable<MethodInfo> src)
            => src.Where(t => !t.ContainsGenericParameters && !t.IsConstructedGenericMethod);

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
 
        /// <summary>
        /// Attempts to retrieve the value of an instance or static property
        /// </summary>
        /// <param name="prop">The property</param>
        /// <param name="instance">The object instance, if applicable</param>
        public static Option<object> TryGetValue(this PropertyInfo prop, object instance = null)
            => Try(() => prop.GetValue(instance));

        /// <summary>
        /// Attempts to retrieve the value of an instance or static field
        /// </summary>
        /// <param name="field">The field</param>
        /// <param name="instance">The object instance, if applicable</param>
        public static Option<object> TryGetValue(this FieldInfo field, object instance = null)
            => Try(() => field.GetValue(instance));
    }
}