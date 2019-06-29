//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    public class Variable
    {
        public Variable(string Name)
            => this.Name = Name;
        public string Name {get;}

        public override string ToString()
            => $"$({Name})";
    }

    public abstract class Property
    {        
        public static Variable buildvar([CallerMemberName]string name = null)
            => new Variable(name);

        public static Property<T> prop<T>(T value, [CallerMemberName]string name = null)
            => new Property<T>(name,value);

        public static Property<T> prop<T>(string name, T value)
            => new Property<T>(name,value);

        public static Property<string> prop(Variable var)
            => prop(var.ToString());

        public static Property<string> prop(params int[] numbers)
            => prop(string.Join(";", numbers));

        public static Property replicate(Property p, [CallerMemberName]string name = null)            
            => p.WithName(name);

        public static object value(Property src)
            => src.GetValue();

        public static string name(Property src)
            => src.Name;

        protected Property(string name)
        {
            this.Name = name;
        }

        public string Name {get;} 

        protected abstract Property WithName(string name);
        public abstract object GetValue();

        public override string ToString()
            => GetValue()?.ToString() ?? string.Empty;
    }    

    public class Property<T> : Property
    {

        public static implicit operator Property<T>((string name, T value) src)
            => new Property<T>(src.name, src.value);

        public static implicit operator (string name, T value)(Property<T> src)
            => (src.Name, src.Value);

        public Property(string Name, T Value)
            : base(Name)
        {
            this.Value = Value;
        }

        public T Value {get;} 

        protected override Property WithName(string name)
            => Rename(Name);

        public Property<T> Rename(string Name)
            => new Property<T>(Name, Value);
        public override object GetValue()
            => Value;
    }

}