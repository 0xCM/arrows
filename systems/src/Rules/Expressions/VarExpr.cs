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
        
    using static zfunc;

    /// <summary>
    /// Defines a variable expression
    /// </summary>
    public readonly struct VarExpr<T> : IRuleExpr<T>
        where T : struct
    {
        [MethodImpl(Inline)]
        public VarExpr(string Name = null, T? value = null)
        {
            this.Name = Name ?? "anon";
            this.Value = value;
        }
        
        /// <summary>
        /// The variable's name
        /// </summary>
        public string Name {get;}

        /// <summary>
        /// The variable's default/initial value, if any
        /// </summary>
        public T? Value {get;}

        T IRuleExpr<T>.Value 
            => Value ?? default;

        /// <summary>
        /// Assigns the variables value
        /// </summary>
        /// <param name="value">The variable value</param>
        [MethodImpl(Inline)]
        public VarValueExpr<T> Assign(T? value = null)
            => new VarValueExpr<T>(this, value ?? this.Value.Require());

        [MethodImpl(Inline)]
        static string Format(VarExpr<T> src)
            => src.Value.Map(v => $"{src.Name} := {v}", () => src.Name);
        
        [MethodImpl(Inline)]
        public string Format()
            => Format(this);
        
        public override string ToString()
            => Format();
        
    }
}