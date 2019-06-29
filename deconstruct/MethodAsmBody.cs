//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using dnlib.DotNet.Emit;
    using static zfunc;
        
    /// <summary>
    /// Adheres a set of IL instructions with the source method
    /// </summary>
    public class MethodAsmBody
    {
        public MethodAsmBody(int MethodId, string FullName, IReadOnlyList<MethodAsmEntry> Code)
        {
            this.MethodId = MethodId;
            this.FullName = FullName;
            this.Instructions = Code;
        }
        
        public int MethodId {get;}
        
        
        public string FullName {get;}

        public IReadOnlyList<MethodAsmEntry> Instructions {get;}

        public override string ToString()
        {
            var desc = sbuild();
            desc.AppendLine(FullName);
            desc.AppendLine(AsciSym.LBrace.ToString());
            foreach(var i in Instructions)
                desc.AppendLine($"    {i.ToString()}");
            desc.AppendLine(AsciSym.RBrace.ToString());
            return desc.ToString();

        }
    }
}