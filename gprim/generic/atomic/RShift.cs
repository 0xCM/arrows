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
        public static T rshift<T>(T lhs, int rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return rshiftI8(lhs,rhs);
            else if(typeof(T) == typeof(byte))
                return rshiftU8(lhs, rhs);
            else if(typeof(T) == typeof(short))
                return rshiftI16(lhs, rhs);
            else if(typeof(T) == typeof(ushort))
                return rshiftU16(lhs,rhs);
            else if(typeof(T) == typeof(int))
                return rshiftI32(lhs, rhs);
            else if(typeof(T) == typeof(uint))
                return rshiftU32(lhs, rhs);
            else if(typeof(T) == typeof(long))
                return rshiftI64(lhs,rhs);
            else if(typeof(T) == typeof(ulong))
                return rshiftU64(lhs,rhs);
            else            
                throw unsupported(PrimalKinds.kind<T>());
        }           

        [MethodImpl(Inline)]
        public static ref T rshift<T>(ref T lhs, int rhs)
            where T : struct
        {
            var kind = PrimalKinds.kind<T>();

            if(kind == PrimalKind.int32)
                return ref rshiftI32(ref lhs, rhs);

            if(kind == PrimalKind.uint32)
                return ref rshiftU32(ref lhs, rhs);

            if(kind == PrimalKind.int64)
                return ref rshiftI64(ref lhs, rhs);

            if(kind == PrimalKind.uint64)
                return ref rshiftU64(ref lhs, rhs);

            if(kind == PrimalKind.int16)
                return ref rshiftI16(ref lhs, rhs);

            if(kind == PrimalKind.uint16)
                return ref rshiftU16(ref lhs, rhs);

            if(kind == PrimalKind.int8)
                return ref rshiftI8(ref lhs, rhs);

            if(kind == PrimalKind.uint8)
                return ref rshiftU8(ref lhs, rhs);

            throw unsupported(kind);
        }           



        [MethodImpl(Inline)]
        static ref T rshiftI8<T>(ref T lhs, int rhs)
        {
            ref var result = ref math.rshift(ref int8(ref lhs), rhs);
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T rshiftU8<T>(ref T lhs, int rhs)
        {
            ref var result = ref math.rshift(ref uint8(ref lhs), rhs);
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T rshiftI16<T>(ref T lhs, int rhs)
        {
            ref var result = ref math.rshift(ref int16(ref lhs), rhs);
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T rshiftU16<T>(ref T lhs, int rhs)
        {
            ref var result = ref math.rshift(ref uint16(ref lhs), rhs);
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            


        [MethodImpl(Inline)]
        static ref T rshiftI32<T>(ref T lhs, int rhs)
        {
            ref var result = ref math.rshift(ref int32(ref lhs), rhs);
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T rshiftU32<T>(ref T lhs, int rhs)
        {
            ref var result = ref math.rshift(ref uint32(ref lhs), rhs);
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T rshiftI64<T>(ref T lhs, int rhs)
        {
            ref var result = ref math.rshift(ref int64(ref lhs), rhs);
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T rshiftU64<T>(ref T lhs, int rhs)
        {
            ref var result = ref math.rshift(ref uint64(ref lhs), rhs);
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static T rshiftI8<T>(T lhs, int rhs)
            => generic<T>((sbyte)(int8(lhs) >> rhs));

        [MethodImpl(Inline)]
        static T rshiftU8<T>(T lhs, int rhs)
            => generic<T>((byte)(uint8(lhs) >> rhs));

        [MethodImpl(Inline)]
        static T rshiftI16<T>(T lhs, int rhs)
            => generic<T>((short)(int16(lhs) >> rhs));

        [MethodImpl(Inline)]
        static T rshiftU16<T>(T lhs, int rhs)
            => generic<T>((ushort)(uint16(lhs) >> rhs));

        [MethodImpl(Inline)]
        static T rshiftI32<T>(T lhs, int rhs)
            => generic<T>(int32(lhs) >> rhs);
        
        [MethodImpl(Inline)]
        static T rshiftU32<T>(T lhs, int rhs)
            => generic<T>(uint32(lhs) >> rhs);

        [MethodImpl(Inline)]
        static T rshiftI64<T>(T lhs, int rhs)
            => generic<T>(int64(lhs)  >> rhs);

        [MethodImpl(Inline)]
        static T rshiftU64<T>(T lhs, int rhs)
            => generic<T>(uint64(lhs)  >> rhs);


    }

}