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
        public static AppException NotEqual(object lhs, object rhs, string caller, string file, int? line)
            => AppException.Define(ErrorMessages.NotEqual(lhs,rhs,caller,file,line));

        public static AppException NotLessThan(object lhs, object rhs, string caller, string file, int? line)
            => AppException.Define(ErrorMessages.NotLessThan(lhs,rhs,caller,file,line));

        public static AppException ItemsNotEqual(int index, object lhs, object rhs, string caller, string file, int? line)
            => AppException.Define(ErrorMessages.ItemsNotEqual(index, lhs,rhs,caller,file,line));

        public static AppException NotNonzero(string caller, string file, int? line)
            => AppException.Define(ErrorMessages.NotNonzero(caller,file,line));
        
        public static AppException NotTrue(string msg, string caller, string file, int? line)
            => AppException.Define(ErrorMessages.NotTrue(msg,caller,file,line));

        public static AppException NotFalse(string msg, string caller, string file, int? line)
            => AppException.Define(ErrorMessages.NotFalse(msg,caller,file,line));

        public static AppException CountMismatch(int lhs, int rhs, string caller, string file, int? line)
            => AppException.Define(ErrorMessages.CountMismatch(lhs,rhs,caller,file,line));

        public static AppException LengthMismatch(int lhs, int rhs, string caller, string file, int? line)
            => AppException.Define(ErrorMessages.LengthMismatch(lhs,rhs,caller,file,line));

        public static IndexOutOfRangeException OutOfRange(int index, int min, int max, string caller, string file, int? line)
            => new IndexOutOfRangeException(ErrorMessages.IndexOutOfRange(index,min,max, caller, file, line).ToString());

        public static AppException KindUnsupported<T>(T kind, string caller, string file, int? line)
            where T : Enum
                => AppException.Define(ErrorMessages.KindUnsupported(kind, caller, file, line));

        public static AppException TypeUnsupported(Type t, string caller, string file, int? line)
                => AppException.Define(ErrorMessages.TypeUnsupported(t, caller, file, line));

        public static AppException FeatureUnsupported(string feature, string caller, string file, int? line)
                => AppException.Define(ErrorMessages.FeatureUnsupported(feature, caller, file, line));

        public static AppException KindOpUnsupported<S,T>(S src, T dst, string caller, string file, int? line)
            where S : Enum
            where T : Enum
                => AppException.Define(ErrorMessages.KindOpUnsupported(src,dst, caller, file, line));
    }
}
