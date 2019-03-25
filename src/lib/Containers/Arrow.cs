//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    using Expose;
    
    using static corefunc;

    /// <summary>
    /// Represents a directed path from a source space to a target space
    /// with no particular basepoint selection
    /// </summary>
    public readonly struct Arrow<A,B> : Traits.Arrow<A,B>
    {
        public static implicit operator Arrow<A,B>(Func<A,B> carrier)
            => new Arrow<A,B>(carrier);

        Func<A,B> carrier {get;}    

        public Label label {get;}
            
        public bool directed => true;

        public Arrow(Func<A,B> carrier, Label? label = null)
        {
            this.carrier = carrier;
            this.label = label ?? Label.Empty;
        }

        /// <summary>
        /// Applies the arrow to a supplied value
        /// </summary>
        /// <param name="src">The source point upon which the arrow will be applied</param>
        /// <returns></returns>
        public B apply(A src) => carrier(src);
        

        public override string ToString()
            => concat(label.empty() ? string.Empty : label.name, AsciSym.Colon) 
             + concat(typename<A>(),Arrows.longright, typename<B>());
    }

   /// <summary>
    /// Represents a directed path from a specific basepoint in one space to a
    /// specific basepoint in another space
    /// </summary>
    public readonly struct PointedArrow<X,Y> : Traits.PointedArrow<X,Y>
    {
        /// <summary>
        /// The source-valued basepoint
        /// </summary>
        public X source {get;}

        /// <summary>
        /// The target-valued basepoint
        /// </summary>
        public Y target {get;}

        public Label label {get;}

        public PointedArrow(X source, Y target, Label? label = null)
        {
            this.source = source;
            this.target = target;
            this.label = label ?? Label.Empty;
        }

        /// <summary>
        /// Interchages source and target to create a new arrow
        /// whose domain is the current codomain and conversely
        /// </summary>
        public PointedArrow<Y,X> reverse()
            => new PointedArrow<Y,X>(target, source, label);
    }
}