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
    


    public readonly struct OpType<T>
        where T : struct
    {

        public OpType(OpKind op)
        {
            Primitive = PrimalKinds.kind<T>();
            this.Op = op;
        }

        public readonly OpKind Op;        

        public readonly PrimalKind Primitive;


    }   

    public readonly struct OpType
    {
        public static OpType Define(OpKind op, PrimalKind prim)
            => new OpType(op, prim);

        public static OpType<T> Define<T>(OpKind op)
            where T : struct
            => new OpType<T>(op);

        public static IEnumerable<OpType> Define(IEnumerable<OpKind> ops, IEnumerable<PrimalKind> prims)
            => from o in ops
            from p in prims
            select Define(o,p);



        public OpType(OpKind op, PrimalKind prim)
        {
            this.Op = op;
            this.Primitive = prim;
        }
        
        public readonly OpKind Op;        

        public readonly PrimalKind Primitive;        
    }
}