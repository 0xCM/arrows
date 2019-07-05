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
    
    using static zfunc;    
    using static As;
    using static Span256;
    using static Span128;


    partial class dinxx
    {
        [MethodImpl(Inline)]
        public static Vec256<sbyte> Or(this in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => dinx.or(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec256<byte> Or(this in Vec256<byte> lhs, in Vec256<byte> rhs)
            => dinx.or(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> Or(this in Vec256<short> lhs, in Vec256<short> rhs)
            => dinx.or(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec256<ushort> Or(this in Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => dinx.or(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec256<int> Or(this in Vec256<int> lhs, in Vec256<int> rhs)
            => dinx.or(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec256<uint> Or(this in Vec256<uint> lhs, in Vec256<uint> rhs)
            => dinx.or(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec256<long> Or(this in Vec256<long> lhs, in Vec256<long> rhs)
            => dinx.or(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static Vec256<ulong> Or(this in Vec256<ulong> lhs, in Vec256<ulong> rhs)
            => dinx.or(in lhs, in rhs);

        [MethodImpl(Inline)]
        public static void Or(this in Vec256<sbyte> lhs, in Vec256<sbyte> rhs, ref sbyte dst)
            => dinx.or(in lhs, in rhs, ref dst);

        [MethodImpl(Inline)]
        public static void Or(this in Vec256<byte> lhs, in Vec256<byte> rhs, ref byte dst)
            => dinx.or(in lhs, in rhs, ref dst);

        [MethodImpl(Inline)]
        public static void Or(this in Vec256<short> lhs, in Vec256<short> rhs, ref short dst)
            => dinx.or(in lhs, in rhs, ref dst);

        [MethodImpl(Inline)]
        public static void Or(this in Vec256<ushort> lhs, in Vec256<ushort> rhs, ref ushort dst)
            => dinx.or(in lhs, in rhs, ref dst);

        [MethodImpl(Inline)]
        public static void Or(this in Vec256<int> lhs, in Vec256<int> rhs, ref int dst)
            => dinx.or(in lhs, in rhs, ref dst);

        [MethodImpl(Inline)]
        public static void Or(this in Vec256<uint> lhs, in Vec256<uint> rhs, ref uint dst)
            => dinx.or(in lhs, in rhs, ref dst);

        [MethodImpl(Inline)]
        public static void Or(this in Vec256<long> lhs, in Vec256<long> rhs, ref long dst)
            => dinx.or(in lhs, in rhs, ref dst);

        [MethodImpl(Inline)]
        public static void Or(this in Vec256<ulong> lhs, in Vec256<ulong> rhs, ref ulong dst)
            => dinx.or(in lhs, in rhs, ref dst);

        public static Span128<int> or(ReadOnlySpan128<int> lhs, ReadOnlySpan128<int> rhs, Span128<int> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                dinx.or(lhs.LoadVec128(i), rhs.LoadVec128(i), ref dst[i]);            
            return dst;            
        }

        public static Span128<uint> or(ReadOnlySpan128<uint> lhs, ReadOnlySpan128<uint> rhs, Span128<uint> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                dinx.or(lhs.LoadVec128(i), rhs.LoadVec128(i), ref dst[i]);            
            return dst;            
        }

        public static Span128<long> or(ReadOnlySpan128<long> lhs, ReadOnlySpan128<long> rhs, Span128<long> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                dinx.or(lhs.LoadVec128(i), rhs.LoadVec128(i), ref dst[i]);            
            return dst;            
        }

        public static Span128<ulong> or(ReadOnlySpan128<ulong> lhs, ReadOnlySpan128<ulong> rhs, Span128<ulong> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                dinx.or(lhs.LoadVec128(i), rhs.LoadVec128(i), ref dst[i]);            
            return dst;            
        }

        public static Span128<float> or(ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs, Span128<float> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                dinx.or(lhs.LoadVec128(i), rhs.LoadVec128(i), ref dst[i]);            
            return dst;            
        }

        public static Span128<double> or(ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs, Span128<double> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                dinx.or(lhs.LoadVec128(i), rhs.LoadVec128(i), ref dst[i]);            
            return dst;            
        }

        public static Span256<sbyte> or(ReadOnlySpan256<sbyte> lhs, ReadOnlySpan256<sbyte> rhs, Span256<sbyte> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                dinx.or(lhs.LoadVec256(i), rhs.LoadVec256(i), ref dst[i]);            
            return dst;            
        }

        public static Span256<byte> or(ReadOnlySpan256<byte> lhs, ReadOnlySpan256<byte> rhs, Span256<byte> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                dinx.or(lhs.LoadVec256(i), rhs.LoadVec256(i), ref dst[i]);            
            return dst;            
        }

        public static Span256<short> or(ReadOnlySpan256<short> lhs, ReadOnlySpan256<short> rhs, Span256<short> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                dinx.or(lhs.LoadVec256(i), rhs.LoadVec256(i), ref dst[i]);            
            return dst;            
        }

        public static Span256<ushort> or(ReadOnlySpan256<ushort> lhs, ReadOnlySpan256<ushort> rhs, Span256<ushort> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                dinx.or(lhs.LoadVec256(i), rhs.LoadVec256(i), ref dst[i]);            
            return dst;            
        }

        public static Span256<int> or(ReadOnlySpan256<int> lhs, ReadOnlySpan256<int> rhs, Span256<int> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                dinx.or(lhs.LoadVec256(i), rhs.LoadVec256(i), ref dst[i]);            
            return dst;            
        }

        public static Span256<uint> or(ReadOnlySpan256<uint> lhs, ReadOnlySpan256<uint> rhs, Span256<uint> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                dinx.or(lhs.LoadVec256(i), rhs.LoadVec256(i), ref dst[i]);            
            return dst;            
        }

        public static Span256<long> or(ReadOnlySpan256<long> lhs, ReadOnlySpan256<long> rhs, Span256<long> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                dinx.or(lhs.LoadVec256(i), rhs.LoadVec256(i), ref dst[i]);            
            return dst;            
        }

        public static Span256<ulong> or(ReadOnlySpan256<ulong> lhs, ReadOnlySpan256<ulong> rhs, Span256<ulong> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                dinx.or(lhs.LoadVec256(i), rhs.LoadVec256(i), ref dst[i]);            
            return dst;            
        }

 

        public static Span128<short> or(ReadOnlySpan128<short> lhs, ReadOnlySpan128<short> rhs, Span128<short> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                dinx.or(lhs.LoadVec128(i), rhs.LoadVec128(i), ref dst[i]);            
            return dst;            
        }

        public static Span128<ushort> or(ReadOnlySpan128<ushort> lhs, ReadOnlySpan128<ushort> rhs, Span128<ushort> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                dinx.or(lhs.LoadVec128(i), rhs.LoadVec128(i), ref dst[i]);            
            return dst;            
        }

        public static Span128<sbyte> or(ReadOnlySpan128<sbyte> lhs, ReadOnlySpan128<sbyte> rhs, Span128<sbyte> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                dinx.or(lhs.LoadVec128(i), rhs.LoadVec128(i), ref dst[i]);            
            return dst;            
        }

        public static Span128<byte> or(ReadOnlySpan128<byte> lhs, ReadOnlySpan128<byte> rhs, Span128<byte> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                dinx.or(lhs.LoadVec128(i), rhs.LoadVec128(i), ref dst[i]);            
            return dst;            
        }

       public static Span256<float> or(ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs, Span256<float> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                dinx.or(lhs.LoadVec256(i), rhs.LoadVec256(i), ref dst[i]);            
            return dst;            
        }

        public static Span256<double> or(ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs, Span256<double> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
                dinx.or(lhs.LoadVec256(i), rhs.LoadVec256(i), ref dst[i]);            
            return dst;            
        }
 
    }
}