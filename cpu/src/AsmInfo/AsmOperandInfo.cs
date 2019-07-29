//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{        
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static zfunc;

    public class AsmOperandInfo
    {
        public AsmOperandInfo(byte Index, string Kind, Option<ImmInfo> imminfo, string register = null)
        {
            this.Index = Index;
            this.Kind = Kind;
            this.ImmInfo = imminfo;
            this.Register = register;
        }
        
        public byte Index {get;}

        public string Kind {get;}

        public Option<ImmInfo> ImmInfo {get;}

        public Option<string> Register;
    }

}