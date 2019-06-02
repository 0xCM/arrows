//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    
    using static zfunc;    
    

    partial class MathX
    {
        [MethodImpl(Inline)]
        public static sbyte ShiftL(this sbyte src, int shift)
            => (sbyte)(src << shift);

        [MethodImpl(Inline)]
        public static byte ShiftL(this byte src, int shift)
            => (byte)(src << shift);

        [MethodImpl(Inline)]
        public static short ShiftL(this short src, int shift)
            => (short)(src << shift);

        [MethodImpl(Inline)]
        public static ushort ShiftL(this ushort src, int shift)
            => (ushort)(src << shift);
    }

}