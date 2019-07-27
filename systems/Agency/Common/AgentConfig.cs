//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Explicit)]
    public readonly struct AgentConfig 
    {
        /// <summary>
        /// Identifies the agent, relative to the server, to which the configuration applies
        /// </summary>
        [FieldOffset(0)]
        public readonly AgentIdentity Identity;
    }
}