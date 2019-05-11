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

        [MethodImpl(Inline)]
        public static string bitstring(sbyte src)
            => zpad(Convert.ToString(src,2), 8);

        [MethodImpl(Inline)]
        public static string bitstring(byte src)
            => zpad(Convert.ToString(src,2), 8);

        [MethodImpl(Inline)]
        public static string bitstring(short src)
            => zpad(Convert.ToString(src,2), 16);

        [MethodImpl(Inline)]
        public static string bitstring(ushort src)
            => zpad(Convert.ToString(src,2), 16);

        [MethodImpl(Inline)]
        public static string bitstring(int src)
            => zpad(Convert.ToString(src,2), 32);

        [MethodImpl(Inline)]
        public static string bitstring(uint src)
            => zpad(Convert.ToString(src,2), 32);

        [MethodImpl(Inline)]
        public static string bitstring(long src)
            => zpad(Convert.ToString(src,2), 64);

        [MethodImpl(Inline)]
        public static string bitstring(ulong src)
        {
             (var x0, var x1) = split(src);
             return bitstring(x1) + bitstring(x0);
        }
            
        [MethodImpl(Inline)]
        public static string bitstring(float src)
            => bitstring(BitConverter.SingleToInt32Bits(src));

        [MethodImpl(Inline)]
        public static string bitstring(double src)
            => bitstring(bitsf(src));


        [MethodImpl(Inline)]
        public static byte[] bytes(short src)
            => BitConverter.GetBytes(src);

        [MethodImpl(Inline)]
        public static byte[] bytes(ushort src)
            => BitConverter.GetBytes(src);

        [MethodImpl(Inline)]
        public static byte[] bytes(int src)
            => BitConverter.GetBytes(src); 

        [MethodImpl(Inline)]
        public static byte[] bytes(uint src)
            => BitConverter.GetBytes(src);

        [MethodImpl(Inline)]
        public static byte[] bytes(long src)
            => BitConverter.GetBytes(src);

        [MethodImpl(Inline)]
        public static byte[] bytes(ulong src)
            => BitConverter.GetBytes(src);

        [MethodImpl(Inline)]
        public static byte[] bytes(float src)
            => BitConverter.GetBytes(src);

        [MethodImpl(Inline)]
        public static byte[] bytes(double src)
            => BitConverter.GetBytes(src);

        [MethodImpl(NotInline)]
        public static Bit[] bits(sbyte src)
        {
            var bitsize = SizeOf<sbyte>.BitSize;
            var dst = array<Bit>(bitsize);
            for(var i = 0; i < bitsize; i++)
                dst[i] = test(src,i);
            return dst; 
        }

        [MethodImpl(NotInline)]
        public static Bit[] bits(int src)
        {
            var dst = array<Bit>(SizeOf<int>.BitSize);
            for(var i = 0; i < SizeOf<int>.BitSize; i++)
                dst[i] = test(src,i);
            return dst; 
        }

        [MethodImpl(Inline)]
        public static Bit[] bits(float src)
            => bits(BitConverter.SingleToInt32Bits(src));

        [MethodImpl(Inline)]
        public static Bit[] bits(double src)
            => bits(bitsf(src));
 
        [MethodImpl(NotInline)]
        public static Bit[] bits(long src)
        {
            var dst = array<Bit>(SizeOf<long>.BitSize);
            for(var i = 0; i < SizeOf<long>.BitSize; i++)
                dst[i] = test(src,i);
            return dst; 
        }        
   
        [MethodImpl(NotInline)]
        public static Bit[] bits(byte src)
        {
            var dst = array<Bit>(SizeOf<byte>.BitSize);
            for(var i = 0; i < SizeOf<byte>.BitSize; i++)
                dst[i] = test(src,i);
            return dst; 
        }

        [MethodImpl(NotInline)]
        public static Bit[] bits(ushort src)
        {
            var dst = array<Bit>(SizeOf<ushort>.BitSize);
            for(var i = 0; i < SizeOf<ushort>.BitSize; i++)
                dst[i] = test(src,i);
            return dst; 
        }
    
        [MethodImpl(NotInline)]
        public static Bit[] bits(uint src)
        {
            var dst = array<Bit>(SizeOf<uint>.BitSize);
            for(var i = 0; i < SizeOf<uint>.BitSize; i++)
                dst[i] = test(src,i);
            return dst; 
        }
    }

}