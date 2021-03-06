//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;    

    public static class BitwiseDelegates
    {
        [MethodImpl(Inline)]
        public static BinaryOp<T> and<T>()
            where T : unmanaged
                => And<T>.Op;

        [MethodImpl(Inline)]
        public static BinaryOp<T> or<T>()
            where T : unmanaged
                => Or<T>.Op;
 
        [MethodImpl(Inline)]
        public static BinaryOp<T> xor<T>()
            where T : unmanaged
                => XOr<T>.Op;

        [MethodImpl(Inline)]
        public static UnaryOp<T> flip<T>()
            where T : unmanaged
                => Flip<T>.Op;

        [MethodImpl(Inline)]
        public static ShiftOp<T> sal<T>(T lhs, int count)
            where T : unmanaged
                => Sal<T>.Op;

        [MethodImpl(Inline)]
        public static ShiftOp<T> sar<T>(T lhs, int count)
            where T : unmanaged
                => Sar<T>.Op;

       readonly struct Sal<T>
            where T : unmanaged
        {
            public static readonly ShiftOp<T> Op = gbits.sal<T>;
        }

       readonly struct Sar<T>
            where T : unmanaged
        {
            public static readonly ShiftOp<T> Op = gbits.sar<T>;
        }


        readonly struct And<T>
            where T : unmanaged
        {
            public static readonly BinaryOp<T> Op = gmath.and<T>;
        }


        readonly struct Or<T>
            where T : unmanaged
        {
            public static readonly BinaryOp<T> Op = gbits.or<T>;
        }

        readonly struct XOr<T>
            where T : unmanaged
        {
            public static readonly BinaryOp<T> Op = gmath.xor<T>;
        }

       readonly struct Flip<T>
            where T : unmanaged
        {
            public static readonly UnaryOp<T> Op = gbits.flip<T>;
        }
    }
}