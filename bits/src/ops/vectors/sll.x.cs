//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx2;
    
    using static zfunc;
    using static As;
    
    partial class BitsX
    {
        /// <summary>
        /// Left-Shifts each element in the source by a unform value and stores the reult in the target
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <param name="count">The number of bits to shift left</param>
        /// <param name="dst">The target operand</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static Span128<T> ShiftL<T>(this ReadOnlySpan128<T> src, byte count, Span128<T> dst)
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

        public static Span256<T> ShiftL<T>(this ReadOnlySpan256<T> lhs, in ReadOnlySpan256<T> shifts, in Span256<T> dst)
            where T : struct
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,shifts);
            for(var i =0; i < cells; i += width)
                ginx.store(gbits.sllv(lhs.LoadVec256(i),shifts.LoadVec256(i)), ref dst[i]);            
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
        public static Span256<T> ShiftL<T>(this ReadOnlySpan256<T> src, byte count, Span256<T> dst)
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

        static Span128<short> ShiftL(this ReadOnlySpan128<short> lhs, byte offset, Span128<short> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                vstore(Bits.sll(lhs.LoadVec128(i), offset), ref dst[i]);            
            return dst;
        }

        static Span128<ushort> ShiftL(this ReadOnlySpan128<ushort> lhs, byte offset, Span128<ushort> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                vstore(Bits.sll(lhs.LoadVec128(i), offset), ref dst[i]);            
            return dst;
        }


        static Span128<int> ShiftL(this ReadOnlySpan128<int> lhs, byte offset, Span128<int> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                vstore(Bits.sll(lhs.LoadVec128(i), offset), ref dst[i]);            
            return dst;
        }

        static Span128<uint> ShiftL(this ReadOnlySpan128<uint> lhs, byte offset,  Span128<uint> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                vstore(Bits.sll(lhs.LoadVec128(i), offset), ref dst[i]);            
            return dst;
        }

        static Span128<long> ShiftL(this ReadOnlySpan128<long> lhs, byte offset, Span128<long> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                vstore(Bits.sll(lhs.LoadVec128(i), offset), ref dst[i]);            
            return dst;
        }

        static Span128<ulong> ShiftL(this ReadOnlySpan128<ulong> lhs, byte offset, Span128<ulong> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                vstore(Bits.sll(lhs.LoadVec128(i), offset), ref dst[i]);            
            return dst;
        }

        static Span256<short> ShiftL(this ReadOnlySpan256<short> lhs, byte offset, Span256<short> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                vstore(Bits.sll(lhs.LoadVec256(i), offset), ref dst[i]);            
            return dst;
        }

        static Span256<ushort> ShiftL(this ReadOnlySpan256<ushort> lhs, byte offset, Span256<ushort> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                vstore(Bits.sll(lhs.LoadVec256(i), offset), ref dst[i]);            
            return dst;
        }

        static Span256<int> ShiftL(this ReadOnlySpan256<int> lhs, byte offset, Span256<int> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                vstore(Bits.sll(lhs.LoadVec256(i), offset), ref dst[i]);            
            return dst;
        }

        static Span256<uint> ShiftL(this ReadOnlySpan256<uint> lhs, byte offset, Span256<uint> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                vstore(Bits.sll(lhs.LoadVec256(i), offset), ref dst[i]);            
            return dst;
        }

        static Span256<long> ShiftL(this ReadOnlySpan256<long> lhs, byte offset, Span256<long> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                vstore(Bits.sll(lhs.LoadVec256(i), offset), ref dst[i]);            
            return dst;
        }

        static Span256<ulong> ShiftL(this ReadOnlySpan256<ulong> lhs, byte offset, Span256<ulong> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                vstore(Bits.sll(lhs.LoadVec256(i), offset), ref dst[i]);            
            return dst;
        }

    }
}