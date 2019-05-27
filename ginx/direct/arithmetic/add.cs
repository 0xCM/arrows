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

    public static partial class dinx
    {
        [MethodImpl(Inline)]
        public static Vec128<byte> add(in Vec128<byte> lhs, in Vec128<byte> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<sbyte> add(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<short> add(in Vec128<short> lhs, in Vec128<short> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ushort> add(in Vec128<ushort> lhs, in Vec128<ushort> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<int> add(in Vec128<int> lhs, in Vec128<int> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<uint> add(in Vec128<uint> lhs, in Vec128<uint> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<long> add(in Vec128<long> lhs, in Vec128<long> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<ulong> add(in Vec128<ulong> lhs, in Vec128<ulong> rhs)
            => Sse42.Add(lhs,rhs);

        [MethodImpl(Inline)]
        public static Vec128<float> add(in Vec128<float> lhs, in Vec128<float> rhs)
            => Avx2.Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec128<double> add(in Vec128<double> lhs, in Vec128<double> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<byte> add(in Vec256<byte> lhs, in Vec256<byte> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<sbyte> add(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<short> add(in Vec256<short> lhs, in Vec256<short> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ushort> add(in Vec256<ushort> lhs, in Vec256<ushort> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<int> add(in Vec256<int> lhs, in Vec256<int> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<uint> add(in Vec256<uint> lhs, in Vec256<uint> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<long> add(in Vec256<long> lhs, in Vec256<long> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<ulong> add(in Vec256<ulong> lhs, in Vec256<ulong> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<float> add(in Vec256<float> lhs, in Vec256<float> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static Vec256<double> add(in Vec256<double> lhs, in Vec256<double> rhs)
            => Add(lhs, rhs);

        [MethodImpl(Inline)]
        public static void add(in Vec128<sbyte> lhs, in Vec128<sbyte> rhs, ref sbyte dst)
            => store(Add(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void add(in Vec128<byte> lhs, in Vec128<byte> rhs, ref byte dst)
            => store(Add(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void add(in Vec128<short> lhs, in Vec128<short> rhs, ref short dst)
            => store(Add(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void add(in Vec128<ushort> lhs, in Vec128<ushort> rhs, ref ushort dst)
            => store(Add(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void add(in Vec128<int> lhs, in Vec128<int> rhs, ref int dst)
            => store(Add(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void add(in Vec128<uint> lhs, in Vec128<uint> rhs, ref uint dst)
            => store(Add(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void add(in Vec128<long> lhs, in Vec128<long> rhs, ref long dst)
            => store(Add(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void add(in Vec128<ulong> lhs, in Vec128<ulong> rhs, ref ulong dst)
            => store(Add(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void add(in Vec128<float> lhs, in Vec128<float> rhs, ref float dst)
            => store(Add(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void add(in Vec128<double> lhs, in Vec128<double> rhs, ref double dst)
            => store(Add(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void add(in Vec256<sbyte> lhs, in Vec256<sbyte> rhs, ref sbyte dst)
            => store(Add(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void add(in Vec256<byte> lhs, in Vec256<byte> rhs, ref byte dst)
            => store(Add(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void add(in Vec256<short> lhs, in Vec256<short> rhs, ref short dst)
            => store(Add(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void add(in Vec256<ushort> lhs, in Vec256<ushort> rhs, ref ushort dst)
            => store(Add(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void add(in Vec256<int> lhs, in Vec256<int> rhs, ref int dst)
            => store(Add(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void add(in Vec256<uint> lhs, in Vec256<uint> rhs, ref uint dst)
            => store(Add(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void add(in Vec256<long> lhs, in Vec256<long> rhs, ref long dst)
            => store(Add(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void add(in Vec256<ulong> lhs, in Vec256<ulong> rhs, ref ulong dst)
            => store(Add(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void add(in Vec256<float> lhs, in Vec256<float> rhs, ref float dst)
            => store(Add(lhs, rhs), ref dst);

        [MethodImpl(Inline)]
        public static void add(in Vec256<double> lhs, in Vec256<double> rhs, ref double dst)
            => store(Add(lhs, rhs), ref dst);

        public static ref Span128<sbyte> add(ReadOnlySpan128<sbyte> lhs, ReadOnlySpan128<sbyte> rhs, ref Span128<sbyte> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x =  lhs.VLoad(i);
                var y = rhs.VLoad(i);
                store(Add(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static ref Span128<byte> add(ReadOnlySpan128<byte> lhs, ReadOnlySpan128<byte> rhs, ref Span128<byte> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.VLoad(i);
                var y = rhs.VLoad(i);
                store(Add(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static ref Span128<short> add(ReadOnlySpan128<short> lhs, ReadOnlySpan128<short> rhs, ref Span128<short> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.VLoad(i);
                var y = rhs.VLoad(i);
                store(Add(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static ref Span128<ushort> add(ReadOnlySpan128<ushort> lhs, ReadOnlySpan128<ushort> rhs, ref Span128<ushort> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.VLoad(i);
                var y = rhs.VLoad(i);
                store(Add(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static ref Span128<int> add(ReadOnlySpan128<int> lhs, ReadOnlySpan128<int> rhs, ref Span128<int> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.VLoad(i);
                var y = rhs.VLoad(i);
                store(Add(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static ref Span128<uint> add(ReadOnlySpan128<uint> lhs, ReadOnlySpan128<uint> rhs, ref Span128<uint> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.VLoad(i);
                var y = rhs.VLoad(i);
                store(Add(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static ref Span128<long> add(ReadOnlySpan128<long> lhs, ReadOnlySpan128<long> rhs, ref Span128<long> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x =  lhs.VLoad(i);
                var y = rhs.VLoad(i);
                store(Add(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static ref Span128<ulong> add(ReadOnlySpan128<ulong> lhs, ReadOnlySpan128<ulong> rhs, ref Span128<ulong> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.VLoad(i);
                var y = rhs.VLoad(i);
                store(Add(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static ref Span128<float> add(ReadOnlySpan128<float> lhs, ReadOnlySpan128<float> rhs, ref Span128<float> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.VLoad(i);
                var y = rhs.VLoad(i);
                store(Add(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static ref Span128<double> add(ReadOnlySpan128<double> lhs, ReadOnlySpan128<double> rhs, ref Span128<double> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.VLoad(i);
                var y = rhs.VLoad(i);
                store(Add(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static ref Span256<sbyte> add(ReadOnlySpan256<sbyte> lhs, ReadOnlySpan256<sbyte> rhs, ref Span256<sbyte> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.VLoad(i);
                var y = rhs.VLoad(i);
                store(Add(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static ref Span256<byte> add(ReadOnlySpan256<byte> lhs, ReadOnlySpan256<byte> rhs, ref Span256<byte> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.VLoad(i);
                var y = rhs.VLoad(i);
                store(Add(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static ref Span256<short> add(ReadOnlySpan256<short> lhs, ReadOnlySpan256<short> rhs, ref Span256<short> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.VLoad(i);
                var y = rhs.VLoad(i);
                store(Add(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static ref Span256<ushort> add(ReadOnlySpan256<ushort> lhs, ReadOnlySpan256<ushort> rhs, ref Span256<ushort> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.VLoad(i);
                var y = rhs.VLoad(i);
                store(Add(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static ref Span256<int> add(ReadOnlySpan256<int> lhs, ReadOnlySpan256<int> rhs, ref Span256<int> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.VLoad(i);
                var y = rhs.VLoad(i);
                store(Add(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static ref Span256<uint> add(ReadOnlySpan256<uint> lhs, ReadOnlySpan256<uint> rhs, ref Span256<uint> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.VLoad(i);
                var y = rhs.VLoad(i);
                store(Add(x,y), ref dst[i]);
            }
            
            return ref dst;
        }

        public static ref Span256<long> add(ReadOnlySpan256<long> lhs, ReadOnlySpan256<long> rhs, ref Span256<long> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.VLoad(i);
                var y = rhs.VLoad(i);
                store(Add(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static ref Span256<ulong> add(ReadOnlySpan256<ulong> lhs, ReadOnlySpan256<ulong> rhs, ref Span256<ulong> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.VLoad(i);
                var y = rhs.VLoad(i);
                store(Add(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static ref Span256<float> add(ReadOnlySpan256<float> lhs, ReadOnlySpan256<float> rhs, ref Span256<float> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.VLoad(i);
                var y = rhs.VLoad(i);
                store(Add(x,y), ref dst[i]);
            }
            
            return ref dst;            
        }

        public static ref Span256<double> add(ReadOnlySpan256<double> lhs, ReadOnlySpan256<double> rhs, ref Span256<double> dst)
        {
            var width = dst.BlockWidth;
            var cells = length(lhs,rhs);
            for(var i =0; i < cells; i += width)
            {
                var x = lhs.VLoad(i);
                var y = rhs.VLoad(i);
                store(Add(x,y), ref dst[i]);
            }
            
            return ref dst;
        }        
    }
}