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
        public static BitVector8 Diagonal(this in BitMatrix8 src)
        {
            var dst = (byte)0;
            for(byte i=0; i < BitMatrix8.N; i++)
                if(src[i,i])
                    BitMask.enable(ref dst, i);
            return dst;                    
        }

        [MethodImpl(Inline)]
        public static BitVector16 Diagonal(this in BitMatrix16 src)
        {
            var dst = (ushort)0;
            for(byte i=0; i < BitMatrix16.N; i++)
                if(src[i,i])
                    BitMask.enable(ref dst, i);
            return dst;                    
        }

        [MethodImpl(Inline)]
        public static BitVector32 Diagonal(this in BitMatrix32 src)
        {
            var dst = (uint)0;
            for(byte i=0; i < BitMatrix32.N; i++)
                if(src[i,i])
                    BitMask.enable(ref dst, i);
            return dst;                    
        }

    }

}