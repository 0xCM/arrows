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
        public static ref T rshiftI8<T>(ref T lhs, int rhs)
        {
            ref var result = ref math.rshift(ref int8(ref lhs), rhs);
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        public static ref T rshiftU8<T>(ref T lhs, int rhs)
        {
            ref var result = ref math.rshift(ref uint8(ref lhs), rhs);
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        public static ref T rshiftI16<T>(ref T lhs, int rhs)
        {
            ref var result = ref math.rshift(ref int16(ref lhs), rhs);
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        public static ref T rshiftU16<T>(ref T lhs, int rhs)
        {
            ref var result = ref math.rshift(ref uint16(ref lhs), rhs);
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            


        [MethodImpl(Inline)]
        public static ref T rshiftI32<T>(ref T lhs, int rhs)
        {
            ref var result = ref math.rshift(ref int32(ref lhs), rhs);
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        public static ref T rshiftU32<T>(ref T lhs, int rhs)
        {
            ref var result = ref math.rshift(ref uint32(ref lhs), rhs);
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        public static ref T rshiftI64<T>(ref T lhs, int rhs)
        {
            ref var result = ref math.rshift(ref int64(ref lhs), rhs);
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        public static ref T rshiftU64<T>(ref T lhs, int rhs)
        {
            ref var result = ref math.rshift(ref uint64(ref lhs), rhs);
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        public static T rshiftI8<T>(T lhs, int rhs)
            => generic<T>((sbyte)(int8(lhs) >> rhs));

        [MethodImpl(Inline)]
        public static T rshiftU8<T>(T lhs, int rhs)
            => generic<T>((byte)(uint8(lhs) >> rhs));

        [MethodImpl(Inline)]
        public static T rshiftI16<T>(T lhs, int rhs)
            => generic<T>((short)(int16(lhs) >> rhs));

        [MethodImpl(Inline)]
        public static T rshiftU16<T>(T lhs, int rhs)
            => generic<T>((ushort)(uint16(lhs) >> rhs));

        [MethodImpl(Inline)]
        public static T rshiftI32<T>(T lhs, int rhs)
            => generic<T>(int32(lhs) >> rhs);
        
        [MethodImpl(Inline)]
        public static T rshiftU32<T>(T lhs, int rhs)
            => generic<T>(uint32(lhs) >> rhs);

        [MethodImpl(Inline)]
        public static T rshiftI64<T>(T lhs, int rhs)
            => generic<T>(int64(lhs)  >> rhs);

        [MethodImpl(Inline)]
        public static T rshiftU64<T>(T lhs, int rhs)
            => generic<T>(uint64(lhs)  >> rhs);


    }

}