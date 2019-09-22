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
        public static Sign signum(int src)
            => (Sign)((src >> 31) | (int)(negate((uint)src) >> 31)); 

        [MethodImpl(Inline)]
        public static Sign signum(uint src)
            => (Sign)math.nonzero(src).ToByte();

        [MethodImpl(Inline)]
        public static Sign signum(long src)
            => (Sign)((src >> 63) | (long)(negate((ulong)src) >> 63)); 

        [MethodImpl(Inline)]
        public static Sign signum(ulong src)
            => (Sign)math.nonzero(src).ToByte();

        [MethodImpl(Inline)]
        public static Sign signum(float src)
            => (Sign)MathF.Sign(src);

        [MethodImpl(Inline)]
        public static Sign signum(double src)
            => (Sign)Math.Sign(src);
                
        [MethodImpl(Inline)]
        public static Sign signum(sbyte src)
            => signum((int)src);

        [MethodImpl(Inline)]
        public static Sign signum(byte src)
            => signum((uint)src);

        [MethodImpl(Inline)]
        public static Sign signum(short src)
            => signum((int)src);

        [MethodImpl(Inline)]
        public static Sign signum(ushort src)
            => signum((uint)src);



    }

}