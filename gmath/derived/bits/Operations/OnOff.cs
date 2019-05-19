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
          public static sbyte enable(sbyte src, int pos)
               => src.Or(LeftMask(src,pos));

          [MethodImpl(Inline)]
          public static byte enable(byte src, int pos)
               => src.Or(LeftMask(src,pos));

          [MethodImpl(Inline)]
          public static short enable(short src, int pos)
               => src.Or(LeftMask(src,pos));

          [MethodImpl(Inline)]
          public static ushort enable(ushort src, int pos)
               => src.Or(LeftMask(src,pos));

          [MethodImpl(Inline)]
          public static int enable(int src, int pos)
               => src | LeftMask(src,pos);

          [MethodImpl(Inline)]
          public static uint enable(uint src, int pos)
               => src | LeftMask(src,pos);

          [MethodImpl(Inline)]
          public static long enable(long src, int pos)
               => src | LeftMask(src,pos);

          [MethodImpl(Inline)]
          public static ulong enable(ulong src, int pos)
               => src | LeftMask(src,pos);


          [MethodImpl(Inline)]
          public static double enable(double src, int pos)
          {
               var srcBits = BitConverter.DoubleToInt64Bits(src);
               srcBits |= LeftMask(srcBits, pos);
               return BitConverter.Int64BitsToDouble(srcBits);            
          }

          [MethodImpl(Inline)]
          public static ref sbyte enable(ref sbyte src, int pos)
          {
               src |= LeftMask(src,pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref byte enable(ref byte src, int pos)
          {
               src |= LeftMask(src,pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref short enable(ref short src, int pos)
          {
               src |= LeftMask(src,pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref ushort enable(ref ushort src, int pos)
          {
               src |= LeftMask(src,pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref ulong enable(ref ulong src, int pos)
          {
               src |= LeftMask(src,pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref int enable(ref int src, int pos)
          {
               src |= LeftMask(src,pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref uint enable(ref uint src, int pos)
          {
               src |= LeftMask(src,pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref long enable(ref long src, int pos)
          {
               src |= LeftMask(src,pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static float enable(float src, int pos)
          {
               var srcBits = BitConverter.SingleToInt32Bits(src);
               srcBits |= LeftMask(srcBits, pos);
               return BitConverter.Int32BitsToSingle(srcBits);            
          }             

          [MethodImpl(Inline)]
          public static ref float enable(ref float src, int pos)
          {
               src = enable(src,pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref double enable(ref double src, int pos)
          {
               src = enable(src,pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref U128 enable(ref U128 src, int pos)
          {
               if(pos < 64)
                    Bits.enable(ref src.x0, pos);
               else
                    Bits.enable(ref src.x1, pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref I128 enable(ref I128 src, int pos)
          {
               if(pos < 64)
                    Bits.enable(ref src.x0, pos);
               else
                    Bits.enable(ref src.x1, pos);
               return ref src;
          }

        [MethodImpl(Inline)]
        public static ref byte disable(ref byte src, int pos)
        {
            var m = LeftMask(src,pos);
            src &= m.Flip();
            return ref src;
        }

        [MethodImpl(Inline)]
        public static byte disable(byte src, int pos)
            => disable(ref src, pos);

        [MethodImpl(Inline)]
        public static ref sbyte disable(ref sbyte src, int pos)
        {
            var m = LeftMask(src,pos);
            src &= m.Flip();
            return ref src;
        }

        [MethodImpl(Inline)]
        public static sbyte disable(sbyte src, int pos)
            => disable(ref src, pos);

        [MethodImpl(Inline)]
        public static ref short disable(ref short src, int pos)
        {
            var m = LeftMask(src,pos);
            src &= m.Flip();
            return ref src;
        }

        [MethodImpl(Inline)]
        public static short disable(short src, int pos)
             => disable(ref src, pos);


        [MethodImpl(Inline)]
        public static ushort disable(ushort src, int pos)
             => disable(ref src, pos);

        [MethodImpl(Inline)]
        public static ref ushort disable(ref ushort src, int pos)
        {
            var m = LeftMask(src,pos);
            src &= m.Flip();
            return ref src;
        }

        [MethodImpl(Inline)]
        public static int disable(int src, int pos)
             => src &= ~ LeftMask(src,pos);

        [MethodImpl(Inline)]
        public static ref int disable(ref int src, int pos)
        {
            var m = LeftMask(src,pos);
            src &= m.Flip();
            return ref src;
        }

        [MethodImpl(Inline)]
        public static uint disable(uint src, int pos)
             => src &= ~ LeftMask(src,pos);

        [MethodImpl(Inline)]
        public static ref uint disable(ref uint src, int pos)
        {
            var m = LeftMask(src,pos);
            src &= m.Flip();
            return ref src;
        }

        [MethodImpl(Inline)]
        public static long disable(long src, int pos)
             => src &= ~ LeftMask(src,pos);

        [MethodImpl(Inline)]
        public static ref long disable(ref long src, int pos)
        {
            var m = LeftMask(src,pos);
            src &= m.Flip();
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ulong disable(ulong src, int pos)
             => src &= ~ LeftMask(src,pos);

        [MethodImpl(Inline)]
        public static ref ulong disable(ref ulong src, int pos)
        {
            var m = LeftMask(src,pos);
            src &= m.Flip();
            return ref src;
        }

        [MethodImpl(Inline)]
        public static ref U128 disable(this ref U128 src, int pos)
        {
            if(pos < 64)
                Bits.disable(ref src.x0, pos);
            else
                Bits.disable(ref src.x1, pos);
            return ref src;
            
        }

        [MethodImpl(Inline)]
        public static ref I128 disable(this ref I128 src, int pos)
        {
            if(pos < 64)
                Bits.disable(ref src.x0, pos);
            else
                Bits.disable(ref src.x1, pos);
            return ref src;
            
        }

          [MethodImpl(Inline)]
          public static ref sbyte toggle(ref sbyte src, int pos)
          {
               src ^= LeftMask(src,pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static sbyte toggle(sbyte src, int pos)
               => toggle(ref src, pos);

          [MethodImpl(Inline)]
          public static ref byte toggle(ref byte src, int pos)
          {
               src ^= LeftMask(src,pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static byte toggle(byte src, int pos)
               => src ^= LeftMask(src,pos);

          [MethodImpl(Inline)]
          public static ref short toggle(ref short src, int pos)
          {
               src ^= LeftMask(src,pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static short toggle(short src, int pos)
               => src ^= LeftMask(src,pos);

          [MethodImpl(Inline)]
          public static ref ushort toggle(ref ushort src, int pos)
          {
               src ^= LeftMask(src,pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ushort toggle(ushort src, int pos)
               => src ^= LeftMask(src,pos);

          [MethodImpl(Inline)]
          public static ref int toggle(ref int src, int pos)
          {
               src ^= LeftMask(src,pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static int toggle(int src, int pos)
               => src ^= LeftMask(src,pos);


          [MethodImpl(Inline)]
          public static uint toggle(uint src, int pos)
               => src ^= LeftMask(src,pos);

          [MethodImpl(Inline)]
          public static ref uint toggle(ref uint src, int pos)
          {
               src ^= LeftMask(src,pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static long toggle(long src, int pos)
               => src ^= LeftMask(src,pos);

          [MethodImpl(Inline)]
          public static ref long toggle(ref long src, int pos)
          {
               src ^= LeftMask(src,pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ulong toggle(ulong src, int pos)
               => src ^= LeftMask(src,pos);

          [MethodImpl(Inline)]
          public static ref ulong toggle(ref ulong src, int pos)
          {
               src ^= LeftMask(src,pos);
               return ref src;
          } 
    }
}