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
    public static AppMsg appMsg(object content, SeverityLevel level = SeverityLevel.Info)
        => AppMsg.Define($"{content}",level);

    public static AppMsg errorMsg(object content)
        => AppMsg.Define($"{content}",SeverityLevel.Error);

}