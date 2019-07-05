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
            public static readonly ShiftOp<T> Op = gbits.shiftr<T>;
        }


    }


}