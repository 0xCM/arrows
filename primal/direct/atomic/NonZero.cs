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
    

    partial class math
    {
        [MethodImpl(Inline)]
        public static bool nonzero(sbyte src)
            => src != 0;

        [MethodImpl(Inline)]
        public static bool nonzero(byte src)
            => src != 0;

        [MethodImpl(Inline)]
        public static bool nonzero(short src)
            => src != 0;

        [MethodImpl(Inline)]
        public static bool nonzero(ushort src)
            => src != 0;

        [MethodImpl(Inline)]
        public static bool nonzero(int src)
            => src != 0;

        [MethodImpl(Inline)]
        public static bool nonzero(uint src)
            => src != 0;

        [MethodImpl(Inline)]
        public static bool nonzero(long src)
            => src != 0;

        [MethodImpl(Inline)]
        public static bool nonzero(ulong src)
            => src != 0;

        [MethodImpl(Inline)]
        public static bool nonzero(float src)
            => src != 0;

        [MethodImpl(Inline)]
        public static bool nonzero(double src)
            => src != 0; 
    }
}