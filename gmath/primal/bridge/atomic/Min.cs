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

    partial class bridge
    {

        [MethodImpl(Inline)]
        public static T minI8<T>(T lhs, T rhs)
            => generic<T>((Math.Min(int8(lhs), int8(rhs))));

        [MethodImpl(Inline)]
        public static T minU8<T>(T lhs, T rhs)
            => generic<T>((Math.Min(uint8(lhs), uint8(rhs))));

        [MethodImpl(Inline)]
        public static T minI16<T>(T lhs, T rhs)
            => generic<T>((Math.Min(int16(lhs), int16(rhs))));

        [MethodImpl(Inline)]
        public static T minU16<T>(T lhs, T rhs)
            => generic<T>((Math.Min(uint16(lhs), int16(rhs))));

        [MethodImpl(Inline)]
        public static T minI32<T>(T lhs, T rhs)
            => generic<T>((Math.Min(int32(lhs), int32(rhs))));

        [MethodImpl(Inline)]
        public static T minU32<T>(T lhs, T rhs)
            => generic<T>((Math.Min(uint32(lhs), int32(rhs))));

        [MethodImpl(Inline)]
        public static T minI64<T>(T lhs, T rhs)
            => generic<T>((Math.Min(int64(lhs), int64(rhs))));

        [MethodImpl(Inline)]
        public static T minU64<T>(T lhs, T rhs)
            => generic<T>((Math.Min(uint64(lhs), uint64(rhs))));

        [MethodImpl(Inline)]
        public static T minF32<T>(T lhs, T rhs)
            => generic<T>((MathF.Min(float32(lhs), float32(rhs))));

        [MethodImpl(Inline)]
        public static T minF64<T>(T lhs, T rhs)
            => generic<T>((Math.Min(float64(lhs), float64(rhs))));


    }

}