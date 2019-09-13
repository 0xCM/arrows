//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    using static MathSym;    

    /// <summary>
    /// Represents an arrow that has a common source/target type
    /// </summary>
    public readonly struct Arrow<T> 
    {
        static readonly string DefaultSeparator = "->";
        
        [MethodImpl(Inline)]
        public Arrow(T Source, T Target)
        {
            this.Source = Source;
            this.Target = Target;
        }

        public readonly T Source;

        public readonly T Target;

        /// <summary>
        /// Renders an arrow in the canonical form "Source -> Target"
        /// </summary>
        /// <param name="arrow">If specified, the arrow symbol that will be used; if unspecified, 
        /// the concatentation of the asci characters '-' and '>' will be used </param>
        public string Format(string arrow = null)
            => $"{Source} {arrow ?? DefaultSeparator.ToString()} {Target}";

        public override string ToString()
            => Format();


    }    

    /// <summary>
    /// Represents an arrow that has a  source and target types that may differ
    /// </summary>
    public readonly struct Arrow<S,T> 
    {
        static readonly string DefaultSeparator = "->";
       
        [MethodImpl(Inline)]
        public Arrow(S Source, T Target)
        {
            this.Source = Source;
            this.Target = Target;
        }

        public readonly S Source;

        public readonly T Target;

        /// <summary>
        /// Renders an arrow in the canonical form "Source -> Target"
        /// </summary>
        /// <param name="arrow">If specified, the arrow symbol that will be used; if unspecified, 
        /// the concatentation of the asci characters '-' and '>' will be used </param>
        public string Format(string arrow = null)
            => $"{Source} {arrow ?? DefaultSeparator.ToString()} {Target}";

        public override string ToString()
            => Format();
    }
}