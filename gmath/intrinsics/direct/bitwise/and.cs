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
    
    
    using static global::mfunc;

    partial class dinx
    {
        #region and:vec -> vec -> vec

        [MethodImpl(Inline)]
        public static Vec128<byte> and(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => Avx2.And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> and(in Vec128<short> lhs, in Vec128<short> rhs)
            => Avx2.And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> and(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => Avx2.And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> and(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => Avx2.And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> and(in Vec128<int> lhs, in Vec128<int> rhs)
            => Avx2.And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<uint> and(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => Avx2.And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<long> and(in Vec128<long> lhs, in Vec128<long> rhs)
            => Avx2.And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ulong> and(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => Avx2.And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> and(in Vec128<float> lhs, in Vec128<float> rhs)
            => Avx2.And(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Vec128<double> and(in Vec128<double> lhs, in Vec128<double> rhs)
            => Avx2.And(lhs, rhs);


        [MethodImpl(Inline)]
        public static Vec256<byte> and(in Vec256<byte> lhs, in Vec256<byte> rhs)
            => Avx2.And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> and(in Vec256<short> lhs, in Vec256<short> rhs)
            => Avx2.And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> and(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => Avx2.And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ushort> and(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => Avx2.And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<int> and(in Vec256<int> lhs, in Vec256<int> rhs)
            => Avx2.And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<uint> and(in Vec256<uint> lhs, in Vec256<uint> rhs)
            => Avx2.And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<long> and(in Vec256<long> lhs, in Vec256<long> rhs)
            => Avx2.And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ulong> and(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
            => Avx2.And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<float> and(in Vec256<float> lhs, in Vec256<float> rhs)
            => Avx2.And(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Vec256<double> and(in Vec256<double> lhs, in Vec256<double> rhs)
            => Avx2.And(lhs, rhs);

        #endregion

        #region and:vec -> vec -> *        

        [MethodImpl(Inline)]
        public unsafe static void and(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs, sbyte* dst)
            => store(and(lhs,rhs), dst);

        [MethodImpl(Inline)]
        public unsafe static void and(in Vec128<byte> lhs, in Vec128<byte> rhs, byte* dst)
            => store(and(lhs,rhs), dst);

        [MethodImpl(Inline)]
        public unsafe static void and(in Vec128<short> lhs, in Vec128<short> rhs, short* dst)
            => store(and(lhs,rhs), dst);

        [MethodImpl(Inline)]
        public unsafe static void and(in Vec128<ushort> lhs, in Vec128<ushort> rhs, ushort* dst)
            => store(and(lhs,rhs), dst);

        [MethodImpl(Inline)]
        public unsafe static void and(in Vec128<int> lhs, in Vec128<int> rhs, int* dst)
            => store(and(lhs,rhs), dst);

        [MethodImpl(Inline)]
        public unsafe static void and(in Vec128<uint> lhs, in Vec128<uint> rhs, uint* dst)
            => store(and(lhs,rhs), dst);

        [MethodImpl(Inline)]
        public unsafe static void and(in Vec128<long> lhs, in Vec128<long> rhs, long* dst)
            => store(and(lhs,rhs), dst);

        [MethodImpl(Inline)]
        public unsafe static void and(in Vec128<ulong> lhs, in Vec128<ulong> rhs, ulong* dst)
            => store(and(lhs,rhs), dst);

        [MethodImpl(Inline)]
        public unsafe static void and(in Vec128<float> lhs, in Vec128<float> rhs, float* dst)
            => store(and(lhs,rhs), dst);

        [MethodImpl(Inline)]
        public unsafe static void and(in Vec128<double> lhs, in Vec128<double> rhs, double* dst)
            => store(and(lhs,rhs), dst);

        [MethodImpl(Inline)]
        public unsafe static void and(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs, sbyte* dst)
            => store(and(lhs,rhs), dst);

        [MethodImpl(Inline)]
        public unsafe static void and(in Vec256<byte> lhs, in Vec256<byte> rhs, byte* dst)
            => store(and(lhs,rhs), dst);

        [MethodImpl(Inline)]
        public unsafe static void and(in Vec256<short> lhs, in Vec256<short> rhs, short* dst)
            => store(and(lhs,rhs), dst);

        [MethodImpl(Inline)]
        public unsafe static void and(in Vec256<ushort> lhs, in Vec256<ushort> rhs, ushort* dst)
            => store(and(lhs,rhs), dst);

        [MethodImpl(Inline)]
        public unsafe static void and(in Vec256<int> lhs, in Vec256<int> rhs, int* dst)
            => store(and(lhs,rhs), dst);

        [MethodImpl(Inline)]
        public unsafe static void and(in Vec256<uint> lhs, in Vec256<uint> rhs, uint* dst)
            => store(and(lhs,rhs), dst);

        [MethodImpl(Inline)]
        public unsafe static void and(in Vec256<long> lhs, in Vec256<long> rhs, long* dst)
            => store(and(lhs,rhs), dst);

        [MethodImpl(Inline)]
        public unsafe static void and(in Vec256<ulong> lhs, in Vec256<ulong> rhs, ulong* dst)
            => store(and(lhs,rhs), dst);

        [MethodImpl(Inline)]
        public unsafe static void and(in Vec256<float> lhs, in Vec256<float> rhs, float* dst)
            => store(and(lhs,rhs), dst);

        [MethodImpl(Inline)]
        public unsafe static void and(in Vec256<double> lhs, in Vec256<double> rhs, double* dst)
            => store(and(lhs,rhs), dst);

        #endregion

        #region and:span -> span -> ref span -> ref span

        public static unsafe ref Span128<sbyte> and(ReadOnlySpan128<sbyte> lhs, ReadOnlySpan128<sbyte> rhs, ref Span128<sbyte> dst)
        {
            var vLen = Span128<sbyte>.BlockLength;            
            var dLen = length(lhs,rhs);

            fixed(sbyte* pLhs0 = &first(lhs))
            fixed(sbyte* pRhs0 = &(first(rhs)))
            fixed(sbyte* pDst0 = &first(dst))
            {
                var pDst = pDst0;                
                var pLhs = pLhs0;
                var pRhs = pRhs0;
                for(var i =0; i < dLen; i+= vLen, pDst += vLen, pLhs += vLen, pRhs += vLen)
                {
                    var vLhs = Vec128.load(pLhs);
                    var vRhs = Vec128.load(pRhs);
                    dinx.store(dinx.and(vLhs,vRhs), pDst);
                }
            }
            
            return ref dst;
        }

        public static unsafe ref Span128<byte> and(ReadOnlySpan128<byte> lhs, ReadOnlySpan128<byte> rhs, ref Span128<byte> dst)
        {
            var vLen = Span128<byte>.BlockLength;            
            var dLen = length(lhs,rhs);

            fixed(byte* pLhs0 = &first(lhs))
            fixed(byte* pRhs0 = &first(rhs))
            fixed(byte* pDst0 = &first(dst))
            {
                var pDst = pDst0;                
                var pLhs = pLhs0;
                var pRhs = pRhs0;
                for(var i =0; i < dLen; i+= vLen, pDst += vLen, pLhs += vLen, pRhs += vLen)
                {
                    var vLhs = Vec128.load(pLhs);
                    var vRhs = Vec128.load(pRhs);
                    dinx.store(dinx.and(vLhs,vRhs), pDst);
                }
            }
            
            return ref dst;
        }

        public static unsafe ref Span128<short> and(ReadOnlySpan128<short> lhs, ReadOnlySpan128<short> rhs, ref Span128<short> dst)
        {
            var vLen = Span128<short>.BlockLength;            
            var dLen = length(lhs,rhs);

            fixed(short* pLhs0 = &first(lhs))
            fixed(short* pRhs0 = &first(rhs))
            fixed(short* pDst0 = &first(dst))
            {
                var pDst = pDst0;                
                var pLhs = pLhs0;
                var pRhs = pRhs0;
                for(var i =0; i < dLen; i+= vLen, pDst += vLen, pLhs += vLen, pRhs += vLen)
                {
                    var vLhs = Vec128.load(pLhs);
                    var vRhs = Vec128.load(pRhs);
                    dinx.store(dinx.and(vLhs,vRhs), pDst);
                }
            }
            
            return ref dst;
        }

        public static unsafe ref Span128<ushort> and(ReadOnlySpan128<ushort> lhs, ReadOnlySpan128<ushort> rhs, ref Span128<ushort> dst)
        {
            var vLen = Span128<ushort>.BlockLength;            
            var dLen = length(lhs,rhs);

            fixed(ushort* pLhs0 = &first(lhs))
            fixed(ushort* pRhs0 = &first(rhs))
            fixed(ushort* pDst0 = &first(dst))
            {
                var pDst = pDst0;                
                var pLhs = pLhs0;
                var pRhs = pRhs0;
                for(var i =0; i < dLen; i+= vLen, pDst += vLen, pLhs += vLen, pRhs += vLen)
                {
                    var vLhs = Vec128.load(pLhs);
                    var vRhs = Vec128.load(pRhs);
                    dinx.store(dinx.and(vLhs,vRhs), pDst);
                }
            }
            
            return ref dst;
        }

        public static unsafe ref Span128<int> and(ReadOnlySpan128<int> lhs, ReadOnlySpan128<int> rhs, ref Span128<int> dst)
        {
            var vLen = Span128<int>.BlockLength;            
            var dLen = length(lhs,rhs);

            fixed(int* pLhs0 = &first(lhs))
            fixed(int* pRhs0 = &first(rhs))
            fixed(int* pDst0 = &first(dst))
            {
                var pDst = pDst0;                
                var pLhs = pLhs0;
                var pRhs = pRhs0;
                for(var i =0; i < dLen; i+= vLen, pDst += vLen, pLhs += vLen, pRhs += vLen)
                {
                    var vLhs = Vec128.load(pLhs);
                    var vRhs = Vec128.load(pRhs);
                    dinx.store(dinx.and(vLhs,vRhs), pDst);
                }
            }
            
            return ref dst;
        }

        public static unsafe ref Span128<uint> and(ReadOnlySpan128<uint> lhs, ReadOnlySpan128<uint> rhs, ref Span128<uint> dst)
        {
            var vLen = Span128<uint>.BlockLength;            
            var dLen = length(lhs,rhs);

            fixed(uint* pLhs0 = &first(lhs))
            fixed(uint* pRhs0 = &first(rhs))
            fixed(uint* pDst0 = &first(dst))
            {
                var pDst = pDst0;                
                var pLhs = pLhs0;
                var pRhs = pRhs0;
                for(var i =0; i < dLen; i+= vLen, pDst += vLen, pLhs += vLen, pRhs += vLen)
                {
                    var vLhs = Vec128.load(pLhs);
                    var vRhs = Vec128.load(pRhs);
                    dinx.store(dinx.and(vLhs,vRhs), pDst);
                }
            }
            
            return ref dst;
        }

        public static unsafe ref Span128<long> and(ReadOnlySpan128<long> lhs, ReadOnlySpan128<long> rhs, ref Span128<long> dst)
        {
            var vLen = Span128<long>.BlockLength;            
            var dLen = length(lhs,rhs);

            fixed(long* pLhs0 = &first(lhs))
            fixed(long* pRhs0 = &first(rhs))
            fixed(long* pDst0 = &first(dst))
            {
                var pDst = pDst0;                
                var pLhs = pLhs0;
                var pRhs = pRhs0;
                for(var i =0; i < dLen; i+= vLen, pDst += vLen, pLhs += vLen, pRhs += vLen)
                {
                    var vLhs = Vec128.load(pLhs);
                    var vRhs = Vec128.load(pRhs);
                    dinx.store(dinx.and(vLhs,vRhs), pDst);
                }
            }
            
            return ref dst;
        }

        public static unsafe ref Span128<ulong> and(ReadOnlySpan128<ulong> lhs, ReadOnlySpan128<ulong> rhs, ref Span128<ulong> dst)
        {
            var vLen = Span128<ulong>.BlockLength;            
            var dLen = length(lhs,rhs);

            fixed(ulong* pLhs0 = &first(lhs))
            fixed(ulong* pRhs0 = &first(rhs))
            fixed(ulong* pDst0 = &first(dst))
            {
                var pDst = pDst0;                
                var pLhs = pLhs0;
                var pRhs = pRhs0;
                for(var i =0; i < dLen; i+= vLen, pDst += vLen, pLhs += vLen, pRhs += vLen)
                {
                    var vLhs = Vec128.load(pLhs);
                    var vRhs = Vec128.load(pRhs);
                    dinx.store(dinx.and(vLhs,vRhs), pDst);
                }
            }
            
            return ref dst;
        }

        public static unsafe ref Span128<float> and(ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs, ref Span128<float> dst)
        {
            var vLen = Span128<float>.BlockLength;            
            var dLen = length(lhs,rhs);

            fixed(float* pLhs0 = &first(lhs))
            fixed(float* pRhs0 = &first(rhs))
            fixed(float* pDst0 = &first(dst))
            {
                var pDst = pDst0;                
                var pLhs = pLhs0;
                var pRhs = pRhs0;
                for(var i =0; i < dLen; i+= vLen, pDst += vLen, pLhs += vLen, pRhs += vLen)
                {
                    var vLhs = Vec128.load(pLhs);
                    var vRhs = Vec128.load(pRhs);
                    dinx.store(dinx.and(vLhs,vRhs), pDst);
                }
            }
            
            return ref dst;
        }

        public static unsafe ref Span128<double> and(ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs, ref Span128<double> dst)
        {
            var vLen = Span128<double>.BlockLength;            
            var dLen = length(lhs,rhs);

            fixed(double* pLhs0 = &first(lhs))
            fixed(double* pRhs0 = &first(rhs))
            fixed(double* pDst0 = &first(dst))
            {
                var pDst = pDst0;                
                var pLhs = pLhs0;
                var pRhs = pRhs0;
                for(var i =0; i < dLen; i+= vLen, pDst += vLen, pLhs += vLen, pRhs += vLen)
                {
                    var vLhs = Vec128.load(pLhs);
                    var vRhs = Vec128.load(pRhs);
                    dinx.store(dinx.and(vLhs,vRhs), pDst);
                }
            }
            
            return ref dst;
        }

        public static unsafe ref Span256<sbyte> and(ReadOnlySpan256<sbyte> lhs, ReadOnlySpan256<sbyte> rhs, ref Span256<sbyte> dst)
        {
            var vLen = Span256<sbyte>.BlockLength;            
            var dLen = length(lhs,rhs);

            fixed(sbyte* pLhs0 = &first(lhs))
            fixed(sbyte* pRhs0 = &first(rhs))
            fixed(sbyte* pDst0 = &first(dst))
            {
                var pLhs = pLhs0;
                var pRhs = pRhs0;
                var pDst = pDst0;                
                for(var i =0; i < dLen; i+= vLen, pDst += vLen, pLhs += vLen, pRhs += vLen)
                {
                    var vLhs = Vec256.load(pLhs);
                    var vRhs = Vec256.load(pRhs);
                    dinx.store(dinx.and(vLhs,vRhs), pDst);
                }
            }
            
            return ref dst;
        }

        public static unsafe ref Span256<byte> and(ReadOnlySpan256<byte> lhs, ReadOnlySpan256<byte> rhs, ref Span256<byte> dst)
        {
            var vLen = Span256<byte>.BlockLength;            
            var dLen = length(lhs,rhs);

            fixed(byte* pLhs0 = &first(lhs))
            fixed(byte* pRhs0 = &first(rhs))
            fixed(byte* pDst0 = &first(dst))
            {
                var pDst = pDst0;                
                var pLhs = pLhs0;
                var pRhs = pRhs0;
                for(var i =0; i < dLen; i+= vLen, pDst += vLen, pLhs += vLen, pRhs += vLen)
                {
                    var vLhs = Vec256.load(pLhs);
                    var vRhs = Vec256.load(pRhs);
                    dinx.store(dinx.and(vLhs,vRhs), pDst);
                }
            }
            
            return ref dst;
        }

        public static unsafe ref Span256<short> and(ReadOnlySpan256<short> lhs, ReadOnlySpan256<short> rhs, ref Span256<short> dst)
        {
            var vLen = Span256<short>.BlockLength;            
            var dLen = length(lhs,rhs);

            fixed(short* pLhs0 = &first(lhs))
            fixed(short* pRhs0 = &first(rhs))
            fixed(short* pDst0 = &first(dst))
            {
                var pDst = pDst0;                
                var pLhs = pLhs0;
                var pRhs = pRhs0;
                for(var i =0; i < dLen; i+= vLen, pDst += vLen, pLhs += vLen, pRhs += vLen)
                {
                    var vLhs = Vec256.load(pLhs);
                    var vRhs = Vec256.load(pRhs);
                    dinx.store(dinx.and(vLhs,vRhs), pDst);
                }
            }
            
            return ref dst;
        }

        public static unsafe ref Span256<ushort> and(ReadOnlySpan256<ushort> lhs, ReadOnlySpan256<ushort> rhs, ref Span256<ushort> dst)
        {
            var vLen = Span256<ushort>.BlockLength;            
            var dLen = length(lhs,rhs);

            fixed(ushort* pLhs0 = &first(lhs))
            fixed(ushort* pRhs0 = &first(rhs))
            fixed(ushort* pDst0 = &first(dst))
            {
                var pDst = pDst0;                
                var pLhs = pLhs0;
                var pRhs = pRhs0;
                for(var i =0; i < dLen; i+= vLen, pDst += vLen, pLhs += vLen, pRhs += vLen)
                {
                    var vLhs = Vec256.load(pLhs);
                    var vRhs = Vec256.load(pRhs);
                    dinx.store(dinx.and(vLhs,vRhs), pDst);
                }
            }
            
            return ref dst;
        }

        public static unsafe ref Span256<int> and(ReadOnlySpan256<int> lhs, ReadOnlySpan256<int> rhs, ref Span256<int> dst)
        {
            var vLen = Span256<int>.BlockLength;            
            var dLen = length(lhs,rhs);

            fixed(int* pLhs0 = &first(lhs))
            fixed(int* pRhs0 = &first(rhs))
            fixed(int* pDst0 = &first(dst))
            {
                var pDst = pDst0;                
                var pLhs = pLhs0;
                var pRhs = pRhs0;
                for(var i =0; i < dLen; i+= vLen, pDst += vLen, pLhs += vLen, pRhs += vLen)
                {
                    var vLhs = Vec256.load(pLhs);
                    var vRhs = Vec256.load(pRhs);
                    dinx.store(dinx.and(vLhs,vRhs), pDst);
                }
            }
            
            return ref dst;
        }

        public static unsafe ref Span256<uint> and(ReadOnlySpan256<uint> lhs, ReadOnlySpan256<uint> rhs, ref Span256<uint> dst)
        {
            var vLen = Span256<uint>.BlockLength;            
            var dLen = length(lhs,rhs);

            fixed(uint* pLhs0 = &first(lhs))
            fixed(uint* pRhs0 = &first(rhs))
            fixed(uint* pDst0 = &first(dst))
            {
                var pDst = pDst0;                
                var pLhs = pLhs0;
                var pRhs = pRhs0;
                for(var i =0; i < dLen; i+= vLen, pDst += vLen, pLhs += vLen, pRhs += vLen)
                {
                    var vLhs = Vec256.load(pLhs);
                    var vRhs = Vec256.load(pRhs);
                    dinx.store(dinx.and(vLhs,vRhs), pDst);
                }
            }
            
            return ref dst;
        }

        public static unsafe ref Span256<long> and(ReadOnlySpan256<long> lhs, ReadOnlySpan256<long> rhs, ref Span256<long> dst)
        {
            var vLen = Span256<long>.BlockLength;            
            var dLen = length(lhs,rhs);

            fixed(long* pLhs0 = &first(lhs))
            fixed(long* pRhs0 = &first(rhs))
            fixed(long* pDst0 = &first(dst))
            {
                var pDst = pDst0;                
                var pLhs = pLhs0;
                var pRhs = pRhs0;
                for(var i =0; i < dLen; i+= vLen, pDst += vLen, pLhs += vLen, pRhs += vLen)
                {
                    var vLhs = Vec256.load(pLhs);
                    var vRhs = Vec256.load(pRhs);
                    dinx.store(dinx.and(vLhs,vRhs), pDst);
                }
            }
            
            return ref dst;
        }

        public static unsafe ref Span256<ulong> and(ReadOnlySpan256<ulong> lhs, ReadOnlySpan256<ulong> rhs, ref Span256<ulong> dst)
        {
            var vLen = Vector256<ulong>.Count;            
            var dLen = length(lhs,rhs);

            fixed(ulong* pLhs0 = &first(lhs))
            fixed(ulong* pRhs0 = &first(rhs))
            fixed(ulong* pDst0 = &first(dst))
            {
                var pDst = pDst0;                
                var pLhs = pLhs0;
                var pRhs = pRhs0;
                for(var i =0; i < dLen; i+= vLen, pDst += vLen, pLhs += vLen, pRhs += vLen)
                {
                    var vLhs = Vec256.load(pLhs);
                    var vRhs = Vec256.load(pRhs);
                    dinx.store(dinx.and(vLhs,vRhs), pDst);
                }
            }
            
            return ref dst;
        }

        public static unsafe ref Span256<float> and(ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs, ref Span256<float> dst)
        {
            var vLen = Vector256<float>.Count;            
            var dLen = length(lhs,rhs);

            fixed(float* pLhs0 = &first(lhs))
            fixed(float* pRhs0 = &first(rhs))
            fixed(float* pDst0 = &first(dst))
            {
                var pDst = pDst0;                
                var pLhs = pLhs0;
                var pRhs = pRhs0;
                for(var i =0; i < dLen; i+= vLen, pDst += vLen, pLhs += vLen, pRhs += vLen)
                {
                    var vLhs = Vec256.load(pLhs);
                    var vRhs = Vec256.load(pRhs);
                    dinx.store(dinx.and(vLhs,vRhs), pDst);
                }
            }
            
            return ref dst;
        }

        public static unsafe ref Span256<double> and(ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs, ref Span256<double> dst)
        {
            var vLen = Vector256<double>.Count;            
            var dLen = length(lhs,rhs);

            fixed(double* pLhs0 = &first(lhs))
            fixed(double* pRhs0 = &first(rhs))
            fixed(double* pDst0 = &first(dst))
            {
                var pDst = pDst0;                
                var pLhs = pLhs0;
                var pRhs = pRhs0;
                for(var i =0; i < dLen; i+= vLen, pDst += vLen, pLhs += vLen, pRhs += vLen)
                {
                    var vLhs = Vec256.load(pLhs);
                    var vRhs = Vec256.load(pRhs);
                    dinx.store(dinx.and(vLhs,vRhs), pDst);
                }
            }
            
            return ref dst;
        }
        #endregion        
   }
}