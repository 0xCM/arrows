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
        public static T orI8<T>(T lhs, T rhs)
            => generic<T>((sbyte)(int8(lhs) | int8(rhs)));

        [MethodImpl(Inline)]
        public static T orU8<T>(T lhs, T rhs)
            => generic<T>((byte)(uint8(lhs) | uint8(rhs)));

        [MethodImpl(Inline)]
        public static T orI16<T>(T lhs, T rhs)
            => generic<T>((short)(int16(lhs) | int16(rhs)));

        [MethodImpl(Inline)]
        public static T orU16<T>(T lhs, T rhs)
            => generic<T>((ushort)(uint16(lhs) | uint16(rhs)));

        [MethodImpl(Inline)]
        public static T orI32<T>(T lhs, T rhs)
            => generic<T>(int32(lhs) | int32(rhs));
        
        [MethodImpl(Inline)]
        public static T orU32<T>(T lhs, T rhs)
            => generic<T>(uint32(lhs) | uint32(rhs));

        [MethodImpl(Inline)]
        public static T orI64<T>(T lhs, T rhs)
            => generic<T>(int64(lhs) | int64(rhs));

        [MethodImpl(Inline)]
        public static T orU64<T>(T lhs, T rhs)
            => generic<T>(uint64(lhs) | uint64(rhs));
                    [MethodImpl(Inline)]
        public static ref T orI8<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.or(ref int8(ref lhs), int8(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        public static ref T orU8<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.or(ref uint8(ref lhs), uint8(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        public static ref T orI16<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.or(ref int16(ref lhs), int16(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        public static ref T orU16<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.or(ref uint16(ref lhs), uint16(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            


        [MethodImpl(Inline)]
        public static ref T orI32<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.or(ref int32(ref lhs), int32(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        public static ref T orU32<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.or(ref uint32(ref lhs), uint32(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        public static ref T orI64<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.or(ref int64(ref lhs), int64(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        public static ref T orU64<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.or(ref uint64(ref lhs), uint64(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            
    }
}