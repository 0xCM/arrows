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
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    using static ReflectionFlags;

    partial class Reflections
    {        
        /// <summary>
        /// Determines whether the type is a (memory) reference
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static bool IsRef(this Type src)
            =>  src.UnderlyingSystemType.IsByRef;

        /// <summary>
        /// Determines whether a property is an indexer
        /// </summary>
        /// <param name="p">The property to examine</param>
        public static bool IsIndexer(this PropertyInfo p)
            => p.GetIndexParameters().Length > 0;

        /// <summary>
        /// Determines whether the property has a public or non-public setter
        /// </summary>
        /// <param name="p">The property to examine</param>
        public static bool HasSetter(this PropertyInfo p)
            => p.Setter().Exists;

        /// <summary>
        /// Determines whether the property has a public or non-public getter
        /// </summary>
        /// <param name="p">The property to examine</param>
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
        public static bool IsAction(this MethodInfo m)
            => m.ReturnType == typeof(void);

        /// <summary>
        /// Determines whether a method is a function
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsFunction(this MethodInfo m)
            => m.ReturnType != typeof(void);

        /// <summary>
        /// Determines whether the method is an implicit conversion operator
        /// </summary>
        /// <param name="m">The method to test</param>
        public static bool IsImplicitConverter(this MethodInfo m)
            => string.Equals(m.Name, "op_Implicit", StringComparison.InvariantCultureIgnoreCase);

        /// <summary>
        /// Determines whether the method is an explicit conversion operator
        /// </summary>
        /// <param name="m">The method to test</param>
        public static bool IsExplicitConverter(this MethodInfo m)
            => string.Equals(m.Name, "op_Explicit", StringComparison.InvariantCultureIgnoreCase);

        /// <summary>
        /// Determines whether an attribute is applied to a member
        /// </summary>
        /// <typeparam name="A">The type of attribute for which to check</typeparam>
        /// <param name="m">The member to examine</param>
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
        [MethodImpl(Inline)]
        public static bool IsCompilerGenerated(this FieldInfo f)
            => f.HasAttribute<CompilerGeneratedAttribute>();

        /// <summary>
        /// Returns a method's parameter types
        /// </summary>
        /// <param name="src">The source method</param>
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
        /// Converts a binary operator delegate fro a conforming method
        /// </summary>
        /// <param name="src">The methodd that defines a binary operator</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static Func<T,T,T> ToBinaryOp<T>(this MethodInfo src)
            => binop<T>(src);
        
        /// <summary>
        /// Constructs a method signature from a source method
        /// </summary>
        /// <param name="src">The source method</param>
        public static MethodSig MethodSig(this MethodInfo src)
            => Z0.MethodSig.Define(src);

        /// <summary>
        /// If a method is non-generic, returns an emtpy list.
        /// If a method is open generic, returns a list describing the open parameters
        /// If a method is closed generic, returns a list describing the closed parameters
        /// </summary>
        /// <param name="src">The type from which to extract existing closed/open generic parameters</param>
        public static Type[] GenericSlots(this MethodInfo src)
            => !(src.IsGenericMethod && !src.IsGenericMethodDefinition) ? new Type[]{} 
               : src.IsConstructedGenericMethod
               ? src.GetGenericArguments()
               : src.GetGenericMethodDefinition().GetGenericArguments();

        /// <summary>
        /// If a type is non-generic, returns an emtpy list.
        /// If a type is open generic, returns a list describing the open parameters
        /// If a type is closed generic, returns a list describing the closed parameters
        /// </summary>
        /// <param name="src">The type from which to extract existing closed/open generic parameters</param>
        public static IReadOnlyList<Type> GetGenericSlots(this Type src)
            => (!src.IsGenericType && !src.IsGenericTypeDefinition) ? new Type[]{} 
               : src.IsConstructedGenericType 
               ? src.GenericTypeArguments 
               : src.GetGenericTypeDefinition().GetGenericArguments();
    
        
        /// <summary>
        /// Selects the types from a stream that implement a specific interface
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The interface type</typeparam>
        public static IEnumerable<Type> Realize<T>(this IEnumerable<Type> src)
            => src.Where(t => t.Interfaces().Contains(typeof(T)));

        /// <summary>
        /// Selects the concrete (not abstract) types from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<Type> Concrete(this IEnumerable<Type> src)
            => src.Where(t => !t.IsAbstract);

        /// <summary>
        /// Selects the concrete (not abstract) methods from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> Concrete(this IEnumerable<MethodInfo> src)
            => src.Where(t => !t.IsAbstract);

        /// <summary>
        /// Selects the abstract methods from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<MethodInfo> Abstract(this IEnumerable<MethodInfo> src)
            => src.Where(t => t.IsAbstract);

        /// <summary>
        /// Selects the abstract types from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<Type> Abstract(this IEnumerable<Type> src)
            => src.Where(t => t.IsAbstract);

        /// <summary>
        /// Selects the nested types from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<Type> Nested(this IEnumerable<Type> src)
            => src.Where(t => t.IsNested);

        /// <summary>
        /// Selects the static fields from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<FieldInfo> Static(this IEnumerable<FieldInfo> src)
            => src.Where(x => x.IsStatic);

        /// <summary>
        /// Selects the fields from the stream for which the field type name contains the search string
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="search">The search string</param>
        public static IEnumerable<FieldInfo> WithTypeNameLike(this IEnumerable<FieldInfo> src, string search)
            => src.Where(x => x.FieldType.Name.Contains(search));

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
        /// Selects the instance properties from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<PropertyInfo> Instance(this IEnumerable<PropertyInfo> src)
            => src.Where(x=> (x.HasSetter() && !x.IsStatic()) || (x.HasGetter() && !x.IsStatic()));

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

        /// <summary>
        /// Selects the public types from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
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
        /// <param name="returnType">The method return type</param>
        public static IEnumerable<MethodInfo> Returns(this IEnumerable<MethodInfo> src, Type returnType)
            => src.Where(x => x.ReturnType == returnType);

        /// <summary>
        /// Selects methods from a stream that have a specified number of parameters
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="count">The parameter count</param>
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
        /// Selects the members with names that contain the supplied search field
        /// </summary>
        /// <param name="src">The members to examine</param>
        /// <param name="search">The name to match</param>
        public static IEnumerable<T> WithNameLike<T>(this IEnumerable<T> src, string search)
            where T : MemberInfo
            => src.Where(x => x.Name.Contains(search)); 

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
    
        /// <summary>
        /// JIT's the method and returns a pointer to the native body
        /// </summary>
        /// <param name="m">The method to JIT</param>
        public static IntPtr Prepare(this MethodInfo m)
        {            
            RuntimeHelpers.PrepareMethod(m.MethodHandle);
            var ptr = m.MethodHandle.GetFunctionPointer();
            return ptr;
        }    
 
        [MethodImpl(Inline)]
        public static void JitMethod(this MethodBase method)
        {
            try
            {
                RuntimeHelpers.PrepareMethod(method.MethodHandle);
            }
            catch(Exception e)
            {
                error(errorMsg(e));
            }
        }

        public static void JitMethods(this IEnumerable<MethodBase> methods)
            => iter(methods,JitMethod);
    }
}