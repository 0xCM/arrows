//-----------------------------------------------------------------------------
// CPrimalyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using System.Runtime.Serialization;
    using System.Runtime.CompilerServices;

    


    public static class ErrorMessage
    {
        public static string NotSupported(PrimalKind kind)
            => $"Primal kind {kind} not supported";
        public static string NotSupported(PrimalKind src, PrimalKind dst)
            => $"Operation {src} => {dst} not supported";

    }

    public static class errors
    {
     
    }

    /// <summary>
    /// Raised when an implementation is expected for a given primitive and it
    /// does not exist
    /// </summary>
    [Serializable]
    public class PrimalUnsupportedException : Exception
    {
        public PrimalUnsupportedException() { }
     
        public PrimalUnsupportedException(PrimalKind kind) 
            : base(ErrorMessage.NotSupported(kind)) 
            { }

        public PrimalUnsupportedException(PrimalKind src, PrimalKind dst) 
            : base(ErrorMessage.NotSupported(src,dst)) 
            { }

        public PrimalUnsupportedException(PrimalKind kind, System.Exception inner) 
            : base(ErrorMessage.NotSupported(kind), inner) { }

        public PrimalUnsupportedException(PrimalKind src, PrimalKind dst, System.Exception inner) 
            : base(ErrorMessage.NotSupported(src,dst), inner) { }
     
        protected PrimalUnsupportedException(SerializationInfo info, StreamingContext context) 
            : base(info, context) { }
    }

}
