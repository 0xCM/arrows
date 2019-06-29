//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class PropertyGroup
    {

        public static PropertyGroup Define(string Name, params Property[] props)
            => new PropertyGroup(Name,props);

        List<Property> proplist;

        public PropertyGroup(string name, params Property[] props)
        {
            this.Name = name;
            this.proplist = new List<Property>();
            Add(props);
        }

        public string Name {get;}

        public IReadOnlyList<Property> Properties
            => proplist;        

        public PropertyGroup Add(params Property[] props)
        {
            proplist.AddRange(props);
            return this;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"<PropertyGroup name='{Name}'>");
            foreach(var prop in proplist)
                sb.AppendLine($"  <{prop.Name}>{prop}</{prop.Name}>");
            sb.AppendLine($"<PropertyGroup/>");
            return sb.ToString();
        }
    }

}