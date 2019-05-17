//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.IO;

using static zfunc;
using Z0;

partial class mfunc
{
    static AppMsg UnsupportedMsg<T>(OpKind op, PrimalKind primal, string caller, string file, int? line)
        where T : struct
            => AppMsg.Define($"{op} for primal {primal}:{typename<T>()} unsupported", 
                    SeverityLevel.Error, caller, file, line);
    static AppMsg UnsupportedMsg(OpKind op, PrimalKind primal, string caller, string file, int? line)
            => AppMsg.Define($"{op} for primal kind {primal} unsupported",  SeverityLevel.Error, caller, file, line);

    static AppException UnsupportedError<T>(OpKind op, PrimalKind primal,  string caller, string file, int? line)
        where T : struct
            => AppException.Define(UnsupportedMsg<T>(op, primal, caller, file, line));

    static AppException UnsupportedError(OpKind op, PrimalKind primal,  string caller, string file, int? line)
            => AppException.Define(UnsupportedMsg(op, primal, caller, file, line));

    public static AppException unsupported<T>(OpKind op, PrimalKind primal, [CallerFilePath] string caller = null,  
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
            where T : struct
                => UnsupportedError<T>(op, primal, caller, file, line);

    public static AppException unsupported(OpKind op, PrimalKind primal, [CallerFilePath] string caller = null,  
        [CallerFilePath] string file = null, [CallerLineNumber] int? line = null)
                => UnsupportedError(op, primal, caller, file, line);

}

    


