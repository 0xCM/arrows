//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static zfunc;

    public static class PrimalTypes
    {
        /// <summary>
        /// Specifies the set of unsigned primal integer types
        /// </summary>
        public static readonly Type[] UnsignedInt = 
            array(typeof(byte),  typeof(ushort), typeof(uint), typeof(ulong));

        /// <summary>
        /// Specifies the set of signed primal integer types
        /// </summary>
        public static readonly Type[] SignedInt = 
            array(typeof(sbyte), typeof(short), typeof(int),  typeof(long));

        /// <summary>
        /// Specifies the set of primal integer types
        /// </summary>
        public static readonly Type[] Int = 
            concat(UnsignedInt, SignedInt);

        /// <summary>
        /// Specifies the set of primal floating-point types
        /// </summary>
        public static readonly Type[] Floating = 
            array(typeof(float),typeof(double));

        /// <summary>
        /// Specifies the set of all primal numeric types
        /// </summary>
        public static readonly HashSet<Type> All = 
            new HashSet<Type>(concat(UnsignedInt, SignedInt, Floating));

        [MethodImpl(Inline)]
        public static bool IsPrimalNumeric(this Type src)
            => All.Contains(src) || All.Contains(src.GetUnderlyingType());
    
        [MethodImpl(Inline)]
        public static string PrialNumericName(this Type src)
        {
            if(src == typeof(sbyte) || src.GetUnderlyingType() == typeof(sbyte))
                return "sbyte";
            else if(src == typeof(byte) || src.GetUnderlyingType() == typeof(byte))
                return "byte";
            else if(src == typeof(ushort)|| src.GetUnderlyingType() == typeof(ushort))
                return "ushort";
            else if(src == typeof(short)|| src.GetUnderlyingType() == typeof(short))
                return "short";
            else if(src == typeof(int)|| src.GetUnderlyingType() == typeof(int))
                return "int";
            else if(src == typeof(uint)|| src.GetUnderlyingType() == typeof(uint))
                return "uint";
            else if(src == typeof(long)|| src.GetUnderlyingType() == typeof(long))
                return "long";
            else if(src == typeof(ulong) || src.GetUnderlyingType() == typeof(ulong))
                return "ulong";
            else if(src == typeof(float)|| src.GetUnderlyingType() == typeof(float))
                return "float";
            else if(src == typeof(double)|| src.GetUnderlyingType() == typeof(double))
                return "double";
            else 
                return string.Empty;
        }

        [MethodImpl(Inline)]
        public static string PrialNumericName<T>()
            where T : struct
                => typeof(T).PrialNumericName();
        
    
        /// <summary>
        /// Determines whether a supplied type or underlying type is a byte
        /// </summary>
        /// <param name="src">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsUInt8(this Type src)
            => !src.IsEnum  && (src == typeof(byte) || src.GetUnderlyingType() == typeof(byte));

        /// <summary>
        /// Determines whether a supplied type or underlying type is a sbyte
        /// </summary>
        /// <param name="src">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsInt8(this Type src)
            => !src.IsEnum  && (src == typeof(sbyte) || src.GetUnderlyingType() == typeof(sbyte));

        /// <summary>
        /// Determines whether a supplied type or underlying type is a Int16
        /// </summary>
        /// <param name="src">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsInt16(this Type src)
            => !src.IsEnum  && (src == typeof(short) || src.GetUnderlyingType() == typeof(short));

        /// <summary>
        /// Determines whether a supplied type or underlying type is a UInt16
        /// </summary>
        /// <param name="src">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsUInt16(this Type src)
            => !src.IsEnum  && (src == typeof(ushort) || src.GetUnderlyingType() == typeof(ushort));

        /// <summary>
        /// Determines whether a supplied type or underlying type is a Int32
        /// </summary>
        /// <param name="src">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsInt32(this Type src)
            => !src.IsEnum  && (src == typeof(int) || src.GetUnderlyingType() == typeof(int));

        /// <summary>
        /// Determines whether a supplied type or underlying type is a UInt32
        /// </summary>
        /// <param name="src">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsUInt32(this Type src)
            => !src.IsEnum  && (src == typeof(uint) || src.GetUnderlyingType() == typeof(uint));

        /// <summary>
        /// Determines whether a supplied type or underlying type is a Int64
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsInt64(this Type src)
            => !src.IsEnum  && (src == typeof(long) || src.GetUnderlyingType() == typeof(long));

        /// <summary>
        /// Determines whether a supplied type or underlying type is a UInt64
        /// </summary>
        /// <param name="src">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsUInt64(this Type src)
            => !src.IsEnum  && (src == typeof(ulong) || src.GetUnderlyingType() == typeof(ulong));

        /// <summary>
        /// Determines whether a supplied type or underlying type is a Double
        /// </summary>
        /// <param name="src">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsDouble(this Type src)
            => !src.IsEnum  && (src == typeof(double) || src.GetUnderlyingType() == typeof(double));

        /// <summary>
        /// Determines whether a supplied type or underlying type is a Double
        /// </summary>
        /// <param name="src">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsSingle(this Type src)
            => !src.IsEnum  && (src == typeof(float) || src.GetUnderlyingType() == typeof(float));

        /// <summary>
        /// Determines whether a supplied type or underlying type is a Decimal
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsDecimal(this Type src)
            => src == typeof(decimal) || src.GetUnderlyingType() == typeof(decimal);

    }

}