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
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;

    using static zfunc;
    using static ReflectionFlags;

    partial class Reflections
    {


        [MethodImpl(Inline)]
        public static bool IsStatic(this PropertyInfo p)
            => p.GetGetMethod()?.IsStatic == true 
            || p.GetSetMethod().IsStatic == true;

        /// <summary>
        /// Determines whether a type is static
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsStatic(this Type t)
            => t.IsAbstract && t.IsSealed;


        /// <summary>
        /// Determines whether a type has a public default constructor
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool HasDefaultPublicConstructor(this Type t)
            => t.GetConstructor(new Type[] { }) != null;

        /// <summary>
        /// Determines whether a type has a public default constructor
        /// </summary>
        /// <typeparam name="T">The type to examine</typeparam>
        [MethodImpl(Inline)]
        public static bool HasDefaultPublicConstructor<T>()
            where T : class 
                => typeof(T).GetConstructor(new Type[] { }) != null;

        /// <summary>
        /// Determines whether the member instance classification is equivalent to static
        /// </summary>
        /// <param name="mit">The instance classification</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static bool IsStaticType(this MemberInstanceType mit)
            => mit == MemberInstanceType.Static;

        /// <summary>
        /// Determines whether a type implements a specified interface
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="interfaceType">The interface type</param>
        [MethodImpl(Inline)]
        public static bool Realizes(this Type t, Type interfaceType)
            => interfaceType.IsInterface && t.GetInterfaces().Contains(interfaceType);

        /// <summary>
        /// Determines whether a type implements a specific interface
        /// </summary>
        /// <typeparam name="T">The interface type</typeparam>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool Realizes<T>(this Type t)
            => typeof(T).IsInterface && t.GetInterfaces().Contains(typeof(T));

        /// <summary>
        /// Determines whether a type is nullable
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static bool IsNullableType(this Type t)
            => t.IsGenericType
                && t.GetGenericTypeDefinition() == typeof(Nullable<>);

        /// <summary>
        /// Determines whether a type is a nullable or non-nullable type with a given underlying type
        /// </summary>
        /// <typeparam name="T">The type to match</typeparam>
        /// <param name="t">The type to examine</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        internal static bool IsTypeOf<T>(this Type t)
            => t == typeof(T) || t.IsNullableType<T>();

        /// <summary>
        /// Determines whether a supplied type is either a <see cref="DateTime"/> or a <see cref="Nullable{DateTime}"/>
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsDateTime(this Type t)
            => t.IsTypeOf<DateTime>();

        /// <summary>
        /// Determines whether a supplied type is either a <see cref="Byte"/> or a <see cref="Nullable{Byte}"/>
        /// </summary>
        /// <param name="src">The type to examine</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static bool IsUInt8(this Type src)
            => src.IsTypeOf<Byte>();

        /// <summary>
        /// Determines whether a supplied type is either a <see cref="SByte"/> or a <see cref="Nullable{SByte}"/>
        /// </summary>
        /// <param name="src">The type to examine</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static bool IsInt8(this Type src)
            => src.IsTypeOf<SByte>();

        /// <summary>
        /// Determines whether a supplied type is either a <see cref="Int16"/> or a <see cref="Nullable{Int16}"/>
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsInt16(this Type t)
            => t.IsTypeOf<Int16>();

        /// <summary>
        /// Determines whether a supplied type is either a <see cref="UInt16"/> or a <see cref="Nullable{UInt16}"/>
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsUInt16(this Type t)
            => t.IsTypeOf<UInt16>();

        /// <summary>
        /// Determines whether a supplied type is either a <see cref="Int32"/> or a <see cref="Nullable{Int32}"/>
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsInt32(this Type t)
            => t.IsTypeOf<Int32>();

        /// <summary>
        /// Determines whether a supplied type is either a <see cref="UInt32"/> or a <see cref="Nullable{UInt32}"/>
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsUInt32(this Type t)
            => t.IsTypeOf<UInt32>();

        /// <summary>
        /// Determines whether a supplied type is either a <see cref="Int64"/> or a <see cref="Nullable{Int64}"/>
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static bool IsInt64(this Type t)
            => t.IsTypeOf<Int64>();

        /// <summary>
        /// Determines whether a supplied type is either a <see cref="UInt64"/> or a <see cref="Nullable{UInt64}"/>
        /// </summary>
        /// <param name="src">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsUInt64(this Type src)
            => src.IsTypeOf<UInt64>();

        /// <summary>
        /// Determines whether a supplied type is either a <see cref="Double"/> or a <see cref="Nullable{Double}"/>
        /// </summary>
        /// <param name="src">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsDouble(this Type src)
            => src.IsTypeOf<Double>();

        /// <summary>
        /// Determines whether a supplied type is either a <see cref="Single"/> or a <see cref="Nullable{Single}"/>
        /// </summary>
        /// <param name="src">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsSingle(this Type src)
            => src.IsTypeOf<Single>();

        /// <summary>
        /// Determines whether a supplied type is either a <see cref="Decimal"/> or a nullable <see cref="Nullable{Decimal}"/>
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsDecimal(this Type t)
            => t.IsTypeOf<Decimal>();

        /// <summary>
        /// Determines whether a supplied type is one of the intrinsic integral types or a nullable type thereof
        /// </summary>
        /// <param name="src">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsInteger(this Type src)
            => src.IsInt32() || src.IsInt64() || src.IsInt8() || src.IsInt16()
            || src.IsUInt8() || src.IsUInt32() || src.IsUInt64() || src.IsUInt16();

        /// <summary>
        /// Determines whether a supplied type is DBNull
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static bool IsDbNull(this Type t)
            => t.IsTypeOf<DBNull>();

        /// <summary>
        /// Determines whether a supplied type is either a <see cref="TimeSpan"/> or a <see cref="Nullable{TimeSpan}"/>
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsTimeSpan(this Type t)
            => t.IsTypeOf<TimeSpan>();

        /// <summary>
        /// Determines whether a supplied type is either a <see cref="Boolean"/> or a <see cref="Nullable{Boolean}"/>
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsBool(this Type t)
            => t.IsTypeOf<Boolean>();

        /// <summary>
        /// Determines whether a supplied type is of type string
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <returns></returns>
        [MethodImpl(Inline)]
        public static bool IsString(this Type t)
            => t == typeof(string);

        /// <summary>
        /// Determines whether a supplied type is either a <see cref="Char"/> or a nullable <see cref="Nullable{Char}"/>
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsChar(this Type t)
            => t.IsTypeOf<Char>();

        /// <summary>
        /// Determines whether a supplied type is either a <see cref="Guid"/> or a nullable <see cref="Nullable{Guid}"/>
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsGuid(this Type t)
            => t.IsTypeOf<Guid>();

        /// <summary>
        /// Determine whether a type is a nullable type with a given underlying type
        /// </summary>
        /// <typeparam name="T">The underlying type</typeparam>
        /// <param name="t">The type to check</param>
        /// <returns>
        /// Returns true if t is both a nullable type and is of type T
        /// </returns>
        [MethodImpl(Inline)]
        public static bool IsNullableType<T>(this Type t)
            => t.IsNullableType() && Nullable.GetUnderlyingType(t) == typeof(T);

        /// <summary>
        /// Determines whether a type is an intrinsic numeric type
        /// </summary>
        /// <param name="type">The type to evaluate</param>
        public static bool IsIntrinsicNumber(this Type type)
        {
            switch (Type.GetTypeCode(type))
            {
                case TypeCode.Byte: case TypeCode.Decimal: case TypeCode.Double:
                case TypeCode.Int16: case TypeCode.Int32: case TypeCode.Int64:
                case TypeCode.SByte: case TypeCode.Single: case TypeCode.UInt16:
                case TypeCode.UInt32: case TypeCode.UInt64:
                    return true;
                case TypeCode.Object:
                    if (type.IsNullableType())
                        return IsIntrinsicNumber(Nullable.GetUnderlyingType(type));
                    return false;
            }
            return false;
        }

        /// <summary>
        /// Determines whether a type is anonymous
        /// </summary>
        /// <param name="src">The type to test</param>
        /// <remarks>
        /// Lifted from: https://github.com/NancyFx/Nancy/blob/master/src/Nancy/ViewEngines/Extensions.cs
        /// </remarks>
        public static bool IsAnonymous(this Type src)
            => src == null ? false : src.GetTypeInfo().IsGenericType
                    && (src.GetTypeInfo().Attributes & TypeAttributes.NotPublic) == TypeAttributes.NotPublic
                    && (src.Name.StartsWith("<>", StringComparison.OrdinalIgnoreCase) || src.Name.StartsWith("VB$", StringComparison.OrdinalIgnoreCase))
                    && (src.Name.Contains("AnonymousType") || src.Name.Contains("AnonType"))
                    && src.GetTypeInfo().GetCustomAttributes(typeof(CompilerGeneratedAttribute)).Any();

        /// <summary>
        /// Determines whether the type is an option type and if so returns the underlying option
        /// type encapsulated within an option ( ! ). Otherwise, none
        /// </summary>
        /// <param name="candidate">the type to test</param>
        [MethodImpl(Inline)]
        public static bool IsOption(this Type candidate)
            => candidate.Realizes<IOption>();

        /// <summary>
        /// Determines whether a type has a name
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsNamed(this Type t)
            => !t.IsAnonymous();

        /// <summary>
        /// Determines whether a type is a struct
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsStruct(this Type t)
            => t.IsValueType && !t.IsEnum;

        /// <summary>
        /// Determines whether the specified type is a delegate type
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsDelegate(this Type t)
            => t.IsSubclassOf(typeof(Delegate));

        static readonly ConcurrentDictionary<Type, IReadOnlyList<ValueMember>> ValueMemberCache
            = new ConcurrentDictionary<Type, IReadOnlyList<ValueMember>>();


        /// <summary>
        /// Selects the types from a specified namespace
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<Type> InNamespace(this IEnumerable<Type> src, string match)
            => src.Where(t => t.Namespace == match);

        /// <summary>
        /// Selects all instance/static and public/non-public fields declared by a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<FieldInfo> DeclaredFields(this Type src)
            => src.GetFields(BF_Declared);

        /// <summary>
        /// Selects all instance/static and public/non-public fields declared by a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<FieldInfo> Fields(this Type src, bool declared = true)
            => src.GetFields(declared ? BF_Declared : BF_All);

        /// <summary>
        /// Selects the public immutable  fields defined by the type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static IEnumerable<FieldInfo> GetDeclaredPublicImmutableFields(this Type t, MemberInstanceType mit)
            => from f in (mit.IsStaticType() 
                    ? t.GetFields(BF_DeclaredPublicStatic) 
                    : t.GetFields(BF_DeclaredPublicInstance))
            where f.IsInitOnly || f.IsLiteral
            select f;

        /// <summary>
        /// Selects all instance/static and public/non-public fields declared and/or inheritied by the type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static IEnumerable<FieldInfo> AllFields(this Type t)
            => t.GetFields(BF_All);

        /// <summary>
        /// Selects the public and non-public static fields declared by a type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static IEnumerable<FieldInfo> DeclaredInstanceFields(this Type t)
            => t.GetFields(BF_DeclaredInstance);

        /// <summary>
        /// Selects the public and nonpublic immutable fields defined by the type
        /// </summary>
        /// <param name="t">The type to examine</param>
        static IEnumerable<FieldInfo> DeclaredImmutableFields(this Type t)
              => t.Fields().Immutable();

        /// <summary>
        /// Selects all instance/static and public/non-public fields inhertited by a type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static IEnumerable<FieldInfo> InheritedFields(this Type t)
            => t.Fields(false).Except(t.Fields(true));


        /// <summary>
        /// Selects the public fields declared by a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<FieldInfo> DeclaredPublicFields(this Type src)
            => src.GetFields(BF_DeclaredPublic);

        /// <summary>
        /// Retrieves the non-public fields declared by a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<FieldInfo> DeclaredNonPublicFields(this Type src)
            => src.GetFields(BF_DeclaredPublic);


        /// <summary>
        /// Retrieves the public instance Fields declared by a supertype
        /// </summary>
        /// <param name="src">The type to examine</param>
        /// <returns></returns>
        public static IEnumerable<FieldInfo> InheritedPublicFields(this Type src)
            => src.BaseType?.GetFields(BF_AllPublicInstance) ?? new FieldInfo[] { };

        /// <summary>
        /// Retrieves all public instance Fields declared or inherited by a type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static IEnumerable<FieldInfo> PublicFields(this Type t)
            => t.InheritedPublicFields().Union(t.GetFields());

        /// <summary>
        /// Attempts to retrieves a static field by name, irrespective of its visibility
        /// </summary>
        /// <param name="t">The declaring type</param>
        /// <param name="name">The name of the method</param>
        public static Option<FieldInfo> DeclaredStaticField(this Type t, string name) 
            => t.Fields().Static().Where(f => f.Name == name).FirstOrDefault();


        /// <summary>
        /// Retrieves a public or non-public setter for a property if it exists
        /// </summary>
        /// <param name="p">The property to examine</param>
        public static Option<MethodInfo> Setter(this PropertyInfo p)
            => p.GetSetMethod() ?? p.GetSetMethod(true);

        /// <summary>
        /// Retrieves a public or non-public getter for a property if it exists
        /// </summary>
        /// <param name="p">The property to examine</param>
        public static Option<MethodInfo> Getter(this PropertyInfo p)
            => p.GetGetMethod() ?? p.GetGetMethod(true);

        /// <summary>
        /// Retrieves all instance/static and public/non-public properties declared by a type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static IEnumerable<PropertyInfo> DeclaredProperties(this Type t)
            => t.GetProperties(BF_Declared);

        public static IEnumerable<PropertyInfo> AllProperties(this Type t)
            => t.GetProperties(BF_All);

        /// <summary>
        /// Retrieves all instance/static and public/non-public properties 
        /// </summary>
        /// <param name="src">The types to examine</param>
        public static IEnumerable<PropertyInfo> Properties(this IEnumerable<Type> src, bool declared = true)
            => (declared ? src.Select(DeclaredProperties) : src.Select(x => x.Properties(declared))).SelectMany(x => x);

        /// <summary>
        /// Retrieves all instance/static and public/non-public properties 
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<PropertyInfo> Properties(this Type src, bool declared = true)
            => src.GetProperties(declared ? BF_Declared : BF_All);

        /// <summary>
        /// Selects the public/non-public static/instance methods declared by a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<MethodInfo> DeclaredMethods(this Type src)
            => src.GetMethods(BF_Declared);

        /// <summary>
        /// Selects the public/non-public static/instance methods declared or exposed by a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<MethodInfo> Methods(this Type src, bool declared = true)
            => declared ? src.GetMethods(BF_Declared) : src.GetMethods(BF_All);
 
        /// <summary>
        /// Selects the public/non-public static/instance methods declared by stream of types
        /// </summary>
        /// <param name="src">The types to examine</param>
        public static IEnumerable<MethodInfo> DeclaredMethods(this IEnumerable<Type> src)
            => src.Select(x => x.DeclaredMethods()).SelectMany(x => x);

        public static IEnumerable<MethodInfo> Methods(this IEnumerable<Type> src, bool declared = true)
            => src.Select(x => x.Methods(declared)).SelectMany(x => x);

        public static IEnumerable<object> Values(this IEnumerable<FieldInfo> src, object o = null)
            => src.Select(x => x.GetValue(o));

        public static IEnumerable<T> Values<T>(this IEnumerable<FieldInfo> src, object o = null)
            => src.Select(x => x.GetValue(o)).Where(x => x is T).Cast<T>();


        /// <summary>
        /// Retrieves a type's default constructor, if present; otherwise, none
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static Option<ConstructorInfo> DefaultConstructor(this Type t)
            => t.GetConstructor(BF_DeclaredInstance, null, new Type[] { }, new ParameterModifier[] { });

        /// <summary>
        /// If a reference type, returns the type; if a value type and not an enum, returns 
        /// the type; if an enum returns the unerlying integral type; if a nullable value type
        /// that is not an enum, returns the underlying type; if anullable enum returns the 
        /// non-nullable underlying integral type
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <returns></returns>
        public static Type GetUnderlyingType(this Type t)
        {
            if (t.IsNullableType())
            {
                var _t = Nullable.GetUnderlyingType(t);
                return _t.IsEnum ? _t.GetEnumUnderlyingType() : _t;
            }
            else
                return t.IsEnum ? t.GetEnumUnderlyingType() : t;
        }

        /// <summary>
        /// Retrieves the public, staticic and immutable fields defined by the type
        /// </summary>
        /// <param name="t">The type to examine</param>
        static IEnumerable<FieldInfo> GetDeclaredPublicStaticImmutableFields(this Type t)
            =>  t.Fields().Public().Immutable().Static();

        /// <summary>
        /// Retrieves the values of the public, staticic and immutable fields defined by the type
        /// </summary>
        /// <param name="t">The type to examine</param>
        static IEnumerable<object> GetDeclaredPublicStaticImmutableFieldValues(this Type t)
            =>  t.Fields().Public().Static().Immutable().Values();

        /// <summary>
        /// Retrieves the T-values of the public, static and immutable fields defined by the type
        /// </summary>
        /// <param name="t">The type to examine</param>
        static IEnumerable<T> GetDeclaredPublicStaticImmutableFieldValues<T>(this Type t)
            =>  t.GetDeclaredPublicStaticImmutableFieldValues().Where(v => v is T).Cast<T>();

        /// <summary>
        /// Selects the public immutable instance fields defined by a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        static IEnumerable<FieldInfo> GetDeclaredPublicInstanceImmutableFields(this Type src)
            =>  src.Fields().Public().Instance().Immutable();

        /// <summary>
        /// Retrieves the nonpublic immutable fields defined by a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        static IEnumerable<FieldInfo> GetDeclaredNonPublicInstanceImmutableFields(this Type src)
            =>  src.Fields().NonPublic().Instance().Immutable();
        
        /// <summary>
        /// Retrieves the type's public inherited immutable instance fields
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public static IEnumerable<FieldInfo> GetInheritedPublicImmutableFields(this Type t, MemberInstanceType mit)
            => from f in ((
                    mit.IsStaticType() 
                ? t.BaseType?.GetFields(BF_AllPublicStatic) 
                : t.BaseType?.GetFields(BF_AllPublicInstance)) 
                ?? new FieldInfo[] { }
                )
            where f.IsInitOnly || f.IsLiteral
            select f;

        /// <summary>
        /// Retrieves the type's non-public fields
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<FieldInfo> GetPublicImmutableFields(this Type src, MemberInstanceType mit)
            => src.GetInheritedPublicImmutableFields(mit).Union(src.GetDeclaredPublicImmutableFields(mit));

        /// <summary>
        /// Retrieves the non-public immutable instance fields declared by the type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static IEnumerable<FieldInfo> DeclaredNonPublicImmutableInstanceFields(this Type t)
            =>  t.Fields().NonPublic().Immutable().Instance();  

        /// <summary>
        /// Retrieves the non-public immutable instance fields inherited by the type
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <returns></returns>
        public static IEnumerable<FieldInfo> GetInheritedRestrictedImmutableFields(this Type t)
            => t.BaseType?.GetFields(BF_AllRestrictedInstance)
                        ?.Where(f => f.IsInitOnly || f.IsLiteral) ?? new FieldInfo[] { };

        /// <summary>
        /// Retrieves the immutable instance fields inherited and declared by the type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static IEnumerable<FieldInfo> GetRestrictedImmutableFields(this Type t)
            => t.GetInheritedRestrictedImmutableFields().Union(t.DeclaredNonPublicImmutableInstanceFields());

        /// <summary>
        /// Retrieves the public properties declared by a type
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="mit">The instance type</param>
        /// <param name="requireSetters">Whether the existence of setters are requied to satisfy matches</param>
        /// <returns></returns>
        public static IEnumerable<PropertyInfo> GetDeclaredPublicProperties(this Type t, 
            MemberInstanceType mit,  bool requireSetters = false)
                => (mit == MemberInstanceType.Instance 
                    ? t.GetProperties(BF_DeclaredPublicInstance) 
                    : t.GetProperties(BF_DeclaredPublicStatic)
                    ).Where(p => !p.IsIndexer() && (requireSetters ? p.HasSetter() : true));

        

        /// <summary>
        /// Retrieves the public instance properties declared by a type
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="mit">The instance type</param>
        /// <param name="requireSetters">Whether the existence of setters are requied to satisfy matches</param>
        /// <returns></returns>
        public static IEnumerable<PropertyInfo> GetDeclaredPublicInstanceProperties(this Type t, bool requireSetters = false)
            => t.GetDeclaredPublicProperties(MemberInstanceType.Instance, requireSetters);
        
        /// <summary>
        /// Retrieves the non-public properties declared by a type
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="mit">The instance type</param>
        /// <param name="requireSetters">Whether the existence of setters are requied to satisfy matches</param>
        /// <returns></returns>

        public static IEnumerable<PropertyInfo> GetDeclaredNonPublicProperties(this Type t, 
            MemberInstanceType mit, bool requireSetters = false)
                => (mit == MemberInstanceType.Instance
                    ? t.GetProperties(BF_DeclaredNonPublicInstance)
                    : t.GetProperties(BF_DeclaredNonPublicStatic)
                    ).Where(p => !p.IsIndexer() && (requireSetters ? p.HasSetter() : true));

            
        /// <summary>
        /// Searches for non-public methods delcared by the type
        /// </summary>
        /// <param name="t">The type to search</param>
        /// <param name="mit">The instance type</param>
        /// <returns></returns>
        public static IEnumerable<MethodInfo> GetDeclaredNonPublicMethods(this Type t,
            MemberInstanceType mit)
                => (mit == MemberInstanceType.Instance
                    ? t.GetMethods(BF_DeclaredNonPublicInstance)
                    : t.GetMethods(BF_DeclaredNonPublicStatic)
                    );

        /// <summary>
        /// Retrieves the public instance properties declared by a supertype
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <returns></returns>
        public static IEnumerable<PropertyInfo> GetInheritedPublicProperties(this Type t, bool requireSetters = false)
            => t.BaseType?.GetProperties(BF_AllPublicInstance)
                        .Where(p => !p.IsIndexer() && (requireSetters ? p.HasSetter() : true))
                        ?? new PropertyInfo[] { };

        /// <summary>
        /// Retrieves the inheritance chain for a specifed type, up to, but not including, <see cref="object"/>
        /// </summary>
        /// <param name="child">The type to examine</param>
        /// <returns></returns>
        public static IEnumerable<Type> BaseTypes(this Type child)
        {
            if (child.BaseType != null && child.BaseType != typeof(object))
            {
                var parent = child.BaseType;
                yield return parent;

                foreach (var grandfather in BaseTypes(parent))
                    yield return grandfather;
            }
        }

        /// <summary>
        /// Retrieves all public instance properties declared or inherited by a type
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="requireSetters"></param>
        public static IEnumerable<PropertyInfo> PublicPropertySearch(this Type t, bool deduplicate, bool requireSetters = false)
        {
            //TODO: this approach is good enough for most cases but fails miserably in the general 
            //case because it doesn't deal with properties declared with new nor does it deal
            //properly with properties that have been overridden
            var props = new List<PropertyInfo>();
            var types = new List<Type>(t.BaseTypes());
            types.Add(t);
            foreach (var type in types)
            {
                iter(type.GetDeclaredPublicProperties(MemberInstanceType.Instance, requireSetters),
                    p =>
                    {
                        if (deduplicate)
                        {
                            var duplicate = props.FirstOrDefault(x => x.Name == p.Name);
                            if (duplicate != null)
                                props.Remove(duplicate);
                        }
                        props.Add(p);
                    });
            }

            if (deduplicate && props.Count != props.Distinct().Count())
                throw new Exception($"Deduplication of the properties of type {t} was requested but deduplication failed");
            return props;
        }


        /// <summary>
        /// Gets the public methods inherited by a type
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="InstanceType">The instance type classification</param>
        public static IEnumerable<MethodInfo> GetInheritedPublicMethods(this Type t, MemberInstanceType InstanceType)
            => (InstanceType.IsStaticType()
                ? t.BaseType?.GetMethods(BF_AllPublicStatic)
                : t.BaseType?.GetMethods(BF_AllPublicInstance)) 
                ?? new MethodInfo[] { };

        /// <summary>
        /// Gets the public methods declared by a type
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="InstanceType">The instance type classification</param>
        /// <returns></returns>
        public static IEnumerable<MethodInfo> GetDeclaredPublicMethods(this Type t, MemberInstanceType InstanceType)
            => InstanceType.IsStaticType() 
            ? t.GetMethods(BF_DeclaredPublicStatic) 
            : t.GetMethods(BF_DeclaredPublicInstance);

        /// <summary>
        /// Gets the public methods inherited or declared by a type
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="InstanceType">The instance type classification</param>
        /// <returns></returns>
        public static IEnumerable<MethodInfo> GetPublicMethods(this Type t, MemberInstanceType InstanceType)
            => t.GetInheritedPublicMethods(InstanceType).Concat(t.GetDeclaredPublicMethods(InstanceType));
            
        /// <summary>
        /// Retrieves a type's public and read-only fields of a specific type
        /// </summary>
        /// <typeparam name="T">The field value type</typeparam>
        /// <param name="declaringType"></param>
        public static IReadOnlyDictionary<string, T> GetDeclaredPublicReadonlyFieldIndex<T>(this Type declaringType)
            => declaringType.GetDeclaredPublicImmutableFields(MemberInstanceType.Static).Where(f => f.FieldType == typeof(T))
                    .Select(field =>
                        (
                            field.Name,
                            field.MemberValue<T>(null)
                        )).ToReadOnlyDictionary();

        /// <summary>
        /// Retrieves the public and not public methods declared by a type
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="InstanceType">Whether to selct static or instance </param>
        public static IEnumerable<MethodInfo> GetDeclaredMethods(this Type t, MemberInstanceType InstanceType)
            => t.GetMethods(InstanceType.IsStaticType()  ? BF_DeclaredStatic : BF_DeclaredInstance);

        /// <summary>
        /// Retrieves the public and non-public static methods declared by a type
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="InstanceType">Whether to selct static or instance </param>
        public static IEnumerable<MethodInfo> DeclaredStaticMethods(this Type t)
            => t.GetMethods(BF_DeclaredStatic);

        /// <summary>
        /// Retrieves the public and non-public static methods declared by a type that have a specific name
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="InstanceType">Whether to selct static or instance </param>
        /// <returns></returns>
        public static IEnumerable<MethodInfo> DeclaredStaticMethods(this Type t, string name)
            => t.GetMethods(BF_DeclaredStatic).Where(m => m.Name == name);

        /// <summary>
        /// Retrieves the public and non-public instance methods declared by a type
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="InstanceType">Whether to selct static or instance </param>
        /// <returns></returns>
        public static IEnumerable<MethodInfo> GetDeclaredInstanceMethods(this Type t)
            => t.GetMethods(BF_DeclaredInstance);


        /// <summary>
        /// Retrieves all public properties exposed by a type and appropriately handles interface inheritance
        /// </summary>
        /// <param name="type">The type to examine</param>
        /// <returns></returns>
        /// <remarks>
        /// Taken from: http://stackoverflow.com/questions/358835/getproperties-to-return-all-properties-for-an-interface-inheritance-hierarchy
        /// </remarks>   
        public static PropertyInfo[] GetPublicInstanceProperties(this Type type)
        {
            if (type.IsInterface)
            {
                var propertyInfos = new List<PropertyInfo>();

                var considered = new List<Type>();
                var queue = new Queue<Type>();
                considered.Add(type);
                queue.Enqueue(type);
                while (queue.Count > 0)
                {
                    var subType = queue.Dequeue();
                    foreach (var subInterface in subType.GetInterfaces())
                    {
                        if (considered.Contains(subInterface)) continue;

                        considered.Add(subInterface);
                        queue.Enqueue(subInterface);
                    }

                    var typeProperties = subType.GetProperties(
                        BindingFlags.FlattenHierarchy
                        | BindingFlags.Public
                        | BindingFlags.Instance);

                    var newPropertyInfos = typeProperties
                        .Where(x => !propertyInfos.Contains(x));

                    propertyInfos.InsertRange(0, newPropertyInfos);
                }

                return propertyInfos.ToArray();
            }

            return type.GetProperties(BindingFlags.FlattenHierarchy
                | BindingFlags.Public | BindingFlags.Instance);
        }

        /// <summary>
        /// Gets the static methods defined on a specified type
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <returns></returns>
        public static IEnumerable<MethodInfo> GetStaticMethods(this Type t)
            => t.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);

        /// <summary>
        /// Gets the static methods defined on a specified type
        /// </summary>
        /// <param name="this">The type to examine</param>
        /// <returns></returns>
        public static IEnumerable<PropertyInfo> GetStaticProperties(this Type @this)
            => @this.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);

        /// <summary>
        /// Retrieves a static method by name, irrespective of its visibility
        /// </summary>
        /// <param name="t">The declaring type</param>
        /// <param name="name">The name of the method</param>
        public static Option<MethodInfo> StaticMethod(this Type t, string name) 
            => t.GetMethod(name, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);


        /// <summary>
        /// Attempts to retrieve the value of a named static field
        /// </summary>
        /// <param name="src">The declaring type</param>
        /// <param name="name">The name of the method</param>
        static Option<V> DeclaredStaticFieldValue<V>(this Type src, string name)
            => src.DeclaredStaticField(name).Select(x => (V)x.GetValue(null));

        /// <summary>
        /// Discovers a type's automatic properties
        /// </summary>
        /// <param name="t"></param>
        static IReadOnlyList<ValueMember> AutoProps(this Type t)
        {
            var afquery = from f in t.GetRestrictedImmutableFields()
                        where f.IsCompilerGenerated() && f.Name.EndsWith("__BackingField")
                        select f;
            var backingFields = afquery.ToList();// .ToReadOnlySet();

            var propertyidx = t.PublicPropertySearch(true, false).ToDictionary(x => x.Name);
            var candidates = propertyidx.Keys.Select(x =>
                    (prop: propertyidx[x], Name:  $"\u003C{x}\u003Ek__BackingField"));
            var autoprops = new List<ValueMember>();
            foreach (var candidate in candidates)
            {
                backingFields.TryFind(f => f.Name == candidate.Name)
                            .OnSome(f => autoprops.Add(new ValueMember(candidate.prop, f)));
            }
            return autoprops;       
        }

        /// <summary>
        /// Gets the members of a type that can contain/represent data (properties and fields)
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IReadOnlyList<ValueMember> ValueMembers(this Type src)
            => ValueMemberCache.GetOrAdd(src, t =>
            {
                var members = new List<ValueMember>();        
                members.AddRange(src.AutoProps());
                var fieldMembers = t.GetPublicImmutableFields(MemberInstanceType.Instance).Select(x => new ValueMember(x));
                members.AddRange(fieldMembers);
                var propMembers = t.PublicPropertySearch(false, true).Where(x => x.CanRead && x.CanWrite).Select(x => new ValueMember(x));
                members.AddRange(propMembers);
                return members;
            });


        /// <summary>
        /// If non-nullable, returns the supplied type. If nullable, returns the underlying type
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static Type GetNonNullableType(this Type t)
            => nonNullable(t);

        /// <summary>
        /// Retrieves the values of a type's public instance properties
        /// </summary>
        /// <param name="t">The type to examine</param>
        /// <param name="o">The type instance</param>
        public static IReadOnlyDictionary<string, object> GetPropertyValues(this Type t, object o)
            => map(props(o), p => (p.Name, p.GetValue(o))).ToReadOnlyDictionary();


        /// <summary>
        /// Retrieves type attribution values from a stream of types
        /// </summary>
        /// <typeparam name="A"></typeparam>
        /// <param name="types"></param>
        /// <returns></returns>
        public static IReadOnlyDictionary<Type, Option<A>> GetTypeAttributions<A>(this IEnumerable<Type> types)
            where A : Attribute
            => (from type in types
                let attrib = type.GetCustomAttribute<A>(true)
                select (type, attrib != null
                        ? some(attrib)
                        : none<A>())).ToReadOnlyDictionary();

        /// <summary>
        /// Retrieves the type's properties together with applied attributes
        /// </summary>
        /// <typeparam name="A">The attribute type</typeparam>
        /// <param name="t">The type to examine</param>
        public static IReadOnlyDictionary<PropertyInfo, A> GetPropertyAttributions<A>(this Type t) where A : Attribute
        {
            var q = from p in t.GetProperties(BF_Instance)
                    where Attribute.IsDefined(p, typeof(A))
                    let attrib = p.GetCustomAttribute<A>()
                    select new
                    {
                        Member = p,
                        Attribute = attrib
                    };
            return q.ToDictionary(x => x.Member, x => x.Attribute);
        }

        /// <summary>
        /// Retrieves the type's fields together with applied attributes
        /// </summary>
        /// <typeparam name="A">The attribute type</typeparam>
        /// <param name="t">The type to examine</param>
        public static IDictionary<FieldInfo, A> DeclaredFieldAttributions<A>(this Type t)
            where A : Attribute
        {
            var q = from p in t.DeclaredFields()
                    where Attribute.IsDefined(p, typeof(A))
                    let attrib = p.GetCustomAttribute<A>()
                    select new
                    {
                        Member = p,
                        Attribute = attrib
                    };
            return q.ToDictionary(x => x.Member, x => x.Attribute);
        }

        /// <summary>
        /// Retrieves the attribution index for the identified methods declared by the type
        /// </summary>
        /// <typeparam name="A">The attribute type</typeparam>
        /// <param name="t">The type to examine</param>
        /// <param name="InstanceType">The member instance type</param>
        public static IDictionary<MethodInfo, A> GetMethodAttributions<A>(this Type t,
                MemberInstanceType InstanceType = MemberInstanceType.Instance)
                    where A : Attribute
        {
            var q = from m in t.GetDeclaredMethods(InstanceType)
                    where Attribute.IsDefined(m, typeof(A))
                    let attrib = m.GetCustomAttribute<A>()
                    select new
                    {
                        Member = m,
                        Attribute = attrib
                    };
            return q.ToDictionary(x => x.Member, x => x.Attribute);
        }

        /// <summary>
        /// Gets the value of a member attribute if it exists 
        /// </summary>
        /// <typeparam name="A">The attribute type</typeparam>
        /// <param name="m">The member</param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Option<A> CustomAttribute<A>(this MemberInfo m) where A : Attribute
            => m.GetCustomAttribute<A>();


        /// <summary>
        /// Recursively close an IEnumerable generic type
        /// </summary>
        /// <param name="stype">The sequence type</param>
        /// <remarks>
        /// Adapted from https://blogs.msdn.microsoft.com/mattwar/2007/07/30/linq-building-an-iqueryable-provider-part-i/
        /// </remarks>
        public static Option<Type> CloseEnumerableType(this Type stype)
        {
            if (stype == typeof(string))
                return null;

            if (stype.IsArray)
                return typeof(IEnumerable<>).MakeGenericType(stype.GetElementType());

            if (stype.IsGenericType)
            {
                foreach (var arg in stype.GetGenericArguments())
                {
                    var enumerable = typeof(IEnumerable<>).MakeGenericType(arg);
                    if (enumerable.IsAssignableFrom(stype))
                        return enumerable;
                }
            }

            var interfaces = stype.GetInterfaces();
            if (interfaces != null && interfaces.Length > 0)
            {
                foreach (var i in interfaces)
                {
                    var ienum = CloseEnumerableType(i);
                    if (ienum.Exists)
                        return ienum;
                }
            }

            if (stype.BaseType != null && stype.BaseType != typeof(object))
                return CloseEnumerableType(stype.BaseType);
            return null;
        }


        /// <summary>
        /// Creates an instance of a type and casts the instance value as specified by a type parameter
        /// </summary>
        /// <typeparam name="T">The cast instance type</typeparam>
        /// <param name="t">The type for which an instance will be created</param>
        /// <param name="args">Arguments matched with/passed to an instance constructor defined by the type</param>
        [MethodImpl(Inline)]
        public static T CreateInstance<T>(this Type t, params object[] args)
            => (T)Activator.CreateInstance(t, args);

    }    
}