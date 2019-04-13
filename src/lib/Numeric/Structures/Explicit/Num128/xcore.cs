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
        public static Num128 absi32(this Num128 src)
            => Num128.absi32(src);

        [MethodImpl(Inline)]
        public static Num128 negatei32(this Num128 src)
            => Num128.negatei32(src);

        [MethodImpl(Inline)]
        public static Num128 addi32(this Num128 lhs, Num128 rhs)
            => Num128.addi32(lhs, rhs);

        [MethodImpl(Inline)]
        public static Num128 subi32(this Num128 lhs, Num128 rhs)
            => Num128.subi32(lhs, rhs);

        [MethodImpl(Inline)]
        public static Num128 muli32(this Num128 lhs, Num128 rhs)
            => Num128.muli32(lhs, rhs);

        [MethodImpl(Inline)]
        public static Num128 divi32(this Num128 lhs, Num128 rhs)
            => Num128.divi32(lhs, rhs);

        [MethodImpl(Inline)]
        public static Num128 modi32(this Num128 lhs, Num128 rhs)
            => Num128.modi32(lhs, rhs);

        [MethodImpl(Inline)]
        public static Num128 andi32(this Num128 lhs, Num128 rhs)
            => Num128.andi32(lhs, rhs);

        [MethodImpl(Inline)]
        public static Num128 ori32(this Num128 lhs, Num128 rhs)
            => Num128.ori32(lhs, rhs);

        [MethodImpl(Inline)]
        public static Num128 xori32(this Num128 lhs, Num128 rhs)
            => Num128.xori32(lhs, rhs);

    }
}