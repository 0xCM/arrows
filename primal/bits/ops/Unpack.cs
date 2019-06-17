//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Numerics;
    using Z0;
 
    using static zfunc;
    
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
            => dst = unpack(Bits.bitsI64(src), out dst);
    }
}