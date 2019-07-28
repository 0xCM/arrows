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
    public class CilFuncSpec
    {
        public CilFuncSpec(int MethodId, string FullName, IReadOnlyList<Instruction> Instructions)
        {
            this.MethodId = MethodId;
            this.FullName = FullName;
            this.Instructions = Instructions.Select(i => new MethodCilEntry(i)).ToReadOnlyList();
        }
        
        public int MethodId {get;}
                
        public string FullName {get;}

        public IReadOnlyList<MethodCilEntry> Instructions {get;}

        public string Format(bool onlyInstructions = true)
        {
            var desc = sbuild();
            if(!onlyInstructions)
            {
                desc.AppendLine(FullName);
                desc.AppendLine(AsciSym.LBrace.ToString());
            }
            foreach(var i in Instructions)
                desc.AppendLine($"    {i.ToString()}");
            
            if(!onlyInstructions)
                desc.AppendLine(AsciSym.RBrace.ToString());
            
            return desc.ToString();

        }
 
         public override string ToString()
            => Format();

    }
}