//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using static zfunc;

    public interface IRecord
    {
        string Delimited(char delimiter = ',', bool digitcommas = false);

        IReadOnlyList<string> GetHeaders();
        
    }
    public interface IRecord<T> : IRecord
    {
        IReadOnlyList<string> Headers
            => type<T>().DeclaredProperties().Select(p => p.Name).ToReadOnlyList();
    }

    public abstract class Record<T> : IRecord<T>
        where T : Record<T>, new()
    {
        public static readonly T Empty = new T();

        public abstract string Delimited(char delimiter = ',', bool digitcommas = false);

        protected IRecord<T> This
            => this;

        IReadOnlyList<string> IRecord.GetHeaders()
            => This.Headers;    
    
        protected static IReadOnlyList<string> GetHeaders()
            => Empty.This.Headers;
    }


    public static class Record
    {
        public static IReadOnlyList<string> GetHeaders<T>()
            => type<T>().DeclaredProperties().Select(p => p.Name).ToReadOnlyList();

        public static IEnumerable<string> Delimited<T>(this IEnumerable<IRecord<T>> records, char delimiter  = ',')
            => records.Select(r => r.Delimited(delimiter));
    }

}