//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;    

    public static class BitwiseDelegates
    {
        [MethodImpl(Inline)]
        public static BinaryOp<T> and<T>()
            where T : struct
                => And<T>.Op;

        [MethodImpl(Inline)]
        public static BinaryOp<T> or<T>()
            where T : struct
                => Or<T>.Op;
 
        [MethodImpl(Inline)]
        public static BinaryOp<T> xor<T>()
            where T : struct
                => XOr<T>.Op;

        [MethodImpl(Inline)]
        public static UnaryOp<T> flip<T>()
            where T : struct
                => Flip<T>.Op;

        [MethodImpl(Inline)]
        public static ShiftOp<T> shiftl<T>(T lhs, int count)
            where T : struct
                => ShiftL<T>.Op;

        [MethodImpl(Inline)]
        public static ShiftOp<T> shiftr<T>(T lhs, int count)
            where T : struct
                => ShiftR<T>.Op;

       readonly struct ShiftL<T>
            where T : struct
        {
            public static readonly ShiftOp<T> Op = gbits.shiftl<T>;
        }

       readonly struct ShiftR<T>
            where T : struct
        {
            public static readonly ShiftOp<T> Op = gbits.sra<T>;
        }


        readonly struct And<T>
            where T : struct
        {
            public static readonly BinaryOp<T> Op = gbits.and<T>;
        }


        readonly struct Or<T>
            where T : struct
        {
            public static readonly BinaryOp<T> Op = gbits.or<T>;
        }

        readonly struct XOr<T>
            where T : struct
        {
            public static readonly BinaryOp<T> Op = gbits.xor<T>;
        }

       readonly struct Flip<T>
            where T : struct
        {
            public static readonly UnaryOp<T> Op = gbits.flip<T>;
        }

    }


}