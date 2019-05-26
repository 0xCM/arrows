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
        public static T addI8<T>(T lhs, T rhs)        
            => generic<T>(int8(lhs) + int8(rhs));

        [MethodImpl(Inline)]
        public static T addU8<T>(T lhs, T rhs)
            => generic<T>(uint8(lhs) + uint8(rhs));

        [MethodImpl(Inline)]
        public static T addI16<T>(T lhs, T rhs)
            => generic<T>(int16(lhs) + int16(rhs));

        [MethodImpl(Inline)]
        public static T addU16<T>(T lhs, T rhs)
            => generic<T>(uint16(lhs) + uint16(rhs));

        [MethodImpl(Inline)]
        public static T addI32<T>(T lhs, T rhs)
            => generic<T>(int32(lhs) + int32(rhs));
        
        [MethodImpl(Inline)]
        public static T addU32<T>(T lhs, T rhs)
            => generic<T>(uint32(lhs) + uint32(rhs));

        [MethodImpl(Inline)]
        public static T addI64<T>(T lhs, T rhs)
            => generic<T>(int64(lhs) + int64(rhs));

        [MethodImpl(Inline)]
        public static T addU64<T>(T lhs, T rhs)
            => generic<T>(uint64(lhs) + uint64(rhs));

        [MethodImpl(Inline)]
        public static T addF32<T>(T lhs, T rhs)
            => generic<T>(float32(lhs) + float32(rhs));
            
        [MethodImpl(Inline)]
        public static T addF64<T>(T lhs, T rhs)
            => generic<T>(float64(lhs) + float64(rhs));

        [MethodImpl(Inline)]
        public static ref T addI8<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.add(ref int8(ref lhs), int8(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        public static ref T addU8<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.add(ref uint8(ref lhs), uint8(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        public static ref T addI16<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.add(ref int16(ref lhs), int16(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        public static ref T addU16<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.add(ref uint16(ref lhs), uint16(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        public static ref T addI32<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.add(ref int32(ref lhs), int32(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        public static ref T addU32<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.add(ref uint32(ref lhs), uint32(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        public static ref T addI64<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.add(ref int64(ref lhs), int64(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        public static ref T addU64<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.add(ref uint64(ref lhs), uint64(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        public static ref T addF32<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.add(ref float32(ref lhs), float32(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            

        [MethodImpl(Inline)]
        public static ref T addF64<T>(ref T lhs, T rhs)
        {
            ref var result = ref math.add(ref float64(ref lhs), float64(ref rhs));
            lhs = ref generic<T>(ref result);
            return ref lhs;
        }            


        [MethodImpl(Inline)]
        public static ref T addI8<T>(in T lhs, in T rhs, out T dst)
        {
            int8(lhs, out sbyte x);
            int8(rhs, out sbyte y);                        
            dst = generic((sbyte)(x + y), out dst);            
            return ref dst;
        }            

        [MethodImpl(Inline)]
        public static ref T addU8<T>(in T lhs, in T rhs, out T dst)
        {
            uint8(lhs, out byte x);
            uint8(rhs, out byte y);                        
            dst = generic((byte)(x + y), out dst);            
            return ref dst;
        }            

        [MethodImpl(Inline)]
        public static ref T addI16<T>(in T lhs, in T rhs, out T dst)
        {
            int16(lhs, out short x);
            int16(rhs, out short y);                        
            dst = generic((short)(x + y), out dst);            
            return ref dst;
        }            

        [MethodImpl(Inline)]
        public static ref T addU16<T>(in T lhs, in T rhs, out T dst)
        {
            uint16(lhs, out ushort x);
            uint16(rhs, out ushort y);                        
            dst = generic((ushort)(x + y), out dst);            
            return ref dst;
        }            


        [MethodImpl(Inline)]
        public static ref T addI32<T>(in T lhs, in T rhs, out T dst)
        {
            int32(lhs, out int x);
            int32(rhs, out int y);                        
            dst = generic(x + y, out dst);            
            return ref dst;
        }            

        [MethodImpl(Inline)]
        public static ref T addU32<T>(in T lhs, in T rhs, out T dst)
        {
            uint32(lhs, out uint x);
            uint32(rhs, out uint y);                        
            dst = generic(x + y, out dst);            
            return ref dst;
        }            

        [MethodImpl(Inline)]
        public static ref T addI64<T>(in T lhs, in T rhs, out T dst)
        {
            int64(lhs, out long x);
            int64(rhs, out long y);                        
            dst = generic(x + y, out dst);            
            return ref dst;
        }            

        [MethodImpl(Inline)]
        public static ref T addU64<T>(in T lhs, in T rhs, out T dst)
        {
            uint64(lhs, out ulong x);
            uint64(rhs, out ulong y);                        
            dst = generic(x + y, out dst);            
            return ref dst;
        }            

        [MethodImpl(Inline)]
        public static ref T addF32<T>(in T lhs, in T rhs, out T dst)
        {
            float32(lhs, out float x);
            float32(rhs, out float y);                        
            dst = generic(x + y, out dst);            
            return ref dst;
        }            

        [MethodImpl(Inline)]
        public static ref T addF64<T>(in T lhs, in T rhs, out T dst)
        {
            float64(lhs, out double x);
            float64(rhs, out double y);                        
            dst = generic(x + y, out dst);            
            return ref dst;
        }
    }
}