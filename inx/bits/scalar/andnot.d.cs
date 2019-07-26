//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using Z0;
 
    using static zfunc;
    
    public static partial class Bits
    {                
        [MethodImpl(Inline)]
        public static ulong andnot(in ulong lhs, in ulong rhs)
            => Bmi1.X64.AndNot(lhs,rhs);

        [MethodImpl(Inline)]
        public static uint andnot(in uint lhs, in uint rhs)
            => Bmi1.AndNot(lhs,rhs);

        [MethodImpl(Inline)]
        public static ushort andnot(in ushort lhs, in ushort rhs)
            => (ushort)Bmi1.AndNot(lhs,rhs);

        [MethodImpl(Inline)]
        public static byte andnot(in byte lhs, in byte rhs)
            => (byte)Bmi1.AndNot(lhs,rhs);
    }
}