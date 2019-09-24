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

    partial class Reflections
    {        
        /// <summary>
        /// Constructs a display name for a type
        /// </summary>
        /// <param name="src">The source type</param>
        public static string DisplayName(this Type src, [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
        {
            if(src == null)
                throw new ArgumentNullException(nameof(src), $"Called from {line} {file}");
                
            if(src.IsEnum)
                return src.Name + AsciSym.Colon + src.GetEnumUnderlyingType().DisplayName();

            if(src.IsSimpleName())
                return src.FormatSimple();

            if(src.IsGenericType && !src.IsRef())
                return src.FormatGeneric();

            if(src.IsRef())
                return src.GetElementType().DisplayName();

            return src.Name;
        }

        /// <summary>
        /// Constructs a display name for a method parameter
        /// </summary>
        /// <param name="type">Describes the parameter type</param>
        /// <param name="name">The parameter display name</param>
        /// <returns></returns>
        public static (string type, string name) DisplayName(this ParameterInfo param)
        {
            var modifier = string.Empty;
            if(param.IsIn)
                modifier = "in ";
            else if(param.IsOut)
                modifier = "out ";
            else if(param.ParameterType.IsByRef)
                modifier = "ref ";
            var t = param.ParameterType.GetElementType();
            return  (modifier + (t.IsGenericType ? t.FormatGeneric() : t.FormatSimple()), param.Name);
        }

        public static string FormatReference(this Type src, bool isIn = false, bool isOut = false)            
        {
            var dst = isIn ? "in " : isOut ? "out " : "ref ";
            dst = dst + src.GetElementType().DisplayName();
            return dst;
        }

        /// <summary>
        /// Constructs a display name for a method
        /// </summary>
        /// <param name="src">The source method</param>
        public static string DisplayName(this MethodInfo src)
        {
            var attrib = src.GetCustomAttribute<DisplayNameAttribute>();
            if(attrib != null)
                return attrib.DisplayName;
            var slots = src.GenericSlots();
            return slots.Length == 0 ? src.Name : GenericMemberDisplayName(src.Name, slots);            
        }

        /// <summary>
        /// Constructs a display name for a method that includes the name of a typee
        /// </summary>
        /// <typeparam name="T">The relative type</typeparam>
        /// <param name="src">The source method</param> 
        [MethodImpl(Inline)]
        public static string TypedDisplayName<T>(this MethodBase src)
            => typeof(T).Name
                + $"/{src.Name.Replace(typeof(T).FullName + ".", string.Empty)}";

        /// <summary>
        /// Constructs a display name for a method
        /// </summary>
        /// <param name="src">The source method</param>
        [MethodImpl(Inline)]
        public static string FullDisplayName(this MethodInfo src)
            => $"{src.DeclaringType.DisplayName()}{src.DisplayName()}";

        static string GenericMemberDisplayName(string memberName, IReadOnlyList<Type> args)
        {                
            var argFmt = args.Count != 0 ? args.Select(t => t.DisplayName()).Concat(", ") : string.Empty;            
            var typeName = memberName.Replace($"`{args.Count}", string.Empty);
            return typeName + (args.Count != 0 ? angled(argFmt) : string.Empty);
        }

        static bool IsSimpleName(this Type src)
        {
            return 
                Attribute.IsDefined(src, typeof(DisplayNameAttribute))
                || src.IsPrimalNumeric()
                || src.IsBool()
                || src.IsVoid()
                || src.IsString();                            
        }

        static string FormatSimple(this Type src)
        {
            var attrib = src.GetCustomAttribute<DisplayNameAttribute>();
            if (attrib != null)
                return attrib.DisplayName;

            if(src.IsPrimalNumeric())
                return src.PrialNumericName();
            
            if(src.IsBool())
                return "bool";
            
            if(src.IsVoid())
                return "void";
            
            if(src.IsString())
                return "string";  

            return src.Name;          
        }

        static string FormatGeneric(this Type src)
        {
            var name = src.Name;                
            var args = src.GetGenericArguments();
            if(args.Length != 0)
            {
                name = name.Replace($"`{args.Length}", string.Empty);
                name += "<";
                for(var i= 0; i< args.Length; i++)
                {
                    name += args[i].DisplayName();
                    if(i != args.Length - 1)
                        name += ",";
                }                                
                name += ">";
            }
            return name;

        }

    }

}