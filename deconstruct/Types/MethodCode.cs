//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using dnlib.DotNet.Emit;

    using static zfunc;

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