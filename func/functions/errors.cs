//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Diagnostics;

using Z0;

partial class zfunc
{
    /// <summary>
    /// Defines an exception indicating that there is no operation 
    /// associated with a specified enumeration literal 
    /// </summary>
    /// <param name="kind">The enum type</param>
    /// <param name="file">The source file where error condition is discerned</param>
    /// <param name="line">The source file line number where error condition is discerned</param>
    /// <typeparam name="T">The enumeration type</typeparam>
    public static AppException unsupported<T>(T kind, [CallerFilePath] string caller = null,  
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where T : Enum
                => Errors.KindUnsupported(kind, caller, file, line);
    
    public static AppException unsupported<S,T>(S src, T dst, [CallerFilePath] string caller = null, 
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where T : Enum
            where S : Enum
                => Errors.KindOpUnsupported(src, dst, caller, file, line);
    public static NotSupportedException unsupported(string feature, [CallerFilePath] string caller = null,  
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            => new NotSupportedException(ErrorMessages.FeatureUnsupported(feature, caller, file, line).ToString());
    public static IndexOutOfRangeException outOfRange(int index, int min, int max, [CallerFilePath] string caller = null, 
        [CallerFilePath] string file = null,  [CallerLineNumber] int? line = null)
            => Errors.OutOfRange(index,min,max, caller, file, line);

    public static ArgumentException badarg(string name, object value, [CallerFilePath] string caller = null, 
        [CallerFilePath] string file = null,  [CallerLineNumber] int? line = null)
            => new ArgumentException($"An invalid argument {name} = {value}  was specified");


}