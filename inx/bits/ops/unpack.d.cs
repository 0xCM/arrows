//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using Z0;
 
    using static zfunc;
    using static Constants;
    
    partial class Bits
    {         

        public static Span<Bit> unpack(in sbyte src, out Span<Bit> dst)
        {
            dst = new Bit[Pow2.T03];
            var last = Pow2.T03 - 1;
            for(var i = 0; i <= last; i++)
                test(in src, in i, out dst[last - i]);            
            return dst; 
        }

        public static Span<Bit> unpack(in byte src, out Span<Bit> dst)
        {
            dst = new Bit[Pow2.T03];
            var last = Pow2.T03 - 1;
            for(var i=0; i <= last; i++)
                test(in src, in i, out dst[last - i]);
            return dst; 
        }

        public static Span<Bit> unpack(in ushort src, out Span<Bit> dst)
        {
            dst = new Bit[Pow2.T04];
            var last = Pow2.T04 - 1;
            for(var i=0; i <= last; i++)
                test(in src, in i, out dst[last - i]);
            return dst; 
        }

        public static Span<Bit> unpack(in short src, out Span<Bit> dst)
        {
            dst = new Bit[Pow2.T04];
            var last = Pow2.T04 - 1;
            for(var i=0; i <= last; i++)
                test(in src, in i, out dst[last - i]);
            return dst; 
        }


        public static Span<Bit> unpack(in int src, out Span<Bit> dst)
        {
            dst = new Bit[Pow2.T05];
            var last = Pow2.T05 - 1;
            for(var i=0; i <= last; i++)
                test(in src, in i, out dst[last - i]);
            return dst; 
        }

        public static Span<Bit> unpack(in uint src, out Span<Bit> dst)
        {
            dst = new Bit[Pow2.T05];
            var last = Pow2.T05 - 1;
            for(var i=0; i <= last; i++)
                test(in src, in i, out dst[last - i]);
            return dst; 
        }

        public static Span<Bit> unpack(in long src, out Span<Bit> dst)
        {
            dst = new Bit[Pow2.T06];
            var last = Pow2.T06 - 1;
            for(var i=0; i <= last; i++)
                test(in src, in i, out dst[last - i]);
            return dst; 
        }        

        public static Span<Bit> unpack(in ulong src, out  Span<Bit> dst)
        {
            dst = new Bit[Pow2.T06];
            var last = Pow2.T06 - 1;
            for(var i=0; i <= last; i++)
                test(src, in i, out dst[last - i]);
            return dst; 
        }
 
        [MethodImpl(Inline)]
        public static Span<Bit> unpack(in float src, out Span<Bit> dst)
            => dst = unpack(BitConverter.SingleToInt32Bits(src), out dst);
        
        [MethodImpl(Inline)]
        public static Span<Bit> unpack(in double src, out Span<Bit> dst)
            => dst = unpack(BitConverter.DoubleToInt64Bits(src), out dst);
 
        [MethodImpl(Inline)]
        static ref Bit test(in sbyte src, in int pos, out Bit dst)
        {
            dst = (src & (1 << pos)) != 0;
            return ref dst;
        }

        [MethodImpl(Inline)]
        static ref Bit test(in byte src, in int pos, out Bit dst)
        {
            dst = (src & (1 << pos)) != 0;
            return ref dst;
        }

        [MethodImpl(Inline)]
        static ref Bit test(in short src, in int pos, out Bit dst)
        {
            dst = (src & (1 << pos)) != 0;
            return ref dst;
        }

        [MethodImpl(Inline)]
        static ref Bit test(in ushort src, in int pos, out Bit dst)
        {
            dst = (src & (1 << pos)) != 0;
            return ref dst;
        }

        [MethodImpl(Inline)]
        static ref Bit test(in int src, in int pos, out Bit dst)
        {
            dst = (src & (1 << pos)) != 0;
            return ref dst;
        }

        [MethodImpl(Inline)]
        static ref Bit test(in uint src, in int pos, out Bit dst)
        {
            dst = (src & (1u << pos)) != 0;
            return ref dst;
        }

        [MethodImpl(Inline)]
        static ref Bit test(in long src, in int pos, out Bit dst)
        {
            dst = (src & (1L << pos)) != I64Zero;
            return ref dst;
        }

        [MethodImpl(Inline)]
        static ref Bit test(in ulong src, in int pos, out Bit dst)
        {
            dst = (src & (1ul << pos)) != U64Zero;
            return ref dst;
        }

    }
}