//-----------------------------------------------------------------------------
// CPrimalyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using System.Runtime.Serialization;
    using System.Runtime.CompilerServices;

    using static zfunc;

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
            => new Exception($"{file} line {line}: Count mismatch, {lhs} != {rhs}");

        public static Exception LengthMismatch(int lhs, int rhs, string file, int? line)
            => new Exception($"{file} line {line}: Length mismatch, {lhs} != {rhs}");

        public static IndexOutOfRangeException OutOfRange(int index, int min, int max)
            => new IndexOutOfRangeException($"The supplied index {index} must be larger or equal to {min} and  less than {max}");

        public static KindUnsupportedException KindUnsupported<T>(T kind, string file, int? line)
            where T : Enum
                => new KindUnsupportedException(kind);

        public static KindUnsupportedException KindOpUnsupported<S,T>(S src, T dst, string file, int? line)
            where S : Enum
            where T : Enum
                => new KindUnsupportedException(src,dst);
    }

    public static class ErrorMessage
    {
        public static string KindUnsupported<T>(T kind)
            where T : Enum
                => $"{kind} for {typename<T>()} not supported";

        public static string KindOpUnsupported<S,T>(S src, T dst)
            where S : Enum
            where T : Enum
            => $"Operation {src} => {dst} not supported";


    }

    /// <summary>
    /// Raised when an implementation is expected for a given primitive and it
    /// does not exist
    /// </summary>
    [Serializable]
    public class KindUnsupportedException : Exception
    {
        public KindUnsupportedException() { }
     
        public KindUnsupportedException(Enum kind) 
            : base(ErrorMessage.KindUnsupported(kind)) 
            { }

        public KindUnsupportedException(Enum src, Enum dst) 
            : base(ErrorMessage.KindOpUnsupported(src,dst)) 
            { }

        public KindUnsupportedException(Enum kind, System.Exception inner) 
            : base(ErrorMessage.KindUnsupported(kind), inner) { }

        public KindUnsupportedException(Enum src, Enum dst, System.Exception inner) 
            : base(ErrorMessage.KindOpUnsupported(src,dst), inner) { }
     
        protected KindUnsupportedException(SerializationInfo info, StreamingContext context) 
            : base(info, context) { }
    }

}
