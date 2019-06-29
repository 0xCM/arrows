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

    using static zfunc;
    using dnlib.DotNet.Emit;

    public abstract class MethodCode<T>
    {
        public T Content {get;}

        protected MethodCode(T Content)
        {
            this.Content = Content;
        }

        public override string ToString()
        {
            return Content.ToString();
        }
    }

    
    public class MethodAsmEntry : MethodCode<string>
    {
        public MethodAsmEntry(ushort Offset, string Content)
            : base(Content)
        {
            this.Offset = Offset;
        }
        
        public ushort Offset {get;}


        public override string ToString()
            => $"{Offset.ToHexString(true,false)}: {Content}";
    }

    public class MethodCilEntry : MethodCode<Instruction>
    {
        public MethodCilEntry(Instruction Content)
            : base(Content)
        {
            this.Offset = Offset;
        }

        public uint Offset {get;}


    }

}