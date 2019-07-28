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
        public MethodAsmBody(MethodBase Method, NativeBlock[] NativeBlocks, Instruction[] Instructions)
        {
            this.Method = Method;
            this.NativeBlocks = NativeBlocks;
            this.Instructions = Instructions;
        }
        
        public MethodBase Method {get;}

        public int MethodId
            => Method.MetadataToken;
                
        public string MethodName 
            => Method.Name;

        public Instruction[] Instructions {get;}
        
        public NativeBlock[] NativeBlocks {get;}


        public override string ToString()
            => this.Format();
        // {
        //     var desc = sbuild();
        //     desc.AppendLine(MethodName);
        //     desc.AppendLine(AsciSym.LBrace.ToString());            
        //     foreach(var i in Instructions)
        //     {
        //         var asm = $"    {i.ToString()}";
        //         desc.AppendLine(asm);                
        //     }
        //     desc.AppendLine(AsciSym.RBrace.ToString());
        //     return desc.ToString();

        // }
    }
}