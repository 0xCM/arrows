//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    /// <summary>
    /// Describes a register in the context of an asm instruction operand
    /// </summary>
    public class AsmRegisterInfo
    {
        public AsmRegisterInfo(string RegisterName)
        {
            this.RegisterName = RegisterName;
        }
        
        public string RegisterName {get;}
    }

}