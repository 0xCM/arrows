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
        OpKind OpKind {get;}

        NumericKind NumKind {get;}

        PrimalKind OperandType {get;}

        ByteSize OperandSize {get;}

        bool Generic {get;}

        bool Intrinsic {get;}

        OpFusion Fusion {get;}

        OpMode Mode {get;}

        bool Role {get;}

    }

    public interface IOpId<T> : IOpId
        where T : struct
    {

    }


}