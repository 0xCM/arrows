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
        public static sbyte set(sbyte src, int pos)
             => src.Or(LeftMask(src,pos));

        [MethodImpl(Inline)]
        public static byte set(byte src, int pos)
             => src.Or(LeftMask(src,pos));

        [MethodImpl(Inline)]
        public static short set(short src, int pos)
             => src.Or(LeftMask(src,pos));

        [MethodImpl(Inline)]
        public static ushort set(ushort src, int pos)
             => src.Or(LeftMask(src,pos));

        [MethodImpl(Inline)]
        public static int set(int src, int pos)
             => src | LeftMask(src,pos);

        [MethodImpl(Inline)]
        public static uint set(uint src, int pos)
             => src | LeftMask(src,pos);

        [MethodImpl(Inline)]
        public static long set(long src, int pos)
             => src | LeftMask(src,pos);

        [MethodImpl(Inline)]
        public static ulong set(ulong src, int pos)
             => src | LeftMask(src,pos);

        
        [MethodImpl(Inline)]
        public static double set(double src, int pos)
        {
            var srcBits = BitConverter.DoubleToInt64Bits(src);
            srcBits |= LeftMask(srcBits, pos);
            return BitConverter.Int64BitsToDouble(srcBits);            
        }

        [MethodImpl(Inline)]
        public static ref sbyte set(ref sbyte src, int pos)
        {
             src |= LeftMask(src,pos);
             return ref src;
        }

        [MethodImpl(Inline)]
        public static ref byte set(ref byte src, int pos)
        {
             src |= LeftMask(src,pos);
             return ref src;
        }

        [MethodImpl(Inline)]
        public static ref short set(ref short src, int pos)
        {
             src |= LeftMask(src,pos);
             return ref src;
        }

        [MethodImpl(Inline)]
        public static ref ushort set(ref ushort src, int pos)
        {
             src |= LeftMask(src,pos);
             return ref src;
        }

        [MethodImpl(Inline)]
        public static ref ulong set(ref ulong src, int pos)
        {
             src |= LeftMask(src,pos);
             return ref src;
        }

        [MethodImpl(Inline)]
        public static ref int set(ref int src, int pos)
        {
             src |= LeftMask(src,pos);
             return ref src;
        }

        [MethodImpl(Inline)]
        public static ref uint set(ref uint src, int pos)
        {
             src |= LeftMask(src,pos);
             return ref src;
        }

        [MethodImpl(Inline)]
        public static ref long set(ref long src, int pos)
        {
             src |= LeftMask(src,pos);
             return ref src;
        }

        [MethodImpl(Inline)]
        public static float set(float src, int pos)
        {
            var srcBits = BitConverter.SingleToInt32Bits(src);
            srcBits |= LeftMask(srcBits, pos);
            return BitConverter.Int32BitsToSingle(srcBits);            
        }             

        [MethodImpl(Inline)]
        public static ref float set(ref float src, int pos)
        {
             src = set(src,pos);
             return ref src;
        }

        [MethodImpl(Inline)]
        public static ref double set(ref double src, int pos)
        {
             src = set(src,pos);
             return ref src;
        }
    }
}