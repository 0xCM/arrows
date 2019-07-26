//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Diagnostics;

    using static zfunc;

    partial class BitMatrixOps
    {    

       [MethodImpl(Inline)]
        public static string Format<M,N,T>(this in BitMatrix<M,N,T> src)
            where M : ITypeNat, new()        
            where N : ITypeNat, new()
            where T : struct
                => src.Bits.AsBytes().Format(src.ColCount);


    }

}