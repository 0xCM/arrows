//-----------------------------------------------------------------------------
// CPrimalyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using System.Runtime.Serialization;
    using System.Runtime.CompilerServices;

    public static class Errors
    {
        public static Exception NotEqual(object lhs, object rhs, string file, int? line)
            => new Exception($"{file} line {line}: {lhs} != {rhs}") ;

        public static Exception NotLessThan(object lhs, object rhs, string file, int? line)
            => new Exception($"{file} line {line}: !({lhs} < {rhs})") ;

        public static Exception ItemsNotEqual(int index, object lhs, object rhs, string file, int? line)
            => new Exception($"{file} line {line}: lhs[{index}] = {lhs} != rhs[{index}] = {rhs}");

        public static Exception NotNonzero(string file, int? line)
            => new Exception($"{file} line {line}: The input value is required to be nonzero, and yet, it is");
        
        public static Exception NotTrue(string msg, string file, int? line)
            => new Exception($"{file} line {line}: {msg ?? "The source value is required to be true and yet it is false"}");

        public static Exception NotFalse(string msg, string file, int? line)
            => new Exception($"{file} line {line}: {msg ?? "The source value is required to be false and yet it is true"}");

        public static Exception CountMismatch(int lhs, int rhs, string file, int? line)
            => throw new Exception($"{file} line {line}: Count mismatch, {lhs} != {rhs}");

        public static Exception LengthMismatch(int lhs, int rhs, string file, int? line)
            => throw new Exception($"{file} line {line}: Length mismatch, {lhs} != {rhs}");

        public static Exception KindUnsupported(PrimalKind kind, string file, int? line)
            => throw new Exception($"{file} line {line}: Length mismatch, Primal kind {kind} not supported");

    }

    public static class ErrorMessage
    {
        public static string NotSupported(PrimalKind kind)
            => $"Primal kind {kind} not supported";
        public static string NotSupported(PrimalKind src, PrimalKind dst)
            => $"Operation {src} => {dst} not supported";

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
