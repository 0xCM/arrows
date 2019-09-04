//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Threading.Tasks;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using static zfunc;


    [Flags]
    public enum ObserverTrace
    {
        None = 0,

        Transitions = 1,

        Events = 2,

        Completions = 4,

        Errors = 8,

        All = Transitions | Events | Completions | Errors
    }

 
}