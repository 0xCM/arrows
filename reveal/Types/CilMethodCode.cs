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

    public class CilMethodCode
    {
        public CilMethodCode(Instruction Content)
        {
            this.Offset = Offset;
            this.Content = Content;
        }

        public uint Offset {get;}

        public Instruction Content;
 
        public override string ToString()
        {
            return Content.ToString();
        }
   }
}