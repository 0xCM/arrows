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

    using static zfunc;
    using static Spans;
    using static As;

    partial class dinx
    {
        #region vec -> vec -> vec

        [MethodImpl(Inline)]
        public static Vec128<byte> sub(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => Subtract(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> sub(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => Subtract(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> sub(in Vec128<short> lhs, in Vec128<short> rhs)
            => Subtract(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> sub(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => Subtract(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> sub(in Vec128<int> lhs, in Vec128<int> rhs)
            => Subtract(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<uint> sub(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => Avx2.Subtract(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<long> sub(in Vec128<long> lhs, in Vec128<long> rhs)
            => Avx2.Subtract(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<ulong> sub(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => Avx2.Subtract(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> sub(in Vec128<float> lhs, in Vec128<float> rhs)
            => Avx2.Subtract(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> sub(in Vec128<double> lhs, in Vec128<double> rhs)
            => Avx2.Subtract(lhs,rhs);
 
        [MethodImpl(Inline)]
        public static Vec256<byte> sub(in Vec256<byte> lhs, in Vec256<byte> rhs)
            => Avx2.Subtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> sub(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => Avx2.Subtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> sub(in Vec256<short> lhs, in Vec256<short> rhs)
            => Subtract(lhs, rhs);


        [MethodImpl(Inline)]
        public static Vec256<ushort> sub(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => Subtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<int> sub(in Vec256<int> lhs, in Vec256<int> rhs)
            => Subtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<uint> sub(in Vec256<uint> lhs, in Vec256<uint> rhs)
            => Subtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<long> sub(in Vec256<long> lhs, in Vec256<long> rhs)
            => Subtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ulong> sub(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
            => Subtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<float> sub(in Vec256<float> lhs, in Vec256<float> rhs)
            => Subtract(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<double> sub(in Vec256<double> lhs, in Vec256<double> rhs)
            => Avx2.Subtract(lhs, rhs);
        #endregion

        #region vec -> vec -> *

        [MethodImpl(Inline)]
        public static unsafe void sub(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs, ref sbyte dst)
            => store(Subtract(lhs,rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void sub(in Vec128<byte> lhs, in Vec128<byte> rhs, ref byte dst)
            => store(Subtract(lhs,rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void sub(in Vec128<short> lhs, in Vec128<short> rhs, ref short dst)
            => store(Subtract(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void sub(in Vec128<ushort> lhs, in Vec128<ushort> rhs, ref ushort dst)
            => store(Subtract(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void sub(in Vec128<int> lhs, in Vec128<int> rhs, ref int dst)
            => store(Subtract(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void sub(in Vec128<uint> lhs, in Vec128<uint> rhs, ref uint dst)
            => store(Subtract(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void sub(in Vec128<long> lhs, in Vec128<long> rhs, ref long dst)
            => store(Subtract(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void sub(in Vec128<ulong> lhs, in Vec128<ulong> rhs, ref ulong dst)
            => store(Subtract(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void sub(in Vec128<float> lhs, in Vec128<float> rhs, ref float dst)
            => store(sub(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static unsafe void sub(in Vec128<double> lhs, in Vec128<double> rhs, ref double dst)
            => store(sub(lhs, rhs), ref dst);


        [MethodImpl(Inline)]
        public static unsafe void sub(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs, ref sbyte dst)
            => Store(pint8(ref dst), Subtract(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void sub(in Vec256<byte> lhs, in Vec256<byte> rhs, ref byte dst)
            => Store(puint8(ref dst), Subtract(lhs,rhs));

        [MethodImpl(Inline)]
        public static unsafe void sub(in Vec256<short> lhs, in Vec256<short> rhs, ref short dst)
            => Store(pint16(ref dst), Subtract(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void sub(in Vec256<ushort> lhs, in Vec256<ushort> rhs, ref ushort dst)
            => Store(puint16(ref dst), Subtract(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void sub(in Vec256<int> lhs, in Vec256<int> rhs, ref int dst)
            => Store(pint32(ref dst), Subtract(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void sub(in Vec256<uint> lhs, in Vec256<uint> rhs, ref uint dst)
            => Store(puint32(ref dst), Subtract(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void sub(in Vec256<long> lhs, in Vec256<long> rhs, ref long dst)
            => Store(pint64(ref dst), Subtract(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void sub(in Vec256<ulong> lhs, in Vec256<ulong> rhs, ref ulong dst)
            => Store(puint64(ref dst), Subtract(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void sub(in Vec256<float> lhs, in Vec256<float> rhs, ref float dst)
            => Store(pfloat32(ref dst), Subtract(lhs, rhs));

        [MethodImpl(Inline)]
        public static unsafe void sub(in Vec256<double> lhs, in Vec256<double> rhs, ref double dst)
            => Store(pfloat64(ref dst), Subtract(lhs, rhs));

        #endregion

        #region span -> span -> ref span -> ref span

        public static unsafe ref Span128<sbyte> sub(ReadOnlySpan128<sbyte> lhs, ReadOnlySpan128<sbyte> rhs, ref Span128<sbyte> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                store(Subtract(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span128<byte> sub(ReadOnlySpan128<byte> lhs, ReadOnlySpan128<byte> rhs, ref Span128<byte> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                store(Subtract(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span128<short> sub(ReadOnlySpan128<short> lhs, ReadOnlySpan128<short> rhs, ref Span128<short> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                store(Subtract(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span128<ushort> sub(ReadOnlySpan128<ushort> lhs, ReadOnlySpan128<ushort> rhs, ref Span128<ushort> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                store(Subtract(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span128<int> sub(ReadOnlySpan128<int> lhs, ReadOnlySpan128<int> rhs, ref Span128<int> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                store(dinx.sub(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span128<uint> sub(ReadOnlySpan128<uint> lhs, ReadOnlySpan128<uint> rhs, ref Span128<uint> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                store(Subtract(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span128<long> sub(ReadOnlySpan128<long> lhs, ReadOnlySpan128<long> rhs, ref Span128<long> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                store(Subtract(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span128<ulong> sub(ReadOnlySpan128<ulong> lhs, ReadOnlySpan128<ulong> rhs, ref Span128<ulong> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                store(Subtract(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span128<float> sub(ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs, ref Span128<float> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                store(Subtract(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span128<double> sub(ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs, ref Span128<double> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                store(Subtract(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span256<sbyte> sub(ReadOnlySpan256<sbyte> lhs, ReadOnlySpan256<sbyte> rhs, ref Span256<sbyte> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                store(Subtract(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span256<byte> sub(ReadOnlySpan256<byte> lhs, ReadOnlySpan256<byte> rhs, ref Span256<byte> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                store(Subtract(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span256<short> sub(ReadOnlySpan256<short> lhs, ReadOnlySpan256<short> rhs, ref Span256<short> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                store(Subtract(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span256<ushort> sub(ReadOnlySpan256<ushort> lhs, ReadOnlySpan256<ushort> rhs, ref Span256<ushort> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                store(Subtract(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span256<int> sub(ReadOnlySpan256<int> lhs, ReadOnlySpan256<int> rhs, ref Span256<int> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                store(Subtract(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span256<uint> sub(ReadOnlySpan256<uint> lhs, ReadOnlySpan256<uint> rhs, ref Span256<uint> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                store(Subtract(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span256<long> sub(ReadOnlySpan256<long> lhs, ReadOnlySpan256<long> rhs, ref Span256<long> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                store(Subtract(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span256<ulong> sub(ReadOnlySpan256<ulong> lhs, ReadOnlySpan256<ulong> rhs, ref Span256<ulong> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                store(Subtract(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span256<float> sub(ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs, ref Span256<float> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                store(Subtract(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static unsafe ref Span256<double> sub(ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs, ref Span256<double> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.LoadVector(i);
                var y = rhs.LoadVector(i);
                store(Subtract(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }
        #endregion        
    }
}