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

          [MethodImpl(Inline)]
          public static ref sbyte enable(ref sbyte src, in BitPos pos)
          {
               src |= (sbyte)(1 << pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref byte enable(ref byte src, in BitPos pos)
          {
               src |= (byte)(1 << pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref short enable(ref short src, in BitPos pos)
          {
               src |= (short)(1 << pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref ushort enable(ref ushort src, in BitPos pos)
          {
               src |= (ushort)(1 << pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref int enable(ref int src, in BitPos pos)
          {
               src |= (1 << pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref uint enable(ref uint src, in BitPos pos)
          {
               src |= (1u << pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref long enable(ref long src, in BitPos pos)
          {
               src |= (1L << pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref ulong enable(ref ulong src, in BitPos pos)
          {
               src |= (1ul << pos);
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref float enable(ref float src, in BitPos pos)
          {
               var srcBits = BitConverter.SingleToInt32Bits(src);
               srcBits |= 1 << pos;
               src = BitConverter.Int32BitsToSingle(srcBits);            
               return ref src;
          }

          [MethodImpl(Inline)]
          public static ref double enable(ref double src, in BitPos pos)
          {               
               var srcBits = BitConverter.DoubleToInt64Bits(src);
               srcBits |= 1L << pos;
               src = BitConverter.Int64BitsToDouble(srcBits);                           
               return ref src;
          }

          [MethodImpl(Inline)]
          public static sbyte enable(sbyte src, BitPos pos)
            =>  src |= (sbyte)(1 << pos);
               
          [MethodImpl(Inline)]
          public static byte enable(byte src, BitPos pos)
            =>  src |= (byte)(1 << pos);

          [MethodImpl(Inline)]
          public static short enable(short src, BitPos pos)
            =>  src |= (short)(1 << pos);
               
          [MethodImpl(Inline)]
          public static ushort enable(ushort src, BitPos pos)
            =>  src |= (ushort)(1 << pos);

          [MethodImpl(Inline)]
          public static int enable(int src, BitPos pos)
            =>  src |= (1 << pos);

          [MethodImpl(Inline)]
          public static uint enable(uint src, BitPos pos)
            =>  src |= (1u << pos);

          [MethodImpl(Inline)]
          public static long enable(long src, BitPos pos)
            =>  src |= (1L << pos);

          [MethodImpl(Inline)]
          public static ulong enable(ulong src, BitPos pos)
            =>  src |= (1ul << pos);

     }
}