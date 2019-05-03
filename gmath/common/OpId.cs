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
        public static OpId Define(OpKind Kind, PrimalKind Primitive, bool Generic = false, bool Intrinsic = false)
            => new OpId(Kind, Primitive, Generic, Intrinsic);

        public static OpId Define<T>(OpKind Kind,  bool Generic = false, bool Intrinsic = false)
            where T : struct, IEquatable<T>
            => new OpId(Kind, PrimalKinds.kind<T>(), Generic, Intrinsic);

        public static OpId operator ~(OpId src)
            => src.FlipGeneric();

        OpId(OpKind Kind, PrimalKind Primitive, bool Parametric, bool Intrinsic)
        {
            this.Kind = Kind;
            this.Primitive = Primitive;
            this.Generic = Parametric;
            this.Intrinsic = Intrinsic;
        }
        
        public readonly OpKind Kind;

        public readonly PrimalKind Primitive;

        public readonly bool Generic;

        public readonly bool Intrinsic;

        /// <summary>
        /// monomorphic (direct) vs parametric (generic)
        /// </summary>
        string Parametricity
            => Generic ? "generic" : "direct";

        string InX 
            => Intrinsic ?  (Generic ? "ginx" : "dinx") : (Generic ? "gmath" : "dmath");

        public override string ToString() 
            => $"{InX}/{Kind}/{Primitive}/{Parametricity}".ToLower();
        
        public OpId FlipGeneric()
            => new OpId(Kind,Primitive, !Generic, Intrinsic);
    }



}