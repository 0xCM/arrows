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
    using System.Reflection;

    using static zfunc;

    /// <summary>
    /// Store for arbitrary data attached to a clr representative
    /// </summary>
    public readonly struct ClrRepTag
    {
        public ClrRepTag(object Value, int Classifier = 0)
        {
            this.Value = Value;
            this.Classifier = Classifier;
        }
        
        public object Value {get;}

        public int Classifier {get;}

        public string Format(bool withKind = false)
            => Value.ToString() + (withKind ? paren(Classifier) : string.Empty);
    
        public override string ToString()
            => Format();
    }


}