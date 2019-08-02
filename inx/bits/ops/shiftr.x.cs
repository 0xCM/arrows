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

    using static System.Runtime.Intrinsics.X86.Sse;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Avx;

    using static zfunc;
    using static Span256;
    using static Span128;
    using static As;

    partial class BitX
    {
        public static Span<sbyte> ShiftR(this ReadOnlySpan<sbyte> lhs, ReadOnlySpan<int> rhs, Span<sbyte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftr(lhs[i], rhs[i]);
            return dst;                
        }

        public static Span<byte> ShiftR(this ReadOnlySpan<byte> lhs, ReadOnlySpan<int> rhs, Span<byte> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftr(lhs[i], rhs[i]);
            return dst;                
        }

        public static Span<short> ShiftR(this ReadOnlySpan<short> lhs, ReadOnlySpan<int> rhs, Span<short> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftr(lhs[i], rhs[i]);
            return dst;                
        }

        public static Span<ushort> ShiftR(this ReadOnlySpan<ushort> lhs, ReadOnlySpan<int> rhs, Span<ushort> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftr(lhs[i], rhs[i]);
            return dst;                
        }

        public static Span<int> ShiftR(this ReadOnlySpan<int> lhs, ReadOnlySpan<int> rhs, Span<int> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftr(lhs[i], rhs[i]);
            return dst;                
        }

        public static Span<uint> ShiftR(this ReadOnlySpan<uint> lhs, ReadOnlySpan<int> rhs, Span<uint> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftr(lhs[i], rhs[i]);
            return dst;                
        }

        public static Span<long> ShiftR(this ReadOnlySpan<long> lhs, ReadOnlySpan<int> rhs, Span<long> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftr(lhs[i], rhs[i]);
            return dst;                
        }

        public static Span<ulong> ShiftR(this ReadOnlySpan<ulong> lhs, ReadOnlySpan<int> rhs, Span<ulong> dst)
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftr(lhs[i], rhs[i]);
            return dst;                
        }
 
         public static Span<sbyte> ShiftR(this ReadOnlySpan<sbyte> lhs, int rhs, Span<sbyte> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftr(lhs[i], rhs);
            return dst;                
        }

        public static Span<byte> ShiftR(this ReadOnlySpan<byte> lhs, int rhs, Span<byte> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftr(lhs[i], rhs);
            return dst;                
        }

        public static Span<short> ShiftR(this ReadOnlySpan<short> lhs, int rhs, Span<short> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftr(lhs[i], rhs);
            return dst;                
        }

        public static Span<ushort> ShiftR(this ReadOnlySpan<ushort> lhs, int rhs, Span<ushort> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftr(lhs[i], rhs);
            return dst;                
        }

        public static Span<int> ShiftR(this ReadOnlySpan<int> lhs, int rhs, Span<int> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftr(lhs[i], rhs);
            return dst;                
        }

        public static Span<uint> ShiftR(this ReadOnlySpan<uint> lhs, int rhs, Span<uint> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftr(lhs[i], rhs);
            return dst;                
        }

        public static Span<long> ShiftR(this ReadOnlySpan<long> lhs, int rhs, Span<long> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftr(lhs[i], rhs);
            return dst;                
        }

        public static Span<ulong> ShiftR(this ReadOnlySpan<ulong> lhs, int rhs, Span<ulong> dst)
        {
            var len = length(lhs,dst);
            for(var i = 0; i< len; i++)
                dst[i] = math.shiftr(lhs[i], rhs);
            return dst;                
        }


        public static Span<sbyte> ShiftR(this Span<sbyte> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs;
            return lhs;                
        }

        public static Span<byte> ShiftR(this Span<byte> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs;
            return lhs;                
        }

        public static Span<short> ShiftR(this Span<short> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs;
            return lhs;                
        }

        public static Span<ushort> ShiftR(this Span<ushort> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs;
            return lhs;                
        }

        public static Span<int> ShiftR(this Span<int> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs;
            return lhs;                
        }

        public static Span<uint> ShiftR(this Span<uint> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs;
            return lhs;                
        }

        public static Span<long> ShiftR(this Span<long> lhs, int rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs;
            return lhs;                
        }

        public static Span<ulong> ShiftR(this Span<ulong> lhs, int rhs)
        {            
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs;
            return lhs;                
        }

 
         public static Span<sbyte> ShiftR(this Span<sbyte> lhs, ReadOnlySpan<int> rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs[i];
            return lhs;                
        }

        public static Span<byte> ShiftR(this Span<byte> lhs, ReadOnlySpan<int> rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs[i];
            return lhs;                
        }

        public static Span<short> ShiftR(this Span<short> lhs, ReadOnlySpan<int> rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs[i];
            return lhs;                
        }

        public static Span<ushort> ShiftR(this Span<ushort> lhs, ReadOnlySpan<int> rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs[i];
            return lhs;                
        }

        public static Span<int> ShiftR(this Span<int> lhs, ReadOnlySpan<int> rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs[i];
            return lhs;                
        }

        public static Span<uint> ShiftR(this Span<uint> lhs, ReadOnlySpan<int> rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs[i];
            return lhs;                
        }

        public static Span<long> ShiftR(this Span<long> lhs, ReadOnlySpan<int> rhs)
        {
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs[i];
            return lhs;                
        }

        public static Span<ulong> ShiftR(this Span<ulong> lhs, ReadOnlySpan<int> rhs)
        {            
            for(var i = 0; i< lhs.Length; i++)
                lhs[i] >>= rhs[i];
            return lhs;                
        }


        public static Span128<int> ShiftR(this ReadOnlySpan128<int> lhs, in ReadOnlySpan128<uint> rhs, in Span128<int> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                Bits.shiftr(lhs.LoadVec128(i), rhs.LoadVec128(i), ref dst[i]);            
            return dst;            
        }

        public static Span128<uint> ShiftR(this ReadOnlySpan128<uint> lhs, in ReadOnlySpan128<uint> rhs, in  Span128<uint> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                Bits.shiftr(lhs.LoadVec128(i), rhs.LoadVec128(i), ref dst[i]);            
            return dst;            
        }

        public static Span128<long> ShiftR(this ReadOnlySpan128<long> lhs, in ReadOnlySpan128<ulong> rhs, in Span128<long> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                Bits.shiftr(lhs.LoadVec128(i), rhs.LoadVec128(i), ref dst[i]);            
            return dst;            
        }

        public static Span128<ulong> ShiftR(this ReadOnlySpan128<ulong> lhs, in ReadOnlySpan128<ulong> rhs, in Span128<ulong> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                Bits.shiftr(lhs.LoadVec128(i), rhs.LoadVec128(i), ref dst[i]);            
            return dst;            
        }

        public static Span256<int> ShiftR(this ReadOnlySpan256<int> lhs, in ReadOnlySpan256<uint> rhs, in Span256<int> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                Bits.shiftr(lhs.LoadVec256(i), rhs.LoadVec256(i), ref dst[i]);            
            return dst;            
        }

        public static Span256<uint> ShiftR(this ReadOnlySpan256<uint> lhs, in ReadOnlySpan256<uint> rhs, in Span256<uint> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                Bits.shiftr(lhs.LoadVec256(i), rhs.LoadVec256(i), ref dst[i]);            
            return dst;            
        }

        public static Span256<long> ShiftR(this ReadOnlySpan256<long> lhs, in ReadOnlySpan256<ulong> rhs, in Span256<long> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                Bits.shiftr(lhs.LoadVec256(i), rhs.LoadVec256(i), ref dst[i]);            
            return dst;            
        }

        public static Span256<ulong> ShiftR(this ReadOnlySpan256<ulong> lhs, in ReadOnlySpan256<ulong> rhs, in Span256<ulong> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                Bits.shiftr(lhs.LoadVec256(i), rhs.LoadVec256(i), ref dst[i]);            
            return dst;            
       }

        public static Span128<short> ShiftR(this ReadOnlySpan128<short> lhs, byte count, Span128<short> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                vstore(Bits.shiftr(lhs.LoadVec128(i), count), ref dst[i]);
            return dst;            
        }

        public static Span128<ushort> ShiftR(this ReadOnlySpan128<ushort> lhs, byte count, Span128<ushort> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                vstore(Bits.shiftr(lhs.LoadVec128(i), count), ref dst[i]);
            return dst;            
        }

        public static Span128<int> ShiftR(this ReadOnlySpan128<int> lhs, byte count, Span128<int> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                vstore(Bits.shiftr(lhs.LoadVec128(i), count), ref dst[i]);
            return dst;            
        }

        public static Span128<uint> ShiftR(this ReadOnlySpan128<uint> lhs, byte count, Span128<uint> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                vstore(Bits.shiftr(lhs.LoadVec128(i), count), ref dst[i]);
            return dst;            
        }

        public static Span128<long> ShiftR(this ReadOnlySpan128<long> lhs, byte count, Span128<long> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                vstore(Bits.shiftr(lhs.LoadVec128(i), count), ref dst[i]);
            return dst;            
        }

        public static Span128<ulong> ShiftR(this ReadOnlySpan128<ulong> lhs, byte count, Span128<ulong> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                vstore(Bits.shiftr(lhs.LoadVec128(i), count), ref dst[i]);
            return dst;            
        }

        public static Span256<short> ShiftR(this ReadOnlySpan256<short> lhs, byte count, Span256<short> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                vstore(Bits.shiftr(lhs.LoadVec256(i), count), ref dst[i]);
            return dst;            
        }

        public static Span256<ushort> ShiftR(this ReadOnlySpan256<ushort> lhs, byte count, Span256<ushort> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                vstore(Bits.shiftr(lhs.LoadVec256(i), count), ref dst[i]);
            return dst;            
        }

        public static Span256<int> ShiftR(this ReadOnlySpan256<int> lhs, byte count, Span256<int> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                vstore(Bits.shiftr(lhs.LoadVec256(i), count), ref dst[i]);
            return dst;            
        }

        public static Span256<uint> ShiftR(this ReadOnlySpan256<uint> lhs, byte count, Span256<uint> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                vstore(Bits.shiftr(lhs.LoadVec256(i), count), ref dst[i]);
            return dst;            
        }

        public static Span256<long> ShiftR(this ReadOnlySpan256<long> lhs, byte count, Span256<long> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                vstore(Bits.shiftr(lhs.LoadVec256(i), count), ref dst[i]);
            return dst;            
        }

        public static Span256<ulong> ShiftR(this ReadOnlySpan256<ulong> lhs, byte count, Span256<ulong> dst)
        {
            var width = dst.BlockWidth;
            for(var i =0; i < lhs.Length; i += width)
                vstore(Bits.shiftr(lhs.LoadVec256(i), count), ref dst[i]);
            return dst;            
       }

    }

}