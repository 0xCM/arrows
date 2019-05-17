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
        public static ref T divI8<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.div(ref int8(ref lhs), int8(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        public static ref T divU8<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.div(ref uint8(ref lhs), uint8(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        public static ref T divI16<T>(ref T lhs, T rhs)
        {
            var result = (short) (int16(ref lhs) / int16(ref rhs));
            lhs = generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        public static ref T divU16<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.div(ref uint16(ref lhs), uint16(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            


        [MethodImpl(Inline)]
        public static ref T divI32<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.div(ref int32(ref lhs), int32(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        public static ref T divU32<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.div(ref uint32(ref lhs), uint32(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        public static ref T divI64<T>(ref T lhs, T rhs)
        {
            // ref var result = ref math.div(ref int64(ref lhs), int64(ref rhs));
            // lhs = ref generic<T>(ref result);
            // return ref lhs;
            lhs = generic<T>(int64(ref lhs) / int64(ref rhs));
            return ref lhs;

        }            

        [MethodImpl(Inline)]
        public static ref T divU64<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.div(ref uint64(ref lhs), uint64(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        public static ref T divF32<T>(ref T lhs, T rhs)
        {
            // ref var result = ref math.div(ref float32(ref lhs), float32(ref rhs));
            // lhs = ref generic<T>(ref result);
            lhs = generic<T>(float32(ref lhs) / float32(ref rhs));
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        public static ref T divF64<T>(ref T lhs, T rhs)
        {
            // ref var result = ref math.div(ref float64(ref lhs), float64(ref rhs));
            // lhs = ref generic<T>(ref result);
            lhs = generic<T>(float64(ref lhs) / float64(ref rhs));
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        public static T divI8<T>(T lhs, T rhs)
            => generic<T>((sbyte)(int8(lhs) / int8(rhs)));

        [MethodImpl(Inline)]
        public static T divU8<T>(T lhs, T rhs)
            => generic<T>((byte)(uint8(lhs) / uint8(rhs)));

        [MethodImpl(Inline)]
        public static T divI16<T>(T lhs, T rhs)
            => generic<T>((short)(int16(lhs) / int16(rhs)));

        [MethodImpl(Inline)]
        public static T divU16<T>(T lhs, T rhs)
            => generic<T>((ushort)(uint16(lhs) / uint16(rhs)));

        [MethodImpl(Inline)]
        public static T divI32<T>(T lhs, T rhs)
            => generic<T>(int32(lhs) / int32(rhs));
        
        [MethodImpl(Inline)]
        public static T divU32<T>(T lhs, T rhs)
            => generic<T>(uint32(lhs) / uint32(rhs));

        [MethodImpl(Inline)]
        public static T divI64<T>(T lhs, T rhs)
            => generic<T>(int64(lhs) / int64(rhs));

        [MethodImpl(Inline)]
        public static T divU64<T>(T lhs, T rhs)
            => generic<T>(uint64(lhs) / uint64(rhs));

        [MethodImpl(Inline)]
        public static T divF32<T>(T lhs, T rhs)
            => generic<T>(float32(lhs) / float32(rhs));

        [MethodImpl(Inline)]
        public static T divF64<T>(T lhs, T rhs)
            => generic<T>(float64(lhs) / float64(rhs));


    }
}


