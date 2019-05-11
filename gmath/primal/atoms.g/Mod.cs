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
        
    using static mfunc;
    using static As;

    partial class atoms
    {
        [MethodImpl(Inline)]
        public static T modI8<T>(T lhs, T rhs)
            => generic<T>((sbyte)(int8(lhs) % int8(rhs)));

        [MethodImpl(Inline)]
        public static T modU8<T>(T lhs, T rhs)
            => generic<T>((byte)(uint8(lhs) % uint8(rhs)));

        [MethodImpl(Inline)]
        public static T modI16<T>(T lhs, T rhs)
            => generic<T>((short)(int16(lhs) % int16(rhs)));

        [MethodImpl(Inline)]
        public static T modU16<T>(T lhs, T rhs)
            => generic<T>((ushort)(uint16(lhs) % uint16(rhs)));

        [MethodImpl(Inline)]
        public static T modI32<T>(T lhs, T rhs)
            => generic<T>(int32(lhs) % int32(rhs));
        
        [MethodImpl(Inline)]
        public static T modU32<T>(T lhs, T rhs)
            => generic<T>(uint32(lhs) % uint32(rhs));

        [MethodImpl(Inline)]
        public static T modI64<T>(T lhs, T rhs)
            => generic<T>(int64(lhs) % int64(rhs));

        [MethodImpl(Inline)]
        public static T modU64<T>(T lhs, T rhs)
            => generic<T>(uint64(lhs) % uint64(rhs));

        [MethodImpl(Inline)]
        public static T modF32<T>(T lhs, T rhs)
            => generic<T>(float32(lhs) % float32(rhs));

        [MethodImpl(Inline)]
        public static T modF64<T>(T lhs, T rhs)
            => generic<T>(float64(lhs) % float64(rhs));


    }
}


