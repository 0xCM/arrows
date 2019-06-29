//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Cpu
{

    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public static partial class Instructions
    {
        public abstract class Instruction<T,S>
        {
            protected Instruction(T Dst, S Src)
            {
                this.Dst = Dst;
                this.Src = Src;
            }

            public S Src {get;}

            public T Dst {get;}

        }
        
        public class MOVZX<T,S> : Instruction<T,S>
        {
            public MOVZX(T Dst, S Src)
                : base(Dst,Src)
            {
            
            }            
        }


    }

}