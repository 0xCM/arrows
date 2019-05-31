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
        public static T shiftr<T>(T lhs, int rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return shiftrI8(lhs,rhs);
            else if(typeof(T) == typeof(byte))
                return shiftrU8(lhs, rhs);
            else if(typeof(T) == typeof(short))
                return shiftrI16(lhs, rhs);
            else if(typeof(T) == typeof(ushort))
                return shiftrU16(lhs,rhs);
            else if(typeof(T) == typeof(int))
                return shiftrI32(lhs, rhs);
            else if(typeof(T) == typeof(uint))
                return shiftrU32(lhs, rhs);
            else if(typeof(T) == typeof(long))
                return shiftrI64(lhs,rhs);
            else if(typeof(T) == typeof(ulong))
                return shiftrU64(lhs,rhs);
            else            
                throw unsupported(PrimalKinds.kind<T>());
        }           

        [MethodImpl(Inline)]
        public static ref T shiftr<T>(ref T lhs, int rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return ref shiftrI8(ref lhs, rhs);
            else if(typeof(T) == typeof(byte))
                return ref shiftrU8(ref lhs, rhs);
            else if(typeof(T) == typeof(short))
                return ref shiftrI16(ref lhs, rhs);
            else if(typeof(T) == typeof(ushort))
                return ref shiftrU16(ref lhs, rhs);
            else if(typeof(T) == typeof(int))
                return ref shiftrI32(ref lhs, rhs);
            else if(typeof(T) == typeof(uint))
                return ref shiftrU32(ref lhs, rhs);
            else if(typeof(T) == typeof(long))
                return ref shiftrI64(ref lhs, rhs);
            else if(typeof(T) == typeof(ulong))
                return ref shiftrU64(ref lhs, rhs);
            else
                throw unsupported(PrimalKinds.kind<T>());
        }           

        [MethodImpl(Inline)]
        public static Span<T> shiftr<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<int> rhs, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.shiftr(int8(lhs), rhs, int8(dst));
            else if(typeof(T) == typeof(byte))
                math.shiftr(uint8(lhs), rhs, uint8(dst));
            else if(typeof(T) == typeof(short))
                math.shiftr(int16(lhs), rhs, int16(dst));
            else if(typeof(T) == typeof(ushort))
                math.shiftr(uint16(lhs), rhs, uint16(dst));
            else if(typeof(T) == typeof(int))
                math.shiftr(int32(lhs), rhs, int32(dst));
            else if(typeof(T) == typeof(uint))
                math.shiftr(uint32(lhs), rhs, uint32(dst));
            else if(typeof(T) == typeof(long))
                math.shiftr(int64(lhs), rhs, int64(dst));
            else if(typeof(T) == typeof(ulong))
                math.shiftr(uint64(lhs), rhs, uint64(dst));
            else
                throw unsupported(PrimalKinds.kind<T>());                
            return dst;

        }

        [MethodImpl(Inline)]
        public static Span<T> shiftr<T>(ReadOnlySpan<T> lhs, int rhs, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.shiftr(int8(lhs), rhs, int8(dst));
            else if(typeof(T) == typeof(byte))
                math.shiftr(uint8(lhs), rhs, uint8(dst));
            else if(typeof(T) == typeof(short))
                math.shiftr(int16(lhs), rhs, int16(dst));
            else if(typeof(T) == typeof(ushort))
                math.shiftr(uint16(lhs), rhs, uint16(dst));
            else if(typeof(T) == typeof(int))
                math.shiftr(int32(lhs), rhs, int32(dst));
            else if(typeof(T) == typeof(uint))
                math.shiftr(uint32(lhs), rhs, uint32(dst));
            else if(typeof(T) == typeof(long))
                math.shiftr(int64(lhs), rhs, int64(dst));
            else if(typeof(T) == typeof(ulong))
                math.shiftr(uint64(lhs), rhs, uint64(dst));
            else
                throw unsupported(PrimalKinds.kind<T>());                
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<T> shiftr<T>(ReadOnlySpan<T> lhs, int rhs)
            where T : struct
            => shiftr(lhs, rhs, span<T>(lhs.Length));

        [MethodImpl(Inline)]
        public static ref Span<T> shiftr<T>(ref Span<T> lhs, int rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.shiftr(int8(lhs), rhs);
            else if(typeof(T) == typeof(byte))
                math.shiftr(uint8(lhs), rhs);
            else if(typeof(T) == typeof(short))
                math.shiftr(int16(lhs), rhs);
            else if(typeof(T) == typeof(ushort))
                math.shiftr(uint16(lhs), rhs);
            else if(typeof(T) == typeof(int))
                math.shiftr(int32(lhs), rhs);
            else if(typeof(T) == typeof(uint))
                math.shiftr(uint32(lhs), rhs);
            else if(typeof(T) == typeof(long))
                math.shiftr(int64(lhs), rhs);
            else if(typeof(T) == typeof(ulong))
                math.shiftr(uint64(lhs), rhs);
            else
                throw unsupported(PrimalKinds.kind<T>());                
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public static ref Span<T> shiftr<T>(ref Span<T> lhs, Span<int> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.shiftr(int8(lhs), rhs);
            else if(typeof(T) == typeof(byte))
                math.shiftr(uint8(lhs), rhs);
            else if(typeof(T) == typeof(short))
                math.shiftr(int16(lhs), rhs);
            else if(typeof(T) == typeof(ushort))
                math.shiftr(uint16(lhs), rhs);
            else if(typeof(T) == typeof(int))
                math.shiftr(int32(lhs), rhs);
            else if(typeof(T) == typeof(uint))
                math.shiftr(uint32(lhs), rhs);
            else if(typeof(T) == typeof(long))
                math.shiftr(int64(lhs), rhs);
            else if(typeof(T) == typeof(ulong))
                math.shiftr(uint64(lhs), rhs);
            else
                throw unsupported(PrimalKinds.kind<T>());                
            return ref lhs;

        }


        [MethodImpl(Inline)]
        static ref T shiftrI8<T>(ref T lhs, int rhs)
        {
            ref var result = ref math.shiftr(ref int8(ref lhs), rhs);
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T shiftrU8<T>(ref T lhs, int rhs)
        {
            ref var result = ref math.shiftr(ref uint8(ref lhs), rhs);
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T shiftrI16<T>(ref T lhs, int rhs)
        {
            ref var result = ref math.shiftr(ref int16(ref lhs), rhs);
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T shiftrU16<T>(ref T lhs, int rhs)
        {
            ref var result = ref math.shiftr(ref uint16(ref lhs), rhs);
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            


        [MethodImpl(Inline)]
        static ref T shiftrI32<T>(ref T lhs, int rhs)
        {
            ref var result = ref math.shiftr(ref int32(ref lhs), rhs);
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T shiftrU32<T>(ref T lhs, int rhs)
        {
            ref var result = ref math.shiftr(ref uint32(ref lhs), rhs);
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T shiftrI64<T>(ref T lhs, int rhs)
        {
            ref var result = ref math.shiftr(ref int64(ref lhs), rhs);
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T shiftrU64<T>(ref T lhs, int rhs)
        {
            ref var result = ref math.shiftr(ref uint64(ref lhs), rhs);
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static T shiftrI8<T>(T lhs, int rhs)
            => generic<T>((sbyte)(int8(lhs) >> rhs));

        [MethodImpl(Inline)]
        static T shiftrU8<T>(T lhs, int rhs)
            => generic<T>((byte)(uint8(lhs) >> rhs));

        [MethodImpl(Inline)]
        static T shiftrI16<T>(T lhs, int rhs)
            => generic<T>((short)(int16(lhs) >> rhs));

        [MethodImpl(Inline)]
        static T shiftrU16<T>(T lhs, int rhs)
            => generic<T>((ushort)(uint16(lhs) >> rhs));

        [MethodImpl(Inline)]
        static T shiftrI32<T>(T lhs, int rhs)
            => generic<T>(int32(lhs) >> rhs);
        
        [MethodImpl(Inline)]
        static T shiftrU32<T>(T lhs, int rhs)
            => generic<T>(uint32(lhs) >> rhs);

        [MethodImpl(Inline)]
        static T shiftrI64<T>(T lhs, int rhs)
            => generic<T>(int64(lhs)  >> rhs);

        [MethodImpl(Inline)]
        static T shiftrU64<T>(T lhs, int rhs)
            => generic<T>(uint64(lhs)  >> rhs);


    }

}