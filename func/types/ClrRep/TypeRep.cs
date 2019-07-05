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
    /// Represents a .Net type
    /// </summary>
    public class TypeRep : ClrItemRep
    {        
        public static TypeRep FromType(Type src)
            => new TypeRep(src.DisplayName(), src.IsConstructedGenericType,  
                    src.IsGenericType && !src.IsConstructedGenericType);

        public TypeRep(string Name, bool IsOpenGeneric, bool IsClosedGeneric, ClrRepTag? Tag = null)
            : base(Name)
        {
            this.IsOpenGeneric = IsOpenGeneric;
            this.IsClosedGeneric = IsClosedGeneric;
        }

        public bool IsOpenGeneric {get;}

        public bool IsClosedGeneric {get;}
        
    }



}