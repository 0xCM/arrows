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

    public interface IRecord
    {
        string Delimited(char delimiter = ',');
        IReadOnlyList<string> Headers();
    }
    public interface IRecord<T> : IRecord
    {

    }

    public static class Record
    {
        public static IEnumerable<string> Delimited<T>(this IEnumerable<IRecord<T>> records, char delimiter  = ',')
            => records.Select(r => r.Delimited(delimiter));
    }

}