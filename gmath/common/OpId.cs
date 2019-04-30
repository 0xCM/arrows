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
    using System.IO;



    public readonly struct OpId 
    {
        public static OpId Define(OpKind Kind, PrimalKind Primitive)
            => new OpId(Kind, Primitive);

        public static OpId Define<T>(OpKind Kind)
            where T : struct, IEquatable<T>
            => new OpId(Kind, PrimalKinds.kind<T>());

        public OpId(OpKind Kind, PrimalKind Primitive)
        {
            this.Kind = Kind;
            this.Primitive = Primitive;
        }
        
        public readonly OpKind Kind;

        public readonly PrimalKind Primitive;

        
        public override string ToString() 
            => $"{Kind}/{Primitive}".ToLower();
    }



}