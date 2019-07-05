//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
 
    using static zfunc;
    
    partial class Bits
    {                

        [MethodImpl(Inline)]
        public static ref sbyte loff(ref sbyte src)
        {
            src &= (sbyte)(src - 1);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref byte loff(ref byte src)
        {
            src &= (byte)(src - 1);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref short loff(ref short src)
        {
            src &= (short)(src - 1);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref ushort loff(ref ushort src)
        {
            src &= (ushort)(src - 1);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref int loff(ref int src)
        {
            src &= src - 1;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref uint loff(ref uint src)
        {
            src &= src - 1;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref long loff(ref long src)
        {
            src &= src - 1;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref ulong loff(ref ulong src)
        {
            src &= src - 1;
            return ref src;
        }
    }
}