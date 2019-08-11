//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
    
    
    using static zfunc;


    public readonly struct VarExpr<T>
        where T : struct
    {
        public VarExpr(string Name = null, T? value = null)
        {
            this.Name = Name ?? "anon";
            this.Value = value;
        }
        
        public string Name {get;}


        public T? Value {get;}

        public VarValueExpr<T> Assign(T? value = null)
            => new VarValueExpr<T>(Name, value ?? this.Value.Require());

    }

    public readonly struct VarValueExpr<T>
        where T : struct
    {

        public VarValueExpr(string Name, T value)
        {
            this.Name = Name;
            this.Value = value;
        }

        public string Name {get;}


        public T Value {get;}

    }

}