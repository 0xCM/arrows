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
    
    
    using static mfunc;

    partial class dinx
    {

        [MethodImpl(Inline)]
        public static Vec128<int> lshiftv(in Vec128<int> src, in Vec128<uint> count)
            => Avx2.ShiftLeftLogicalVariable(src, count);

        [MethodImpl(Inline)]
        public static Vec128<uint> lshiftv(in Vec128<uint> src, in Vec128<uint> shifts)
            => Avx2.ShiftLeftLogicalVariable(src, shifts);

        [MethodImpl(Inline)]
        public static Vec128<long> lshiftv(in Vec128<long> src, in Vec128<ulong> shifts)
            => Avx2.ShiftLeftLogicalVariable(src, shifts);

        [MethodImpl(Inline)]
        public static Vec128<ulong> lshiftv(in Vec128<ulong> src, in Vec128<ulong> shifts)
            => Avx2.ShiftLeftLogicalVariable(src, shifts);       
 
        [MethodImpl(Inline)]
        public static Vec256<int> lshiftv(in Vec256<int> src, in Vec256<uint> shifts)
            => Avx2.ShiftLeftLogicalVariable(src, shifts);

        [MethodImpl(Inline)]
        public static Vec256<uint> lshiftv(in Vec256<uint> src, in Vec256<uint> shifts)
            => Avx2.ShiftLeftLogicalVariable(src, shifts);

        [MethodImpl(Inline)]
        public static Vec256<long> lshiftv(in Vec256<long> src, in Vec256<ulong> shifts)
            => Avx2.ShiftLeftLogicalVariable(src, shifts);

        [MethodImpl(Inline)]
        public static Vec256<ulong> lshiftv(in Vec256<ulong> src, in Vec256<ulong> shifts)
            => Avx2.ShiftLeftLogicalVariable(src, shifts); 
  
        public static unsafe ref Span128<int> lshiftv(in ReadOnlySpan128<int> lhs, in ReadOnlySpan128<uint> shifts, ref Span128<int> dst)
        {
            var vLen = Span128<int>.BlockLength;            
            var dLen = length(lhs,shifts);

            fixed(int* pLhs0 = &first(lhs))
            fixed(uint* pRhs0 = &first(shifts))
            fixed(int* pDst0 = &first(dst))
            {
                var pDst = pDst0;                
                var pLhs = pLhs0;
                var pRhs = pRhs0;
                for(var i =0; i < dLen; i+= vLen, pDst += vLen, pLhs += vLen, pRhs += vLen)
                {
                    var vLhs = Vec128.load(pLhs);
                    var vRhs = Vec128.load(pRhs);
                    dinx.store(dinx.lshiftv(vLhs,vRhs), pDst);
                }
            }
            
            return ref dst;
        }

        public static unsafe ref Span128<uint> lshiftv(in ReadOnlySpan128<uint> lhs, in ReadOnlySpan128<uint> shifts, ref Span128<uint> dst)
        {
            var vLen = Span128<uint>.BlockLength;            
            var dLen = length(lhs,shifts);

            fixed(uint* pLhs0 = &first(lhs))
            fixed(uint* pRhs0 = &first(shifts))
            fixed(uint* pDst0 = &first(dst))
            {
                var pDst = pDst0;                
                var pLhs = pLhs0;
                var pRhs = pRhs0;
                for(var i =0; i < dLen; i+= vLen, pDst += vLen, pLhs += vLen, pRhs += vLen)
                {
                    var vLhs = Vec128.load(pLhs);
                    var vRhs = Vec128.load(pRhs);
                    dinx.store(dinx.lshiftv(vLhs,vRhs), pDst);
                }
            }
            
            return ref dst;
        }

        public static unsafe ref Span128<long> lshiftv(in ReadOnlySpan128<long> lhs, in ReadOnlySpan128<ulong> shifts, ref Span128<long> dst)
        {
            var vLen = Span128<long>.BlockLength;            
            var dLen = length(lhs,shifts);

            fixed(long* pLhs0 = &first(lhs))
            fixed(ulong* pRhs0 = &first(shifts))
            fixed(long* pDst0 = &first(dst))
            {
                var pDst = pDst0;                
                var pLhs = pLhs0;
                var pRhs = pRhs0;
                for(var i =0; i < dLen; i+= vLen, pDst += vLen, pLhs += vLen, pRhs += vLen)
                {
                    var vLhs = Vec128.load(pLhs);
                    var vRhs = Vec128.load(pRhs);
                    dinx.store(dinx.lshiftv(vLhs,vRhs), pDst);
                }
            }
            
            return ref dst;
        }

        public static unsafe ref Span128<ulong> lshiftv(in ReadOnlySpan128<ulong> lhs, in ReadOnlySpan128<ulong> shifts, ref Span128<ulong> dst)
        {
            var vLen = Span128<ulong>.BlockLength;            
            var dLen = length(lhs,shifts);

            fixed(ulong* pLhs0 = &first(lhs))
            fixed(ulong* pRhs0 = &first(shifts))
            fixed(ulong* pDst0 = &first(dst))
            {
                var pDst = pDst0;                
                var pLhs = pLhs0;
                var pRhs = pRhs0;
                for(var i =0; i < dLen; i+= vLen, pDst += vLen, pLhs += vLen, pRhs += vLen)
                {
                    var vLhs = Vec128.load(pLhs);
                    var vRhs = Vec128.load(pRhs);
                    dinx.store(dinx.lshiftv(vLhs,vRhs), pDst);
                }
            }
            
            return ref dst;
        }

        public static unsafe ref Span256<int> lshiftv(in ReadOnlySpan256<int> lhs, in ReadOnlySpan256<uint> shifts, ref Span256<int> dst)
        {
            var vLen = Span256<int>.BlockLength;            
            var dLen = length(lhs,shifts);

            fixed(int* pLhs0 = &first(lhs))
            fixed(uint* pRhs0 = &first(shifts))
            fixed(int* pDst0 = &first(dst))
            {
                var pDst = pDst0;                
                var pLhs = pLhs0;
                var pRhs = pRhs0;
                for(var i =0; i < dLen; i+= vLen, pDst += vLen, pLhs += vLen, pRhs += vLen)
                {
                    var vLhs = Vec256.load(pLhs);
                    var vRhs = Vec256.load(pRhs);
                    dinx.store(dinx.lshiftv(vLhs,vRhs), pDst);
                }
            }
            
            return ref dst;
        }

        public static unsafe ref Span256<uint> lshiftv(in ReadOnlySpan256<uint> lhs, in ReadOnlySpan256<uint> shifts, ref Span256<uint> dst)
        {
            var vLen = Span256<uint>.BlockLength;            
            var dLen = length(lhs,shifts);

            fixed(uint* pLhs0 = &first(lhs))
            fixed(uint* pRhs0 = &first(shifts))
            fixed(uint* pDst0 = &first(dst))
            {
                var pDst = pDst0;                
                var pLhs = pLhs0;
                var pRhs = pRhs0;
                for(var i =0; i < dLen; i+= vLen, pDst += vLen, pLhs += vLen, pRhs += vLen)
                {
                    var vLhs = Vec256.load(pLhs);
                    var vRhs = Vec256.load(pRhs);
                    dinx.store(dinx.lshiftv(vLhs,vRhs), pDst);
                }
            }
            
            return ref dst;
        }

        public static unsafe ref Span256<long> lshiftv(in ReadOnlySpan256<long> lhs, in ReadOnlySpan256<ulong> shifts, ref Span256<long> dst)
        {
            var vLen = Span256<long>.BlockLength;            
            var dLen = length(lhs,shifts);

            fixed(long* pLhs0 = &first(lhs))
            fixed(ulong* pRhs0 = &first(shifts))
            fixed(long* pDst0 = &first(dst))
            {
                var pDst = pDst0;                
                var pLhs = pLhs0;
                var pRhs = pRhs0;
                for(var i =0; i < dLen; i+= vLen, pDst += vLen, pLhs += vLen, pRhs += vLen)
                {
                    var vLhs = Vec256.load(pLhs);
                    var vRhs = Vec256.load(pRhs);
                    dinx.store(dinx.lshiftv(vLhs,vRhs), pDst);
                }
            }
            
            return ref dst;
        }

        public static unsafe ref Span256<ulong> lshiftv(in ReadOnlySpan256<ulong> lhs, in ReadOnlySpan256<ulong> shifts, ref Span256<ulong> dst)
        {
            var vLen = Span256<ulong>.BlockLength;            
            var dLen = length(lhs,shifts);

            fixed(ulong* pLhs0 = &first(lhs))
            fixed(ulong* pRhs0 = &first(shifts))
            fixed(ulong* pDst0 = &first(dst))
            {
                var pDst = pDst0;                
                var pLhs = pLhs0;
                var pRhs = pRhs0;
                for(var i =0; i < dLen; i+= vLen, pDst += vLen, pLhs += vLen, pRhs += vLen)
                {
                    var vLhs = Vec256.load(pLhs);
                    var vRhs = Vec256.load(pRhs);
                    dinx.store(dinx.lshiftv(vLhs,vRhs), pDst);
                }
            }
            
            return ref dst;
        }

    }

}