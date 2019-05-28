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
        public static ref sbyte bitpack(in ReadOnlySpan<Bit> src, out sbyte dst)
        {
            dst = 0;
            var last = math.min(Pow2.T03, src.Length) - 1;
            for(var i = 0; i <= last; i++)
                if(src[last - i])
                    dst |= (sbyte)(I32One << i);
            return ref dst;
        }

        [MethodImpl(Optimize)]
        public static ref byte bitpack(in ReadOnlySpan<Bit> src, out byte dst)
        {
            dst = 0;
            var last = math.min(Pow2.T03, src.Length) - 1;
            for(var i = 0; i <= last; i++)
                if(src[last - i])
                    dst |= (byte)(I32One << i);
            return ref dst;
        }

        [MethodImpl(Optimize)]
        public static ref ushort bitpack(in ReadOnlySpan<Bit> src, out ushort dst)
        {
            dst = 0;
            var last = math.min(Pow2.T04, src.Length) - 1;
            for(var i = 0; i <= last; i++)
                if(src[last - i])
                    dst |= (ushort)(I32One << i);
            return ref dst;
        }

        [MethodImpl(Optimize)]
        public static ref short bitpack(in ReadOnlySpan<Bit> src, out short dst)
        {
            dst = 0;
            var last = math.min(Pow2.T04, src.Length) - 1;
            for(var i = 0; i <= last; i++)
                if(src[last - i])
                    dst |= (short)(I32One << i);
            return ref dst;
        }

        [MethodImpl(Optimize)]
        public static ref int bitpack(in ReadOnlySpan<Bit> src, out int dst)
        {
            dst = 0;
            var last = math.min(Pow2.T05, src.Length) - 1;
            for(var i = 0; i <= last; i++)
                if(src[last - i])
                    dst |= (1 << i);
            return ref dst;
        }

        [MethodImpl(Optimize)]
        public static ref uint bitpack(in ReadOnlySpan<Bit> src, out uint dst)
        {
            dst = 0;
            var last = math.min(Pow2.T05, src.Length) - 1;
            for(var i = 0; i <= last; i++)
                if(src[last - i])
                    dst |= (1u << i);
            return ref dst;
        }
        
        [MethodImpl(Optimize)]        
        public static ref long bitpack(in ReadOnlySpan<Bit> src, out long dst)
        {
            dst = 0;
            var last = math.min(Pow2.T06, src.Length) - 1;
            for(var i = 0; i <= last; i++)
                if(src[last - i])
                    dst |= (1L << i);
            return ref dst;
        }

        [MethodImpl(Optimize)]
        public static ref ulong bitpack(in ReadOnlySpan<Bit> src, out ulong dst)
        {
            dst = 0;
            var last = math.min(Pow2.T06, src.Length) - 1;
            for(var i = 0; i <= last; i++)
                if(src[last - i])
                    dst |= (1ul << i);
            return ref dst;
        }
    }
}