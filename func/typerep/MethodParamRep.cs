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

    public enum ParameterDirection
    {
        Default,

        In = 1,

        Out = 2
    }

    public static class ClrRepX
    {
        public static ParameterDirection Direction(this ParameterInfo src)
            => src.IsIn ? ParameterDirection.In : src.IsOut ? ParameterDirection.Out : ParameterDirection.Default;

    }

    /// <summary>
    /// Represents a method (value, not type) parameter 
    /// </summary>
    public class MethodParamRep : ClrItemRep
    {        
        public MethodParamRep(TypeRep Type, ParameterDirection Direction, string ParamName, int Position, ClrRepTag? Tag = null)
            : base(ParamName)            
        {
            this.Type = Type;
            this.Direction = Direction;
            this.Position = Position;
        }

        public TypeRep Type {get;}

        public ParameterDirection Direction {get;}
        
        public int Position {get;}

        public override string Format()
            => $"{Type} {Name}";

        public override string ToString()
            => Format();

    }


    public class MethodParamReps : ClrItemReps<MethodParamReps, MethodParamRep>
    {
        public static implicit operator MethodParamReps(MethodParamRep[] src)
            => new MethodParamReps(src);

        readonly MethodParamRep[] reps;

        public MethodParamReps(IEnumerable<MethodParamRep> refs)
            => this.reps = refs.ToArray();

        protected override IReadOnlyList<MethodParamRep> Items
            => reps;

        public string Format(bool fence)
        {
            var content = reps.Select(mp => mp.Format()).Concat(", ");
            return fence ? paren(content) : content;
        }
    }


}