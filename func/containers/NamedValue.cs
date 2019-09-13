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
    

    public static class NamedValue
    {
        public static NamedValue<V> Define<V>(string name, V value)
            => (name,value);
    }
    
    /// <summary>
    /// Confers a name to a value
    /// </summary>
    public readonly struct NamedValue<V> 
    {
        public static implicit operator NamedValue<V>((string name, V value) src)
            => new NamedValue<V>(src);

        public static implicit operator (string name, V value)(NamedValue<V> src)
            => src.Tuple;

        public NamedValue(string name, V value)
        {
            this.Name = name;
            this.Value = value;
        }

        public NamedValue((string name, V value) nv)
        {
            this.Name = nv.name;
            this.Value = nv.value;
        }        

        /// <summary>
        /// The name of the value
        /// </summary>
        public readonly string Name;

        /// <summary>
        /// The named value
        /// </summary>
        public readonly V Value;

        public (string name, V value) Tuple
            => this;

        public override string ToString()
            => $"{Name} = {Value}";
    }
}