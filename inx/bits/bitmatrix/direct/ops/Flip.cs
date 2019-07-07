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
        public static ref BitMatrix4 Flip(this ref BitMatrix4 src)
        {
             src.bits = ((ushort) (~(ushort)src)).ToBytes();
             return ref src;
        }

        [MethodImpl(Inline)]
        public static ref BitMatrix8 Flip(this ref BitMatrix8 src)
        {
             src.bits = (~(ulong)src).ToBytes();
             return ref src;
        }
        
        [MethodImpl(Inline)]
        public static ref BitMatrix16 Flip(this ref BitMatrix16 src)
        {
            src.LoadVector(out Vec256<ushort> vSrc);
            vSrc.Flip(ref src.bits[0]);
            return ref src;
        }

        public static ref BitMatrix32 Flip(this ref BitMatrix32 src)
        {
            const int rowstep = 8;
            for(var i=0; i< src.RowDim; i += rowstep)
            {
                src.LoadVector(out Vec256<uint> vSrc, i);
                vSrc.Flip(ref src.bits[i]);
            }
            return ref src;
        }

        public static ref BitMatrix64 Flip(this ref BitMatrix64 src)
        {
            const int rowstep = 4;
            for(var i=0; i< src.RowDim; i += rowstep)
            {
                src.LoadVector(out Vec256<ulong> vSrc, i);
                vSrc.Flip(ref src.bits[i]);
            }
            return ref src;
        }
    }
}