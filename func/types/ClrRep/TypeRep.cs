//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using static zfunc;

    /// <summary>
    /// A succinct representative of a .Net type
    /// </summary>
    public class TypeRep : ClrItemRep
    {        
        public static TypeRep FromType(Type src)
            => new TypeRep(src.DisplayName(), src.IsConstructedGenericType,  src.IsGenericType && !src.IsConstructedGenericType, src.IsByRef);

        public static TypeRep FromParameter(ParameterInfo src)
        {
            var type = src.ParameterType;
            var name = type.IsRef() ? type.GetElementType().DisplayName() : type.DisplayName();
            
            return new TypeRep(name, 
                type.IsConstructedGenericType, 
                type.IsGenericType && !type.IsConstructedGenericType,
                type.IsRef(),
                src.IsIn,
                src.IsOut);
        }

        public TypeRep(string Name, bool IsOpenGeneric, bool IsClosedGeneric, bool IsByRef, bool IsIn = false, bool IsOut = false)
            : base(Name)
        {
            this.IsOpenGeneric = IsOpenGeneric;
            this.IsClosedGeneric = IsClosedGeneric;
            this.IsByRef = IsByRef;
            this.IsIn = IsIn;
            this.IsOut = IsOut;
        }

        public bool IsOpenGeneric {get;}

        public bool IsClosedGeneric {get;}

        public bool IsByRef {get;}

        public bool IsIn {get;}

        public bool IsOut {get;}

        string Modifier
            => IsIn ? "in " : IsOut ? "out " : IsByRef ? "ref " : string.Empty;

        public override string Format()
            => $"{Modifier}{Name}";        
    }
}