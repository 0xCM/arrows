//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;

    using static zfunc;    
    
    partial class MathX
    {
        [MethodImpl(Inline)]
        public static ref sbyte Abs(this ref sbyte src)
            => ref math.abs(ref src);

        [MethodImpl(Inline)]
        public static ref short Abs(this ref short src)
            => ref math.abs(ref src);

        [MethodImpl(Inline)]
        public static ref int Abs(this ref int src)
            => ref math.abs(ref src);

        [MethodImpl(Inline)]
        public static ref long Abs(this ref long src)
            => ref math.abs(ref src);

        [MethodImpl(Inline)]
        public static ref float Abs(this ref float src)
            => ref math.abs(ref src);

        [MethodImpl(Inline)]
        public static ref double Abs(this ref double src)
            => ref math.abs(ref src);

        [MethodImpl(Inline)]
        public static Span<sbyte> Abs(this Span<sbyte> io)
            => abs(io);

        [MethodImpl(Inline)]
        public static Span<short> Abs(this Span<short> io)
            => abs(io);

        [MethodImpl(Inline)]
        public static Span<int> Abs(this Span<int> io)
            => abs(io);

        [MethodImpl(Inline)]
        public static Span<long> Abs(this Span<long> io)
            => abs(io);

        [MethodImpl(Inline)]
        public static Span<float> Abs(this Span<float> io)
            => abs(io);

        [MethodImpl(Inline)]
        public static Span<double> Abs(this Span<double> io)
            => abs(io);

        [MethodImpl(Inline)]
        public static Span<sbyte> Abs(this ReadOnlySpan<sbyte> src)
            => abs(src, span<sbyte>(src.Length));

        [MethodImpl(Inline)]
        public static Span<short> Abs(this ReadOnlySpan<short> src)
            => abs(src, span<short>(src.Length));

        [MethodImpl(Inline)]
        public static Span<int> Abs(this ReadOnlySpan<int> src)
            => abs(src, span<int>(src.Length));

        [MethodImpl(Inline)]
        public static Span<long> Abs(this ReadOnlySpan<long> src)
            => abs(src, span<long>(src.Length));

        [MethodImpl(Inline)]
        public static Span<float> Abs(this ReadOnlySpan<float> src)
            => abs(src, span<float>(src.Length));

        [MethodImpl(Inline)]
        public static Span<double> Abs(this ReadOnlySpan<double> src)
            => abs(src, span<double>(src.Length));

        [MethodImpl(Inline)]
        public static ReadOnlySpan<sbyte> Abs(this ReadOnlySpan<sbyte> src, Span<sbyte> dst)
            => abs(src,dst);            

        [MethodImpl(Inline)]
        public static ReadOnlySpan<short> Abs(this ReadOnlySpan<short> src, Span<short> dst)
            => abs(src,dst);            

        [MethodImpl(Inline)]
        public static ReadOnlySpan<int> Abs(this ReadOnlySpan<int> src, Span<int> dst)
            => abs(src,dst);            

        [MethodImpl(Inline)]
        public static ReadOnlySpan<long> Abs(this ReadOnlySpan<long> src, Span<long> dst)
            => abs(src,dst);            

        [MethodImpl(Inline)]
        public static ReadOnlySpan<float> Abs(this ReadOnlySpan<float> src, Span<float> dst )
            => abs(src,dst);            

        [MethodImpl(Inline)]
        public static ReadOnlySpan<double> Abs(this ReadOnlySpan<double> src, Span<double> dst )
            => abs(src,dst);            

        [MethodImpl(Inline)]
        public static ReadOnlySpan<short> Abs(this short[] src, short[] dst)
            => abs(src,dst);            

        [MethodImpl(Inline)]
        public static ReadOnlySpan<int> Abs(this int[] src, int[] dst)
            => abs(src,dst);            

        [MethodImpl(Inline)]
        public static ReadOnlySpan<long> Abs(this long[] src, long[] dst)
            => abs(src,dst);            

        [MethodImpl(Inline)]
        public static ReadOnlySpan<float> Abs(this float[] src, float[] dst)
            => abs(src,dst);            

        [MethodImpl(Inline)]
        public static ReadOnlySpan<double> Abs(this double[] src, double[] dst )
            => abs(src,dst);            

        static Span<sbyte> abs(ReadOnlySpan<sbyte> src, Span<sbyte> dst)
        {
            var len = length(src,dst);
            for(var i = 0; i< len; i++)
                math.abs(src[i], out dst[i]);
            return dst;
        }

        static Span<short> abs(ReadOnlySpan<short> src, Span<short> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                math.abs(src[i], out dst[i]);
            return dst;
        }

        static Span<int> abs(ReadOnlySpan<int> src, Span<int> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                math.abs(src[i], out dst[i]);
            return dst;
        }

        static Span<long> abs(ReadOnlySpan<long> src, Span<long> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                math.abs(src[i], out dst[i]);
            return dst;
        }

        static Span<float> abs(ReadOnlySpan<float> src, Span<float> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                math.abs(src[i], out dst[i]);
            return dst;
        }

        static Span<double> abs(ReadOnlySpan<double> src, Span<double> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                math.abs(src[i], out dst[i]);
            return dst;
        }

        [MethodImpl(NotInline)]
        static Span<sbyte> abs(Span<sbyte> io)
        {
            for(var i = 0; i< io.Length; i++)
                math.abs(ref io[i]);
            return io;
        }

        static Span<short> abs(Span<short> io)
        {
            for(var i = 0; i< io.Length; i++)
                math.abs(ref io[i]);
            return io;
        }

        static Span<int> abs(Span<int> io)
        {
            for(var i = 0; i< io.Length; i++)
                math.abs(ref io[i]);
            return io;
        }

        static Span<long> abs(Span<long> io)
        {
            for(var i = 0; i< io.Length; i++)
                math.abs(ref io[i]);
            return io;
        }

        static Span<float> abs(Span<float> io)
        {
            for(var i = 0; i< io.Length; i++)
                math.abs(ref io[i]);
            return io;
        }

        static Span<double> abs(Span<double> io)
        {
            for(var i = 0; i< io.Length; i++)
                math.abs(ref io[i]);
            return io;
        } 
    }
}