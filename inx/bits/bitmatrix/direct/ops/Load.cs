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
        public static ref Vec256<ulong> LoadVector(this in BitMatrix64 src, out Vec256<ulong> dst, int rowOffset)
        {
            dst = Vec256.load(ref src.bits[rowOffset]);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Vec256<uint> LoadVector(this in BitMatrix32 src, out Vec256<uint> dst, int rowOffset)
        {
            dst = Vec256.load(ref src.bits[rowOffset]);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Vec256<ushort> LoadVector(this in BitMatrix16 src, out Vec256<ushort> dst)
        {
            dst = Vec256.load(ref src.bits[0]);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref Vec128<ushort> LoadVector(this in BitMatrix16 src, out Vec128<ushort> dst, int rowOffset)
        {
            dst = Vec128.load(ref src.bits[rowOffset]);
            return ref dst;
        }
    }
}
