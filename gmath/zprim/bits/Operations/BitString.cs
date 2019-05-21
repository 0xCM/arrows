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
    using static mfunc;
    
    partial class Bits
    {                
        [MethodImpl(Optimize)]
        public static string bitstring(in byte src, bool tlz = false, bool pfs = false)
        {
            Span<char> dst = stackalloc char[Pow2.T03];
            var last = Pow2.T03 - 1;

            for(var i=0; i <= last; i++)
                dst[last - i] = Bits.test(src,i) ? Bit.One : Bit.Zero;
            
            var bsRaw = new string(dst);
            if(!tlz && ! pfs)
                return bsRaw;
                
            bsRaw = tlz ? bsRaw.TrimStart(Bit.Zero) : bsRaw;
            bsRaw = pfs ? "0b" + bsRaw : bsRaw;
            return bsRaw;
        }

        [MethodImpl(Optimize)]
        public static string bitstring(in sbyte src, bool tlz = false, bool pfs = false)
        {
            Span<char> dst = stackalloc char[Pow2.T03];
            var last = Pow2.T03 - 1;

            for(var i=0; i <= last; i++)
                dst[last - i] = Bits.test(src,i) ? Bit.One : Bit.Zero;
            
            var bsRaw = new string(dst);
            if(!tlz && ! pfs)
                return bsRaw;
                
            bsRaw = tlz ? bsRaw.TrimStart(Bit.Zero) : bsRaw;
            bsRaw = pfs ? "0b" + bsRaw : bsRaw;
            return bsRaw;
        }

        [MethodImpl(Optimize)]
        public static string bitstring(in short src, bool tlz = false, bool pfs = false)
        {
            Span<char> dst = stackalloc char[Pow2.T04];
            var last = Pow2.T04 - 1;

            for(var i=0; i <= last; i++)
                dst[last - i] = Bits.test(src,i) ? Bit.One : Bit.Zero;
            
            var bsRaw = new string(dst);
            if(!tlz && ! pfs)
                return bsRaw;
                
            bsRaw = tlz ? bsRaw.TrimStart(Bit.Zero) : bsRaw;
            bsRaw = pfs ? "0b" + bsRaw : bsRaw;
            return bsRaw;
        }

        [MethodImpl(Optimize)]
        public static string bitstring(in ushort src, bool tlz = false, bool pfs = false)
        {
            Span<char> dst = stackalloc char[Pow2.T04];
            var last = Pow2.T04 - 1;

            for(var i=0; i <= last; i++)
                dst[last - i] = Bits.test(src,i) ? Bit.One : Bit.Zero;
            
            var bsRaw = new string(dst);
            if(!tlz && ! pfs)
                return bsRaw;
                
            bsRaw = tlz ? bsRaw.TrimStart(Bit.Zero) : bsRaw;
            bsRaw = pfs ? "0b" + bsRaw : bsRaw;
            return bsRaw;
        }

        [MethodImpl(Optimize)]
        public static string bitstring(in int src, bool tlz = false, bool pfs = false)
        {
            Span<char> dst = stackalloc char[Pow2.T05];
            var last = Pow2.T05 - 1;

            for(var i=0; i <= last; i++)
                dst[last - i] = Bits.test(src,i) ? Bit.One : Bit.Zero;
            
            var bsRaw = new string(dst);
            if(!tlz && ! pfs)
                return bsRaw;
                
            bsRaw = tlz ? bsRaw.TrimStart(Bit.Zero) : bsRaw;
            bsRaw = pfs ? "0b" + bsRaw : bsRaw;
            return bsRaw;
        }

        [MethodImpl(Optimize)]
        public static string bitstring(in uint src, bool tlz = false, bool pfs = false)
        {
            Span<char> dst = stackalloc char[Pow2.T05];
            var last = Pow2.T05 - 1;

            for(var i=0; i <= last; i++)
                dst[last - i] = Bits.test(src,i) ? Bit.One : Bit.Zero;
            
            var bsRaw = new string(dst);
            if(!tlz && ! pfs)
                return bsRaw;
                
            bsRaw = tlz ? bsRaw.TrimStart(Bit.Zero) : bsRaw;
            bsRaw = pfs ? "0b" + bsRaw : bsRaw;
            return bsRaw;
        }

        [MethodImpl(Optimize)]
        public static string bitstring(in long src, bool tlz = false, bool pfs = false)
        {
            Span<char> dst = stackalloc char[Pow2.T06];
            var last = Pow2.T06 - 1;
            for(var i=0; i <= last; i++)
                dst[last - i] = Bits.test(src,i) ? Bit.One : Bit.Zero;
            
            var bsRaw = new string(dst);
            if(!tlz && ! pfs)
                return bsRaw;
                
            bsRaw = tlz ? bsRaw.TrimStart(Bit.Zero) : bsRaw;
            bsRaw = pfs ? "0b" + bsRaw : bsRaw;
            return bsRaw;
        }

        [MethodImpl(Optimize)]
        public static string bitstring(in ulong src, bool tlz = false, bool pfs = false)
        {
            Span<char> dst = stackalloc char[Pow2.T06];
            var last = Pow2.T06 - 1;

            for(var i=0; i <= last; i++)
                dst[last - i] = Bits.test(src,i) ? Bit.One : Bit.Zero;
            
            var bsRaw = new string(dst);
            if(!tlz && ! pfs)
                return bsRaw;
                
            bsRaw = tlz ? bsRaw.TrimStart(Bit.Zero) : bsRaw;
            bsRaw = pfs ? "0b" + bsRaw : bsRaw;
            return bsRaw;
        }

        [MethodImpl(Optimize)]
        public static string bitstring(Span<Bit> src)
        {
            var len = src.Length;
            var dst = span<char>(len);
            var last = len - 1;
            for(var i=0; i <= last; i++)
                dst[last -i] = src[i];
            return new string(dst);
        }
    }
}