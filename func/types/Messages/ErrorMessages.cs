//-----------------------------------------------------------------------------
// CPrimalyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using System.Runtime.Serialization;
    using System.Runtime.CompilerServices;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    using static zfunc;

    public static class ErrorMessages
    {
        public static AppMsg FeatureUnsupported(string feature, string caller, string file, int? line)
                => AppMsg.Define($"Unsupported: {feature}", SeverityLevel.Error, caller, file, line);
        public static AppMsg KindUnsupported<T>(T kind, string caller, string file, int? line)
            where T : Enum
                => AppMsg.Define($"{typename<T>()}.{kind} not supported", SeverityLevel.Error, caller, file, line);
        public static AppMsg TypeUnsupported(Type t, string caller, string file, int? line)
                => AppMsg.Define($"Type {t.Name} is not supported in the current context", SeverityLevel.Error, caller, file, line);
        public static AppMsg KindOpUnsupported<S,T>(S src, T dst, string caller, string file, int? line)
            where S : Enum
            where T : Enum
                => AppMsg.Define($"Operation {src} => {dst} not supported", SeverityLevel.Error, caller, file, line);

        public static AppMsg NotEqual(object lhs, object rhs, string caller, string file, int? line)
            => AppMsg.Define($"{lhs} != {rhs}", SeverityLevel.Error, caller, file, line) ;

        public static AppMsg Equal(object lhs, object rhs, string caller, string file, int? line)
            => AppMsg.Define($"{lhs} == {rhs}", SeverityLevel.Error, caller, file, line) ;

        public static AppMsg NotLessThan(object lhs, object rhs, string caller, string file, int? line)
            => AppMsg.Define($"!({lhs} < {rhs})", SeverityLevel.Error, caller, file, line) ;

        public static AppMsg NotGreaterThan(object lhs, object rhs, string caller, string file, int? line)
            => AppMsg.Define($"!({lhs} > {rhs})", SeverityLevel.Error, caller, file, line) ;

        public static AppMsg NotGreaterThanOrEqual(object lhs, object rhs, string caller, string file, int? line)
            => AppMsg.Define($"!({lhs} >= {rhs})", SeverityLevel.Error, caller, file, line) ;

        public static AppMsg NotLessThanOrEqual(object lhs, object rhs, string caller, string file, int? line)
            => AppMsg.Define($"!({lhs} <= {rhs})", SeverityLevel.Error, caller, file, line) ;

        public static AppMsg ItemsNotEqual(int index, object lhs, object rhs, string caller, string file, int? line)
            => AppMsg.Define($"lhs[{index}] = {lhs} != rhs[{index}] = {rhs}", SeverityLevel.Error, caller, file, line);
        public static AppMsg NotNonzero(string caller, string file, int? line)
            => AppMsg.Define($"The input value is required to be nonzero, and yet, it is",  SeverityLevel.Error, caller, file, line);        
        
        public static AppMsg NotTrue(string msg, string caller, string file, int? line)
            => AppMsg.Define($"{msg ?? "The source value is required to be true and yet it is false"}", SeverityLevel.Error, caller, file, line);

        public static AppMsg NotFalse(string msg, string caller, string file, int? line)
            => AppMsg.Define($"{msg ?? "The source value is required to be false and yet it is true"}", SeverityLevel.Error, caller, file, line);
        public static AppMsg CountMismatch(int lhs, int rhs, string caller, string file, int? line)
            => AppMsg.Define($"Count mismatch, {lhs} != {rhs}", SeverityLevel.Error, caller, file, line);
        public static AppMsg EmptySourceSpan(string caller, string file, int? line)
            => AppMsg.Define($"The source span was empty", SeverityLevel.Error, caller, file, line);

        public static AppMsg LengthMismatch(int lhs, int rhs, string caller, string file, int? line)
            => AppMsg.Define($"Length mismatch, {lhs} != {rhs}", SeverityLevel.Error, caller, file, line);

        public static AppMsg IndexOutOfRange(int index, int min, int max, string caller, string file, int? line)
            => AppMsg.Define($"The index {index} is not between {min} and {max}", SeverityLevel.Error, caller, file, line);

        public static AppMsg TooManyBytes(ByteSize requested, ByteSize available, string caller, string file, int? line)
            => AppMsg.Define($"The requested number of bytes, {requested} exceeds the maximum available bytes, {available}", SeverityLevel.Error, caller, file, line);

        public static AppMsg Unanticipated(Exception e, [CallerMemberName] string caller = null, [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            => AppMsg.Define(e?.ToString() ??"Heh?", SeverityLevel.Error, caller, file, line);
    
        public static AppMsg FileDoesNotExist(FilePath path, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)    
            => AppMsg.Define($"The file {path} does not exist", SeverityLevel.Error, caller, file, line);
    }
}