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
        public static ref BitMatrix4 AndNot(this ref BitMatrix4 lhs, in BitMatrix4 rhs)
        {
             lhs.bits = ((ushort)lhs &~ (ushort)rhs).ToBytes();
             return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref BitMatrix8 AndNot(this ref BitMatrix8 lhs, in BitMatrix8 rhs)
        {
             lhs.bits = ((ulong)lhs &~ (ulong)rhs).ToBytes();
             return ref lhs;
        }
        
        [MethodImpl(Inline)]
        public static ref BitMatrix16 AndNot(this ref BitMatrix16 lhs, in BitMatrix16 rhs)
        {
            lhs.LoadVector(out Vec256<ushort> vLhs);
            rhs.LoadVector(out Vec256<ushort> vRhs);
            vLhs.AndNot(vRhs, ref lhs.bits[0]);
            return ref lhs;
        }

        public static ref BitMatrix32 AndNot(this ref BitMatrix32 lhs, in BitMatrix32 rhs)
        {
            const int rowstep = 8;
            for(var i=0; i< lhs.RowDim; i += rowstep)
            {
                lhs.LoadVector(out Vec256<uint> vLhs, i);
                rhs.LoadVector(out Vec256<uint> vRhs, i);
                vLhs.AndNot(vRhs, ref lhs.bits[i]);                
            }
            return ref lhs;
        }

        public static ref BitMatrix64 AndNot(this ref BitMatrix64 lhs, in BitMatrix64 rhs)
        {
            const int rowstep = 4;
            for(var i=0; i< lhs.RowDim; i += rowstep)
            {
                lhs.LoadVector(out Vec256<ulong> vLhs, i);
                rhs.LoadVector(out Vec256<ulong> vRhs, i);
                vLhs.AndNot(vRhs, ref lhs.bits[i]);                
            }
            return ref lhs;
        }

    }
}