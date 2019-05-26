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
        static T lshiftI8<T>(in T lhs, in int rhs)
            => AsIn.generic<T>((sbyte)(AsIn.int8(in lhs)) << rhs);            

        [MethodImpl(Inline)]
        static T lshiftU8<T>(in T lhs, in int rhs)
            => generic<T>((byte)(uint8(lhs) << rhs));

        [MethodImpl(Inline)]
        static T lshiftI16<T>(in T lhs, in int rhs)
            => generic<T>((short)(int16(lhs) << rhs));

        [MethodImpl(Inline)]
        static T lshiftU16<T>(in T lhs, in int rhs)
            => generic<T>((ushort)(uint16(lhs) << rhs));

        [MethodImpl(Inline)]
        static T lshiftI32<T>(in T lhs, in int rhs)
            => generic<T>(int32(lhs) << rhs);
        
        [MethodImpl(Inline)]
        static T lshiftU32<T>(in T lhs, in int rhs)
            => generic<T>(uint32(lhs) << rhs);

        [MethodImpl(Inline)]
        static T lshiftI64<T>(in T lhs, in int rhs)
            => generic<T>(int64(lhs)  << rhs);

        [MethodImpl(Inline)]
        static T lshiftU64<T>(in T lhs, in int rhs)
            => generic<T>(uint64(lhs)  << rhs);

        [MethodImpl(Inline)]
        static ref T lshiftI8<T>(ref T lhs, int rhs)
        {
            ref var result = ref math.lshift(ref int8(ref lhs), rhs);
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T lshiftU8<T>(ref T lhs, int rhs)
        {
            ref var result = ref math.lshift(ref uint8(ref lhs), rhs);
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T lshiftI16<T>(ref T lhs, int rhs)
        {
            ref var result = ref math.lshift(ref int16(ref lhs), rhs);
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T lshiftU16<T>(ref T lhs, int rhs)
        {
            ref var result = ref math.lshift(ref uint16(ref lhs), rhs);
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            


        [MethodImpl(Inline)]
        static ref T lshiftI32<T>(ref T lhs, int rhs)
        {
            ref var result = ref math.lshift(ref int32(ref lhs), rhs);
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T lshiftU32<T>(ref T lhs, int rhs)
        {
            ref var result = ref math.lshift(ref uint32(ref lhs), rhs);
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T lshiftI64<T>(ref T lhs, int rhs)
        {
            ref var result = ref math.lshift(ref int64(ref lhs), rhs);
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T lshiftU64<T>(ref T lhs, int rhs)
        {
            ref var result = ref math.lshift(ref uint64(ref lhs), rhs);
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            




    }

}