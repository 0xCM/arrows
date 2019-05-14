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
    public static KindUnsupportedException unsupported<T>(T kind, [CallerFilePath] string file = null, 
        [CallerLineNumber] int? line = null)
            where T : Enum
                => Errors.KindUnsupported(kind, file, line);

    public static KindUnsupportedException unsupported<S,T>(S src, T dst, [CallerFilePath] string file = null,
         [CallerLineNumber] int? line = null)
            where T : Enum
            where S : Enum
                => Errors.KindOpUnsupported(src, dst, file, line);

    public static IndexOutOfRangeException outOfRange(int index, int min, int max)
        => Errors.OutOfRange(index,min,max);
        
    public static HashSet<T> set<T>(params T[] src)
        => new HashSet<T>(src);

}