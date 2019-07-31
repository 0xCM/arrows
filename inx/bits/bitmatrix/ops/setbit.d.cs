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
        static void Set(this ref Span<byte> src, int row, int col, Bit value)
        {
            if(value)
                BitMask.enable(ref src[row], col); 
            else
                BitMask.disable(ref src[row], col);
        }

        [MethodImpl(Inline)]
        static void Set(this ref Span<ushort> src, int row, int col, Bit value)
        {
            if(value)
                BitMask.enable(ref src[row], col); 
            else
                BitMask.disable(ref src[row], col);
        }

        [MethodImpl(Inline)]
        static void Set(this ref Span<uint> src, int row, int col, Bit value)
        {
            if(value)
                BitMask.enable(ref src[row], col); 
            else
                BitMask.disable(ref src[row], col);
        }

        [MethodImpl(Inline)]
        static void Set(this ref Span<ulong> src, int row, int col, Bit value)
        {
            if(value)
                BitMask.enable(ref src[row], col); 
            else
                BitMask.disable(ref src[row], col);
        }

        [MethodImpl(Inline)]
        public static void SetBit(this ref BitMatrix4 src, int row, int col, Bit value)
            => src.bits.Set(row,col,value);

        [MethodImpl(Inline)]
        public static void SetBit(this ref BitMatrix8 src, int row, int col, Bit value)
            => src.bits.Set(row,col,value);

        [MethodImpl(Inline)]
        public static void SetBit(this ref BitMatrix16 src, int row, int col, Bit value)
            => src.bits.Set(row,col,value);

        [MethodImpl(Inline)]
        public static void SetBit(this ref BitMatrix32 src, int row, int col, Bit value)
            => src.bits.Set(row,col,value);

        [MethodImpl(Inline)]
        public static void SetBit(this ref BitMatrix64 src, int row, int col, Bit value)
            => src.bits.Set(row,col,value);
    }
}