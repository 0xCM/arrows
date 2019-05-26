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

    partial class bridge
    {
        [MethodImpl(Inline)]
        public static bool gteqI8<T>(T lhs, T rhs)
            => int8(lhs) >= int8(rhs);

        [MethodImpl(Inline)]
        public static bool gteqU8<T>(T lhs, T rhs)
            => uint8(lhs) >= uint8(rhs);

        [MethodImpl(Inline)]
        public static bool gteqI16<T>(T lhs, T rhs)
            => int16(lhs) >= int16(rhs);

        [MethodImpl(Inline)]
        public static bool gteqU16<T>(T lhs, T rhs)
            => uint16(lhs) >= uint16(rhs);

        [MethodImpl(Inline)]
        public static bool gteqI32<T>(T lhs, T rhs)
            => int32(lhs) >= int32(rhs);
        
        [MethodImpl(Inline)]
        public static bool gteqU32<T>(T lhs, T rhs)
            => uint32(lhs) >= uint32(rhs);

        [MethodImpl(Inline)]
        public static bool gteqI64<T>(T lhs, T rhs)
            => int64(lhs) >= int64(rhs);

        [MethodImpl(Inline)]
        public static bool gteqU64<T>(T lhs, T rhs)
            => uint64(lhs) >= uint64(rhs);

        [MethodImpl(Inline)]
        public static bool gteqF32<T>(T lhs, T rhs)
            => float32(lhs) >= float32(rhs);

        [MethodImpl(Inline)]
        public static bool gteqF64<T>(T lhs, T rhs)
            => float64(lhs) >= float64(rhs);


    }

}