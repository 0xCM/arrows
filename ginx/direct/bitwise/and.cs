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
    
    using static As;
    using static zfunc;
    using static Spans;

    partial class dinx
    {

        [MethodImpl(Inline)]
        public static Vec128<byte> and(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> and(in Vec128<short> lhs, in Vec128<short> rhs)
            => And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> and(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> and(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> and(in Vec128<int> lhs, in Vec128<int> rhs)
            => And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<uint> and(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<long> and(in Vec128<long> lhs, in Vec128<long> rhs)
            => And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ulong> and(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> and(in Vec128<float> lhs, in Vec128<float> rhs)
            => And(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Vec128<double> and(in Vec128<double> lhs, in Vec128<double> rhs)
            => And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<byte> and(in Vec256<byte> lhs, in Vec256<byte> rhs)
            => And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> and(in Vec256<short> lhs, in Vec256<short> rhs)
            => And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> and(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ushort> and(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<int> and(in Vec256<int> lhs, in Vec256<int> rhs)
            => And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<uint> and(in Vec256<uint> lhs, in Vec256<uint> rhs)
            => And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<long> and(in Vec256<long> lhs, in Vec256<long> rhs)
            => And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ulong> and(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
            => And(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<float> and(in Vec256<float> lhs, in Vec256<float> rhs)
            => And(lhs, rhs);
        
        [MethodImpl(Inline)]
        public static Vec256<double> and(in Vec256<double> lhs, in Vec256<double> rhs)
            => And(lhs, rhs);

        [MethodImpl(Inline)]
        public static unsafe void and(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs, ref sbyte dst)
            => Store(pint8(ref dst), And(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void and(in Vec128<byte> lhs, in Vec128<byte> rhs, ref byte dst)
            => Store(puint8(ref dst), And(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void and(in Vec128<short> lhs, in Vec128<short> rhs, ref short dst)
            => Store(pint16(ref dst), And(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void and(in Vec128<ushort> lhs, in Vec128<ushort> rhs, ref ushort dst)
            => Store(puint16(ref dst), And(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void and(in Vec128<int> lhs, in Vec128<int> rhs, ref int dst)
            => Store(pint32(ref dst), And(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void and(in Vec128<uint> lhs, in Vec128<uint> rhs, ref uint dst)
            => Store(puint32(ref dst), And(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void and(in Vec128<long> lhs, in Vec128<long> rhs, ref long dst)
            => Store(pint64(ref dst), And(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void and(in Vec128<ulong> lhs, in Vec128<ulong> rhs, ref ulong dst)
            => Store(puint64(ref dst), And(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void and(in Vec128<float> lhs, in Vec128<float> rhs, ref float dst)
            => Store(pfloat32(ref dst), And(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void and(in Vec128<double> lhs, in Vec128<double> rhs, ref double dst)
            => Store(pfloat64(ref dst), And(lhs,rhs));

        [MethodImpl(Inline)]
        public static unsafe void and(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs, ref sbyte dst)
            => Store(pint8(ref dst), And(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void and(in Vec256<byte> lhs, in Vec256<byte> rhs, ref byte dst)
            => Store(puint8(ref dst), And(lhs,rhs));

        [MethodImpl(Inline)]
        public static unsafe void and(in Vec256<short> lhs, in Vec256<short> rhs, ref short dst)
            => Store(pint16(ref dst), And(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void and(in Vec256<ushort> lhs, in Vec256<ushort> rhs, ref ushort dst)
            => Store(puint16(ref dst), And(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void and(in Vec256<int> lhs, in Vec256<int> rhs, ref int dst)
            => Store(pint32(ref dst), And(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void and(in Vec256<uint> lhs, in Vec256<uint> rhs, ref uint dst)
            => Store(puint32(ref dst), And(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void and(in Vec256<long> lhs, in Vec256<long> rhs, ref long dst)
            => Store(pint64(ref dst), And(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void and(in Vec256<ulong> lhs, in Vec256<ulong> rhs, ref ulong dst)
            => Store(puint64(ref dst), And(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void and(in Vec256<float> lhs, in Vec256<float> rhs, ref float dst)
            => Store(pfloat32(ref dst), And(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void and(in Vec256<double> lhs, in Vec256<double> rhs, ref double dst)
            => Store(pfloat64(ref dst), And(lhs, rhs));
 
        public static unsafe ref Span128<sbyte> and(ReadOnlySpan128<sbyte> lhs, ReadOnlySpan128<sbyte> rhs, ref Span128<sbyte> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                and(x, y, ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span128<byte> and(ReadOnlySpan128<byte> lhs, ReadOnlySpan128<byte> rhs, ref Span128<byte> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                and(x, y, ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span128<short> and(ReadOnlySpan128<short> lhs, ReadOnlySpan128<short> rhs, ref Span128<short> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                and(x, y, ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span128<ushort> and(ReadOnlySpan128<ushort> lhs, ReadOnlySpan128<ushort> rhs, ref Span128<ushort> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                and(x, y, ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span128<int> and(ReadOnlySpan128<int> lhs, ReadOnlySpan128<int> rhs, ref Span128<int> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                and(x, y, ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span128<uint> and(ReadOnlySpan128<uint> lhs, ReadOnlySpan128<uint> rhs, ref Span128<uint> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                and(x, y, ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span128<long> and(ReadOnlySpan128<long> lhs, ReadOnlySpan128<long> rhs, ref Span128<long> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                and(x, y, ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span128<ulong> and(ReadOnlySpan128<ulong> lhs, ReadOnlySpan128<ulong> rhs, ref Span128<ulong> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                and(x, y, ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span128<float> and(ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs, ref Span128<float> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                and(x, y, ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span128<double> and(ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs, ref Span128<double> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                and(x, y, ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span256<sbyte> and(ReadOnlySpan256<sbyte> lhs, ReadOnlySpan256<sbyte> rhs, ref Span256<sbyte> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                and(x, y, ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span256<byte> and(ReadOnlySpan256<byte> lhs, ReadOnlySpan256<byte> rhs, ref Span256<byte> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                and(x, y, ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span256<short> and(ReadOnlySpan256<short> lhs, ReadOnlySpan256<short> rhs, ref Span256<short> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                and(x, y, ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span256<ushort> and(ReadOnlySpan256<ushort> lhs, ReadOnlySpan256<ushort> rhs, ref Span256<ushort> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                and(x, y, ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span256<int> and(ReadOnlySpan256<int> lhs, ReadOnlySpan256<int> rhs, ref Span256<int> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                and(x, y, ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span256<uint> and(ReadOnlySpan256<uint> lhs, ReadOnlySpan256<uint> rhs, ref Span256<uint> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                and(x, y, ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span256<long> and(ReadOnlySpan256<long> lhs, ReadOnlySpan256<long> rhs, ref Span256<long> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                and(x, y, ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span256<ulong> and(ReadOnlySpan256<ulong> lhs, ReadOnlySpan256<ulong> rhs, ref Span256<ulong> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                and(x, y, ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span256<float> and(ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs, ref Span256<float> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                and(x, y, ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span256<double> and(ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs, ref Span256<double> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                and(x, y, ref dst[i]);
            }
            
            return ref dst;            
        }
   }
}