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
        public static ref T andI8<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.and(ref int8(ref lhs), int8(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        public static ref T andU8<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.and(ref uint8(ref lhs), uint8(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        public static ref T andI16<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.and(ref int16(ref lhs), int16(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        public static ref T andU16<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.and(ref uint16(ref lhs), uint16(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            


        [MethodImpl(Inline)]
        public static ref T andI32<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.and(ref int32(ref lhs), int32(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        public static ref T andU32<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.and(ref uint32(ref lhs), uint32(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        public static ref T andI64<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.and(ref int64(ref lhs), int64(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        public static ref T andU64<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.and(ref uint64(ref lhs), uint64(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            


        [MethodImpl(Inline)]
        public static T andI8<T>(T lhs, T rhs)
            => generic<T>((sbyte)(int8(lhs) & int8(rhs)));

        [MethodImpl(Inline)]
        public static T andU8<T>(T lhs, T rhs)
            => generic<T>((byte)(uint8(lhs) & uint8(rhs)));

        [MethodImpl(Inline)]
        public static T andI16<T>(T lhs, T rhs)
            => generic<T>((short)(int16(lhs) & int16(rhs)));

        [MethodImpl(Inline)]
        public static T andU16<T>(T lhs, T rhs)
            => generic<T>((ushort)(uint16(lhs) & uint16(rhs)));

        [MethodImpl(Inline)]
        public static T andI32<T>(T lhs, T rhs)
            => generic<T>(int32(lhs) & int32(rhs));
        
        [MethodImpl(Inline)]
        public static T andU32<T>(T lhs, T rhs)
            => generic<T>(uint32(lhs) & uint32(rhs));

        [MethodImpl(Inline)]
        public static T andI64<T>(T lhs, T rhs)
            => generic<T>(int64(lhs) & int64(rhs));

        [MethodImpl(Inline)]
        public static T andU64<T>(T lhs, T rhs)
            => generic<T>(uint64(lhs) & uint64(rhs));

    }

}