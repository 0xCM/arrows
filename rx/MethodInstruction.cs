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

    public class MethodInstruction 
    {
        public MethodInstruction(ushort Offset, string Text)
        {
            this.Offset = Offset;
            this.Text  = Text;
        }
        
        public ushort Offset {get;}

        public string Text {get;}

        public override string ToString()
            => $"{Offset.ToHexString(true,false)}: {Text}";
    }


}