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
        [MethodImpl(Optimize)]
        public static Span<Bit> bitspan(in sbyte src)
        {
            var dst = new Bit[Pow2.T03];
            var last = Pow2.T03 - 1;
            for(var i = 0; i <= last; i++)
                test(in src, in i, out dst[last - i]);            
            return dst; 
        }

        [MethodImpl(Optimize)]
        public static Span<Bit> bitspan(in byte src)
        {
            var dst = new Bit[Pow2.T03];
            var last = Pow2.T03 - 1;
            for(var i=0; i <= last; i++)
                test(in src, in i, out dst[last - i]);
            return dst; 
        }

        [MethodImpl(Optimize)]
        public static Span<Bit> bitspan(in ushort src)
        {
            var dst = new Bit[Pow2.T04];
            var last = Pow2.T04 - 1;
            for(var i=0; i <= last; i++)
                test(in src, in i, out dst[last - i]);
            return dst; 
        }

        [MethodImpl(Optimize)]
        public static Span<Bit> bitspan(in short src)
        {
            var dst = new Bit[Pow2.T04];
            var last = Pow2.T04 - 1;
            for(var i=0; i <= last; i++)
                test(in src, in i, out dst[last - i]);
            return dst; 
        }

        [MethodImpl(Optimize)]
        public static Span<Bit> bitspan(in int src)
        {
            var dst = new Bit[Pow2.T05];
            var last = Pow2.T05 - 1;
            for(var i=0; i <= last; i++)
                test(in src, in i, out dst[last - i]);
            return dst; 
        }

        [MethodImpl(NotInline)]
        public static Span<Bit> bitspan(in uint src)
        {
            var dst = new Bit[Pow2.T05];
            var last = Pow2.T05 - 1;
            for(var i=0; i <= last; i++)
                test(in src, in i, out dst[last - i]);
            return dst; 
        }

        [MethodImpl(Optimize)]
        public static Span<Bit> bitspan(in long src)
        {
            var dst = new Bit[Pow2.T06];
            var last = Pow2.T06 - 1;
            for(var i=0; i <= last; i++)
                test(in src, in i, out dst[last - i]);
            return dst; 
        }        

        [MethodImpl(Optimize)]
        public static Span<Bit> bitspan(in ulong src)
        {
            var dst = new Bit[Pow2.T06];
            var last = Pow2.T06 - 1;
            for(var i=0; i <= last; i++)
                test(src, in i, out dst[last - i]);
            return dst; 
        }
 
        [MethodImpl(Inline)]
        public static Span<Bit> bitspan(in float src)
            => bitspan(BitConverter.SingleToInt32Bits(src));
        
        [MethodImpl(Inline)]
        public static Span<Bit> bitspan(in double src)
            => bitspan(Bits.bitsI64(src));
    }
}