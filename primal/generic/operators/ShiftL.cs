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
        public static T shiftl<T>(T lhs, int rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return shiftlI8(lhs,rhs);
            else if(typeof(T) == typeof(byte))
                return shiftlU8(lhs, rhs);
            else if(typeof(T) == typeof(short))
                return shiftlI16(lhs, rhs);
            else if(typeof(T) == typeof(ushort))
                return shiftlU16(lhs,rhs);
            else if(typeof(T) == typeof(int))
                return shiftlI32(lhs, rhs);
            else if(typeof(T) == typeof(uint))
                return shiftlU32(lhs, rhs);
            else if(typeof(T) == typeof(long))
                return shiftlI64(lhs,rhs);
            else if(typeof(T) == typeof(ulong))
                return shiftlU64(lhs,rhs);
            else            
                throw unsupported(PrimalKinds.kind<T>());
        }           

        [MethodImpl(Inline)]
        public static ref T shiftl<T>(ref T lhs, int rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return ref shiftlI8(ref lhs, rhs);
            else if(typeof(T) == typeof(byte))
                return ref shiftlU8(ref lhs, rhs);
            else if(typeof(T) == typeof(short))
                return ref shiftlI16(ref lhs, rhs);
            else if(typeof(T) == typeof(ushort))
                return ref shiftlU16(ref lhs, rhs);
            else if(typeof(T) == typeof(int))
                return ref shiftlI32(ref lhs, rhs);
            else if(typeof(T) == typeof(uint))
                return ref shiftlU32(ref lhs, rhs);
            else if(typeof(T) == typeof(long))
                return ref shiftlI64(ref lhs, rhs);
            else if(typeof(T) == typeof(ulong))
                return ref shiftlU64(ref lhs, rhs);
            else
                throw unsupported(PrimalKinds.kind<T>());
        }           


        [MethodImpl(Inline)]
        public static Span<T> shiftl<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<int> rhs, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.shiftl(int8(lhs), rhs, int8(dst));
            else if(typeof(T) == typeof(byte))
                math.shiftl(uint8(lhs), rhs, uint8(dst));
            else if(typeof(T) == typeof(short))
                math.shiftl(int16(lhs), rhs, int16(dst));
            else if(typeof(T) == typeof(ushort))
                math.shiftl(uint16(lhs), rhs, uint16(dst));
            else if(typeof(T) == typeof(int))
                math.shiftl(int32(lhs), rhs, int32(dst));
            else if(typeof(T) == typeof(uint))
                math.shiftl(uint32(lhs), rhs, uint32(dst));
            else if(typeof(T) == typeof(long))
                math.shiftl(int64(lhs), rhs, int64(dst));
            else if(typeof(T) == typeof(ulong))
                math.shiftl(uint64(lhs), rhs, uint64(dst));
            else
                throw unsupported(PrimalKinds.kind<T>());                
            return dst;

        }
        
        [MethodImpl(Inline)]
        public static Span<T> shiftl<T>(ReadOnlySpan<T> lhs, int rhs, Span<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.shiftl(int8(lhs), rhs, int8(dst));
            else if(typeof(T) == typeof(byte))
                math.shiftl(uint8(lhs), rhs, uint8(dst));
            else if(typeof(T) == typeof(short))
                math.shiftl(int16(lhs), rhs, int16(dst));
            else if(typeof(T) == typeof(ushort))
                math.shiftl(uint16(lhs), rhs, uint16(dst));
            else if(typeof(T) == typeof(int))
                math.shiftl(int32(lhs), rhs, int32(dst));
            else if(typeof(T) == typeof(uint))
                math.shiftl(uint32(lhs), rhs, uint32(dst));
            else if(typeof(T) == typeof(long))
                math.shiftl(int64(lhs), rhs, int64(dst));
            else if(typeof(T) == typeof(ulong))
                math.shiftl(uint64(lhs), rhs, uint64(dst));
            else
                throw unsupported(PrimalKinds.kind<T>());                
            return dst;

        }

        [MethodImpl(Inline)]
        public static Span<T> shiftl<T>(ReadOnlySpan<T> lhs, int rhs)
            where T : struct
            => shiftl(lhs, rhs, span<T>(lhs.Length));

        [MethodImpl(Inline)]
        public static ref Span<T> shiftl<T>(ref Span<T> lhs, int rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.shiftl(int8(lhs), rhs);
            else if(typeof(T) == typeof(byte))
                math.shiftl(uint8(lhs), rhs);
            else if(typeof(T) == typeof(short))
                math.shiftl(int16(lhs), rhs);
            else if(typeof(T) == typeof(ushort))
                math.shiftl(uint16(lhs), rhs);
            else if(typeof(T) == typeof(int))
                math.shiftl(int32(lhs), rhs);
            else if(typeof(T) == typeof(uint))
                math.shiftl(uint32(lhs), rhs);
            else if(typeof(T) == typeof(long))
                math.shiftl(int64(lhs), rhs);
            else if(typeof(T) == typeof(ulong))
                math.shiftl(uint64(lhs), rhs);
            else
                throw unsupported(PrimalKinds.kind<T>());                
            return ref lhs;

        }

        [MethodImpl(Inline)]
        public static ref Span<T> shiftl<T>(ref Span<T> lhs, Span<int> rhs)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                math.shiftl(int8(lhs), rhs);
            else if(typeof(T) == typeof(byte))
                math.shiftl(uint8(lhs), rhs);
            else if(typeof(T) == typeof(short))
                math.shiftl(int16(lhs), rhs);
            else if(typeof(T) == typeof(ushort))
                math.shiftl(uint16(lhs), rhs);
            else if(typeof(T) == typeof(int))
                math.shiftl(int32(lhs), rhs);
            else if(typeof(T) == typeof(uint))
                math.shiftl(uint32(lhs), rhs);
            else if(typeof(T) == typeof(long))
                math.shiftl(int64(lhs), rhs);
            else if(typeof(T) == typeof(ulong))
                math.shiftl(uint64(lhs), rhs);
            else
                throw unsupported(PrimalKinds.kind<T>());                
            return ref lhs;

        }


        [MethodImpl(Inline)]
        public static T shiftl<T>(in T lhs, in uint rhs)
            where T : struct
                => shiftl(lhs, (int)rhs);
        
        [MethodImpl(Inline)]
        public static T shiftl<T>(in T lhs, in ulong rhs)
            where T : struct
                => shiftl(lhs, (int)rhs);

        [MethodImpl(Inline)]
        static T shiftlI8<T>(in T lhs, in int rhs)
            => AsIn.generic<T>((sbyte)(AsIn.int8(in lhs)) << rhs);            

        [MethodImpl(Inline)]
        static T shiftlU8<T>(in T lhs, in int rhs)
            => generic<T>((byte)(uint8(lhs) << rhs));

        [MethodImpl(Inline)]
        static T shiftlI16<T>(in T lhs, in int rhs)
            => generic<T>((short)(int16(lhs) << rhs));

        [MethodImpl(Inline)]
        static T shiftlU16<T>(in T lhs, in int rhs)
            => generic<T>((ushort)(uint16(lhs) << rhs));

        [MethodImpl(Inline)]
        static T shiftlI32<T>(in T lhs, in int rhs)
            => generic<T>(int32(lhs) << rhs);
        
        [MethodImpl(Inline)]
        static T shiftlU32<T>(in T lhs, in int rhs)
            => generic<T>(uint32(lhs) << rhs);

        [MethodImpl(Inline)]
        static T shiftlI64<T>(in T lhs, in int rhs)
            => generic<T>(int64(lhs)  << rhs);

        [MethodImpl(Inline)]
        static T shiftlU64<T>(in T lhs, in int rhs)
            => generic<T>(uint64(lhs)  << rhs);

        [MethodImpl(Inline)]
        static ref T shiftlI8<T>(ref T lhs, int rhs)
        {
            ref var result = ref math.shiftl(ref int8(ref lhs), rhs);
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T shiftlU8<T>(ref T lhs, int rhs)
        {
            ref var result = ref math.shiftl(ref uint8(ref lhs), rhs);
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T shiftlI16<T>(ref T lhs, int rhs)
        {
            ref var result = ref math.shiftl(ref int16(ref lhs), rhs);
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T shiftlU16<T>(ref T lhs, int rhs)
        {
            ref var result = ref math.shiftl(ref uint16(ref lhs), rhs);
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T shiftlI32<T>(ref T lhs, int rhs)
        {
            ref var result = ref math.shiftl(ref int32(ref lhs), rhs);
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T shiftlU32<T>(ref T lhs, int rhs)
        {
            ref var result = ref math.shiftl(ref uint32(ref lhs), rhs);
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T shiftlI64<T>(ref T lhs, int rhs)
        {
            ref var result = ref math.shiftl(ref int64(ref lhs), rhs);
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        static ref T shiftlU64<T>(ref T lhs, int rhs)
        {
            ref var result = ref math.shiftl(ref uint64(ref lhs), rhs);
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            




    }

}