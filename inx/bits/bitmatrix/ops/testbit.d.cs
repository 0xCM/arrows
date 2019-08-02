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

    using static zfunc;

    partial class BitMatrixOps
    {    

        [MethodImpl(Inline)]
        public static bool IsZero(this BitMatrix8 src)
            => BitConverter.ToUInt64(src.bits) == 0;

        [MethodImpl(Inline)]
        public static bool IsZero(this BitMatrix16 src)
        {
            src.LoadVector(out Vec256<ushort> vSrc);
            return vSrc.TestZ(vSrc);            
        }


    }
}