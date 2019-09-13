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
    /// Represents a type parameter in a generic artifact definition
    /// </summary>
    public class TypeParamRep : ClrItemRep
    {
        public TypeParamRep(string Name, int Position, bool IsOpen = true, ClrRepTag? Tag = null)
            : base(Name, 0, Tag)
        {
            this.Position = Position;
            this.IsOpen = IsOpen;
            this.IsClosed = !IsOpen;
        }

        public int Position {get;}

        public bool IsOpen {get;}

        public bool IsClosed {get;}

        public string Format(bool fence)
            => fence ? angled(Name) : Name;

        public override string Format()
            => Format(false);
    }

    public class TypeParamReps : ClrItemReps<TypeParamReps, TypeParamRep>
    {
        readonly TypeParamRep[] reps;

        public static implicit operator TypeParamReps(TypeParamRep[] src)
            => new TypeParamReps(src);
        
        
        public TypeParamReps(TypeParamRep[] reps)
            => this.reps = reps;

        public TypeParamReps(IEnumerable<TypeParamRep> reps)
            => this.reps = reps.ToArray();

        protected override IReadOnlyList<TypeParamRep> Items
            => reps;

        public string Format(bool fence)
        {            
            var content = reps.Select(x => x.Format(false)).Concat(", ");
            return fence ? angled(content) : content;
        }

        public int Count
            => reps.Length;

        public override string Format()
            => Format(true);
    }


}