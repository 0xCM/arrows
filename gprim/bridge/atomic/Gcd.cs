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
        public static T gcdI8<T>(T lhs, T rhs)
            => generic<T>((math.gcd(int8(lhs), int8(rhs))));

        [MethodImpl(Inline)]
        public static T gcdU8<T>(T lhs, T rhs)
            => generic<T>((math.gcd(uint8(lhs), uint8(rhs))));

        [MethodImpl(Inline)]
        public static T gcdI16<T>(T lhs, T rhs)
            => generic<T>((math.gcd(int16(lhs), int16(rhs))));

        [MethodImpl(Inline)]
        public static T gcdU16<T>(T lhs, T rhs)
            => generic<T>((math.gcd(uint16(lhs), int16(rhs))));

        [MethodImpl(Inline)]
        public static T gcdI32<T>(T lhs, T rhs)
            => generic<T>((math.gcd(int32(lhs), int32(rhs))));

        [MethodImpl(Inline)]
        public static T gcdU32<T>(T lhs, T rhs)
            => generic<T>((math.gcd(uint32(lhs), int32(rhs))));

        [MethodImpl(Inline)]
        public static T gcdI64<T>(T lhs, T rhs)
            => generic<T>((math.gcd(int64(lhs), int64(rhs))));

        [MethodImpl(Inline)]
        public static T gcdU64<T>(T lhs, T rhs)
            => generic<T>((math.gcd(uint64(lhs), uint64(rhs))));

        [MethodImpl(Inline)]
        public static T gcdF32<T>(T lhs, T rhs)
            => generic<T>((MathF.Max(float32(lhs), float32(rhs))));

        [MethodImpl(Inline)]
        public static T gcdF64<T>(T lhs, T rhs)
            => generic<T>((math.gcd(float64(lhs), float64(rhs))));

    }

}