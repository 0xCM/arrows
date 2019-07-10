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

        public static ref sbyte pack(in ReadOnlySpan<Bit> src, out sbyte dst)
        {
            dst = 0;
            var last = math.min(Pow2.T03, src.Length) - 1;
            for(var i = 0; i <= last; i++)
                if(src[last - i])
                    dst |= (sbyte)(I32One << i);
            return ref dst;
        }

        public static ref byte pack(in ReadOnlySpan<Bit> src, out byte dst)
        {
            dst = 0;
            var last = math.min(Pow2.T03, src.Length) - 1;
            for(var i = 0; i <= last; i++)
                if(src[last - i])
                    dst |= (byte)(I32One << i);
            return ref dst;
        }

        public static ref ushort pack(in ReadOnlySpan<Bit> src, out ushort dst)
        {
            dst = 0;
            var last = math.min(Pow2.T04, src.Length) - 1;
            for(var i = 0; i <= last; i++)
                if(src[last - i])
                    dst |= (ushort)(I32One << i);
            return ref dst;
        }

        public static ref short pack(in ReadOnlySpan<Bit> src, out short dst)
        {
            dst = 0;
            var last = math.min(Pow2.T04, src.Length) - 1;
            for(var i = 0; i <= last; i++)
                if(src[last - i])
                    dst |= (short)(I32One << i);
            return ref dst;
        }

        public static ref int pack(in ReadOnlySpan<Bit> src, out int dst)
        {
            dst = 0;
            var last = math.min(Pow2.T05, src.Length) - 1;
            for(var i = 0; i <= last; i++)
                if(src[last - i])
                    dst |= (1 << i);
            return ref dst;
        }

        public static ref uint pack(in ReadOnlySpan<Bit> src, out uint dst)
        {
            dst = 0;
            var last = math.min(Pow2.T05, src.Length) - 1;
            for(var i = 0; i <= last; i++)
                if(src[last - i])
                    dst |= (1u << i);
            return ref dst;
        }
        
        public static ref long pack(in ReadOnlySpan<Bit> src, out long dst)
        {
            dst = 0;
            var last = math.min(Pow2.T06, src.Length) - 1;
            for(var i = 0; i <= last; i++)
                if(src[last - i])
                    dst |= (1L << i);
            return ref dst;
        }

        public static ref ulong pack(in ReadOnlySpan<Bit> src, out ulong dst)
        {
            dst = 0;
            var last = math.min(Pow2.T06, src.Length) - 1;
            for(var i = 0; i <= last; i++)
                if(src[last - i])
                    dst |= (1ul << i);
            return ref dst;
        } 
 

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
            dst = (src & (1 << pos)) != I32Zero;
            return ref dst;
        }

        [MethodImpl(Inline)]
        static ref Bit test(in uint src, in int pos, out Bit dst)
        {
            dst = (src & (1u << pos)) != U32Zero;
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

        public static Span<Bit> unpack(in int src, out Span<Bit> dst)
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
 

    }

}