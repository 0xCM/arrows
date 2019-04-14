//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    

    using static zcore;

    
    partial class xcore
    {

        [MethodImpl(Inline)]
        public static PolyNum128 absi32(this PolyNum128 src)
            => PolyNum128.absi32(src);

        [MethodImpl(Inline)]
        public static PolyNum128 negatei32(this PolyNum128 src)
            => PolyNum128.negatei32(src);

        [MethodImpl(Inline)]
        public static PolyNum128 addi32(this PolyNum128 lhs, PolyNum128 rhs)
            => PolyNum128.addi32(lhs, rhs);

        [MethodImpl(Inline)]
        public static PolyNum128 subi32(this PolyNum128 lhs, PolyNum128 rhs)
            => PolyNum128.subi32(lhs, rhs);

        [MethodImpl(Inline)]
        public static PolyNum128 muli32(this PolyNum128 lhs, PolyNum128 rhs)
            => PolyNum128.muli32(lhs, rhs);

        [MethodImpl(Inline)]
        public static PolyNum128 divi32(this PolyNum128 lhs, PolyNum128 rhs)
            => PolyNum128.divi32(lhs, rhs);

        [MethodImpl(Inline)]
        public static PolyNum128 modi32(this PolyNum128 lhs, PolyNum128 rhs)
            => PolyNum128.modi32(lhs, rhs);

        [MethodImpl(Inline)]
        public static PolyNum128 andi32(this PolyNum128 lhs, PolyNum128 rhs)
            => PolyNum128.andi32(lhs, rhs);

        [MethodImpl(Inline)]
        public static PolyNum128 ori32(this PolyNum128 lhs, PolyNum128 rhs)
            => PolyNum128.ori32(lhs, rhs);

        [MethodImpl(Inline)]
        public static PolyNum128 xori32(this PolyNum128 lhs, PolyNum128 rhs)
            => PolyNum128.xori32(lhs, rhs);

    }
}