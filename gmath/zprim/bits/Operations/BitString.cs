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
        const char Digit0 = '0';
        const char Digit1 = '1';

        public static string bitstring(in byte src, bool tlz = false, bool pfs = false)
        {
            var dst = new char[Pow2.T03];
            var last = Pow2.T03 - 1;

            for(var i=0; i <= last; i++)
                dst[last - i] = Bits.test(src,i) ? Digit1 : Digit0;
            
            var bsRaw = new string(dst);
            if(!tlz && ! pfs)
                return bsRaw;
                
            bsRaw = tlz ? bsRaw.TrimStart(Digit0) : bsRaw;
            bsRaw = pfs ? "0b" + bsRaw : bsRaw;
            return bsRaw;
        }


        static string Refine(string src, bool tlz = false, bool pfs = false)
        {
            if(!tlz)
                src = src.PadLeft(8, Digit0);
            if(pfs)
                src = "0b" + src;
            return src;

        }
        public static string bitstring(in sbyte src, bool tlz = false, bool pfs = false)
        {
            //return Refine(Convert.ToString(src, 2));

            var dst = new char[Pow2.T03];
            var last = Pow2.T03 - 1;

            for(var i=0; i <= last; i++)
                dst[last - i] = Bits.test(src,i) ? Digit1 : Digit0;
            
            var bsRaw = new string(dst);
            if(!tlz && ! pfs)
                return bsRaw;
                
            bsRaw = tlz ? bsRaw.TrimStart(Digit0) : bsRaw;
            bsRaw = pfs ? "0b" + bsRaw : bsRaw;
            return bsRaw;
        }

        public static string bitstring(in short src, bool tlz = false, bool pfs = false)
        {
            var dst = new char[Pow2.T04];
            var last = Pow2.T04 - 1;

            for(var i=0; i <= last; i++)
                dst[last - i] = Bits.test(src,i) ? Digit1 : Digit0;
            
            var bsRaw = new string(dst);
            if(!tlz && ! pfs)
                return bsRaw;
                
            bsRaw = tlz ? bsRaw.TrimStart(Digit0) : bsRaw;
            bsRaw = pfs ? "0b" + bsRaw : bsRaw;
            return bsRaw;
        }

        public static string bitstring(in ushort src, bool tlz = false, bool pfs = false)
        {
            var dst = new char[Pow2.T04];
            var last = Pow2.T04 - 1;

            for(var i=0; i <= last; i++)
                dst[last - i] = Bits.test(src,i) ? Digit1 : Digit0;
            
            var bsRaw = new string(dst);
            if(!tlz && ! pfs)
                return bsRaw;
                
            bsRaw = tlz ? bsRaw.TrimStart(Digit0) : bsRaw;
            bsRaw = pfs ? "0b" + bsRaw : bsRaw;
            return bsRaw;
        }

        public static string bitstring(in int src, bool tlz = false, bool pfs = false)
        {
            //return(Refine(Convert.ToString(src, 2)));
            var dst = new char[Pow2.T05];
            var last = Pow2.T05 - 1;

            for(var i=0; i <= last; i++)
                dst[last - i] = Bits.test(src,i) ? Digit1 : Digit0;
            
            var bsRaw = new string(dst);
            if(!tlz && ! pfs)
                return bsRaw;
                
            bsRaw = tlz ? bsRaw.TrimStart(Digit0) : bsRaw;
            bsRaw = pfs ? "0b" + bsRaw : bsRaw;
            return bsRaw;
        }

        public static string bitstring(in uint src, bool tlz = false, bool pfs = false)
        {
            //return Refine(Convert.ToString(src,2));
            var dst = new char[Pow2.T05];
            var last = Pow2.T05 - 1;

            for(var i=0; i <= last; i++)
                dst[last - i] = Bits.test(src,i) ? Digit1 : Digit0;
            
            var bsRaw = new string(dst);
            if(!tlz && ! pfs)
                return bsRaw;
                
            bsRaw = tlz ? bsRaw.TrimStart(Digit0) : bsRaw;
            bsRaw = pfs ? "0b" + bsRaw : bsRaw;
            return bsRaw;
        }

        public static string bitstring(in long src, bool tlz = false, bool pfs = false)
        {
            var dst = new char[Pow2.T06];
            var last = Pow2.T06 - 1;
            for(var i=0; i <= last; i++)
                dst[last - i] = Bits.test(src,i) ? Digit1 : Digit0;
            
            var bsRaw = new string(dst);
            if(!tlz && ! pfs)
                return bsRaw;
                
            bsRaw = tlz ? bsRaw.TrimStart(Digit0) : bsRaw;
            bsRaw = pfs ? "0b" + bsRaw : bsRaw;
            return bsRaw;
        }

        public static string bitstring(in ulong src, bool tlz = false, bool pfs = false)
        {
            //return Refine(Convert.ToString((long)src, 2));

            var dst = new char[Pow2.T06];
            var last = Pow2.T06 - 1;

            for(var i=0; i <= last; i++)
                dst[last - i] = Bits.test(src,i) ? Digit1 : Digit0;
            
            var bsRaw = new string(dst);
            if(!tlz && ! pfs)
                return bsRaw;
                
            bsRaw = tlz ? bsRaw.TrimStart(Digit0) : bsRaw;
            bsRaw = pfs ? "0b" + bsRaw : bsRaw;
            return bsRaw;
        }

        public static string bitstring(Span<Bit> src, bool tlz = false, bool pfs = false)
        {
            var len = src.Length;
            var dst = span<char>(len);
            var last = len - 1;
            for(var i=0; i <= last; i++)
                dst[last -i] = src[i];

            var bs = new string(dst);
            if(tlz) bs = bs.TrimStart(Digit0);
            if(pfs) bs = "0b" + bs;
            
            return bs;
        }
    }
}