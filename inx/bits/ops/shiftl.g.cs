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
    using static AsInX;
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
                math.shiftl(ref int8(ref lhs), rhs);
            else if (typeof(T) == typeof(byte))
                math.shiftl(ref uint8(ref lhs), rhs);
            else if (typeof(T) == typeof(short))
                math.shiftl(ref int16(ref lhs), rhs);
            else if (typeof(T) == typeof(ushort))
                math.shiftl(ref uint16(ref lhs), rhs);
            else if (typeof(T) == typeof(int))
                math.shiftl(ref int32(ref lhs), rhs);
            else if (typeof(T) == typeof(uint))
                math.shiftl(ref uint32(ref lhs), rhs);
            else if (typeof(T) == typeof(long))
                math.shiftl(ref int64(ref lhs), rhs);
            else if (typeof(T) == typeof(ulong))
                math.shiftl(ref uint64(ref lhs), rhs);
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
        public static Span<T> shiftl<T>(ReadOnlySpan<T> src, ReadOnlySpan<int> offsets, Span<T> dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                int8(src).ShiftL(offsets, int8(dst));
            else if (typeof(T) == typeof(byte))
                uint8(src).ShiftL(offsets, uint8(dst));
            else if (typeof(T) == typeof(short))
                int16(src).ShiftL(offsets, int16(dst));
            else if (typeof(T) == typeof(ushort))
                uint16(src).ShiftL(offsets, uint16(dst));
            else if (typeof(T) == typeof(int))
                int32(src).ShiftL(offsets, int32(dst));
            else if (typeof(T) == typeof(uint))
                uint32(src).ShiftL(offsets, uint32(dst));
            else if (typeof(T) == typeof(long))
                int64(src).ShiftL(offsets, int64(dst));
            else if (typeof(T) == typeof(ulong))
                uint64(src).ShiftL(offsets, uint64(dst));
            else
                throw unsupported<T>();
            return dst;

        }

        [MethodImpl(Inline)]
        public static Span<T> shiftl<T>(ReadOnlySpan<T> src, int offset, Span<T> dst)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                int8(src).ShiftL(offset, int8(dst));
            else if (typeof(T) == typeof(byte))
                uint8(src).ShiftL(offset, uint8(dst));
            else if (typeof(T) == typeof(short))
                int16(src).ShiftL(offset, int16(dst));
            else if (typeof(T) == typeof(ushort))
                uint16(src).ShiftL(offset, uint16(dst));
            else if (typeof(T) == typeof(int))
                int32(src).ShiftL(offset, int32(dst));
            else if (typeof(T) == typeof(uint))
                uint32(src).ShiftL(offset, uint32(dst));
            else if (typeof(T) == typeof(long))
                int64(src).ShiftL(offset, int64(dst));
            else if (typeof(T) == typeof(ulong))
                uint64(src).ShiftL(offset, uint64(dst));
            else
                throw unsupported<T>();
            return dst;

        }

        [MethodImpl(Inline), PrimalKinds(PrimalKind.Integral)]
        public static Span<T> shiftl<T>(ReadOnlySpan<T> src, int offset)
            where T : struct
            => shiftl(src, offset, span<T>(src.Length));

        [MethodImpl(Inline), PrimalKinds(PrimalKind.Integral)]
        public static ref Span<T> shiftl<T>(ref Span<T> src, int offset)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                int8(src).ShiftL(offset);
            else if (typeof(T) == typeof(byte))
                uint8(src).ShiftL(offset);
            else if (typeof(T) == typeof(short))
                int16(src).ShiftL(offset);
            else if (typeof(T) == typeof(ushort))
                uint16(src).ShiftL(offset);
            else if (typeof(T) == typeof(int))
                int32(src).ShiftL(offset);
            else if (typeof(T) == typeof(uint))
                uint32(src).ShiftL(offset);
            else if (typeof(T) == typeof(long))
                int64(src).ShiftL(offset);
            else if (typeof(T) == typeof(ulong))
                uint64(src).ShiftL(offset);
            else
                throw unsupported<T>();
            return ref src;

        }

        [MethodImpl(Inline), PrimalKinds(PrimalKind.Integral)]
        public static ref Span<T> shiftl<T>(ref Span<T> src, Span<int> offsets)
            where T : struct
        {
            if (typeof(T) == typeof(sbyte))
                int8(src).ShiftL(offsets);
            else if (typeof(T) == typeof(byte))
                uint8(src).ShiftL(offsets);
            else if (typeof(T) == typeof(short))
                int16(src).ShiftL(offsets);
            else if (typeof(T) == typeof(ushort))
                uint16(src).ShiftL(offsets);
            else if (typeof(T) == typeof(int))
                int32(src).ShiftL(offsets);
            else if (typeof(T) == typeof(uint))
                uint32(src).ShiftL(offsets);
            else if (typeof(T) == typeof(long))
                int64(src).ShiftL(offsets);
            else if (typeof(T) == typeof(ulong))
                uint64(src).ShiftL(offsets);
            else
                throw unsupported<T>();
            return ref src;
        }
 
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
                int32(in lhs).ShiftLSpan(uint32(in shifts), int32(in dst));
            else if(typeof(S) == typeof(uint)) 
                uint32(in lhs).ShiftLSpan(uint32(in shifts), uint32(in dst));
            else if(typeof(S) == typeof(long))
                int64(in lhs).ShiftLSpan(uint64(in shifts), int64(in dst));
            else if(typeof(S) == typeof(ulong))
                uint64(lhs).ShiftLSpan(uint64(in shifts), uint64(in dst));
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
                int32(lhs).ShiftLSpan(uint32(in shifts), int32(in dst));
            else if(typeof(S) == typeof(uint)) 
                uint32(lhs).ShiftLSpan(uint32(in shifts), uint32(in dst));
            else if(typeof(S) == typeof(long))
                int64(lhs).ShiftLSpan(uint64(in shifts), int64(in dst));
            else if(typeof(S) == typeof(ulong))
                uint64(lhs).ShiftLSpan(uint64(in shifts), uint64(in dst));
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

        static Span128<short> ShiftL(this ReadOnlySpan128<short> lhs, byte count, Span128<short> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                Bits.shiftl(lhs.LoadVec128(i), count, ref dst[i]);            
            return dst;
        }

        static Span128<ushort> ShiftL(this ReadOnlySpan128<ushort> lhs, byte count, Span128<ushort> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                Bits.shiftl(lhs.LoadVec128(i), count, ref dst[i]);            
            return dst;
        }


        static Span128<int> ShiftL(this ReadOnlySpan128<int> lhs, byte count, Span128<int> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                Bits.shiftl(lhs.LoadVec128(i), count, ref dst[i]);            
            return dst;
        }

        static Span128<uint> ShiftL(this ReadOnlySpan128<uint> lhs, byte count,  Span128<uint> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                Bits.shiftl(lhs.LoadVec128(i), count, ref dst[i]);            
            return dst;
        }

        static Span128<long> ShiftL(this ReadOnlySpan128<long> lhs, byte count, Span128<long> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                Bits.shiftl(lhs.LoadVec128(i), count, ref dst[i]);            
            return dst;
        }

        static Span128<ulong> ShiftL(this ReadOnlySpan128<ulong> lhs, byte count, Span128<ulong> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                Bits.shiftl(lhs.LoadVec128(i), count, ref dst[i]);            
            return dst;
        }

        static Span256<short> ShiftL(this ReadOnlySpan256<short> lhs, byte count, Span256<short> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                Bits.shiftl(lhs.LoadVec256(i), count, ref dst[i]);            
            return dst;
        }

        static Span256<ushort> ShiftL(this ReadOnlySpan256<ushort> lhs, byte count, Span256<ushort> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                Bits.shiftl(lhs.LoadVec256(i), count, ref dst[i]);            
            return dst;
        }

        static Span256<int> ShiftL(this ReadOnlySpan256<int> lhs, byte count, Span256<int> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                Bits.shiftl(lhs.LoadVec256(i), count, ref dst[i]);            
            return dst;
        }

        static Span256<uint> ShiftL(this ReadOnlySpan256<uint> lhs, byte count, Span256<uint> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                Bits.shiftl(lhs.LoadVec256(i), count, ref dst[i]);            
            return dst;
        }

        static Span256<long> ShiftL(this ReadOnlySpan256<long> lhs, byte count, Span256<long> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                Bits.shiftl(lhs.LoadVec256(i), count, ref dst[i]);            
            return dst;
        }

        static Span256<ulong> ShiftL(this ReadOnlySpan256<ulong> lhs, byte count, Span256<ulong> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                Bits.shiftl(lhs.LoadVec256(i), count, ref dst[i]);            
            return dst;
        }

        static Span128<int> ShiftLSpan(this ReadOnlySpan128<int> lhs, in ReadOnlySpan128<uint> shifts, in Span128<int> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,shifts);
            for(var i =0; i < cells; i += width)
                vstore(Bits.shiftl(lhs.LoadVec128(i), shifts.LoadVec128(i)), ref dst[i]);            
            return dst;
        }

        static Span128<uint> ShiftLSpan(this ReadOnlySpan128<uint> lhs, in ReadOnlySpan128<uint> shifts, in Span128<uint> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,shifts);
            for(var i =0; i < cells; i += width)
                vstore(Bits.shiftl(lhs.LoadVec128(i),shifts.LoadVec128(i)), ref dst[i]);            
            return dst;
        }

        static Span128<long> ShiftLSpan(this ReadOnlySpan128<long> lhs, in ReadOnlySpan128<ulong> shifts, in Span128<long> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,shifts);
            for(var i =0; i < cells; i += width)
                vstore(Bits.shiftl(lhs.LoadVec128(i),shifts.LoadVec128(i)), ref dst[i]);            
            return dst;
        }

        static Span128<ulong> ShiftLSpan(this ReadOnlySpan128<ulong> lhs, in ReadOnlySpan128<ulong> shifts, in Span128<ulong> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,shifts);
            for(var i =0; i < cells; i += width)
                vstore(Bits.shiftl(lhs.LoadVec128(i),shifts.LoadVec128(i)), ref dst[i]);            
            return dst;
        }

        static Span256<int> ShiftLSpan(this ReadOnlySpan256<int> lhs, in ReadOnlySpan256<uint> shifts, in Span256<int> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,shifts);
            for(var i =0; i < cells; i += width)
                vstore(Bits.shiftl(lhs.LoadVec256(i),shifts.LoadVec256(i)), ref dst[i]);            
            return dst;            
        }

        static Span256<uint> ShiftLSpan(this ReadOnlySpan256<uint> lhs, in ReadOnlySpan256<uint> shifts, in Span256<uint> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,shifts);
            for(var i =0; i < cells; i += width)
                vstore(Bits.shiftl(lhs.LoadVec256(i),shifts.LoadVec256(i)), ref dst[i]);            
            return dst;            
        }

        static Span256<long> ShiftLSpan(this ReadOnlySpan256<long> lhs, in ReadOnlySpan256<ulong> shifts, in Span256<long> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,shifts);
            for(var i =0; i < cells; i += width)
                vstore(Bits.shiftl(lhs.LoadVec256(i),shifts.LoadVec256(i)), ref dst[i]);            
            return dst;            
        }

        static Span256<ulong> ShiftLSpan(this ReadOnlySpan256<ulong> lhs, in ReadOnlySpan256<ulong> shifts, in Span256<ulong> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,shifts);
            for(var i =0; i < cells; i += width)
                vstore(Bits.shiftl(lhs.LoadVec256(i),shifts.LoadVec256(i)), ref dst[i]);            
            return dst;            
       }

        static Span<sbyte> ShiftL(this ReadOnlySpan<sbyte> lhs, ReadOnlySpan<int> rhs, Span<sbyte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftl(lhs[i], rhs[i]);
            return dst;                
        }

        static Span<byte> ShiftL(this ReadOnlySpan<byte> lhs, ReadOnlySpan<int> rhs, Span<byte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftl(lhs[i], rhs[i]);
            return dst;                
        }

        static Span<short> ShiftL(this ReadOnlySpan<short> lhs, ReadOnlySpan<int> rhs, Span<short> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftl(lhs[i], rhs[i]);
            return dst;                
        }

        static Span<ushort> ShiftL(this ReadOnlySpan<ushort> lhs, ReadOnlySpan<int> rhs, Span<ushort> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftl(lhs[i], rhs[i]);
            return dst;                
        }

        static Span<int> ShiftL(this ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<int> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftl(lhs[i], rhs[i]);
            return dst;                
        }

        static Span<uint> ShiftL(this ReadOnlySpan<uint> lhs, ReadOnlySpan<int> rhs, Span<uint> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftl(lhs[i], rhs[i]);
            return dst;                
        }

        static Span<long> ShiftL(this ReadOnlySpan<long> lhs, ReadOnlySpan<int> rhs, Span<long> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftl(lhs[i], rhs[i]);
            return dst;                
        }

        static Span<ulong> ShiftL(this ReadOnlySpan<ulong> lhs, ReadOnlySpan<int> rhs, Span<ulong> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftl(lhs[i], rhs[i]);
            return dst;                
        }
 
        static Span<sbyte> ShiftL(this ReadOnlySpan<sbyte> lhs, int rhs, Span<sbyte> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftl(lhs[i], rhs);
            return dst;                
        }

        static Span<byte> ShiftL(this ReadOnlySpan<byte> lhs, int rhs, Span<byte> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftl(lhs[i], rhs);
            return dst;                
        }

        static Span<short> ShiftL(this ReadOnlySpan<short> lhs, int rhs, Span<short> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftl(lhs[i], rhs);
            return dst;                
        }

        static Span<ushort> ShiftL(this ReadOnlySpan<ushort> lhs, int rhs, Span<ushort> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftl(lhs[i], rhs);
            return dst;                
        }

        static Span<int> ShiftL(this ReadOnlySpan<int> lhs, int rhs, Span<int> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftl(lhs[i], rhs);
            return dst;                
        }

        static Span<uint> ShiftL(this ReadOnlySpan<uint> lhs, int rhs, Span<uint> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftl(lhs[i], rhs);
            return dst;                
        }

        static Span<long> ShiftL(this ReadOnlySpan<long> lhs, int rhs, Span<long> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftl(lhs[i], rhs);
            return dst;                
        }

        static Span<ulong> ShiftL(this ReadOnlySpan<ulong> lhs, int rhs, Span<ulong> dst)
        {            
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftl(lhs[i], rhs);
            return dst;                
        }

        static Span<sbyte> ShiftL(this Span<sbyte> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] <<= rhs;
            return lhs;                
        }

        static Span<byte> ShiftL(this Span<byte> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] <<= rhs;
            return lhs;                
        }

        static Span<short> ShiftL(this Span<short> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] <<= rhs;
            return lhs;                
        }

        static Span<ushort> ShiftL(this Span<ushort> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] <<= rhs;
            return lhs;                
        }

        static Span<int> ShiftL(this Span<int> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] <<= rhs;
            return lhs;                
        }

        static Span<uint> ShiftL(this Span<uint> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] <<= rhs;
            return lhs;                
        }

        static Span<long> ShiftL(this Span<long> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] <<= rhs;
            return lhs;                
        }

        static Span<ulong> ShiftL(this Span<ulong> lhs, int rhs)
        {            
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] <<= rhs;
            return lhs;                
        }

        static Span<sbyte> ShiftL(this Span<sbyte> lhs, ReadOnlySpan<int> rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] <<= rhs[i];
            return lhs;                
        }

        static Span<byte> ShiftL(this Span<byte> lhs, ReadOnlySpan<int> rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] <<= rhs[i];
            return lhs;                
        }

        static Span<short> ShiftL(this Span<short> lhs, ReadOnlySpan<int> rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] <<= rhs[i];
            return lhs;                
        }

        static Span<ushort> ShiftL(this Span<ushort> lhs, ReadOnlySpan<int> rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] <<= rhs[i];
            return lhs;                
        }

        static Span<int> ShiftL(this Span<int> lhs, ReadOnlySpan<int> rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] <<= rhs[i];
            return lhs;                
        }

        static Span<uint> ShiftL(this Span<uint> lhs, ReadOnlySpan<int> rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] <<= rhs[i];
            return lhs;                
        }

        static Span<long> ShiftL(this Span<long> lhs, ReadOnlySpan<int> rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] <<= rhs[i];
            return lhs;                
        }

        static Span<ulong> ShiftL(this Span<ulong> lhs, ReadOnlySpan<int> rhs)
        {            
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] <<= rhs[i];
            return lhs;                
        }

   }
}