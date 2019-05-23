//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Numerics;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using Z0;
 
    using static zfunc;
    using static mfunc;
    
    partial class Bits
    {                

        [MethodImpl(Inline)]
        public static ref sbyte loOff(ref sbyte src)
        {
            src &= (sbyte)(src - 1);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref byte loOff(ref byte src)
        {
            src &= (byte)(src - 1);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref short loOff(ref short src)
        {
            src &= (short)(src - 1);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref ushort loOff(ref ushort src)
        {
            src &= (ushort)(src - 1);
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref int loOff(ref int src)
        {
            src &= src - 1;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref uint loOff(ref uint src)
        {
            src &= src - 1;
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref long loOff(ref long src)
        {
            src &= src - 1;
            return ref src;
        }

    
        [MethodImpl(Inline)]
        public static ref ulong loOff(ref ulong src)
        {
            src &= src - 1;
            return ref src;
        }
    }
}