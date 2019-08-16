//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Threading;
    using System.Reflection.Emit;
    using System.Linq;

    using static zfunc;

    public abstract class Record<T> : IRecord<T>
        where T : Record<T>, new()
    {
        public static readonly T Empty = new T();

        public abstract string DelimitedText(char delimiter);

        protected IRecord<T> This
            => this;

        IReadOnlyList<string> IRecord.GetHeaders()
            => This.Headers;    
    
        protected static IReadOnlyList<string> GetHeaders()
            => Empty.This.Headers;
        
        
    }




}