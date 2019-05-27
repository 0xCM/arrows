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

    using static System.Runtime.Intrinsics.X86.Pclmulqdq;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse;

    using static zfunc;
    using static Spans;

    partial class dinx
    {

        [MethodImpl(Inline)]
        public static Vec128<long> clmul(in Vec128<long> lhs, in Vec128<long> rhs, byte control)
            =>  CarrylessMultiply(lhs, rhs,control);

        [MethodImpl(Inline)]
        public static Vec128<ulong> clmul(in Vec128<ulong> lhs, in Vec128<ulong> rhs, byte control)
            =>  CarrylessMultiply(lhs, rhs,control);

        [MethodImpl(Inline)]
        public static Vec128<long> mul(in Vec128<int> lhs, in Vec128<int> rhs)
            => Multiply(lhs, rhs);
            
        [MethodImpl(Inline)]
        public static Vec128<ulong> mul(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => Multiply(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> mul(in Vec128<float> lhs,in Vec128<float> rhs)
            => Multiply(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> mul(in Vec128<double> lhs,in Vec128<double> rhs)
            => Multiply(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<long> mul(in Vec256<int> lhs,in Vec256<int> rhs)
            => Multiply(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ulong> mul(in Vec256<uint> lhs,in Vec256<uint> rhs)
            => Multiply(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<float> mul(in Vec256<float> lhs,in Vec256<float> rhs)
            => Multiply(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<double> mul(in Vec256<double> lhs, in Vec256<double> rhs)
            => Multiply(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static void mul(in Vec128<int> lhs, in Vec128<int> rhs, ref long dst)
            => store(Multiply(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void mul(in Vec128<uint> lhs, in Vec128<uint> rhs, ref ulong dst)
            => store(Multiply(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void mul(in Vec128<float> lhs, in Vec128<float> rhs, ref float dst)
            => store(Multiply(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void mul(in Vec128<double> lhs, in Vec128<double> rhs, ref double dst)
            => store(Multiply(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void mul(in Vec256<int> lhs, in Vec256<int> rhs, ref long dst)
            => store(Multiply(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void mul(in Vec256<uint> lhs, in Vec256<uint> rhs, ref ulong dst)
            => store(Multiply(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void mul(in Vec256<float> lhs, in Vec256<float> rhs, ref float dst)
            => store(Multiply(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void mul(in Vec256<double> lhs, in Vec256<double> rhs, ref double dst)
            => store(Multiply(lhs, rhs), ref dst);

        public static ref Span128<long> mul(ReadOnlySpan128<int> lhs, ReadOnlySpan128<int> rhs, ref Span128<long> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.VLoad(i);
                var y = rhs.VLoad(i);
                store(Multiply(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static ref Span128<ulong> mul(ReadOnlySpan128<uint> lhs, ReadOnlySpan128<uint> rhs, ref Span128<ulong> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.VLoad(i);
                var y = rhs.VLoad(i);
                store(Multiply(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static ref Span128<float> mul(ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs, ref Span128<float> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.VLoad(i);
                var y = rhs.VLoad(i);
                store(Multiply(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static ref Span128<double> mul(ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs, ref Span128<double> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.VLoad(i);
                var y = rhs.VLoad(i);
                store(Multiply(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span256<long> mul(ReadOnlySpan256<int> lhs, ReadOnlySpan256<int> rhs, ref Span256<long> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.VLoad(i);
                var y = rhs.VLoad(i);
                store(Multiply(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span256<ulong> mul(ReadOnlySpan256<uint> lhs, ReadOnlySpan256<uint> rhs, ref Span256<ulong> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.VLoad(i);
                var y = rhs.VLoad(i);
                store(Multiply(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span256<float> mul(ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs, ref Span256<float> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.VLoad(i);
                var y = rhs.VLoad(i);
                store(Multiply(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span256<double> mul(ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs,ref Span256<double> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.VLoad(i);
                var y = rhs.VLoad(i);
                store(Multiply(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }
    }
}