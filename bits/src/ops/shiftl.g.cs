//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;
    using static As;
    using static AsIn;
    
    using static Span256;
    using static Span128;

    partial class gbits
    {

        [MethodImpl(Inline), PrimalKinds(PrimalKind.Integral)]
        public static T shiftl<T>(T src, int offset)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>((sbyte)(int8(src) << offset));
            else if(typeof(T) == typeof(byte))
                return generic<T>((byte)(uint8(src) << offset));
            else if(typeof(T) == typeof(short))
                return generic<T>((short)(int16(src) << offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>((ushort)(uint16(src) << offset));
            else if(typeof(T) == typeof(int))
                return generic<T>(int32(src) << offset);
            else if(typeof(T) == typeof(uint))
                return generic<T>(uint32(src) << offset);
            else if(typeof(T) == typeof(long))
                return generic<T>(int64(src) << offset);
            else if(typeof(T) == typeof(ulong))
                return generic<T>(uint64(src) << offset);
            else            
                throw unsupported<T>();
        }           

        [MethodImpl(Inline), PrimalKinds(PrimalKind.Integral)]
        public static T shiftl<T>(T src, T offset)
            where T : struct
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>((sbyte)(int8(src) << (int)int8(offset)));
            else if(typeof(T) == typeof(byte))
                return generic<T>((byte)(uint8(src) << (int)uint8(offset)));
            else if(typeof(T) == typeof(short))
                return generic<T>((short)(int16(src) << (int)int16(offset)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>((ushort)(uint16(src) << (int)uint16(offset)));
            else if(typeof(T) == typeof(int))
                return generic<T>(int32(src) << (int)int32(offset));
            else if(typeof(T) == typeof(uint))
                return generic<T>(uint32(src) << (int)uint32(offset));
            else if(typeof(T) == typeof(long))
                return generic<T>(int64(src) << (int)int64(offset));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(uint64(src) << (int)uint64(offset));
            else            
                throw unsupported<T>();
        }           

        [MethodImpl(Inline), PrimalKinds(PrimalKind.Integral)]
        public static ref T shiftl<T>(ref T lhs, int rhs)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                Bits.shiftl(ref int8(ref lhs), rhs);
            else if (typeof(T) == typeof(byte))
                Bits.shiftl(ref uint8(ref lhs), rhs);
            else if (typeof(T) == typeof(short))
                Bits.shiftl(ref int16(ref lhs), rhs);
            else if (typeof(T) == typeof(ushort))
                Bits.shiftl(ref uint16(ref lhs), rhs);
            else if (typeof(T) == typeof(int))
                Bits.shiftl(ref int32(ref lhs), rhs);
            else if (typeof(T) == typeof(uint))
                Bits.shiftl(ref uint32(ref lhs), rhs);
            else if (typeof(T) == typeof(long))
                Bits.shiftl(ref int64(ref lhs), rhs);
            else if (typeof(T) == typeof(ulong))
                Bits.shiftl(ref uint64(ref lhs), rhs);
            else
                throw unsupported<T>();
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
        public static Vec128<S> shiftl<S,T>(in Vec128<S> lhs, in Vec128<T> shifts)
            where S : struct
            where T : struct
        {
            if(typeof(S) == typeof(int))
                return generic<S>(Bits.shiftl(in int32(in lhs), in uint32(in shifts)));
            else if(typeof(S) == typeof(uint)) 
                return generic<S>(Bits.shiftl(in uint32(in lhs), in uint32(in shifts)));
            else if(typeof(S) == typeof(long))
                return generic<S>(Bits.shiftl(in int64(lhs), in uint64(in shifts)));
            else if(typeof(S) == typeof(ulong))
                return generic<S>(Bits.shiftl(in uint64(lhs), in uint64(in shifts)));
            else
                throw unsupported<S>();
        }

        [MethodImpl(Inline)]
        public static Vec256<S> shiftl<S,T>(in Vec256<S> lhs, in Vec256<T> shifts)
            where S : struct
            where T : struct
        {
            if(typeof(S) == typeof(int))
                return generic<S>(Bits.shiftl(in int32(in lhs), in uint32(in shifts)));
            else if(typeof(S) == typeof(uint)) 
                return generic<S>(Bits.shiftl(in uint32(in lhs), in uint32(in shifts)));
            else if(typeof(S) == typeof(long))
                return generic<S>(Bits.shiftl(in int64(lhs), in uint64(in shifts)));
            else if(typeof(S) == typeof(ulong))
                return generic<S>(Bits.shiftl(in uint64(lhs), in uint64(in shifts)));
            else
                throw unsupported<S>();
        }

        [MethodImpl(Inline)]
        public static Vec128<T> shiftlw<T>(in Vec128<T> lhs, byte count)
            where T : struct
        {
            if(typeof(T) == typeof(short))
                return generic<T>(Bits.shiftlw(in int16(in lhs), count));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.shiftlw(in uint16(in lhs), count));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.shiftlw(in int32(in lhs), count));
            else if(typeof(T) == typeof(uint)) 
                return generic<T>(Bits.shiftlw(in uint32(in lhs), count));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.shiftlw(in int64(in lhs), count));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.shiftlw(in uint64(in lhs), count));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vec256<T> shiftlw<T>(in Vec256<T> lhs, byte count)
            where T : struct
        {
            if(typeof(T) == typeof(short))
                return generic<T>(Bits.shiftlw(in int16(in lhs), count));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Bits.shiftlw(in uint16(in lhs), count));
            else if(typeof(T) == typeof(int))
                return generic<T>(Bits.shiftlw(in int32(in lhs), count));
            else if(typeof(T) == typeof(uint)) 
                return generic<T>(Bits.shiftlw(in uint32(in lhs), count));
            else if(typeof(T) == typeof(long))
                return generic<T>(Bits.shiftlw(in int64(in lhs), count));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(Bits.shiftlw(in uint64(in lhs), count));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Span128<S> shiftl<S,T>(ReadOnlySpan128<S> lhs, ReadOnlySpan128<T> shifts, Span128<S> dst)
            where S : struct
            where T : struct
        {
            if(typeof(S) == typeof(int))
                int32(in lhs).ShiftL(uint32(in shifts), int32(in dst));
            else if(typeof(S) == typeof(uint)) 
                uint32(in lhs).ShiftL(uint32(in shifts), uint32(in dst));
            else if(typeof(S) == typeof(long))
                int64(in lhs).ShiftL(uint64(in shifts), int64(in dst));
            else if(typeof(S) == typeof(ulong))
                uint64(lhs).ShiftL(uint64(in shifts), uint64(in dst));
            else
                throw unsupported<S>();
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span256<T> shiftl<S,T>(ReadOnlySpan256<T> lhs,  ReadOnlySpan256<S> shifts, Span256<T> dst)
            where T : struct
            where S : struct
        {
            if(typeof(S) == typeof(int))
                int32(lhs).ShiftL(uint32(in shifts), int32(in dst));
            else if(typeof(S) == typeof(uint)) 
                uint32(lhs).ShiftL(uint32(in shifts), uint32(in dst));
            else if(typeof(S) == typeof(long))
                int64(lhs).ShiftL(uint64(in shifts), int64(in dst));
            else if(typeof(S) == typeof(ulong))
                uint64(lhs).ShiftL(uint64(in shifts), uint64(in dst));
            else
                throw unsupported<S>();
            return dst;
        }

        /// <summary>
        /// Left-Shifts each element in the source by a unform value and stores the reult in the target
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="count">The number of bits to shift left</param>
        /// <param name="dst">The target operand</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static Span128<T> shiftl<T>(ReadOnlySpan128<T> src, byte count, Span128<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(short))
                int16(src).ShiftL(count, int16(in dst));
            else if(typeof(T) == typeof(uint)) 
                uint16(src).ShiftL(count, uint16(in dst));
            if(typeof(T) == typeof(int))
                int32(src).ShiftL(count, int32(in dst));
            else if(typeof(T) == typeof(uint)) 
                uint32(src).ShiftL(count, uint32(in dst));
            else if(typeof(T) == typeof(long))
                int64(src).ShiftL(count, int64(in dst));
            else if(typeof(T) == typeof(ulong))
                uint64(src).ShiftL(count, uint64(in dst));
            else
                throw unsupported<T>();
            return dst;

        }

        /// <summary>
        /// Left-Shifts each element in the source by a unform value and stores the reult in the target
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="count">The number of bits to shift left</param>
        /// <param name="dst">The target operand</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> shiftl<T>(ReadOnlySpan256<T> src, byte count, Span256<T> dst)
            where T : struct
        {
            if(typeof(T) == typeof(short))
                int16(src).ShiftL(count, int16(in dst));
            else if(typeof(T) == typeof(uint)) 
                uint16(src).ShiftL(count, uint16(in dst));
            if(typeof(T) == typeof(int))
                int32(src).ShiftL(count, int32(in dst));
            else if(typeof(T) == typeof(uint)) 
                uint32(src).ShiftL(count, uint32(in dst));
            else if(typeof(T) == typeof(long))
                int64(src).ShiftL(count, int64(in dst));
            else if(typeof(T) == typeof(ulong))
                uint64(src).ShiftL(count, uint64(in dst));
            else
                throw unsupported<T>();
            return dst;

        }


   }
}