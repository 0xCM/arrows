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
        /// Creates a report that specifies disagreement between property values, when both properties are defined
        /// on supplied objects
        /// </summary>
        /// <param name="x">An object</param>
        /// <param name="y">An object</param>
        public static IDictionary<string, Tuple<object, object>> ComputePropertyValueDelta(object x, object y)
        {
            var delta = new Dictionary<string, Tuple<object, object>>();
            var xprops = x.GetType().GetProperties();
            var yprops = y.GetType().GetProperties();
            foreach (var xprop in xprops)
            {
                var yprop = yprops.FirstOrDefault(z => z.Name == xprop.Name);
                if (yprop != null)
                {
                    var xval = xprop.GetValue(x);
                    var yval = yprop.GetValue(y);
                    if (!Object.Equals(xval, yval))
                    {
                        delta[xprop.Name] = Tuple.Create(xval, yval);
                    }
                }
            }

            return delta;
        }

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



    }
}