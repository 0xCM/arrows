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
        
    using static zfunc;    
    using static As;

    partial class gmath
    {

        [MethodImpl(Inline)]
        static bool dividesI8<T>(T lhs, T rhs)
            => int8(rhs) % int8(lhs) == 0;

        [MethodImpl(Inline)]
        static bool dividesU8<T>(T lhs, T rhs)
            => uint8(rhs) % uint8(lhs) == 0;

        [MethodImpl(Inline)]
        static bool dividesI16<T>(T lhs, T rhs)
            => int16(rhs) % int16(lhs) == 0;

        [MethodImpl(Inline)]
        static bool dividesU16<T>(T lhs, T rhs)
            => uint16(rhs) % uint16(lhs) == 0;

        [MethodImpl(Inline)]
        static bool dividesI32<T>(T lhs, T rhs)
            => int32(rhs) % int32(lhs) == 0;
        
        [MethodImpl(Inline)]
        static bool dividesU32<T>(T lhs, T rhs)
            => uint32(rhs) % uint32(lhs) == 0;

        [MethodImpl(Inline)]
        static bool dividesI64<T>(T lhs, T rhs)
            => int64(rhs) % int64(lhs) == 0;

        [MethodImpl(Inline)]
        static bool dividesU64<T>(T lhs, T rhs)
            => uint64(rhs) % uint64(lhs) == 0;

        [MethodImpl(Inline)]
        static bool dividesF32<T>(T lhs, T rhs)
            => float32(rhs) % float32(lhs) == 0;

        [MethodImpl(Inline)]
        static bool dividesF64<T>(T lhs, T rhs)
            => float64(rhs) % float64(lhs) == 0;
    }
}


