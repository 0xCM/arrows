//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zcore;

    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class FacetAttribute : Attribute
    {
        public FacetAttribute(string Name, object Value)
        {
            this.Name = Name;
            this.Value = Value;
        }
        public string Name {get;}

        public object Value {get;}

    }

}