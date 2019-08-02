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
    using static Span256;
    using static Span128;
    using static As;
    using static AsInX;

    partial class dinxx
    {

        [MethodImpl(Inline)]
        public static Span128<S> ShiftL<S,T>(this ReadOnlySpan128<S> lhs, ReadOnlySpan128<T> shifts, Span128<S> dst)
            where S : struct
            where T : struct
        {
            if(typeof(S) == typeof(int))
                shiftl(int32(in lhs), uint32(in shifts), int32(in dst));
            else if(typeof(S) == typeof(uint)) 
                shiftl(uint32(in lhs), uint32(in shifts), uint32(in dst));
            else if(typeof(S) == typeof(long))
                shiftl(int64(in lhs), uint64(in shifts), int64(in dst));
            else if(typeof(S) == typeof(ulong))
                shiftl(uint64(in lhs), uint64(in shifts), uint64(in dst));
            else
                throw unsupported<S>();
            return dst;
        }

        public static Span256<T> ShiftL<S,T>(this ReadOnlySpan256<T> lhs,  ReadOnlySpan256<S> shifts, Span256<T> dst)
            where T : struct
            where S : struct
        {
            if(typeof(S) == typeof(int))
                shiftl(int32(in lhs), uint32(in shifts), int32(in dst));
            else if(typeof(S) == typeof(uint)) 
                shiftl(uint32(in lhs), uint32(in shifts), uint32(in dst));
            else if(typeof(S) == typeof(long))
                shiftl(int64(in lhs), uint64(in shifts), int64(in dst));
            else if(typeof(S) == typeof(ulong))
                shiftl(uint64(in lhs), uint64(in shifts), uint64(in dst));
            else
                throw unsupported<S>();
            return dst;
        }

        [MethodImpl(Inline)]
        public static UInt128 ShiftRW(this UInt128 src, byte offset)
            => Bits.shiftrw(src.ToVec128(), offset).ToUInt128();

        [MethodImpl(Inline)]
        public static UInt128 ShiftLW(this UInt128 src, byte offset)
            => Bits.shiftlw(src.ToVec128(), offset).ToUInt128();

        static Span128<int> shiftl(in ReadOnlySpan128<int> lhs, in ReadOnlySpan128<uint> shifts, in Span128<int> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,shifts);
            for(var i =0; i < cells; i += width)
                vstore(Bits.shiftl(lhs.LoadVec128(i), shifts.LoadVec128(i)), ref dst[i]);            
            return dst;
        }

        static Span128<uint> shiftl(in ReadOnlySpan128<uint> lhs, in ReadOnlySpan128<uint> shifts, in Span128<uint> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,shifts);
            for(var i =0; i < cells; i += width)
                vstore(Bits.shiftl(lhs.LoadVec128(i),shifts.LoadVec128(i)), ref dst[i]);            
            return dst;
        }

        static Span128<long> shiftl(in ReadOnlySpan128<long> lhs, in ReadOnlySpan128<ulong> shifts, in Span128<long> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,shifts);
            for(var i =0; i < cells; i += width)
                vstore(Bits.shiftl(lhs.LoadVec128(i),shifts.LoadVec128(i)), ref dst[i]);            
            return dst;
        }

        static Span128<ulong> shiftl(in ReadOnlySpan128<ulong> lhs, in ReadOnlySpan128<ulong> shifts, in Span128<ulong> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,shifts);
            for(var i =0; i < cells; i += width)
                vstore(Bits.shiftl(lhs.LoadVec128(i),shifts.LoadVec128(i)), ref dst[i]);            
            return dst;
        }

        static Span256<int> shiftl(in ReadOnlySpan256<int> lhs, in ReadOnlySpan256<uint> shifts, in Span256<int> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,shifts);
            for(var i =0; i < cells; i += width)
                vstore(Bits.shiftl(lhs.LoadVec256(i),shifts.LoadVec256(i)), ref dst[i]);            
            return dst;            
        }

        static Span256<uint> shiftl(in ReadOnlySpan256<uint> lhs, in ReadOnlySpan256<uint> shifts, in Span256<uint> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,shifts);
            for(var i =0; i < cells; i += width)
                vstore(Bits.shiftl(lhs.LoadVec256(i),shifts.LoadVec256(i)), ref dst[i]);            
            return dst;            
        }

        static Span256<long> shiftl(in ReadOnlySpan256<long> lhs, in ReadOnlySpan256<ulong> shifts, in Span256<long> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,shifts);
            for(var i =0; i < cells; i += width)
                vstore(Bits.shiftl(lhs.LoadVec256(i),shifts.LoadVec256(i)), ref dst[i]);            
            return dst;            
        }

        static Span256<ulong> shiftl(in ReadOnlySpan256<ulong> lhs, in ReadOnlySpan256<ulong> shifts, in Span256<ulong> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,shifts);
            for(var i =0; i < cells; i += width)
                vstore(Bits.shiftl(lhs.LoadVec256(i),shifts.LoadVec256(i)), ref dst[i]);            
            return dst;            
       }
 
        public static Span128<short> ShiftL(this ReadOnlySpan128<short> lhs, byte count, Span128<short> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                Bits.shiftl(lhs.LoadVec128(i), count, ref dst[i]);            
            return dst;
        }

        public static Span128<ushort> ShiftL(this ReadOnlySpan128<ushort> lhs, byte count, Span128<ushort> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                Bits.shiftl(lhs.LoadVec128(i), count, ref dst[i]);            
            return dst;
        }

        public static Span128<int> ShiftL(this ReadOnlySpan128<int> lhs, byte count, Span128<int> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                Bits.shiftl(lhs.LoadVec128(i), count, ref dst[i]);            
            return dst;
        }

        public static Span128<uint> ShiftL(this ReadOnlySpan128<uint> lhs, byte count,  Span128<uint> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                Bits.shiftl(lhs.LoadVec128(i), count, ref dst[i]);            
            return dst;
        }

        public static Span128<long> ShiftL(this ReadOnlySpan128<long> lhs, byte count, Span128<long> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                Bits.shiftl(lhs.LoadVec128(i), count, ref dst[i]);            
            return dst;
        }

        public static Span128<ulong> ShiftL(this ReadOnlySpan128<ulong> lhs, byte count, Span128<ulong> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                Bits.shiftl(lhs.LoadVec128(i), count, ref dst[i]);            
            return dst;
        }

        public static Span256<short> ShiftL(this ReadOnlySpan256<short> lhs, byte count, Span256<short> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                Bits.shiftl(lhs.LoadVec256(i), count, ref dst[i]);            
            return dst;
        }

        public static Span256<ushort> ShiftL(this ReadOnlySpan256<ushort> lhs, byte count, Span256<ushort> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                Bits.shiftl(lhs.LoadVec256(i), count, ref dst[i]);            
            return dst;
        }

        public static Span256<int> ShiftL(this ReadOnlySpan256<int> lhs, byte count, Span256<int> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                Bits.shiftl(lhs.LoadVec256(i), count, ref dst[i]);            
            return dst;
        }

        public static Span256<uint> ShiftL(this ReadOnlySpan256<uint> lhs, byte count, Span256<uint> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                Bits.shiftl(lhs.LoadVec256(i), count, ref dst[i]);            
            return dst;
        }

        public static Span256<long> ShiftL(this ReadOnlySpan256<long> lhs, byte count, Span256<long> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                Bits.shiftl(lhs.LoadVec256(i), count, ref dst[i]);            
            return dst;
        }

        public static Span256<ulong> ShiftL(this ReadOnlySpan256<ulong> lhs, byte count, Span256<ulong> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                Bits.shiftl(lhs.LoadVec256(i), count, ref dst[i]);            
            return dst;
        }

 
    }
}