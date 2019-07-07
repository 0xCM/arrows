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

    partial class BitMatrixX
    {    
        [MethodImpl(Inline)]
        public static bool IsZero(this in BitMatrix4 src)
            => BitConverter.ToUInt16(src.bits) == 0;

        [MethodImpl(Inline)]
        public static bool IsZero(this in BitMatrix8 src)
            => BitConverter.ToUInt64(src.bits) == 0;

        [MethodImpl(Inline)]
        public static bool IsZero(this in BitMatrix16 src)
        {
            src.LoadVector(out Vec256<ushort> vSrc);
            return vSrc.TestZ(vSrc);            
        }

        [MethodImpl(Inline)]
        public static bool IsZero(this in BitMatrix32 src)
        {
            const int rowstep = 8;
            for(var i=0; i< src.RowDim; i += rowstep)
            {
                src.LoadVector(out Vec256<uint> vSrc, i);
                if(!vSrc.TestZ(vSrc))
                    return false;
            }
            return true;
        }

        [MethodImpl(Inline)]
        public static bool IsZero(this in BitMatrix64 src)
        {
            const int rowstep = 4;
            for(var i=0; i< src.RowDim; i += rowstep)
            {
                src.LoadVector(out Vec256<ulong> vSrc, i);
                if(!vSrc.TestZ(vSrc))
                    return false;
            }
            return true;
        }
    }
}