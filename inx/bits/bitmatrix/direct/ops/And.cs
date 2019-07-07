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

    partial class BitMatrixX
    {    
        [MethodImpl(Inline)]
        public static ref BitMatrix4 And(this ref BitMatrix4 lhs, in BitMatrix4 rhs)
        {
             lhs.bits = ((ushort) ((ushort)lhs & (ushort)rhs)).ToBytes();
             return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref BitMatrix8 And(this ref BitMatrix8 lhs, in BitMatrix8 rhs)
        {
             lhs.bits =((ulong)lhs & (ulong)rhs).ToBytes();
             return ref lhs;
        }
        
        [MethodImpl(Inline)]
        public static ref BitMatrix16 And(this ref BitMatrix16 lhs, in BitMatrix16 rhs)
        {
            lhs.LoadVector(out Vec256<ushort> vLhs);
            rhs.LoadVector(out Vec256<ushort> vRhs);
            vLhs.And(vRhs, ref lhs.bits[0]);
            return ref lhs;
        }

        public static ref BitMatrix32 And(this ref BitMatrix32 lhs, in BitMatrix32 rhs)
        {
            const int rowstep = 8;
            for(var i=0; i< lhs.RowDim; i += rowstep)
            {
                lhs.LoadVector(out Vec256<uint> vLhs, i);
                rhs.LoadVector(out Vec256<uint> vRhs, i);
                vLhs.And(vRhs, ref lhs.bits[i]);                
            }
            return ref lhs;
        }

        public static ref BitMatrix64 And(this ref BitMatrix64 lhs, in BitMatrix64 rhs)
        {
            const int rowstep = 4;
            for(var i=0; i< lhs.RowDim; i += rowstep)
            {
                lhs.LoadVector(out Vec256<ulong> vLhs, i);
                rhs.LoadVector(out Vec256<ulong> vRhs, i);
                vLhs.And(vRhs, ref lhs.bits[i]);                
            }
            return ref lhs;
        }

        public static ref BitMatrix<M,N,T> And<M,N,T>(this ref BitMatrix<M,N,T> lhs, in BitMatrix<M,N,T> rhs)        
            where N : ITypeNat, new()
            where M : ITypeNat, new()
            where T : struct
        {
            return ref lhs;
        }

    }
}