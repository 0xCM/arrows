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
 
        [MethodImpl(Inline)]
        public static ReadOnlySpan<sbyte> Sqrt(this ReadOnlySpan<sbyte> src, Span<sbyte> dst)
            => math.sqrt(src,dst);            

        [MethodImpl(Inline)]
        public static ReadOnlySpan<short> Sqrt(this ReadOnlySpan<short> src, Span<short> dst)
            => math.sqrt(src,dst);            

        [MethodImpl(Inline)]
        public static ReadOnlySpan<int> Sqrt(this ReadOnlySpan<int> src, Span<int> dst)
            => math.sqrt(src,dst);            

        [MethodImpl(Inline)]
        public static ReadOnlySpan<long> Sqrt(this ReadOnlySpan<long> src, Span<long> dst)
            => math.sqrt(src,dst);            

        [MethodImpl(Inline)]
        public static ReadOnlySpan<float> Sqrt(this ReadOnlySpan<float> src, Span<float> dst )
            => math.sqrt(src,dst);            

        [MethodImpl(Inline)]
        public static ReadOnlySpan<double> Sqrt(this ReadOnlySpan<double> src, Span<double> dst )
            => math.sqrt(src,dst);            
 
        [MethodImpl(Inline)]
        public static Span<sbyte> Sqrt(this Span<sbyte> io)
            => math.sqrt(io);

        [MethodImpl(Inline)]
        public static Span<byte> Sqrt(this Span<byte> io)
            => math.sqrt(io);

        [MethodImpl(Inline)]
        public static Span<short> Sqrt(this Span<short> io)
            => math.sqrt(io);

        [MethodImpl(Inline)]
        public static Span<ushort> Sqrt(this Span<ushort> io)
            => math.sqrt(io);

        [MethodImpl(Inline)]
        public static Span<int> Sqrt(this Span<int> io)
            => math.sqrt(io);

        [MethodImpl(Inline)]
        public static Span<uint> Sqrt(this Span<uint> io)
            => math.sqrt(io);

        [MethodImpl(Inline)]
        public static Span<long> Sqrt(this Span<long> io)
            => math.sqrt(io);

        [MethodImpl(Inline)]
        public static Span<ulong> Sqrt(this Span<ulong> io)
            => math.sqrt(io);

        [MethodImpl(Inline)]
        public static Span<float> Sqrt(this Span<float> io)
            => math.sqrt(io);

        [MethodImpl(Inline)]
        public static Span<double> Sqrt(this Span<double> io)
            => math.sqrt(io);

   }

}