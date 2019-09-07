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

    using Iced.Intel;
    using static zfunc;
        
    /// <summary>
    /// Adheres a set of IL instructions with the source method
    /// </summary>
    public class MethodAsmBody
    {
        public MethodAsmBody(MethodBase Method, CodeBlock[] NativeBlocks, Instruction[] Instructions)
        {
            this.Method = Method;
            this.NativeBlocks = NativeBlocks;
            this.Instructions = Instructions;
            this.StartAddress = Instructions.First().IP;
            this.EndAddress = Instructions.Last().IP;
        }
        
        public MethodBase Method {get;}

        public ulong StartAddress {get;}
            
        public ulong EndAddress {get;}

        public Instruction[] Instructions {get;}
        
        public CodeBlock[] NativeBlocks {get;}

        public int MethodId
            => Method.MetadataToken;
                
        public string MethodName 
            => Method.Name;



        public override string ToString()
            => this.Format();
    }
}