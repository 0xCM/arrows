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
    /// Represents a method (value, not type) parameter 
    /// </summary>
    public class ValueParamRep : ClrItemRep
    {        
        public ValueParamRep(TypeRep Type, string ParamName, int Position, ClrRepTag? Tag = null)
            : base(ParamName)            
        {
            this.Type = Type;
            this.Position = Position;
        }

        public TypeRep Type {get;}

        public int Position {get;}

        public override string Format()
            => $"{Type} {Name}";

        public override string ToString()
            => Format();

    }


    public class ValueParamReps : ClrItemReps<ValueParamReps, ValueParamRep>
    {
        public static implicit operator ValueParamReps(ValueParamRep[] src)
            => new ValueParamReps(src);

        readonly ValueParamRep[] reps;

        public ValueParamReps(IEnumerable<ValueParamRep> refs)
            => this.reps = refs.ToArray();

        protected override IReadOnlyList<ValueParamRep> Items
            => reps;


        public string Format(bool fence)
        {
            var content = reps.Select(mp => mp.Format()).Concat(", ");
            return fence ? paren(content) : content;
        }
    }


}