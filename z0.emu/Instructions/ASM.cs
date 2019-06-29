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
    using static Instructions;

    public static class ASM
    {

        public static MOVZX<R,S> movzx<R,S>(R dst, S src)
            => new MOVZX<R,S>(dst,src);

    }

}