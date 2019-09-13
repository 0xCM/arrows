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

    public interface IOpId
    {
        NumericSystem NumSystem {get;}
        
        OpKind OpKind {get;}

        NumericKind NumKind {get;}

        PrimalKind OperandType {get;}

        Genericity Generic {get;}
        
        bool Intrinsic {get;}

        OpFusion Fusion {get;}

        string OpTitle {get;}


    }

    public interface IOpId<T> : IOpId
        where T : struct
    {

    }


}