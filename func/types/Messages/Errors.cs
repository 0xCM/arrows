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

    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public static class Errors
    {
        public static AppException NotEqual(object lhs, object rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(ErrorMessages.NotEqual(lhs,rhs,caller,file,line));

        public static AppException Equal(object lhs, object rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(ErrorMessages.Equal(lhs,rhs,caller,file,line));

        public static AppException NotLessThan(object lhs, object rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(ErrorMessages.NotLessThan(lhs,rhs,caller,file,line));

        public static AppException ItemsNotEqual(int index, object lhs, object rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(ErrorMessages.ItemsNotEqual(index, lhs,rhs,caller,file,line));

        public static AppException NotNonzero([Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(ErrorMessages.NotNonzero(caller,file,line));
        
        public static AppException NotTrue(string msg, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(ErrorMessages.NotTrue(msg,caller,file,line));

        public static AppException NotFalse(string msg, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(ErrorMessages.NotFalse(msg,caller,file,line));

        public static AppException CountMismatch(int lhs, int rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(ErrorMessages.CountMismatch(lhs,rhs,caller,file,line));

        public static AppException LengthMismatch(int lhs, int rhs, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(ErrorMessages.LengthMismatch(lhs,rhs,caller,file,line));

        public static AppException EmptySourceSpan([Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(ErrorMessages.EmptySourceSpan(caller,file,line));

        public static AppException KindUnsupported<T>(T kind, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where T : Enum
                => AppException.Define(ErrorMessages.KindUnsupported(kind, caller, file, line));

        public static AppException TypeUnsupported(Type t, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
                => AppException.Define(ErrorMessages.TypeUnsupported(t, caller, file, line));

        public static AppException FeatureUnsupported(string feature, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
                => AppException.Define(ErrorMessages.FeatureUnsupported(feature, caller, file, line));
  
        public static AppException FileDoesNotExist(FilePath path, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => AppException.Define(ErrorMessages.FileDoesNotExist(path, caller, file, line));

        public static AppException KindOpUnsupported<S,T>(S src, T dst, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            where S : Enum
            where T : Enum
                => AppException.Define(ErrorMessages.KindOpUnsupported(src,dst, caller, file, line));

        public static IndexOutOfRangeException TooManyBytes(ByteSize requested, ByteSize available, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => new IndexOutOfRangeException(ErrorMessages.TooManyBytes(requested, available, caller, file, line).ToString());

        public static IndexOutOfRangeException OutOfRange(int index, int min, int max, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => new IndexOutOfRangeException(ErrorMessages.IndexOutOfRange(index,min,max, caller, file, line).ToString());

        public static IndexOutOfRangeException OutOfRange<T>(T value, T min, T max, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
                    => new IndexOutOfRangeException($"Value {value} is not between {min} and {max}: line {line}, member {caller} in file {file}");
        public static T ThrowOutOfRange<T>(int index, int min, int max, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => throw OutOfRange(index, min, max, caller, file, line);

    }
}
