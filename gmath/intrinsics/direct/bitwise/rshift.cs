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
        public static Vec128<short> rshift(in Vec128<short> src, byte count)
            => Avx2.ShiftRightLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec128<ushort> rshift(in Vec128<ushort> src, byte count)
            => Avx2.ShiftRightLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec128<int> rshift(in Vec128<int> src, byte count)
            => Avx2.ShiftRightLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec128<uint> rshift(in Vec128<uint> src, byte count)
            => Avx2.ShiftRightLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec128<long> rshift(in Vec128<long> src, byte count)
            => Avx2.ShiftRightLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec128<ulong> rshift(in Vec128<ulong> src, byte count)
            => Avx2.ShiftRightLogical(src, count);
        
        [MethodImpl(Inline)]
        public static Vec256<short> rshift(in Vec256<short> src, byte count)
            => Avx2.ShiftRightLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec256<ushort> rshift(in Vec256<ushort> src, byte count)
            => Avx2.ShiftRightLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec256<int> rshift(in Vec256<int> src, byte count)
            => Avx2.ShiftRightLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec256<uint> rshift(in Vec256<uint> src, byte count)
            => Avx2.ShiftRightLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec256<long> rshift(in Vec256<long> src, byte count)
            => Avx2.ShiftRightLogical(src, count);

        [MethodImpl(Inline)]
        public static Vec256<ulong> rshift(in Vec256<ulong> src, byte count)
            => Avx2.ShiftRightLogical(src, count);

        [MethodImpl(Inline)]
        public unsafe static ref readonly Vec128<short> rshift(in Vec128<short> lhs, byte count, short* dst)
        {
            store(rshift(lhs,count), dst);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public unsafe static ref readonly Vec128<ushort> rshift(in Vec128<ushort> lhs, byte count, ushort* dst)
        {
            store(rshift(lhs,count), dst);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public unsafe static ref readonly Vec128<int> rshift(in Vec128<int> lhs, byte count, int* dst)
        {
            store(rshift(lhs,count), dst);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public unsafe static ref readonly Vec128<uint> rshift(in Vec128<uint> lhs, byte count, uint* dst)
        {
            store(rshift(lhs,count), dst);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public unsafe static ref readonly Vec128<long> rshift(in Vec128<long> lhs, byte count, long* dst)
        {
            store(rshift(lhs,count), dst);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public unsafe static ref readonly Vec128<ulong> rshift(in Vec128<ulong> lhs, byte count, ulong* dst)
        {
            store(rshift(lhs,count), dst);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public unsafe static ref readonly Vec256<short> rshift(in Vec256<short> lhs, byte count, short* dst)
        {
            store(rshift(lhs,count), dst);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public unsafe static ref readonly Vec256<ushort> rshift(in Vec256<ushort> lhs, byte count, ushort* dst)
        {
            store(rshift(lhs,count), dst);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public unsafe static ref readonly Vec256<int> rshift(in Vec256<int> lhs, byte count, int* dst)
        {
            store(rshift(lhs,count), dst);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public unsafe static ref readonly Vec256<uint> rshift(in Vec256<uint> lhs, byte count, uint* dst)
        {
            store(rshift(lhs,count), dst);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public unsafe static ref readonly Vec256<long> rshift(in Vec256<long> lhs, byte count, long* dst)
        {
            store(rshift(lhs,count), dst);
            return ref lhs;
        }

        [MethodImpl(Inline)]
        public unsafe static ref readonly Vec256<ulong> rshift(in Vec256<ulong> lhs, byte count, ulong* dst)
        {
            store(rshift(lhs,count), dst);
            return ref lhs;
        }

        public static unsafe ref Span128<short> rshift(ReadOnlySpan128<short> lhs, byte count, ref Span128<short> dst)
        {
            var vLen = Span128<short>.BlockLength;            
            var dLen = lhs.Length;

            fixed(short* pLhs0 = &first(lhs))
            fixed(short* pDst0 = &first(dst))
            {
                var pDst = pDst0;                
                var pLhs = pLhs0;
                for(var i =0; i < dLen; i+= vLen, pDst += vLen, pLhs += vLen)
                {
                    var vLhs = Vec128.load(pLhs);
                    store(rshift(vLhs,count), pDst);
                }
            }
            
            return ref dst;
        }

        public static unsafe ref Span128<ushort> rshift(ReadOnlySpan128<ushort> lhs, byte count, ref Span128<ushort> dst)
        {
            var vLen = Span128<ushort>.BlockLength;            
            var dLen = lhs.Length;

            fixed(ushort* pLhs0 = &first(lhs))
            fixed(ushort* pDst0 = &first(dst))
            {
                var pDst = pDst0;                
                var pLhs = pLhs0;
                for(var i =0; i < dLen; i+= vLen, pDst += vLen, pLhs += vLen)
                {
                    var vLhs = Vec128.load(pLhs);
                    store(rshift(vLhs,count), pDst);
                }
            }
            
            return ref dst;
        }

        public static unsafe ref Span128<int> rshift(ReadOnlySpan128<int> lhs, byte count, ref Span128<int> dst)
        {
            var vLen = Span128<int>.BlockLength;            
            var dLen = lhs.Length;

            fixed(int* pLhs0 = &first(lhs))
            fixed(int* pDst0 = &first(dst))
            {
                var pDst = pDst0;                
                var pLhs = pLhs0;
                for(var i =0; i < dLen; i+= vLen, pDst += vLen, pLhs += vLen)
                {
                    var vLhs = Vec128.load(pLhs);
                    store(rshift(vLhs,count), pDst);
                }
            }
            
            return ref dst;
        }

        public static unsafe ref Span128<uint> rshift(ReadOnlySpan128<uint> lhs, byte count, ref Span128<uint> dst)
        {
            var vLen = Span128<uint>.BlockLength;            
            var dLen = lhs.Length;

            fixed(uint* pLhs0 = &first(lhs))
            fixed(uint* pDst0 = &first(dst))
            {
                var pDst = pDst0;                
                var pLhs = pLhs0;
                for(var i =0; i < dLen; i+= vLen, pDst += vLen, pLhs += vLen)
                {
                    var vLhs = Vec128.load(pLhs);
                    store(rshift(vLhs,count), pDst);
                }
            }
            
            return ref dst;
        }

        public static unsafe ref Span128<long> rshift(ReadOnlySpan128<long> lhs, byte count, ref Span128<long> dst)
        {
            var vLen = Span128<long>.BlockLength;            
            var dLen = lhs.Length;

            fixed(long* pLhs0 = &first(lhs))
            fixed(long* pDst0 = &first(dst))
            {
                var pDst = pDst0;                
                var pLhs = pLhs0;
                for(var i =0; i < dLen; i+= vLen, pDst += vLen, pLhs += vLen)
                {
                    var vLhs = Vec128.load(pLhs);
                    store(rshift(vLhs,count), pDst);
                }
            }
            
            return ref dst;
        }

        public static unsafe ref Span128<ulong> rshift(ReadOnlySpan128<ulong> lhs, byte count, ref Span128<ulong> dst)
        {
            var vLen = Span128<ulong>.BlockLength;            
            var dLen = lhs.Length;

            fixed(ulong* pLhs0 = &first(lhs))
            fixed(ulong* pDst0 = &first(dst))
            {
                var pDst = pDst0;                
                var pLhs = pLhs0;
                for(var i =0; i < dLen; i+= vLen, pDst += vLen, pLhs += vLen)
                {
                    var vLhs = Vec128.load(pLhs);
                    store(rshift(vLhs,count), pDst);
                }
            }
            
            return ref dst;
        }

        public static unsafe ref Span256<short> rshift(ReadOnlySpan256<short> lhs, byte count, ref Span256<short> dst)
        {
            var vLen = Span256<short>.BlockLength;            
            var dLen = lhs.Length;

            fixed(short* pLhs0 = &first(lhs))
            fixed(short* pDst0 = &first(dst))
            {
                var pDst = pDst0;                
                var pLhs = pLhs0;
                for(var i =0; i < dLen; i+= vLen, pDst += vLen, pLhs += vLen)
                {
                    var vLhs = Vec256.load(pLhs);
                    store(rshift(vLhs,count), pDst);
                }
            }
            
            return ref dst;
        }

        public static unsafe ref Span256<ushort> rshift(ReadOnlySpan256<ushort> lhs, byte count, ref Span256<ushort> dst)
        {
            var vLen = Span256<ushort>.BlockLength;            
            var dLen = lhs.Length;

            fixed(ushort* pLhs0 = &first(lhs))
            fixed(ushort* pDst0 = &first(dst))
            {
                var pDst = pDst0;                
                var pLhs = pLhs0;
                for(var i =0; i < dLen; i+= vLen, pDst += vLen, pLhs += vLen)
                {
                    var vLhs = Vec256.load(pLhs);
                    store(rshift(vLhs,count), pDst);
                }
            }
            
            return ref dst;
        }

        public static unsafe ref Span256<int> rshift(ReadOnlySpan256<int> lhs, byte count, ref Span256<int> dst)
        {
            var vLen = Span256<int>.BlockLength;            
            var dLen = lhs.Length;

            fixed(int* pLhs0 = &first(lhs))
            fixed(int* pDst0 = &first(dst))
            {
                var pDst = pDst0;                
                var pLhs = pLhs0;
                for(var i =0; i < dLen; i+= vLen, pDst += vLen, pLhs += vLen)
                {
                    var vLhs = Vec256.load(pLhs);
                    store(rshift(vLhs,count), pDst);
                }
            }
            
            return ref dst;
        }

        public static unsafe ref Span256<uint> rshift(ReadOnlySpan256<uint> lhs, byte count, ref Span256<uint> dst)
        {
            var vLen = Span256<uint>.BlockLength;            
            var dLen = lhs.Length;

            fixed(uint* pLhs0 = &first(lhs))
            fixed(uint* pDst0 = &first(dst))
            {
                var pDst = pDst0;                
                var pLhs = pLhs0;
                for(var i =0; i < dLen; i+= vLen, pDst += vLen, pLhs += vLen)
                {
                    var vLhs = Vec256.load(pLhs);
                    store(rshift(vLhs,count), pDst);
                }
            }
            
            return ref dst;
        }

        public static unsafe ref Span256<long> rshift(ReadOnlySpan256<long> lhs, byte count, ref Span256<long> dst)
        {
            var vLen = Span256<long>.BlockLength;            
            var dLen = lhs.Length;

            fixed(long* pLhs0 = &first(lhs))
            fixed(long* pDst0 = &first(dst))
            {
                var pDst = pDst0;                
                var pLhs = pLhs0;
                for(var i =0; i < dLen; i+= vLen, pDst += vLen, pLhs += vLen)
                {
                    var vLhs = Vec256.load(pLhs);
                    store(rshift(vLhs,count), pDst);
                }
            }
            
            return ref dst;
        }

        public static unsafe ref Span256<ulong> rshift(ReadOnlySpan256<ulong> lhs, byte count, ref Span256<ulong> dst)
        {
            var vLen = Span256<ulong>.BlockLength;            
            var dLen = lhs.Length;

            fixed(ulong* pLhs0 = &first(lhs))
            fixed(ulong* pDst0 = &first(dst))
            {
                var pDst = pDst0;                
                var pLhs = pLhs0;
                for(var i =0; i < dLen; i+= vLen, pDst += vLen, pLhs += vLen)
                {
                    var vLhs = Vec256.load(pLhs);
                    store(rshift(vLhs,count), pDst);
                }
            }
            
            return ref dst;
        }

    }

}