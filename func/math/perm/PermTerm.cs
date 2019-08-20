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
    using System.Text;

    using static zfunc;    

    /// <summary>
    /// Describes a term of a permutaiton p, i.e. the point of evaluation i and
    /// its image p(i)
    /// </summary>
    public readonly struct PermTerm
    {
        public static implicit operator PermTerm((int src, int dst) x)
            => new PermTerm(x.src, x.dst);

        public static implicit operator (int src, int dst)(PermTerm x)
            => (x.Source, x.Target);

        public PermTerm(int src, int dst)
        {
            this.Source = src;
            this.Target = dst;
        }
        
        /// <summary>
        /// The point at which the permuation is evaluated
        /// </summary>
        public readonly int Source;

        /// <summary>
        /// The result of evaluating the permuation over the source
        /// </summary>                
        public readonly int Target;


        public bool IsDegenerate
            => Source == Target;

        public void Deconstruct(out int src, out int dst)
        {
            src = Source;
            dst = Target;
        }

        public override string ToString() 
            => $"{Source} -> {Target}";
    }

}