//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Serialization;
        
    using static mfunc;
    using static zfunc;


    /// <summary>
    /// Raised when a claim has failed
    /// </summary>
    [Serializable]
    public class ClaimException : AppException
    {
        public static ClaimException Define(ClaimOpKind op, AppMsg msg)
            => new ClaimException(op, msg);

        public static ClaimException Define(ClaimOpKind op, string msg, string caller, string file, int? line)
            => new ClaimException(op, msg, caller, file, line);

        public ClaimException() { }
     
        ClaimException(ClaimOpKind kind, AppMsg msg) 
            : base(msg.WithPrependedContent("fail(").WithAppendedContent(")"))
            { 
                this.OpKind = kind;
            }

        ClaimException(ClaimOpKind kind, string msg, string caller, string file, int? line) 
            : base($"fail({msg})", caller, file, line) 
            { 
                this.OpKind = kind;
            }
     
        protected ClaimException(SerializationInfo info, StreamingContext context) 
            : base(info, context) { }
    
        public ClaimOpKind OpKind {get;}         
    }

}