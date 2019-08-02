//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    partial class BitMatrixOps
    {    


        [MethodImpl(Inline)]
        public static ref BitMatrix8 XOr(this ref BitMatrix8 lhs, in BitMatrix8 rhs)
        {
             lhs.bits = ((ulong)lhs ^ (ulong)rhs).ToBytes();
             return ref lhs;
        }
        
        [MethodImpl(Inline)]
        public static ref BitMatrix16 XOr(this ref BitMatrix16 lhs, in BitMatrix16 rhs)
        {
            lhs.LoadVector(out Vec256<ushort> vLhs);
            rhs.LoadVector(out Vec256<ushort> vRhs);
            vLhs.XOr(vRhs, ref lhs.bits[0]);
            return ref lhs;
        }



    }

}