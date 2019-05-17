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
        public static T maxI8<T>(T lhs, T rhs)
            => generic<T>((Math.Max(int8(lhs), int8(rhs))));

        [MethodImpl(Inline)]
        public static T maxU8<T>(T lhs, T rhs)
            => generic<T>((Math.Max(uint8(lhs), uint8(rhs))));

        [MethodImpl(Inline)]
        public static T maxI16<T>(T lhs, T rhs)
            => generic<T>((Math.Max(int16(lhs), int16(rhs))));

        [MethodImpl(Inline)]
        public static T maxU16<T>(T lhs, T rhs)
            => generic<T>((Math.Max(uint16(lhs), int16(rhs))));

        [MethodImpl(Inline)]
        public static T maxI32<T>(T lhs, T rhs)
            => generic<T>((Math.Max(int32(lhs), int32(rhs))));

        [MethodImpl(Inline)]
        public static T maxU32<T>(T lhs, T rhs)
            => generic<T>((Math.Max(uint32(lhs), int32(rhs))));

        [MethodImpl(Inline)]
        public static T maxI64<T>(T lhs, T rhs)
            => generic<T>((Math.Max(int64(lhs), int64(rhs))));

        [MethodImpl(Inline)]
        public static T maxU64<T>(T lhs, T rhs)
            => generic<T>((Math.Max(uint64(lhs), uint64(rhs))));

        [MethodImpl(Inline)]
        public static T maxF32<T>(T lhs, T rhs)
            => generic<T>((MathF.Max(float32(lhs), float32(rhs))));

        [MethodImpl(Inline)]
        public static T maxF64<T>(T lhs, T rhs)
            => generic<T>((Math.Max(float64(lhs), float64(rhs))));



    }

}