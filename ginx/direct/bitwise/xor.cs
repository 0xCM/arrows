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
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;

    
    using static zfunc;    
    using static Spans;

    partial class dinx
    {
        #region xor:vec -> vec -> vec

        [MethodImpl(Inline)]
        public static Vec128<byte> xor(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> xor(in Vec128<short> lhs, in Vec128<short> rhs)
            => Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> xor(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> xor(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> xor(in Vec128<int> lhs, in Vec128<int> rhs)
            => Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<uint> xor(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<long> xor(in Vec128<long> lhs, in Vec128<long> rhs)
            => Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ulong> xor(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> xor(in Vec128<float> lhs, in Vec128<float> rhs)
            => Xor(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Vec128<double> xor(in Vec128<double> lhs, in Vec128<double> rhs)
            => Xor(lhs, rhs);


        [MethodImpl(Inline)]
        public static Vec256<byte> xor(in Vec256<byte> lhs, in Vec256<byte> rhs)
            => Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> xor(in Vec256<short> lhs, in Vec256<short> rhs)
            => Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> xor(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ushort> xor(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<int> xor(in Vec256<int> lhs, in Vec256<int> rhs)
            => Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<uint> xor(in Vec256<uint> lhs, in Vec256<uint> rhs)
            => Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<long> xor(in Vec256<long> lhs, in Vec256<long> rhs)
            => Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ulong> xor(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
            => Xor(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<float> xor(in Vec256<float> lhs, in Vec256<float> rhs)
            => Xor(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Vec256<double> xor(in Vec256<double> lhs, in Vec256<double> rhs)
            => Xor(lhs, rhs);

        #endregion

        #region xor:vec -> vec -> *        

        [MethodImpl(Inline)]
        public unsafe static void xor(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs, sbyte* dst)
            => Avx2.Store(dst, xor(lhs,rhs));

        [MethodImpl(Inline)]
        public unsafe static void xor(in Vec128<byte> lhs, in Vec128<byte> rhs, byte* dst)
            => Avx2.Store(dst, xor(lhs,rhs));

        [MethodImpl(Inline)]
        public unsafe static void xor(in Vec128<short> lhs, in Vec128<short> rhs, short* dst)
            => Avx2.Store(dst, xor(lhs,rhs));

        [MethodImpl(Inline)]
        public unsafe static void xor(in Vec128<ushort> lhs, in Vec128<ushort> rhs, ushort* dst)
            => Avx2.Store(dst, xor(lhs,rhs));

        [MethodImpl(Inline)]
        public unsafe static void xor(in Vec128<int> lhs, in Vec128<int> rhs, int* dst)
            => Avx2.Store(dst, xor(lhs,rhs));

        [MethodImpl(Inline)]
        public unsafe static void xor(in Vec128<uint> lhs, in Vec128<uint> rhs, uint* dst)
            => Avx2.Store(dst, xor(lhs,rhs));

        [MethodImpl(Inline)]
        public unsafe static void xor(in Vec128<long> lhs, in Vec128<long> rhs, long* dst)
            => Avx2.Store(dst, xor(lhs,rhs));

        [MethodImpl(Inline)]
        public unsafe static void xor(in Vec128<ulong> lhs, in Vec128<ulong> rhs, ulong* dst)
            => Avx2.Store(dst, xor(lhs,rhs));

        [MethodImpl(Inline)]
        public unsafe static void xor(in Vec128<float> lhs, in Vec128<float> rhs, float* dst)
            => Avx2.Store(dst, xor(lhs,rhs));

        [MethodImpl(Inline)]
        public unsafe static void xor(in Vec128<double> lhs, in Vec128<double> rhs, double* dst)
            => Avx2.Store(dst, xor(lhs,rhs));

        [MethodImpl(Inline)]
        public unsafe static void xor(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs, sbyte* dst)
            => Avx2.Store(dst, xor(lhs,rhs));

        [MethodImpl(Inline)]
        public unsafe static void xor(in Vec256<byte> lhs, in Vec256<byte> rhs, byte* dst)
            => Avx2.Store(dst, xor(lhs,rhs));

        [MethodImpl(Inline)]
        public unsafe static void xor(in Vec256<short> lhs, in Vec256<short> rhs, short* dst)
            => Avx2.Store(dst, xor(lhs,rhs));

        [MethodImpl(Inline)]
        public unsafe static void xor(in Vec256<ushort> lhs, in Vec256<ushort> rhs, ushort* dst)
            => Avx2.Store(dst, xor(lhs,rhs));

        [MethodImpl(Inline)]
        public unsafe static void xor(in Vec256<int> lhs, in Vec256<int> rhs, int* dst)
            => Avx2.Store(dst, xor(lhs,rhs));

        [MethodImpl(Inline)]
        public unsafe static void xor(in Vec256<uint> lhs, in Vec256<uint> rhs, uint* dst)
            => Avx2.Store(dst, xor(lhs,rhs));

        [MethodImpl(Inline)]
        public unsafe static void xor(in Vec256<long> lhs, in Vec256<long> rhs, long* dst)
            => Avx2.Store(dst, xor(lhs,rhs));

        [MethodImpl(Inline)]
        public unsafe static void xor(in Vec256<ulong> lhs, in Vec256<ulong> rhs, ulong* dst)
            => Avx2.Store(dst, xor(lhs,rhs));

        [MethodImpl(Inline)]
        public unsafe static void xor(in Vec256<float> lhs, in Vec256<float> rhs, float* dst)
            => Avx2.Store(dst, xor(lhs,rhs));

        [MethodImpl(Inline)]
        public unsafe static void xor(in Vec256<double> lhs, in Vec256<double> rhs, double* dst)
            => Avx2.Store(dst, xor(lhs,rhs));

        #endregion

        #region xor:span -> span -> ref span -> ref span

        public static unsafe ref Span128<sbyte> xor(ReadOnlySpan128<sbyte> lhs, ReadOnlySpan128<sbyte> rhs, ref Span128<sbyte> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                store(xor(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span128<byte> xor(ReadOnlySpan128<byte> lhs, ReadOnlySpan128<byte> rhs, ref Span128<byte> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                store(xor(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span128<short> xor(ReadOnlySpan128<short> lhs, ReadOnlySpan128<short> rhs, ref Span128<short> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                store(xor(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span128<ushort> xor(ReadOnlySpan128<ushort> lhs, ReadOnlySpan128<ushort> rhs, ref Span128<ushort> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                store(xor(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span128<int> xor(ReadOnlySpan128<int> lhs, ReadOnlySpan128<int> rhs, ref Span128<int> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                store(xor(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span128<uint> xor(ReadOnlySpan128<uint> lhs, ReadOnlySpan128<uint> rhs, ref Span128<uint> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                store(xor(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span128<long> xor(ReadOnlySpan128<long> lhs, ReadOnlySpan128<long> rhs, ref Span128<long> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                store(xor(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span128<ulong> xor(ReadOnlySpan128<ulong> lhs, ReadOnlySpan128<ulong> rhs, ref Span128<ulong> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                store(xor(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span128<float> xor(ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs, ref Span128<float> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                store(xor(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span128<double> xor(ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs, ref Span128<double> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                store(xor(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span256<sbyte> xor(ReadOnlySpan256<sbyte> lhs, ReadOnlySpan256<sbyte> rhs, ref Span256<sbyte> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                store(xor(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span256<byte> xor(ReadOnlySpan256<byte> lhs, ReadOnlySpan256<byte> rhs, ref Span256<byte> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                store(xor(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span256<short> xor(ReadOnlySpan256<short> lhs, ReadOnlySpan256<short> rhs, ref Span256<short> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                store(xor(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span256<ushort> xor(ReadOnlySpan256<ushort> lhs, ReadOnlySpan256<ushort> rhs, ref Span256<ushort> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                store(xor(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span256<int> xor(ReadOnlySpan256<int> lhs, ReadOnlySpan256<int> rhs, ref Span256<int> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                store(xor(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span256<uint> xor(ReadOnlySpan256<uint> lhs, ReadOnlySpan256<uint> rhs, ref Span256<uint> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                store(xor(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span256<long> xor(ReadOnlySpan256<long> lhs, ReadOnlySpan256<long> rhs, ref Span256<long> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                store(xor(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span256<ulong> xor(ReadOnlySpan256<ulong> lhs, ReadOnlySpan256<ulong> rhs, ref Span256<ulong> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                store(xor(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span256<float> xor(ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs, ref Span256<float> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                store(xor(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span256<double> xor(ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs, ref Span256<double> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                store(xor(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }
        
        #endregion        
   }
}