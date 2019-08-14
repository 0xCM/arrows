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
        public static ref sbyte Sqrt(this ref sbyte src)
            => ref math.sqrt(ref src);

        [MethodImpl(Inline)]
        public static ref byte Sqrt(this ref byte src)
            => ref math.sqrt(ref src);

        [MethodImpl(Inline)]
        public static ref short Sqrt(this ref short src)
            => ref math.sqrt(ref src);

        [MethodImpl(Inline)]
        public static ref ushort Sqrt(this ref ushort src)
            => ref math.sqrt(ref src);

        [MethodImpl(Inline)]
        public static ref int Sqrt(this ref int src)
            => ref math.sqrt(ref src);

        [MethodImpl(Inline)]
        public static ref uint Sqrt(this ref uint src)
            => ref math.sqrt(ref src);

        [MethodImpl(Inline)]
        public static ref long Sqrt(this ref long src)
            => ref math.sqrt(ref src);

        [MethodImpl(Inline)]
        public static ref ulong Sqrt(this ref ulong src)
            => ref math.sqrt(ref src);

        [MethodImpl(Inline)]
        public static ref float Sqrt(this ref float src)
            => ref math.sqrt(ref src);

        [MethodImpl(Inline)]
        public static ref double Sqrt(this ref double src)
            => ref math.sqrt(ref src);
 
        public static ReadOnlySpan<sbyte> Sqrt(this ReadOnlySpan<sbyte> src, Span<sbyte> dst)
        {
            var len = length(src,dst);
            for(var i = 0; i< len; i++)
                math.sqrt(src[i], out dst[i]);
            return dst;                
        }

        public static Span<byte> Sqrt(this ReadOnlySpan<byte> src, Span<byte> dst)
        {
            var len = length(src,dst);
            for(var i = 0; i< len; i++)
                math.sqrt(src[i], out dst[i]);
            return dst;
        }

        public static Span<ushort> Sqrt(this ReadOnlySpan<ushort> src, Span<ushort> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                math.sqrt(src[i], out dst[i]);
            return dst;                
        }

        public static ReadOnlySpan<short> Sqrt(this ReadOnlySpan<short> src, Span<short> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                math.sqrt(src[i], out dst[i]);
            return dst;                
        }

        [MethodImpl(Inline)]
        public static ReadOnlySpan<int> Sqrt(this ReadOnlySpan<int> src, Span<int> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                math.sqrt(src[i], out dst[i]);
            return dst;                
        }

        public static Span<uint> Sqrt(this ReadOnlySpan<uint> src, Span<uint> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                math.sqrt(src[i], out dst[i]);
            return dst;                
        }

        public static ReadOnlySpan<long> Sqrt(this ReadOnlySpan<long> src, Span<long> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                math.sqrt(src[i], out dst[i]);
            return dst;                
        }

        public static Span<ulong> Sqrt(this ReadOnlySpan<ulong> src, Span<ulong> dst)
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                math.sqrt(src[i], out dst[i]);
            return dst;                
        }

        public static ReadOnlySpan<float> Sqrt(this ReadOnlySpan<float> src, Span<float> dst )
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                math.sqrt(src[i], out dst[i]);
            return dst;                
        }

        public static ReadOnlySpan<double> Sqrt(this ReadOnlySpan<double> src, Span<double> dst )
        {
            var len = length(src, dst);
            for(var i = 0; i< len; i++)
                math.sqrt(src[i], out dst[i]);
            return dst;                
        }
 
        public static Span<sbyte> Sqrt(this Span<sbyte> io)
        {
            for(var i = 0; i< io.Length; i++)
                math.sqrt(ref io[i]);
            return io;
        }

        public static Span<byte> Sqrt(this Span<byte> io)
        {
            for(var i = 0; i< io.Length; i++)
                math.sqrt(ref io[i]);
            return io;
        }

        public static Span<short> Sqrt(this Span<short> io)
        {
            for(var i = 0; i< io.Length; i++)
                math.sqrt(ref io[i]);
            return io;
        }

        public static Span<ushort> Sqrt(this Span<ushort> io)
        {
            for(var i = 0; i< io.Length; i++)
                math.sqrt(ref io[i]);
            return io;
        }

        public static Span<int> Sqrt(this Span<int> io)
        {
            for(var i = 0; i< io.Length; i++)
                math.sqrt(ref io[i]);
            return io;
        }

        public static Span<uint> Sqrt(this Span<uint> io)
        {
            for(var i = 0; i< io.Length; i++)
                math.sqrt(ref io[i]);
            return io;
        }

        public static Span<long> Sqrt(this Span<long> io)
        {
            for(var i = 0; i< io.Length; i++)
                math.sqrt(ref io[i]);
            return io;
        }

        public static Span<ulong> Sqrt(this Span<ulong> io)
        {
            for(var i = 0; i< io.Length; i++)
                math.sqrt(ref io[i]);
            return io;
        }

        public static Span<float> Sqrt(this Span<float> io)
        {
            for(var i = 0; i< io.Length; i++)
                math.sqrt(ref io[i]);
            return io;
        }

        public static Span<double> Sqrt(this Span<double> io)
        {
            for(var i = 0; i< io.Length; i++)
                math.sqrt(ref io[i]);
            return io;
        }

   }

}