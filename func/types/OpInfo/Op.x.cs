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

    using static zfunc;

    public static class OpX
    {
        
        public static OpArity Arity(this OpKind op)
        {
            var attributions = (from a in typeof(OpKind).DeclaredFieldAttributions<ArityAttribute>() 
                                 select (a.Key.Name, a.Value.Arity)).ToDictionary();

            if(attributions.ContainsKey(op.ToString()))
                return attributions[op.ToString()];
            else
            return OpArity.None;
        }
                
        [MethodImpl(Inline)]
        public static bool IsIntrinsic(this NumericKind kind)
            => (byte)kind >= (byte)NumericKind.Num128;

        [MethodImpl(Inline)]
        public static bool NonZeroRight(this OpKind op)
            => op == OpKind.Div || op == OpKind.Mod;

        [MethodImpl(Inline)]
        public static Genericity Flip(this Genericity src)
            => src == Genericity.Generic ? Genericity.Direct : Genericity.Generic;

        [MethodImpl(Inline)]
        public static bool IsGeneric(this Genericity src)
            => src == Genericity.Generic;

        [MethodImpl(Inline)]
        public static bool IsDirect(this Genericity src)
            => src == Genericity.Direct;

        public static OpType WithType(this OpKind src, PrimalKind prim)
            => OpType.Define(src,prim);    

        public static OpId OpId(this OpKind op, 
            NumericSystem system,
            PrimalKind prim, 
            NumericKind numKind = NumericKind.Native, 
            Genericity generic = Genericity.Direct, 
            OpFusion fusion = OpFusion.Atomic, 
            string title = null)
                => new OpId(system, op, prim, numKind, generic, fusion, title);

        public static OpId<T> OpId<T>(this OpKind op, 
            NumericSystem system,             
            NumericKind numKind = NumericKind.Native, 
            Genericity generic = Genericity.Direct, 
            OpFusion fusion = OpFusion.Atomic, 
            string title = null)
                where T : struct
                    => new OpId<T>(system, op, numKind, generic, fusion, title);        

    }

}

