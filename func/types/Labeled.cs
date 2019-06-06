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
    

    /// <summary>
    /// Labels anything
    /// </summary>
    public class Labeled<T> 
    {
        public static implicit operator string(Labeled<T> src)
            => src.ToString();

        public Labeled(T Subject, string Label, Func<T,string> Formatter = null)
        {
            this.Subject = Subject;
            this.Label = Label;
            this.Formatter = Formatter;
        }

        public T Subject {get;}            

        public string Label {get;}

        public Option<Func<T,string>> Formatter {get;}

        
        public override string ToString()
            => $"{Label}: {Formatter.MapValueOrElse(f => f(Subject), () => Subject.ToString())}";

    }

    public static class Labels
    {
        public static Labeled<T> Label<T>(T subject, string label, Func<T,string> formatter = null)
            => new Labeled<T>(subject, label, formatter);

    }
}