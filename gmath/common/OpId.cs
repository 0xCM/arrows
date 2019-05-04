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
        public static OpId Define(OpKind Kind, PrimalKind Primitive, bool Generic = false, bool Intrinsic = false, bool Vectored = false, int? OperandSize = null)
            => new OpId(Kind, Primitive, Generic, Intrinsic,  Vectored);

        public static OpId Define<T>(OpKind Kind,  bool Generic = false, bool Intrinsic = false, bool Vectored = false)
            where T : struct, IEquatable<T>
            => new OpId(Kind, PrimalKinds.kind<T>(), Generic, Intrinsic, Vectored, Unsafe.SizeOf<T>());

        public static OpId operator ~(OpId src)
            => src.FlipGeneric();

        OpId(OpKind Kind, PrimalKind Primitive, bool Generic, bool Intrinsic, bool Vectored, int? OperandSize = null)
        {
            this.OpKind = Kind;
            this.Primitive = Primitive;
            this.Generic = Generic;
            this.Intrinsic = Intrinsic;
            this.Vectored = Vectored;
            this.OperandSize = Intrinsic ? 128 : OperandSize ?? 0;
        }
        
        public readonly OpKind OpKind;

        public readonly PrimalKind Primitive;

        public readonly bool Generic;

        public readonly bool Intrinsic;

        public readonly int OperandSize;

        public readonly bool Vectored;

        /// <summary>
        /// monomorphic (direct) vs parametric (generic)
        /// </summary>
        string Parametricity
            => Generic ? "generic" : "direct";

        string Prefix 
            => Intrinsic ?  (Generic ? "ginx" : "dinx") : (Generic ? "gmath" : "dmath");

        string OpInfo
            => Vectored ? $"{OpKind}/Vec{OperandSize}[{Primitive}]" 
              : Intrinsic ? $"Num{OperandSize}[{Primitive}]"            
              : $"{OpKind}/{Primitive}";

        public override string ToString() 
            => $"{Prefix}/{OpInfo}".ToLower();
        
        public OpId FlipGeneric()
            => new OpId(OpKind,Primitive, !Generic, Intrinsic, Vectored, OperandSize);
    
        public OpId ResizeOperand(int OperandSize)
            => new OpId(OpKind,Primitive, Generic, Intrinsic, Vectored, OperandSize);
    }



}